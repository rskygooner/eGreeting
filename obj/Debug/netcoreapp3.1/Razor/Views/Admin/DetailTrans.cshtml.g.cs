#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "800b4301f503a47b370aba97ee7a058b44babaa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DetailTrans), @"mvc.1.0.view", @"/Views/Admin/DetailTrans.cshtml")]
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
#line 1 "D:\.Net\.NetCore\eGreeting\Views\_ViewImports.cshtml"
using eGreeting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\.NetCore\eGreeting\Views\_ViewImports.cshtml"
using eGreeting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"800b4301f503a47b370aba97ee7a058b44babaa4", @"/Views/Admin/DetailTrans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb72740cbf7746d379f3076cf0c087747c26d371", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DetailTrans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eGreeting.Models.Transaction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Cinque Terre"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
  
    ViewBag.Title = "DetailTrans";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Detail Transaction</h2>\n\n<div>\n\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
#nullable restore
#line 13 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 17 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 21 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayNameFor(model => model.Receiver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 25 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayFor(model => model.Receiver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 29 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 33 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 37 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 41 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 45 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayNameFor(model => model.NameCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 49 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayFor(model => model.NameCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 53 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageNameTrans));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "800b4301f503a47b370aba97ee7a058b44babaa47428", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1108, "~/ImageCard/", 1108, 12, true);
#nullable restore
#line 57 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
AddHtmlAttributeValue("", 1120, Model.ImageNameTrans, 1120, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 61 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeSend));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 65 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
       Write(Html.DisplayFor(model => model.TimeSend));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n    </dl>\n</div>\n<div class=\"form-group \">\n    <div class=\"col-md-offset-2 col-md-10\">\n        ");
#nullable restore
#line 72 "D:\.Net\.NetCore\eGreeting\Views\Admin\DetailTrans.cshtml"
   Write(Html.ActionLink("Back", "ManageTrans", "Admin", null, new { @class = "btn btn-warning", @style = "float:left" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eGreeting.Models.Transaction> Html { get; private set; }
    }
}
#pragma warning restore 1591
