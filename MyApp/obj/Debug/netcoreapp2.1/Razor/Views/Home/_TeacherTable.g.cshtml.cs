#pragma checksum "D:\GitHub\MyApp\MyApp\Views\Home\_TeacherTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea079ee894ec04ee99192b5e8f1af9602d016eca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__TeacherTable), @"mvc.1.0.view", @"/Views/Home/_TeacherTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_TeacherTable.cshtml", typeof(AspNetCore.Views_Home__TeacherTable))]
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
#line 9 "D:\GitHub\MyApp\MyApp\Views\_ViewImports.cshtml"
using MyApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea079ee894ec04ee99192b5e8f1af9602d016eca", @"/Views/Home/_TeacherTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd8b2c6cb909e1d1dda3687d268818482697bd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__TeacherTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentTeacherViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(187, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(221, 172, true);
            WriteLiteral("\r\n<h2>Our Teachers</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Class</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "D:\GitHub\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
         foreach (var teacher in Model.Teachers)
        {

#line default
#line hidden
            BeginContext(454, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(493, 12, false);
#line 20 "D:\GitHub\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
               Write(teacher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(505, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(533, 13, false);
#line 21 "D:\GitHub\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
               Write(teacher.Class);

#line default
#line hidden
            EndContext();
            BeginContext(546, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 23 "D:\GitHub\MyApp\MyApp\Views\Home\_TeacherTable.cshtml"
        }

#line default
#line hidden
            BeginContext(583, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentTeacherViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591