#pragma checksum "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "862662c457d90d4c2467b2b90392b7f41a75e4f2"
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
#line 5 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
using Anno.Models.Sample;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/orders")]
    public partial class Orders : Anno.Pages.OrdersComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Orders");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\r\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Anno.Models.Sample.Order>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Anno.Models.Sample.Order>>(
#line 16 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                                     getOrdersResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 16 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                                                              getOrdersCount

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#line 16 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                                                                                                                          Grid0LoadData

#line default
#line hidden
                )));
                __builder2.AddAttribute(27, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Anno.Models.Sample.Order>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Anno.Models.Sample.Order>(this, 
#line 16 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                                                                                                                                                     Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(28, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Anno.Models.Sample.Order>>(30);
                    __builder3.AddAttribute(31, "Property", "Id");
                    __builder3.AddAttribute(32, "Title", "Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Anno.Models.Sample.Order>>(34);
                    __builder3.AddAttribute(35, "Property", "UserName");
                    __builder3.AddAttribute(36, "Title", "User Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Anno.Models.Sample.Order>>(38);
                    __builder3.AddAttribute(39, "Property", "OrderDate");
                    __builder3.AddAttribute(40, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(41, "Title", "Order Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Anno.Models.Sample.Order>>(43);
                    __builder3.AddAttribute(44, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                                           false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(45, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 24 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                                                            false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(46, "Width", "70px");
                    __builder3.AddAttribute(47, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 24 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                                                                                           TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(48, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Anno.Models.Sample.Order>)((annoModelsSampleOrder) => (__builder4) => {
                        __builder4.AddMarkupContent(49, "\r\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(50);
                        __builder4.AddAttribute(51, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 26 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(52, "Icon", "close");
                        __builder4.AddAttribute(53, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 26 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(54, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 26 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, annoModelsSampleOrder)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(55, "onclick", 
#line 26 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                                                                                                                                                                                                     true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(58, (__value) => {
#line 16 "C:\Users\ttrub\Source\Repos\DontDoThat21\Annotator-2020-Blazor\server\Pages\Orders.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Anno.Models.Sample.Order>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
