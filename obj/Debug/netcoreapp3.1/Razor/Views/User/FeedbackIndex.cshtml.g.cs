#pragma checksum "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c621e6b63931030be5d3360e6308ba70195ceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_FeedbackIndex), @"mvc.1.0.view", @"/Views/User/FeedbackIndex.cshtml")]
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
#line 1 "/Users/inmac/Projects/eGreeting/eGreeting/Views/_ViewImports.cshtml"
using eGreeting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/inmac/Projects/eGreeting/eGreeting/Views/_ViewImports.cshtml"
using eGreeting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c621e6b63931030be5d3360e6308ba70195ceb", @"/Views/User/FeedbackIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9c54a3ec50c7518cdd1d1c7119f4a974300b0f", @"/Views/_ViewImports.cshtml")]
    public class Views_User_FeedbackIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eGreeting.Models.Feedback>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
  
    ViewBag.Title = "FeedbackIndex";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>Feedback</h4>\n        <hr />\n        ");
#nullable restore
#line 15 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 16 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
   Write(Html.HiddenFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 18 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
       Write(Html.LabelFor(model => model.Subject, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 20 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
           Write(Html.EditorFor(model => model.Subject, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 21 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
           Write(Html.ValidationMessageFor(model => model.Subject, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 26 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
       Write(Html.LabelFor(model => model.Content, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 28 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
           Write(Html.TextAreaFor(model => model.Content, new { @class = "form-control", @rows = "10" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 29 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
           Write(Html.ValidationMessageFor(model => model.Content, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                ");
#nullable restore
#line 35 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
           Write(Html.ActionLink("Cancel", "Index", "Home", null, new { @class = "btn btn-warning", @style = "float:left" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <input type=\"submit\" value=\"Send\" class=\"btn btn-primary\" />\n                <input type=\"reset\" value=\"Clear\" class=\"btn btn-default\" />\n            </div>\n        </div>       \n    </div>\n");
#nullable restore
#line 41 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/FeedbackIndex.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eGreeting.Models.Feedback> Html { get; private set; }
    }
}
#pragma warning restore 1591
