#pragma checksum "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "203876c92d0e129d684a42382daa2481a26fa875"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowUsers), @"mvc.1.0.view", @"/Views/Home/ShowUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowUsers.cshtml", typeof(AspNetCore.Views_Home_ShowUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203876c92d0e129d684a42382daa2481a26fa875", @"/Views/Home/ShowUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RocketGame.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tick", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
  
	ViewData["Title"] = "ShowUsers";

#line default
#line hidden
            BeginContext(86, 133, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js\"></script>\r\n\r\n<div id=\"main\">\r\n\t<h2>Код-приглашение: ");
            EndContext();
            BeginContext(220, 13, false);
#line 9 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
                    Write(ViewBag.Promo);

#line default
#line hidden
            EndContext();
            BeginContext(233, 10, true);
            WriteLiteral("</h2>\r\n\r\n\t");
            EndContext();
            BeginContext(243, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9cba5dcad043fba2d736cd59fa0b9f", async() => {
                BeginContext(335, 27, true);
                WriteLiteral("Открыть таблицу результатов");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(366, 207, true);
            WriteLiteral("\r\n\t<span id=\"resume\" class=\"btn\" onclick=\"resume()\">Продолжить игру</span>\r\n\r\n\t<table>\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>\r\n\t\t\t\t\tКоманда\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\tКод\r\n\t\t\t\t</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
            EndContext();
#line 26 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
             foreach (string item in ViewBag.Promos)
			{

#line default
#line hidden
            BeginContext(624, 27, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(652, 43, false);
#line 30 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
                   Write(ViewBag.Names[ViewBag.Promos.IndexOf(item)]);

#line default
#line hidden
            EndContext();
            BeginContext(695, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(727, 4, false);
#line 33 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(731, 25, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 36 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
			}

#line default
#line hidden
            BeginContext(762, 28, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\r\n\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 790, "\"", 829, 2);
            WriteAttributeValue("", 797, "/Home/ShowUsers?Key=", 797, 20, true);
#line 40 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 817, ViewBag.Key, 817, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(830, 270, true);
            WriteLiteral(@">Обновить</a>

	<a id=""s""><span class=""btn"" onclick=""makeMove(); $('#s').empty(); $('#s').append('Нажмите обновить')"">Начать игру</span></a>

	<h1 id=""msg""></h1>

	<div id=""teams"">
	</div>

	<div id=""users"">
	</div>

</div>

<br>
<h3>Количество игроков - ");
            EndContext();
            BeginContext(1101, 17, false);
#line 55 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
                    Write(ViewBag.UserCount);

#line default
#line hidden
            EndContext();
            BeginContext(1118, 85, true);
            WriteLiteral("</h3>\r\n<br>\r\n\r\n<table class=\"table\" id=\"t\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<!--\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1204, 40, false);
#line 63 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1270, 45, false);
#line 66 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Intellect));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1341, 41, false);
#line 69 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1408, 44, false);
#line 72 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 214, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t\t-->\r\n\t\t\t<th>\r\n\t\t\t\tКоманда\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tНикнейм\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tИмя\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tКлюч\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t\t<th></th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 93 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
            BeginContext(1703, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1728, 14, false);
#line 97 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(item.Team.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1742, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1771, 39, false);
#line 100 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1810, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1839, 43, false);
#line 103 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.RealName));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 42, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<!--\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1925, 40, false);
#line 107 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 34, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2000, 43, false);
#line 110 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 39, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t-->\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(2083, 38, false);
#line 114 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Key));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 20, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2141, "\"", 2157, 2);
            WriteAttributeValue("", 2146, "k-", 2146, 2, true);
#line 116 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2148, item.Key, 2148, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2158, 25, true);
            WriteLiteral(">\r\n\t\t\t\t\t<span class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2183, "\"", 2217, 3);
            WriteAttributeValue("", 2193, "selectOwner(\'", 2193, 13, true);
#line 117 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2206, item.Key, 2206, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2215, "\')", 2215, 2, true);
            EndWriteAttribute();
            BeginContext(2218, 42, true);
            WriteLiteral(">Сделать дублем</span>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2260, "\"", 2276, 2);
            WriteAttributeValue("", 2265, "t-", 2265, 2, true);
#line 119 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2267, item.Key, 2267, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2277, 25, true);
            WriteLiteral(">\r\n\t\t\t\t\t<span class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2302, "\"", 2335, 3);
            WriteAttributeValue("", 2312, "selectTeam(\'", 2312, 12, true);
#line 120 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2324, item.Key, 2324, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2333, "\')", 2333, 2, true);
            EndWriteAttribute();
            BeginContext(2336, 54, true);
            WriteLiteral(">Изменить команду</span>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2390, "\"", 2446, 4);
            WriteAttributeValue("", 2397, "/Home/DeleteUser?Key=", 2397, 21, true);
#line 123 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2418, ViewBag.Key, 2418, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2430, "&id=", 2430, 4, true);
#line 123 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2434, item.UserId, 2434, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2447, 75, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t<span class=\"btn\">Удалить</span>\r\n\t\t\t\t\t</a>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 128 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
		}

#line default
#line hidden
            BeginContext(2527, 3511, true);
            WriteLiteral(@"	</tbody>
</table>

<script>
	var end = ""Игра окончена - <a href='..//Test.xlsx' download>Скачать таблицу результатов игры</a>""

	$(""#users"").hide();

	function resume() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/Resume"",

			success: function (result) {

			}
		});
	}

	function selectOwner(kkey) {
		$.ajax({
			type: ""GET"",
			url: ""/Home/GetUsers"",
			data: { Key: kkey },

			success: function (result) {

				$(""#users"").empty();
				$(""#users"").show();

				var i = 0;
				for (var item in result) {
					$(""#users"").append(""<span class='btn' onclick='editKey(\"""" + kkey + ""\"","" + result[i][1] + ""); '>"" + result[i][0] + ""</span></br></br>"");
					i++;
				}
			}
		});
	}

	setInterval(check, 5000);

	$(""#resume"").hide();

	var f = true;

	function check() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/GameCheck"",

			success: function (result) {

				if (result == ""Игра закончилась"") {
					if (f) {
						$(""#main"").empty();
						$(""#main"").append(end);
");
            WriteLiteral(@"						f = false;
					}
				}
			}
		});
		$.ajax({
			type: ""GET"",
			url: ""/Game/PauseCheck"",

			success: function (result) {

				if (result) {
					$(""#resume"").show();
				}
			}
		});
	}

	$(""#teams"").hide();

	function selectTeam(key) {
		$.ajax({
			type: ""GET"",
			url: ""/Game/GroupList"",

			success: function (result) {

				$(""#teams"").empty();
				$(""#teams"").show();

				var i = 0;
				for (var item in result) {
					$(""#teams"").append(""<span class='btn' onclick='editTeam(\"""" + key + ""\"", \"""" + result[i].teamId + ""\"")'>"" + result[i].name + ""</span></br></br>"");
					i++;
				}
			}
		});
	}

	function editTeam(key, team) {
		$.ajax({
			type: ""GET"",
			url: ""/Home/EditUserTeam"",
			data: { Key: key, Team: team },

			success: function (result) {
				$(""#msg"").empty();
				$(""#msg"").append(""Новый ключ - "" + result);

				$(""#teams"").hide();
			}
		});
	}

	function editKey(key, userId) {
		$.ajax({
			type: ""GET"",
			url: ""/Home/EditUserKey""");
            WriteLiteral(@",
			data: { Key: key, UserId: userId },

			success: function (result) {
				$(""#msg"").empty();
				$(""#msg"").append(""Дубль сделан (нажмите обновить)"");

				$(""#users"").hide();
				$(""#t-"" + key).empty();
				$(""#k-"" + key).empty();
				$(""#t-"" + key).append(""<span class='btn' onclick=\""selectTeam('"" + result + ""')\"">Изменить команду</span>"");
				$(""#k-"" + key).append(""<span class='btn' onclick=\""editKey(\'"" + result + ""')\"">Изменить ключ</span>"");

				$.ajax({
					type: ""GET"",
					url: ""/Home/DoubleMail"",
					data: { DoubleKey: result, UserId: userId },

					success: function (result) {
					}
				});

				var idd = ""t-"" + result;
				document.getElementById(""t-"" + key).id = idd;
				idd = ""k-"" + result;
				document.getElementById(""k-"" + key).id = idd;
			}
		});
	}

	function makeMove() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/StartGame"",

			success: function (result) {
				$(""#s"").empty();
				$(""#s"").append(""<h2>"" + result + ""</h2>"");
			}
		});
	}

	");
            WriteLiteral(@"$(document).ready(function () {
		$.ajax({
			type: ""GET"",
			url: ""/Game/GameCheck"",
			success: function (result) {
				if (result == ""Игра началась"") {
					$(""#s"").empty();
					$(""#s"").append(""<h2>Игра началась</h2>"");
				}
			}
		})
	});
</script>

<style type=""text/css"">
	.btn {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RocketGame.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
