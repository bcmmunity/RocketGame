using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using RocketGame.Models;

namespace RocketGame.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class GSheetsController : ControllerBase
    {
        private string Credentials = "credentials.json";
        private readonly string[] ScopesSheets = { SheetsService.Scope.Spreadsheets };
        private readonly string AppName = "Google Sheets API .NET Quickstart";
        private readonly string SpreadsheetId = "11JB5cruILtYvnZMN6mRDo8lE_8T9_asmRFCyUxIbN8Y";
        public string Range = "'Лист1'!A2:E";

        private MyContext db;

        public GSheetsController(MyContext context)
        {
            db = context;
        }


        public void InsertTickResult()
        {

            db.Logs.Add(new Log { Msg = "I'm working" });
            db.SaveChanges();

            int i = 3 * db.Ticks.Last().Number;

            var credential = GetSheetCredentials();
            var service = GetService(credential);

            //Заполняем номер такта и названия колонок
            FillTickColumn(service, SpreadsheetId, i);
            AddToTickColumns(service, SpreadsheetId, i);
            FormatTickCell(service, SpreadsheetId, i);

            //Вводим результаты такта
            FillMovesColumn(service, SpreadsheetId, i);

            //Заполняем топливо команды и статы юзеров
            FillTeams(service, SpreadsheetId);
            FillStats(service, SpreadsheetId);

            //FormatTeams(service, SpreadsheetId);
            //FillUsers(service, SpreadsheetId);

            //Console.WriteLine("Getting result");
            //string result = GetFirstCell(service, SpreadsheetId);
            //Console.WriteLine("result: {0}", result);
        }

        public void InsertUsers()
        {
            var credential = GetSheetCredentials();
            var service = GetService(credential);

            //Заполняем команды, юзеров и статы
            FillTeams(service, SpreadsheetId);
            FormatTeams(service, SpreadsheetId);
            FillUsers(service, SpreadsheetId);
            FillStats(service, SpreadsheetId);
        }

        private UserCredential GetSheetCredentials()
        {
            using (var stream = new FileStream(Credentials, FileMode.Open, FileAccess.Read))
            {
                var credPath = Path.Combine(Directory.GetCurrentDirectory(), "sheetCreds.json");

                return GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    ScopesSheets,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
        }

        private SheetsService GetService(UserCredential credential)
        {
            return new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = AppName
            });
        }

        public void FillTickColumn(SheetsService service, string SpreadsheetId, int InsertColumn)
        {
            string[,] TickData = { { "Такт " + db.Ticks.Last().Number.ToString() } };
            List<Request> requests = new List<Request>();
            for (int i = 0; i < TickData.GetLength(0); i++)
            {
                List<CellData> values = new List<CellData>();
                for (int j = 0; j < TickData.GetLength(1); j++)
                {
                    values.Add(new CellData
                    {
                        UserEnteredValue = new ExtendedValue
                        {
                            StringValue = TickData[i, j]
                        }
                    });
                }

                requests.Add(
                    new Request
                    {
                        UpdateCells = new UpdateCellsRequest
                        {
                            Start = new GridCoordinate
                            {
                                SheetId = 0,
                                RowIndex = 0,
                                ColumnIndex = 1 + InsertColumn,
                            },
                            Rows = new List<RowData> { new RowData { Values = values } },
                            Fields = "userEnteredValue"
                        }
                    });

                BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest
                {
                    Requests = requests
                };
                service.Spreadsheets.BatchUpdate(busr, SpreadsheetId).Execute();
            }
        }

        public void AddToTickColumns(SheetsService service, string SpreadsheetId, int InsertColumn)
        {
            string[,] Data = { { "Действие", "Цель", "Результат" } };
            List<Request> requests = new List<Request>();
            for (int i = 0; i < Data.GetLength(0); i++)
            {
                List<CellData> values = new List<CellData>();
                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    values.Add(new CellData
                    {
                        UserEnteredValue = new ExtendedValue
                        {
                            StringValue = Data[i, j]
                        }
                    });
                }

                requests.Add(
                    new Request
                    {
                        UpdateCells = new UpdateCellsRequest
                        {
                            Start = new GridCoordinate
                            {
                                SheetId = 0,
                                RowIndex = 1,
                                ColumnIndex = 1 + InsertColumn,
                            },
                            Rows = new List<RowData> { new RowData { Values = values } },
                            Fields = "userEnteredValue"
                        }
                    });
            }

            BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest
            {
                Requests = requests
            };
            service.Spreadsheets.BatchUpdate(busr, SpreadsheetId).Execute();
        }

        public void FormatTickCell(SheetsService service, string SpreadsheetId, int i)
        {
            List<Request> requests = new List<Request>();

            requests.Add(
                new Request
                {
                    MergeCells = new MergeCellsRequest
                    {
                        Range = new GridRange
                        {
                            SheetId = 0,
                            StartColumnIndex = 1 + i,
                            EndColumnIndex = 4 + i,
                            StartRowIndex = 0,
                            EndRowIndex = 1,
                        },
                        //Rows = new List<RowData> { new RowData { Values = values } },
                        MergeType = "MERGE_ROWS"
                    }
                });

            BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest
            {
                Requests = requests
            };
            service.Spreadsheets.BatchUpdate(busr, SpreadsheetId).Execute();
        }

        public void FillUsers(SheetsService service, string SpreadsheetId)
        {
            int index = 0;
            int number = 1;
            foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
            {
                foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(m => m.Name).ToList())
                {
                    string[,] userdata = { { number.ToString(), user.Name } };
                    List<Request> requests = new List<Request>();
                    for (int i = 0; i < userdata.GetLength(0); i++)
                    {
                        List<CellData> values = new List<CellData>();
                        for (int j = 0; j < userdata.GetLength(1); j++)
                        {
                            values.Add(new CellData
                            {
                                UserEnteredValue = new ExtendedValue
                                {
                                    StringValue = userdata[i, j]
                                }
                            });
                        }

                        requests.Add(
                            new Request
                            {
                                UpdateCells = new UpdateCellsRequest
                                {
                                    Start = new GridCoordinate
                                    {
                                        SheetId = 0,
                                        RowIndex = 2 + index,
                                        ColumnIndex = 1,
                                    },
                                    Rows = new List<RowData> { new RowData { Values = values } },
                                    Fields = "userEnteredValue"
                                }
                            });

                        BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest
                        {
                            Requests = requests
                        };
                        service.Spreadsheets.BatchUpdate(busr, SpreadsheetId).Execute();
                    }
                    index++;
                    number++;
                }
            }
        }

        public void FillStats(SheetsService service, string SpreadsheetId)
        {
            int index = 0;
            foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
            {
                foreach (User user in db.Users.Where(n => n.Team == team).OrderBy(m => m.Name).ToList())
                {
                    string[,] userdata = { { user.Power + "/" + user.Intellect } };
                    List<Request> requests = new List<Request>();
                    for (int i = 0; i < userdata.GetLength(0); i++)
                    {
                        List<CellData> values = new List<CellData>();
                        for (int j = 0; j < userdata.GetLength(1); j++)
                        {
                            values.Add(new CellData
                            {
                                UserEnteredValue = new ExtendedValue
                                {
                                    StringValue = userdata[i, j]
                                }
                            });
                        }

                        requests.Add(
                            new Request
                            {
                                UpdateCells = new UpdateCellsRequest
                                {
                                    Start = new GridCoordinate
                                    {
                                        SheetId = 0,
                                        RowIndex = 2 + index,
                                        ColumnIndex = 3,
                                    },
                                    Rows = new List<RowData> { new RowData { Values = values } },
                                    Fields = "userEnteredValue"
                                }
                            });

                        BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest
                        {
                            Requests = requests
                        };
                        service.Spreadsheets.BatchUpdate(busr, SpreadsheetId).Execute();
                    }
                    index++;
                }
            }
        }

        public void FillTeams(SheetsService service, string SpreadsheetId)
        {
            int size = db.Settings.FirstOrDefault().TeamSize;
            int index = 0;
            int check = 0;
            foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
            {
                if (check == db.Settings.FirstOrDefault().TeamCount)
                {
                    break;
                }

                string[,] userdata = { { "" + team.TeamId.ToString() + "("+team.Fuel+")" } };
                List<Request> requests = new List<Request>();
                for (int i = 0; i < userdata.GetLength(0); i++)
                {
                    List<CellData> values = new List<CellData>();
                    for (int j = 0; j < userdata.GetLength(1); j++)
                    {
                        values.Add(new CellData
                        {
                            UserEnteredValue = new ExtendedValue
                            {
                                StringValue = userdata[i, j]
                            }
                        });
                    }

                    requests.Add(
                        new Request
                        {
                            UpdateCells = new UpdateCellsRequest
                            {
                                Start = new GridCoordinate
                                {
                                    SheetId = 0,
                                    RowIndex = 2 + index,
                                    ColumnIndex = 0,
                                },
                                Rows = new List<RowData> { new RowData { Values = values } },
                                Fields = "userEnteredValue"
                            }
                        });
                    BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest
                    {
                        Requests = requests
                    };
                    service.Spreadsheets.BatchUpdate(busr, SpreadsheetId).Execute();
                }

                check++;
                index += size;
            }
        }

        public void FormatTeams(SheetsService service, string SpreadsheetId)
        {
            int size = db.Settings.FirstOrDefault().TeamSize;
            int index = 0;
            int check = 0;
            foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
            {
                if (check == db.Settings.FirstOrDefault().TeamCount)
                {
                    break;
                }
                List<Request> requests = new List<Request>();

                requests.Add(
                    new Request
                    {
                        MergeCells = new MergeCellsRequest
                        {
                            Range = new GridRange
                            {
                                SheetId = 0,
                                StartColumnIndex = 0,
                                EndColumnIndex = 1,
                                StartRowIndex = 2 + index,
                                EndRowIndex = 2 + size + index,
                            },
                            //Rows = new List<RowData> { new RowData { Values = values } },
                            MergeType = "MERGE_COLUMNS"
                        }
                    });

                BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest
                {
                    Requests = requests
                };
                service.Spreadsheets.BatchUpdate(busr, SpreadsheetId).Execute();
                check++;
                index += size;
            }
        }

        public void FillMovesColumn(SheetsService service, string SpreadsheetId, int InsertColumn)
        {
            int index = 0;
            foreach (Team team in db.Teams.OrderBy(n => n.TeamId).ToList())
            {
                foreach (Move move in db.Moves.Where(n => n.User.Team == team).Where(m => m.Tick == db.Ticks.Last()).OrderBy(m => m.User.Name).ToList())
                {
                    string target;
                    if (move.Result == null)
                    {
                        move.Result = "";
                    }
                    if (move.To == null)
                    {
                        target = "";
                    }
                    else
                    {
                        target = move.To.Name;
                    }

                    
                    string[,] movedata = { { move.Type, target, move.Result } };
                    List<Request> requests = new List<Request>();
                    for (int i = 0; i < movedata.GetLength(0); i++)
                    {
                        List<CellData> values = new List<CellData>();
                        for (int j = 0; j < movedata.GetLength(1); j++)
                        {
                            values.Add(new CellData
                            {
                                UserEnteredValue = new ExtendedValue
                                {
                                    StringValue = movedata[i, j]
                                }
                            });
                        }

                        requests.Add(
                            new Request
                            {
                                UpdateCells = new UpdateCellsRequest
                                {
                                    Start = new GridCoordinate
                                    {
                                        SheetId = 0,
                                        RowIndex = 2 + index,
                                        ColumnIndex = 1 + InsertColumn,
                                    },
                                    Rows = new List<RowData> { new RowData { Values = values } },
                                    Fields = "userEnteredValue"
                                }
                            });

                        BatchUpdateSpreadsheetRequest busr = new BatchUpdateSpreadsheetRequest
                        {
                            Requests = requests
                        };
                        service.Spreadsheets.BatchUpdate(busr, SpreadsheetId).Execute();
                    }
                    index++;
                }
            }
        }

        //Извлечение значения ячеек

        //private static string GetFirstCell(SheetsService service, string SpreadsheetId)
        //{
        //    SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(SpreadsheetId, range);
        //    ValueRange response = request.Execute();

        //    string result = null;
        //    foreach (var value in response.Values)
        //    {
        //        result += " " + value[0];
        //    }
        //    return result;
        //}
    }
}