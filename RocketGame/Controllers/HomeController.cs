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
            db.Logs.RemoveRange(db.Logs);
            db.Moves.RemoveRange(db.Moves);
            db.Users.RemoveRange(db.Users);
			db.Ticks.RemoveRange(db.Ticks);
			db.Teams.RemoveRange(db.Teams);
			db.Settings.RemoveRange(db.Settings);
			db.SaveChanges();

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
            string[] colors = { "Красные", "Синие", "Желтые", "Зеленые", "Фиолетовые" };
            for (int i = 0; i < settings.TeamCount; i++)
            {
                Team team = new Team();
                team.Name = colors[i];
				team.Power = settings.TeamSize;
				db.Teams.Add(team);
            }
			Random a = new Random();
			settings.Promo = "JDFJ" + a.Next(277, 1000).ToString();
            settings.IsFinished = false;
            settings.IsStarted = false;
            db.Settings.Add(settings);
            db.SaveChanges();
            ViewBag.Key = Key;

			List<string> Promos = new List<string>();
			List<string> Names = new List<string>();

			foreach (var item in db.Teams.ToList())
			{
				Promos.Add(db.Settings.Last().Promo + "-" + item.TeamId.ToString());
				Names.Add(item.Name);
			}

			ViewBag.Names = Names;
			ViewBag.Promos = Promos;

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

			List<string> Promos = new List<string>();
			List<string> Names = new List<string>();

			foreach (var item in db.Teams.ToList())
			{
				Promos.Add(db.Settings.Last().Promo + "-" + item.TeamId.ToString());
				Names.Add(item.Name);
			}

			ViewBag.Names = Names;
			ViewBag.Promos = Promos;

			return View(db.Users.Include(n => n.Team).ToList());
		}
		
		public string EditUserKey(string Key)
		{
			if (db.Moves.Where(n => n.User.Key == Key).ToList() != null)
			{
				List<Move> moves = db.Moves.Where(n => n.User.Key == Key).ToList();
				foreach (var item in moves)
				{
					db.Moves.Find(item.MoveId).User = db.Users.Find(item.User.UserId);
				}
				db.SaveChanges();
			}

			if (db.Users.Where(n => n.Key == Key).FirstOrDefault() == null)
				return "Такого игрока нет";

			Random rand = new Random();
			string k = rand.Next(10).ToString();

			for (int i = 0; i < Key.Length; i++)
				k = Key[i] + k;

			db.Users.Where(n => n.Key == Key).FirstOrDefault().Key = k;
			db.SaveChanges();

			return k;
		}

		public string EditUserTeam(string Key, string Team)
		{
			if (db.Users.Where(n => n.Key == Key).FirstOrDefault() == null)
				return "Такого игрока нет";
			if (db.Teams.Find(int.Parse(Team)) == null)
				return "Такой команды нет";

			db.Users.Where(n => n.Key == Key).FirstOrDefault().Team = db.Teams.Find(int.Parse(Team));
			db.SaveChanges();

			return "Команда изменена";
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
			ViewBag.key = key;
			return View();
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string Promo, string Name, string RealName)
		{
			foreach (User item in db.Users.ToList())
			{
				if (item.Name == Name)
				{
					ViewBag.msg = "Псевдоним занят";
					return View("Index");
				}
			}

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

			if (db.Settings.FirstOrDefault().TeamCount * db.Settings.FirstOrDefault().TeamSize <= db.Users.Count())
			{
				ViewBag.msg = "Все игроки уже зарегистрированы";
				return View("Index");
			}

			string[] pr = Promo.Split('-');
			if (db.Settings.FirstOrDefault().Promo == Promo || pr.Length == 2)
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
				user.Intellect = 1;
				user.Power = 1;
				user.Name = Name;
				user.RealName = RealName;
				user.Key = id.ToString() + "СРКД" + count.ToString();
				
				if (pr.Length == 2)
				{
					user.Team = db.Teams.Find(int.Parse(pr[1]));
				}
				else
				{
					user.Team = db.Teams.Find(id);
				}
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
