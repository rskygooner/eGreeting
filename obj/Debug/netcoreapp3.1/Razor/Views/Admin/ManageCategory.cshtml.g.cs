<<<<<<< HEAD
#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bef58c43c5d21c7c0f1724f1c09748e1b25ca6"
=======
#pragma checksum "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f45db281f485fb9acffcd853f12ab9f54ba4cb"
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageCategory), @"mvc.1.0.view", @"/Views/Admin/ManageCategory.cshtml")]
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bef58c43c5d21c7c0f1724f1c09748e1b25ca6", @"/Views/Admin/ManageCategory.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f45db281f485fb9acffcd853f12ab9f54ba4cb", @"/Views/Admin/ManageCategory.cshtml")]
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb72740cbf7746d379f3076cf0c087747c26d371", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eGreeting.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
            WriteLiteral("<h2>Manage Category</h2>\r\n");
#nullable restore
#line 3 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
  
    ViewBag.Title = "Manage Card";
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 8 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
=======
            WriteLiteral("<h2>Manage Category</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 5 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a
Write(Html.ActionLink("Create New Category", "CreateCategory", "Admin", new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>No.</th>\r\n        <th>CategoryId</th>\r\n        <th>CategoryName</th>\r\n        <th>IsActive</th>\r\n        <th>Action</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
=======
            WriteLiteral(@"
</p>

<table class=""table"">
    <tr>

        <th>

            CategoryId
        </th>
        <th>

            CategoryName
        </th>
        <th>

            IsActive
        </th>
        <th>
            Action
        </th>
    </tr>

");
#nullable restore
#line 28 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 23 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n        ");
#nullable restore
#line 25 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
=======
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 32 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a
   Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
<<<<<<< HEAD
#line 28 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
=======
#line 35 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a
   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
<<<<<<< HEAD
#line 31 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
=======
#line 38 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a
   Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        <a class=\"btn btn-warning\"");
<<<<<<< HEAD
            BeginWriteAttribute("href", " href=\"", 682, "\"", 725, 2);
            WriteAttributeValue("", 689, "/Admin/EditCategory/", 689, 20, true);
#nullable restore
#line 34 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
WriteAttributeValue("", 709, item.CategoryId, 709, 16, false);
=======
            BeginWriteAttribute("href", " href=\"", 690, "\"", 729, 2);
            WriteAttributeValue("", 697, "/Admin/EditCard/", 697, 16, true);
#nullable restore
#line 41 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
WriteAttributeValue("", 713, item.CategoryId, 713, 16, false);
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-edit\"></i></a>\r\n        <a");
<<<<<<< HEAD
            BeginWriteAttribute("onClick", " onClick=\"", 770, "\"", 806, 3);
            WriteAttributeValue("", 780, "doDelete(", 780, 9, true);
#nullable restore
#line 35 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
WriteAttributeValue("", 789, item.CategoryId, 789, 16, false);
=======
            BeginWriteAttribute("onClick", " onClick=\"", 774, "\"", 810, 3);
            WriteAttributeValue("", 784, "doDelete(", 784, 9, true);
#nullable restore
#line 42 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
WriteAttributeValue("", 793, item.CategoryId, 793, 16, false);
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteAttributeValue("", 805, ")", 805, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-circle\">\r\n            <i style=\"color: #fff\" class=\"fas fa-trash\"></i>\r\n        </a>\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 40 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
    i++;
=======
            WriteAttributeValue("", 809, ")", 809, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-circle\">\r\n            <i style=\"color: #fff\" class=\"fas fa-trash\"></i>\r\n        </a>\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 47 "D:\.Net\.NetCore\eGreeting\Views\Admin\ManageCategory.cshtml"
>>>>>>> aa3b5888926c32b9d3f36a6df5c5409f5c7c719a
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</table>

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
                    url: ""/Admin/DeleteCategory"",
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
            WriteLiteral(@"                          });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eGreeting.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
