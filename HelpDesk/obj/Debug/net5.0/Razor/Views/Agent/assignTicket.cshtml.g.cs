#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6da751135c4db54f07f84de8b956d59ee5562f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agent_assignTicket), @"mvc.1.0.view", @"/Views/Agent/assignTicket.cshtml")]
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
#line 1 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\_ViewImports.cshtml"
using HelpDesk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\_ViewImports.cshtml"
using HelpDesk.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6da751135c4db54f07f84de8b956d59ee5562f", @"/Views/Agent/assignTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Agent_assignTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Entities.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "assignTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
   Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"modal fade \" id=\"assignTicket\">\r\n    <div class=\"modal-dialog modal-dialog-scrollable modal-dialog-centered\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <span>");
#nullable restore
#line 18 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                 Write(localizer["assignticket"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <a data-dismiss=\"modal\" class=\"close\">x</a>\r\n\r\n            </div>\r\n\r\n            <div class=\"modal-body\">\r\n\r\n                <h3>");
#nullable restore
#line 25 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
               Write(localizer["assignticket"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</h3> <h1>#");
#nullable restore
#line 25 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                                                      Write(Model.ticketId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                                                                      Write(Model.ticketTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                <h3>");
#nullable restore
#line 26 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
               Write(localizer["ToAgent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h3>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e6da751135c4db54f07f84de8b956d59ee5562f6621", async() => {
                WriteLiteral("\r\n\r\n\r\n                    <div class=\"dx-form-group\">\r\n                        <input name=\"ticketId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 883, "\"", 906, 1);
#nullable restore
#line 31 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
WriteAttributeValue("", 891, Model.ticketId, 891, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <select name=\"AgentId\" class=\"form-control dx-select-ticket\">\r\n\r\n");
#nullable restore
#line 34 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                             foreach (var item in ViewBag.AgentList)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e6da751135c4db54f07f84de8b956d59ee5562f7827", async() => {
#nullable restore
#line 37 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                                                                                                                     Write(item.FirstName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                                                                                                                                     Write(item.LastName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                WriteLiteral("<img src=");
#nullable restore
#line 37 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                                                                         Write(Url.Content(item.ThumbUrl));

#line default
#line hidden
#nullable disable
                WriteLiteral(" alt=\"sdfkdj\"> ");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-content", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </select>
                    </div>


                    <div class=""dx-box-content"" style=""justify-content:space-between; display:flex;"">

                        <button data-dismiss=""modal"" class=""btn btn-outline-danger btn-sm"">");
#nullable restore
#line 48 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                                                                                      Write(localizer["Cancel"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                        <button type=\"submit\" class=\"btn btn-primary btn-sm  \">");
#nullable restore
#line 49 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\assignTicket.cshtml"
                                                                          Write(localizer["SaveChanges"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n\r\n                    </div>\r\n\r\n\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Entities.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
