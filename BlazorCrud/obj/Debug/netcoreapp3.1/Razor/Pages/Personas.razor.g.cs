#pragma checksum "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa0c62b5152f9889131c6103d60345394d5ba9a2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using BlazorCrud.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
using BlazorCrud.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/personas")]
    public partial class Personas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Personas</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row\"><div class=\"col-12 text-right\"><a class=\"btn btn-success\" href=\"agregar\">Nuevo</a></div></div>\r\n\r\n\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<tr><th>Id Persona Fisica</th>\r\n        <th>Nombre</th>\r\n        <th>Apellido Paterno</th>\r\n        <th>Apellido Materno</th>\r\n        <th>RFC</th>\r\n        <th>Fecha de Nacimiento</th>\r\n        <th></th></tr>");
#nullable restore
#line 37 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
     if (oResponse != null && oResponse.Data != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
         foreach (var oElement in oResponse.Data)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 42 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                     oElement.IdPersonaFisica

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 43 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                     oElement.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 44 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                     oElement.ApellidoPaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 45 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                     oElement.ApellidoMaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 46 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                     oElement.RFC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 47 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                     oElement.FechaNacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "class", "btn btn-info");
            __builder.AddAttribute(27, "href", "/agregar/" + (
#nullable restore
#line 49 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                                                            oElement.IdPersonaFisica

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "btn btn-danger");
            __builder.AddAttribute(32, "href", "/eliminar/" + (
#nullable restore
#line 50 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                                                               oElement.IdPersonaFisica

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n\r\n");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-info");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
                                       ExportarExcel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Exportar a Excel");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Alejandro H\source\repos\BlazorCrud\BlazorCrud\Pages\Personas.razor"
       
    public string Url = "api/Personas";
    public Data.Respuesta<List<Data.Personas>> oResponse = new Data.Respuesta<List<Data.Personas>>();


    protected override async Task OnInitializedAsync() =>
        oResponse = await Http.GetFromJsonAsync<Data.Respuesta<List<Data.Personas>>>(Url);


    private void ExportarExcel()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using (var package = new ExcelPackage())
        {
            try
            {
                var worksheet = package.Workbook.Worksheets.Add("PersonasFisicas");
                var tableBody = worksheet.Cells["A1:A1"].LoadFromCollection(
                    from f in oResponse.Data
                    select new { f.IdPersonaFisica, f.Nombre, f.ApellidoPaterno, f.ApellidoMaterno, f.RFC}, true);

                var header = worksheet.Cells["A1:B1"];
                worksheet.DefaultColWidth = 25;
                tableBody.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                tableBody.Style.Fill.PatternType = ExcelFillStyle.Solid;
                tableBody.Style.Fill.BackgroundColor.SetColor(Color.WhiteSmoke);
                tableBody.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                header.Style.Font.Bold = true;
                header.Style.Font.Color.SetColor(Color.White);


                var arr = package.GetAsByteArray();
                JS.GuardarComo("persona.xlsx", package.GetAsByteArray());

            }catch(Exception ex)
            {
               oResponse.Mensaje =  ex.Message;
            }


        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
