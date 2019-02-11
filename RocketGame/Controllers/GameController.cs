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
            db1.Logs.Add(new Log { Msg = "TickChecker " + x.ToString() });
            db1.SaveChanges();
            timer.Dispose();
            if (db1.Ticks.Last().Number == number)
            {
                AddTick();
            }
            else
            {
                db1.Logs.Add(new Log { Msg = "ERRORRRR " + number.ToString() });
                db1.SaveChanges();
            }
        }

        public Timer timer;
        public Timer ftimer;

        public void Timer()
        {
            Unit();
            db1.Logs.Add(new Log { Msg = "T" + db1.Ticks.Last().Number.ToString()});
            db1.SaveChanges();
            TimerCallback tm = new TimerCallback(TickChecker);
            timer = new Timer(tm, db1.Ticks.Last().Number, 60000 * db1.Settings.FirstOrDefault().TimeTick, 30000);
        }

        public void FTimer()
        {
            Unit();
            db1.Logs.Add(new Log { Msg = "FT" });
            db1.SaveChanges();
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
            db1.Logs.Add(new Log { Msg = "AddTick" });
            db1.SaveChanges();
            Timer();

            return "Начался новый такт";
        }

        public void FinishGame(object o)
        {
            db1.Logs.Add(new Log { Msg = "Dispose FTimer" });
            ftimer.Dispose();
            db1.Logs.Add(new Log { Msg = "Dispose Timer" });
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
                    db.Teams.Find(target.TeamId).Fuel -= result * 2;
                    db.SaveChanges();
                }
                else
                {
                    db.Teams.Where(n => n.TeamId == ids[attacker]).FirstOrDefault().Fuel += target.Fuel;
                    db.Teams.Find(target.TeamId).Fuel = 0;
                    db.SaveChanges();
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
                    db.SaveChanges();
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
            foreach(Move item in Moves)
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

            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackgroup").ToList();
            List<User> Users = db.Users.ToList();
            foreach (Team target in Teams)
            {
                if (Users.Where(b => b.Team == target).Where(a=> a.InRocket == false).Count() == db.Settings.FirstOrDefault().TeamSize)
                {
                    int i = 0;
                    int[] power = new int[5]; //Сила Команд
                    int[] ids = new int[5]; //ID Команд
                    DateTime[] earlyuserid = new DateTime[5]; //Самый ранний ход команды

                    foreach (Team team in Teams)
                    {
                        foreach (User attacker in db.Users.Where(n => n.Team == team).ToList())
                        {
                            earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
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
                        i++;
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
                        AttackGroupResult(0, ids, power, target);
                    }

                    if (equalcount == 2)
                    {

                        if (earlyuserid[0] < earlyuserid[1])
                        {
                            AttackGroupResult(0, ids, power, target);
                        }
                        else
                        {
                            AttackGroupResult(1, ids, power, target);
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
                    }
                }
            }

            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "getinrocket").ToList();
            foreach (Team team in Teams)
            {
                if (Moves.Where(b => b.User.Team == team).Count() == db.Settings.FirstOrDefault().TeamSize
                    && team.Fuel >= db.Settings.FirstOrDefault().RocketFuel)
                {
                    foreach (Team tocompare in Moves.FirstOrDefault().User.Team)
                    {
                        db.Users.Find(user.UserId).InRocket = true;
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
                        foreach (User attacker in db.Users.Where(n => n.Team == team).ToList())
                        {
                            earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
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
                    }

                    if (equalcount == 2)
                    {

                        if (earlyuserid[0] < earlyuserid[1])
                        {
                            AttackRocketResult(0, defendpower, power, target);
                        }
                        else
                        {
                            AttackRocketResult(1, defendpower, power, target);
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
                    }
                }
            }
        }
    }
}