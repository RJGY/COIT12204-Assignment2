#pragma checksum "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "becb61d567d4c161219281f14edd3f12f5bb0e4a"
// <auto-generated/>
#pragma warning disable 1591
namespace KoalaBeach.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\_Imports.razor"
using KoalaBeach.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/create")]
    public partial class Editor : OwningComponentBase<IStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    div.validation-message {\r\n        color: rgb(220, 53, 69);\r\n        font-weight: 500\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 12 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                                       TitleText

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " a Product");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                 Product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                         SaveProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n");
#nullable restore
#line 16 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
     if (Product.ProductID != 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, "<label>ID</label>\r\n            ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "disabled", true);
                __builder2.AddAttribute(21, "value", 
#nullable restore
#line 20 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                                         Product.ProductID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n");
#nullable restore
#line 22 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, "    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<label>Name</label>\r\n        ");
                __Blazor.KoalaBeach.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 25 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                  () => Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                                     Product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Name = __value, Product.Name))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.AddMarkupContent(42, "<label>Description</label>\r\n        ");
                __Blazor.KoalaBeach.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 30 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                  () => Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                                     Product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Description = __value, Product.Description))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.AddMarkupContent(56, "<label>Category</label>\r\n        ");
                __Blazor.KoalaBeach.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 35 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                  () => Product.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                                     Product.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Category = __value, Product.Category))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.AddMarkupContent(69, "<label> Sub-category </label><br>\r\n        ");
                __Blazor.KoalaBeach.Pages.Admin.Editor.TypeInference.CreateInputSelect_3(__builder2, 70, 71, 
#nullable restore
#line 40 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                  Product.SubCategory

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.SubCategory = __value, Product.SubCategory)), 73, () => Product.SubCategory, 74, (__builder3) => {
                    __builder3.AddMarkupContent(75, "\r\n            ");
                    __builder3.AddMarkupContent(76, "<option value=\"Both\">Both</option>\r\n            ");
                    __builder3.AddMarkupContent(77, "<option value=\"Men\">Men</option>\r\n            ");
                    __builder3.AddMarkupContent(78, "<option value=\"Women\">Women</option>\r\n        ");
                }
                );
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.AddMarkupContent(83, "<label> <br> Sale </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(84);
                __builder2.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                    Product.Sale

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Sale = __value, Product.Sale))));
                __builder2.AddAttribute(87, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Product.Sale));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n    ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "form-group");
                __builder2.AddMarkupContent(92, "\r\n        ");
                __builder2.AddMarkupContent(93, "<label>Price</label>\r\n        ");
                __Blazor.KoalaBeach.Pages.Admin.Editor.TypeInference.CreateValidationMessage_4(__builder2, 94, 95, 
#nullable restore
#line 52 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                  () => Product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(96, "\r\n        ");
                __Blazor.KoalaBeach.Pages.Admin.Editor.TypeInference.CreateInputNumber_5(__builder2, 97, 98, "form-control", 99, 
#nullable restore
#line 53 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                                       Product.Price

#line default
#line hidden
#nullable disable
                , 100, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Price = __value, Product.Price)), 101, () => Product.Price);
                __builder2.AddMarkupContent(102, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n    ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group");
                __builder2.AddMarkupContent(106, "\r\n        ");
                __builder2.AddMarkupContent(107, "<label>Image File Name</label>\r\n        ");
                __Blazor.KoalaBeach.Pages.Admin.Editor.TypeInference.CreateValidationMessage_6(__builder2, 108, 109, 
#nullable restore
#line 57 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                  () => Product.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(110, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(111);
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                                     Product.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Image = __value, Product.Image))));
                __builder2.AddAttribute(115, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Image));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n    ");
                __builder2.OpenElement(118, "button");
                __builder2.AddAttribute(119, "type", "submit");
                __builder2.AddAttribute(120, "class", "btn" + " btn-" + (
#nullable restore
#line 60 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
                                          ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(121, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(123);
                __builder2.AddAttribute(124, "class", "btn btn-secondary");
                __builder2.AddAttribute(125, "href", "/admin/products");
                __builder2.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(127, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Alerz\Documents\uni work\year 2 sem 2\website development\assess 2\KoalaBeach\KoalaBeach\Pages\Admin\Editor.razor"
 
    public IStoreRepository Repository => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public long Id { get; set; } = 0;
    public Product Product { get; set; } = new Product();

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            Product = Repository.Products.FirstOrDefault(p => p.ProductID == Id);
        }
    }
    public void SaveProduct()
    {
        if (Id == 0)
        {
            Repository.CreateProduct(Product);
        }
        else
        {
            Repository.SaveProduct(Product);
        }

        NavManager.NavigateTo("/admin/products");
    }
    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.KoalaBeach.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
