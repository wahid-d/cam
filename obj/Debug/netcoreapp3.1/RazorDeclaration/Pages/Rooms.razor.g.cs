#pragma checksum "/Users/david/repos/cam/Pages/Rooms.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3a81f4f94b7ec0e41828d862ee44cf430490d05"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace cam.Pages
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
#nullable restore
#line 2 "/Users/david/repos/cam/Pages/Rooms.razor"
using cam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/david/repos/cam/Pages/Rooms.razor"
using cam.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rooms")]
    public partial class Rooms : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "/Users/david/repos/cam/Pages/Rooms.razor"
 
    List<Room> rooms = new List<Room>();
    List<Data.AppUser> teachers = new List<Data.AppUser>();
    List<Class> classes = new List<Class>();

    Room room = new Room();

    protected override async Task OnInitializedAsync()
    {
        rooms = await roomRepo.Get();
        foreach (var room in rooms)
        {   
            room.Classes = await classRepo.GetForRoom(room.Id);
        }
        StateHasChanged();
        teachers = await userRepo.Get();
        StateHasChanged();
    }

    private async void SaveRoom()
    {
        await roomRepo.Insert(room);
        rooms = await roomRepo.Get();
        room = new Room();
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassService classRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoomService roomRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
