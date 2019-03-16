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
			//optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersstoredb;Trusted_Connection=True;MultipleActiveResultSets=true");
			optionsBuilder.UseSqlServer("Server=localhost;Database=u0641156_rocketbot;User Id = u0641156_rocketbot; Password = Rocketbot1!");

			db1 = new MyContext(optionsBuilder.Options);
		}

		public IActionResult Game()
        {
            string[,] users = new string[db.Users.Count(), 4];
            int i = 0;

            foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
            {
                foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(b => b.UserId).ToList())
                {
                    users[i, 0] = team.Name;
                    users[i, 1] = team.Fuel.ToString();
                    users[i, 2] = user.Name;
                    users[i, 3] = user.Power.ToString() + "/" + user.Intellect.ToString();
                    i++;
                }

            }

			ViewBag.i = i;
			ViewBag.users = users;

            return View();
        }

        public IActionResult GetTick(int number)
        {
			if (number == db.Ticks.Last().Number - 1)
			{
				ViewBag.number = number + 1;
				string[] moves = new string[db.Users.Count()];
				int i = 0;

				foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
				{
					foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(n => n.UserId).ToList())
					{
						if (db.Moves.Where(n => n.User == user).Where(b => b.Tick == db.Ticks.Last()).FirstOrDefault() != null)
						{
							if (db.Moves.Where(n => n.User == user).Where(b => b.Tick == db.Ticks.Last()).FirstOrDefault().To == null)
							{
								moves[i] = CommonTranslate(db.Moves.Where(n => n.User == user).Where(b => b.Tick == db.Ticks.Last()).FirstOrDefault().Type);
							}
							else
							{
								moves[i] = Translator(db.Moves.Where(n => n.User == user).Where(b => b.Tick == db.Ticks.Last()).Include(m => m.User).FirstOrDefault());
							}
						}
						i++;
					}
				}

				ViewBag.moves = moves;

				return View();
			}
			else
			{
				return new EmptyResult();
			}
        }

        #region Переводчики

        public string Translator(Move move)
        {
            string result = "Move with result";

            if (move.Type == "gift")
            {
                if (move.Result == "Подарили")
                {
                    result = "Д-" + GroupTranslator(move.To.Name) + ":V";
                }
                else
                {
                    result = "Д-" + GroupTranslator(move.To.Name) + ":X";
                }
            }

            if (move.Type == "attackgroup")
            {
                if (move.Result == "Победа")
                {
                    result = "АГ-" + GroupTranslator(move.To.Name) + ":W";
                }
                else
                {
                    result = "АГ-" + GroupTranslator(move.To.Name) + ":L";
                }
            }

            if (move.Type == "attackrocket")
            {
                if (move.Result == "Победа")
                {
                    result = "АР-" + GroupTranslator(move.To.Name) + ":W";
                }
                else
                {
                    result = "АР-" + GroupTranslator(move.To.Name) + ":L";
                }
            }

            if (move.Type == "getinrocket")
            {
                result = "Р:В";
            }
            return result;
        }

        public string GroupTranslator(string team)
        {
            string result = "Group";

            if(team == "Красные")
            {
                result = "Кс";
            }
            else if (team == "Зеленые")
            {
                result = "Зл";
            }
            else if (team == "Синие")
            {
                result = "Сн";
            }
            else if (team == "Желтые")
            {
                result = "Жт";
            }
            else if (team == "Фиолетовые")
            {
                result = "Фв";
            }

            return result;
        }

        public string CommonTranslate(string move)
        {
            string result = "Move";
            
            if(move == "powerup")
            {
                result = "У";
            }
            else if(move == "intellectup")
            {
                result = "О";
            }
            else if(move == "gather")
            {
                result = "Т";
            }
            else if (move == "getinrocket")
            {
                result = "Р:П";
            }

            return result;
        }

        #endregion
    }
}