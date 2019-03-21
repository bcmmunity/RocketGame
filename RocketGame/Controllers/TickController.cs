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

			if (number <= db.Ticks.Last().Number - 1 || (number == db.Ticks.Last().Number && db.Settings.FirstOrDefault().IsFinished))
			{
				ViewBag.number = number;
				string[] moves = new string[db.Users.Count()];
				i = 0;

				foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
				{
					foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(n => n.UserId).ToList())
					{
						foreach (Move move in db.Moves.Where(n => n.User == user).Where(b => b.Tick.Number == number).Include(n => n.User).ToList())
						if (move != null)
						{
							moves[i] = Translator(move);
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
                    result = "Д-" + GroupTranslator(move.To.Name) + ":V";
                }
                else
                {
                    result = "Д-" + GroupTranslator(move.To.Name) + ":X";
                }
            }

			if (move.Type == "getinrocket")
			{
				if (move.User.InRocket == true)
				{
					result = "Р:П";
				}
				else if (move.User.InRocket == false && move.Result == "Выбиты")
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

        #endregion
    }
}