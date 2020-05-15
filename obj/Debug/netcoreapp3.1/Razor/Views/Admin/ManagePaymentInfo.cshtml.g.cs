#pragma checksum "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94087af88a59643893b7a0901f7a122363d9fe31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManagePaymentInfo), @"mvc.1.0.view", @"/Views/Admin/ManagePaymentInfo.cshtml")]
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
#line 1 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/_ViewImports.cshtml"
using eGreeting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/_ViewImports.cshtml"
using eGreeting.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94087af88a59643893b7a0901f7a122363d9fe31", @"/Views/Admin/ManagePaymentInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9c54a3ec50c7518cdd1d1c7119f4a974300b0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManagePaymentInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
  
    ViewBag.Title = "Manage Payment Info";
    Layout = "~/Views/Shared/_AdminLayoutPage.cshtml";
    var pageList = (IPagedList)ViewBag.page;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2>Manage Payment Info</h2>

<table class=""table"">
    <tr>
        <th>Username</th>
        <th>Bank Name</th>
        <th>Bank Account</th>
        <th>Expired Date</th>
        <th>Date Created</th>
        <th>Status</th>
        <th>Action</th>
    </tr>
");
#nullable restore
#line 22 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
     foreach (var item in ViewBag.page)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 25 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
           Write(item.BankName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 27 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
           Write(item.BankAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 28 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
           Write(item.DateExpire);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 29 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
           Write(item.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n");
#nullable restore
#line 31 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                 if (item.DateCreated != null)
                {
                    if (item.DateExpire < DateTime.Now || (item.DateCreated.Value.AddMonths(1)) < DateTime.Now)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span style=\"color: red; font-weight: 900\">Expired</span>\n");
#nullable restore
#line 36 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                    }
                    else
                    {
                        if (item.IsActive)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color: green; font-weight: 900\">Activated</span>\n");
#nullable restore
#line 42 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color: red; font-weight: 900\">Not Activated</span>\n");
#nullable restore
#line 46 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                        }
                    }
                }
                else
                {
                    if (item.IsActive == Status.Active)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span style=\"color: green; font-weight: 900\">Activated</span>\n");
#nullable restore
#line 54 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span style=\"color: red; font-weight: 900\">Not Activated</span>\n");
#nullable restore
#line 58 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n");
#nullable restore
#line 62 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                 if (item.IsActive == Status.Active)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"button\" value=\"Deactivate\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onClick", " onClick=\"", 2061, "\"", 2092, 3);
            WriteAttributeValue("", 2071, "Deactive(", 2071, 9, true);
#nullable restore
#line 64 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
WriteAttributeValue("", 2080, item.PayId, 2080, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2091, ")", 2091, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                    <a");
            BeginWriteAttribute("onClick", " onClick=\"", 2119, "\"", 2150, 3);
            WriteAttributeValue("", 2129, "doDelete(", 2129, 9, true);
#nullable restore
#line 65 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
WriteAttributeValue("", 2138, item.PayId, 2138, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2149, ")", 2149, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" class=\"btn btn-danger btn-circle\">\n                        <i style=\"color: #fff\" class=\"fas fa-trash\"></i>\n                    </a>\n");
#nullable restore
#line 68 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                }
                else
                {
                    if (item.DateCreated != null && (item.DateExpire < DateTime.Now || (item.DateCreated.Value.AddMonths(1)) < DateTime.Now))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"button\" value=\"Activate\" class=\"btn btn-success\"");
            BeginWriteAttribute("onClick", " onClick=\"", 2600, "\"", 2629, 3);
            WriteAttributeValue("", 2610, "active(", 2610, 7, true);
#nullable restore
#line 73 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
WriteAttributeValue("", 2617, item.PayId, 2617, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2628, ")", 2628, 1, true);
            EndWriteAttribute();
            WriteLiteral(" disabled\n                               title=\"This Card was expired !!!\" />\n                        <a");
            BeginWriteAttribute("onClick", " onClick=\"", 2734, "\"", 2765, 3);
            WriteAttributeValue("", 2744, "doDelete(", 2744, 9, true);
#nullable restore
#line 75 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
WriteAttributeValue("", 2753, item.PayId, 2753, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2764, ")", 2764, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" class=\"btn btn-danger btn-circle\">\n                            <i style=\"color: #fff\" class=\"fas fa-trash\"></i>\n                        </a>\n");
#nullable restore
#line 78 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"button\" value=\"Activate\" class=\"btn btn-success\"");
            BeginWriteAttribute("onClick", " onClick=\"", 3071, "\"", 3100, 3);
            WriteAttributeValue("", 3081, "active(", 3081, 7, true);
#nullable restore
#line 81 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
WriteAttributeValue("", 3088, item.PayId, 3088, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3099, ")", 3099, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                        <a");
            BeginWriteAttribute("onClick", " onClick=\"", 3131, "\"", 3162, 3);
            WriteAttributeValue("", 3141, "doDelete(", 3141, 9, true);
#nullable restore
#line 82 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
WriteAttributeValue("", 3150, item.PayId, 3150, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3161, ")", 3161, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" class=\"btn btn-danger btn-circle\">\n                            <i style=\"color: #fff\" class=\"fas fa-trash\"></i>\n                        </a>\n");
#nullable restore
#line 85 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n        </tr>\n");
#nullable restore
#line 89 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<div>\n    ");
#nullable restore
#line 93 "/Users/inmac/Projects/eGreeting_local/eGreeting/Views/Admin/ManagePaymentInfo.cshtml"
Write(Html.PagedListPager(pageList, page => Url.Action("ManagePaymentInfo", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script>
    function active(Id) {
        Swal.fire({
            title: 'Are you sure?',
            text: ""Active for User can use Subcribe services. "",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            confirmButtonText: 'Yes, Active it!',
            cancelButtonColor: '#d33'
        }).then((result) => {
            if (result.value) {
                $.ajax({
                    url: ""/Admin/EditPayment/"",
                    type: ""POST"",
                    data: {
                        Id: Id,
                        IsActive: true,
                    },
                    success: function (res) {
                        if (res) {
                            location.reload();
                        }
                    }
                })
            }
        })
    };

    function Deactive(Id) {
        Swal.fire({
            title: 'Are you sure?',
            text: ""Deactivate User will cannot use Subcribe");
            WriteLiteral(@" services. "",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            confirmButtonText: 'Yes, Deactivate it!',
            cancelButtonColor: '#d33'
        }).then((result) => {
            if (result.value) {
                $.ajax({
                    url: ""/Admin/EditPayment/"",
                    type: ""POST"",
                    data: {
                        Id: Id,
                        IsActive: false,
                    },
                    success: function (res) {
                        if (res) {
                            Swal.fire({
                                title: 'Deactivate success',
                                text: 'Successfully Deactivate!',
                                type: 'success'
                            }).then(() => {
                                location.reload();
                            });
                        }
                        else {
                            Swal.fire");
            WriteLiteral(@"({
                                title: 'Deactivated failed',
                                text: 'An error occurred while Deactivating!',
                                type: 'error'
                            })
                        }
                    }
                })
            }
        })
    }

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
                    url: ""/Admin/DeletePayment"",
                    type: ""POST"",
                    data: { id: id },
                    success: function (res) {
                        if (res) {
                            Swal.fire({
                                title: 'D");
            WriteLiteral(@"elete success',
                                text: 'Successfully deleted!',
                                type: 'success'
                            }).then(() => {
                                location.reload();
                            });
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
                Swal.fire(
                    'Deleted!',
                    'Your file has been deleted!',
                    'success'
                )
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
