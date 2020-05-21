#pragma checksum "/Users/david/repos/cam/Pages/AddStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6739af4e2adf0eb9a1198dbf741b4c36a08cb130"
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
#line 2 "/Users/david/repos/cam/Pages/AddStudent.razor"
using cam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/david/repos/cam/Pages/AddStudent.razor"
using cam.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addstudent")]
    public partial class AddStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/Users/david/repos/cam/Pages/AddStudent.razor"
      
    List<string> levels = new List<string>(){"Select ...", "Primary 1", "Primary 2", "Primary 3", "Primary 4", "Primary 5", "Primary 6"};
    Student student = new Student(){Birthdate = DateTime.Now};

    private void SaveStudent()
    {
        Save(student);
    }

    private async void Save(Student student)
    {
        await studentRepo.Insert(student);
        NavigationManager.NavigateTo("/students", false);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService studentRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
