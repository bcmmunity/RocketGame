#pragma checksum "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9397ad34e5220dd224819e7a8ec35f817c06f8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Game), @"mvc.1.0.view", @"/Views/Home/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Game.cshtml", typeof(AspNetCore.Views_Home_Game))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame;

#line default
#line hidden
#line 2 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9397ad34e5220dd224819e7a8ec35f817c06f8f", @"/Views/Home/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
  
	ViewData["Title"] = "Игра";

#line default
#line hidden
            BeginContext(39, 1058, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js""></script>
<h2 id=""warning""></h2>

<div id=""moves"">
	<span class=""btn"" onclick=""move = 'powerup'; choose = 'Усилиться'; Confirme()"">Усилиться</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'intellectup'; choose = 'Обучиться'; Confirme()"">Обучиться</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'gather'; choose = 'Добыть'; Confirme()"">Добыть</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'attackgroup'; choose = 'Атаковать группу'; selectTeam()"">Атаковать группу</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'attackrocket'; choose = 'Атаковать ракету'; Confirme()"">Атаковать ракету</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'gift'; choose = 'Дарить'; selectTeam()"">Дарить</span>
	</br>
	</br>
	<span id=""getinrocket"" class='btn' onclick=""move = 'getinrocket'; choose = 'Сесть в ракету'; Confirme()"">Сесть в ракету</span>
	</br>
	</br>
</div>
<div id=""teams"">
</di");
            WriteLiteral("v>\r\n<div id=\"res\">\r\n\t<h1 id=\"msg\">");
            EndContext();
            BeginContext(1098, 11, false);
#line 35 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
            Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 19, true);
            WriteLiteral("</h1>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1290, 38, true);
            WriteLiteral("\r\n<h3 id=\"kp\">Ключ игрока: </h3>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1584, 67, true);
            WriteLiteral("\r\n<script>\r\n\t$(\"#kp\").empty();\r\n\t$(\"#kp\").append(\"Ключ игрока: \" + ");
            EndContext();
            BeginContext(1652, 11, false);
#line 52 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                                 Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 456, true);
            WriteLiteral(@");

	function io() {
		document.getElementById(""k1"").href = ""/Home/Game?Key="" + $(""#k"").val();
		$(""#kp"").empty();
		$(""#kp"").append(""Ключ игрока: "" + $(""#k"").val());
	}

</script>

<h3>Таблица результатов:</h3>
<div id=""cont"" style=""margin-top: 0px;"">
	<table class=""card stst"" id=""table1"" style=""background-color: darkgray"">
		<thead>
			<tr>
				<th> Ком(Т) </th>
				<th> Ник </th>
				<th> С/И </th>
			</tr>
		</thead>
		<tbody>
");
            EndContext();
#line 73 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
             for (int i = 0; i < ViewBag.i; i++)
			{

#line default
#line hidden
            BeginContext(2166, 18, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2184, "\"", 2193, 2);
            WriteAttributeValue("", 2189, "0-", 2189, 2, true);
#line 76 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
WriteAttributeValue("", 2191, i, 2191, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2194, 9, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2204, 19, false);
#line 77 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                   Write(ViewBag.users[i, 0]);

#line default
#line hidden
            EndContext();
            BeginContext(2223, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2255, 19, false);
#line 80 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                   Write(ViewBag.users[i, 2]);

#line default
#line hidden
            EndContext();
            BeginContext(2274, 22, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2296, "\"", 2305, 2);
            WriteAttributeValue("", 2301, "1-", 2301, 2, true);
#line 82 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
WriteAttributeValue("", 2303, i, 2303, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2306, 9, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2316, 19, false);
#line 83 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                   Write(ViewBag.users[i, 3]);

#line default
#line hidden
            EndContext();
            BeginContext(2335, 25, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 86 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
			}

#line default
#line hidden
            BeginContext(2366, 242, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\r\n\t<div id=\"content\">\r\n\t</div>\r\n</div>\r\n\r\n<script>\r\n\r\n\tsetInterval(metod, 7000);\r\n\r\n\tfunction metod() {\r\n\t\t$.ajax({\r\n\t\t\ttype: \"GET\",\r\n\t\t\turl: \"/Game/Stats\",\r\n\r\n\t\t\tsuccess: function (result) {\r\n\r\n\t\t\t\tfor (var i = 0; i < ");
            EndContext();
            BeginContext(2609, 9, false);
#line 105 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                               Write(ViewBag.i);

#line default
#line hidden
            EndContext();
            BeginContext(2618, 1258, true);
            WriteLiteral(@" ; i++) {
					$(""#0-"" + i).empty();
					$(""#0-"" + i).append(result[i][0]);
					$(""#1-"" + i).empty();
					$(""#1-"" + i).append(result[i][1]);
				}

			}
		});

		$.ajax({
			type: ""GET"",
			url: ""/Tick/GetTick"",
			data: {type: 0},

			success: function (result) {

				if (result != """") {
					$(""#content"").empty();
					$(""#content"").append(result);
				}
			}
		});
	}
</script>

<style>

	.stst {
		white-space: nowrap;
		float: left;
	}

	.stst1 {
		white-space: nowrap;
	}

	body {
		margin: 0;
		display: flex;
		justify-content: center;
	}

	.card {
		white-space: nowrap;
	}

	#cont {
		background-color: #fff;
		min-height: 200px;
		max-width: 100%;
		-webkit-overflow-scrolling: touch;
		margin-top: 0px;
	}

	#content {
		background-color: #fff;
		min-height: 200px;
		max-width: 100%;
		display: flex;
		overflow-x: auto;
		overflow-y: auto;
		-webkit-overflow-scrolling: touch;
		margin-top: 0px;
	}

	.ft {
		background-color: darkgray;
");
            WriteLiteral("\t\tborder: solid 1px;\r\n\t}\r\n\r\n\ttr {\r\n\t\theight: 30px;\r\n\t\tborder-bottom: solid 1px;\r\n\t}\r\n\r\n\tth {\r\n\t\tmin-width: 20px;\r\n\t\tborder-left: solid 1px;\r\n\t\tborder-right: solid 1px;\r\n\t\tborder-top: solid 1px;\r\n\t\ttext-align: center;\r\n\t}\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(3876, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79686303d81145ffbe78961a8f8e4700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3921, 1904, true);
            WriteLiteral(@"

<div style=""float: none; clear: both""></div>

<div>
	<h2>
		Обозначение действий:
	</h2>
	<p>
		У — усилиться </br>
		О — обучиться </br>
		Т — добыть топливо </br>
		Д — дарить </br>
		А — атаковать группу </br>
		АР — атаковать ракету </br>
		Р — сесть в ракету </br>
	</p>
	<p>
		Обозначение команд: </br>
		К — красные </br>
		З — зеленые </br>
		С — синие </br>
		Ж — желтые </br>
		Ф — фиолетовые </br>
	</p>
    <p>
        Обозначения результатов: </br>
        ДК:V — подарил красной команде, успешно </br>
        ДЗ:X — подарил зеленой команде, провал </br>
        АС:W — атаковал синих, победа </br>
        АЖ:L — атаковал желтых, поражение </br>
        АР:W — атаковал ракету, победа </br>
        АР:L — атаковал ракету, поражение </br>
        Р — сел в ракету, но не хватило силы + интеллекта или топлива у команды </br>
        Р:В — сел в ракету, но был выбит </br>
        Р:П — сел в ракету и победил </br>
    </p>
</div>

<div id=""modal"">

</div>

<div c");
            WriteLiteral(@"lass=""modal-overlay"" id=""modal-overlay""></div>

<script type=""text/javascript"">
	var move = ""s"";
	var choose = ""s"";
	var opt = """";
	var team = ""0"";
	var checkk = true;
	var table = true;
	var isfin = true;

	var proces = true;
	$('#modal').hide();
	$('#modal-overlay').hide();
	$('#kk').hide();
	$(""#moves"").hide();
	$(""#teams"").hide();
	$(""#msg"").empty();
	$(""#msg"").append(""Игра еще не началась"");

	setInterval(check, 7000);

	var chk = true;

	function check() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/TimeCheck"",

			success: function (result) {
			}
		});

		$.ajax({
			type: ""GET"",
			url: ""/Game/LastTickCheck"",

			success: function (result) {
				if (result && chk) {
					$(""#warning"").append(""ПОСЛЕДНИЙ ТАКТ"");
					chk = false;
				}
			}
		});

		$.ajax({
			type: ""GET"",
			url: ""/Game/KeyCheck"",
			data: { Key: ");
            EndContext();
            BeginContext(5826, 11, false);
#line 281 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                    Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(5837, 431, true);
            WriteLiteral(@" },

			success: function (result) {
				if (result) {

					if (!checkk) {
						$(""#kk"").hide();

						$(""#kp"").show();
						$(""#k1"").show();
						$(""#k2"").show();
						$('#k').show();
						return;
					}
					$(""#kk"").show();

					$(""#kp"").hide();
					$(""#k1"").hide();
					$(""#k2"").hide();
					$('#k').hide();

					$.ajax({
						type: ""GET"",
						url: ""/Game/RocketCheck"",
						data: { Key: ");
            EndContext();
            BeginContext(6269, 11, false);
#line 305 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                                Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(6280, 276, true);
            WriteLiteral(@" },

						success: function (result) {
							if (result) {
								$(""#getinrocket"").show();
							}
							else {
								$(""#getinrocket"").hide();
							}
						}
					});

					$.ajax({
						type: ""GET"",
						url: ""/Game/MoveCheck"",
						data: { Key: ");
            EndContext();
            BeginContext(6557, 11, false);
#line 320 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                                Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(6568, 1308, true);
            WriteLiteral(@" },

						success: function (result) {
							if (result == ""Ход не сделан"") {

								if (table) {
									metod();
								}


								$(""#msg"").hide();
								$(""#teams"").hide();
								$(""#moves"").show();

								table = false;
							}
							else if (result == ""Выжившие улетели!"" || result == ""Все погибли!"") {
								$.ajax({
									type: ""GET"",
									url: ""/Game/GameResult"",

									success: function (result1) {
										if (result1 != ""NotFinished"" && isfin) {
											alert(result1);

											table = true;

											$(""#msg"").empty();
											$(""#msg"").append(result1);
											$(""#msg"").show();
											$(""#teams"").hide();
											$(""#moves"").hide();
											isfin = false;
										}
									}
								});
							}
							else {
								table = true;
								$(""#msg"").empty();
								$(""#msg"").append(result);
								$(""#msg"").show();
								$(""#teams"").hide();
								$(""#moves"").hide();
							}
						}
					});
	");
            WriteLiteral(@"			}
				else {
					$(""#teams"").hide();
					$(""#moves"").hide();
					$(""#msg"").empty();
					$(""#msg"").show();
					$(""#msg"").append(""Неверный ключ"");
				}
			}
		});
	}

	function selectTeam() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/TeamList"",
			data: { Key: ");
            EndContext();
            BeginContext(7877, 11, false);
#line 383 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                    Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(7888, 754, true);
            WriteLiteral(@" },

			success: function (result) {
				checkk = false;
				$(""#moves"").hide();
				$(""#msg"").hide();

				$(""#teams"").empty();
				$(""#teams"").show();
				//$(""#teams"").append(result);

				//alert(result[1].teamId);

				var i = 0;
				for (var item in result) {
					$(""#teams"").append(""<span class='btn' onclick=\""team = "" + result[i].teamId + ""; checkk = true;choose += '"" + result[i].name + ""'; Confirme()\"">"" + result[i].name + ""</span></br></br>"");
					i++;
				}
				$(""#teams"").append(""<span class='btn' onclick='checkk = true;$(\""#moves\"").show();$(\""#teams\"").hide();'>Отменить</span></br></br>"");
			}
		});
	}

	function makeMove() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/Make"",
			data: { Type: move, Key: ");
            EndContext();
            BeginContext(8643, 11, false);
#line 410 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                                Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(8654, 970, true);
            WriteLiteral(@", TeamId: team },

			success: function (result) {

				$(""#moves"").hide();
				$(""#teams"").hide();

				$(""#msg"").empty();
				$(""#msg"").show();
				$(""#msg"").append(result);
			}
		});
	}

	function Confirme() {
		checkk = false;
		$(""#moves"").hide();
		$(""#teams"").empty();
		$(""#teams"").show();
		$(""#modal"").empty();
		$(""#modal"").show();

		$(""#modal-overlay"").show();
		$(""#modal"").append(""Ваше действие: "" + choose + ""<br>"")
		$(""#modal"").append(""<a><span class='btnn' onclick='checkk = true;$(\""#moves\"").show();$(\""#teams\"").hide();$(\""#modal\"").hide();$(\""#modal-overlay\"").hide();' style='background-color: red'>Отменить</span></a>"");
		$(""#modal"").append(""<a><span class='btnn' onclick='checkk = true;makeMove();$(\""#teams\"").hide();$(\""#modal\"").hide();$(\""#modal-overlay\"").hide();' style='background-color: green'>Подтвердить</span></a></br></br>"");
	}

		$.ajax({
			type: ""GET"",
			url: ""/Game/KeyCheck"",
			data: { Key: ");
            EndContext();
            BeginContext(9625, 11, false);
#line 441 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                    Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(9636, 431, true);
            WriteLiteral(@" },

			success: function (result) {
				if (result) {

					if (!checkk) {
						$(""#kk"").hide();

						$(""#kp"").show();
						$(""#k1"").show();
						$(""#k2"").show();
						$('#k').show();
						return;
					}
					$(""#kk"").show();

					$(""#kp"").hide();
					$(""#k1"").hide();
					$(""#k2"").hide();
					$('#k').hide();

					$.ajax({
						type: ""GET"",
						url: ""/Game/RocketCheck"",
						data: { Key: ");
            EndContext();
            BeginContext(10068, 11, false);
#line 465 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                                Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(10079, 276, true);
            WriteLiteral(@" },

						success: function (result) {
							if (result) {
								$(""#getinrocket"").show();
							}
							else {
								$(""#getinrocket"").hide();
							}
						}
					});

					$.ajax({
						type: ""GET"",
						url: ""/Game/MoveCheck"",
						data: { Key: ");
            EndContext();
            BeginContext(10356, 11, false);
#line 480 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                                Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(10367, 1414, true);
            WriteLiteral(@" },

						success: function (result) {
							if (result == ""Ход не сделан"") {

								if (table) {
									metod();
								}


								$(""#msg"").hide();
								$(""#teams"").hide();
								$(""#moves"").show();

								table = false;
							}
							else {
								table = true;
								$(""#msg"").empty();
								$(""#msg"").append(result);
								$(""#msg"").show();
								$(""#teams"").hide();
								$(""#moves"").hide();
							}
						}
					});
				}
				else {
					$(""#teams"").hide();
					$(""#moves"").hide();
					$(""#msg"").empty();
					$(""#msg"").show();
					$(""#msg"").append(""Неверный ключ"");
				}
			}
	});

</script>

<style type=""text/css"">

	.modal-overlay {
		opacity: 0.5;
		background-color: black;
		z-index: 1000;
		position: fixed;
		top: 0;
		left: 0;
		width: 100%;
		height: 100%;
	}

	.btn {
		min-width: 20%;
		min-height: 20px;
		background-color: gray;
		border-radius: 200px;
		padding: 5px;
		float: left;
		color: white;
	}

	.b");
            WriteLiteral(@"tnn {
		min-width: 20%;
		min-height: 20px;
		background-color: gray;
		border-radius: 200px;
		padding: 5px;
		float: left;
		color: white;
		margin: 10px;
	}

	.info {
		color: gray;
	}

	#modal {
		margin-left: auto;
		margin-right: auto;
		padding: 15px;
		z-index: 1010;
		top: 25%;
		display: block;
		position: fixed;
		background-color: white;
	}
</style>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
