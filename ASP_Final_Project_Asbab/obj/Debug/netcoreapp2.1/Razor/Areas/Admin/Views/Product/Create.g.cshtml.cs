#pragma checksum "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "058c88328eae232f86d388a6eda364b2977447e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058c88328eae232f86d388a6eda364b2977447e0", @"/Areas/Admin/Views/Product/Create.cshtml")]
    public class Areas_Admin_Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_Final_Project_Asbab.Models.ViewModel.ViewModelClasses>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(172, 141, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <form method=\"post\" enctype=\"multipart/form-data\">\r\n            ");
            EndContext();
            BeginContext(314, 23, false);
#line 12 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(337, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(352, 64, false);
#line 13 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(416, 56, true);
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(473, 34, false);
#line 15 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(t => t.Product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(507, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(526, 106, false);
#line 16 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.TextBoxFor(t => t.Product.Name, new { @class = "form-control", type = "text", placeholder = "Name" }));

#line default
#line hidden
            EndContext();
            BeginContext(632, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(651, 84, false);
#line 17 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(t => t.Product.Name, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(735, 78, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(814, 37, false);
#line 21 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(t => t.Product.Details));

#line default
#line hidden
            EndContext();
            BeginContext(851, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(870, 112, false);
#line 22 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.TextBoxFor(t => t.Product.Details, new { @class = "form-control", type = "text", placeholder = "Details" }));

#line default
#line hidden
            EndContext();
            BeginContext(982, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1001, 87, false);
#line 23 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(t => t.Product.Details, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 78, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1167, 35, false);
#line 27 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(t => t.Product.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1221, 108, false);
#line 28 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.TextBoxFor(t => t.Product.Price, new { @class = "form-control", type = "text", placeholder = "Price" }));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1348, 85, false);
#line 29 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(t => t.Product.Price, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 78, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1512, 43, false);
#line 33 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(t => t.Product.DiscountPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1574, 125, false);
#line 34 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.TextBoxFor(t => t.Product.DiscountPrice, new { @class = "form-control", type = "text", placeholder = "Discount Price" }));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1718, 93, false);
#line 35 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(t => t.Product.DiscountPrice, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1811, 78, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1890, 35, false);
#line 39 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(t => t.Product.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1944, 105, false);
#line 40 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.TextBoxFor(t => t.Product.Photo, new { @class = "form-control", type = "file", accept = "image/*" }));

#line default
#line hidden
            EndContext();
            BeginContext(2049, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2068, 85, false);
#line 41 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(t => t.Product.Photo, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2153, 87, true);
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n            <select class=\"form-control\" name=\"CategoryId\">\r\n");
            EndContext();
#line 46 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
                 foreach (var category in Model.Categories)
                {

#line default
#line hidden
            BeginContext(2320, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2347, "\"", 2367, 1);
#line 48 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
WriteAttributeValue("", 2355, category.Id, 2355, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2368, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2370, 13, false);
#line 48 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
                                            Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2383, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 49 "C:\Users\User\source\repos\ASP_Final_Project_Asbab\ASP_Final_Project_Asbab\Areas\Admin\Views\Product\Create.cshtml"
                }

#line default
#line hidden
            BeginContext(2413, 140, true);
            WriteLiteral("            </select>\r\n\r\n            <input type=\"submit\" class=\"btn btn-success\" value=\"Create\" />\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2570, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2576, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa5e9e69e8d7403c93d7a41828874f5d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2647, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2653, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f27c967caa4a01a0d4e578fb760337", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2743, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_Final_Project_Asbab.Models.ViewModel.ViewModelClasses> Html { get; private set; }
    }
}
#pragma warning restore 1591