#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e0d2120c780597711159347ddc98be408c3dd72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Payment), @"mvc.1.0.view", @"/Views/User/Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e0d2120c780597711159347ddc98be408c3dd72", @"/Views/User/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb72740cbf7746d379f3076cf0c087747c26d371", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eGreeting.Models.PaymentInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
  
    ViewBag.Title = "Payment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Payment Info</h2>\n\n");
#nullable restore
#line 10 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n    <hr />\n    ");
#nullable restore
#line 16 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 17 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
Write(Html.HiddenFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 18 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
Write(Html.HiddenFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 21 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
   Write(Html.LabelFor(model => model.BankName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 23 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
       Write(Html.EditorFor(model => model.BankName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 24 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
       Write(Html.ValidationMessageFor(model => model.BankName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 29 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
   Write(Html.LabelFor(model => model.BankAccount, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 31 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
       Write(Html.EditorFor(model => model.BankAccount, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 32 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
       Write(Html.ValidationMessageFor(model => model.BankAccount, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 37 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
   Write(Html.LabelFor(model => model.DateExpire, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 39 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
       Write(Html.EditorFor(model => model.DateExpire, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 40 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
       Write(Html.ValidationMessageFor(model => model.DateExpire, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            ");
#nullable restore
#line 46 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
       Write(Html.ActionLink("Cancel", "Index", "Home", null, new { @class = "btn btn-warning", @style = "float:left" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <input type=\"submit\" name=\"name\" value=\"Submit\" class=\"btn btn-primary\" />\n        </div>\n    </div>\n</div>\n");
#nullable restore
#line 51 "D:\.Net\.NetCore\eGreeting\Views\User\Payment.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eGreeting.Models.PaymentInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591