#pragma checksum "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e2d70f588045e96e4dea56e57fc5486d999e4ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Welcome), @"mvc.1.0.view", @"/Views/Login/Welcome.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e2d70f588045e96e4dea56e57fc5486d999e4ec", @"/Views/Login/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0a83b8b5988f3038230479476a297be027ee35", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelsDefault.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 7 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
       Write(Model.fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n\r\n<div>\r\n    <h4>User Info</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            First Name: \r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
       Write(Html.DisplayFor(model => model.fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Last Name:\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
       Write(Html.DisplayFor(model => model.lname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            User ID:\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Recommended Store ID:\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
       Write(Html.DisplayFor(model => model.storeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Authorization Level:\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
       Write(Html.DisplayFor(model => model.auth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n           Total Number Of Orders:\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
       Write(Html.DisplayFor(model => model.totalOrders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n           Total Amout Spent:\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
       Write(Html.DisplayFor(model => model.totalSpent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <button class=\"btn-light\">");
#nullable restore
#line 58 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
                         Write(Html.ActionLink("Check Previous Orders", "PrevOrder", "Menu", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button class=\"btn-light\">");
#nullable restore
#line 59 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
                         Write(Html.ActionLink("Search For Users*", "Search", "Menu", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button class=\"btn-light\">");
#nullable restore
#line 60 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
                         Write(Html.ActionLink("Manage Stores*", "Search", "Stores", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button class=\"btn-light\">");
#nullable restore
#line 61 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
                         Write(Html.ActionLink("Search For Stores", "Search2", "Stores", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button class=\"btn-light\">");
#nullable restore
#line 62 "C:\Users\ALAIN\Documents\Revature\AlainDuplanP0\P1\P1\P1\Views\Login\Welcome.cshtml"
                         Write(Html.ActionLink("Start A New Order", "Search", "Order", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button class=\"btn-light\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e2d70f588045e96e4dea56e57fc5486d999e4ec9154", async() => {
                WriteLiteral("Log Out");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n</div>\r\n\r\n<sub>* Features are locked away to only authorized users.</sub>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelsDefault.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
