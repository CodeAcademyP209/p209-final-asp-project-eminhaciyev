#pragma checksum "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4c6102e333f48831f91700a7030bfa57f36767e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NewArrival_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/NewArrival/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NewArrival/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_NewArrival_Index))]
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
#line 1 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
using ASP_Final_Project_Asbab.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4c6102e333f48831f91700a7030bfa57f36767e", @"/Areas/Admin/Views/NewArrival/Index.cshtml")]
    public class Areas_Admin_Views_NewArrival_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewArrival>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(176, 415, true);
            WriteLiteral(@"
<h2>Index</h2>

<div class=""container"">
    <div class=""row"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Price</th>
                    <th scope=""col"">Discount Price</th>
                    <th scope=""col""><a class=""btn btn-success""");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 591, "\'", 656, 1);
#line 19 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
WriteAttributeValue("", 598, Url.Action("Create","NewArrival", new { area = "Admin" }), 598, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(657, 120, true);
            WriteLiteral("><i class=\"fas fa-plus\"></i> Create new one</a></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 23 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
                   var id = 0;

#line default
#line hidden
            BeginContext(810, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 24 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
                 foreach (var arrival in Model)
                {

#line default
#line hidden
            BeginContext(878, 58, true);
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(938, 4, false);
#line 27 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
                                Write(++id);

#line default
#line hidden
            EndContext();
            BeginContext(943, 31, true);
            WriteLiteral("</th>\r\n                    <td>");
            EndContext();
            BeginContext(975, 12, false);
#line 28 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
                   Write(arrival.Name);

#line default
#line hidden
            EndContext();
            BeginContext(987, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1019, 13, false);
#line 29 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
                   Write(arrival.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1032, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1064, 21, false);
#line 30 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
                   Write(arrival.DiscountPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1116, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7fcb3413a264a03afd6fe659f594603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1126, "~/images/", 1126, 9, true);
#line 31 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
AddHtmlAttributeValue("", 1135, arrival.Image, 1135, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1164, 57, true);
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1221, "\"", 1296, 1);
#line 32 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
WriteAttributeValue("", 1228, Url.Action("Edit","NewArrival", new { area = "Admin", arrival.Id }), 1228, 68, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1297, 94, true);
            WriteLiteral("><i class=\"fas fa-edit\"></i> Edit</a></td>\r\n                    <td><a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1391, "\"", 1468, 1);
#line 33 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
WriteAttributeValue("", 1398, Url.Action("Delete","NewArrival", new { area = "Admin", arrival.Id }), 1398, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1469, 75, true);
            WriteLiteral("><i class=\"fas fa-user-minus\"></i> Delete</a></td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\NewArrival\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1563, 58, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewArrival>> Html { get; private set; }
    }
}
#pragma warning restore 1591
