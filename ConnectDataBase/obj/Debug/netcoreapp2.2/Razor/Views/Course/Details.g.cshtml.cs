#pragma checksum "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2451d714ff2812a12522ad7901dc207d85b94cc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Details), @"mvc.1.0.view", @"/Views/Course/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/Details.cshtml", typeof(AspNetCore.Views_Course_Details))]
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
#line 1 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\_ViewImports.cshtml"
using ConnectDataBase;

#line default
#line hidden
#line 2 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\_ViewImports.cshtml"
using ConnectDataBase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2451d714ff2812a12522ad7901dc207d85b94cc7", @"/Views/Course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"590080c666a494eeeeabf49be6b7bb320af8dbd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_Core_EF.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Course</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(207, 46, false);
#line 14 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(253, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(315, 42, false);
#line 17 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
       Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(357, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(418, 43, false);
#line 20 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Credits));

#line default
#line hidden
            EndContext();
            BeginContext(461, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(523, 39, false);
#line 23 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
       Write(Html.DisplayFor(model => model.Credits));

#line default
#line hidden
            EndContext();
            BeginContext(562, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(623, 47, false);
#line 26 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Enrollments));

#line default
#line hidden
            EndContext();
            BeginContext(670, 632, true);
            WriteLiteral(@"
        </dt>
        <dd class=""col-sm-10"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Student
                        </th>
                        <th>
                           Start Date
                        </th>
                        <th>
                            End Date
                        </th>
                        <th>
                            Grade
                        </th>
                        
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 48 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
                     foreach (var item in Model.Enrollments)
                    {

#line default
#line hidden
            BeginContext(1387, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1484, 53, false);
#line 52 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Students.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 133, true);
            WriteLiteral("\r\n                            </td>\r\n                            \r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1671, 44, false);
#line 56 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1819, 42, false);
#line 59 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1965, 40, false);
#line 62 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 65 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2096, 93, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2189, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2451d714ff2812a12522ad7901dc207d85b94cc79519", async() => {
                BeginContext(2241, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "D:\Project VS\ConnectDataBase\ConnectDataBase\Views\Course\Details.cshtml"
                           WriteLiteral(Model.CourseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2249, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2257, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2451d714ff2812a12522ad7901dc207d85b94cc711840", async() => {
                BeginContext(2279, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2295, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_Core_EF.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
