#pragma checksum "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca79976d89dab6eeca381f6f475f5607dfcd9bd3"
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
#line 11 "C:\WorkingProjects\BlazorAdoNet\_Imports.razor"
using BlazorAdoNet.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeleteCustomer/{CurrentId}")]
    public partial class DeleteCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Delete Customer</h3>\r\n<hr>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.AddMarkupContent(7, "<label>Customer ID:</label>\r\n            ");
            __builder.OpenElement(8, "label");
            __builder.AddContent(9, 
#nullable restore
#line 14 "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor"
                    objCI.CustId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "<label>Name:</label>\r\n            ");
            __builder.OpenElement(14, "label");
            __builder.AddContent(15, 
#nullable restore
#line 18 "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor"
                    objCI.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.AddMarkupContent(19, "<label>Gender:</label>\r\n            ");
            __builder.OpenElement(20, "label");
            __builder.AddContent(21, 
#nullable restore
#line 22 "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor"
                    objCI.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "<label>Country:</label>\r\n            ");
            __builder.OpenElement(26, "label");
            __builder.AddContent(27, 
#nullable restore
#line 26 "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor"
                    objCI.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group");
            __builder.AddMarkupContent(31, "<label>City:</label>\r\n            ");
            __builder.OpenElement(32, "label");
            __builder.AddContent(33, 
#nullable restore
#line 30 "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor"
                    objCI.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-4");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor"
                                            DeleteCustomers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "class", "btn btn-primary");
            __builder.AddAttribute(45, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor"
                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\WorkingProjects\BlazorAdoNet\Pages\DeleteCustomer.razor"
       

    [Parameter]
    public string CurrentID { get; set; }
    CustomerInfo objCI = new CustomerInfo();

    protected override async Task OnInitializedAsync()
    {
        objCI = ObjCustomService.GetCustomerByID(int.Parse(CurrentID));
    }
    protected void DeleteCustomers()
    {
        ObjCustomService.DeleteCustomer(objCI);
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
