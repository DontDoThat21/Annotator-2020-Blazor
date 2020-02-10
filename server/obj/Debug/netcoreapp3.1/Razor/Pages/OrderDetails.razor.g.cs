#pragma checksum "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fdc485187f5cc909485e5a2caafebdd29b23e67"
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
#line 1 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\Tylor\Desktop\AnnoPages\server\_Imports.razor"
using Anno.Shared;

#line default
#line hidden
#line 5 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
using Anno.Models.Sample;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/order-details")]
    public partial class OrderDetails : Anno.Pages.OrderDetailsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Order Details");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Anno.Models.Sample.OrderDetail>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Anno.Models.Sample.OrderDetail>>(
#line 16 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                                     getOrderDetailsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 16 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                                                                    getOrderDetailsCount

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#line 16 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                                                                                                                                            Grid0LoadData

#line default
#line hidden
                )));
                __builder2.AddAttribute(27, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Anno.Models.Sample.OrderDetail>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Anno.Models.Sample.OrderDetail>(this, 
#line 16 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                                                                                                                                                                       Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Anno.Models.Sample.OrderDetail>>(30);
                    __builder3.AddAttribute(31, "Property", "Id");
                    __builder3.AddAttribute(32, "Title", "Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Anno.Models.Sample.OrderDetail>>(34);
                    __builder3.AddAttribute(35, "Property", "Quantity");
                    __builder3.AddAttribute(36, "Title", "Quantity");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Anno.Models.Sample.OrderDetail>>(38);
                    __builder3.AddAttribute(39, "Property", "OrderId");
                    __builder3.AddAttribute(40, "SortProperty", "Order.UserName");
                    __builder3.AddAttribute(41, "FilterProperty", "Order.UserName");
                    __builder3.AddAttribute(42, "Title", "Order");
                    __builder3.AddAttribute(43, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Anno.Models.Sample.OrderDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(44, "\n              ");
                        __builder4.AddContent(45, 
#line 24 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                data.Order?.UserName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(46, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Anno.Models.Sample.OrderDetail>>(48);
                    __builder3.AddAttribute(49, "Property", "ProductId");
                    __builder3.AddAttribute(50, "SortProperty", "Product.ProductName");
                    __builder3.AddAttribute(51, "FilterProperty", "Product.ProductName");
                    __builder3.AddAttribute(52, "Title", "Product");
                    __builder3.AddAttribute(53, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Anno.Models.Sample.OrderDetail>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(54, "\n              ");
                        __builder4.AddContent(55, 
#line 29 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                data.Product?.ProductName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(56, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Anno.Models.Sample.OrderDetail>>(58);
                    __builder3.AddAttribute(59, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 32 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 32 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(61, "Width", "70px");
                    __builder3.AddAttribute(62, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 32 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(63, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Anno.Models.Sample.OrderDetail>)((annoModelsSampleOrderDetail) => (__builder4) => {
                        __builder4.AddMarkupContent(64, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(65);
                        __builder4.AddAttribute(66, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 34 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(67, "Icon", "close");
                        __builder4.AddAttribute(68, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 34 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(69, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 34 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, annoModelsSampleOrderDetail)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(70, "onclick", 
#line 34 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                                                                                                                                                                                                           true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(71, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(73, (__value) => {
#line 16 "C:\Users\Tylor\Desktop\AnnoPages\server\Pages\OrderDetails.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Anno.Models.Sample.OrderDetail>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591