#pragma checksum "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1962bf4547dada5b094c2291dbae186484b432c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_ConfirmInvoice), @"mvc.1.0.view", @"/Views/Invoice/ConfirmInvoice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/ConfirmInvoice.cshtml", typeof(AspNetCore.Views_Invoice_ConfirmInvoice))]
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
#line 1 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\_ViewImports.cshtml"
using MinVoiCe;

#line default
#line hidden
#line 2 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\_ViewImports.cshtml"
using MinVoiCe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1962bf4547dada5b094c2291dbae186484b432c4", @"/Views/Invoice/ConfirmInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db14de72e6b960ccc1bb7f88b301de34e824484", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_ConfirmInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MinVoiCe.ViewModels.ConfirmInvoiceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 59, true);
            WriteLiteral("\r\n\r\n<div style=\"width: 600px; margin: 0 auto;\">\r\n    \r\n    ");
            EndContext();
            BeginContext(111, 3449, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "534ccdf8540040e6bf2d36ecd3c6e6d2", async() => {
                BeginContext(176, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(186, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae8cb351ff20493ebb8a8e367c35f24c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InvoiceId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 7 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
                                            WriteLiteral(Model.InvoiceId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(254, 227, true);
                WriteLiteral("\r\n\r\n\r\n        <div style=\"width: 100%; margin: 20px auto; text-align: justify;\">\r\n            <table style=\"width: 200px; float: right;\">\r\n                <tr>\r\n                    <td>INVOICE NO.</td>\r\n                    <td>");
                EndContext();
                BeginContext(482, 15, false);
#line 14 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
                   Write(Model.InvoiceId);

#line default
#line hidden
                EndContext();
                BeginContext(497, 111, true);
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>DATE</td>\r\n                    <td>");
                EndContext();
                BeginContext(609, 25, false);
#line 18 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
                   Write(Model.Invoice.CurrentDate);

#line default
#line hidden
                EndContext();
                BeginContext(634, 517, true);
                WriteLiteral(@"</td>
                </tr>
            </table>
        </div>

        <div style=""width: 100%; margin: 20px auto; text-align: left;"">
            <strong>Mike Toth</strong><br />
            Cooper St. Design<br />
            WeWork C/O Mike Toth<br />
            111 Street St.<br />
            Miami Beach, FL 33139<br />
            (123) 123 1234<br />
        </div>

        <div style=""width: 100%; margin: 20px auto; text-align: left;"">
            <h3>BILL TO:</h3>
            <strong>");
                EndContext();
                BeginContext(1152, 43, false);
#line 34 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
               Write(Model.Invoice.Project.Client.PointOfContact);

#line default
#line hidden
                EndContext();
                BeginContext(1195, 29, true);
                WriteLiteral("</strong><br />\r\n            ");
                EndContext();
                BeginContext(1225, 33, false);
#line 35 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
       Write(Model.Invoice.Project.Client.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1258, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(1279, 42, false);
#line 36 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
       Write(Model.Invoice.Project.Client.AddressStreet);

#line default
#line hidden
                EndContext();
                BeginContext(1321, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(1342, 43, false);
#line 37 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
       Write(Model.Invoice.Project.Client.AddressCityZip);

#line default
#line hidden
                EndContext();
                BeginContext(1385, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(1406, 34, false);
#line 38 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
       Write(Model.Invoice.Project.Client.EMail);

#line default
#line hidden
                EndContext();
                BeginContext(1440, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(1461, 34, false);
#line 39 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
       Write(Model.Invoice.Project.Client.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(1495, 681, true);
                WriteLiteral(@"<br />
        </div>

        <div style=""width: 100%; margin: 20px auto; border: 1px solid black; text-align: center;"">
            <table style=""width:100%;"">
                <tr style=""background-color: lightgreen; height: 30px;"">
                    <th style=""width: calc(100%-200px);text-align: center;"">Description</th>
                    <th style=""width: 100px;text-align: center;"">Hours</th>
                    <th style=""width: 100px;text-align: center; position:relative;"">Amount
                        <div style=""position: absolute; left: 110px; top:5px;"">
                            Remove
                        </div></th>
                </tr>
");
                EndContext();
#line 52 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
                     foreach (Worktime aWorktime in Model.Invoice.Worktimes)
                    {

#line default
#line hidden
                BeginContext(2277, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(2340, 125, false);
#line 55 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
                           Write(string.Format("'{0}' thru period {1} at {2:C}/hr", @aWorktime.Description, @aWorktime.WeekRange, @Model.Invoice.Project.Rate));

#line default
#line hidden
                EndContext();
                BeginContext(2465, 79, true);
                WriteLiteral("</td>\r\n                            <td><input style=\"width: 40px; margin: 2px;\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2544, "\"", 2568, 1);
#line 56 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
WriteAttributeValue("", 2552, aWorktime.Hours, 2552, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2569, 104, true);
                WriteLiteral(" /></td>\r\n                            <td style=\"position: relative;\">\r\n                                ");
                EndContext();
                BeginContext(2674, 41, false);
#line 58 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
                           Write(string.Format("{0:C}", @aWorktime.Amount));

#line default
#line hidden
                EndContext();
                BeginContext(2715, 150, true);
                WriteLiteral("\r\n                                <div style=\"position: absolute; right: -30px; top:5px;\">\r\n                                    <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " \r\nvalue=\"", 2865, "\"", 2896, 1);
#line 61 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
WriteAttributeValue("", 2875, aWorktime.WorktimeID, 2875, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2897, 136, true);
                WriteLiteral(" name=\"RemoveWorkTimeIDs\" />\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 65 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
                    }

#line default
#line hidden
                BeginContext(3056, 271, true);
                WriteLiteral(@"</table>
        </div>

        <div style=""width: 100%; margin: 20px auto; text-align: center;"">
            <table style=""width: 200px; float: right;"">
                <tr>
                    <td><strong>Total Due</strong></td>
                    <td><strong>");
                EndContext();
                BeginContext(3328, 50, false);
#line 73 "C:\Users\miket\lc101\Unit4 - Liftoff\MinVoiCe\MinVoiCe\MinVoiCe\Views\Invoice\ConfirmInvoice.cshtml"
                           Write(string.Format("{0:C}", @Model.Invoice.TotalAmount));

#line default
#line hidden
                EndContext();
                BeginContext(3378, 175, true);
                WriteLiteral("</strong></td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n\r\n        <button class=\"addTimeButton bluegreenBG withGlow\" type=\"submit\">Update</button>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3560, 14, true);
            WriteLiteral("\r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MinVoiCe.ViewModels.ConfirmInvoiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
