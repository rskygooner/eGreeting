#pragma checksum "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f0173d11ce321555d857aeb9e2d55f7508a1efb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageFeedback), @"mvc.1.0.view", @"/Views/Admin/ManageFeedback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f0173d11ce321555d857aeb9e2d55f7508a1efb", @"/Views/Admin/ManageFeedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9c54a3ec50c7518cdd1d1c7119f4a974300b0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eGreeting.Models.Feedback>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml"
  
    ViewBag.Title = "ManageFeedback";
    Layout = "~/Views/Shared/_AdminLayoutPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card shadow mb-4"">
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Username</th>
                        <th>Subject</th>
                        <th>Content</th>
                        <th>DataCreated</th>
                        <th>Function</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 24 "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 27 "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml"
                           Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 28 "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml"
                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td id=\"Content\">");
#nullable restore
#line 29 "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml"
                                        Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 30 "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml"
                           Write(item.DataCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n\n                                <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1088, "\"", 1133, 2);
            WriteAttributeValue("", 1095, "/Admin/DetailFeedback/", 1095, 22, true);
#nullable restore
#line 33 "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml"
WriteAttributeValue("", 1117, item.FeedbackId, 1117, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i style=\"color: #fff\" class=\"fas fa-info\"></i></a>\n                                <a");
            BeginWriteAttribute("onClick", " onClick=\"", 1221, "\"", 1257, 3);
            WriteAttributeValue("", 1231, "doDelete(", 1231, 9, true);
#nullable restore
#line 34 "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml"
WriteAttributeValue("", 1240, item.FeedbackId, 1240, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1256, ")", 1256, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" class=\"btn btn-danger btn-circle\">\n                                    <i style=\"color: #fff\" class=\"fas fa-trash\"></i>\n                                </a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 39 "/Users/inmac/Projects/eGreeting/eGreeting/Views/Admin/ManageFeedback.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>



<script>
    $(document).ready(function () {

        grid_func.init(1);
    });
    var grid_func = {
        init: function (page) {
            var list = this.getData(page);
            $(""#gridContainer"").dxDataGrid({
                dataSource: list,
                keyExpr: ""Id"",
                selection: {
                    mode: ""single""
                },
                editing: {
                    mode: ""row"",
                    allowUpdating: true, //
                    allowDeleting: true, //
                    allowAdding: true //
                },
                hoverStateEnabled: true,
                showBorders: true,
                columns: [{
                    caption: ""No."",
                    dataField: ""myIndex"",
                    width: 80
                }, {
                    dataField: ""Username"",
                    caption: 'Username',
                    width: 120,
              ");
            WriteLiteral(@"  },
                {
                    dataField: ""Subject"",
                    caption: 'Subject',
                    width: 150,
                },
                {
                    dataField: ""Content"",
                    caption: 'Content'
                },
                {
                    dataField: ""DataCreated"",
                    caption: 'DataCreated',
                    width: 100
                }],
                onRowInserted: function (e) {
                    console.log(e);
                    $.ajax({
                        url: '/Admin/InsertFeedback',
                        type: ""POST"",
                        data: { model: e.key }, // model giong ben controller
                        async: false,
                        success: function (res) {
                            if (res) {
                                grid_func.init(page);
                            }
                        }
                    })
                },
                onRowUpdated: f");
            WriteLiteral(@"unction (e) {
                    console.log(e);
                    $.ajax({
                        url: '/Admin/UpdateFeedback',
                        type: ""POST"",
                        data: { model: e.data },
                        async: false,
                        success: function (res) {
                            if (res) {
                                grid_func.init(page);
                            }
                        }
                    })
                },
                onRowRemoved: function (e) {
                    console.log(e);
                    $.ajax({
                        url: '/Admin/DeleteFeedbackv2',
                        type: ""POST"",
                        data: { id: e.key },
                        async: false,
                        success: function (res) {
                            if (!res) {
                                grid_func.init(page);
                            }
                        }
                    })
               ");
            WriteLiteral(@" }
            });
        },
        getData: function (page) {
            var list = [];
            $.ajax({
                url: '/Admin/getManagerFeedback',
                type: ""POST"",
                data: { page: page },
                async: false,
                success: function (res) {
                    console.log(res);
                    if (res != null && res != """") {
                        var respone = JSON.parse(res);
                        if (respone.success) {
                            list = respone.data;
                            $(""#my-pagination"").pagination({
                                items: list.length > 0 ? list[0].total : 0,
                                itemsOnPage: 2,
                                currentPage: page,
                                cssStyle: 'light-theme',
                                onPageClick: function (page, e) {
                                    grid_func.init(page);
                                }
                            }");
            WriteLiteral(@");
                        }
                    }
                }
            });
            return list;
        }
    }


    // delete
    // idData là biến truyền vào (đặt tên là gì cũng được)
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
                    url: ""/Admin/DeleteFeedback"", // Yêu cầu lấy dữ liệu: /controller/tên hàm
                    type: ""POST"",
                    data: { id: id }, // id phải giống id truyền vào trong TinTucController Delete
                    success: function (res) {
                        // success là hàm được gọi khi yêu cầu thành công
                        // res là giá trị trả về đặt t");
            WriteLiteral(@"ên là gì cũng được()
                        if (res) {
                            Swal.fire({
                                title: 'Delete success',
                                text: 'Successfully deleted!',
                                type: 'success'
                            }).then((res2) => {
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

    var lengthContent = $('#Content').text().length;
    if (length");
            WriteLiteral("Content > 50) {\n        var newStr = $(\'#Content\').text().substring(0, 50);\n        document.getElementById(\"Content\").innerText = newStr + \"...\";\n        $(\'br\').remove();\n    }\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eGreeting.Models.Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591
