#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe989725fe39ce48aa546ec017d1fd6c2ffa2449"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageCard), @"mvc.1.0.view", @"/Views/Admin/ManageCard.cshtml")]
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
#line 1 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe989725fe39ce48aa546ec017d1fd6c2ffa2449", @"/Views/Admin/ManageCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb72740cbf7746d379f3076cf0c087747c26d371", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/ManageCard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
  
    ViewBag.Title = "Manage Card";
    Layout = "~/Views/Shared/_AdminLayoutPage.cshtml";
    var pageList = (IPagedList)ViewBag.page;
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Manage Card</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 13 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
Write(Html.ActionLink("Create New Card", "CreateCard", "Admin", new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe989725fe39ce48aa546ec017d1fd6c2ffa24495265", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"pName\" style=\"font-size:14px\" placeholder=\"Enter Card name\">\r\n    <button type=\"submit\" class=\"btn btn-primary\">Search</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table"">
    <tr>

        <th>

            NameCard
        </th>
        <th>

            Category
        </th>
        <th>

            Image
        </th>
        <th>

            DateCreated
        </th>
        <th>
            Action
        </th>
    </tr>

");
#nullable restore
#line 44 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
     foreach (var item in ViewBag.page)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
           Write(item.CardName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td width=\"20%\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe989725fe39ce48aa546ec017d1fd6c2ffa24498365", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1134, "~/ImageCard/", 1134, 12, true);
#nullable restore
#line 54 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
AddHtmlAttributeValue("", 1146, item.ImageName, 1146, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 54 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
AddHtmlAttributeValue("", 1168, item.ImageName, 1168, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 54 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
AddHtmlAttributeValue("", 1212, item.ImageName, 1212, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
           Write(item.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1384, "\"", 1419, 2);
            WriteAttributeValue("", 1391, "/Admin/EditCard/", 1391, 16, true);
#nullable restore
#line 60 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
WriteAttributeValue("", 1407, item.CardId, 1407, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-edit\"></i></a>\r\n");
            WriteLiteral("                <a");
            BeginWriteAttribute("onClick", " onClick=\"", 1592, "\"", 1624, 3);
            WriteAttributeValue("", 1602, "doDelete(", 1602, 9, true);
#nullable restore
#line 62 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
WriteAttributeValue("", 1611, item.CardId, 1611, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1623, ")", 1623, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-circle\">\r\n                    <i style=\"color: #fff\" class=\"fas fa-trash\"></i>\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 67 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
        i++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<div>\r\n    ");
#nullable restore
#line 72 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCard.cshtml"
Write(Html.PagedListPager(pageList, page => Url.Action("ManageCard", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script>
    function doDelete(id) {
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
                    url: ""/Admin/DeleteCard"",
                    type: ""POST"",
                    data: {
                        id: id,
                    },
                    success: function (res) {
                        if (res) {
                            Swal.fire({
                                title: 'Delete success',
                                text: 'Successfully deleted!',
                                type: 'success'
                            }).then(() => {
                                location.reload();
        ");
            WriteLiteral(@"                    });
                        }
                        else {
                            Swal.fire({
                                title: 'Delete failed',
                                text: 'An error occurred while deleting!',
                                type: 'error'
                            })
                        }
                    }
                })
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
