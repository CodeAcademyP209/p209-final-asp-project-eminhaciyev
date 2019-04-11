#pragma checksum "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbc1b3be8014ce6a9962e2dc9a73f60a8de1581e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Index))]
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
#line 1 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
using ASP_Final_Project_Asbab.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc1b3be8014ce6a9962e2dc9a73f60a8de1581e", @"/Areas/Admin/Views/Category/Index.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(174, 323, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <h2>Categories</h2>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col""><a class=""btn btn-success""");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 497, "\'", 560, 1);
#line 17 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 504, Url.Action("Create","Category", new { area = "Admin" }), 504, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(561, 120, true);
            WriteLiteral("><i class=\"fas fa-plus\"></i> Create new one</a></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
                   var id = 0;

#line default
#line hidden
            BeginContext(714, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 22 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
                 foreach (var category in Model)
                {

#line default
#line hidden
            BeginContext(783, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(851, 4, false);
#line 25 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
                                    Write(++id);

#line default
#line hidden
            EndContext();
            BeginContext(856, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(892, 13, false);
#line 26 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
                       Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(905, 61, true);
            WriteLiteral("</td>\r\n                        <td><a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 966, "\"", 1040, 1);
#line 27 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 973, Url.Action("Edit","Category", new { area = "Admin", category.Id }), 973, 67, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1041, 98, true);
            WriteLiteral("><i class=\"fas fa-edit\"></i> Edit</a></td>\r\n                        <td><a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1139, "\"", 1215, 1);
#line 28 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 1146, Url.Action("Delete","Category", new { area = "Admin", category.Id }), 1146, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1216, 79, true);
            WriteLiteral("><i class=\"fas fa-user-minus\"></i> Delete</a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 30 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Category\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1314, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591