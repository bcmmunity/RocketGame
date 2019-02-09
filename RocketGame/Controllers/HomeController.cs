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


        //public IActionResult Admin()
        //{
        //    return View();
        //}

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
            if (db.Admins.Where(a => a.mail == data.mail).FirstOrDefault() != null)
            {
                if (db.Admins.Where(a => a.mail == data.mail).FirstOrDefault().password == data.password)
                {
                    ViewBag.Key = db.Admins.Where(a => a.mail == data.mail).FirstOrDefault().key;
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


            db.Settings.Add(settings);
            db.SaveChanges();

            return View();
        }

        public IActionResult ShowUsers()
        {
            return View(db.Users.ToList());
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            
            return View(db.Users.Find(id));
        }

        [HttpPost]
        public IActionResult EditUser(User user)
        {
            db.Users.Find(user.UserId).Team = user.Team;

            return RedirectToAction("ShowUsers");
        }
    }    
}
