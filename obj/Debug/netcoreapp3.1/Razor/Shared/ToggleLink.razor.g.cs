#pragma checksum "/Users/david/repos/cam/Shared/ToggleLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9dc4b5b8fe13bd00e811da909d373a6159909c8"
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
#line 1 "/Users/david/repos/cam/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/david/repos/cam/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/david/repos/cam/_Imports.razor"
using cam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/david/repos/cam/_Imports.razor"
using cam.Shared;

#line default
#line hidden
#nullable disable
    public partial class ToggleLink : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "/Users/david/repos/cam/Shared/ToggleLink.razor"
                                   ToggleClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 3 "/Users/david/repos/cam/Shared/ToggleLink.razor"
                                                               ToggleUnfocused

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "toggle-mob-menu");
            __builder.AddAttribute(4, "aria-expanded", "false");
            __builder.AddAttribute(5, "aria-label", "open menu");
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 3 "/Users/david/repos/cam/Shared/ToggleLink.razor"
              toggleBtn = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(7, " \n    <i class=\"fas fa-bars fa-2x\"></i>\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "/Users/david/repos/cam/Shared/ToggleLink.razor"
       
    ElementReference toggleBtn;

    public async Task ToggleClicked()
    {
        await JSRuntime.InvokeVoidAsync("toggleBtnClicked", toggleBtn);
    }
    public async Task ToggleUnfocused()
    {
        await JSRuntime.InvokeVoidAsync("toggleUnfocused", toggleBtn);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
