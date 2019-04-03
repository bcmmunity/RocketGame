using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using RocketGame.Models;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace RocketGame.Controllers
{
	public class TableCreator
	{
		private MyContext db;

		public TableCreator()
		{
			Unit();
			db = db1;
		}

		static MyContext db1;

		public void Unit()
		{
			var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersstoredb;Trusted_Connection=True;MultipleActiveResultSets=true");
//			optionsBuilder.UseSqlServer("Server=localhost;Database=u0641156_rocketbot;User Id = u0641156_rocketbot; Password = Rocketbot1!");

			db1 = new MyContext(optionsBuilder.Options);
		}

		TickController tc = new TickController();

		public string alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		public void CreateTable()
		{
			db.Logs.Add(new Log { Msg = "Таблица создается" });
			db.SaveChanges();

			string fileName = Environment.CurrentDirectory + "\\wwwroot\\Test.xlsx";
			FileInfo newFile = new FileInfo(fileName);

			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}

			using (ExcelPackage xlPackage = new ExcelPackage(newFile)) // create the xlsx file
			{
				// Add a new worksheet on which to put data 
				ExcelWorksheet xlWorksheet = xlPackage.Workbook.Worksheets.Add("Лист");

				string[,] insert = DataArray();
				InsertData(xlWorksheet, insert);

				// Write the file
				xlPackage.Save();

				db.Logs.Add(new Log { Msg = "Таблица создалась" });
				db.SaveChanges();
			}
		}

		public void InsertData(ExcelWorksheet ew, string[,] insert)
		{
			for (int row = 0; row < insert.GetLength(0); row++)
			{
				for (int col = 0; col < insert.GetLength(1); col++)
				{
					ew.Cells[ColTranslator(col + 1) + (row + 1).ToString()].Value = insert[row, col];
				}
			}
		}

		public string ColTranslator(int col)
		{
			string result = "";

			if (col <= 26)
			{
				result = alf[col - 1].ToString();
			}
			else
			{
				int lettwo = col / 26;
				col -= lettwo * 26;
				result = alf[lettwo - 1].ToString() + alf[col - 1].ToString();
			}

			return result;
		}

		public string[,] DataArray()
		{
			Unit();
			string[,] result = new string[(1 + db1.Users.Count()), (5 + db1.Ticks.Count())];
			int i = 0;

			result[i, 0] = "Команда";
			result[i, 1] = "Топливо";
			result[i, 2] = "Никнейм";
			result[i, 3] = "Реальное имя";
			result[i, 4] = "Сила/Ум";
			i++;

			foreach (Team team in db1.Teams.ToList())
			{
				result[i, 0] = team.Name;
				result[i, 1] = team.Fuel.ToString();

				foreach (User user in db1.Users.Where(n => n.Team == team).OrderBy(b => b.UserId).ToList())
				{
					result[i, 2] = user.Name;
					result[i, 3] = user.RealName;
					result[i, 4] = user.Power.ToString() + "/" + user.Intellect.ToString();
					i++;
				}
			}

			int j = 5;

			foreach (Tick tick in db1.Ticks.OrderBy(n => n.TickId).ToList())
			{
				result[0, j] = "Такт " + tick.Number;

				int count = 1;

				foreach (Team team in db1.Teams.OrderBy(n => n.TeamId).ToList())
				{
					foreach (User user in db1.Users.Where(n => n.Team == team).OrderBy(n => n.UserId).ToList())
					{
						if (db1.Moves.Where(n => n.User == user).Where(b => b.Tick == tick).FirstOrDefault() != null)
						{
							result[count, j] = tc.Translator(db1.Moves.Where(n => n.User == user).Where(b => b.Tick == tick).Include(m => m.User).FirstOrDefault());
						}
						count++;
					}
				}
				j++;
			}

			return result;
		}
	}
}
