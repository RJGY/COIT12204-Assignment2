#pragma checksum "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8c79713c3bfb1abddda10224985701131016411"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KoalaBeach.Home.Views_Home_Catalog), @"mvc.1.0.view", @"/Views/Home/Catalog.cshtml")]
namespace KoalaBeach.Home
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
#line 2 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\_ViewImports.cshtml"
using KoalaBeach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\_ViewImports.cshtml"
using KoalaBeach.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\_ViewImports.cshtml"
using KoalaBeach.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\_ViewImports.cshtml"
using KoalaBeach.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\_ViewImports.cshtml"
using KoalaBeach.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c79713c3bfb1abddda10224985701131016411", @"/Views/Home/Catalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fd7e514b9982225bf9149ca50c86b7c0cf7d398", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Catalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private global::KoalaBeach.Home.Views_Home_Catalog.__Generated__NavigationMenuViewComponentTagHelper __NavigationMenuViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
  
    ViewData["Title"] = "Catalog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row flex-column flex-md-row\">\r\n\r\n        <div id=\"categories\" class=\"col-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:navigation-menu", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8c79713c3bfb1abddda102249857011310164115472", async() => {
            }
            );
            __NavigationMenuViewComponentTagHelper = CreateTagHelper<global::KoalaBeach.Home.Views_Home_Catalog.__Generated__NavigationMenuViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__NavigationMenuViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-9\">\r\n");
#nullable restore
#line 14 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
              
                int col = 0;

                foreach (Product p in Model)
                {
                    string image;
                    string altText;
                    if (p.Image == null || p.Image == "")
                    {
                        image = "/images/cap.png";
                        altText = "Default picture";
                    }
                    else
                    {
                        image = "/images/" + p.Image;
                        altText = p.Image.Split(".")[0];
                    }
                    if (col == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 34 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-3\">\r\n                        <div class=\"card bg-white\">\r\n                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1138, "\"", 1150, 1);
#nullable restore
#line 38 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 1144, image, 1144, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "  alt=\"", 1151, "\"", 1166, 1);
#nullable restore
#line 38 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 1158, altText, 1158, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"card-body text-center\">\r\n                                <p class=\"card-title\">");
#nullable restore
#line 40 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
                                                 Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 41 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
                                                Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"card-text\">$");
#nullable restore
#line 42 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
                                                 Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8c79713c3bfb1abddda102249857011310164119803", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"ProductID\"");
                BeginWriteAttribute("value", " value=\"", 1607, "\"", 1627, 1);
#nullable restore
#line 45 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 1615, p.ProductID, 1615, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", "\r\n                                           value=\"", 1706, "\"", 1805, 1);
#nullable restore
#line 47 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
WriteAttributeValue("", 1758, ViewContext.HttpContext.Request.PathAndQuery(), 1758, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <span class=""card-text"">
                                        <button type=""submit""
                                                class=""btn btn-success btn-sm"">
                                            Add To Cart
                                        </button>
                                    </span>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
AddHtmlAttributeValue("", 1487, p.ProductID, 1487, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 60 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"

                    if (col == 3 || col == Model.Count() - 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("</div><br />\r\n");
#nullable restore
#line 64 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Views\Home\Catalog.cshtml"
                    }

                    col = ++col % 4;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:navigation-menu")]
        public class __Generated__NavigationMenuViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__NavigationMenuViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("NavigationMenu", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
