#pragma checksum "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\NewStore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6183bca2c1c0afb9addc9957b94c0207470699f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stores_NewStore), @"mvc.1.0.view", @"/Views/Stores/NewStore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6183bca2c1c0afb9addc9957b94c0207470699f3", @"/Views/Stores/NewStore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0a83b8b5988f3038230479476a297be027ee35", @"/Views/_ViewImports.cshtml")]
    public class Views_Stores_NewStore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelsDefault.Store>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\NewStore.cshtml"
  
    ViewData["Title"] = "NewStore";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>New Store Has Been Opened!</h1>\r\n\r\n<div>\r\n    <h4>Store</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Store Name:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\NewStore.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Store Location\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\NewStore.cshtml"
       Write(Html.DisplayFor(model => model.location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>       \r\n        <dt class=\"col-sm-2\">\r\n            Store ID:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Stores\NewStore.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <div>\r\n        <a src=\"https://localhost:44340/\" href=\"https://localhost:44340/\">Relogin</a>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelsDefault.Store> Html { get; private set; }
    }
}
#pragma warning restore 1591
