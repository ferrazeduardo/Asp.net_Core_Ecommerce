#pragma checksum "/home/eduardo/Documentos/projetos/Ecommerce/Views/Shared/Components/CarrinhoResumo/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a44e6c6c15be79628d5490047c14043523d8868b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CarrinhoResumo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CarrinhoResumo/Default.cshtml")]
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
#line 1 "/home/eduardo/Documentos/projetos/Ecommerce/Views/_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/eduardo/Documentos/projetos/Ecommerce/Views/_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/eduardo/Documentos/projetos/Ecommerce/Views/_ViewImports.cshtml"
using Ecommerce.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a44e6c6c15be79628d5490047c14043523d8868b", @"/Views/Shared/Components/CarrinhoResumo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ffcd4346edeb7da922d6d5bfd1457affbfa7c3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CarrinhoResumo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/eduardo/Documentos/projetos/Ecommerce/Views/Shared/Components/CarrinhoResumo/Default.cshtml"
 if(Model.Carrinho.GetProdutosCarrinho().Count>=1){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span> <img src=\"https://img.icons8.com/office/30/000000/buy.png\"> </span>\n    <span class=\"cart-status\">\n        ");
#nullable restore
#line 6 "/home/eduardo/Documentos/projetos/Ecommerce/Views/Shared/Components/CarrinhoResumo/Default.cshtml"
   Write(Model.Carrinho.GetProdutosCarrinho().Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </span>\n");
#nullable restore
#line 8 "/home/eduardo/Documentos/projetos/Ecommerce/Views/Shared/Components/CarrinhoResumo/Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591