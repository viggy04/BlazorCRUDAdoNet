#pragma checksum "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cb47c4f92777776551ccc4046982035e2b4e560"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdoNet.Pages
{
    #line hidden
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
#line 2 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
using BlazorAdoNet.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditCustomer/{CurretnID}")]
    public partial class EditCustomer : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "for", "Name");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
                                                               objCI.CustId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.CustId = __value, objCI.CustId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group");
            __builder.AddMarkupContent(16, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "for", "Name");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
                                                               objCI.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Name = __value, objCI.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "<label asp-for=\"Gender\" class=\"control-label\"></label>\r\n                ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
                                objCI.Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Gender = __value, objCI.Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value");
            __builder.AddContent(32, "-- Select Gender --");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "Male");
            __builder.AddContent(36, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "Female");
            __builder.AddContent(40, "Female");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "<label for=\"Country\" class=\"control-label\">Country</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "for", "Country");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
                                                                  objCI.Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.Country = __value, objCI.Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group");
            __builder.AddMarkupContent(53, "<label for=\"City\" class=\"control-label\">City</label>\r\n                ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "for", "City");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
                                                               objCI.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCI.City = __value, objCI.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-md-4");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "button");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
                                                UpdateCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "class", "btn btn-primary");
            __builder.AddAttribute(70, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "type", "button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "class", "btn btn-primary");
            __builder.AddAttribute(76, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\WorkingProjects\BlazorAdoNet\Pages\EditCustomer.razor"
       
    [Parameter]
    public string CurretnID { get; set; }
    CustomerInfo objCI = new CustomerInfo();

    protected override async Task OnInitializedAsync()
    {
        objCI = await Task.Run(() => ObjCustomService.GetCustomerByID(Convert.ToInt32(CurretnID)));
    }
    protected void UpdateCustomer()
    {
        ObjCustomService.UpdateCustomer(objCI);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomerService ObjCustomService { get; set; }
    }
}
#pragma warning restore 1591