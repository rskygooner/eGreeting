#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\User\DescriptionPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0163a3e147fd59e75506ab8fe13f194affc7848b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DescriptionPayment), @"mvc.1.0.view", @"/Views/User/DescriptionPayment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0163a3e147fd59e75506ab8fe13f194affc7848b", @"/Views/User/DescriptionPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb72740cbf7746d379f3076cf0c087747c26d371", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DescriptionPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\.Net\.NetCore\eGreeting\Views\User\DescriptionPayment.cshtml"
  
    ViewBag.Title = "Description Payment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Description Payment</h2>

<table>
    <tr>
        <td>
            <h4>Our motto is make the most convenient for customers, so you only need to subscribe once (pay once), you can comfortably free to send all kind of greeting cards like birthday, new year, festival for a month. Subscribtion for experience our service!</h4>
        </td>
    </tr>
    <tr>
        <td>
            ");
#nullable restore
#line 17 "D:\.Net\.NetCore\eGreeting\Views\User\DescriptionPayment.cshtml"
       Write(Html.ActionLink("Cancel", "Index", "Home", null, new { @class = "btn btn-warning", @style = "float:left" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <a onClick=""doPayment()"" class=""btn btn-primary btn-circle"">
                <i style=""color: #fff"" class=""fa fa-money"">Payment</i>
            </a>
        </td>
    </tr>
</table>


<script>
    function doPayment() {
        Swal.fire({
            title: 'Confirm',
            text: ""By click OK, you'll accept to pay $10 per month. Are you sure?"",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            confirmButtonText: 'Yes, pay it!',
            cancelButtonColor: '#d33'
        }).then((result) => {
            if (result.value) {
                window.location.href = ""/User/Payment"";
            }
        })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
