using System;
using System.Web;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
using RocketGame.Models;
using OfficeOpenXml;

namespace RocketGame.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class GameController : ControllerBase
    {
        private MyContext db;

        public GameController(MyContext context)
        {
            db = context;
        }

		static MyContext db1;

		public void Unit()
		{
			var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=usersstoredb;Trusted_Connection=True;MultipleActiveResultSets=true");
			//optionsBuilder.UseSqlServer("Server=localhost;Database=u0641156_rocketbot;User Id = u0641156_rocketbot; Password = Rocketbot1!");

			db1 = new MyContext(optionsBuilder.Options);
		}

		TableCreator tc = new TableCreator();
		TickController transl = new TickController();

		public void Make(Move Move, string Key, int TeamId)
        {
            if (Move.Type == "powerup" || Move.Type == "intellectup" || Move.Type == "gather" || Move.Type == "gift" 
				|| Move.Type == "attackgroup" || Move.Type == "attackrocket" || Move.Type == "getinrocket")
            {
                Move.User = db.Users.Where(n => n.Key == Key).FirstOrDefault();
                Move.Tick = db.Ticks.Last();
                Move.Time = DateTime.Now;
                Move.To = db.Teams.Find(TeamId);
				Move.IsUpdated = false;
				db.Moves.Add(Move);
                db.SaveChanges();

                Tick LastTick = db.Ticks.Last();

                db.Logs.Add(new Log { Msg = Move.Type + " " + db.Users.Where(n => n.Key == Key).FirstOrDefault().Key });
                db.SaveChanges();

                if (db.Settings.FirstOrDefault().TeamCount * db.Settings.FirstOrDefault().TeamSize == db.Moves.Where(n => n.Tick == LastTick).Count())
                {
                    db.Logs.Add(new Log { Msg = "Move check done" });
                    db.SaveChanges();

					if (DateTime.Now >= db.Settings.Last().GameEnd)
					{
						Update();
						FinishGame();
					}
					else
					{
						if (!db.Settings.Last().IsPaused)
						{
							db.Logs.Add(new Log { Msg = "Move starts Update" });
							db.SaveChanges();

							Update();
							AddTick();
						}
					}
                }
            }
        }

		#region Checks

		public void TimeCheck()
		{
			if (db.Settings.Last().IsFinished == false && !db.Ticks.Last().IsUpdated)
			{
				if (DateTime.Now >= db.Settings.Last().GameEnd
					&& DateTime.Now >= db.Ticks.Last().Start.AddMinutes(db.Settings.Last().TimeTick) && !db.Settings.Last().IsPaused)
				{
					db.Logs.Add(new Log { Msg = "TimeCheck starts Update (with FinishGame)" });
					db.SaveChanges();

					Update();
					FinishGame();
				}
				else if (DateTime.Now >= db.Ticks.Last().Start.AddMinutes(db.Settings.Last().TimeTick) && !db.Settings.Last().IsPaused)
				{
					db.Logs.Add(new Log { Msg = "TimeCheck starts Update" });
					db.SaveChanges();

					Update();
					AddTick();
				}
			}
		} 

		public bool LastTickCheck()
		{
			if (DateTime.Now >= db.Settings.Last().GameEnd && db.Settings.Last().GameEnd != DateTime.MinValue && !db.Settings.Last().IsFinished)
			{
				return true;
			}
			return false;
		}

		public bool KeyCheck(string Key)
		{
			if (db.Users.Where(n => n.Key == Key).FirstOrDefault() != null)
			{
				return true;
			}
			return false;
		}

		public bool PauseCheck()
		{
			if (db.Settings.Last().IsPaused)
			{
				return true;
			}
			return false;
		}

		public string GameCheck()
		{

			if (db.Settings.Last().IsFinished)
			{
				return "Игра завершилась!";
			}

			if (!db.Settings.FirstOrDefault().IsStarted)
			{
				return "Игра еще не началась";
			}
			else
			{
				return "Игра началась";
			}
			
		}

		public string MoveCheck(string Key)
		{
			//if (db.Settings.FirstOrDefault().IsFinished)
			//{
			//	return "Игра завершена";
			//}

			if (db.Settings.Last().IsFinished && db.Users.Where(n => n.InRocket == true).Count() == db.Settings.Last().RocketSize)
			{
				return "Выжившие улетели!";
			}

			if (db.Settings.Last().IsFinished && db.Users.Where(n => n.InRocket == true).Count() != db.Settings.Last().RocketSize)
			{
				return "Все погибли!";
			}

			if (!db.Settings.FirstOrDefault().IsStarted)
			{
				return "Игра еще не началась";
			}

			if (db.Settings.FirstOrDefault().IsPaused)
			{
				return "Пауза";
			}

			if (db.Moves.Where(n => n.User.Key == Key).Where(l => l.Tick.Number == db.Ticks.Last().Number).FirstOrDefault() != null)
			{
				return "Ход сделан";
			}
			else
			{
				return "Ход не сделан";
			}
		}

		public bool RocketCheck(string Key)
		{
			if (db.Users.Where(n => n.Key == Key).Include(l => l.Team).FirstOrDefault().Team.Fuel >= db.Settings.FirstOrDefault().RocketFuel)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion

		#region Extra

		public List<Team> TeamList(string Key)
		{
			List<Team> teams = db.Teams.Where(n => n.TeamId != db.Users.Where(f => f.Key == Key).FirstOrDefault().Team.TeamId).ToList();
			return teams;
		}

		public string GameResult()
		{
			string msg = " ";

			if (db.Settings.Last().IsFinished && db.Users.Where(x => x.InRocket == true).Count() == db.Settings.Last().RocketSize)
			{
				string winners = "";
				int i = 1; //Счетчик игроков

				foreach (User user in db.Users.Where(x => x.InRocket == true).ToList())
				{
					if (i != db.Settings.Last().RocketSize)
					{
						winners += user.Name + ", ";
						i++;
					}
					else
					{
						winners += user.Name;
					}
				}

				msg = "Выжившие из команды " + db.Users.Where(x => x.InRocket == true).FirstOrDefault().Team.Name + " " + winners + "улетели!";
			}
			else if (db.Settings.Last().IsFinished && db.Users.Where(x => x.InRocket == true).Count() != db.Settings.Last().RocketSize)
			{
				msg = "Метеорит упал на землю, все погибли!";
			}
			else
			{
				msg = "NotFinished";
			}

			return msg;
		}

		public List<Team> GroupList()
		{
			return db.Teams.ToList();
		}

		public string[,] Stats()
		{
			string[,] stats = new string[db.Users.Count(), 2];
			int i = 0;

			foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
			{
				foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(b => b.UserId).ToList())
				{
					stats[i, 0] = transl.GroupTranslator(team.Name) + " (" + team.Fuel.ToString() + ")" ;
					stats[i, 1] = user.Power.ToString() + "/" + user.Intellect.ToString();
					i++;
				}
			}
			return stats;
		}

		public void Resume()
		{
			if (db.Settings.Last().IsPaused)
			{
				TimeSpan diff = DateTime.Now - db.Ticks.Last().Finish;
				db.Settings.Last().GameEnd = db.Settings.Last().GameEnd.Add(diff);
				db.Settings.Last().IsPaused = false;
				db.SaveChanges();
				AddTick();
			}
		}

		#endregion

		[HttpGet]
        public string StartGame()
        {
			int count = 0; // Кол-во команд, размер которых равен настройкам игры

			foreach (Team team in db.Teams.ToList())
			{
				if (db.Users.Where(n => n.Team == team).Count() == db.Settings.Last().TeamSize)
				{
					count++;
				}
			}

			if (count == db.Settings.Last().TeamCount && !db.Settings.Last().IsStarted && !db.Settings.Last().IsFinished)
			{
				db.Logs.Add(new Log { Msg = "Game started" });
				db.SaveChanges();

				if (System.IO.File.Exists("Test.xlsx"))
				{
					System.IO.File.Delete("Test.xlsx");
				}

				Tick Tick = new Tick();
				Tick.Number = 1;
				//Tick.Updated = false;
				Tick.Start = DateTime.Now;
				db.Ticks.Add(Tick);

				db.Logs.Add(new Log { Msg = "StartGame end" });
				db.Settings.Last().GameEnd = Tick.Start.AddMinutes(db.Settings.Last().TimeGame);
				db.Settings.FirstOrDefault().IsStarted = true;
				db.SaveChanges();

				return "Игра началась";
			}
			else if (db.Settings.Last().IsFinished)
			{
				return "Эта игра уже закончилась";
			}
			else
			{
				return "Не все игроки вошли!";
			}
		}

		public string AddTick()
		{
			db.Logs.Add(new Log { Msg = "AddTick Start" });
			db.SaveChanges();

			//Update();

			if (db.Settings.Last().IsFinished)
			{
				db.Logs.Add(new Log { Msg = "AddTick GameEnd" });
				db.SaveChanges();
				return "Игра окончена";
			}

			if (db.Ticks.Last().Finish == DateTime.MinValue)
			{
				db.Ticks.Last().Finish = DateTime.Now;
			}

			if (!db.Settings.Last().IsPaused && db.Settings.Last().TickPause != db.Ticks.Last().Number
				|| !db.Settings.Last().IsPaused && db.Ticks.Last().Finish.AddSeconds(1) < DateTime.Now)
			{
				Tick Tick = new Tick();
				Tick.Number = db.Ticks.Last().Number + 1;
				//Tick.Updated = false;
				Tick.Start = DateTime.Now;
				db.Ticks.Add(Tick);

				db.Logs.Add(new Log { Msg = "AddTick End" });
				db.SaveChanges();

				return "Начался новый такт";
			}
			else
			{
				db.Settings.Last().IsPaused = true;

				db.Logs.Add(new Log { Msg = "AddTick PAUSE" });
				db.SaveChanges();

				return "Пауза";
			}
        }

        public void FinishGame()
        {
            db.Logs.Add(new Log { Msg = "FinishGame Done" });
            db.SaveChanges();

			db.Ticks.Last().Finish = DateTime.Now;
			db.Settings.Last().IsFinished = true;
			db.SaveChanges();

			db.Logs.Add(new Log { Msg = "Запуск таблицы" });
			db.SaveChanges();

			tc.CreateTable();

			db.Logs.Add(new Log { Msg = "Создана таблица" });
			db.SaveChanges();
		}

        public void Update()
        {
			Unit();

			db1.Ticks.Last().IsUpdated = true;

			if (db1.Ticks.Last().Finish == DateTime.MinValue)//db1.Ticks.Last().Updated == false
			{
				//db1.Ticks.Last().Updated = true;

				db1.Logs.Add(new Log { Msg = "Update Start. Tick: " + db1.Ticks.Last().Number.ToString() });
				db1.SaveChanges();

				PowerUp();

				IntellectUp();

				Gather();

				Gift();

				GetInRocket();

				AttackGroup();

				AttackRocket();

				if (db1.Users.Where(n => n.InRocket == true).Count() == db1.Settings.FirstOrDefault().RocketSize)
				{
					foreach (User user in db1.Users.Where(n => n.InRocket == true).ToList())
					{
						db1.Moves.Where(m => m.User == user).Where(n => n.Tick == db1.Ticks.Last()).FirstOrDefault().Result = "Победа";
						db1.SaveChanges();
					}
					FinishGame();
				}

				db1.Logs.Add(new Log { Msg = "Update End"});
				db1.SaveChanges();
			}
        }

		#region for Update

		public void PowerUp()
		{
			db.Logs.Add(new Log { Msg = "PowerUp Start" });
			db.SaveChanges();

			if (db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "powerup").Count() != 0)
			{
				List<Move> Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "powerup").Include(f => f.User).Include(a => a.User.Team).ToList();
				foreach (Move item in Moves)
				{
					if (!db.Moves.Find(item.MoveId).IsUpdated)
					{
						db.Logs.Add(new Log { Msg = "MoveId: " + item.MoveId });
						db.SaveChanges();

						db.Users.Find(item.User.UserId).Power++;
						db.Teams.Find(item.User.Team.TeamId).Power++;
						db.Moves.Find(item.MoveId).IsUpdated = true;
						db.SaveChanges();
					}
				}

				db.Logs.Add(new Log { Msg = "PowerUp End" });
				db.SaveChanges();
			}
		}

		public void IntellectUp()
		{
			db.Logs.Add(new Log { Msg = "IntellectUp Start" });
			db.SaveChanges();

			if (db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "intellectup").Count() != 0)
			{
				List<Move> Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "intellectup").Include(f => f.User).ToList();
				foreach (Move item in Moves)
				{
					if (!db.Moves.Find(item.MoveId).IsUpdated)
					{
						db.Logs.Add(new Log { Msg = "MoveId: " + item.MoveId });
						db.SaveChanges();

						db.Users.Find(item.User.UserId).Intellect++;
						db.Moves.Find(item.MoveId).IsUpdated = true;
						db.SaveChanges();
					}
				}
			}

			db.Logs.Add(new Log { Msg = "IntellectUp End" });
			db.SaveChanges();
		}

		public void Gather()
		{
			db.Logs.Add(new Log { Msg = "Gather Start" });
			db.SaveChanges();

			if (db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "gather").Count() != 0)
			{
				List<Move> Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "gather").Include(f => f.User.Team).ToList();
				foreach (Move item in Moves)
				{
					if (!db.Moves.Find(item.MoveId).IsUpdated)
					{
						db.Logs.Add(new Log { Msg = "MoveId: " + item.MoveId });
						db.SaveChanges();

						db.Teams.Find(item.User.Team.TeamId).Fuel += db.Users.Find(item.User.UserId).Intellect;
						db.Moves.Find(item.MoveId).IsUpdated = true;
						db.SaveChanges();
					}
				}
			}

			db.Logs.Add(new Log { Msg = "Gather End" });
			db.SaveChanges();
		}

		public void Gift()
		{
			db.Logs.Add(new Log { Msg = "Gift Start" });
			db.SaveChanges();

			if (db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "gift").Count() != 0)
			{
				List<Move> Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "gift").Include(f => f.User).Include(a => a.User.Team).Include(g => g.To).ToList();

				foreach (Team item in db.Teams.ToList())
				{
					foreach (Team target in db.Teams.ToList())
					{
						if (Moves.Where(n => n.User.Team == item).Where(b => b.To == target).Count() == db.Settings.Last().TeamSize)
						{
							db.Teams.Find(target.TeamId).Fuel += db.Teams.Find(item.TeamId).Fuel;
							db.Teams.Find(item.TeamId).Fuel = 0;

							foreach (Move move in db.Moves.Where(x => x.Type == "gift").Where(c => c.User.Team == item).Where(b => b.To == target).Where(n => n.Tick == db.Ticks.Last()).ToList())
							{
								db.Logs.Add(new Log { Msg = "MoveId: " + move.MoveId });
								db.SaveChanges();

								db.Moves.Find(move.MoveId).Result = "Подарили";
								db.Moves.Find(move.MoveId).IsUpdated = true;
							}

						}

						if (Moves.Where(n => n.User.Team == item).Where(b => b.To == target).Count() != db.Settings.Last().TeamSize)
						{
							foreach (Move move in db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(x => x.Type == "gift").Where(c => c.User.Team == item).Where(b => b.To == target).ToList())
							{
								db.Logs.Add(new Log { Msg = "MoveId: " + move.MoveId });
								db.SaveChanges();

								db.Moves.Find(move.MoveId).Result = "Неудача";
								db.Moves.Find(move.MoveId).IsUpdated = true;
							}
						}
						db.SaveChanges();
					}
				}
			}

			db.Logs.Add(new Log { Msg = "Gift End" });
			db.SaveChanges();
		}

		public void GetInRocket()
		{
			db.Logs.Add(new Log { Msg = "GetInRocket Start" });
			db.SaveChanges();

			if (db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "getinrocket").Count() != 0)
			{
				List<Move> Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "getinrocket").Include(f => f.User).Include(a => a.User.Team).ToList();
				int count = 0;
				int[] powint = new int[db.Settings.FirstOrDefault().TeamSize]; //Сила+Интеллект Игрока
				int[] teamids = new int[5]; //ID Команд
				int[] userid = new int[db.Settings.FirstOrDefault().TeamSize];
				bool isdone = false;
				DateTime[] earlyuser = new DateTime[db.Settings.FirstOrDefault().TeamSize]; //Время хода игрока

				db.Logs.Add(new Log { Msg = "Проверка Гет_Ин_Да_Факин_Рокет" });
				db.SaveChanges();

				foreach (Team team in db.Teams.ToList())
				{
					if (Moves.Where(n => n.User.Team == team).FirstOrDefault() != null &&
						Moves.Where(n => n.User.Team == team).Count() == db.Settings.Last().RocketSize)
					{
						isdone = true;
						teamids[count] = team.TeamId;
						count++;
					}
				}

				if (isdone)
				{
					db.Logs.Add(new Log { Msg = "Начало Гет_Ин_Да_Факин_Рокет" });
					db.SaveChanges();

					if (count > 0)
					{
						int winner = 0;
						bool fl = false;

						//int teams = 0; //кол-во команд с равным кол-вом топлива
						int fuel = 0; //наибольшее кол-во топлива у команды

						foreach (Move move in Moves.ToList())
						{
							db.Logs.Add(new Log { Msg = "MoveId (подсчет топлива): " + move.MoveId });
							db.SaveChanges();

							for (int f = 0; f < count; f++)
							{
								if (teamids[f] == move.User.Team.TeamId && move.User.Team.Fuel > fuel)
								{
									fuel = move.User.Team.Fuel;
									//teams++;
								}
							}
						}

						db.Logs.Add(new Log { Msg = "Наибольшее топливо = " + fuel });
						db.SaveChanges();

						foreach (Move move in Moves.Where(x => x.User.Team.Fuel == fuel).OrderBy(n => n.Time).ToList()) //Проверить
						{
							for (int f = 0; f < count; f++)
							{
								if (teamids[f] == move.User.Team.TeamId)
								{
									winner = move.User.Team.TeamId;
									fl = true;

									db.Logs.Add(new Log { Msg = "MoveId (поиск команды-победителя): " + move.MoveId });
									db.Logs.Add(new Log { Msg = "fl = " + fl.ToString() });
									db.SaveChanges();

									break;
								}

								if (fl) break;
							}

							if (fl) break;
						}

						//==================================================== СОРИТИРОВКА ИГРОКОВ В РАКЕТУ =============================================================

						if (Moves.Where(m => m.User.Team.TeamId == winner).Count() == db.Settings.FirstOrDefault().RocketSize) //Нет конкуренции в команде
						{
							db.Logs.Add(new Log { Msg = "Нет конкуренции" });
							db.SaveChanges();

							foreach (Move winners in Moves.Where(m => m.User.Team.TeamId == winner).ToList())
							{
								if (!winners.IsUpdated)
								{
									db.Users.Find(winners.User.UserId).InRocket = true;
									db.Moves.Find(winners.MoveId).IsUpdated = true;
									db.SaveChanges();
								}
							}
						}
						else //Есть конкуренция в команде
						{
							db.Logs.Add(new Log { Msg = "Есть конкуренция" });
							db.SaveChanges();

							int countwinner = 0; //кол-во игроков в команде победивших
							int c = db.Settings.FirstOrDefault().RocketSize;

							foreach (Move move in Moves.Where(m => m.User.Team.TeamId == winner).OrderBy(k => k.Time).ToList())
							{
								powint[countwinner] += move.User.Power + move.User.Intellect;
								userid[countwinner] = move.User.UserId;

								countwinner++;
							}

							db.Logs.Add(new Log { Msg = "countwinner = " + countwinner });
							db.SaveChanges();

							for (int p = 1; p < countwinner; p++)
							{
								for (int k = 0; k < p; k++)
								{
									if (powint[k] < powint[p]) //Сортировка
									{
										int t = powint[p];
										powint[p] = powint[k];
										powint[k] = t;

										t = userid[p];
										userid[p] = userid[k];
										userid[k] = t;
									}
								}
							}

							int index = db.Settings.FirstOrDefault().RocketSize;
							int borders = index - 1;
							int borderf = index;
							bool g = true;

							if (powint[index - 1] != powint[index])
							{
								g = false;
								for (int s = 0; s < index; s++)
								{
									if (!db.Moves.Where(m => m.User.UserId == userid[s]).FirstOrDefault().IsUpdated)
									{
										db.Users.Where(m => m.UserId == userid[s]).FirstOrDefault().InRocket = true;
										db.Moves.Where(m => m.User.UserId == userid[s]).FirstOrDefault().IsUpdated = true;
										db.SaveChanges();
									}
								}
							}

							if (g)
							{
								db.Logs.Add(new Log { Msg = "Сложная проверка конкуренции. Индекс = " + index + "powint = " + powint[0] + " " + powint[1] });
								db.SaveChanges();

								while (powint[index - 1] == powint[index])
								{
									borders = index - 1;
									index--;
									if (index == 0)
									{
										break;
									}
								}

								db.Logs.Add(new Log { Msg = "Прошел 1 while. borders = " + borders });
								db.SaveChanges();

								while (powint[index + 1] == powint[index])
								{
									if (index + 1 > powint.Length)
									{
										borderf = index + 1;
										index++;
									}
									break;
								}

								db.Logs.Add(new Log { Msg = "Прошел 2 while. borderf = " + borderf });
								db.SaveChanges();

								for (int s = 0; s <= borders; s++)
								{
									if (!db.Moves.Where(m => m.User.UserId == userid[s]).FirstOrDefault().IsUpdated)
									{
										db.Users.Where(m => m.UserId == userid[s]).FirstOrDefault().InRocket = true;
										db.Moves.Where(m => m.User.UserId == userid[s]).FirstOrDefault().IsUpdated = true;
										db.SaveChanges();
									}
								}

								db.Logs.Add(new Log { Msg = "Прошел первый for для верхней границы" });
								db.SaveChanges();

								for (int h = borders; h <= borderf; h++)
								{
									earlyuser[h] = db.Moves.Where(a => a.User.UserId == userid[h]).FirstOrDefault().Time;
								}

								db.Logs.Add(new Log { Msg = "Прошел for для времени" });
								db.SaveChanges();

								for (int l = borders + 1; l < borderf; l++)
								{
									for (int z = borders; z < l; z++)
									{
										if (earlyuser[z] > earlyuser[l])
										{
											DateTime t = earlyuser[l];
											earlyuser[l] = earlyuser[z];
											earlyuser[z] = t;

											int n = powint[l];
											powint[l] = powint[z];
											powint[z] = n;

											n = userid[l];
											userid[l] = userid[z];
											userid[z] = n;
										}
									}
								}

								db.Logs.Add(new Log { Msg = "Прошел последний for" });
								db.SaveChanges();

								for (int b = 0; b < db.Settings.FirstOrDefault().RocketSize - borders; b++)
								{
									if (!db.Moves.Where(m => m.User.UserId == userid[b]).FirstOrDefault().IsUpdated)
									{
										db.Users.Where(m => m.UserId == userid[b]).FirstOrDefault().InRocket = true;
										db.Moves.Where(m => m.User.UserId == userid[b]).FirstOrDefault().IsUpdated = true;
										db.SaveChanges();
									}
								}
							}
						}
						db.Logs.Add(new Log { Msg = "Конец getinrocket" });
						db.SaveChanges();
					}
				}
			}

			db.Logs.Add(new Log { Msg = "GetInRocket End" });
			db.SaveChanges();
		}

		public void AttackGroup()
		{
			db.Logs.Add(new Log { Msg = "AttackGrop Start" });
			db.SaveChanges();

			if (db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackgroup").Count() != 0)
			{
				List<Move> Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackgroup").Include(f => f.User).Include(a => a.User.Team).Include(g => g.To).ToList();
				foreach (Team target in db.Teams.ToList())
				{
					db.Logs.Add(new Log { Msg = "Атака на " + target.Name });
					db.SaveChanges();

					if (db.Users.Where(b => b.Team == target).Where(a => a.InRocket == false).Count() == db.Settings.Last().TeamSize)
					{
						int i = 0; //кол-во атакующих команд
						int[] power = new int[5]; //Сила Команд
						int[] ids = new int[5]; //ID Команд
						DateTime[] earlyuserid = new DateTime[5]; //Самый ранний ход команды

						foreach (Team team in db.Teams.ToList())
						{
							power[i] = 0;
							earlyuserid[i] = DateTime.Now; //Moves.Where(n => n.User.Team == team).First().Time;

							if (db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackgroup").Where(n => n.User.Team == team).Where(n => n.To == target).ToList() != null)
							{
								db.Logs.Add(new Log { Msg = "Прошел проверку. i = " + i });

								ids[i] = team.TeamId;

								foreach (Move attacker in db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackgroup").Where(n => n.User.Team == team).Where(n => n.To == target).Include(c => c.User).ToList()) // 
								{
									db.Logs.Add(new Log { Msg = "MoveId: " + attacker.MoveId });
									db.SaveChanges();

									db.Logs.Add(new Log { Msg = "Тип: " + attacker.Type + " Цель: " + attacker.To.Name + " Сила: " + attacker.User.Power + " Время в массиве: " + earlyuserid[i] });
									db.SaveChanges();

									if (attacker.Time < earlyuserid[i])
									{
										db.Logs.Add(new Log { Msg = "Вошли в проверку" });
										db.SaveChanges();
										earlyuserid[i] = attacker.Time;
									}

									db.Logs.Add(new Log { Msg = "Вышли из проверки" });
									db.SaveChanges();

									power[i] += attacker.User.Power;

									db.Logs.Add(new Log { Msg = "Attack Group power[" + i + "] = " + power[i] });
									db.SaveChanges();

								}
								i++;
							}
						}

						for (int j = 1; j < i; j++)
						{
							for (int k = 0; k < j; k++)
							{
								if (power[k] < power[j])
								{
									int n = power[j];
									power[j] = power[k];
									power[k] = n;

									n = ids[j];
									ids[j] = ids[k];
									ids[k] = n;

									DateTime t = earlyuserid[j];
									earlyuserid[j] = earlyuserid[k];
									earlyuserid[k] = t;
								}
							}
						}

						int equalcount = 1; //Количество самых сильных
						for (int j = 1; j < i; j++)
						{
							if (power[0] == power[j])
							{
								equalcount++;
							}
						}

						db.Logs.Add(new Log { Msg = "Где-то тут запускается AttackGroupResult" });
						db.SaveChanges();

						if (equalcount == 1)
						{
							db.Logs.Add(new Log { Msg = "1) Тут" });
							db.SaveChanges();

							AttackGroupResult(0, ids, power, target);
							db.SaveChanges();
						}

						if (equalcount == 2)
						{

							if (earlyuserid[0] < earlyuserid[1])
							{
								db.Logs.Add(new Log { Msg = "2) Тут" });
								db.SaveChanges();

								AttackGroupResult(0, ids, power, target);
								db.SaveChanges();
							}
							else
							{
								db.Logs.Add(new Log { Msg = "3) Тут" });
								db.SaveChanges();

								AttackGroupResult(1, ids, power, target);
								db.SaveChanges();
							}
						}

						if (equalcount == 3)
						{
							for (int j = 1; j < 3; j++) //Проверить (Сортировка на убывание времени)
							{
								for (int k = 0; k < j; k++)
								{
									if (earlyuserid[k] > earlyuserid[j])
									{
										DateTime t = earlyuserid[j];
										earlyuserid[j] = earlyuserid[k];
										earlyuserid[k] = t;

										int n = power[j];
										power[j] = power[k];
										power[k] = n;

										n = ids[j];
										ids[j] = ids[k];
										ids[k] = n;
									}
								}
							}
							db.Logs.Add(new Log { Msg = "4) Тут?" });
							db.SaveChanges();

							AttackGroupResult(0, ids, power, target);
							db.SaveChanges();
						}

						if (equalcount == 4)
						{
							for (int j = 1; j < 4; j++) //Проверить (Сортировка на убывание времени)
							{
								for (int k = 0; k < j; k++)
								{
									if (earlyuserid[k] > earlyuserid[j])
									{
										DateTime t = earlyuserid[j];
										earlyuserid[j] = earlyuserid[k];
										earlyuserid[k] = t;

										int n = power[j];
										power[j] = power[k];
										power[k] = n;

										n = ids[j];
										ids[j] = ids[k];
										ids[k] = n;
									}
								}
							}
							db.Logs.Add(new Log { Msg = "5) Тут" });
							db.SaveChanges();

							AttackGroupResult(0, ids, power, target);
							db.SaveChanges();
						}
					}

					db.Logs.Add(new Log { Msg = "Атака группы для команды закончилась" });
					db.SaveChanges();
				}
			}
			db.Logs.Add(new Log { Msg = "AttackGrop End" });
			db.SaveChanges();
		}

		public void AttackGroupResult(int attacker, int[] ids, int[] power, Team target)
		{
			Unit();

			int result = (power[attacker] - target.Power);

			db1.Logs.Add(new Log { Msg = "AttackGroupResult Start" });
			db1.Logs.Add(new Log { Msg = "AttackGroup result = " + result.ToString() });

			if (result > 0 &&
				db1.Moves.Where(x => x.Type == "attackgroup").Where(c => c.User.Team.TeamId == ids[attacker]).Where(n => n.Tick == db1.Ticks.Last()).Where(y => y.To == target).Where(a => a.IsUpdated == false).Count()
				== db1.Users.Where(c => c.Team.TeamId == ids[attacker]).Count())
			{
				if (target.Fuel >= result * 2)
				{
					db1.Teams.Where(n => n.TeamId == ids[attacker]).FirstOrDefault().Fuel += result * 2;
					db1.Logs.Add(new Log { Msg = "AttackGroup result = " + (result * 2).ToString() });

					db1.Teams.Where(m => m.TeamId == target.TeamId).FirstOrDefault().Fuel = target.Fuel - result * 2;

					foreach (Move move in db1.Moves.Where(x => x.Type == "attackgroup").Where(c => c.User.Team.TeamId == ids[attacker]).Where(n => n.Tick == db1.Ticks.Last()).Where(y => y.To == target).ToList())
					{
						db1.Moves.Find(move.MoveId).Result = "Победа";
						db1.Moves.Find(move.MoveId).IsUpdated = true;
						db1.SaveChanges();
					}
				}
				else
				{
					foreach (Move move in db1.Moves.Where(x => x.Type == "attackgroup").Where(c => c.User.Team.TeamId == ids[attacker]).Where(n => n.Tick == db1.Ticks.Last()).Where(y => y.To == target).ToList())
					{
						db1.Moves.Find(move.MoveId).Result = "Победа";
						db1.Moves.Find(move.MoveId).IsUpdated = true;
						db1.SaveChanges();
					}
					db1.Teams.Where(n => n.TeamId == ids[attacker]).FirstOrDefault().Fuel += target.Fuel;
					db1.Teams.Find(target.TeamId).Fuel = 0;
					db1.SaveChanges();
				}
			}
			else
			{
				foreach (Move move in db1.Moves.Where(x => x.Type == "attackgroup").Where(c => c.User.Team.TeamId == ids[attacker]).Where(n => n.Tick == db1.Ticks.Last()).Where(y => y.To == target).ToList())
				{
					db1.Moves.Find(move.MoveId).Result = "Проигрыш";
					db1.Moves.Find(move.MoveId).IsUpdated = true;
				}
			}

			db1.Logs.Add(new Log { Msg = "AttackGroupResult Finish" });
			db1.SaveChanges();
		}

		public void AttackRocket()
		{
			db.Logs.Add(new Log { Msg = "AttackRocket Start" });
			db.SaveChanges();

			if (db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackrocket").Count() != 0)
			{
				List<Move> Moves = db.Moves.Where(n => n.Tick == db.Ticks.Last()).Where(a => a.Type == "attackrocket").Include(f => f.User).Include(a => a.User.Team).Include(d => d.To).ToList(); //Можно сократить

				db.Logs.Add(new Log { Msg = "Игроков в ракете: " + db.Users.Where(a => a.InRocket == true).Count().ToString() });
				db.SaveChanges();

				if (db.Users.Where(a => a.InRocket == true).Count() == db.Settings.Last().RocketSize)
				{
					db.Logs.Add(new Log { Msg = "I'm in!" });
					db.SaveChanges();

					int i = 0; //Кол-во атакующих команд
					int defendpower = 0;
					int[] power = new int[5]; //Сила Команд
					int[] ids = new int[5]; //ID Команд
					DateTime[] earlyuserid = new DateTime[5]; //Самый ранний ход команды

					foreach (Team team in db.Teams.ToList())
					{
						if (Moves.Where(n => n.User.Team == team).FirstOrDefault() != null)
						{
							db.Logs.Add(new Log { Msg = "Провека на НЕнуль пройдена!" });
							db.SaveChanges();

							earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
							ids[i] = team.TeamId;

							foreach (Move attacker in Moves.Where(n => n.User.Team == team).ToList())
							{
								db.Logs.Add(new Log { Msg = "MoveId: " + attacker.MoveId });
								db.SaveChanges();

								db.Logs.Add(new Log { Msg = attacker.User.Name });
								db.SaveChanges();

								if (attacker.Time < earlyuserid[i])
								{
									earlyuserid[i] = Moves.Where(n => n.User.Team == team).FirstOrDefault().Time;
								}
								power[i] += attacker.User.Power;
							}
						}
						db.Logs.Add(new Log { Msg = "Attack Rocket power[" + i + "] = " + power[i].ToString() });
						db.SaveChanges();

						i++;
					}

					foreach (User defender in db.Users.Where(s => s.InRocket == true).ToList())
					{
						defendpower += defender.Power;
					}

					for (int j = 1; j < i; j++) //Проверить (Сортировка)
					{
						for (int k = 0; k < j; k++)
						{
							if (power[k] < power[j])
							{
								int n = power[j];
								power[j] = power[k];
								power[k] = n;

								n = ids[j];
								ids[j] = ids[k];
								ids[k] = n;

								DateTime t = earlyuserid[j];
								earlyuserid[j] = earlyuserid[k];
								earlyuserid[k] = t;
							}
						}
					}

					int equalcount = 1; //Количество самых сильных
					for (int j = 1; j < i; j++)
					{
						if (power[0] == power[j])
						{
							equalcount++;
						}
					}

					db.Logs.Add(new Log { Msg = "Equal = " + equalcount.ToString() + "  = " + i.ToString() });
					db.Logs.Add(new Log { Msg = "Defenders = " + defendpower.ToString() + " id = " + i.ToString() });
					db.SaveChanges();

					if (equalcount == 1)
					{
						AttackRocketResult(0, defendpower, ids, power);
						db.SaveChanges();
					}

					if (equalcount == 2)
					{

						if (earlyuserid[0] < earlyuserid[1])
						{
							AttackRocketResult(0, defendpower, ids, power);
							db.SaveChanges();
						}
						else
						{
							AttackRocketResult(1, defendpower, ids, power);
							db.SaveChanges();
						}
					}

					if (equalcount == 3)
					{
						for (int j = 1; j < 3; j++) //Проверить (Сортировка на убывание времени)
						{
							for (int k = 0; k < j; k++)
							{
								if (earlyuserid[k] > earlyuserid[j])
								{
									DateTime t = earlyuserid[j];
									earlyuserid[j] = earlyuserid[k];
									earlyuserid[k] = t;

									int n = power[j];
									power[j] = power[k];
									power[k] = n;

									n = ids[j];
									ids[j] = ids[k];
									ids[k] = n;
								}
							}
						}
						AttackRocketResult(0, defendpower, ids, power);
						db.SaveChanges();
					}

					if (equalcount == 4)
					{
						for (int j = 1; j < 4; j++) //Проверить (Сортировка на убывание времени)
						{
							for (int k = 0; k < j; k++)
							{
								if (earlyuserid[k] > earlyuserid[j])
								{
									DateTime t = earlyuserid[j];
									earlyuserid[j] = earlyuserid[k];
									earlyuserid[k] = t;

									int n = power[j];
									power[j] = power[k];
									power[k] = n;

									n = ids[j];
									ids[j] = ids[k];
									ids[k] = n;
								}
							}
						}
						AttackRocketResult(0, defendpower, ids, power);
						db.SaveChanges();
					}
				}
				db.Logs.Add(new Log { Msg = "Я вышел из большого If'а!" });
				db.SaveChanges();
			}

			db.Logs.Add(new Log { Msg = "AttackRocket End" });
			db.SaveChanges();
		}

		public void AttackRocketResult(int attacker, int defender, int[] ids, int[] power)
		{
			Unit();

			db1.Logs.Add(new Log { Msg = "AttackRocketResult Start" });
			db1.Logs.Add(new Log { Msg = "Attacker power = " + power[attacker].ToString() });
			db1.Logs.Add(new Log { Msg = "2) Deffender power = " + defender.ToString() });
			db1.Logs.Add(new Log { Msg = "Result = " + (power[attacker] - defender).ToString() });
			db1.SaveChanges();

			if ((power[attacker] - defender) > 0)
			{
				foreach (User user in db.Users.Where(n => n.InRocket == true))
				{
					db1.Logs.Add(new Log { Msg = "user = " + user.InRocket.ToString() });

					db1.Users.Find(user.UserId).InRocket = false;
					db1.Moves.Where(m => m.User == user).Where(n => n.Tick == db1.Ticks.Last()).FirstOrDefault().Result = "Выбит";
					db1.SaveChanges();
				}

				foreach (Move move in db1.Moves.Where(n => n.Tick == db1.Ticks.Last()).Where(x => x.Type == "attackrocket").Where(c => c.User.Team.TeamId == ids[attacker]).ToList())
				{
					db1.Moves.Find(move.MoveId).Result = "Победа";
					db1.Moves.Find(move.MoveId).IsUpdated = true;
					db1.SaveChanges();
				}
			}
			else
			{
				db1.Logs.Add(new Log { Msg = "if = false" });
				foreach (Move move in db1.Moves.Where(n => n.Tick == db1.Ticks.Last()).Where(x => x.Type == "attackrocket").Where(c => c.User.Team.TeamId == ids[attacker]).ToList())
				{
					db1.Moves.Find(move.MoveId).Result = "Проигрыш";
					db1.Moves.Find(move.MoveId).IsUpdated = true;
					db1.SaveChanges();
				}
			}

			db1.Logs.Add(new Log { Msg = "AttackRocetResult Finish" });
			db1.SaveChanges();
		}

		#endregion

		#region Debug

		public string Debug()
        {
            Tick tick = new Tick();
            Setting setting = new Setting();

            //Настройки
            setting.RocketFuel = 2;
            setting.RocketSize = 3;
            setting.TeamCount = 4;
            setting.TimeTick = 1;
            setting.TimeGame = 4;
            setting.TeamSize = 3;
            db.Settings.Add(setting);

            //Добавление групп

            //team.Name = "Красные";
            //team.Power = 5;
            //db.Teams.Add(team);

            Team team1 = new Team();
            team1.Name = "Blue";
            team1.Power = 3;
            team1.Fuel = 7;
            db.Teams.Add(team1);
            db.SaveChanges();

            Team team2 = new Team();
            team2.Name = "Yellow";
            team2.Power = 7;
            team2.Fuel = 2;
            db.Teams.Add(team2);
            db.SaveChanges();

            Team team3 = new Team();
            team3.Name = "Green";
            team3.Power = 3;
            team3.Fuel = 9;
            db.Teams.Add(team3);
            db.SaveChanges();

            Team team4 = new Team();
            team4.Name = "Red";
            team4.Power = 3;
            team4.Fuel = 5;
            db.Teams.Add(team4);
            db.SaveChanges();

            //Добавлене игроков

            User user1 = new User();
            user1.Team = db.Teams.Where(b => b.Name == "Blue").FirstOrDefault();
            user1.Name = "Player11";
            user1.Power = 1;
            user1.Intellect = 2;
            db.Users.Add(user1);
            db.SaveChanges();

            User user2 = new User();
            user2.Team = db.Teams.Where(b => b.Name == "Blue").FirstOrDefault();
            user2.Name = "Player12";
            user2.Power = 1;
            user2.Intellect = 3;
            db.Users.Add(user2);
            db.SaveChanges();

            User user3 = new User();
            user3.Team = db.Teams.Where(b => b.Name == "Blue").FirstOrDefault();
            user3.Name = "Player13";
            user3.Power = 1;
            user3.Intellect = 2;
            db.Users.Add(user3);
            db.SaveChanges();

            User user4 = new User();
            user4.Team = db.Teams.Where(b => b.Name == "Yellow").FirstOrDefault();
            user4.Name = "Player21";
            user4.Power = 1;
            user4.Intellect = 3;
            db.Users.Add(user4);
            db.SaveChanges();

            User user5 = new User();
            user5.Team = db.Teams.Where(b => b.Name == "Yellow").FirstOrDefault();
            user5.Name = "Player22";
            user5.Power = 4;
            user5.Intellect = 1;
            db.Users.Add(user5);
            db.SaveChanges();

            User user6 = new User();
            user6.Team = db.Teams.Where(b => b.Name == "Yellow").FirstOrDefault();
            user6.Name = "Player23";
            user6.Power = 2;
            user6.Intellect = 2;
            db.Users.Add(user6);
            db.SaveChanges();

            User user7 = new User();
            user7.Team = db.Teams.Where(b => b.Name == "Green").FirstOrDefault();
            user7.Name = "Player31";
            user7.Power = 1;
            user7.Intellect = 2;
            db.Users.Add(user7);
            db.SaveChanges();

            User user8 = new User();
            user8.Team = db.Teams.Where(b => b.Name == "Green").FirstOrDefault();
            user8.Name = "Player32";
            user8.Power = 1;
            user8.Intellect = 1;
            db.Users.Add(user8);
            db.SaveChanges();

            User user9 = new User();
            user9.Team = db.Teams.Where(b => b.Name == "Green").FirstOrDefault();
            user9.Name = "Player33";
            user9.Power = 1;
            user9.Intellect = 5;
            db.Users.Add(user9);
            db.SaveChanges();

            User user10 = new User();
            user10.Team = db.Teams.Where(b => b.Name == "Red").FirstOrDefault();
            user10.Name = "Player41";
            user10.Power = 1;
            user10.Intellect = 2;
            db.Users.Add(user10);
            db.SaveChanges();

            User user11 = new User();
            user11.Team = db.Teams.Where(b => b.Name == "Red").FirstOrDefault();
            user11.Name = "Player42";
            user11.Power = 1;
            user11.Intellect = 3;
            db.Users.Add(user11);
            db.SaveChanges();

            User user12 = new User();
            user12.Team = db.Teams.Where(b => b.Name == "Red").FirstOrDefault();
            user12.Name = "Player43";
            user12.Power = 1;
            user12.Intellect = 6;
            db.Users.Add(user12);
            db.SaveChanges();

            StartGame();

            //Добавление Тактов
            tick.Number = 1;
            db.Ticks.Add(tick);

            //Добавление действий
            Move move1 = new Move();
            move1.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move1.User = db.Users.Where(m => m.Name == "Player11").FirstOrDefault();
            move1.Type = "intellectup";
            //move1.To = db.Teams.Where(c => c.Name == "Yellow").FirstOrDefault();
            move1.Time = DateTime.Now;
            db.Moves.Add(move1);
            db.SaveChanges();

            Move move2 = new Move();
            move2.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move2.User = db.Users.Where(m => m.Name == "Player12").FirstOrDefault();
            move2.Type = "intellectup";
            //move2.To = db.Teams.Where(c => c.Name == "Yellow").FirstOrDefault();
            move2.Time = DateTime.Now;
            db.Moves.Add(move2);
            db.SaveChanges();

            Move move3 = new Move();
            move3.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move3.User = db.Users.Where(m => m.Name == "Player13").FirstOrDefault();
            move3.Type = "intellectup";
            //move3.To = db.Teams.Where(c => c.Name == "Yellow").FirstOrDefault();
            move3.Time = DateTime.Now;
            db.Moves.Add(move3);
            db.SaveChanges();

            Move move4 = new Move();
            move4.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move4.User = db.Users.Where(m => m.Name == "Player21").FirstOrDefault();
            move4.Type = "intellectup";
            //move4.To = db.Teams.Where(c => c.Name == "Blue").FirstOrDefault();
            move4.Time = DateTime.Now;
            db.Moves.Add(move4);
            db.SaveChanges();

            Move move5 = new Move();
            move5.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move5.User = db.Users.Where(m => m.Name == "Player22").FirstOrDefault();
            move5.Type = "attackgroup";
            move5.To = db.Teams.Where(c => c.Name == "Blue").FirstOrDefault();
            move5.Time = DateTime.Now;
            db.Moves.Add(move5);
            db.SaveChanges();

            Move move6 = new Move();
            move6.Tick = db.Ticks.Where(s => s.Number == 1).FirstOrDefault();
            move6.User = db.Users.Where(m => m.Name == "Player23").FirstOrDefault();
            move6.Type = "intellectup";
            move6.Time = DateTime.Now;
            db.Moves.Add(move6);
            db.SaveChanges();

            Update();

            
   //         tick.Number = 2;
   //         db.Ticks.Add(tick);

   //         Update();

   //         tick.Number = 3;
   //         db.Ticks.Add(tick);
   //         Update();
			//db.SaveChanges();

			return "Все хорошо!";
        }

		#endregion

    }
}