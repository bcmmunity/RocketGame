#pragma checksum "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe44831127f3720370b84d0690347d2e4537cea0"
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
#line 1 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame;

#line default
#line hidden
#line 2 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe44831127f3720370b84d0690347d2e4537cea0", @"/Views/Home/Setting.cshtml")]
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
#line 2 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
  
	ViewData["Title"] = "Настройки игры";

#line default
#line hidden
            BeginContext(81, 65, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<div class=\"row\">\r\n\t\t<col-6>\r\n\t\t\t<h1>");
            EndContext();
            BeginContext(147, 11, false);
#line 9 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(158, 10, true);
            WriteLiteral("</h1>\r\n\t\t\t");
            EndContext();
            BeginContext(168, 808, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f429f1c39d0a44b28387ed87399574cc", async() => {
                BeginContext(261, 79, true);
                WriteLiteral("\r\n\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Время одного такта в минутах</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(341, 32, false);
#line 15 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.TimeTick));

#line default
#line hidden
                EndContext();
                BeginContext(373, 69, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Время игры в минутах</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(443, 32, false);
#line 19 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.TimeGame));

#line default
#line hidden
                EndContext();
                BeginContext(475, 66, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Количество команд</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(542, 33, false);
#line 23 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.TeamCount));

#line default
#line hidden
                EndContext();
                BeginContext(575, 62, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Размер команд</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(638, 32, false);
#line 27 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.TeamSize));

#line default
#line hidden
                EndContext();
                BeginContext(670, 73, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Количество мест в ракете</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(744, 34, false);
#line 31 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.RocketSize));

#line default
#line hidden
                EndContext();
                BeginContext(778, 79, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\t\t\t\t<label>Необходимое для ракеты топливо</label>\r\n\t\t\t\t</br>\r\n\t\t\t\t");
                EndContext();
                BeginContext(858, 34, false);
#line 35 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
           Write(Html.TextBoxFor(n => n.RocketFuel));

#line default
#line hidden
                EndContext();
                BeginContext(892, 77, true);
                WriteLiteral("\r\n\t\t\t\t</br>\r\n\r\n\t\t\t\t<input type=\"submit\" value=\"Отправить\" class=\"btn\" />\r\n\t\t\t");
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
#line 10 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
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
            BeginContext(976, 72, true);
            WriteLiteral("\r\n\t\t</col-6>\r\n\t</div>\r\n</div>\r\n\r\n<script>\r\n\tlocalStorage.setItem(\"Key\", ");
            EndContext();
            BeginContext(1049, 11, false);
#line 45 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Home\Setting.cshtml"
                           Write(ViewBag.Key);

#line default
#line hidden
            EndContext();
            BeginContext(1060, 13, true);
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
