#pragma checksum "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dec000315d4b7ab64155ee9de87f9f054170d21"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dec000315d4b7ab64155ee9de87f9f054170d21", @"/Views/Home/ShowUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RocketGame.Models.User>>
    {
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
            BeginContext(91, 22, true);
            WriteLiteral("\r\n<h2>Секретный код - ");
            EndContext();
            BeginContext(114, 13, false);
#line 7 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
               Write(ViewBag.Promo);

#line default
#line hidden
            EndContext();
            BeginContext(127, 11, true);
            WriteLiteral("</h2>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 138, "\"", 177, 2);
            WriteAttributeValue("", 145, "/Home/ShowUsers?Key=", 145, 20, true);
#line 9 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 165, ViewBag.Key, 165, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(178, 79, true);
            WriteLiteral(">Обновить</a>\r\n<table class=\"table\" id=\"t\">\r\n    <thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(258, 40, false);
#line 14 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(298, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(324, 45, false);
#line 17 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Intellect));

#line default
#line hidden
            EndContext();
            BeginContext(369, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(395, 41, false);
#line 20 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(436, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(462, 44, false);
#line 23 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(506, 94, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tКоманда\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(632, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(681, 39, false);
#line 35 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(720, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(776, 44, false);
#line 38 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Intellect));

#line default
#line hidden
            EndContext();
            BeginContext(820, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(876, 40, false);
#line 41 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
            EndContext();
            BeginContext(916, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(972, 43, false);
#line 44 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(Html.DisplayFor(modelItem => item.InRocket));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1071, 14, false);
#line 47 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
           Write(item.Team.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1142, "\"", 1196, 4);
            WriteAttributeValue("", 1149, "/Home/EditUser?id=", 1149, 18, true);
#line 50 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 1167, item.UserId, 1167, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1179, "&key=", 1179, 5, true);
#line 50 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
WriteAttributeValue("", 1184, ViewBag.Key, 1184, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1197, 49, true);
            WriteLiteral(">Изменить</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 53 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\ShowUsers.cshtml"
}

#line default
#line hidden
            BeginContext(1249, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
