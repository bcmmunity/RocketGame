#pragma checksum "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "676cdee1dc43113b1939736240686ac8ba86a1da"
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
#line 1 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame;

#line default
#line hidden
#line 2 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\_ViewImports.cshtml"
using RocketGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"676cdee1dc43113b1939736240686ac8ba86a1da", @"/Views/Tick/Game.cshtml")]
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
#line 2 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
  
    ViewData["Title"] = "Game";
    ViewBag.number = 0;

#line default
#line hidden
            BeginContext(67, 369, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js""></script>

<div id=""content"">
    <table class=""card"" id=""table2"" style=""background-color: darkgray"">
        <thead>
            <tr>
                <th> Ком(Т) </th>
                <th> Ник </th>
                <th> С/И </th>
            </tr>
        </thead>
		<tbody>
");
            EndContext();
#line 19 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
             for (int i = 0; i < ViewBag.i; i++)
			{

#line default
#line hidden
            BeginContext(483, 18, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 501, "\"", 510, 2);
            WriteAttributeValue("", 506, "0-", 506, 2, true);
#line 22 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
WriteAttributeValue("", 508, i, 508, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(511, 9, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(521, 19, false);
#line 23 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                   Write(ViewBag.users[i, 0]);

#line default
#line hidden
            EndContext();
            BeginContext(540, 31, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(572, 19, false);
#line 26 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                   Write(ViewBag.users[i, 2]);

#line default
#line hidden
            EndContext();
            BeginContext(591, 22, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 613, "\"", 622, 2);
            WriteAttributeValue("", 618, "1-", 618, 2, true);
#line 28 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
WriteAttributeValue("", 620, i, 620, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(623, 9, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(633, 19, false);
#line 29 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                   Write(ViewBag.users[i, 3]);

#line default
#line hidden
            EndContext();
            BeginContext(652, 25, true);
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 32 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
			}

#line default
#line hidden
            BeginContext(683, 281, true);
            WriteLiteral(@"		</tbody>
    </table>
</div>

<script>
	var number = 1;
	

	setInterval(metod, 2000);

	function metod() {

		$(""#head"").hide();
		$(""#foo"").hide();

		$.ajax({
			type: ""GET"",
			url: ""/Game/Stats"",

			success: function (result) {

				for (var i = 0; i < ");
            EndContext();
            BeginContext(965, 9, false);
#line 54 "C:\Users\Никита\Desktop\RocketGame\RocketGame\Views\Tick\Game.cshtml"
                               Write(ViewBag.i);

#line default
#line hidden
            EndContext();
            BeginContext(974, 1117, true);
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
		//$(""#table2"").width = $(""#table1"").width;
	}

	

	$(""#head"").hide();
	$(""#foo"").hide();
</script>

<style>
    html,
    body {
        width: 100%;
        height: 100%;
    }

	.card {
		white-space: nowrap;
		min-width: 20px;
	}

	#content {
		background-color: #fff;
		min-height: 200px;
		min-width: 500%;
		margin-top: 100px;
		position: absolute;
		left: 0;
	}

	table {
		float: left;
	}

    .ft {
        background-color: darkgray;
        border: solid 1px;
    }

	tr {
		height: 30px;
		border-bottom: solid 1px;
		border-top: solid 1px;
	}

	th {
		min-width: 20px;
	");
            WriteLiteral("\tborder-left: solid 1px;\r\n\t\tborder-right: solid 1px;\r\n\t\ttext-align: center;\r\n\t}\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(2091, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1475950f79804c42aec13eaae53eb05f", async() => {
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
            BeginContext(2136, 48, true);
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
