#pragma checksum "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9be554af058000dce97b7f99bd8f8258ad7edcc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9be554af058000dce97b7f99bd8f8258ad7edcc", @"/Views/Home/ShowUsers.cshtml")]
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
  
	ViewData["Title"] = "ShowUsers";

#line default
#line hidden
            BeginContext(88, 132, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js\"></script>\r\n\r\n<div id=\"main\">\r\n\t<h2>Секретный код - ");
            EndContext();
            BeginContext(221, 13, false);
#line 10 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
                   Write(ViewBag.Promo);

#line default
#line hidden
            EndContext();
            BeginContext(234, 10, true);
            WriteLiteral("</h2>\r\n\r\n\t");
            EndContext();
            BeginContext(244, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934bf1f74c184238a890c2517d554939", async() => {
                BeginContext(336, 27, true);
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
            BeginContext(367, 133, true);
            WriteLiteral("\r\n\r\n\t<table>\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>\r\n\t\t\t\t\tКоманда\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\tКод\r\n\t\t\t\t</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
            EndContext();
#line 26 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
             foreach (string item in ViewBag.Promos)
			{

#line default
#line hidden
            BeginContext(551, 27, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(579, 43, false);
#line 30 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
                   Write(ViewBag.Names[ViewBag.Promos.IndexOf(item)]);

#line default
#line hidden
            EndContext();
            BeginContext(622, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(654, 4, false);
#line 33 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
                   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(658, 25, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 36 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
			}

#line default
#line hidden
            BeginContext(689, 28, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\r\n\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 717, "\"", 756, 2);
            WriteAttributeValue("", 724, "/Home/ShowUsers?Key=", 724, 20, true);
#line 40 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 744, ViewBag.Key, 744, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(757, 317, true);
            WriteLiteral(@">Обновить</a>

	<a id=""s""><span onclick=""makeMove(); $('#s').empty(); $('#s').append('Нажмите обновить')"">Начать игру</span></a>

	<h1 id=""msg""></h1>

	<div id=""teams"">
	</div>

	<div id=""users"">
	</div>

</div>

<table class=""table"" id=""t"">
	<thead>
        <tr>
            <!--
    <th>
        ");
            EndContext();
            BeginContext(1075, 40, false);
#line 59 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 31, true);
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
            EndContext();
            BeginContext(1147, 45, false);
#line 62 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
   Write(Html.DisplayNameFor(model => model.Intellect));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 31, true);
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
            EndContext();
            BeginContext(1224, 41, false);
#line 65 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
   Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 31, true);
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
            EndContext();
            BeginContext(1297, 44, false);
#line 68 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
   Write(Html.DisplayNameFor(model => model.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 349, true);
            WriteLiteral(@"
    </th>
        -->
            <th>
                Команда
            </th>
            <th>
                Никнейм
            </th>
            <th>
                Имя
            </th>
            <th>
                Ключ
            </th>
            <th></th>
            <th></th>
        </tr>
	</thead>
	<tbody>
");
            EndContext();
#line 88 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
            BeginContext(1727, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1776, 14, false);
#line 92 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(item.Team.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1790, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1846, 39, false);
#line 95 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1941, 43, false);
#line 98 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.RealName));

#line default
#line hidden
            EndContext();
            BeginContext(1984, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <!--\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2058, 40, false);
#line 102 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
            EndContext();
            BeginContext(2098, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2154, 43, false);
#line 105 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(2197, 64, true);
            WriteLiteral("\r\n            </td>\r\n    -->\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2262, 38, false);
#line 109 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 36, true);
            WriteLiteral("\r\n            </td>\r\n            <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2336, "\"", 2352, 2);
            WriteAttributeValue("", 2341, "k-", 2341, 2, true);
#line 111 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2343, item.Key, 2343, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2353, 36, true);
            WriteLiteral(">\r\n                <span class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2389, "\"", 2423, 3);
            WriteAttributeValue("", 2399, "selectOwner(\'", 2399, 13, true);
#line 112 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2412, item.Key, 2412, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2421, "\')", 2421, 2, true);
            EndWriteAttribute();
            BeginContext(2424, 58, true);
            WriteLiteral(">Сделать дублем</span>\r\n            </td>\r\n            <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2482, "\"", 2498, 2);
            WriteAttributeValue("", 2487, "t-", 2487, 2, true);
#line 114 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2489, item.Key, 2489, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2499, 36, true);
            WriteLiteral(">\r\n                <span class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2535, "\"", 2568, 3);
            WriteAttributeValue("", 2545, "selectTeam(\'", 2545, 12, true);
#line 115 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2557, item.Key, 2557, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2566, "\')", 2566, 2, true);
            EndWriteAttribute();
            BeginContext(2569, 60, true);
            WriteLiteral(">Изменить команду</span>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 118 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
		}

#line default
#line hidden
            BeginContext(2634, 3005, true);
            WriteLiteral(@"	</tbody>
</table>

<script>
	var end = ""Игра окончена - <a href='..//Test.xlsx' download>Скачать таблицу</a>""

	$(""#users"").hide();

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
						f = false;
					}
				}
			}
		});
	}

	$(""#teams"").hide();

	function selectTeam(key) {
		$.ajax({
			type: ""GET"",
			url: ""/Game/GroupList"",

			success");
            WriteLiteral(@": function (result) {

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
			url: ""/Home/EditUserKey"",
			data: { Key: key, UserId: userId },

			success: function (result) {
				$(""#msg"").empty();
				$(""#msg"").append(""Дубль сделан (нажмите обновить)"");

				$(""#users"").hide();
				$(""#t-"" + key).empty();
				$(""#k-"" + key).empty();
				$(""#t-"" + key).append(""<span class='btn' onclick=\""selectTeam('"" + result + ""')\"">Изме");
            WriteLiteral(@"нить команду</span>"");
				$(""#k-"" + key).append(""<span class='btn' onclick=\""editKey(\'"" + result + ""')\"">Изменить ключ</span>"");

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

	$(document).ready(function () {
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
