#pragma checksum "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\Shared\Components\BlogLastThreePost\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86496787ee2f7ce19551804b2c3f2759047ee6dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLastThreePost_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLastThreePost/Default.cshtml")]
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
#line 1 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\_ViewImports.cshtml"
using Core_Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\_ViewImports.cshtml"
using Core_Demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86496787ee2f7ce19551804b2c3f2759047ee6dc", @"/Views/Shared/Components/BlogLastThreePost/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e76275c1eafa0dfe2525e25af72be9df534ce8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLastThreePost_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"blog-grids row mb-3\">\r\n");
#nullable restore
#line 4 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 164, "\"", 201, 2);
            WriteAttributeValue("", 171, "/Blog/BlogReadAll/", 171, 18, true);
#nullable restore
#line 7 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
WriteAttributeValue("", 189, item.BlogId, 189, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 213, "\"", 234, 1);
#nullable restore
#line 8 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
WriteAttributeValue("", 219, item.BlogImage, 219, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 266, "\"", 272, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t</a>\r\n\t\t</div>\r\n");
            WriteLiteral("\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t<h5>\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 360, "\"", 397, 2);
            WriteAttributeValue("", 367, "/Blog/BlogReadAll/", 367, 18, true);
#nullable restore
#line 17 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
WriteAttributeValue("", 385, item.BlogId, 385, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
                                                    Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </a>\r\n\t\t\t</h5>\r\n\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t<span>\r\n\t\t\t\t\t<i class=\"far fa-clock\"></i>");
#nullable restore
#line 21 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"
                                            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</span>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 25 "C:\Users\user\source\repos\Core_Demo\Core_Demo\Views\Shared\Components\BlogLastThreePost\Default.cshtml"


	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
