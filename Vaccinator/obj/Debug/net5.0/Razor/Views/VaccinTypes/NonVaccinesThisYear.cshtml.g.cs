#pragma checksum "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56fe3570524296b4d8aaf72a1264c970a7904b5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VaccinTypes_NonVaccinesThisYear), @"mvc.1.0.view", @"/Views/VaccinTypes/NonVaccinesThisYear.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56fe3570524296b4d8aaf72a1264c970a7904b5e", @"/Views/VaccinTypes/NonVaccinesThisYear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5165a61010724eae51c5b101de220bda49750591", @"/Views/_ViewImports.cshtml")]
    public class Views_VaccinTypes_NonVaccinesThisYear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vaccinator.Models.Personne>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Non-Vacciné(e)s du ");
#nullable restore
#line 7 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
                  Write(ViewData["NomVaccin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cette année</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
           Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
           Write(Html.DisplayNameFor(model => model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
           Write(Html.DisplayNameFor(model => model.Sexe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
           Write(Html.DisplayNameFor(model => model.Statut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
               Write(Html.DisplayFor(modelItem => item.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sexe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
               Write(Html.DisplayFor(modelItem => item.Statut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Romain\source\repos\Vaccinator\Vaccinator\Views\VaccinTypes\NonVaccinesThisYear.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vaccinator.Models.Personne>> Html { get; private set; }
    }
}
#pragma warning restore 1591
