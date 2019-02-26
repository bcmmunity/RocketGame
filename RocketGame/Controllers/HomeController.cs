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
    public class HomeController : Controller
    {
        private MyContext db;

        public HomeController(MyContext context)
        {
            db = context;
        }

        #region Админ часть

        public IActionResult Admin()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Admin(AdminView data)
		{
			if (db.Admins.Where(a => a.Mail == data.Mail).FirstOrDefault() != null)
			{
				if (db.Admins.Where(a => a.Mail == data.Mail).FirstOrDefault().Password == data.Password)
				{
					ViewBag.Key = db.Admins.Where(a => a.Mail == data.Mail).FirstOrDefault().Key;
					return View("Setting");
				}

				ViewBag.msg = "Неверный пароль";
				return View();
			}
			ViewBag.msg = "Неверный логин";
			return View();
		}

		public IActionResult Setting(string Key)
		{
			return View();
		}

		[HttpPost]
        public IActionResult Setting(Setting settings, string Key)
        {
            if (settings.TeamCount > 5)
            {
                ViewBag.msg = "Количество команд должно быть не больше 5";
                return View();
            }

            if (settings.TeamCount * settings.TeamSize > 35)
            {
                ViewBag.msg = "Ошибка!</br>Должно быть не больше 35 игроков";
                return View();
            }
            string[] colors = { "Красные", "Синие", "Желтые", "Зеленые", "Оранжевые" };
            for (int i = 0; i < settings.TeamCount; i++)
            {
                Team team = new Team();
                team.Name = colors[i];
                db.Teams.Add(team);
            }
			Random a = new Random();
			settings.Promo = "КОД";
            settings.IsFinished = false;
            settings.IsStarted = false;
            db.Settings.Add(settings);
            db.SaveChanges();
            ViewBag.Key = Key;

            return RedirectToAction("ShowUsers", new { Key = Key });
        }

        public IActionResult ShowUsers(string Key)
        {
			if (db.Admins.FirstOrDefault().Key != Key)
			{
				return View("Index");
			}
            ViewBag.Key = Key;
			ViewBag.Promo = db.Settings.FirstOrDefault().Promo;
            return View(db.Users.Include(n => n.Team).ToList());
		}

		[HttpGet]
		public IActionResult EditUser(int id, string Key)
		{
			if (db.Admins.FirstOrDefault().Key != Key)
			{
				ViewBag.msg = "Авторизация прошла с ошибкой, попробуйте еще раз";
				return View("Index");
			}
			ViewBag.id = id;
            List<User> user = db.Users.Where(n => n.UserId == id).ToList();
            db.Logs.Add(new Log { Msg = user.FirstOrDefault().Team.TeamId.ToString() });
            db.SaveChanges();

            ViewBag.tName = db.Users.Where(n => n.UserId == id).FirstOrDefault().Team.Name;

			return View(db.Teams.ToList());
		}

		[HttpPost]
		public IActionResult EditUser(Team team, string Key, int id)
		{
			if (db.Admins.FirstOrDefault().Key != Key)
			{
				ViewBag.msg = "Авторизация прошла с ошибкой, попробуйте еще раз";
				return View("Index");
			}

			db.Users.Find(id).Team = team;

			return RedirectToAction("ShowUsers");
		}

		#endregion

		#region Пользовательская часть

		[HttpPost]
		public IActionResult Game(string type, string key, int teamId)
		{
            Move nwMove = new Move { Type = type };

			//GameController.Make(nwMove, key, teamId);

			return View();
		}

		[HttpGet]
		public IActionResult Game(string key)
		{
			return View();
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string Promo)
		{
			if (db.Settings.FirstOrDefault() == null)
			{
				ViewBag.msg = "Нет активных игр";
				return View("Index");   
			}

            if (db.Settings.FirstOrDefault().TeamCount * db.Settings.FirstOrDefault().TeamSize == db.Users.Count())
            {
                ViewBag.msg = "Все места заняты";
                return View("Index");
            }


            if (db.Settings.FirstOrDefault().Promo == Promo)
			{
				User user = new User();

				int count = db.Users.Where(n => n.Team == db.Teams.FirstOrDefault()).Count(), id = db.Teams.FirstOrDefault().TeamId;
				
				foreach (Team team in db.Teams.ToList())
				{
					if (db.Users.Where(n => n.Team == team).Count() < count)
					{
						count = db.Users.Where(n => n.Team == team).Count();
						id = team.TeamId;
					}
				}

				user.InRocket = false;
				user.Intellect = 0;
				user.Power = 0;
				user.Name = "Игрок " + (count + 1).ToString();
				user.Key = id.ToString() + "СРКД" + count.ToString();

				user.Team = db.Teams.Find(id);
				db.Users.Add(user);
				db.SaveChanges();

				string userKey = id.ToString() + "СРКД" + count.ToString();

				return RedirectToAction("Game", new { key = userKey });
			}

			ViewBag.msg = "Неверный код";
			return View("Index");
		}

		#endregion
		
    }    
}
