#pragma checksum "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7d8acb5cd57dfbf0b9486d3f21bf073a914d8e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\_ViewImports.cshtml"
using ProjectPeriod1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\_ViewImports.cshtml"
using ProjectPeriod1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d8acb5cd57dfbf0b9486d3f21bf073a914d8e3", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cfaa252a76e9ba15acebcb94301fbf8e3f63f5", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectPeriod1.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<h1>View</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7d8acb5cd57dfbf0b9486d3f21bf073a914d8e33475", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n\r\n\r\n\r\n<div class=\"container\">\r\n    <h2>User manager</h2>\r\n    <table class=\"table table-striped table-bordered\" id=\"sortTable\">\r\n        <thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>");
#nullable restore
#line 20 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 21 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 22 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th># tickets</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item._id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
                    Write((ViewBag.TickCount as ICollection<Ticket>).Where(x => x.User.MongoId == item.MongoId).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Zico\Desktop\Project database\nosqlmongo\ProjectPeriod1\Views\User\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<script>\r\n    $(\'#sortTable\').DataTable();\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectPeriod1.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591