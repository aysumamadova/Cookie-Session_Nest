#pragma checksum "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77d6a4211cc9599e04fe6980b73652da0ccfed14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\_ViewImports.cshtml"
using Nest_Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\_ViewImports.cshtml"
using Nest_Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\_ViewImports.cshtml"
using Nest_Backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d6a4211cc9599e04fe6980b73652da0ccfed14", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57478d0b789b0ec658c37f7590456baedb99b5f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-30\">\r\n    <div class=\"row flex-row-reverse\">\r\n        <div class=\"col-lg-4-5\">\r\n            <div class=\"row product-grid\">\r\n                ");
#nullable restore
#line 11 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml"
           Write(await Html.PartialAsync("~/Views/Shared/_ProductPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!--end product card-->\r\n            </div>\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 399, "\"", 428, 1);
#nullable restore
#line 14 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml"
WriteAttributeValue("", 407, ViewBag.ProductCount, 407, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"proCount\" />\r\n            <div class=\"d-flex justify-content-center mb-30\">\r\n                <button class=\"btn btn-brand\" id=\"btnLoadMore\">Load more</button>\r\n            </div>\r\n            <!--product grid-->\r\n");
            WriteLiteral(@"            <!--End Deals-->
        </div>
        <div class=""col-lg-1-5 primary-sidebar sticky-sidebar"">
            <div class=""sidebar-widget widget-category-2 mb-30"">
                <h5 class=""section-title style-1 mb-30"">Category</h5>
                <ul>
");
#nullable restore
#line 42 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml"
                     foreach (Categories item in ViewBag.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"category-filter\" data-id=\"");
#nullable restore
#line 44 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml"
                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <a> <img");
            BeginWriteAttribute("src", " src=\"", 2256, "\"", 2289, 2);
            WriteAttributeValue("", 2262, "assets/imgs/shop/", 2262, 17, true);
#nullable restore
#line 45 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml"
WriteAttributeValue("", 2279, item.Logo, 2279, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2290, "\"", 2296, 0);
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 45 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span class=\"count\">");
#nullable restore
#line 45 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml"
                                                                                                             Write(item.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </li>\r\n");
#nullable restore
#line 47 "C:\Users\tu7tw2d21\Desktop\Cookie-Session_Nest\Nest_Backend\Nest_Backend\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
            <!-- Fillter By Price -->
            <div class=""sidebar-widget price_range range mb-30"">
                <h5 class=""section-title style-1 mb-30"">Fill by price</h5>
                <div class=""price-filter"">
                    <div class=""price-filter-inner"">
                        <div id=""slider-range"" class=""mb-20""></div>
                        <div class=""d-flex justify-content-between"">
                            <div class=""caption"">From: <strong id=""slider-range-value1"" class=""text-brand""></strong></div>
                            <div class=""caption"">To: <strong id=""slider-range-value2"" class=""text-brand""></strong></div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Product sidebar Widget -->
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).on(""click"", ""#btnLoadMore"", function () {
            let skip = $("".product-grid"").children().length;
            let prodCount = $(""#proCount"").val();
            $.ajax({
                url: ""/Product/LoadMore"",
                method: 'GET',
                data: {
                    skip: skip
                },
                success: function (res) {
                    $("".product-grid"").append(res);
                    if ($("".product-grid"").children().length >= prodCount) {
                        $(""#btnLoadMore"").remove();
                    }
                }
            })
        })
        $(document).on(""click"", "".category-filter"", function () {
            let id = $(this).attr(""data-id"");
            $.ajax({
                url: ""/Product/CategoryFilter"",
                method: 'GET',
                data: {
                    CategoryId: id
                },
                success: function (res) {
                    ");
                WriteLiteral("$(\".product-grid\").html(res);\r\n                }\r\n            })\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
