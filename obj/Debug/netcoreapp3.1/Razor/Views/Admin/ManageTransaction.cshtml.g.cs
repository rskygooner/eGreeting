#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c357389f5b91066fd5d440fb0f5d01ebf2647738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageTransaction), @"mvc.1.0.view", @"/Views/Admin/ManageTransaction.cshtml")]
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
#nullable restore
#line 1 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c357389f5b91066fd5d440fb0f5d01ebf2647738", @"/Views/Admin/ManageTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb72740cbf7746d379f3076cf0c087747c26d371", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
  
    ViewBag.Title = "ManageTrans";
    Layout = "~/Views/Shared/_AdminLayoutPage.cshtml";
    var pageList = (IPagedList)ViewBag.page;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Manage Transaction</h2>

<table class=""table"">
    <tr>
        <th>Sender (Username)</th>
        <th>Receiver</th>
        <th>Subject</th>
        <th>Content</th>
        <th>Name Card</th>
        <th>Image</th>
        <th>TimeSend</th>
        <th>Action</th>
    </tr>
");
#nullable restore
#line 22 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
     foreach (var item in ViewBag.page)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
           Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
           Write(item.Receiver);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td id=\"Content\">");
#nullable restore
#line 28 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
                        Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
           Write(item.CardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c357389f5b91066fd5d440fb0f5d01ebf26477385792", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 774, "~/ImageCard/", 774, 12, true);
#nullable restore
#line 30 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
AddHtmlAttributeValue("", 786, item.TransImage, 786, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
AddHtmlAttributeValue("", 809, item.TransImage, 809, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
           Write(item.TimeSend);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 20%\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 947, "\"", 1022, 1);
#nullable restore
#line 33 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
WriteAttributeValue("", 954, Url.Action("DetailTransaction", "Admin", new { id = item.TransId }), 954, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\r\n                    <i class=\"fas fa-info\"></i>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1139, "\"", 1172, 3);
            WriteAttributeValue("", 1149, "DoDelete(", 1149, 9, true);
#nullable restore
#line 36 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
WriteAttributeValue("", 1158, item.TransId, 1158, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1171, ")", 1171, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fas fa-trash\"></i></a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div>\r\n    ");
#nullable restore
#line 42 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageTransaction.cshtml"
Write(Html.PagedListPager(pageList, page => Url.Action("ManageFeedback", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<script>
    var lengthContent = $('#Content').text().length;
    if (lengthContent > 50) {
        var newStr = $('#Content').text().substring(0, 50);
        document.getElementById(""Content"").innerText = newStr + ""..."";
        $('br').remove();
    }

    function DoDelete(id) {
        Swal.fire({
            title: 'Are you sure?',
            text: ""You won't be able to revert this!"",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            confirmButtonText: 'Yes, delete it!',
            cancelButtonColor: '#d33'
        }).then((result) => {
            if (result.value) {
                $.ajax({
                    url: ""/Admin/DeleteTrans"",
                    type: ""POST"",
                    data: { id: id },
                    success: function (res) {
                        if (res) {
                            location.reload();
                        }
                    }
             ");
            WriteLiteral("   })\r\n                Swal.fire(\r\n                    \'Deleted!\',\r\n                    \'Your file has been deleted!\',\r\n                    \'success\'\r\n                )\r\n            }\r\n        })\r\n    }\r\n</script>");
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
