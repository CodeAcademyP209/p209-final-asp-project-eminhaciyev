#pragma checksum "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f43d98b94c2d4d3690cf481152cfd7ff1955187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Delete))]
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
#line 1 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Delete.cshtml"
using ASP_Final_Project_Asbab.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f43d98b94c2d4d3690cf481152cfd7ff1955187", @"/Areas/Admin/Views/Category/Delete.cshtml")]
    public class Areas_Admin_Views_Category_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(162, 149, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <h2>Delete</h2>\r\n        <form method=\"post\" enctype=\"multipart/form-data\">\r\n            ");
            EndContext();
            BeginContext(312, 23, false);
#line 13 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Delete.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(335, 202, true);
            WriteLiteral("\r\n            <div class=\"alert alert-danger\" role=\"alert\">\r\n                Bu kateqoriyani silmək istədiyinizə əminsiziniz??\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(538, 26, false);
#line 18 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Delete.cshtml"
           Write(Html.LabelFor(t => t.Name));

#line default
#line hidden
            EndContext();
            BeginContext(564, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(583, 98, false);
#line 19 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Delete.cshtml"
           Write(Html.TextBoxFor(t => t.Name, new { @class = "form-control", type = "text", placeholder = "Name" }));

#line default
#line hidden
            EndContext();
            BeginContext(681, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(700, 76, false);
#line 20 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Delete.cshtml"
           Write(Html.ValidationMessageFor(t => t.Name, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(776, 135, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <input type=\"submit\" class=\"btn btn-success\" value=\"Delete\" />\r\n        </form>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
