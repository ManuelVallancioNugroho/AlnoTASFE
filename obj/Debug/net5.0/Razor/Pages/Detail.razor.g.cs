#pragma checksum "D:\Front-end (matkul)\TASfe\Pages\Detail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a262dd279eb8f3375af864122412cd1d5d6154d9"
// <auto-generated/>
#pragma warning disable 1591
namespace TASfe.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using TASfe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Front-end (matkul)\TASfe\_Imports.razor"
using TASfe.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailpage/{id}")]
    public partial class Detail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Details</h2>\r\n");
            __builder.AddMarkupContent(1, "<h5>Student</h5>\r\n<hr>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col-2\"><td>Nim</td></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-2");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 10 "D:\Front-end (matkul)\TASfe\Pages\Detail.razor"
             Students.studentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    <div class=\"col-7\"></div>\r\n    ");
            __builder.AddMarkupContent(10, "<div class=\"col-2\"><td>Nama Belakang</td></div>\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-2");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 17 "D:\Front-end (matkul)\TASfe\Pages\Detail.razor"
            Students.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    <div class=\"col-7\"></div>\r\n    ");
            __builder.AddMarkupContent(16, "<div class=\"col-2\"><td>Nama Depan</td></div>\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-2");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 24 "D:\Front-end (matkul)\TASfe\Pages\Detail.razor"
             Students.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <div class=\"col-7\"></div>\r\n    ");
            __builder.AddMarkupContent(22, "<div class=\"col-2\"><td>Tanggal Masuk</td></div>\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-3");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 31 "D:\Front-end (matkul)\TASfe\Pages\Detail.razor"
             Students.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    <div class=\"col-7\"></div>\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-2");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 35 "D:\Front-end (matkul)\TASfe\Pages\Detail.razor"
                   $"editstudent/{Students.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, " \r\n        ");
            __builder.AddMarkupContent(34, "<a>&nbsp | &nbsp</a>\r\n        ");
            __builder.AddMarkupContent(35, "<a href=\"/studentpage\">Back to List</a>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
