#pragma checksum "C:\Users\Zico\Desktop\Project database\nosqlmongo\TicketSystem\ProjectPeriod1\Views\Ticket\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0967a532ec6c57b8622f39487c283eb1e8aef7a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Create), @"mvc.1.0.view", @"/Views/Ticket/Create.cshtml")]
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
#line 1 "C:\Users\Zico\Desktop\Project database\nosqlmongo\TicketSystem\ProjectPeriod1\Views\_ViewImports.cshtml"
using ProjectPeriod1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zico\Desktop\Project database\nosqlmongo\TicketSystem\ProjectPeriod1\Views\_ViewImports.cshtml"
using ProjectPeriod1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0967a532ec6c57b8622f39487c283eb1e8aef7a0", @"/Views/Ticket/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cfaa252a76e9ba15acebcb94301fbf8e3f63f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectPeriod1.Models.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cancel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0967a532ec6c57b8622f39487c283eb1e8aef7a05450", async() => {
                WriteLiteral("\r\n    <fieldset class=\"idea-form\">\r\n        <h2>Create new incident ticket</h2>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0967a532ec6c57b8622f39487c283eb1e8aef7a05801", async() => {
                    WriteLiteral("\r\n            <p>Subject of incident: ");
#nullable restore
#line 9 "C:\Users\Zico\Desktop\Project database\nosqlmongo\TicketSystem\ProjectPeriod1\Views\Ticket\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.Subject_Incident));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n            <p>\r\n                Type of incident:\r\n                ");
#nullable restore
#line 12 "C:\Users\Zico\Desktop\Project database\nosqlmongo\TicketSystem\ProjectPeriod1\Views\Ticket\Create.cshtml"
           Write(Html.DropDownListFor(model => model.Type,
                  new List<SelectListItem> {
                       new SelectListItem { Value = "0" , Text = "Software" },
                       new SelectListItem { Value = "1" , Text = "Hardware" },
                       new SelectListItem { Value = "2" , Text = "Service" }
                    },
                  new { @class = "myselect" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </p>\r\n            <p>\r\n                Reported by user:\r\n                ");
#nullable restore
#line 22 "C:\Users\Zico\Desktop\Project database\nosqlmongo\TicketSystem\ProjectPeriod1\Views\Ticket\Create.cshtml"
           Write(Html.DropDownListFor(model => model.Id,
                  new List<SelectListItem> {
                       new SelectListItem { Value = "0" , Text = "Sander" },
                       new SelectListItem { Value = "1" , Text = "Fabian" },
                       new SelectListItem { Value = "2" , Text = "Sed" },
                       new SelectListItem { Value = "3", Text = "Zico"}
                    },
                  new { @class = "myselect" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </p>\r\n            <p>\r\n                Priority:\r\n                ");
#nullable restore
#line 33 "C:\Users\Zico\Desktop\Project database\nosqlmongo\TicketSystem\ProjectPeriod1\Views\Ticket\Create.cshtml"
           Write(Html.DropDownListFor(model => model.Priority,
                     new List<SelectListItem> {
                          new SelectListItem { Value = "0" , Text = "Low" },
                          new SelectListItem { Value = "1" , Text = "Normal" },
                          new SelectListItem { Value = "2" , Text = "High" }
                       },
                     new { @class = "myselect" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </p>\r\n            <p>\r\n                Deadline/Follow up:\r\n                ");
#nullable restore
#line 43 "C:\Users\Zico\Desktop\Project database\nosqlmongo\TicketSystem\ProjectPeriod1\Views\Ticket\Create.cshtml"
           Write(Html.DropDownListFor(model => model.Deadline,
                     new List<SelectListItem> {
                          new SelectListItem { Value = "0" , Text = "7 Days" },
                          new SelectListItem { Value = "1" , Text = "14 Days" },
                          new SelectListItem { Value = "2" , Text = "28 Days" },
                          new SelectListItem { Value = "3", Text = "6 Months"}
                       },
                     new { @class = "myselect" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            </p>\r\n            <p>Description:  ");
#nullable restore
#line 52 "C:\Users\Zico\Desktop\Project database\nosqlmongo\TicketSystem\ProjectPeriod1\Views\Ticket\Create.cshtml"
                        Write(Html.TextBoxFor(m => m.Description));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p> \r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0967a532ec6c57b8622f39487c283eb1e8aef7a011093", async() => {
                    WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Cancel\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0967a532ec6c57b8622f39487c283eb1e8aef7a012570", async() => {
                    WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Submit Ticket\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </fieldset>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectPeriod1.Models.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
