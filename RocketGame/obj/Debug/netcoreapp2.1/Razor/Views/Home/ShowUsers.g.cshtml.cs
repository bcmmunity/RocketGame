#pragma checksum "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e390c60c1ce4456065dc3927d458d13b904b08b6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e390c60c1ce4456065dc3927d458d13b904b08b6", @"/Views/Home/ShowUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RocketGame.Models.User>>
    {
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
            BeginContext(214, 11, true);
            WriteLiteral("</h2>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 225, "\"", 264, 2);
            WriteAttributeValue("", 232, "/Home/ShowUsers?Key=", 232, 20, true);
#line 10 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 252, ViewBag.Key, 252, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(265, 143, true);
            WriteLiteral(">Обновить</a>\r\n\r\n<a id=\"s\"><span onclick=\"makeMove()\">Начать игру</span></a>\r\n\r\n\r\n<table class=\"table\" id=\"t\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(409, 40, false);
#line 19 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(449, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(475, 45, false);
#line 22 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Intellect));

#line default
#line hidden
            EndContext();
            BeginContext(520, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(546, 41, false);
#line 25 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(587, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(613, 44, false);
#line 28 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(657, 88, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tКоманда\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 37 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
            BeginContext(782, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(807, 39, false);
#line 41 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(846, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(875, 44, false);
#line 44 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Intellect));

#line default
#line hidden
            EndContext();
            BeginContext(919, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(948, 40, false);
#line 47 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
            EndContext();
            BeginContext(988, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1017, 43, false);
#line 50 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1089, 14, false);
#line 53 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(item.Team.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 30, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1133, "\"", 1187, 4);
            WriteAttributeValue("", 1140, "/Home/EditUser?id=", 1140, 18, true);
#line 56 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 1158, item.UserId, 1158, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1170, "&key=", 1170, 5, true);
#line 56 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 1175, ViewBag.Key, 1175, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1188, 36, true);
            WriteLiteral(">Изменить</a>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 59 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
		}

#line default
#line hidden
            BeginContext(1229, 510, true);
            WriteLiteral(@"	</tbody>
</table>

<script>


	function makeMove() {
		$.ajax({
			type: ""GET"",
			url: ""/Game/StartGame"",

			success: function (result) {
				$(""#s"").empty();
				$(""#s"").append(""<h2>Игра началась</h2>"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RocketGame.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
