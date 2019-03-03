#pragma checksum "C:\Users\Никита\Desktop\RocketGame1\RocketGame\Views\Home\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c6c9e7aaf75e28c20ee3206b283ec714f16b6f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Game), @"mvc.1.0.view", @"/Views/Home/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Game.cshtml", typeof(AspNetCore.Views_Home_Game))]
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
#line 1 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\Views\_ViewImports.cshtml"
using RocketGame;

#line default
#line hidden
#line 2 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\Views\_ViewImports.cshtml"
using RocketGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6c9e7aaf75e28c20ee3206b283ec714f16b6f3", @"/Views/Home/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4450a6b090bdc82caf393fa2bbbfb4f42a268c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\Views\Home\Game.cshtml"
  
	ViewData["Title"] = "Игра";

#line default
#line hidden
            BeginContext(39, 870, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js""></script>

<div id=""moves"">
	<span class=""btn"" onclick=""move = 'powerup'; makeMove()"">Усилиться</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'intellectup'; makeMove()"">Усилить интеллект</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'gather'; makeMove()"">Добыть</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'attackgroup'; selectTeam()"">Атаковать</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'attackrocket'; selectTeam()"">Атаковать ракету</span>
	</br>
	</br>
	<span class=""btn"" onclick=""move = 'gift'; selectTeam()"">Дарить</span>
	</br>
	</br>
	<span id=""getinrocket"" class='btn' onclick=""move = 'getinrocket'; makeMove()"">Сесть в ракету</span>
	</br>
	</br>
</div>
<div id=""teams"">
</div>
<div id=""res"">
	<h1 id=""msg"">");
            EndContext();
            BeginContext(910, 11, false);
#line 34 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\Views\Home\Game.cshtml"
            Write(ViewBag.key);

#line default
#line hidden
            EndContext();
            BeginContext(921, 41, true);
            WriteLiteral(" </h1>\r\n</div>\r\n<input id=\"k\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 962, "\"", 982, 1);
#line 36 "C:\Users\Никита\Desktop\RocketGame1\RocketGame\Views\Home\Game.cshtml"
WriteAttributeValue("", 970, ViewBag.key, 970, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(983, 2495, true);
            WriteLiteral(@"/>

<script type=""text/javascript"">
	var move = ""s"";
	var opt = """";
	var team = ""0"";
	var checkk = true;

	var proces = true;

	$(""#moves"").hide();
	$(""#teams"").hide();
	$(""#msg"").empty();
	$(""#msg"").append(""Игра еще не началась"");

	setInterval(check, 5000);

	function check()
	{
		$.ajax({
			type: ""GET"",
			url: ""/Game/KeyCheck"",
			data: { Key: $(""#k"").val() },

			success: function (result) {
				if (result) {

					if (!checkk) return;
					$.ajax({
						type: ""GET"",
						url: ""/Game/RocketCheck"",
						data: { Key: $(""#k"").val() },

						success: function (result) {
							if (result) {
								$(""#getinrocket"").show();
							}
							else {
								$(""#getinrocket"").hide();
							}
						}
					});

					$.ajax({
						type: ""GET"",
						url: ""/Game/MoveCheck"",
						data: { Key: $(""#k"").val() },

						success: function (result) {
							if (result == ""Ход не сделан"") {
								$(""#msg"").hide();
								$(""#teams"").hide();
								$(""#moves"").s");
            WriteLiteral(@"how();
							}
							else {
								$(""#msg"").empty();
								$(""#msg"").append(result);
								$(""#msg"").show();
								$(""#teams"").hide();
								$(""#moves"").hide();
							}
						}
					});
				}
				else
				{
					$(""#teams"").hide();
					$(""#moves"").hide();
					$(""#msg"").empty();
					$(""#msg"").show();
					$(""#msg"").append(""Неверный код"");
				}
			}
		});
	}

	function selectTeam()
	{
		$.ajax({
			type: ""GET"",
			url: ""/Game/GroupList"",

			success: function (result) {
				checkk = false;
				$(""#moves"").hide();
				$(""#msg"").hide();

				$(""#teams"").empty();
				$(""#teams"").show();
				//$(""#teams"").append(result);

				//alert(result[1].teamId);

				var i = 0;
				for (var item in result) {
					$(""#teams"").append(""<span class='btn' onclick='team = "" + result[i].teamId + ""; checkk = true; makeMove()'>"" + result[i].name + ""</span></br></br>"");
					i++;
				}
			}
		});
	}

	function makeMove()
	{
		$.ajax({
			type: ""GET"",
			url: ""/Game");
            WriteLiteral(@"/Make"",
			data: { Type: move, Key: $(""#k"").val(), TeamId: team },

			success: function(result) {
				$(""#moves"").hide();
				$(""#teams"").hide();

				$(""#msg"").empty();
				$(""#msg"").show();
				$(""#msg"").append(result);
			}
		});
	}
</script>

<style type=""text/css"">
	.btn {
		width: 20%;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
