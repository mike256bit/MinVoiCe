#pragma checksum "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Project\Project.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "457efa0424712f1671e891354fbeed559597efea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Project), @"mvc.1.0.view", @"/Views/Project/Project.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Project.cshtml", typeof(AspNetCore.Views_Project_Project))]
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
#line 1 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\_ViewImports.cshtml"
using MinVoiCe;

#line default
#line hidden
#line 2 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\_ViewImports.cshtml"
using MinVoiCe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457efa0424712f1671e891354fbeed559597efea", @"/Views/Project/Project.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db14de72e6b960ccc1bb7f88b301de34e824484", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Project : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 66, true);
            WriteLiteral("<h1>SINGLE PROJECT</h1>\r\n<h6><a href=\"/\">(Home)</a></h6>\r\n\r\nNAME: ");
            EndContext();
            BeginContext(67, 26, false);
#line 4 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Project\Project.cshtml"
 Write(ViewBag.SingleProject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(93, 14, true);
            WriteLiteral("<br />\r\nRATE: ");
            EndContext();
            BeginContext(108, 26, false);
#line 5 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Project\Project.cshtml"
 Write(ViewBag.SingleProject.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(134, 21, true);
            WriteLiteral("<br />\r\nDESCRIPTION: ");
            EndContext();
            BeginContext(156, 33, false);
#line 6 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Project\Project.cshtml"
        Write(ViewBag.SingleProject.Description);

#line default
#line hidden
            EndContext();
            BeginContext(189, 18, true);
            WriteLiteral("<br />\r\n\r\nCLIENT: ");
            EndContext();
            BeginContext(208, 33, false);
#line 8 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Project\Project.cshtml"
   Write(ViewBag.SingleProject.Client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(241, 4, true);
            WriteLiteral("\r\n\r\n");
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
