#pragma checksum "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "598143cd13512ff5c772f19135695db98b7b0e78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tick_Game), @"mvc.1.0.view", @"/Views/Tick/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tick/Game.cshtml", typeof(AspNetCore.Views_Tick_Game))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598143cd13512ff5c772f19135695db98b7b0e78", @"/Views/Tick/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Tick_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
  
	ViewData["Title"] = "Game";
	ViewBag.number = 0;

#line default
#line hidden
            BeginContext(61, 368, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js""></script>

<div id=""content"">
    <table class=""card stst"" style=""background-color: darkgray"">
        <thead>
            <tr>
                <th> Команда </th>
                <th> Ник </th>
                <th> С/И</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
             for (int i = 0; i < ViewBag.i; i++)
            {

#line default
#line hidden
            BeginContext(494, 37, true);
            WriteLiteral("            <tr>\r\n                <th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 531, "\"", 540, 2);
            WriteAttributeValue("", 536, "0-", 536, 2, true);
#line 22 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
WriteAttributeValue("", 538, i, 538, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(541, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(565, 19, false);
#line 23 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
               Write(ViewBag.users[i, 0]);

#line default
#line hidden
            EndContext();
            BeginContext(584, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(652, 19, false);
#line 26 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
               Write(ViewBag.users[i, 2]);

#line default
#line hidden
            EndContext();
            BeginContext(671, 44, true);
            WriteLiteral("\r\n                </th>\r\n                <th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 715, "\"", 724, 2);
            WriteAttributeValue("", 720, "1-", 720, 2, true);
#line 28 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
WriteAttributeValue("", 722, i, 722, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(725, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(749, 19, false);
#line 29 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
               Write(ViewBag.users[i, 3]);

#line default
#line hidden
            EndContext();
            BeginContext(768, 44, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n");
            EndContext();
#line 32 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
            }

#line default
#line hidden
            BeginContext(827, 281, true);
            WriteLiteral(@"        </tbody>
    </table>
    <table class=""card"" style=""background-color: darkgray"">
        <thead>
            <tr>
                <th> Команда </th>
                <th> Ник </th>
                <th> С/И</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 44 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
             for (int i = 0; i < ViewBag.i; i++)
            {

#line default
#line hidden
            BeginContext(1173, 60, true);
            WriteLiteral("            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1234, 19, false);
#line 48 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
               Write(ViewBag.users[i, 0]);

#line default
#line hidden
            EndContext();
            BeginContext(1253, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1321, 19, false);
#line 51 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
               Write(ViewBag.users[i, 2]);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1408, 19, false);
#line 54 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
               Write(ViewBag.users[i, 3]);

#line default
#line hidden
            EndContext();
            BeginContext(1427, 44, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
            }

#line default
#line hidden
            BeginContext(1486, 237, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<script>\r\n\tvar number = 1;\r\n\r\n\tsetInterval(metod, 1000);\r\n\r\n\tfunction metod() {\r\n\t\t$.ajax({\r\n\t\t\ttype: \"GET\",\r\n\t\t\turl: \"/Game/Stats\",\r\n\r\n\t\t\tsuccess: function (result) {\r\n\r\n\t\t\t\tfor (var i = 0; i < ");
            EndContext();
            BeginContext(1724, 9, false);
#line 74 "C:\Users\Никита Кураев\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                               Write(ViewBag.i);

#line default
#line hidden
            EndContext();
            BeginContext(1733, 934, true);
            WriteLiteral(@" ; i++) {
					$(""#0-"" + i).empty();
					$(""#0-"" + i).append(result[i][0]);
					$(""#1-"" + i).empty();
					$(""#1-"" + i).append(result[i][1]);
				}

			}
		});

		$.ajax({
			type: ""GET"",
			url: ""/Tick/GetTick"",
			data: { number: number },

			success: function (result) {

				if (result != """") {
					$(""#content"").append(result);
					number++;
				}
			}
		});
	}
</script>

<style>
	html,
	body {
		width: 100%;
		height: 100%;
	}
    .stst {
        position: absolute;
    }

	body {
		margin: 0;
		display: flex;
		justify-content: center;
	}

	.card {
		margin: 5px;
	}

	#content {
		background-color: #fff;
		min-height: 200px;
		max-width: 100%;
		display: flex;
		overflow-x: auto;
        margin-top: 100px;
	}

	.ft {
		background-color: darkgray;
		border: solid 1px;
	}

	tr {
		height: 30px;
		border-bottom: solid 1px;
	}

	th {
	}
</style>

");
            EndContext();
            BeginContext(2667, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a760284b4d254db68d80811811eec967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2712, 48, true);
            WriteLiteral("\r\n\r\n<div style=\"float: none; clear: both\"></div>");
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
