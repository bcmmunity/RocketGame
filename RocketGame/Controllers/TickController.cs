using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketGame.Models;

namespace RocketGame.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class TickController : Controller
    {
        private MyContext db;

        public TickController(MyContext context)
        {
            db = context;
        }

        public string[,] Stats()
        {
            string[,] stats = new string[db.Users.Count(), 2];
            int i = 0;

            foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
            {
                foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(b => b.UserId).ToList())
                {
                    stats[i, 0] = team.Fuel.ToString();
                    stats[i, 1] = user.Power.ToString() + "/" + user.Intellect.ToString();
                    i++;
                }

            }
            return stats;
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
								moves[i] = db.Moves.Where(n => n.User == user).Where(b => b.Tick == db.Ticks.Last()).FirstOrDefault().Type;
							}
							else
							{
								moves[i] = Transletor(db.Moves.Where(n => n.User == user).Where(b => b.Tick == db.Ticks.Last()).Include(m => m.User).FirstOrDefault());
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


        public string Transletor(Move move)
        {
            string result = "";
            if (move.Type == "gift")
            {
                if (move.Result == "Подарили")
                {
                    result = "Подарил команде " + move.To.Name + " топливо.";
                }
                else
                {
                    result = "Предпринял попытку подарить";
                }
            }

            if (move.Type == "attackgroup")
            {
                if (move.Result == "Победа")
                {
                    result = "Атака на " + move.To.Name + ": Победа.";
                }
                else
                {
                    result = "Атака на " + move.To.Name + ": Поражение.";
                }
            }

            if (move.Type == "attackrocket")
            {
                if (move.Result == "Победа")
                {
                    result = "Атака на ракету " + move.To.Name + ": Победа";
                }
                else
                {
                    result = "Атака на ракету " + move.To.Name + ": Поражение";
                }
            }

            if (move.Type == "getinrocket")
            {
                if(move.User.InRocket)
                {
                    result = "УЛЕТЕЛ";
                }
                else
                {
                    result = "Сел в ракету, но был выбит";
                }
            }

            return result;
        }


    }

}