#pragma checksum "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f031fa0055f36b487611a7a20c32d0b962e35bca"
// <auto-generated/>
#pragma warning disable 1591
namespace Anno.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\_Imports.razor"
using Anno.Shared;

#line default
#line hidden
#line 5 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
using Anno.Models.Sample;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-product")]
    public partial class AddProduct : Anno.Pages.AddProductComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Anno.Models.Sample.Product>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Anno.Models.Sample.Product>(
#line 12 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                   product

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                                       product != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Anno.Models.Sample.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Anno.Models.Sample.Product>(this, 
#line 12 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                                                                                                     Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "Product Name");
                    __builder3.AddAttribute(25, "Component", "ProductName");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "style", "width: 100%");
                    __builder3.AddAttribute(34, "Name", "ProductName");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                                                  product.ProductName

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProductName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-3");
                    __builder3.AddMarkupContent(47, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
                    __builder3.AddAttribute(49, "Text", "Product Price");
                    __builder3.AddAttribute(50, "Component", "ProductPrice");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\n                ");
                    __Blazor.Anno.Pages.AddProduct.TypeInference.CreateRadzenNumeric_0(__builder3, 57, 58, "display: block; width: 100%", 59, "ProductPrice", 60, 
#line 30 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                                                                  product.ProductPrice

#line default
#line hidden
                    , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductPrice = __value, product.ProductPrice)), 62, () => product.ProductPrice);
                    __builder3.AddMarkupContent(63, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(64);
                    __builder3.AddAttribute(65, "Component", "ProductPrice");
                    __builder3.AddAttribute(66, "Text", "ProductPrice is required");
                    __builder3.AddAttribute(67, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\n            ");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(73, "class", "row");
                    __builder3.AddMarkupContent(74, "\n              ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "class", "col-md-3");
                    __builder3.AddMarkupContent(77, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(78);
                    __builder3.AddAttribute(79, "Text", "Product Picture");
                    __builder3.AddAttribute(80, "Component", "ProductPicture");
                    __builder3.AddAttribute(81, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "class", "col-md-9");
                    __builder3.AddMarkupContent(86, "\n                ");
                    __Blazor.Anno.Pages.AddProduct.TypeInference.CreateRadzenFileInput_1(__builder3, 87, 88, "ProductPicture", 89, 
#line 42 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                                product.ProductPicture

#line default
#line hidden
                    , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductPicture = __value, product.ProductPicture)), 91, () => product.ProductPicture);
                    __builder3.AddMarkupContent(92, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(93, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\n            ");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "class", "row");
                    __builder3.AddMarkupContent(97, "\n              ");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(100, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(101);
                    __builder3.AddAttribute(102, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 48 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(103, "Icon", "save");
                    __builder3.AddAttribute(104, "Text", "Save");
                    __builder3.AddAttribute(105, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 48 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(107);
                    __builder3.AddAttribute(108, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 50 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(109, "Text", "Cancel");
                    __builder3.AddAttribute(110, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 50 "C:\Users\Tylor\source\repos\Annotator-2020-Blazor\server\Pages\AddProduct.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Anno.Pages.AddProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenFileInput_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenFileInput<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
