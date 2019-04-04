using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
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
		public IActionResult Admin(AdminView data, string Type)
		{
			if (Type == "")
			{
				ViewBag.msg = "Выберете способ входа";
				return View();
			}

			if (db.Admins.Where(a => a.Mail == data.Mail).FirstOrDefault() != null && Type == "Old")
			{
				if (db.Admins.Where(a => a.Mail == data.Mail).FirstOrDefault().Password == data.Password)
				{
					return RedirectToAction("ShowUsers", new { Key = db.Admins.Where(a => a.Mail == data.Mail).FirstOrDefault().Key });
				}

				ViewBag.msg = "Неверный пароль";
				return View();
			}

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

			db.Logs.RemoveRange(db.Logs);
			db.Moves.RemoveRange(db.Moves);
			db.Users.RemoveRange(db.Users);
			db.Ticks.RemoveRange(db.Ticks);
			db.Teams.RemoveRange(db.Teams);
			db.Settings.RemoveRange(db.Settings);
			db.SaveChanges();


			string[] colors = { "Красные", "Синие", "Желтые", "Зеленые", "Фиолетовые" };
            for (int i = 0; i < settings.TeamCount; i++)
            {
                Team team = new Team();
                team.Name = colors[i];
				team.Power = settings.TeamSize;
				db.Teams.Add(team);
            }
			Random a = new Random();

			string ALF = "QWERTYUIOPASDFGHJKLZXCVBNM";

			settings.Promo = "JDFJ" + ALF[a.Next(0, 25)];
            settings.IsFinished = false;
            settings.IsStarted = false;
            db.Settings.Add(settings);
            db.SaveChanges();
            ViewBag.Key = Key;

			List<string> Promos = new List<string>();
			List<string> Names = new List<string>();

			foreach (var item in db.Teams.ToList())
			{
				int idd = item.TeamId;
				string res = "";
				while (idd != 0)
				{
					res = ALF[idd % 10] + res;
					idd /= 10;
				}
				Promos.Add(db.Settings.Last().Promo + "-" + res);
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
			List<string> Names = new List<string>(); string ALF = "QWERTYUIOPASDFGHJKLZXCVBNM";

			foreach (var item in db.Teams.ToList())
			{
				int idd = item.TeamId;
				string res = "";

				while (idd != 0)
				{
					res = ALF[idd % 10] + res;
					idd /= 10;
				}
				Promos.Add(db.Settings.Last().Promo + "-" + res);
				Names.Add(item.Name);
			}

			ViewBag.Names = Names;
			ViewBag.Promos = Promos;

			return View(db.Users.Include(n => n.Team).OrderBy(l => l.Team.Name).ToList());
		}
		
		public string EditUserKey(string Key, string UserId)
		{
			if (db.Moves.Where(n => n.User.Key == Key).ToList() != null)
			{
				List<Move> moves = db.Moves.Where(n => n.User.Key == Key).ToList();
				foreach (var item in moves)
				{
					db.Moves.Find(item.MoveId).User = db.Users.Where(n => n.Key == Key).FirstOrDefault();
				}
				db.SaveChanges();
			}

			if (db.Users.Where(n => n.Key == Key).FirstOrDefault() == null)
				return "Такого игрока нет";
			if (db.Users.Find(int.Parse(UserId))== null)
				return "Такого игрока нет";

			Random rand = new Random();
			string k = rand.Next(10).ToString();

			for (int i = 0; i < Key.Length; i++)
				k = Key[i] + k;

			db.Users.Where(n => n.Key == Key).FirstOrDefault().RealName = db.Users.Find(int.Parse(UserId)).RealName;
			db.Users.Where(n => n.Key == Key).FirstOrDefault().Name = db.Users.Where(n => n.Key == Key).FirstOrDefault().Name + "_D";
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
			ViewBag.key = key;
			return View();
		}

		[HttpGet]
		public string[,] GetUsers(string key)
		{
			string[,] users = new string[db.Users.Count() - 1, 2];
			int i = 0;

			foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
			{
				foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(b => b.UserId).ToList())
				{
					if (user.Key != key)
					{
						users[i, 0] = user.RealName;
						users[i, 1] = user.UserId.ToString();
						i++;
					}
				}

			}

			ViewBag.i = i;
			ViewBag.users = users;
			ViewBag.key = key;

			return users;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string Promo, string Name, string RealName, string Mail)
		{
			if (Name != "")
				ViewBag.Name = Name;
			else
				ViewBag.Name = "1";

			if (Promo != "")
				ViewBag.Promo = Promo;
			else
				ViewBag.Promo = "1";

			if (Mail != "")
				ViewBag.Mail = Mail;
			else
				ViewBag.Mail = "1";

			if (RealName != "")
				ViewBag.RealName = RealName;
			else
				ViewBag.RealName = "1";

			if (Name == "" || RealName == "")
			{
				ViewBag.msg = "Заполните все поля";
				return View("Index");
			}

			foreach (User item in db.Users.ToList())
			{
				if (item.Name == Name)
				{
					ViewBag.msg = "Такой псевдоним уже кем-то занят, придумайте другой";
					return View("Index");
				}
			}

			if (db.Settings.FirstOrDefault() == null)
			{
				ViewBag.msg = "Нет активных игр";
				return View("Index");   
			}

            if ((db.Settings.Last().TeamCount * db.Settings.Last().TeamSize) == db.Users.Count())
            {
                ViewBag.msg = "Мест в игре больше нет";
                return View("Index");
            }

			if (db.Settings.FirstOrDefault().TeamCount * db.Settings.FirstOrDefault().TeamSize <= db.Users.Count())
			{
				ViewBag.msg = "Все игроки уже зарегистрированы";
				return View("Index");
			}

			if(Mail == null)
			{
				ViewBag.msg = "Введите почту";
				return View("Index");
			}

			if (!VerifyMail(Mail))
			{
				ViewBag.msg = "Проверьте корректность адреса почты";
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
				user.Mail = Mail;
				user.Key = id.ToString() + count.ToString();

				string userKey = id.ToString() + count.ToString();
				List<string> Names = new List<string>();
				string ALF = "QWERTYUIOPASDFGHJKLZXCVBNM";

				if (pr.Length == 2)
				{
						int j = 0, tId = 0;

					for (int i = 0; i < pr[1].Length; i++)
					{
						while (ALF[j] != pr[1][i])
						{
							j++;
						}

						if (tId == 0)
						{
							tId = j;
						}
						else
						{
							tId = tId * 10 + j;
						}

						j = 0;
					}

					user.Team = db.Teams.Find(tId);
					userKey = user.Team.TeamId + db.Users.Where(n => n.Team == user.Team).Count().ToString();
					user.Key = user.Team.TeamId + db.Users.Where(n => n.Team == user.Team).Count().ToString();
				}
				else
				{
					user.Team = db.Teams.Find(id);
				}
				db.Users.Add(user);
				db.SaveChanges();

				MailAsync(Mail, user.Key); //Работай.
			
				return RedirectToAction("Game", new { key = userKey });
			}

			ViewBag.msg = "Неверный ключ игрока";
			return View("Index");
		}

		#endregion

		public void MailAsync(string Mail, string Key)
		{
			MailAddress from = new MailAddress("info@diffind.com", "RocketGame");
			MailAddress to = new MailAddress(Mail);

			MailMessage m = new MailMessage(from, to);
			m.Subject = "ID для игры RocketGame";
			m.Body = Key;

			SmtpClient smtp = new SmtpClient("wpl19.hosting.reg.ru", 587);
			smtp.Credentials = new NetworkCredential("info@diffind.com", "SuperInfo123!");
			//smtp.EnableSsl = true;

			smtp.SendAsync(m, "check");
		}

		public void DoubleMail(int UserId, string DoubleKey)
		{
			MailAsync(db.Users.Where(n => n.UserId == UserId).FirstOrDefault().Mail, "Ключ дубля: " + DoubleKey);
		}

		public bool VerifyMail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}
	}    
}
