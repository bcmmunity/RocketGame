#pragma checksum "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecb08926e81521225a3f6df4d09e9ed08bd12eac"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb08926e81521225a3f6df4d09e9ed08bd12eac", @"/Views/Home/Game.cshtml")]
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
            BeginContext(39, 891, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js""></script>
<h2 id=""warning""></h2>

<div id=""moves"">
	<span class=""btn"" onclick=""move = 'powerup'; makeMove()"">Усилиться</span>
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
	<span class=""btn"" onclick=""move = 'attackrocket'; makeMove()"">Атаковать ракету</span>
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
            BeginContext(931, 11, false);
#line 35 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
            Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(942, 179, true);
            WriteLiteral("</h1>\r\n</div>\r\n\r\n\r\n<span id=\"kk\" class=\"btn\" onclick=\"$(\'#kk\').hide(); $(\'#k\').show()\">Показать поле ввода ключа</span></br>\r\n\r\n<h3>Ключ игрока: </h3>\r\n\r\n<input id=\"k\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1121, "\"", 1141, 1);
#line 43 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
WriteAttributeValue("", 1129, ViewBag.key, 1129, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1142, 558, true);
            WriteLiteral(@" oninput=""io()"" /></br>

<a href=""/Home/Game?Key="" id=""ag"" class=""btn"">Подтвердить</a></br>

<p class=""info"">Если поле пустое, введите ключ игрока (из Email) и нажмите ""Подтвердить""</p>

<h3>Таблица результатов:</h3>

<script>

	function io() {
		document.getElementById(""ag"").href = ""/Home/Game?Key="" + $(""#k"").val();
	}

</script>

<div id=""cont"">
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
#line 69 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
             for (int i = 0; i < ViewBag.i; i++)
			{

#line default
#line hidden
            BeginContext(1747, 18, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1765, "\"", 1774, 2);
            WriteAttributeValue("", 1770, "0-", 1770, 2, true);
#line 72 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
WriteAttributeValue("", 1772, i, 1772, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1775, 9, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1785, 19, false);
#line 73 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                   Write(ViewBag.users[i, 0]);

#line default
#line hidden
            EndContext();
            BeginContext(1804, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1836, 19, false);
#line 76 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                   Write(ViewBag.users[i, 2]);

#line default
#line hidden
            EndContext();
            BeginContext(1855, 22, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1877, "\"", 1886, 2);
            WriteAttributeValue("", 1882, "1-", 1882, 2, true);
#line 78 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
WriteAttributeValue("", 1884, i, 1884, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1887, 9, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1897, 19, false);
#line 79 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                   Write(ViewBag.users[i, 3]);

#line default
#line hidden
            EndContext();
            BeginContext(1916, 25, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 82 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
			}

#line default
#line hidden
            BeginContext(1947, 260, true);
            WriteLiteral(@"		</tbody>
	</table>

	<div id=""content"">
	</div>
</div>

<script>
	var number = 1;

	setInterval(metod, 2000);

	function metod() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/Stats"",

			success: function (result) {

				for (var i = 0; i < ");
            EndContext();
            BeginContext(2208, 9, false);
#line 102 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Game.cshtml"
                               Write(ViewBag.i);

#line default
#line hidden
            EndContext();
            BeginContext(2217, 1258, true);
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
		margin-top: 100px;
	}

	#content {
		background-color: #fff;
		min-height: 200px;
		max-width: 100%;
		display: flex;
		overflow-x: auto;
		overflow-y: auto;
		-webkit-overflow-scrolling: touch;
		margin-top: 100px;
	}

	.ft {
		background-color: darkgray;
");
            WriteLiteral("\t\tborder: solid 1px;\r\n\t}\r\n\r\n\ttr {\r\n\t\theight: 30px;\r\n\t\tborder-bottom: solid 1px;\r\n\t}\r\n\r\n\tth {\r\n\t\tmin-width: 20px;\r\n\t\tborder-left: solid 1px;\r\n\t\tborder-right: solid 1px;\r\n\t\tborder-top: solid 1px;\r\n\t\ttext-align: center;\r\n\t}\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(3475, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1913e678400433eb523f05748f09f35", async() => {
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
            BeginContext(3520, 3824, true);
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
	var checkk = true;

	var proces = true;
	$('#kk').hid");
            WriteLiteral(@"e();
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
						type: ""GET"",
						url: ""/Game/Mov");
            WriteLiteral(@"eCheck"",
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
				for (var item in result) {
					$(""#teams"").append(""<span cl");
            WriteLiteral(@"ass='btn' onclick='team = "" + result[i].teamId + ""; checkk = true; makeMove()'>"" + result[i].name + ""</span></br></br>"");
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

	.info {
		color: gray;
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
