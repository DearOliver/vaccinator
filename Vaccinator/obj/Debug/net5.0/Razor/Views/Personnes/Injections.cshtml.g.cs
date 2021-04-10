#pragma checksum "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e85c51bd295edc821dd8008633fee3e20695eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personnes_Injections), @"mvc.1.0.view", @"/Views/Personnes/Injections.cshtml")]
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
#line 1 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\_ViewImports.cshtml"
using Vaccinator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\_ViewImports.cshtml"
using Vaccinator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e85c51bd295edc821dd8008633fee3e20695eb", @"/Views/Personnes/Injections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5165a61010724eae51c5b101de220bda49750591", @"/Views/_ViewImports.cshtml")]
    public class Views_Personnes_Injections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vaccinator.Models.Injection>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Liste des injections du vacciné</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
           Write(Html.DisplayNameFor(model => model.VaccinType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
           Write(Html.DisplayNameFor(model => model.Personne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
           Write(Html.DisplayNameFor(model => model.Marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
           Write(Html.DisplayNameFor(model => model.Reference));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
           Write(Html.DisplayNameFor(model => model.PriseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
           Write(Html.DisplayNameFor(model => model.RappelDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
               Write(Html.DisplayFor(modelItem => item.VaccinType.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
               Write(Html.DisplayFor(modelItem => item.Personne.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 42 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
               Write(Html.DisplayFor(modelItem => item.Personne.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
               Write(Html.DisplayFor(modelItem => item.Marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
               Write(Html.DisplayFor(modelItem => item.Reference));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
               Write(Html.DisplayFor(modelItem => item.PriseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
               Write(Html.DisplayFor(modelItem => item.RappelDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\Personnes\Injections.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vaccinator.Models.Injection>> Html { get; private set; }
    }
}
#pragma warning restore 1591
