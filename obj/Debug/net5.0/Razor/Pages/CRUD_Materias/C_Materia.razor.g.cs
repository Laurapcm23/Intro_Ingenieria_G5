#pragma checksum "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e75117e5ab7aff7b134e2241e7dfd4ee9529472"
// <auto-generated/>
#pragma warning disable 1591
namespace Sistema_Estudiantil.Pages.CRUD_Materias
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Sistema_Estudiantil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Sistema_Estudiantil.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
using Sistema_Estudiantil.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CRUD_Materias/C_Materia")]
    public partial class C_Materia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "Style", "margin:25px;");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardContent>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(5);
                    __builder3.AddAttribute(6, "Link", "/CRUD_Materias/Materias");
                    __builder3.AddAttribute(7, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                             Icons.Material.Filled.ArrowBack

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 6 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                     Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(9, "\r\n\r\n        ");
                    __builder3.AddMarkupContent(10, "<h2 class=\"text-center\"><strong>Agregar Materia</strong></h2>\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCard>(11);
                    __builder3.AddAttribute(12, "Style", "background-color:lightgrey;");
                    __builder3.AddAttribute(13, "Class", "mt-3");
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardContent>(15);
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudExpansionPanel>(17);
                            __builder5.AddAttribute(18, "Text", "Formulario");
                            __builder5.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudForm>(20);
                                __builder6.AddAttribute(21, "IsValid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                        success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(22, "IsValidChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => success = __value, success))));
                                __builder6.AddAttribute(23, "Errors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 12 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                               errors

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(24, "ErrorsChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String[]>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => errors = __value, errors))));
                                __builder6.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudGrid>(26);
                                    __builder7.AddAttribute(27, "Class", "mt-3");
                                    __builder7.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudItem>(29);
                                        __builder8.AddAttribute(30, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                         12

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(31, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                 6

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(32, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                        6

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddMarkupContent(34, "<label>Ingrese el nombre de la materia:</label>\r\n                                ");
                                            __builder9.OpenComponent<MudBlazor.MudTextField<string>>(35);
                                            __builder9.AddAttribute(36, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 16 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(37, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                                           true

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(38, "RequiredError", "El campo de materia es requerido...");
                                            __builder9.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 16 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                 materia.Nombre

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => materia.Nombre = __value, materia.Nombre))));
                                            __builder9.CloseComponent();
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(41, "\r\n                            ");
                                        __builder8.OpenComponent<MudBlazor.MudItem>(42);
                                        __builder8.AddAttribute(43, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                         12

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(44, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                 6

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(45, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                        6

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddMarkupContent(47, "<label>Ingrese los Creditos de la Materia:</label>\r\n                                ");
                                            __builder9.OpenComponent<MudBlazor.MudTextField<long>>(48);
                                            __builder9.AddAttribute(49, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 20 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                       Variant.Outlined

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(50, "Required", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                                           true

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(51, "RequiredError", "El campo de creditos es requerido...");
                                            __builder9.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<long>(
#nullable restore
#line 20 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                               materia.Creditos

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<long>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<long>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => materia.Creditos = __value, materia.Creditos))));
                                            __builder9.CloseComponent();
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(54, "\r\n                            ");
                                        __builder8.OpenComponent<MudBlazor.MudItem>(55);
                                        __builder8.AddAttribute(56, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                         12

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(57, "Style", "display:flex; justify-content:center;");
                                        __builder8.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.OpenComponent<MudBlazor.MudButton>(59);
                                            __builder9.AddAttribute(60, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                    Variant.Filled

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(61, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                           Color.Success

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(62, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                      !success

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                                           CreateMateria

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(64, "EndIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                                                                    Icons.Filled.Save

#line default
#line hidden
#nullable disable
                                            ));
                                            __builder9.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder10) => {
                                                __builder10.AddContent(66, "Agregar");
                                            }
                                            ));
                                            __builder9.CloseComponent();
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.AddComponentReferenceCapture(67, (__value) => {
#nullable restore
#line 12 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                   form = (MudBlazor.MudForm)__value;

#line default
#line hidden
#nullable disable
                                }
                                );
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 31 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
         if (showCallAlert)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudAlert>(68);
                    __builder3.AddAttribute(69, "Class", "mt-5");
                    __builder3.AddAttribute(70, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 33 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                             Severity.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "AlertTextPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.AlertTextPosition>(
#nullable restore
#line 33 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                  AlertTextPosition.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                                           true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "CloseIconClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MudBlazor.MudAlert>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MudBlazor.MudAlert>(this, 
#nullable restore
#line 33 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                                                                   (() => CloseMe(false))

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(75, "Materia a�adida de forma correcta");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 34 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
        }

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudExpansionPanel>(76);
                    __builder3.AddAttribute(77, "Style", "background-color:lightblue;");
                    __builder3.AddAttribute(78, "Text", "Errores del formulario");
                    __builder3.AddAttribute(79, "Class", "mt-5");
                    __builder3.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 37 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
             if (errors.Length == 0)
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudAlert>(81);
                        __builder4.AddAttribute(82, "Style", "background-color:white;");
                        __builder4.AddAttribute(83, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 39 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                    Severity.Info

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "AlertTextPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.AlertTextPosition>(
#nullable restore
#line 39 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                      AlertTextPosition.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(86, "No hay ningun error en el formulario...");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 40 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
             if (!success)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                 foreach (var error in errors)
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudAlert>(87);
                        __builder4.AddAttribute(88, "Style", "background-color:red; color:white;");
                        __builder4.AddAttribute(89, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 45 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                   Severity.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(90, "AlertTextPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.AlertTextPosition>(
#nullable restore
#line 45 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                                      AlertTextPosition.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(92, 
#nullable restore
#line 45 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                                                                                                                                                 error

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 46 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
                 
            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Materia.razor"
      
    bool success;
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;

    Materia materia = new Materia();

    void CreateMateria()
    {
        //---------------obtener el ultimo registro--------------------------
        List<Materia> getUltimoId() => new ProgramaEstudiantilDBContext().Materia.OrderByDescending(x => x.MateriaId).Take(1).ToList();

        foreach (var i in getUltimoId())
        {
            materia.MateriaId = Convert.ToInt32(i.MateriaId + 1);
        }
        //----------------------Fin----------------------------

        using (ProgramaEstudiantilDBContext cmd_Insert = new ProgramaEstudiantilDBContext())
        {
            cmd_Insert.Add(materia);
            cmd_Insert.SaveChanges();
            ShowAlert();
        }

    }

    //Close the alerts variables
    private bool showCallAlert = false;
    private bool showLeaveAlert = false;
    private bool errorAlert = false;

    //Method for closing the alert
    private void CloseMe(bool value)
    {
        if (value)
        {
            showLeaveAlert = false;
        }
        else
        {
            showCallAlert = false;
        }
    }

    //ShowAlert
    private void ShowAlert()
    {
        showCallAlert = true;
        showLeaveAlert = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
