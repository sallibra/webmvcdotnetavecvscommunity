#pragma checksum "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\TestAuthentification001\Areas\Identity\Pages\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e80781eb18679f88d29060ccf632134b2338265b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestAuthentification001.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml", typeof(TestAuthentification001.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ConfirmEmail), null)]
namespace TestAuthentification001.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\TestAuthentification001\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\TestAuthentification001\Areas\Identity\Pages\_ViewImports.cshtml"
using TestAuthentification001.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\TestAuthentification001\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using TestAuthentification001.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e80781eb18679f88d29060ccf632134b2338265b", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66be9b7b58b8516db42c24f03e7bee0ca17d259", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3605b2af477e2b72456d49c3e7d6d54579c3f206", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\TestAuthentification001\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Confirm email";

#line default
#line hidden
            BeginContext(77, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(83, 17, false);
#line 7 "C:\Users\x666825\Desktop\Document\Formation_ASP-NET-CORE_C#_bis\webmvcdotnetavecvscommunity\TestAuthentification001\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(100, 81, true);
            WriteLiteral("</h2>\n<div>\n    <p>\n        Thank you for confirming your email.\n    </p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
