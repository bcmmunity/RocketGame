#pragma checksum "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\GetTick.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cab465a161d4cd74153cc19438b012a49121d9bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tick_GetTick), @"mvc.1.0.view", @"/Views/Tick/GetTick.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tick/GetTick.cshtml", typeof(AspNetCore.Views_Tick_GetTick))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab465a161d4cd74153cc19438b012a49121d9bd", @"/Views/Tick/GetTick.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Tick_GetTick : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\GetTick.cshtml"
  
	Layout = null;

#line default
#line hidden
            BeginContext(24, 54, true);
            WriteLiteral("\r\n<table class=\"card\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>Такт ");
            EndContext();
            BeginContext(79, 14, false);
#line 8 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\GetTick.cshtml"
                Write(ViewBag.number);

#line default
#line hidden
            EndContext();
            BeginContext(93, 37, true);
            WriteLiteral("</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 12 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\GetTick.cshtml"
         for (int i = 0; i < ViewBag.moves.Length; i++)
		{

#line default
#line hidden
            BeginContext(186, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(211, 16, false);
#line 16 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\GetTick.cshtml"
               Write(ViewBag.moves[i]);

#line default
#line hidden
            EndContext();
            BeginContext(227, 23, true);
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 19 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\GetTick.cshtml"
		}

#line default
#line hidden
            BeginContext(255, 19, true);
            WriteLiteral("\t</tbody>\r\n</table>");
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
