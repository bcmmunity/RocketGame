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
    //[Route("api/[controller]")]
    //[ApiController]
    public class TickController : Controller
    {
        private MyContext db;

        public TickController()
        {
			Unit();
            db = db1;
        }

		static MyContext db1;

		public void Unit()
		{
			var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersstoredb;Trusted_Connection=True;MultipleActiveResultSets=true");
			//optionsBuilder.UseSqlServer("Server=localhost;Database=u0641156_rocketbot;User Id = u0641156_rocketbot; Password = Rocketbot1!");

			db1 = new MyContext(optionsBuilder.Options);
		}

		public IActionResult Game()
        {
			ViewBag.Link = db.Settings.Last().Link;
            string[,] users = new string[db.Users.Count(), 4];
            int i = 0;

            foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
            {
                foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(b => b.UserId).ToList())
                {
                    users[i, 0] = GroupTranslator(team.Name) + " (" + team.Fuel.ToString() + ")";
                    //users[i, 1] = team.Fuel.ToString();
                    users[i, 2] = user.Name;
                    users[i, 3] = user.Power.ToString() + "/" + user.Intellect.ToString();
                    i++;
                }

            }


			if (db.Settings.FirstOrDefault() != null)
			{
				ViewBag.timeE = (db.Settings.FirstOrDefault().GameEnd - DateTime.Now).TotalSeconds;
				ViewBag.time = db.Settings.FirstOrDefault().TimeTick;
			}
			else
			{
				ViewBag.time = 0;
				ViewBag.timeE = 0;
			}

			if (db.Ticks.FirstOrDefault() != null)
			{
				ViewBag.timedif = (DateTime.Now - db.Ticks.Last().Start).TotalSeconds;
			}
			else
			{
				ViewBag.timedif = 0;
			}

			ViewBag.i = i;
			ViewBag.users = users;
			ViewBag.Promo = db.Settings.FirstOrDefault().Promo;

			return View();
        }

        public IActionResult GetTick(int type)
		{
			ViewBag.type = type;
			string[,] users = new string[db.Users.Count(), 4];
			int i = 0;

			foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
			{
				foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(b => b.UserId).ToList())
				{
					users[i, 0] = GroupTranslator(team.Name) + " (" + team.Fuel.ToString() + ")";
					//users[i, 1] = team.Fuel.ToString();
					users[i, 1] = user.Name;
					users[i, 2] = user.Power.ToString() + "/" + user.Intellect.ToString();
					i++;
				}

			}

			ViewBag.i = i;
			ViewBag.users = users;

			int ticks = db.Ticks.Count();
			if (!db.Settings.Last().IsFinished)
			{
				ticks--;
			}

			if (db.Settings.Last().IsPaused)
			{
				ticks++;
			}

			if (db.Settings.FirstOrDefault() != null)
			{
				ViewBag.timeE = (db.Settings.FirstOrDefault().GameEnd - DateTime.Now).TotalSeconds;
				ViewBag.time = db.Settings.FirstOrDefault().TimeTick;
			}
			else
			{
				ViewBag.time = 0;
				ViewBag.timeE = 0;
			}

			if (db.Ticks.FirstOrDefault() != null)
			{
				ViewBag.timedif = (DateTime.Now - db.Ticks.Last().Start).TotalSeconds;
			}
			else
			{
				ViewBag.timedif = 0;
			}

			ViewBag.movesJ =  ticks;
			ViewBag.movesI = db.Users.Count();
			string[,] moves = new string[ticks, db.Users.Count()];
			string[] stats = new string[db.Users.Count()];
			
			i = 0;

			for (int j = 0; j < ticks; j++)
			{
				foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
				{
					foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(n => n.UserId).ToList())
					{
						foreach (Move move in db.Moves.Where(n => n.User == user).Where(b => b.Tick.Number == j + 1).Include(n => n.User).ToList())
						{
							if (move != null)
							{
								stats[i] = users[i, 2];
								moves[j, i] = Translator(move);
							}
						}
						i++;
					}
				}
				i = 0;
			}

			ViewBag.stats = stats;
			ViewBag.moves = moves;

			return View();
        }

        #region Переводчик

        public string Translator(Move move)
        {
            string result = "Move";

			if (move.Type == "powerup")
			{
				result = "У";
			}

			if (move.Type == "intellectup")
			{
				result = "О";
			}

			if (move.Type == "gather")
			{
				result = "Т";
			}

			if (move.Type == "gift")
            {
                if (move.Result == "Подарили")
                {
                    result = "Д" + GroupTranslator(move.To.Name) + ":V";
                }
                else
                {
                    result = "Д" + GroupTranslator(move.To.Name) + ":X";
                }
            }

			if (move.Type == "getinrocket")
			{
				if (move.Result == "Победа")
				{
					result = "Р:П";
				}
				else if (move.Result == "Выбит")
				{

					result = "Р:В";
				}
				else
				{
					result = "Р";
				}
			}

			if (move.Type == "attackgroup")
            {
                if (move.Result == "Победа")
                {
                    result = "А" + GroupTranslator(move.To.Name) + ":W";
                }
                else
                {
                    result = "А" + GroupTranslator(move.To.Name) + ":L";
                }
            }

            if (move.Type == "attackrocket")
            {
                if (move.Result == "Победа")
                {
                    result = "АР" + ":W";
                }
                else
                {
                    result = "АР" + ":L";
                }
            }

			return result;
        }

        public string GroupTranslator(string team)
        {
            string result = "Group";

            if(team == "Красные")
            {
                result = "К";
            }
            else if (team == "Зеленые")
            {
                result = "З";
            }
            else if (team == "Синие")
            {
                result = "С";
            }
            else if (team == "Желтые")
            {
                result = "Ж";
            }
            else if (team == "Фиолетовые")
            {
                result = "Ф";
            }

            return result;
        }

        #endregion
    }
}