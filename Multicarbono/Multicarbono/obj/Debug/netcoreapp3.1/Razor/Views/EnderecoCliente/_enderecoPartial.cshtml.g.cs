#pragma checksum "C:\Multicarbono\Multicarbono\Multicarbono\Views\EnderecoCliente\_enderecoPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ff31984ce9da82bfc8b4c8975863948eef3366"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnderecoCliente__enderecoPartial), @"mvc.1.0.view", @"/Views/EnderecoCliente/_enderecoPartial.cshtml")]
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
#line 1 "C:\Multicarbono\Multicarbono\Multicarbono\Views\_ViewImports.cshtml"
using Multicarbono;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Multicarbono\Multicarbono\Multicarbono\Views\_ViewImports.cshtml"
using Multicarbono.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45ff31984ce9da82bfc8b4c8975863948eef3366", @"/Views/EnderecoCliente/_enderecoPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00a755c8db28c4501d2077b3c31da2327a2b2c30", @"/Views/_ViewImports.cshtml")]
    public class Views_EnderecoCliente__enderecoPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Multicarbono\Multicarbono\Multicarbono\Views\EnderecoCliente\_enderecoPartial.cshtml"
  
    Layout = null;
    List<Multicarbono.Models.EnderecoCliente.EnderecoCliente> itemEndereco = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Multicarbono.Models.EnderecoCliente.EnderecoCliente>>(TempData["Endereco"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<h6 style=""margin-left:2%"">Endereços</h6>


<table class=""table table-striped table-hover"" style=""margin-left:1%; margin-right:1%"">
    <thead>
        <tr>
            <th>
                Endereco
            </th>
            <th>
                CEP
            </th>
            <th>
                TipoEndereco
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Multicarbono\Multicarbono\Multicarbono\Views\EnderecoCliente\_enderecoPartial.cshtml"
         foreach (var item in itemEndereco.Select((value, index) => new { value, index }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 30 "C:\Multicarbono\Multicarbono\Multicarbono\Views\EnderecoCliente\_enderecoPartial.cshtml"
           Write(item.value.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Multicarbono\Multicarbono\Multicarbono\Views\EnderecoCliente\_enderecoPartial.cshtml"
           Write(item.value.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Multicarbono\Multicarbono\Multicarbono\Views\EnderecoCliente\_enderecoPartial.cshtml"
           Write(item.value.TipoEndereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 38 "C:\Multicarbono\Multicarbono\Multicarbono\Views\EnderecoCliente\_enderecoPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
