#pragma checksum "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6949b3859775a608ea8828ea7f6025efe9adbc03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Edit), @"mvc.1.0.view", @"/Views/Employee/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Edit.cshtml", typeof(AspNetCore.Views_Employee_Edit))]
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
#line 1 "C:\Workspace\Source\KLove\KLove\Views\_ViewImports.cshtml"
using KLove;

#line default
#line hidden
#line 2 "C:\Workspace\Source\KLove\KLove\Views\_ViewImports.cshtml"
using KLove.Models;

#line default
#line hidden
#line 4 "C:\Workspace\Source\KLove\KLove\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#line 1 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
using Data.Models;

#line default
#line hidden
#line 2 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
using Microsoft.AspNetCore.Mvc.Internal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6949b3859775a608ea8828ea7f6025efe9adbc03", @"/Views/Employee/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff14865496bf385b00e439aca68823c7e67b5cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
  
	ViewData["Title"] = "Create/Edit";

#line default
#line hidden
            BeginContext(135, 37, true);
            WriteLiteral("\r\n<h2>Create / Edit Employee</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
 using (Html.BeginForm("Save", "Employee", FormMethod.Post))
{
	

#line default
#line hidden
            BeginContext(239, 23, false);
#line 12 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(266, 61, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n\t<hr />\r\n\t<input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 327, "\"", 344, 1);
#line 16 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 335, Model.Id, 335, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(345, 36, true);
            WriteLiteral(" name=\"Id\" />\r\n\t<input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 381, "\"", 403, 1);
#line 17 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 389, Model.Created, 389, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(404, 41, true);
            WriteLiteral(" name=\"Created\" />\r\n\t<input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 445, "\"", 469, 1);
#line 18 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 453, Model.CreatedBy, 453, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(470, 25, true);
            WriteLiteral(" name=\"CreatedBy\" />\r\n\r\n\t");
            EndContext();
            BeginContext(496, 64, false);
#line 20 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(560, 31, true);
            WriteLiteral("\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(592, 98, false);
#line 22 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(690, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t");
            EndContext();
            BeginContext(722, 98, false);
#line 24 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(820, 52, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(873, 97, false);
#line 29 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(970, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t");
            EndContext();
            BeginContext(1002, 97, false);
#line 31 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 52, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(1152, 102, false);
#line 36 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.StreetAddress, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t");
            EndContext();
            BeginContext(1286, 102, false);
#line 38 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(model => model.StreetAddress, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 52, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(1441, 93, false);
#line 43 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.City, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t");
            EndContext();
            BeginContext(1566, 93, false);
#line 45 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(model => model.City, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 52, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(1712, 94, false);
#line 50 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.State, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t");
            EndContext();
            BeginContext(1838, 94, false);
#line 52 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(model => model.State, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1932, 52, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(1985, 101, false);
#line 57 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.EmailAddress, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t");
            EndContext();
            BeginContext(2118, 101, false);
#line 59 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(model => model.EmailAddress, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 52, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(2272, 100, false);
#line 64 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2372, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t");
            EndContext();
            BeginContext(2404, 134, false);
#line 66 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { placeholder = "### - ### - ####", @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2538, 52, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(2591, 99, false);
#line 71 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.Department, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2690, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t");
            EndContext();
            BeginContext(2722, 146, false);
#line 73 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
       Write(Html.DropDownListFor(model => model.DepartmentId, (SelectList)ViewBag.Departments, null, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2868, 52, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(2921, 95, false);
#line 78 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.Active, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3016, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-1\">\r\n\t\t\t");
            EndContext();
            BeginContext(3048, 95, false);
#line 80 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
       Write(Html.EditorFor(model => model.Active, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3143, 233, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<br />\r\n\r\n\t<div class=\"form-group\">\r\n\t\t<div class=\"col-md-2\">\r\n\t\t\t<input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n\t\t</div>\r\n\t\t<div class=\"col-md-1\">\r\n\t\t\t<input value=\"Delete\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3376, "\"", 3468, 5);
            WriteAttributeValue("", 3386, "location.href", 3386, 13, true);
            WriteAttributeValue(" ", 3399, "=", 3400, 2, true);
            WriteAttributeValue(" ", 3401, "\'", 3402, 2, true);
#line 90 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 3403, Url.Action("Delete", "Employee", new { employeeId = Model.Id }), 3403, 64, false);

#line default
#line hidden
            WriteAttributeValue("", 3467, "\'", 3467, 1, true);
            EndWriteAttribute();
            BeginContext(3469, 32, true);
            WriteLiteral(" />\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            EndContext();
#line 94 "C:\Workspace\Source\KLove\KLove\Views\Employee\Edit.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
