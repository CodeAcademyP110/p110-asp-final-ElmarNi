#pragma checksum "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da4e86c4c9ee0276c5630e3a9c803f0a9aafb7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Advertisement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Advertisement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Advertisement/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Advertisement_Index))]
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
#line 1 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\_ViewImports.cshtml"
using aspFinal.ViewModel;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\_ViewImports.cshtml"
using aspFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da4e86c4c9ee0276c5630e3a9c803f0a9aafb7f", @"/Areas/Admin/Views/Advertisement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf694dcf4e6b1a3a31f8a4ad34a7201b6267ca37", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Advertisement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Advertisement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:165px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-block my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 291, true);
            WriteLiteral(@"<div class=""page-wrapper"">
    <!-- Container fluid  -->
    <div class=""container-fluid"">

        <!-- Bread crumb and right sidebar toggle -->
        <div class=""row page-titles"">
            <div class=""col-12 text-center"">
                <h3 class=""text-themecolor"">Hello dear ");
            EndContext();
            BeginContext(327, 18, false);
#line 9 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                                                  Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(345, 126, true);
            WriteLiteral("</h3>\r\n                <ol class=\"breadcrumb d-flex justify-content-center\">\r\n                    <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(471, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c824f5a9a7a4effaf23813bc243a941", async() => {
                BeginContext(520, 5, true);
                WriteLiteral("Admin");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(529, 900, true);
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"">Advertisment</li>
                </ol>
            </div>
        </div>

        <div class=""row page-titles"">
            <table class=""table table-bordered text-white table-responsive w-100"">
                <thead>
                    <tr>
                        <th>Image</th>
                        <th>Brand</th>
                        <th>Make</th>
                        <th>Motor</th>
                        <th>Millage</th>
                        <th>Transmission</th>
                        <th>Color</th>
                        <th>Current date</th>
                        <th>Updated date</th>
                        <th>Price</th>
                        <th>Is VIP?</th>
                        <th>Details</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 36 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                     foreach (var ad in Model)
                    {

#line default
#line hidden
            BeginContext(1500, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1596, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24fcdde8153143aead3674d3945f0d9c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1626, "~/img/", 1626, 6, true);
#line 40 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
AddHtmlAttributeValue("", 1632, ad.Car.Image, 1632, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1649, 71, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(1721, 22, false);
#line 43 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                           Write(ad.Car.Make.Brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1743, 41, true);
            WriteLiteral("</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(1785, 16, false);
#line 45 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                           Write(ad.Car.Make.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1801, 41, true);
            WriteLiteral("</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(1843, 12, false);
#line 47 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                           Write(ad.Car.Motor);

#line default
#line hidden
            EndContext();
            BeginContext(1855, 43, true);
            WriteLiteral(" L</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(1899, 14, false);
#line 49 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                           Write(ad.Car.Millage);

#line default
#line hidden
            EndContext();
            BeginContext(1913, 44, true);
            WriteLiteral(" km</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(1958, 24, false);
#line 51 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                           Write(ad.Car.Transmission.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1982, 41, true);
            WriteLiteral("</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(2024, 12, false);
#line 53 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                           Write(ad.Car.Color);

#line default
#line hidden
            EndContext();
            BeginContext(2036, 41, true);
            WriteLiteral("</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(2078, 18, false);
#line 55 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                           Write(ad.CurrentDate.Day);

#line default
#line hidden
            EndContext();
            BeginContext(2096, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(2098, 20, false);
#line 55 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                                               Write(ad.CurrentDate.Month);

#line default
#line hidden
            EndContext();
            BeginContext(2118, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(2120, 19, false);
#line 55 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                                                                     Write(ad.CurrentDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2139, 41, true);
            WriteLiteral("</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(2181, 18, false);
#line 57 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                           Write(ad.UpdatedDate.Day);

#line default
#line hidden
            EndContext();
            BeginContext(2199, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(2201, 20, false);
#line 57 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                                               Write(ad.UpdatedDate.Month);

#line default
#line hidden
            EndContext();
            BeginContext(2221, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(2223, 19, false);
#line 57 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                                                                     Write(ad.UpdatedDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2242, 41, true);
            WriteLiteral("</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(2284, 12, false);
#line 59 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                           Write(ad.Car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2296, 45, true);
            WriteLiteral(" $</td>\r\n\r\n                            <td>\r\n");
            EndContext();
#line 62 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                                 if (ad.Car.IsVip)
                                {

#line default
#line hidden
            BeginContext(2428, 54, true);
            WriteLiteral("                                    <span>Yes</span>\r\n");
            EndContext();
#line 65 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2590, 53, true);
            WriteLiteral("                                    <span>No</span>\r\n");
            EndContext();
#line 69 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2678, 101, true);
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2779, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62fcb0358e3c4aebac20a3543505a32f", async() => {
                BeginContext(2869, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                                                                                                      WriteLiteral(ad.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2880, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 75 "C:\Users\User\Desktop\aspFinal\aspFinal\Areas\Admin\Views\Advertisement\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2971, 323, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <!-- End Bread crumb and right sidebar toggle -->
    </div>
    <!-- End Container fluid  -->
    <!-- footer -->
    <footer class=""footer"">
        © 2019 Admin Wrap Admin by themedesigner.in
    </footer>
    <!-- End footer -->
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Advertisement>> Html { get; private set; }
    }
}
#pragma warning restore 1591