#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d6a83e45573c57bf136d91a99c583afb62158c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditUser), @"mvc.1.0.view", @"/Views/Admin/EditUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6a83e45573c57bf136d91a99c583afb62158c0", @"/Views/Admin/EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb72740cbf7746d379f3076cf0c087747c26d371", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eGreeting.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
  
    ViewBag.Title = "EditUser";
    Layout = "~/Views/Shared/_AdminLayoutPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>EditUser</h2>\n\n");
#nullable restore
#line 10 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n    <hr />\n    ");
#nullable restore
#line 16 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 17 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
Write(Html.HiddenFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 20 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 22 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control", @readonly = true } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 23 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 28 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 30 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.PasswordFor(model => model.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 31 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 36 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.RePassword, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 38 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.PasswordFor(model => model.RePassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 39 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.RePassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        <h5 style=\"color:#4cbc1f\">Note: Leave the Password field blank if you don\'t want to change the password!</h5>\n    </div>\n\n");
#nullable restore
#line 47 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
     if (Model.UserName != "admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\n            ");
#nullable restore
#line 50 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.LabelFor(model => model.Role, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                <div class=\"checkbox\">\n                    ");
#nullable restore
#line 53 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
               Write(Html.EditorFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p style=\"display:inline-block; color: red\">Admin</p>\n                    ");
#nullable restore
#line 54 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
               Write(Html.ValidationMessageFor(model => model.Role, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 58 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 60 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.IsVIP, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            <div class=\"checkbox\">\n                ");
#nullable restore
#line 63 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
           Write(Html.EditorFor(model => model.IsVIP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 64 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
           Write(Html.ValidationMessageFor(model => model.IsVIP, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 70 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.IsDeactive, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            <div class=\"checkbox\">\n                ");
#nullable restore
#line 73 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
           Write(Html.EditorFor(model => model.IsDeactive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 74 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
           Write(Html.ValidationMessageFor(model => model.IsSubcribeSend, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 81 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.IsSubcribeSend, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            <div class=\"checkbox\">\n                ");
#nullable restore
#line 84 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
           Write(Html.EditorFor(model => model.IsSubcribeSend));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 85 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
           Write(Html.ValidationMessageFor(model => model.IsSubcribeSend, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 91 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.IsSubcribeReceive, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            <div class=\"checkbox\">\n                ");
#nullable restore
#line 94 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
           Write(Html.EditorFor(model => model.IsSubcribeReceive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 95 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
           Write(Html.ValidationMessageFor(model => model.IsSubcribeReceive, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 101 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.FullName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 103 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.EditorFor(model => model.FullName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 104 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.FullName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 109 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.Gender, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""col-md-10"">
            <div class=""col-md-10"">
                <label><input type=""radio"" name=""Gender"" value=""true"" checked=""checked"">Male</label><br />
                <label><input type=""radio"" name=""Gender"" value=""false"">Female</label>
                ");
#nullable restore
#line 114 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
           Write(Html.ValidationMessageFor(model => model.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 120 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 122 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 123 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 128 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
   Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 130 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 131 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            ");
#nullable restore
#line 137 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
       Write(Html.ActionLink("Back to List", "ManageUser", null, new { @class = "btn btn-default", @style = "float:left" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" style=\"float:right\" />\n        </div>\n    </div>\n</div>\n");
#nullable restore
#line 142 "D:\.Net\.NetCore\eGreeting\Views\Admin\EditUser.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eGreeting.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
