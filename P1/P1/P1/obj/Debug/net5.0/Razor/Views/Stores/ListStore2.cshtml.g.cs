#pragma checksum "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\ListStore2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8890d42eb8137bc81b44e18dd2af107ff09e215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stores_ListStore2), @"mvc.1.0.view", @"/Views/Stores/ListStore2.cshtml")]
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
#line 1 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\_ViewImports.cshtml"
using P1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\_ViewImports.cshtml"
using P1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8890d42eb8137bc81b44e18dd2af107ff09e215", @"/Views/Stores/ListStore2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0a83b8b5988f3038230479476a297be027ee35", @"/Views/_ViewImports.cshtml")]
    public class Views_Stores_ListStore2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ModelsDefault.Store>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\ListStore2.cshtml"
  
    ViewData["Title"] = "ListStore2";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Stores</h1>

<table class=""table"">
    <thead style=""background-color:#E6D8C6"">
        <tr>
            <th>
                Store Name
            </th>
            <th>
                Location
            </th>
            <th>
                Store ID
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\ListStore2.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\ListStore2.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\ListStore2.cshtml"
               Write(Html.DisplayFor(modelItem => item.location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\ListStore2.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\ListStore2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    <button class=\"btn-light\"><a href=\"javascript:void(0);\" onclick=\"history.go(-1);\">Back</a></button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ModelsDefault.Store>> Html { get; private set; }
    }
}
#pragma warning restore 1591
