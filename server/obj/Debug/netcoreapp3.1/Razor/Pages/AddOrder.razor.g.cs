#pragma checksum "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab4d19fb77076cc7affbfe651b5103a3a0b1bc79"
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
#line 1 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\_Imports.razor"
using Anno.Shared;

#line default
#line hidden
#line 5 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
using Anno.Models.Sample;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-order")]
    public partial class AddOrder : Anno.Pages.AddOrderComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\r\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Anno.Models.Sample.Order>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Anno.Models.Sample.Order>(
#line 12 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
                                   order

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
                                                     order != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Anno.Models.Sample.Order>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Anno.Models.Sample.Order>(this, 
#line 12 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
                                                                                                               Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\r\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "User Name");
                    __builder3.AddAttribute(25, "Component", "UserName");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "style", "width: 100%");
                    __builder3.AddAttribute(34, "Name", "UserName");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
                                                                  order.UserName

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.UserName = __value, order.UserName))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => order.UserName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\r\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.AddMarkupContent(44, "\r\n              ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-3");
                    __builder3.AddMarkupContent(47, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
                    __builder3.AddAttribute(49, "Text", "Order Date");
                    __builder3.AddAttribute(50, "Component", "OrderDate");
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\r\n              ");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-9");
                    __builder3.AddMarkupContent(56, "\r\n                ");
                    __Blazor.Anno.Pages.AddOrder.TypeInference.CreateRadzenDatePicker_0(__builder3, 57, 58, "MM/dd/yyyy", 59, "display: block; width: 100%", 60, "OrderDate", 61, 
#line 30 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
                                                                                                             order.OrderDate

#line default
#line hidden
                    , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.OrderDate = __value, order.OrderDate)), 63, () => order.OrderDate);
                    __builder3.AddMarkupContent(64, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(65);
                    __builder3.AddAttribute(66, "Component", "OrderDate");
                    __builder3.AddAttribute(67, "Text", "OrderDate is required");
                    __builder3.AddAttribute(68, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n            ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "row");
                    __builder3.AddMarkupContent(74, "\r\n              ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(77, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(78);
                    __builder3.AddAttribute(79, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 38 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(80, "Icon", "save");
                    __builder3.AddAttribute(81, "Text", "Save");
                    __builder3.AddAttribute(82, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 38 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(84);
                    __builder3.AddAttribute(85, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 40 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(86, "Text", "Cancel");
                    __builder3.AddAttribute(87, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 40 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\AddOrder.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\r\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Anno.Pages.AddOrder
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
