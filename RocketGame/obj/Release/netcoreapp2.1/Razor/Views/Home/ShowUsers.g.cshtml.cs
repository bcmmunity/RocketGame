#pragma checksum "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca9b39443b23886327281a44852b93feea036948"
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
#line 1 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame;

#line default
#line hidden
#line 2 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca9b39443b23886327281a44852b93feea036948", @"/Views/Home/ShowUsers.cshtml")]
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
#line 3 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
  
	ViewData["Title"] = "ShowUsers";

#line default
#line hidden
            BeginContext(88, 112, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js\"></script>\r\n<h2>Секретный код - ");
            EndContext();
            BeginContext(201, 13, false);
#line 8 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(ViewBag.Promo);

#line default
#line hidden
            EndContext();
            BeginContext(214, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(221, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "388263b740d24e39a5b6fae77a65c391", async() => {
                BeginContext(313, 27, true);
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
            BeginContext(344, 121, true);
            WriteLiteral("\r\n\r\n<table>\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\tКоманда\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tКод\r\n\t\t\t</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 23 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
         foreach (string item in ViewBag.Promos)
		{

#line default
#line hidden
            BeginContext(514, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(539, 43, false);
#line 27 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(ViewBag.Names[ViewBag.Promos.IndexOf(item)]);

#line default
#line hidden
            EndContext();
            BeginContext(582, 28, true);
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(611, 4, false);
#line 30 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(615, 23, true);
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 33 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
		}

#line default
#line hidden
            BeginContext(643, 25, true);
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 668, "\"", 707, 2);
            WriteAttributeValue("", 675, "/Home/ShowUsers?Key=", 675, 20, true);
#line 37 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 695, ViewBag.Key, 695, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(708, 244, true);
            WriteLiteral(">Обновить</a>\r\n\r\n<a id=\"s\"><span onclick=\"makeMove(); $(\'#s\').empty(); $(\'#s\').append(\'Нажмите обновить\')\">Начать игру</span></a>\r\n\r\n<h1 id=\"msg\"></h1>\r\n\r\n<div id=\"teams\">\r\n</div>\r\n\r\n<table class=\"table\" id=\"t\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(953, 40, false);
#line 50 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(993, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1019, 45, false);
#line 53 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Intellect));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1090, 41, false);
#line 56 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1157, 44, false);
#line 59 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 102, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tКоманда\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 69 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
            BeginContext(1340, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1365, 39, false);
#line 73 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1433, 44, false);
#line 76 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Intellect));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1506, 40, false);
#line 79 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1575, 43, false);
#line 82 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1647, 14, false);
#line 85 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(item.Team.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1661, 20, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1681, "\"", 1697, 2);
            WriteAttributeValue("", 1686, "k-", 1686, 2, true);
#line 87 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 1688, item.Key, 1688, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1698, 25, true);
            WriteLiteral(">\r\n\t\t\t\t\t<span class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1723, "\"", 1753, 3);
            WriteAttributeValue("", 1733, "editKey(\'", 1733, 9, true);
#line 88 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 1742, item.Key, 1742, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1751, "\')", 1751, 2, true);
            EndWriteAttribute();
            BeginContext(1754, 41, true);
            WriteLiteral(">Изменить ключ</span>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1795, "\"", 1811, 2);
            WriteAttributeValue("", 1800, "t-", 1800, 2, true);
#line 90 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 1802, item.Key, 1802, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1812, 25, true);
            WriteLiteral(">\r\n\t\t\t\t\t<span class=\"btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1837, "\"", 1870, 3);
            WriteAttributeValue("", 1847, "selectTeam(\'", 1847, 12, true);
#line 91 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 1859, item.Key, 1859, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1868, "\')", 1868, 2, true);
            EndWriteAttribute();
            BeginContext(1871, 47, true);
            WriteLiteral(">Изменить команду</span>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 94 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
		}

#line default
#line hidden
            BeginContext(1923, 2060, true);
            WriteLiteral(@"	</tbody>
</table>

<script>
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
				$(""#t-""");
            WriteLiteral(@" + key).append(""<span class='btn' onclick=\""selectTeam('"" + result + ""')\"">Изменить команду</span>"");
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
");
            WriteLiteral("\t}\r\n</style>");
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
