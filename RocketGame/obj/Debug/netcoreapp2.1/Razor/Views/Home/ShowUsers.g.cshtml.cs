#pragma checksum "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b63ae25b929185c9a068b67db0b10f4e4c5542f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b63ae25b929185c9a068b67db0b10f4e4c5542f", @"/Views/Home/ShowUsers.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "530a9cb1825a4694a78460178e17db15", async() => {
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
            BeginContext(757, 287, true);
            WriteLiteral(@">Обновить</a>

	<a id=""s""><span onclick=""makeMove(); $('#s').empty(); $('#s').append('Нажмите обновить')"">Начать игру</span></a>

	<h1 id=""msg""></h1>

	<div id=""teams"">
	</div>

</div>

<table class=""table"" id=""t"">
	<thead>
        <tr>
            <!--
    <th>
        ");
            EndContext();
            BeginContext(1045, 40, false);
#line 56 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 31, true);
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
            EndContext();
            BeginContext(1117, 45, false);
#line 59 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
   Write(Html.DisplayNameFor(model => model.Intellect));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 31, true);
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
            EndContext();
            BeginContext(1194, 41, false);
#line 62 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
   Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 31, true);
            WriteLiteral("\r\n    </th>\r\n    <th>\r\n        ");
            EndContext();
            BeginContext(1267, 44, false);
#line 65 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
   Write(Html.DisplayNameFor(model => model.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 349, true);
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
#line 85 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
            BeginContext(1697, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1746, 14, false);
#line 89 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(item.Team.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1760, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1816, 39, false);
#line 92 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1855, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1911, 43, false);
#line 95 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.RealName));

#line default
#line hidden
            EndContext();
            BeginContext(1954, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <!--\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2028, 40, false);
#line 99 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2124, 43, false);
#line 102 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 64, true);
            WriteLiteral("\r\n            </td>\r\n    -->\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2232, 38, false);
#line 106 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Key));

#line default
#line hidden
            EndContext();
            BeginContext(2270, 36, true);
            WriteLiteral("\r\n            </td>\r\n            <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2306, "\"", 2322, 2);
            WriteAttributeValue("", 2311, "k-", 2311, 2, true);
#line 108 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2313, item.Key, 2313, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2323, 36, true);
            WriteLiteral(">\r\n                <span class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2359, "\"", 2389, 3);
            WriteAttributeValue("", 2369, "editKey(\'", 2369, 9, true);
#line 109 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2378, item.Key, 2378, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2387, "\')", 2387, 2, true);
            EndWriteAttribute();
            BeginContext(2390, 57, true);
            WriteLiteral(">Изменить ключ</span>\r\n            </td>\r\n            <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2447, "\"", 2463, 2);
            WriteAttributeValue("", 2452, "t-", 2452, 2, true);
#line 111 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2454, item.Key, 2454, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2464, 36, true);
            WriteLiteral(">\r\n                <span class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2500, "\"", 2533, 3);
            WriteAttributeValue("", 2510, "selectTeam(\'", 2510, 12, true);
#line 112 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 2522, item.Key, 2522, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2531, "\')", 2531, 2, true);
            EndWriteAttribute();
            BeginContext(2534, 60, true);
            WriteLiteral(">Изменить команду</span>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 115 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
		}

#line default
#line hidden
            BeginContext(2599, 2476, true);
            WriteLiteral(@"	</tbody>
</table>

<script>
	var end = ""Игра окончена - <a href='..//Test.xlsx' download>Скачать таблицу</a>""


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

			suc");
            WriteLiteral(@"cess: function (result) {
				$(""#msg"").empty();
				$(""#msg"").append(""Новый ключ - "" + result);

				$(""#teams"").hide();
			}
		});
	}

	function editKey(key) {
		$.ajax({
			type: ""GET"",
			url: ""/Home/EditUserKey"",
			data: { Key: key },

			success: function (result) {
				$(""#msg"").empty();
				$(""#msg"").append(result);

				$(""#t-"" + key).empty();
				$(""#k-"" + key).empty();
				$(""#t-"" + key).append(""<span class='btn' onclick=\""selectTeam('"" + result + ""')\"">Изменить команду</span>"");
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

	$(document)");
            WriteLiteral(@".ready(function () {
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
