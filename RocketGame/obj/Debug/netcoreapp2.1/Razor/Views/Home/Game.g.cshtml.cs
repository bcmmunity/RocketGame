#pragma checksum "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff4e7e24cca459d08a8b00f10f0244edca97baa"
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
#line 1 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame;

#line default
#line hidden
#line 2 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff4e7e24cca459d08a8b00f10f0244edca97baa", @"/Views/Home/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
  
	ViewData["Title"] = "Игра";

#line default
#line hidden
            BeginContext(39, 281, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js""></script>
<h2 id=""warning""></h2>

<table id=""ft"">
	<thead>
		<tr>
			<th> Команда</th>
			<th> Топливо</th>
			<th> Ник игрока</th>
			<th> Сила/Интеллект</th>
		</tr>
	</thead>
	<tbody>
");
            EndContext();
#line 19 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
         for (int i = 0; i < ViewBag.i; i++)
		{

#line default
#line hidden
            BeginContext(365, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(390, 19, false);
#line 23 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
               Write(ViewBag.users[i, 0]);

#line default
#line hidden
            EndContext();
            BeginContext(409, 20, true);
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 429, "\"", 438, 2);
            WriteAttributeValue("", 434, "1-", 434, 2, true);
#line 25 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
WriteAttributeValue("", 436, i, 436, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(439, 8, true);
            WriteLiteral(">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(448, 19, false);
#line 26 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
               Write(ViewBag.users[i, 1]);

#line default
#line hidden
            EndContext();
            BeginContext(467, 28, true);
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(496, 19, false);
#line 29 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
               Write(ViewBag.users[i, 2]);

#line default
#line hidden
            EndContext();
            BeginContext(515, 20, true);
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 535, "\"", 544, 2);
            WriteAttributeValue("", 540, "2-", 540, 2, true);
#line 31 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
WriteAttributeValue("", 542, i, 542, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(545, 8, true);
            WriteLiteral(">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(554, 19, false);
#line 32 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
               Write(ViewBag.users[i, 3]);

#line default
#line hidden
            EndContext();
            BeginContext(573, 23, true);
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 35 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
		}

#line default
#line hidden
            BeginContext(601, 246, true);
            WriteLiteral("\t</tbody>\r\n</table>\r\n<div id=\"content\">\r\n</div>\r\n\r\n<script>\r\n\tvar number = 1;\r\n\r\n\tsetInterval(metod, 1000);\r\n\r\n\tfunction metod() {\r\n\t\t$.ajax({\r\n\t\t\ttype: \"GET\",\r\n\t\t\turl: \"/Game/Stats\",\r\n\r\n\t\t\tsuccess: function (result) {\r\n\r\n\t\t\t\tfor (var i = 0; i < ");
            EndContext();
            BeginContext(848, 9, false);
#line 53 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                               Write(ViewBag.i);

#line default
#line hidden
            EndContext();
            BeginContext(857, 1746, true);
            WriteLiteral(@" ; i++) {
					$(""#1-"" + i).empty();
					$(""#1-"" + i).append(result[i][0]);
					$(""#2-"" + i).empty();
					$(""#2-"" + i).append(result[i][1]);
				}

			}
		});

		$.ajax({
			type: ""GET"",
			url: ""/Tick/GetTick"",
			data: { number: number },

			success: function (result) {

				if (result != """") {
					$(""#content"").append(result);
					number++;
				}
			}
		});
	}
</script>

<style>
	html,
	body {
		width: 100%;
		height: 100%;
	}

	body {
		margin: 0;
		display: flex;
		justify-content: center;
	}

	.card {
		margin: 5px;
		min-width: 50px;
	}

	#content {
		background-color: #fff;
		min-height: 200px;
		display: flex;
		overflow-x: auto;
	}

	#ft {
		background-color: darkgray;
		left: 0;
		border: solid 1px;
		float: left;
	}

	#content {
		margin-left: 0;
	}

	tr {
		height: 30px;
		border-bottom: solid 1px;
	}

	th {
	}
</style>

<div style=""float: none; clear: both""></div>

<div id=""moves"">
	<span class=""btn"" onclick=""move = ");
            WriteLiteral(@"'powerup'; makeMove()"">Усилиться</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'intellectup'; makeMove()"">Обучиться</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'gather'; makeMove()"">Добыть</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'attackgroup'; selectTeam()"">Атаковать группу</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'attackrocket'; selectTeam()"">Атаковать ракету</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'gift'; selectTeam()"">Дарить</span>
	</br>
	</br>
	<span id=""getinrocket"" class='btn' onclick=""move = 'getinrocket'; makeMove()"">Сесть в ракету</span>
	</br>
	</br>
</div>
<div id=""teams"">
</div>
<div id=""res"">
	<h1 id=""msg"">");
            EndContext();
            BeginContext(2604, 11, false);
#line 152 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
            Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(2615, 43, true);
            WriteLiteral(" </h1>\r\n</div>\r\n\r\n<input id=\"k\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2658, "\"", 2678, 1);
#line 155 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
WriteAttributeValue("", 2666, ViewBag.key, 2666, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2679, 3827, true);
            WriteLiteral(@" />

<span id=""kk"" onclick=""$('#kk').hide(); $('#k').show()"">Показать ключ</span>


<div>
	<h2>
		Обозначение действий:
	</h2>
	<p>
		У — усилиться </br>
		О — обучиться </br>
		Т — добыть топливо </br>
		Д — дарить </br>
		АГ — атаковать группу </br>
		АР — атаковать ракету </br>
		Р — сесть в ракету </br>
	</p>
	<p>
		Обозначение команд: </br>
		Кс — красные </br>
		Зл — зеленые </br>
		Сн — синие </br>
		Жт — желтые </br>
		Фв — фиолетовые </br>
	</p>
	<p>
		Обозначения результатов: </br>
		Д-Кс:V — подарил красной команде, успешно </br>
		Д-Зл:X — подарил зеленой команде, провал </br>
		АГ-Сн:W — атаковал синих, победа </br>
		АГ-Жт:L — атаковал желтых, поражение </br>
		АР-Фв:W — атаковал ракету фиолетовых, победа </br>
		АР-Кс:L — атаковал ракету красных, поражение </br>
		Р:В — сел в ракету, но был выбит </br>
		Р:П — сел в ракету и победил </br>
	</p>
</div>

<script type=""text/javascript"">
	var move = ""s"";
	var opt = """";
	var team = ""0"";
	var checkk = true;");
            WriteLiteral(@"

	var proces = true;
	$('#kk').hide();
	$(""#moves"").hide();
	$(""#teams"").hide();
	$(""#msg"").empty();
	$(""#msg"").append(""Игра еще не началась"");

	setInterval(check, 5000);

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
			data: { Key: $(""#k"").val() },

			success: function (result) {
				if (result) {

					if (!checkk) return;
					$.ajax({
						type: ""GET"",
						url: ""/Game/RocketCheck"",
						data: { Key: $(""#k"").val() },

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
				");
            WriteLiteral(@"		type: ""GET"",
						url: ""/Game/MoveCheck"",
						data: { Key: $(""#k"").val() },

						success: function (result) {
							if (result == ""Ход не сделан"") {
								$(""#msg"").hide();
								$(""#teams"").hide();
								$(""#moves"").show();
							}
							else {
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
					$(""#msg"").append(""Неверный код"");
				}
			}
		});
	}

	function selectTeam() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/TeamList"",
			data: { Key: $(""#k"").val() },

			success: function (result) {
				checkk = false;
				$(""#moves"").hide();
				$(""#msg"").hide();

				$(""#teams"").empty();
				$(""#teams"").show();
				//$(""#teams"").append(result);

				//alert(result[1].teamId);

				var i = 0;
				for (var item in result)");
            WriteLiteral(@" {
					$(""#teams"").append(""<span class='btn' onclick='team = "" + result[i].teamId + ""; checkk = true; makeMove()'>"" + result[i].name + ""</span></br></br>"");
					i++;
				}
			}
		});
	}

	function makeMove() {
		$(""#k"").hide();
		$('#kk').show();
		$.ajax({
			type: ""GET"",
			url: ""/Game/Make"",
			data: { Type: move, Key: $(""#k"").val(), TeamId: team },

			success: function (result) {
				$(""#moves"").hide();
				$(""#teams"").hide();

				$(""#msg"").empty();
				$(""#msg"").show();
				$(""#msg"").append(result);
			}
		});
	}
</script>

<style type=""text/css"">
	.btn {
		min-width: 20%;
		min-height: 20px;
		background-color: gray;
		border-radius: 200px;
		padding: 5px;
		float: left;
		color: white;
	}
</style>");
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
