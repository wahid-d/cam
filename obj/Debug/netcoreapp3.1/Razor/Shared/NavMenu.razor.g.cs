#pragma checksum "/Users/HSpark/Projects/cam/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c9a49698a57dc187ec27a528e41df43849c870e"
// <auto-generated/>
#pragma warning disable 1591
namespace cam.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/HSpark/Projects/cam/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/HSpark/Projects/cam/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/HSpark/Projects/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/HSpark/Projects/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/HSpark/Projects/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/HSpark/Projects/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/HSpark/Projects/cam/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/HSpark/Projects/cam/_Imports.razor"
using cam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/HSpark/Projects/cam/_Imports.razor"
using cam.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.AddAttribute(1, "class", "page-header");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "nav");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<a href=\"#0\">\r\n            <i class=\"fas fa-pen-nib fa-3x logo\"><span>wd</span></i>\r\n        </a>\r\n        \r\n        ");
            __builder.OpenComponent<cam.Shared.ToggleLink>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "admin-menu");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenComponent<cam.Shared.ClassLink>(11);
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenComponent<cam.Shared.StudentLink>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenComponent<cam.Shared.ReportsLink>(15);
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenComponent<cam.Shared.CollapseLink>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
