#pragma checksum "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e45c2a0eeac7b4f9ee8fb07591350c0ab491e07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kitap_Index), @"mvc.1.0.view", @"/Views/Kitap/Index.cshtml")]
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
#line 1 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\_ViewImports.cshtml"
using MVC_TEST;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\_ViewImports.cshtml"
using MVC_TEST.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e45c2a0eeac7b4f9ee8fb07591350c0ab491e07", @"/Views/Kitap/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6bfe0e050e7bdc841a85866e9db2e97d9cca653", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Kitap_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
  
    // Layout = null; // ---> Layout kullanılmayacak
    Layout = "_Layout"; //---> Shared>_Layout.cshtml kullanılacak

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 20 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
Write(ViewBag.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    <ul>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
         foreach (var item in ViewBag.Kitap as List<MVC_TEST.Models.KitapModel>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 25 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
               Write(item.KitapAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 26 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 31 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
Write(ViewData["Baslik"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    <ul>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
         foreach (var item in ViewData["Kitap"] as List<MVC_TEST.Models.KitapModel>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 36 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
           Write(item.KitapAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 37 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 42 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
Write(TempData["Baslik"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    <ul>\r\n\r\n");
#nullable restore
#line 45 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
         foreach (var item in TempData["Kitap"] as List<MVC_TEST.Models.KitapModel>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 47 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
               Write(item.KitapAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 48 "C:\Users\kübra selçuk\Documents\GitHub\DersNotllari\MVC_TEST\MVC_TEST\Views\Kitap\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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