#pragma checksum "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b08a6efdc00094ee52daaa7e086b2b375909e9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main__ForumPostForm), @"mvc.1.0.view", @"/Views/Main/_ForumPostForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b08a6efdc00094ee52daaa7e086b2b375909e9d", @"/Views/Main/_ForumPostForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd7da1be8f07b82e0184d47952fa5f7edb815b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Main__ForumPostForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SnowboardProject.Models.ForumPost>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 14 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml"
Write(Html.LabelFor(p => p.PostTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml"
Write(Html.TextAreaFor(p => p.PostTitle, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 16 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml"
Write(Html.ValidationMessageFor(p => p.PostTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 22 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml"
Write(Html.LabelFor(p => p.Post));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml"
Write(Html.TextAreaFor(p => p.Post, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 24 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml"
Write(Html.ValidationMessageFor(p => p.Post));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n\r\n    ");
#nullable restore
#line 30 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml"
Write(Html.LabelFor(p => p.UserIdEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml"
Write(Html.TextAreaFor(p => p.UserIdEmail, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 32 "C:\Users\student\Code_School\SnowboardCommunityProject\SnowboardProject\Views\Main\_ForumPostForm.cshtml"
Write(Html.ValidationMessageFor(p => p.UserIdEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SnowboardProject.Models.ForumPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
