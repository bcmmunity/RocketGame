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

        public string Make(Move Move, string Key, int TeamId)
        {
            if (Move.Type == "PowerUp" || Move.Type == "IntellectUP" || Move.Type == "Gather" || Move.Type == "Gift" || Move.Type == "Attack")
            {
                Move.User = db.Users.Where(n => n.Key == Key).FirstOrDefault();
                Move.Tick = db.Ticks.Last();
                Move.Time = DateTime.Now;
                Move.To = db.Teams.Find(TeamId);
                db.SaveChanges();

                Tick LastTick = db.Ticks.Last();

                if (db.Settings.FirstOrDefault().TeamCount * db.Settings.FirstOrDefault().TeamSize == db.Moves.Where(n => n.Tick == LastTick).Count())
                {

                    AddTick();
                }

                return "Ход зафиксирован";
            }
            else
            {
                return "Ошибка";
            }
        }

        public void TickChecker(object x)
        {
            int number = (int)x;
            Unit();

            //db1.Logs.Add(new Log { Msg = "TickChecker " + x.ToString() });
            //db1.SaveChanges();

            timer.Dispose();
            if (db1.Ticks.Last().Number == number)
            {
                AddTick();
            }
        }

        public Timer timer;
        public Timer ftimer;

        public void Timer()
        {
            Unit();

            //db1.Logs.Add(new Log { Msg = "T" + db1.Ticks.Last().Number.ToString()});
            //db1.SaveChanges();

            TimerCallback tm = new TimerCallback(TickChecker);
            timer = new Timer(tm, db1.Ticks.Last().Number, 60000 * db1.Settings.FirstOrDefault().TimeTick, 30000);
        }

        public void FTimer()
        {
            Unit();

            //db1.Logs.Add(new Log { Msg = "FT" });
            //db1.SaveChanges();

            TimerCallback tm = new TimerCallback(FinishGame);
            timer = new Timer(tm, null, 100 + 60000 * db1.Settings.FirstOrDefault().TimeGame, 3000000000);
        }

        static MyContext db1;
        //private static MyContext db = new MyContext(optionsBuilder.Options);

        public static void Unit()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersstoredb;Trusted_Connection=True;MultipleActiveResultSets=true");
            db1 = new MyContext(optionsBuilder.Options);
        }



        public string StartGame()
        {
            Tick Tick = new Tick();
            Tick.Number = 1;
            Tick.Start = DateTime.Now;
            db.Ticks.Add(Tick);
            db.SaveChanges();
            Timer();
            FTimer();

            return "Игра началась";
        }

        public string AddTick()
        {
            Unit();
            if (db1.Settings.Last().IsFinished)
            {
                return "Игра окончена";
            }
            db1.Ticks.Last().Finish = DateTime.Now;
            Tick Tick = new Tick();
            Tick.Number = db1.Ticks.Last().Number + 1;
            Tick.Start = DateTime.Now;
            db1.Ticks.Add(Tick);
            //db1.Logs.Add(new Log { Msg = "AddTick" });
            db1.SaveChanges();
            Timer();

            return "Начался новый такт";
        }

        public void FinishGame(object o)
        {
            //db1.Logs.Add(new Log { Msg = "Dispose FTimer" });
            ftimer.Dispose();
            //db1.Logs.Add(new Log { Msg = "Dispose Timer" });
            timer.Dispose();
            Unit();
            db1.Ticks.Last().Finish = DateTime.Now;
            db1.Settings.Last().IsFinished = true;
            db1.SaveChanges();

            //return "Игра закончилась!";
        }


        public void AttackGroupResult(int attacker, int[] ids, int[] power, Team target)
        {
            int result = (power[attacker] - target.Power);
            if (result > 0)
            {
                if (target.Fuel >= result * 2)
                {
                    db.Teams.Where(n => n.TeamId == ids[attacker]).FirstOrDefault().Fuel += result * 2;
                    db.Teams.Where(m => m.TeamId == target.TeamId).FirstOrDefault().Fuel = target.Fuel - result * 2;
//                    db.SaveChanges();
                }
                else
                {
                    db.Teams.Where(n => n.TeamId == ids[attacker]).FirstOrDefault().Fuel += target.Fuel;
                    db.Teams.Find(target.TeamId).Fuel = 0;
//                    db.SaveChanges();
                }
            }
        }

        public void AttackRocketResult(int attacker, int defender, int[] power, Team target)
        {
            List<User> Users = db.Users.ToList();
            if ((power[attacker] - defender) > 0)
            {
                foreach (User user in db.Users.Where(n => n.Team.TeamId == target.TeamId))
                {
                    db.Users.Where(n => n.Team.TeamId == target.TeamId).FirstOrDefault().InRocket = false;
//                    db.SaveChanges();
                }
            }
        }

        public void Update()
        {
            List<Move> Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "powerup").ToList();
            foreach (Move item in Moves)
            {
                db.Users.Find(item.User.UserId).Power++;
                db.Teams.Find(item.User.Team.TeamId).Power++;
                db.SaveChanges();
            }

            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "intellectup").ToList();
            foreach (Move item in Moves)
            {
                db.Users.Find(item.User.UserId).Intellect++;
                db.SaveChanges();
            }

            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "gather").ToList();
            foreach (Move item in Moves)
            {
                db.Teams.Find(item.User.Team.TeamId).Fuel += db.Users.Find(item.User.UserId).Intellect;
                db.SaveChanges();
            }

            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "gift").ToList();
            List<Team> Teams = db.Teams.ToList();
            foreach (Team item in Teams)
            {
                foreach (Team item1 in Teams)
                {
                    if (Moves.Where(n => n.User.Team == item).Where(b => b.To == item1).Count() == db.Settings.FirstOrDefault().TeamSize)
                    {
                        db.Teams.Find(item1.TeamId).Fuel += db.Teams.Find(item.TeamId).Fuel;
                        db.Teams.Find(item.TeamId).Fuel = 0;
                        db.SaveChanges();
                    }
                }
            }


            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "getinrocket").ToList();
            int count = 0;
            int[] powint = new int[db.Settings.FirstOrDefault().TeamSize]; //Сила+Интеллект Игрока
            int[] teamids = new int[5]; //ID Команд
            int[] userid = new int[db.Settings.FirstOrDefault().TeamSize];
            //            DateTime[] earlyteamid = new DateTime[5]; //Самый ранний ход КОМАНДЫ
            DateTime[] earlyuser = new DateTime[db.Settings.FirstOrDefault().TeamSize]; //Время хода игрока

            List<Team> Teams2 = db.Teams.ToList();
            foreach (Team team in Teams2)
            {
                if (Moves.Where(n => n.User.Team == team).FirstOrDefault() != null && Moves.Where(n => n.User.Team == team).Count() == db.Settings.FirstOrDefault().TeamSize)
                {

                    teamids[count] = team.TeamId;
                    count++;
                    //db.Logs.Add(new Log { Msg = "count method " + count.ToString() }); //LOGSSSSSSS
                    //db.SaveChanges();
                }
            }

            //db.Logs.Add(new Log { Msg = "count result " + count.ToString() }); //LOGSSSSSSS
            //db.SaveChanges();

            //db.Logs.Add(new Log { Msg = "TeamID = " + teamids[count - 1].ToString() }); //LOGSSSSSSS
            //db.SaveChanges();

            if (count > 0)
            {
                int winner = 0;
                bool fl = false;
                foreach (Move move in Moves.OrderBy(n => n.Time).ToList())
                {
                    //db.Logs.Add(new Log { Msg = "Moves exist " + move.ToString() }); //LOGSSSSSSS
                    //db.SaveChanges();

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

                //db.Logs.Add(new Log { Msg = "Победитель " + winner.ToString() }); //LOGSSSSSSS
                //db.SaveChanges();

                if (Moves.Where(m => m.User.Team.TeamId == winner).Count() == db.Settings.FirstOrDefault().RocketSize)
                {
                    foreach (Move winners in Moves.Where(m => m.User.Team.TeamId == winner).ToList())
                    {
                        db.Users.Find(winners.User.UserId).InRocket = true;
                        db.SaveChanges();
                    }
                }
                else
                {
                    int countwinner = 0; //кол-во игроков в команде победивших
                    int c = db.Settings.FirstOrDefault().RocketSize;
                    foreach (Move move in Moves.Where(m => m.User.Team.TeamId == winner).OrderBy(k => k.Time).ToList())
                    {

                        powint[countwinner] += move.User.Power + move.User.Intellect;
                        userid[countwinner] = move.User.UserId;
                        countwinner++;
                    }

                    //db.Logs.Add(new Log { Msg = "Людей " + countwinner.ToString() }); //LOGSSSSSSS
                    //db.SaveChanges();

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

                    db.Logs.Add(new Log { Msg = userid[0].ToString() + " " + powint[0] }); //LOGSSSSSSS
                    db.SaveChanges();

                    db.Logs.Add(new Log { Msg = userid[2].ToString() + " " + powint[2] }); //LOGSSSSSSS
                    db.SaveChanges();

                    int index = db.Settings.FirstOrDefault().RocketSize;
                    int borders = index - 1;
                    int borderf = index;
                    bool g = true;

                    db.Logs.Add(new Log { Msg = "Finish " + borderf.ToString() + " Start" + borders.ToString() }); //LOGSSSSSSS
                    db.SaveChanges();

                    if (powint[index - 1] != powint[index])
                    {
                        g = false;
                        for (int s = 0; s < index; s++)
                        {
                            db.Users.Where(m => m.UserId == userid[s]).FirstOrDefault().InRocket = true;
                            db.SaveChanges();
                        }
                    }

                    if (g)
                    {
                        while (powint[index - 1] == powint[index])
                        {
                            borders = index - 1;
                            index--;
                        }

                        //db.Logs.Add(new Log { Msg = "S" + borders.ToString() }); //LOGSSSSSSS
                        //db.SaveChanges();

                        while (powint[index + 1] == powint[index])
                        {
                            if (index + 1 > powint.Length)
                            {
                                borderf = index + 1;
                                index++;
                            }
                            break;
                        }

                        //db.Logs.Add(new Log { Msg = "F" + borderf.ToString() }); //LOGSSSSSSS
                        //db.SaveChanges();

                        //db.Logs.Add(new Log { Msg = "UserID[0] = " + userid[0].ToString() }); //LOGSSSSSSS
                        //db.SaveChanges();

                        //db.Logs.Add(new Log { Msg = "UserID[1] = " + userid[1].ToString() }); //LOGSSSSSSS
                        //db.SaveChanges();

                        for (int s = 0; s <= borders; s++)
                        {
                            db.Users.Where(m => m.UserId == userid[s]).FirstOrDefault().InRocket = true; //Error
                            db.SaveChanges();
                        }
                        for (int h = borders; h <= borderf; h++)
                        {
                            earlyuser[h] = db.Moves.Where(a => a.User.UserId == userid[h]).FirstOrDefault().Time;
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
                        for (int b = 0; b < db.Settings.FirstOrDefault().RocketSize - borders; b++)
                        {
                            db.Users.Where(m => m.UserId == userid[b]).FirstOrDefault().InRocket = true;
                            db.SaveChanges();
                        }
                    }
                }
            }

            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackgroup").ToList();
            List<User> Users = db.Users.ToList();
            List<Team> Teams1 = db.Teams.ToList();
            foreach (Team target in Teams)
            {
                db.Logs.Add(new Log { Msg = target.Name });
                db.SaveChanges();

                if (Users.Where(b => b.Team == target).Where(a => a.InRocket == false).Count() != 0 )
                {
                    int i = 0; //кол-во атакующих команд
                    int[] power = new int[5]; //Сила Команд
                    int[] ids = new int[5]; //ID Команд
                    DateTime[] earlyuserid = new DateTime[5]; //Самый ранний ход команды

                    foreach (Team team in Teams1)
                    {
                        db.Logs.Add(new Log { Msg = team.Name });
                        db.SaveChanges();

                        if (Moves.Where(n => n.User.Team == team).Where(n => n.To == target).FirstOrDefault() != null)
                        {
                            db.Logs.Add(new Log { Msg = team.Name });
                            db.SaveChanges();

                            //db.Logs.Add(new Log { Msg = "Exist Check: null" });//Moves.Where(n => n.User.Team == team).FirstOrDefault().Time.ToString() }); //LOGSSSSSSS
                            //db.SaveChanges();

                            //db.Logs.Add(new Log { Msg = "Exist Check: exist" });//Moves.Where(n => n.User.Team == team).FirstOrDefault().Time.ToString() }); //LOGSSSSSSS
                            //db.SaveChanges();

                            earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
                            ids[i] = team.TeamId;

                            foreach (Move attacker in Moves.Where(n => n.User.Team == team).Where(m => m.To == target).ToList())
                            {
                                db.Logs.Add(new Log { Msg = "To = " + attacker.To.Name.ToString() });//Moves.Where(n => n.User.Team == team).FirstOrDefault().Time.ToString() }); //LOGSSSSSSS
                                db.SaveChanges();

                                db.Logs.Add(new Log { Msg = "User " + attacker.User.Name.ToString() + " P = " + attacker.User.Power.ToString() });//Moves.Where(n => n.User.Team == team).FirstOrDefault().Time.ToString() }); //LOGSSSSSSS
                                db.SaveChanges();

                                db.Logs.Add(new Log { Msg = "It works" });
                                db.SaveChanges();

                                if (attacker.Time < earlyuserid[i])
                                {
                                    earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
                                }
                                power[i] = power[i] + attacker.User.Power;

                                db.Logs.Add(new Log { Msg = "power[" + i + "] = " + power[i].ToString() });
                                db.SaveChanges();
                            }
                            //}
                            i++;
                        }
                    }
                       

                    db.Logs.Add(new Log { Msg = i.ToString() });
                    db.SaveChanges();

                    db.Logs.Add(new Log { Msg = "Power = " + power[0].ToString() + " Time = " + earlyuserid[0] });//Moves.Where(n => n.User.Team == team).FirstOrDefault().Time.ToString() }); //LOGSSSSSSS
                    db.SaveChanges();

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

                    if (equalcount == 1)
                    {
                        AttackGroupResult(0, ids, power, target);
                        db.SaveChanges();
                    }

                    if (equalcount == 2)
                    {

                        if (earlyuserid[0] < earlyuserid[1])
                        {
                            AttackGroupResult(0, ids, power, target);
                            db.SaveChanges();
                        }
                        else
                        {
                            AttackGroupResult(1, ids, power, target);
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
                        AttackGroupResult(0, ids, power, target);
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
                        AttackGroupResult(0, ids, power, target);
                        db.SaveChanges();
                    }
                }
            }


            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackrocket").ToList(); //Можно сократить
            foreach (Team target in Teams)
            {
                if (Users.Where(b => b.Team == target).Where(a => a.InRocket == true).Count() == db.Settings.FirstOrDefault().RocketSize)
                {
                    int i = 0;
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

                    if (equalcount == 1)
                    {
                        AttackRocketResult(0, defendpower, power, target);
                        db.SaveChanges();
                    }

                    if (equalcount == 2)
                    {

                        if (earlyuserid[0] < earlyuserid[1])
                        {
                            AttackRocketResult(0, defendpower, power, target);
                            db.SaveChanges();
                        }
                        else
                        {
                            AttackRocketResult(1, defendpower, power, target);
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
                        AttackRocketResult(0, defendpower, power, target);
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
                        AttackRocketResult(0, defendpower, power, target);
                        db.SaveChanges();
                    }
                }
            }
            if (db.Users.Where(n => n.InRocket == true).Count() == db.Settings.FirstOrDefault().RocketSize)
            {
                FinishGame(null);
            }

        }


        public string Check()
        {
            Tick tick = new Tick();
            Setting setting = new Setting();

            //Настройки
            setting.RocketFuel = 2;
            setting.RocketSize = 3;
            setting.TeamCount = 2;
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

            User user6 = new User();
            user6.Team = db.Teams.Where(b => b.Name == "Yellow").FirstOrDefault();
            user6.Name = "Player23";
            user6.Power = 2;
            user6.Intellect = 2;
            db.Users.Add(user6);

            db.SaveChanges();

            //Добавление Тактов
            tick.Number = 1;
            db.Ticks.Add(tick);

            db.SaveChanges();

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