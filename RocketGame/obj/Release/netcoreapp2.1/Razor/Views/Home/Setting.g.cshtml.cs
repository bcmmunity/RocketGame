#pragma checksum "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c811901bb0e4e77d8237aafd70ed692172b3fd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Setting), @"mvc.1.0.view", @"/Views/Home/Setting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Setting.cshtml", typeof(AspNetCore.Views_Home_Setting))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c811901bb0e4e77d8237aafd70ed692172b3fd4", @"/Views/Home/Setting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Setting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RocketGame.Models.Setting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Setting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
  
	ViewData["Title"] = "Настройки игры";

#line default
#line hidden
            BeginContext(81, 155, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js\"></script>\r\n<div class=\"container\">\r\n\t<div class=\"row\">\r\n\t\t<col-6>\r\n\t\t\t<h1>");
            EndContext();
            BeginContext(237, 11, false);
#line 10 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(248, 10, true);
            WriteLiteral("</h1>\r\n\t\t\t");
            EndContext();
            BeginContext(258, 1055, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72a00271e28d435eb536dc7b4918ae37", async() => {
                BeginContext(350, 79, true);
                WriteLiteral("\r\n\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Время одного такта в минутах</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(430, 51, false);
#line 16 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.TimeTick, new { id = "i1" }));

#line default
#line hidden
                EndContext();
                BeginContext(481, 74, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Сделать паузу после такта</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(556, 52, false);
#line 20 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.TickPause, new { id = "i7" }));

#line default
#line hidden
                EndContext();
                BeginContext(608, 69, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Время игры в минутах</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(678, 51, false);
#line 24 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.TimeGame, new { id = "i2" }));

#line default
#line hidden
                EndContext();
                BeginContext(729, 66, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Количество команд</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(796, 52, false);
#line 28 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.TeamCount, new { id = "i3" }));

#line default
#line hidden
                EndContext();
                BeginContext(848, 66, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Игроков в команде</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(915, 51, false);
#line 32 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.TeamSize, new { id = "i4" }));

#line default
#line hidden
                EndContext();
                BeginContext(966, 73, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Количество мест в ракете</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(1040, 53, false);
#line 36 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.RocketSize, new { id = "i5" }));

#line default
#line hidden
                EndContext();
                BeginContext(1093, 79, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Необходимое для ракеты топливо</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(1173, 53, false);
#line 40 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.RocketFuel, new { id = "i6" }));

#line default
#line hidden
                EndContext();
                BeginContext(1226, 80, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\r\n\t\t\t\t<input type=\"submit\" value=\"Создать игру\" class=\"btn\" />\r\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-key", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
                                                                WriteLiteral(ViewBag.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["key"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-key", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["key"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1313, 412, true);
            WriteLiteral(@"
		</col-6>
	</div>
</div>

<script>
	document.getElementById(""i1"").value = ""5"";
	document.getElementById(""i2"").value = ""60"";
	document.getElementById(""i3"").value = ""5"";
	document.getElementById(""i4"").value = ""7"";
	document.getElementById(""i5"").value = ""4"";
	document.getElementById(""i6"").value = ""40"";
	document.getElementById(""i7"").value = ""0"";
</script>

<script>
	localStorage.setItem(""Key"", ");
            EndContext();
            BeginContext(1726, 11, false);
#line 60 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
                           Write(ViewBag.Key);

#line default
#line hidden
            EndContext();
            BeginContext(1737, 13, true);
            WriteLiteral(");\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RocketGame.Models.Setting> Html { get; private set; }
    }
}
#pragma warning restore 1591
