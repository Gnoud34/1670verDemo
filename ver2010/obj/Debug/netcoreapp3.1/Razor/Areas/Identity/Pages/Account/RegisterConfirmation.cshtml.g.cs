#pragma checksum "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ef1c0c1624a5ec4ab9bbc1b8bc58d3f827c6bee638512c9a015f3bd6758deaef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\_ViewImports.cshtml"
using ver2010.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\_ViewImports.cshtml"
using ver2010.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 1 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ver2010.Areas.Identity.Pages.Account

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ef1c0c1624a5ec4ab9bbc1b8bc58d3f827c6bee638512c9a015f3bd6758deaef", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e906d3e0b54ce7a3f640d8879bdf55d985927a25288247946b13cc4d0d8faaaa", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d938b799c899d696bf69aa7b974609a12a7795cc576c1d2a02b37c2bed76174f", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>");
            Write(
#nullable restore
#line 7 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
     ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("<p>\r\n    This app does not currently have a real email sender registered, see <a href=\"https://aka.ms/aspaccountconf\">these docs</a> for how to configure a real email sender.\r\n    Normally this would be emailed: <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 415, "\"", 449, 1);
            WriteAttributeValue("", 422, 
#nullable restore
#line 13 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                                                                Model.EmailConfirmationUrl

#line default
#line hidden
#nullable disable
            , 422, 27, false);
            EndWriteAttribute();
            WriteLiteral(">Click here to confirm your account</a>\r\n</p>\r\n");
#nullable restore
#line 15 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("<p>\r\n        Please check your email to confirm your account.\r\n</p>\r\n");
#nullable restore
#line 21 "D:\Zalo Received Files\ver2010\ver2010\ver2010\ver2010\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
