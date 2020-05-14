#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a13e1b828eeae5d5155f311ebf81ba6d606ccc9"
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
#line 1 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a13e1b828eeae5d5155f311ebf81ba6d606ccc9", @"/Views/Admin/ManageFeedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb72740cbf7746d379f3076cf0c087747c26d371", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
  
    ViewBag.Title = "ManageFeedback";
    Layout = "~/Views/Shared/_AdminLayoutPage.cshtml";
    var pageList = (IPagedList)ViewBag.page;

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
#line 24 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
                     foreach (var item in ViewBag.page)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 27 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
                           Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td id=\"Content\">");
#nullable restore
#line 29 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
                                        Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
                           Write(item.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n\r\n                                <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1173, "\"", 1218, 2);
            WriteAttributeValue("", 1180, "/Admin/DetailFeedback/", 1180, 22, true);
#nullable restore
#line 33 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
WriteAttributeValue("", 1202, item.FeedbackId, 1202, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i style=\"color: #fff\" class=\"fas fa-info\"></i></a>\r\n                                <a");
            BeginWriteAttribute("onClick", " onClick=\"", 1307, "\"", 1343, 3);
            WriteAttributeValue("", 1317, "doDelete(", 1317, 9, true);
#nullable restore
#line 34 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
WriteAttributeValue("", 1326, item.FeedbackId, 1326, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1342, ")", 1342, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" class=\"btn btn-danger btn-circle\">\r\n                                    <i style=\"color: #fff\" class=\"fas fa-trash\"></i>\r\n                                </a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 39 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 47 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageFeedback.cshtml"
Write(Html.PagedListPager(pageList, page => Url.Action("ManageFeedback", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
                },
                {
               ");
            WriteLiteral(@"     dataField: ""Subject"",
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
                onRowUpdated: function (e)");
            WriteLiteral(@" {
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
                    })");
            WriteLiteral(@"
                }
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
                        ");
            WriteLiteral(@"        }
                            });
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
                        // success là hàm được gọi khi yêu c");
            WriteLiteral(@"ầu thành công
                        // res là giá trị trả về đặt tên là gì cũng được()
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
      ");
            WriteLiteral(@"      }
        })
    }

    var lengthContent = $('#Content').text().length;
    if (lengthContent > 50) {
        var newStr = $('#Content').text().substring(0, 50);
        document.getElementById(""Content"").innerText = newStr + ""..."";
        $('br').remove();
    }
</script>
");
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
