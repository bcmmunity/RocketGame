﻿using System;
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

        public IActionResult Game()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminView data)
        {
            if (db.Admins.Where(a => a.Mail == data.Mail).FirstOrDefault() != null)
            {
                if (db.Admins.Where(a => a.Mail == data.Mail).FirstOrDefault().Password == data.Password)
                {
                    ViewBag.Key = db.Admins.Where(a => a.Mail == data.Mail).FirstOrDefault().Key;
                    return View("Admin");
                }

                ViewBag.msg = "Неверный пароль";
                return View();
            }
            ViewBag.msg = "Неверный логин";
            return View();
        }

        public IActionResult Admin()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Admin(Setting settings)
        {
            if (settings.TeamCount > 5)
            {
                ViewBag.msg = "Количество команд должно быть не больше 5";
                return View();
            }

            if (settings.TeamCount * settings.TeamSize > 35)
            {
                ViewBag.msg = "Ошибка!/nДолжно быть не больше 35 игроков";
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
            db.Settings.Add(settings);
            db.SaveChanges();

            return RedirectToAction("ShowUsers");
        }

        public IActionResult ShowUsers()
        {
			//if (db.Admins.FirstOrDefault().Key != Key)
			//{
			//	return View("Index");
			//}
			ViewBag.Promo = db.Settings.FirstOrDefault().Promo;
            return View(db.Users.Include(n => n.Team).ToList());
		}

		[HttpPost]
		public IActionResult Login(string Promo)
		{
			if (db.Settings.FirstOrDefault() == null)
			{
				ViewBag.msg = "Нет активных игр";
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
				user.Name = "Игрок " + count;
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

		[HttpGet]
        public IActionResult EditUser(int id, string Key)
		{
			if (db.Admins.FirstOrDefault().Key != Key)
			{
				ViewBag.msg = "Авторизация прошла с ошибкой, попробуйте еще раз";
				return View("Index");
			}
			return View(db.Users.Find(id));
        }

        [HttpPost]
        public IActionResult EditUser(User user, string Key)
		{
			if (db.Admins.FirstOrDefault().Key != Key)
			{
				ViewBag.msg = "Авторизация прошла с ошибкой, попробуйте еще раз";
				return View("Index");
			}

			db.Users.Find(user.UserId).Team = user.Team;

            return RedirectToAction("ShowUsers");
        }
    }    
}
