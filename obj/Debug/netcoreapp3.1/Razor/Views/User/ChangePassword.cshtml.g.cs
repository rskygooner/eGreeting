#pragma checksum "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f475fdf8f205df4fcfc8fe78c34328ba2534149c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ChangePassword), @"mvc.1.0.view", @"/Views/User/ChangePassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f475fdf8f205df4fcfc8fe78c34328ba2534149c", @"/Views/User/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9c54a3ec50c7518cdd1d1c7119f4a974300b0f", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eGreeting.Models.ChangePassword>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
  
    ViewBag.Title = "ChangePassword";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>ChangePassword</h2>\n\n");
#nullable restore
#line 10 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n    <hr />\n    ");
#nullable restore
#line 16 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 17 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
Write(Html.HiddenFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 20 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
   Write(Html.LabelFor(model => model.OldPassword, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 22 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
       Write(Html.EditorFor(model => model.OldPassword, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 23 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
       Write(Html.ValidationMessageFor(model => model.OldPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 28 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
   Write(Html.LabelFor(model => model.NewPassword, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 30 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
       Write(Html.EditorFor(model => model.NewPassword, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 31 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
       Write(Html.ValidationMessageFor(model => model.NewPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 36 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
   Write(Html.LabelFor(model => model.ConfirmNewPassword, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 38 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
       Write(Html.EditorFor(model => model.ConfirmNewPassword, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 39 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
       Write(Html.ValidationMessageFor(model => model.ConfirmNewPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            ");
#nullable restore
#line 45 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
       Write(Html.ActionLink("Cancel", "Index", "User", null, new { @class = "btn btn-warning", @style = "float:left" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <input type=""submit"" value=""Save"" class=""btn btn-success"" />
            <input type=""reset"" value=""Reset"" class=""btn btn-default"">
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
        </div>
    </div>
</div>
");
#nullable restore
#line 55 "/Users/inmac/Projects/eGreeting/eGreeting/Views/User/ChangePassword.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eGreeting.Models.ChangePassword> Html { get; private set; }
    }
}
#pragma warning restore 1591
