#pragma checksum "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\jeudontonestleheros.Web.UI\Views\Aventure\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a384945c4508f8715e7b30cb8af8632b6e664e4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aventure_Index), @"mvc.1.0.view", @"/Views/Aventure/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aventure/Index.cshtml", typeof(AspNetCore.Views_Aventure_Index))]
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
#line 1 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\jeudontonestleheros.Web.UI\Views\_ViewImports.cshtml"
using jeudontonestleheros.Web.UI;

#line default
#line hidden
#line 2 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\jeudontonestleheros.Web.UI\Views\_ViewImports.cshtml"
using jeudontonestleheros.Web.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a384945c4508f8715e7b30cb8af8632b6e664e4c", @"/Views/Aventure/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b6ade6be95e6f0cd3e4275f496d6bb41c524550", @"/Views/_ViewImports.cshtml")]
    public class Views_Aventure_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<jeudontonestleheros.Core.Data.Models.Aventure>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Aventure", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\jeudontonestleheros.Web.UI\Views\Aventure\Index.cshtml"
  
//ViewData["Title"] = "Aventure Page";

//string monTitre = "Aventure";

#line default
#line hidden
            BeginContext(144, 26, true);
            WriteLiteral("\r\n<h1 class=\"text-center\">");
            EndContext();
            BeginContext(171, 16, false);
#line 9 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\jeudontonestleheros.Web.UI\Views\Aventure\Index.cshtml"
                   Write(ViewBag.monTitre);

#line default
#line hidden
            EndContext();
            BeginContext(187, 55, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"row justify-content-center\">\r\n    ");
            EndContext();
            BeginContext(242, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9dae102125c4c8ab4e48c8f85d07783", async() => {
                BeginContext(327, 17, true);
                WriteLiteral("Nouvelle aventure");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(348, 91, true);
            WriteLiteral("\r\n</div>\r\n<h2 class=\"text-center small\">Vos dernières aventures</h2>\r\n<div class=\"row\">\r\n\r\n");
            EndContext();
#line 17 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\jeudontonestleheros.Web.UI\Views\Aventure\Index.cshtml"
     foreach (var aventure in Model)
    {

#line default
#line hidden
            BeginContext(484, 132, true);
            WriteLiteral("        <a href=\"#\" class=\"card border m-2 text-center\" style=\"width: 7rem;\">\r\n            <div class=\"card-body\">\r\n                ");
            EndContext();
            BeginContext(617, 14, false);
#line 21 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\jeudontonestleheros.Web.UI\Views\Aventure\Index.cshtml"
           Write(aventure.Titre);

#line default
#line hidden
            EndContext();
            BeginContext(631, 36, true);
            WriteLiteral("\r\n            </div>\r\n        </a>\r\n");
            EndContext();
#line 24 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\jeudontonestleheros.Web.UI\Views\Aventure\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(674, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<jeudontonestleheros.Core.Data.Models.Aventure>> Html { get; private set; }
    }
}
#pragma warning restore 1591
