#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8152141c52b09cab3198e23107f19e512d8e3e77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_ticketInfo), @"mvc.1.0.view", @"/Views/Tickets/ticketInfo.cshtml")]
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
#line 2 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8152141c52b09cab3198e23107f19e512d8e3e77", @"/Views/Tickets/ticketInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_ticketInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Entities.Reply>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-style-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-file-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addReply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
   Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""modal fade "" id=""ticketInfo"">
    <div class=""modal-dialog modal-dialog-scrollable modal-dialog-centered "">
        <div class=""modal-content "">
            <div class=""modal-body"">


                <div class=""row justify-content-center"">
                    <div class=""container pl-0 pr-0"">
                        <div class=""dx-box dx-box-decorated"">
                            <div class=""dx-blog-post dx-ticket "">
                                <div class=""dx-blog-post-box p-10 pt-15"" style=""display: flex;justify-content: space-around;background: goldenrod;border-radius: 5px;"">
                                    <h2 class=""h4 mnt-5 mb-9 dx-ticket-title"">#");
#nullable restore
#line 21 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                          Write(ViewBag.Ticket.ticketId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                                   Write(ViewBag.Ticket.ticketTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <span>");
#nullable restore
#line 22 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                     Write(ViewBag.Ticket.ticketStatut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n\r\n                                <div class=\"dx-separator mb-10\"></div>\r\n\r\n                                <div class=\"dx-comment dx-ticket-comment p-15\"");
            BeginWriteAttribute("id", " id=\"", 1168, "\"", 1215, 1);
#nullable restore
#line 27 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 1173, ViewBag.Ticket.creator_user.role.roleName, 1173, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div>

                                        <div class=""dx-comment-cont"">
                                            <div style=""display:flex"">
                                                <div class=""dx-comment-img"">
                                                    <img id=""al-img""");
            BeginWriteAttribute("src", " src=\"", 1553, "\"", 1609, 1);
#nullable restore
#line 33 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 1559, Url.Content(ViewBag.Ticket.creator_user.ThumbUrl), 1559, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""replier img"">
                                                </div>
                                                <div class=""al-info-reply"">
                                                    <a href=""#"" class=""dx-comment-name"">
                                                        ");
#nullable restore
#line 37 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                   Write(ViewBag.Ticket.creator_user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                          Write(ViewBag.Ticket.creator_user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                    </a>\r\n                                                    <div class=\"dx-comment-date\">");
#nullable restore
#line 40 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                            Write(ViewBag.Ticket.ticketDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"al-comment-text\">\r\n                                                <p>");
#nullable restore
#line 44 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                              Write(ViewBag.Ticket.ticketDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>

                                </div>

                                <div class=""dx-separator mnt-1""></div>
");
#nullable restore
#line 52 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                 if (@ViewBag.ticketReplies != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                     foreach (var item in ViewBag.ticketReplies)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"dx-comment dx-ticket-comment p-15\"");
            BeginWriteAttribute("id", " id=\"", 3008, "\"", 3043, 1);
#nullable restore
#line 56 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 3013, item.replyOwner.role.roleName, 3013, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <div>

                                                <div class=""dx-comment-cont"">
                                                    <div style=""display:flex"">
                                                        <div class=""dx-comment-img"">
                                                            <img id=""al-img""");
            BeginWriteAttribute("src", " src=\"", 3421, "\"", 3465, 1);
#nullable restore
#line 62 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 3427, Url.Content(item.replyOwner.ThumbUrl), 3427, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""replier img"">
                                                        </div>
                                                        <div class=""al-info-reply"">
                                                            <a href=""#"" class=""dx-comment-name"">
                                                                ");
#nullable restore
#line 66 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                           Write(item.replyOwner.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 66 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                      Write(item.replyOwner.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                            </a>\r\n                                                            <div class=\"dx-comment-date\">");
#nullable restore
#line 69 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                    Write(item.reply_date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                        </div>
                                                    </div>
                                                    <div class=""al-comment-text"">
                                                        <p>");
#nullable restore
#line 73 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                      Write(item.content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""dx-separator mnt-1""></div>
");
#nullable restore
#line 79 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"dx-blog-post-box p-6\">\r\n\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8152141c52b09cab3198e23107f19e512d8e3e7717477", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n                                        <div class=\"dx-form-group \">\r\n\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8152141c52b09cab3198e23107f19e512d8e3e7717870", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 92 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 92 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
AddHtmlAttributeValue("", 5119, localizer["Description"], 5119, 25, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8152141c52b09cab3198e23107f19e512d8e3e7720012", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 93 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                            <input type=\"hidden\" name=\"replierAdress\"");
                BeginWriteAttribute("value", " value=\"", 5353, "\"", 5380, 1);
#nullable restore
#line 95 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 5361, User.Identity.Name, 5361, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8152141c52b09cab3198e23107f19e512d8e3e7722206", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 97 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TicketId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                               WriteLiteral(ViewBag.Ticket.ticketId);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n\r\n                                            <input type=\"hidden\" name=\"asp-action\" value=\"myTickets\" />\r\n                                            <input type=\"hidden\" name=\"asp-controller\" value=\"Agent\" />\r\n\r\n\r\n");
                WriteLiteral(@"


                                        </div>


                                        <div class=""dx-form-group mt-10"">

                                            <div class=""input-group mb-3"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8152141c52b09cab3198e23107f19e512d8e3e7725195", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 116 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.r_uploadedFile);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                <label class=""custom-file-label"">Choose file</label>
                                            </div>

                                        </div>


                                        <div class=""dx-box-content p-6 pb-15"" style=""width: 100%;display: flex;justify-content: space-around;padding-bottom: 20px;"">
                                            <a data-dismiss=""modal"" class=""btn btn-outline-dark btn-sm mr-10"">close</a>
                                            <button type=""submit"" class=""btn btn-success btn-sm ml-30"">Send Reply</button>
                                        </div>



                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Entities.Reply> Html { get; private set; }
    }
}
#pragma warning restore 1591
