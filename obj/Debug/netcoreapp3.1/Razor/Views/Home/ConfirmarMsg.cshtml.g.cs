#pragma checksum "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\Home\ConfirmarMsg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ac85c1ed057eff3773e71b2c8422189a032a713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ConfirmarMsg), @"mvc.1.0.view", @"/Views/Home/ConfirmarMsg.cshtml")]
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
#line 1 "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\_ViewImports.cshtml"
using Bmw_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\Home\ConfirmarMsg.cshtml"
using Bmw_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac85c1ed057eff3773e71b2c8422189a032a713", @"/Views/Home/ConfirmarMsg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea0ab962e0efc404b9771a14ed309670879debc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ConfirmarMsg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mensagem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\Home\ConfirmarMsg.cshtml"
  
    ViewData["Title"] = "Formulario";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-mensagem\">\r\n    <p>Olá <strong>");
#nullable restore
#line 8 "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\Home\ConfirmarMsg.cshtml"
              Write(Model.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>!</p>\r\n    <p>\r\n        Obrigado por entrar em contato!\r\n    </p>\r\n    <p>\r\n        Assim que possível responderemos à sua mensagem pelo e-mail <strong>");
#nullable restore
#line 13 "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\Home\ConfirmarMsg.cshtml"
                                                                       Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>.\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\Home\ConfirmarMsg.cshtml"
     if (!string.IsNullOrEmpty(Model.telefone))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            Ou pelo telefone <strong>");
#nullable restore
#line 18 "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\Home\ConfirmarMsg.cshtml"
                                Write(Model.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>.\r\n        </p>\r\n");
#nullable restore
#line 20 "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\Home\ConfirmarMsg.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        BMW entrara em contato em poucos dias!\r\n\r\n    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 571, "\"", 625, 3);
            WriteAttributeValue("", 581, "location.href=\'", 581, 15, true);
#nullable restore
#line 24 "C:\Users\felip\OneDrive\Documentos\Bmw-MVC\Views\Home\ConfirmarMsg.cshtml"
WriteAttributeValue("", 596, Url.Action("Index", "Home"), 596, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 624, "\'", 624, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Voltar</button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mensagem> Html { get; private set; }
    }
}
#pragma warning restore 1591