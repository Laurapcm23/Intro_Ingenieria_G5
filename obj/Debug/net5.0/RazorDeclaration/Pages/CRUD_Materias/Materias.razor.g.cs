// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sistema_Estudiantil.Pages.CRUD_Materias
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Sistema_Estudiantil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Sistema_Estudiantil.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\Pages\CRUD_Materias\Materias.razor"
using Sistema_Estudiantil.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CRUD_Materias/Materias")]
    public partial class Materias : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\Pages\CRUD_Materias\Materias.razor"
      
    List<Materia> GetMaterias() => new ProgramaEstudiantilDBContext().Materia.ToList();

    //Methods for the funcionality of Datatable
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#table");
    }
    void IDisposable.Dispose()
    {
        JSRuntime.InvokeAsync<object>("TestDataTablesRemove", "#table");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
