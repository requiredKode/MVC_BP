#pragma checksum "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e170e70b622da456bbc522126ca507ce46cea004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\_ViewImports.cshtml"
using PruebaMVC_BP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\_ViewImports.cshtml"
using PruebaMVC_BP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
using ORM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
using ORM.SP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
using ORM.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e170e70b622da456bbc522126ca507ce46cea004", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e115b430f817359763df602c965cc2f47a499038", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Lista de Art??culos Activos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
function printpage() {

        var printButton = document.getElementById(""printpagebutton"");

        printButton.style.visibility = 'hidden';

        window.print()
        printButton.style.visibility = 'visible';
    }
</script>


<h1>");
#nullable restore
#line 20 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<input id=""printpagebutton"" value=""Imprimir Listado"" type=""button"" class=""btn btn-primary mb-3 float-right"" onclick=""printpage()""/>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th scope=""col"">C??digo Art??culo</th>
            <th scope=""col"">Nombre Art??culo</th>
            <th scope=""col"">Costo</th>
            <th scope=""col"">C??digo Proveedor</th>
            <th scope=""col"">Nombre Proveedor</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
         foreach (sp_lista_articulos_activos _arti in ViewBag.ListaCombinada)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td scope=\"row\">");
#nullable restore
#line 36 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
                       Write(_arti.cod_articulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
           Write(_arti.nombreA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
           Write(_arti.costo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
           Write(_arti.cod_proveedor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
           Write(_arti.nombreP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\001S\Desktop\PruebaMVC_BP\PruebaMVC_BP\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
