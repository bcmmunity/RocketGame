#pragma checksum "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f6aeed288e94768127a62b2bfbe0ed5848c26a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tick_Game), @"mvc.1.0.view", @"/Views/Tick/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tick/Game.cshtml", typeof(AspNetCore.Views_Tick_Game))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f6aeed288e94768127a62b2bfbe0ed5848c26a7", @"/Views/Tick/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Tick_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
  
	ViewData["Title"] = "Game";
	ViewBag.number = 0;
	//Layout = null;

#line default
#line hidden
            BeginContext(80, 135, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js\"></script>\r\n\r\n<h3>\r\n\t<span id=\"Promo\">Код-приглашение: ");
            EndContext();
            BeginContext(216, 13, false);
#line 11 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                                 Write(ViewBag.Promo);

#line default
#line hidden
            EndContext();
            BeginContext(229, 31, true);
            WriteLiteral(" | Адрес страницы регистрации: ");
            EndContext();
            BeginContext(261, 12, false);
#line 11 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                                                                              Write(ViewBag.Link);

#line default
#line hidden
            EndContext();
            BeginContext(273, 320, true);
            WriteLiteral(@"</span>
	<span id=""time""></span>
	<span id=""timeE""></span>
</h3>
<span id=""li""></span>
<h3 id=""msg""></h3>

<div id=""content"">
	<table class=""card"" id=""table2"" style=""background-color: darkgray"">
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
#line 28 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
             for (int i = 0; i < ViewBag.i; i++)
			{

#line default
#line hidden
            BeginContext(640, 18, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 658, "\"", 667, 2);
            WriteAttributeValue("", 663, "0-", 663, 2, true);
#line 31 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
WriteAttributeValue("", 665, i, 665, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(668, 9, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(678, 19, false);
#line 32 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                   Write(ViewBag.users[i, 0]);

#line default
#line hidden
            EndContext();
            BeginContext(697, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(729, 19, false);
#line 35 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                   Write(ViewBag.users[i, 2]);

#line default
#line hidden
            EndContext();
            BeginContext(748, 22, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 770, "\"", 779, 2);
            WriteAttributeValue("", 775, "1-", 775, 2, true);
#line 37 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
WriteAttributeValue("", 777, i, 777, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(780, 9, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(790, 19, false);
#line 38 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                   Write(ViewBag.users[i, 3]);

#line default
#line hidden
            EndContext();
            BeginContext(809, 25, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 41 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
			}

#line default
#line hidden
            BeginContext(840, 70, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n</div>\r\n\r\n<script>\r\n\r\n\tvar totalE = Math.floor(");
            EndContext();
            BeginContext(911, 13, false);
#line 48 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                       Write(ViewBag.timeE);

#line default
#line hidden
            EndContext();
            BeginContext(924, 24, true);
            WriteLiteral(");\r\n\r\n\tvar total = 60 * ");
            EndContext();
            BeginContext(949, 12, false);
#line 50 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                Write(ViewBag.time);

#line default
#line hidden
            EndContext();
            BeginContext(961, 14, true);
            WriteLiteral(" - Math.floor(");
            EndContext();
            BeginContext(976, 15, false);
#line 50 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                                           Write(ViewBag.timedif);

#line default
#line hidden
            EndContext();
            BeginContext(991, 898, true);
            WriteLiteral(@");

	setInterval(check, 5000);

	var ispause = false;
	var isfin = true;

	function check() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/PauseCheck"",

			success: function (result) {

				if (result) {
					$(""#timeE"").empty();
					$(""#time"").empty();
					$(""#msg"").empty();
					$(""#msg"").append(""Пауза"");
					ispause = true;
				}
				else {
					if (ispause)
						$(""#msg"").empty();
					ispause = false;
				}
			}
		});
	}

	updateTime();

	function updateTime() {

		if (!isfin || ispause) return;

		if (total != 0) {
			total -= 1;

			if (total > 0 && totalE > 0) {
				$(""#time"").empty();
				if (total % 60 > 9)
					$(""#time"").append(""| До конца такта: "" + Math.floor(total / 60) + "":"" + total % 60);
				else
					$(""#time"").append(""| До конца такта: "" + Math.floor(total / 60) + "":0"" + total % 60);
			}
		}
		else {
			total = 60 * ");
            EndContext();
            BeginContext(1890, 12, false);
#line 98 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                    Write(ViewBag.time);

#line default
#line hidden
            EndContext();
            BeginContext(1902, 652, true);
            WriteLiteral(@";

			if (total > 0 && totalE > 0) {
				$(""#time"").empty();
				if (total % 60 > 9)
					$(""#time"").append(""| До конца такта: "" + Math.floor(total / 60) + "":"" + total % 60);
				else
					$(""#time"").append(""| До конца такта: "" + Math.floor(total / 60) + "":0"" + total % 60);
			}
		}

		if (totalE != 0) {
			totalE -= 1;

			if (totalE > 0) {
				$(""#timeE"").empty();
				if (totalE % 60 > 9)
					$(""#timeE"").append(""| До конца игры: "" + Math.floor(totalE / 60) + "":"" + totalE % 60);
				else
					$(""#timeE"").append(""| До конца игры: "" + Math.floor(totalE / 60) + "":0"" + totalE % 60);
			}
		}
		else {
			totalE = Math.floor(");
            EndContext();
            BeginContext(2555, 13, false);
#line 121 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                           Write(ViewBag.timeE);

#line default
#line hidden
            EndContext();
            BeginContext(2568, 1232, true);
            WriteLiteral(@");

			if (totalE > 0) {
				$(""#timeE"").empty();
				if (totalE % 60 > 9)
					$(""#timeE"").append(""| До конца игры: "" + Math.floor(totalE / 60) + "":"" + totalE % 60);
				else
					$(""#timeE"").append(""| До конца игры: "" + Math.floor(totalE / 60) + "":0"" + totalE % 60);
			}
		}
		if (totalE < 0) {
			$.ajax({
				type: ""GET"",
				url: ""/Game/GameResult"",

				success: function (result) {

					if (result != ""NotFinished"") {

						if (isfin) {
							$(""#msg"").empty();
							$(""#msg"").append(result);
							isfin = false;
							$(""#time"").empty();
							$(""#timeE"").empty();
						}
					}
				}
			});
		}

		setTimeout(updateTime, 1000);
	}

	setInterval(metod, 5000);

	function metod() {

		$(""#head"").hide();
		$(""#foo"").hide();

		$.ajax({
			type: ""GET"",
			url: ""/Game/GameResult"",

			success: function (result) {

				if (result != ""NotFinished"") {

					if (isfin) {
						$(""#msg"").empty();
						$(""#msg"").append(result);
						isfin = false;
						$");
            WriteLiteral("(\"#time\").empty();\r\n\t\t\t\t\t\t$(\"#timeE\").empty();\r\n\t\t\t\t\t}\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t});\r\n\r\n\t\t//$.ajax({\r\n\t\t//\ttype: \"GET\",\r\n\t\t//\turl: \"/Game/Stats\",\r\n\r\n\t\t//\tsuccess: function (result) {\r\n\t\t\t\t//\r\n\t\t//\t\tfor (var i = 0; i < ");
            EndContext();
            BeginContext(3801, 9, false);
#line 187 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                                 Write(ViewBag.i);

#line default
#line hidden
            EndContext();
            BeginContext(3810, 405, true);
            WriteLiteral(@" ; i++) {
		//			$(""#0-"" + i).empty();
		//			$(""#0-"" + i).append(result[i][0]);
		//			$(""#1-"" + i).empty();
		//			$(""#1-"" + i).append(result[i][1]);
		//		}
		//
		//	}
		//});

		$.ajax({
			type: ""GET"",
			url: ""/Tick/GetTick"",
			data: { type: 1 },

			success: function (result) {

				if (result != """") {
					$(""#li"").empty();
					$(""#li"").append(""Адрес страницы регистрации: ");
            EndContext();
            BeginContext(4216, 12, false);
#line 206 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                                                            Write(ViewBag.Link);

#line default
#line hidden
            EndContext();
            BeginContext(4228, 886, true);
            WriteLiteral(@""");
					$(""#Promo"").empty();
					$(""#content"").empty();
					$(""#content"").append(result);
				}
				else {
					$(""#time"").empty();
					$(""#timeE"").empty();
				}
			}
		});
		//$(""#table2"").width = $(""#table1"").width;
	}



	$(""#head"").hide();
	$(""#foo"").hide();
</script>

<style>
	html,
	body {
		width: 100%;
		height: 100%;
	}

	.card {
		white-space: nowrap;
		min-width: 20px;
	}

	#head {
		display: none;
	}

	#content {
		background-color: #fff;
		min-height: 200px;
		min-width: 500%;
		position: absolute;
		left: 0;
	}

	table {
		float: left;
	}

	.ft {
		background-color: darkgray;
		border: solid 1px;
	}

	tr {
		height: 30px;
		border-bottom: solid 1px;
		border-top: solid 1px;
	}

	th {
		min-width: 20px;
		border-left: solid 1px;
		border-right: solid 1px;
		text-align: center;
	}
</style>

");
            EndContext();
            BeginContext(5114, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7276300b79c64271afd97e4781955a47", async() => {
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
            BeginContext(5159, 48, true);
            WriteLiteral("\r\n\r\n<div style=\"float: none; clear: both\"></div>");
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
