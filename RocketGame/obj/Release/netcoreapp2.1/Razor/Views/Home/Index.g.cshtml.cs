#pragma checksum "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "552623ec4a9f739119d4578e83385407f0775fcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552623ec4a9f739119d4578e83385407f0775fcd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Войти в игру";

#line default
#line hidden
            BeginContext(45, 165, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js\"></script>\r\n<div class=\"container\" id=\"main\">\r\n\t<div class=\"row\">\r\n\t\t<col-6>\r\n\t\t\t<h1>");
            EndContext();
            BeginContext(211, 11, false);
#line 9 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
           Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(222, 10, true);
            WriteLiteral("</h1>\r\n\t\t\t");
            EndContext();
            BeginContext(232, 695, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02eab06de656412cb5dbab5897f8497b", async() => {
                BeginContext(293, 220, true);
                WriteLiteral("\r\n\t\t\t\t<label>Ваш код-приглашение (из email):</label><br />\r\n\t\t\t\t<input type=\"text\" name=\"Promo\" id=\"Promo\" /><br /><br />\r\n\t\t\t\t<label>Придумайте себе псевдоним:</label><br />\r\n\t\t\t\t<input type=\"text\" name=\"Name\" id=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 513, "\"", 535, 1);
#line 14 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
WriteAttributeValue("", 522, ViewBag.Name, 522, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(536, 133, true);
                WriteLiteral("/><br /><br />\r\n\t\t\t\t<label>Ваше имя (видит только администратор):</label><br />\r\n\t\t\t\t<input type=\"text\" name=\"RealName\" id=\"RealName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 669, "\"", 694, 1);
#line 16 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
WriteAttributeValue("", 677, ViewBag.RealName, 677, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(695, 225, true);
                WriteLiteral("/><br /><br />\r\n\t\t\t\t<label>Ваша почта:</label><br />\r\n\t\t\t\t<input type=\"text\" name=\"Mail\" id=\"Mail\" /><br /><br />\r\n\t\t\t\t<input type=\"submit\" value=\"Войти в игру\" class=\"btn\" />\r\n\t\t\t\t<p class=\"info\">Захожу в первый раз</p>\r\n\t\t\t");
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
            BeginContext(927, 192, true);
            WriteLiteral("\r\n\t\t</col-6>\r\n\t</div>\r\n\t<br>\r\n</div>\r\n\r\n<a id=\"main2a\" onclick=\"iamplayer()\">Я уже игрок</a>\r\n\r\n<div class=\"container\" id=\"main2\" style=\"display: none\">\r\n\t<div class=\"row\">\r\n\t\t<col-6>\r\n\t\t\t<h1>");
            EndContext();
            BeginContext(1120, 11, false);
#line 32 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
           Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(1131, 10, true);
            WriteLiteral("</h1>\r\n\t\t\t");
            EndContext();
            BeginContext(1141, 296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1d4aa2d061b416da8428f9565da59aa", async() => {
                BeginContext(1202, 228, true);
                WriteLiteral("\r\n\t\t\t\t<label>Ваш ключ:</label><br />\r\n\t\t\t\t<input type=\"text\" id=\"Key1\" oninput=\"io()\"/><br /><br />\r\n\t\t\t\t<a href=\"/Home/Game?Key=\" id=\"Key\" class=\"btn\">Вернуться в игру</a>\r\n\t\t\t\t<p class=\"info\">Я уже получил ключ игрока</p>\r\n\t\t\t");
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
            BeginContext(1437, 486, true);
            WriteLiteral(@"
		</col-6>
	</div>
	<br>
</div>

	<script>

		
		$.ajax({
			type: ""GET"",
			url: ""/Game/GameCheck"",

			success: function (result) {

				if (result == ""Игра началась"") {
					$(""#main2a"").hide();
					$(""#main"").hide();
				}
				else {
					$(""#main2"").hide();
				}
			}
		});

		function iamplayer() {
			$(""#main2"").show();
		}

		function io() {
			document.getElementById(""Key"").href = ""/Home/Game?Key="" + $(""#Key1"").val();
		}

//	if (""1"" != '");
            EndContext();
            BeginContext(1924, 12, false);
#line 71 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
             Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1936, 49, true);
            WriteLiteral("\')\r\n//\t\tdocument.getElementById(\"Name\").value = \'");
            EndContext();
            BeginContext(1986, 12, false);
#line 72 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
                                              Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1998, 19, true);
            WriteLiteral("\';\r\n//\tif (\"1\" != \'");
            EndContext();
            BeginContext(2018, 16, false);
#line 73 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
             Write(ViewBag.RealName);

#line default
#line hidden
            EndContext();
            BeginContext(2034, 53, true);
            WriteLiteral("\')\r\n//\t\tdocument.getElementById(\"RealName\").value = \'");
            EndContext();
            BeginContext(2088, 16, false);
#line 74 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
                                                  Write(ViewBag.RealName);

#line default
#line hidden
            EndContext();
            BeginContext(2104, 17, true);
            WriteLiteral("\';\r\n\tif (\"1\" != \'");
            EndContext();
            BeginContext(2122, 12, false);
#line 75 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
           Write(ViewBag.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(2134, 47, true);
            WriteLiteral("\')\r\n\t\tdocument.getElementById(\"Mail\").value = \'");
            EndContext();
            BeginContext(2182, 12, false);
#line 76 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
                                            Write(ViewBag.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(2194, 17, true);
            WriteLiteral("\';\r\n\tif (\"1\" != \'");
            EndContext();
            BeginContext(2212, 13, false);
#line 77 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
           Write(ViewBag.Promo);

#line default
#line hidden
            EndContext();
            BeginContext(2225, 48, true);
            WriteLiteral("\')\r\n\t\tdocument.getElementById(\"Promo\").value = \'");
            EndContext();
            BeginContext(2274, 13, false);
#line 78 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Home\Index.cshtml"
                                             Write(ViewBag.Promo);

#line default
#line hidden
            EndContext();
            BeginContext(2287, 256, true);
            WriteLiteral(@"';
	</script>


	<style type=""text/css"">
		.btn {
			min-width: 20%;
			min-height: 20px;
			background-color: gray;
			border-radius: 200px;
			padding: 5px;
			float: left;
			color: white;
		}

		.info {
			color: gray;
		}
	</style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
