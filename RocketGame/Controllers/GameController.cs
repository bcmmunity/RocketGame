using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using RocketGame.Models;

namespace RocketGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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

        public string StartGame()
        {
            Tick Tick = new Tick();
            Tick.Number = 1;
            Tick.Start = DateTime.Now;
            db.Ticks.Add(Tick);
            db.SaveChanges();

            return "Игра началась";
        }

        public string AddTick()
        {
            db.Ticks.Last().Finish = DateTime.Now;
            Tick Tick = new Tick();
            Tick.Number = ++db.Ticks.Last().Number;
            Tick.Start = DateTime.Now;
            db.Ticks.Add(Tick);
            db.SaveChanges();

            return "Начался новый такт";
        }

        public string FinishGame()
        {
            db.Ticks.Last().Finish = DateTime.Now;
            db.SaveChanges();

            return "Игра закончилась!";
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

            Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attack").ToList();
            foreach (Team item in Teams)
            {
                int power = 0;
                foreach (User item1 in db.Users.Where(n => n.Team == item).ToList())
                {
                    power += item1.Power;
                }
            }
        }
    }
}