#pragma checksum "C:\WorkingProjects\BlazorAdoNet\Pages\AddCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9140eb3f5e81ca65d77606cad0b4bcdea826c043"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdoNet.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using BlazorAdoNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using BlazorAdoNet.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WorkingProjects\BlazorAdoNet\Pages\AddCustomer.razor"
using BlazorAdoNet.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addCustomer")]
    public partial class AddCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Customer</h3>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                    ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "for", "Name");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\WorkingProjects\BlazorAdoNet\Pages\AddCustomer.razor"
                                                                   objCI.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Name = __value, objCI.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label asp-for=\"Gender\" class=\"control-label\"></label>\r\n                    ");
            __builder.OpenElement(18, "select");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\WorkingProjects\BlazorAdoNet\Pages\AddCustomer.razor"
                                    objCI.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Gender = __value, objCI.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value");
            __builder.AddContent(24, "-- Select Gender --");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "Male");
            __builder.AddContent(28, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "Female");
            __builder.AddContent(32, "Female");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group");
            __builder.AddMarkupContent(36, "<label for=\"Country\" class=\"control-label\">Country</label>\r\n                    ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "for", "Country");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\WorkingProjects\BlazorAdoNet\Pages\AddCustomer.razor"
                                                                      objCI.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Country = __value, objCI.Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "<label for=\"City\" class=\"control-label\">City</label>\r\n                    ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "for", "City");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\WorkingProjects\BlazorAdoNet\Pages\AddCustomer.razor"
                                                                   objCI.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.City = __value, objCI.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "row");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-md-4");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\WorkingProjects\BlazorAdoNet\Pages\AddCustomer.razor"
                                                                            CreateCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn btn-primary");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\WorkingProjects\BlazorAdoNet\Pages\AddCustomer.razor"
                                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\WorkingProjects\BlazorAdoNet\Pages\AddCustomer.razor"
       

    CustomerInfo objCI = new CustomerInfo();
    protected void CreateCustomer()
    {
        ObjCustomerService.Create(objCI);
        NavigationManager.NavigateTo("Customer");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Customer");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomerService ObjCustomerService { get; set; }
    }
}
#pragma warning restore 1591
