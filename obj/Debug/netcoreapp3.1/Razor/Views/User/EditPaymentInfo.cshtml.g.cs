#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d029162c2ca4b9ac759fa3b653fa641731874dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_EditPaymentInfo), @"mvc.1.0.view", @"/Views/User/EditPaymentInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d029162c2ca4b9ac759fa3b653fa641731874dc", @"/Views/User/EditPaymentInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb72740cbf7746d379f3076cf0c087747c26d371", @"/Views/_ViewImports.cshtml")]
    public class Views_User_EditPaymentInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eGreeting.Models.PaymentInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n    <h4>Your Payment Info</h4>\n    <hr />\n    ");
#nullable restore
#line 11 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 12 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
Write(Html.HiddenFor(model => model.PayId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 13 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
Write(Html.HiddenFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 16 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
   Write(Html.LabelFor(model => model.BankName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 18 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
       Write(Html.EditorFor(model => model.BankName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 19 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
       Write(Html.ValidationMessageFor(model => model.BankName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 24 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
   Write(Html.LabelFor(model => model.BankAccount, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 26 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
       Write(Html.EditorFor(model => model.BankAccount, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 27 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
       Write(Html.ValidationMessageFor(model => model.BankAccount, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 32 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
   Write(Html.LabelFor(model => model.DateExpire, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n");
            WriteLiteral("\n            ");
#nullable restore
#line 36 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
       Write(Html.TextBoxFor(model => model.DateExpire, new { @class = "form-control", id= "datepicker" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 37 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
       Write(Html.ValidationMessageFor(model => model.DateExpire, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n\n\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            ");
#nullable restore
#line 45 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
       Write(Html.ActionLink("Back to List", "Index", null, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <input type=\"reset\" value=\"Reset\" class=\"btn btn-primary\">\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" />\n\n        </div>\n    </div>\n</div>\n");
#nullable restore
#line 52 "D:\.Net\.NetCore\eGreeting\Views\User\EditPaymentInfo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n</div>\n<script>\n    //$(document).ready(function () {\n    //    $(\'#datetimepicker1\').datetimepicker();\n    //})\n</script>");
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
