#pragma checksum "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01dfcbdc5cfe64b68393f6f55405bab48e15b37b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main__ResortForm), @"mvc.1.0.view", @"/Views/Main/_ResortForm.cshtml")]
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
#nullable restore
#line 1 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\_ViewImports.cshtml"
using SnowboardProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\_ViewImports.cshtml"
using SnowboardProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01dfcbdc5cfe64b68393f6f55405bab48e15b37b", @"/Views/Main/_ResortForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd7da1be8f07b82e0184d47952fa5f7edb815b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Main__ResortForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SnowboardProject.Models.Resort>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 13 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml"
Write(Html.LabelFor(r => r.ResortName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml"
Write(Html.TextAreaFor(r => r.ResortName, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml"
Write(Html.ValidationMessageFor(r => r.ResortName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 21 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml"
Write(Html.LabelFor(r => r.ResortLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 22 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml"
Write(Html.TextAreaFor(r => r.ResortLocation, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml"
Write(Html.ValidationMessageFor(r => r.ResortLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 29 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml"
Write(Html.LabelFor(r => r.ResortElevation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 30 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml"
Write(Html.TextAreaFor(r => r.ResortElevation, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ResortForm.cshtml"
Write(Html.ValidationMessageFor(r => r.ResortElevation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SnowboardProject.Models.Resort> Html { get; private set; }
    }
}
#pragma warning restore 1591
