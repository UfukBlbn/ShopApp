#pragma checksum "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bd518f6dcd03844d0f6fdb126e72306c8e6327e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
#line 2 "C:\Users\casper\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\casper\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\casper\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd518f6dcd03844d0f6fdb126e72306c8e6327e", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a1d473ff392a7c3da7e52d0828e770ca054fb36", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/pagination.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8bd518f6dcd03844d0f6fdb126e72306c8e6327e3929", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 6 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"row\">                  \r\n");
#nullable restore
#line 10 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                  foreach (var product in Model.Products)
                     {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 13 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                       Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                        </div>       \r\n");
#nullable restore
#line 15 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                     }                   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div>

    </div>
<div class=""demo"">
    <nav class=""pagination-outer"" aria-label=""Page navigation"">
        <ul class=""pagination"">
            <li class=""page-item"">
                <a href=""/products?page=1"" class=""page-link "" aria-label=""Previous"">
                    <span aria-hidden=""true"">«</span>
                </a>
            </li>
");
#nullable restore
#line 30 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
             for (int i = 0; i < Model.PageInfo.totalPages(); i++)
            {
                if(String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 1179, "\"", 1243, 2);
            WriteAttributeValue("", 1187, "page-item", 1187, 9, true);
#nullable restore
#line 34 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1196, Model.PageInfo.CurrentPage==i+1?"active":"", 1197, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1291, "\"", 1319, 2);
            WriteAttributeValue("", 1298, "/products?page=", 1298, 15, true);
#nullable restore
#line 35 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1313, i+1, 1313, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 36 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                        Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a></li>\r\n");
#nullable restore
#line 38 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <li");
            BeginWriteAttribute("class", " class=\"", 1478, "\"", 1542, 2);
            WriteAttributeValue("", 1486, "page-item", 1486, 9, true);
#nullable restore
#line 41 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1495, Model.PageInfo.CurrentPage==i+1?"active":"", 1496, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1590, "\"", 1650, 4);
            WriteAttributeValue("", 1597, "/products/", 1597, 10, true);
#nullable restore
#line 42 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1607, Model.PageInfo.CurrentCategory, 1607, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1638, "?page=", 1638, 6, true);
#nullable restore
#line 42 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1644, i+1, 1644, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 43 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                        Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a></li>\r\n");
#nullable restore
#line 45 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
                }
              
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("           <li class=\"page-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1828, "\"", 1878, 2);
            WriteAttributeValue("", 1835, "/products?page=", 1835, 15, true);
#nullable restore
#line 49 "C:\Users\casper\shopapp\shopapp.webui\Views\Shop\List.cshtml"
WriteAttributeValue("", 1850, Model.PageInfo.totalPages(), 1850, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Next\">\r\n                    <span aria-hidden=\"true\">»</span>\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
