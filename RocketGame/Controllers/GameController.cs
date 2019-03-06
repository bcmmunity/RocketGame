using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using RocketGame.Models;

namespace RocketGame.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class GameController : ControllerBase
    {
        private MyContext db;

        public GameController(MyContext context)
        {
            db = context;
        }

        //public DateTime EndGameTime = db1.Ticks.Where(n => n.Number == 1).FirstOrDefault().Start.AddMinutes(db1.Settings.Last().TimeGame);

        public List<Team> GroupList()
        {
            return db.Teams.ToList();
        }

        public void Make(Move Move, string Key, int TeamId)
        {
            if (Move.Type == "powerup" || Move.Type == "intellectup" || Move.Type == "gather" || Move.Type == "gift" || Move.Type == "attackgroup" || Move.Type == "attackrocket" || Move.Type == "getinrocket")
            {
                db.Logs.Add(new Log { Msg = Move.Type });
                db.SaveChanges();

                Move.User = db.Users.Where(n => n.Key == Key).FirstOrDefault();
                Move.Tick = db.Ticks.Last();
                Move.Time = DateTime.Now;
                Move.To = db.Teams.Find(TeamId);
				db.Moves.Add(Move);
                db.SaveChanges();

                Tick LastTick = db.Ticks.Last();

                db.Logs.Add(new Log { Msg = db.Users.Where(n => n.Key == Key).FirstOrDefault().Key });
                db.SaveChanges();

                if (db.Settings.FirstOrDefault().TeamCount * db.Settings.FirstOrDefault().TeamSize == db.Moves.Where(n => n.Tick == LastTick).Count())
                {
                    db.Logs.Add(new Log { Msg = "Move check done" });
                    db.SaveChanges();

                    AddTick();
                }
            }
        }


        #region ForTimers

        //public void TickChecker(object x)
        //{
        //    int number = (int)x;
        //    //Unit();

        //    db.Logs.Add(new Log { Msg = "Таймер " + number.ToString() + " конец" });
        //    db.SaveChanges();
        //    //timer.Dispose();
        //    if (db.Ticks.Last().Number == number)
        //    {
        //        AddTick();
        //    }
        //    else
        //    {
        //        db.Logs.Add(new Log { Msg = "ERRORRRR " + number.ToString() });
        //    }
        //    db.SaveChanges();
        //}

        //public static Timer timer;
        //public Timer ftimer;

        //public void Timer()
        //{
        //    //Unit();

        //    db.Logs.Add(new Log { Msg = "Таймер пуск" });
        //    db.SaveChanges();

        //    TimerCallback tm = new TimerCallback(TickChecker);
        //    timer = new Timer(tm, db.Ticks.Last().Number, 60000 * db.Settings.FirstOrDefault().TimeTick, Timeout.Infinite);
        //    db.Logs.Add(new Log { Msg = "Таймер запустился" });
        //    db.SaveChanges();
        //}

        //public void FTimer()
        //{
        //    db.Logs.Add(new Log { Msg = "Финиш Таймер пуск" });
        //    db.SaveChanges();

        //    TimerCallback tm = new TimerCallback(FinishGame);
        //    ftimer = new Timer(tm, null, 60000 * db.Settings.FirstOrDefault().TimeGame, Timeout.Infinite);

        //    db.Logs.Add(new Log { Msg = "Финиш Таймер апустился" });
        //    db.SaveChanges();
        //}

        #endregion

        static MyContext db1;

        public static void Unit()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
			//optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersstoredb;Trusted_Connection=True;MultipleActiveResultSets=true");
			optionsBuilder.UseSqlServer("Server=localhost;Database=u0641156_rocketbot;User Id = u0641156_rocketbot; Password = Rocketbot1!");

			db1 = new MyContext(optionsBuilder.Options);
        }

		[HttpGet]
        public string StartGame()
        {
            db.Logs.Add(new Log { Msg = "Game started" });
            db.SaveChanges();

            Tick Tick = new Tick();
            Tick.Number = 1;
            Tick.Start = DateTime.Now;
            db.Ticks.Add(Tick);

            //FTimer();
            //Timer();

            //GSheetsController gsheets = new GSheetsController(db);
            //gsheets.InsertUsers();

            db.Logs.Add(new Log { Msg = "Start game end" });
            db.Settings.FirstOrDefault().IsStarted = true;
            db.SaveChanges();

            return "Игра началась";
		}

        #region Checks

        public void TimeCheck()
        {
            if (db.Settings.Last().IsFinished == false)
            {
                if (DateTime.Now >= db.Ticks.Where(n => n.Number == 1).FirstOrDefault().Start.AddMinutes(db.Settings.Last().TimeGame) 
                    && DateTime.Now >= db.Ticks.Last().Start.AddMinutes(db.Settings.Last().TimeTick))
                {
                    FinishGame();
                }
                else if (DateTime.Now >= db.Ticks.Last().Start.AddMinutes(db.Settings.Last().TimeTick))
                {
                    AddTick();
                }
            }
        }

        public bool LastTickCheck()
        {
            if (db.Ticks.Last().Finish.AddMinutes(db.Settings.Last().TimeTick) 
                >= db.Ticks.Where(n => n.Number == 1).FirstOrDefault().Start.AddMinutes(db.Settings.Last().TimeGame))
            {
                return true;
            }
            return false;
        }

        public bool KeyCheck(string Key)
		{
			if (db.Users.Where(n => n.Key == Key).FirstOrDefault() != null)
			{
				return true;
			}
			return false;
		}

		public string GameCheck()
        {
            if(db.Settings.FirstOrDefault().IsStarted == false)
            {
                return "Игра еще не началась";
            }
            return "Игра началась";
        }

        public string MoveCheck(string Key)
        {
            if (db.Settings.FirstOrDefault().IsFinished)
            {
                return "Игра окончена";
            }

            if (db.Settings.FirstOrDefault().IsStarted == false)
            {
                return "Игра еще не началась";
            }

            if (db.Moves.Where(n => n.User.Key == Key).Where(l => l.Tick.Number == db.Ticks.Last().Number).FirstOrDefault() != null)
            {
                return "Ход сделан";
            }
            else
            {
                return "Ход не сделан";
            }
        }

        public bool RocketCheck(string Key)
        {
            if (db.Users.Where(n => n.Key == Key).Include(l => l.Team).FirstOrDefault().Team.Fuel >= db.Settings.FirstOrDefault().RocketFuel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Team> TeamList(string Key)
        {
            List<Team> teams = db.Teams.Where(n => n.TeamId != db.Users.Where(f => f.Key == Key).FirstOrDefault().Team.TeamId).ToList();
            return teams;
        }

        #endregion

        public string AddTick()
        {
            db.Logs.Add(new Log { Msg = "AddTick Start" });
            db.SaveChanges();

            Update();
            //GSheetsController gsheets = new GSheetsController(db);
            //gsheets.InsertTickResult();

            if (db.Settings.Last().IsFinished)
            {
                db.Logs.Add(new Log { Msg = "AddTick GameEnd" });
                db.SaveChanges();
                return "Игра окончена";
            }

            db.Ticks.Last().Finish = DateTime.Now;
            Tick Tick = new Tick();
            Tick.Number = db.Ticks.Last().Number + 1;
            Tick.Start = DateTime.Now;
            db.Ticks.Add(Tick);
            //Timer();

            db.Logs.Add(new Log { Msg = "AddTick End" });
            db.SaveChanges();

            return "Начался новый такт";
        }

        public void FinishGame()
        {
            db.Logs.Add(new Log { Msg = "FinishGame Done" });
            db.SaveChanges();

            //GSheetsController gsheets = new GSheetsController(db);
            //gsheets.InsertTickResult();

            db.Ticks.Last().Finish = DateTime.Now;
            db.Settings.Last().IsFinished = true;
            db.SaveChanges();
        }


        public void AttackGroupResult(int attacker, int[] ids, int[] power, Team target)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersstoredb;Trusted_Connection=True;MultipleActiveResultSets=true");
            //optionsBuilder.UseSqlServer("Server=localhost;Database=u0641156_rocketbot;User Id = u0641156_rocketbot; Password = Rocketbot1!");

            db1 = new MyContext(optionsBuilder.Options);


            int result = (power[attacker] - target.Power);
            if (result > 0)
            {
                if (target.Fuel >= result * 2)
                {
                    db1.Teams.Where(n => n.TeamId == ids[attacker]).FirstOrDefault().Fuel += result * 2;
                    db1.Teams.Where(m => m.TeamId == target.TeamId).FirstOrDefault().Fuel = target.Fuel - result * 2;
                    foreach (Move move in db1.Moves.Where(x => x.Type == "attackgroup").Where(c => c.User.Team.TeamId == ids[attacker]).ToList())
                    {
                        db1.Moves.Find(move.MoveId).Result = "Победа";
                        db1.SaveChanges();
                    }
                    
                }
                else
                {
                    db1.Teams.Where(n => n.TeamId == ids[attacker]).FirstOrDefault().Fuel += target.Fuel;
                    db1.Teams.Find(target.TeamId).Fuel = 0;
                    db1.SaveChanges();
                }
            }
            else
            {
                foreach (Move move in db1.Moves.Where(x => x.Type == "attackgroup").Where(c => c.User.Team.TeamId == ids[attacker]).ToList())
                {
                    db1.Moves.Find(move.MoveId).Result = "Проигрыш";
                }
            }
        }

        public void AttackRocketResult(int attacker, int defender, int[] ids, int[] power, Team target)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersstoredb;Trusted_Connection=True;MultipleActiveResultSets=true");
            //optionsBuilder.UseSqlServer("Server=localhost;Database=u0641156_rocketbot;User Id = u0641156_rocketbot; Password = Rocketbot1!");

            db1 = new MyContext(optionsBuilder.Options);

            db1.Logs.Add(new Log { Msg = "AttackRocketResult Start" });
            db1.Logs.Add(new Log { Msg = "Attacker power = " + power[attacker] });
            db1.Logs.Add(new Log { Msg = "2) Deffender power = " + defender });
            db1.Logs.Add(new Log { Msg = "Result = " + (power[attacker]-defender).ToString() });
            db1.Logs.Add(new Log { Msg = "Цель = " + target.Name });

            if ((power[attacker] - defender) > 0)
            {
                db1.Logs.Add(new Log { Msg = "If = true " });
                foreach (User user in db.Users.Where(n => n.Team.TeamId == target.TeamId))
                {
                    db1.Logs.Add(new Log { Msg = "user = " + user.InRocket.ToString() });
                    db1.Users.Find(user.UserId).InRocket = false;
                    db1.Moves.Where(m => m.User == user).FirstOrDefault().Result = "Выбиты";
                    db1.SaveChanges();
                }

                foreach (Move move in db1.Moves.Where(x => x.Type == "attackrocket").Where(c => c.User.Team.TeamId == ids[attacker]).ToList())
                {
                    db1.Moves.Find(move.MoveId).Result = "Победа";
                    db1.SaveChanges();
                }
            }
            else
            {
                db1.Logs.Add(new Log { Msg = "if = false" });
                foreach (Move move in db1.Moves.Where(x => x.Type == "attackrocket").Where(c => c.User.Team.TeamId == ids[attacker]).ToList())
                {
                    db1.Moves.Find(move.MoveId).Result = "Проигрыш";
                    db1.SaveChanges();
                }
            }

            db1.Logs.Add(new Log { Msg = "AttackRocetResult Finish" });
            db.SaveChanges();
        }

        public void Update()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersstoredb;Trusted_Connection=True;MultipleActiveResultSets=true");
            //optionsBuilder.UseSqlServer("Server=localhost;Database=u0641156_rocketbot;User Id = u0641156_rocketbot; Password = Rocketbot1!");

            db1 = new MyContext(optionsBuilder.Options);

            db1.Logs.Add(new Log { Msg = "Update Start ()" });
            List<Team> Teams = db1.Teams.ToList();
            List<Team> Teams1 = db1.Teams.ToList();
            List<User> Users = db1.Users.Include(f => f.Team).ToList();
            List<User> Users1 = db1.Users.Include(f => f.Team).ToList();

            #region PowerUp
            List<Move> Moves = db1.Moves.Where(n => n.Tick == db1.Ticks.Last()).Where(a => a.Type == "powerup").Include(f => f.User).Include(a => a.User.Team).ToList();
            foreach (Move item in Moves)
            {

                db1.Users.Find(item.User.UserId).Power++;
                db1.Teams.Find(item.User.Team.TeamId).Power++;
                db1.SaveChanges();
            }
            #endregion

            #region IntellectUp
            Moves = db1.Moves.Where(n => n.Tick == db1.Ticks.Last()).Where(a => a.Type == "intellectup").Include(f => f.User).ToList();
            foreach (Move item in Moves)
            {
                db1.Users.Find(item.User.UserId).Intellect++;
                db1.SaveChanges();
            }

            Moves = db1.Moves.Where(n => n.Tick == db1.Ticks.Last()).Where(a => a.Type == "gather").Include(f => f.User.Team).ToList();
            foreach (Move item in Moves)
            {
                db1.Teams.Find(item.User.Team.TeamId).Fuel += db1.Users.Find(item.User.UserId).Intellect;
                db1.SaveChanges();
            }
            #endregion

            #region Gift
            Moves = db1.Moves.Where(n => n.Tick == db1.Ticks.Last()).Where(a => a.Type == "gift").Include(f => f.User).Include(a => a.User.Team).ToList();
            foreach (Team item in Teams)
            {
                foreach (Team target in Teams)
                {
                    if (Moves.Where(n => n.User.Team == item).Where(b => b.To == target).Count() == db1.Settings.FirstOrDefault().TeamSize)
                    {
                        db1.Teams.Find(target.TeamId).Fuel += db1.Teams.Find(item.TeamId).Fuel;
                        db1.Teams.Find(item.TeamId).Fuel = 0;
                        foreach (Move move in db1.Moves.Where(x => x.Type == "gift").Where(c => c.User.Team == item).ToList())
                        {
                            db1.Moves.Find(move.MoveId).Result = "Подарили";
                        }
                        db1.SaveChanges();
                    }
                    else
                    {
                        foreach (Move move in db1.Moves.Where(x => x.Type == "gift").Where(c => c.User.Team == item).ToList())
                        {
                            db1.Moves.Find(move.MoveId).Result = "Неудача";
                        }
                    }
                }
            }
            #endregion

            #region GetInRocket
            Moves = db1.Moves.Where(n => n.Tick == db1.Ticks.Last()).Where(a => a.Type == "getinrocket").Include(f => f.User).Include(a => a.User.Team).ToList();
            int count = 0;
            int[] powint = new int[db1.Settings.FirstOrDefault().TeamSize]; //Сила+Интеллект Игрока
            int[] teamids = new int[5]; //ID Команд
            int[] userid = new int[db1.Settings.FirstOrDefault().TeamSize];
            //            DateTime[] earlyteamid = new DateTime[5]; //Самый ранний ход КОМАНДЫ
            DateTime[] earlyuser = new DateTime[db1.Settings.FirstOrDefault().TeamSize]; //Время хода игрока

            List<Team> Teams2 = db1.Teams.ToList();
            foreach (Team team in Teams2)
            {
                if (Moves.Where(n => n.User.Team == team).FirstOrDefault() != null && Moves.Where(n => n.User.Team == team).Count() == db1.Settings.FirstOrDefault().TeamSize)
                {
                    teamids[count] = team.TeamId;
                    count++;
                }
            }

            if (count > 0)
            {
                int winner = 0;
                bool fl = false;
                foreach (Move move in Moves.OrderBy(n => n.Time).ToList())
                {

                    for (int f = 0; f < count; f++)
                    {

                        if (teamids[f] == move.User.Team.TeamId)
                        {
                            winner = move.User.Team.TeamId;
                            fl = true;
                            break;
                        }

                        if (fl) break;
                    }
                    if (fl) break;
                }

                if (Moves.Where(m => m.User.Team.TeamId == winner).Count() == db1.Settings.FirstOrDefault().RocketSize)
                {
                    foreach (Move winners in Moves.Where(m => m.User.Team.TeamId == winner).ToList())
                    {
                        db1.Users.Find(winners.User.UserId).InRocket = true;
                        db1.SaveChanges();
                    }
                }
                else
                {
                    int countwinner = 0; //кол-во игроков в команде победивших
                    int c = db1.Settings.FirstOrDefault().RocketSize;
                    foreach (Move move in Moves.Where(m => m.User.Team.TeamId == winner).OrderBy(k => k.Time).ToList())
                    {

                        powint[countwinner] += move.User.Power + move.User.Intellect;
                        userid[countwinner] = move.User.UserId;
                        countwinner++;
                    }

                    for (int p = 0; p < countwinner; p++)
                    {
                        for (int k = 0; k < p; k++)
                        {
                            if (powint[k] < powint[p])
                            {
                                int t = powint[p];
                                powint[p] = powint[k];
                                powint[k] = t;

                                t = userid[p];
                                userid[p] = userid[k];
                                userid[k] = t;
                            }
                        }
                    }

                    int index = db1.Settings.FirstOrDefault().RocketSize;
                    int borders = index - 1;
                    int borderf = index;
                    bool g = true;

                    if (powint[index - 1] != powint[index])
                    {
                        g = false;
                        for (int s = 0; s < index; s++)
                        {
                            db1.Users.Where(m => m.UserId == userid[s]).FirstOrDefault().InRocket = true;
                            db1.SaveChanges();
                        }
                    }

                    if (g)
                    {
                        while (powint[index - 1] == powint[index])
                        {
                            borders = index - 1;
                            index--;
                        }

                        while (powint[index + 1] == powint[index])
                        {
                            if (index + 1 > powint.Length)
                            {
                                borderf = index + 1;
                                index++;
                            }
                            break;
                        }

                        for (int s = 0; s <= borders; s++)
                        {
                            db1.Users.Where(m => m.UserId == userid[s]).FirstOrDefault().InRocket = true; //Error
                            db1.SaveChanges();
                        }
                        for (int h = borders; h <= borderf; h++)
                        {
                            earlyuser[h] = db1.Moves.Where(a => a.User.UserId == userid[h]).FirstOrDefault().Time;
                        }
                        for (int l = borders + 1; l < borderf; l++) //Проверить (Сортировка на убывание времени)
                        {
                            for (int z = borders; z < l; z++)
                            {
                                if (earlyuser[z] > earlyuser[l])
                                {
                                    DateTime t = earlyuser[l];
                                    earlyuser[l] = earlyuser[z];
                                    earlyuser[z] = t;

                                    int n = powint[l];
                                    powint[l] = powint[z];
                                    powint[z] = n;

                                    n = userid[l];
                                    userid[l] = userid[z];
                                    userid[z] = n;
                                }
                            }
                        }
                        for (int b = 0; b < db1.Settings.FirstOrDefault().RocketSize - borders; b++)
                        {
                            db1.Users.Where(m => m.UserId == userid[b]).FirstOrDefault().InRocket = true;
                            db1.SaveChanges();
                        }
                    }
                }
            }
            #endregion

            #region AttackGroup
            Moves = db1.Moves.Where(n => n.Tick == db1.Ticks.Last()).Where(a => a.Type == "attackgroup").Include(f => f.User).Include(a => a.User.Team).ToList();
            foreach (Team target in Teams)
            {
                if (Users.Where(b => b.Team == target).Where(a => a.InRocket == false).Count() != 0 )
                {
                    int i = 0; //кол-во атакующих команд
                    int[] power = new int[5]; //Сила Команд
                    int[] ids = new int[5]; //ID Команд
                    DateTime[] earlyuserid = new DateTime[5]; //Самый ранний ход команды

                    foreach (Team team in Teams1)
                    {
                        if (Moves.Where(n => n.User.Team == team).Where(n => n.To == target).FirstOrDefault() != null)
                        {
                            earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
                            ids[i] = team.TeamId;

                            foreach (Move attacker in Moves.Where(n => n.User.Team == team).Where(m => m.To == target).ToList())
                            {
                                if (attacker.Time < earlyuserid[i])
                                {
                                    earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
                                }
                                power[i] = power[i] + attacker.User.Power;

                                db1.Logs.Add(new Log { Msg = "Attack Rocket power[" + i + "] = " + power[i].ToString() });
                                db1.SaveChanges();
                            }
                            i++;
                        }
                    }

                    for (int j = 1; j < i; j++)
                    {
                        for (int k = 0; k < j; k++)
                        {
                            if (power[k] < power[j])
                            {
                                int n = power[j];
                                power[j] = power[k];
                                power[k] = n;

                                n = ids[j];
                                ids[j] = ids[k];
                                ids[k] = n;

                                DateTime t = earlyuserid[j];
                                earlyuserid[j] = earlyuserid[k];
                                earlyuserid[k] = t;
                            }
                        }
                    }

                    int equalcount = 1; //Количество самых сильных
                    for (int j = 1; j < i; j++)
                    {
                        if (power[0] == power[j])
                        {
                            equalcount++;
                        }
                    }

                    if (equalcount == 1)
                    {
                        AttackGroupResult(0, ids, power, target);
                        db1.SaveChanges();
                    }

                    if (equalcount == 2)
                    {

                        if (earlyuserid[0] < earlyuserid[1])
                        {
                            AttackGroupResult(0, ids, power, target);
                            db1.SaveChanges();
                        }
                        else
                        {
                            AttackGroupResult(1, ids, power, target);
                            db1.SaveChanges();
                        }
                    }

                    if (equalcount == 3)
                    {
                        for (int j = 1; j < 3; j++) //Проверить (Сортировка на убывание времени)
                        {
                            for (int k = 0; k < j; k++)
                            {
                                if (earlyuserid[k] > earlyuserid[j])
                                {
                                    DateTime t = earlyuserid[j];
                                    earlyuserid[j] = earlyuserid[k];
                                    earlyuserid[k] = t;

                                    int n = power[j];
                                    power[j] = power[k];
                                    power[k] = n;

                                    n = ids[j];
                                    ids[j] = ids[k];
                                    ids[k] = n;
                                }
                            }
                        }
                        AttackGroupResult(0, ids, power, target);
                        db1.SaveChanges();
                    }

                    if (equalcount == 4)
                    {
                        for (int j = 1; j < 4; j++) //Проверить (Сортировка на убывание времени)
                        {
                            for (int k = 0; k < j; k++)
                            {
                                if (earlyuserid[k] > earlyuserid[j])
                                {
                                    DateTime t = earlyuserid[j];
                                    earlyuserid[j] = earlyuserid[k];
                                    earlyuserid[k] = t;

                                    int n = power[j];
                                    power[j] = power[k];
                                    power[k] = n;

                                    n = ids[j];
                                    ids[j] = ids[k];
                                    ids[k] = n;
                                }
                            }
                        }
                        AttackGroupResult(0, ids, power, target);
                        db1.SaveChanges();
                    }
                }
            }
            #endregion

            #region AttackRocket
            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackrocket").Include(f => f.User).Include(a => a.User.Team).Include(d => d.To).ToList(); //Можно сократить
            foreach (Team target in Teams)
            {
                if (Users1.Where(b => b.Team == target).Where(a => a.InRocket == true).Count() == db.Settings.FirstOrDefault().RocketSize)
                {
                    int i = 0; //Кол-во атакующих команд
                    int defendpower = 0;
                    int[] power = new int[5]; //Сила Команд
                    int[] ids = new int[5]; //ID Команд
                    DateTime[] earlyuserid = new DateTime[5]; //Самый ранний ход команды

                    foreach (Team team in Teams)
                    {
                        if (Moves.Where(n => n.User.Team == team).FirstOrDefault() != null)
                        {
                            earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
                            foreach (User attacker in db.Users.Where(n => n.Team == team).ToList())
                            {

                                if (Moves.Where(n => n.User.Team == team).FirstOrDefault().To == target)
                                {
                                    if (Moves.Where(n => n.User.Team == team).FirstOrDefault().Time < earlyuserid[i])
                                    {
                                        earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
                                    }
                                    ids[i] = team.TeamId;
                                    power[i] += attacker.Power;
                                }
                            }
                        }
                        i++;
                    }

                    foreach (User defender in db.Users.Where(n => n.Team == target).Where(s => s.InRocket == true).ToList())
                    {
                        defendpower += defender.Power;
                    }

                    for (int j = 1; j < i; j++) //Проверить (Сортировка)
                    {
                        for (int k = 0; k < j; k++)
                        {
                            if (power[k] < power[j])
                            {
                                int n = power[j];
                                power[j] = power[k];
                                power[k] = n;

                                n = ids[j];
                                ids[j] = ids[k];
                                ids[k] = n;

                                DateTime t = earlyuserid[j];
                                earlyuserid[j] = earlyuserid[k];
                                earlyuserid[k] = t;
                            }
                        }
                    }

                    int equalcount = 1; //Количество самых сильных
                    for (int j = 1; j < i; j++)
                    {
                        if (power[0] == power[j])
                        {
                            equalcount++;
                        }
                    }

                    db1.Logs.Add(new Log { Msg = "Equal = " + equalcount.ToString() + "  = " + i.ToString() });
                    db1.Logs.Add(new Log { Msg = "Defenders = " + defendpower.ToString() + " id = " + i.ToString() });
                    db1.SaveChanges();

                    if (equalcount == 1)
                    {
                        AttackRocketResult(0, defendpower, ids, power, target);
                        db.SaveChanges();
                    }

                    if (equalcount == 2)
                    {

                        if (earlyuserid[0] < earlyuserid[1])
                        {
                            AttackRocketResult(0, defendpower, ids, power, target);
                            db.SaveChanges();
                        }
                        else
                        {
                            AttackRocketResult(1, defendpower, ids, power, target);
                            db.SaveChanges();
                        }
                    }

                    if (equalcount == 3)
                    {
                        for (int j = 1; j < 3; j++) //Проверить (Сортировка на убывание времени)
                        {
                            for (int k = 0; k < j; k++)
                            {
                                if (earlyuserid[k] > earlyuserid[j])
                                {
                                    DateTime t = earlyuserid[j];
                                    earlyuserid[j] = earlyuserid[k];
                                    earlyuserid[k] = t;

                                    int n = power[j];
                                    power[j] = power[k];
                                    power[k] = n;

                                    n = ids[j];
                                    ids[j] = ids[k];
                                    ids[k] = n;
                                }
                            }
                        }
                        AttackRocketResult(0, defendpower, ids, power, target);
                        db.SaveChanges();
                    }

                    if (equalcount == 4)
                    {
                        for (int j = 1; j < 4; j++) //Проверить (Сортировка на убывание времени)
                        {
                            for (int k = 0; k < j; k++)
                            {
                                if (earlyuserid[k] > earlyuserid[j])
                                {
                                    DateTime t = earlyuserid[j];
                                    earlyuserid[j] = earlyuserid[k];
                                    earlyuserid[k] = t;

                                    int n = power[j];
                                    power[j] = power[k];
                                    power[k] = n;

                                    n = ids[j];
                                    ids[j] = ids[k];
                                    ids[k] = n;
                                }
                            }
                        }
                        AttackRocketResult(0, defendpower, ids, power, target);
                        db.SaveChanges();
                    }
                }
            }
            #endregion

            if (db1.Users.Where(n => n.InRocket == true).Count() == db1.Settings.FirstOrDefault().RocketSize)
            {
                FinishGame();
            }
        }
        

        public string Debug()
        {
            Tick tick = new Tick();
            Setting setting = new Setting();

            //Настройки
            setting.RocketFuel = 2;
            setting.RocketSize = 3;
            setting.TeamCount = 4;
            setting.TimeTick = 1;
            setting.TimeGame = 4;
            setting.TeamSize = 3;
            db.Settings.Add(setting);

            //Добавление групп

            //team.Name = "Красные";
            //team.Power = 5;
            //db.Teams.Add(team);

            Team team1 = new Team();
            team1.Name = "Blue";
            team1.Power = 3;
            team1.Fuel = 7;
            db.Teams.Add(team1);
            db.SaveChanges();

            Team team2 = new Team();
            team2.Name = "Yellow";
            team2.Power = 7;
            team2.Fuel = 2;
            db.Teams.Add(team2);
            db.SaveChanges();

            Team team3 = new Team();
            team3.Name = "Green";
            team3.Power = 3;
            team3.Fuel = 9;
            db.Teams.Add(team3);
            db.SaveChanges();

            Team team4 = new Team();
            team4.Name = "Red";
            team4.Power = 3;
            team4.Fuel = 5;
            db.Teams.Add(team4);
            db.SaveChanges();

            //Добавлене игроков

            User user1 = new User();
            user1.Team = db.Teams.Where(b => b.Name == "Blue").FirstOrDefault();
            user1.Name = "Player11";
            user1.Power = 1;
            user1.Intellect = 2;
            db.Users.Add(user1);
            db.SaveChanges();

            User user2 = new User();
            user2.Team = db.Teams.Where(b => b.Name == "Blue").FirstOrDefault();
            user2.Name = "Player12";
            user2.Power = 1;
            user2.Intellect = 3;
            db.Users.Add(user2);
            db.SaveChanges();

            User user3 = new User();
            user3.Team = db.Teams.Where(b => b.Name == "Blue").FirstOrDefault();
            user3.Name = "Player13";
            user3.Power = 1;
            user3.Intellect = 2;
            db.Users.Add(user3);
            db.SaveChanges();

            User user4 = new User();
            user4.Team = db.Teams.Where(b => b.Name == "Yellow").FirstOrDefault();
            user4.Name = "Player21";
            user4.Power = 1;
            user4.Intellect = 3;
            db.Users.Add(user4);
            db.SaveChanges();

            User user5 = new User();
            user5.Team = db.Teams.Where(b => b.Name == "Yellow").FirstOrDefault();
            user5.Name = "Player22";
            user5.Power = 4;
            user5.Intellect = 1;
            db.Users.Add(user5);
            db.SaveChanges();

            User user6 = new User();
            user6.Team = db.Teams.Where(b => b.Name == "Yellow").FirstOrDefault();
            user6.Name = "Player23";
            user6.Power = 2;
            user6.Intellect = 2;
            db.Users.Add(user6);
            db.SaveChanges();

            User user7 = new User();
            user7.Team = db.Teams.Where(b => b.Name == "Green").FirstOrDefault();
            user7.Name = "Player31";
            user7.Power = 1;
            user7.Intellect = 2;
            db.Users.Add(user7);
            db.SaveChanges();

            User user8 = new User();
            user8.Team = db.Teams.Where(b => b.Name == "Green").FirstOrDefault();
            user8.Name = "Player32";
            user8.Power = 1;
            user8.Intellect = 1;
            db.Users.Add(user8);
            db.SaveChanges();

            User user9 = new User();
            user9.Team = db.Teams.Where(b => b.Name == "Green").FirstOrDefault();
            user9.Name = "Player33";
            user9.Power = 1;
            user9.Intellect = 5;
            db.Users.Add(user9);
            db.SaveChanges();

            User user10 = new User();
            user10.Team = db.Teams.Where(b => b.Name == "Red").FirstOrDefault();
            user10.Name = "Player41";
            user10.Power = 1;
            user10.Intellect = 2;
            db.Users.Add(user10);
            db.SaveChanges();

            User user11 = new User();
            user11.Team = db.Teams.Where(b => b.Name == "Red").FirstOrDefault();
            user11.Name = "Player42";
            user11.Power = 1;
            user11.Intellect = 3;
            db.Users.Add(user11);
            db.SaveChanges();

            User user12 = new User();
            user12.Team = db.Teams.Where(b => b.Name == "Red").FirstOrDefault();
            user12.Name = "Player43";
            user12.Power = 1;
            user12.Intellect = 6;
            db.Users.Add(user12);
            db.SaveChanges();

            StartGame();

            //Добавление Тактов
            //tick.Number = 1;
            //db.Ticks.Add(tick);

            //Добавление действий
            Move move1 = new Move();
            move1.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move1.User = db.Users.Where(m => m.Name == "Player11").FirstOrDefault();
            move1.Type = "intellectup";
            //move1.To = db.Teams.Where(c => c.Name == "Yellow").FirstOrDefault();
            move1.Time = DateTime.Now;
            db.Moves.Add(move1);
            db.SaveChanges();

            Move move2 = new Move();
            move2.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move2.User = db.Users.Where(m => m.Name == "Player12").FirstOrDefault();
            move2.Type = "intellectup";
            //move2.To = db.Teams.Where(c => c.Name == "Yellow").FirstOrDefault();
            move2.Time = DateTime.Now;
            db.Moves.Add(move2);
            db.SaveChanges();

            Move move3 = new Move();
            move3.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move3.User = db.Users.Where(m => m.Name == "Player13").FirstOrDefault();
            move3.Type = "intellectup";
            //move3.To = db.Teams.Where(c => c.Name == "Yellow").FirstOrDefault();
            move3.Time = DateTime.Now;
            db.Moves.Add(move3);
            db.SaveChanges();

            Move move4 = new Move();
            move4.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move4.User = db.Users.Where(m => m.Name == "Player21").FirstOrDefault();
            move4.Type = "intellectup";
            //move4.To = db.Teams.Where(c => c.Name == "Blue").FirstOrDefault();
            move4.Time = DateTime.Now;
            db.Moves.Add(move4);
            db.SaveChanges();

            Move move5 = new Move();
            move5.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move5.User = db.Users.Where(m => m.Name == "Player22").FirstOrDefault();
            move5.Type = "attackgroup";
            move5.To = db.Teams.Where(c => c.Name == "Blue").FirstOrDefault();
            move5.Time = DateTime.Now;
            db.Moves.Add(move5);
            db.SaveChanges();

            Move move6 = new Move();
            move6.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move6.User = db.Users.Where(m => m.Name == "Player23").FirstOrDefault();
            move6.Type = "intellectup";
            move6.Time = DateTime.Now;
            db.Moves.Add(move6);
            db.SaveChanges();

            Update();

            
            //tick.Number = 2;
            //db.Ticks.Add(tick);

            //Update();

            //tick.Number = 3;
            //db.Ticks.Add(tick);
            //Update();

            return "Все хорошо!";
        }
    }
}