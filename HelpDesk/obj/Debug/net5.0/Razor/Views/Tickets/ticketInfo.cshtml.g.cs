#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeaccf86239a73f9130d904d73eafb2efd2417c7"
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
#nullable restore
#line 4 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
using Entities.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeaccf86239a73f9130d904d73eafb2efd2417c7", @"/Views/Tickets/ticketInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_ticketInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Entities.Reply>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:flex; justify-content: end;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-style-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept", new global::Microsoft.AspNetCore.Html.HtmlString(".png,.jpg,.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-file-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addReply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
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


");
#nullable restore
#line 22 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                         if (ViewBag.Ticket.ticketStatut != Ticket.TicketStatus.Closed && User.Identity.Name != "boss@boss.com")
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeaccf86239a73f9130d904d73eafb2efd2417c710199", async() => {
                WriteLiteral("Open chat");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-reciver", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                                                                           WriteLiteral(ViewBag.Ticket.creator_user.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reciver"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-reciver", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reciver"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""dx-box dx-box-decorated"">
                                <div class=""dx-blog-post dx-ticket "">
                                    <div class=""dx-blog-post-box p-10 pt-15"" style=""display: flex;justify-content: space-around;background: goldenrod;border-radius: 5px;"">
                                        <h2 class=""h4 mnt-5 mb-9 dx-ticket-title"">#");
#nullable restore
#line 30 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                              Write(ViewBag.Ticket.ticketId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                                       Write(ViewBag.Ticket.ticketTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <span>");
#nullable restore
#line 31 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                         Write(ViewBag.Ticket.ticketStatut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n\r\n                                    <div class=\"dx-separator mb-10\"></div>\r\n\r\n                                    <div class=\"dx-comment dx-ticket-comment p-15\"");
            BeginWriteAttribute("id", " id=\"", 1619, "\"", 1666, 1);
#nullable restore
#line 36 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 1624, ViewBag.Ticket.creator_user.role.roleName, 1624, 42, false);

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
            BeginWriteAttribute("src", " src=\"", 2024, "\"", 2080, 1);
#nullable restore
#line 42 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 2030, Url.Content(ViewBag.Ticket.creator_user.ThumbUrl), 2030, 50, false);

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
#line 46 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                       Write(ViewBag.Ticket.creator_user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                              Write(ViewBag.Ticket.creator_user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                        </a>\r\n                                                        <div class=\"dx-comment-date\">");
#nullable restore
#line 49 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                Write(ViewBag.Ticket.ticketDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                    </div>
                                                </div>
                                                <div class=""al-comment-text"">
                                                    <p>");
#nullable restore
#line 53 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
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
#line 61 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                     if (ViewBag.ticketReplies != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                         foreach (var item in ViewBag.ticketReplies)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"dx-comment dx-ticket-comment p-15\"");
            BeginWriteAttribute("id", " id=\"", 3558, "\"", 3593, 1);
#nullable restore
#line 65 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 3563, item.replyOwner.role.roleName, 3563, 30, false);

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
            BeginWriteAttribute("src", " src=\"", 3991, "\"", 4035, 1);
#nullable restore
#line 71 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 3997, Url.Content(item.replyOwner.ThumbUrl), 3997, 38, false);

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
#line 75 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                               Write(item.replyOwner.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 75 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                          Write(item.replyOwner.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                                </a>\r\n                                                                <div class=\"dx-comment-date\">");
#nullable restore
#line 78 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
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
#line 82 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                          Write(item.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        </div>\r\n");
#nullable restore
#line 84 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                         if (!string.IsNullOrEmpty(item.r_uploadedFile))
                                                        {

                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                       Write(await Component.InvokeAsync("TicketAttatchment", item.r_uploadedFile));

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                                                                  
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"dx-separator mnt-1\"></div>\r\n");
#nullable restore
#line 94 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"

                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                     if (ViewBag.Ticket.ticketStatut != Ticket.TicketStatus.Closed && User.Identity.Name != "boss@boss.com")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"dx-blog-post-box p-6\">\r\n\r\n\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeaccf86239a73f9130d904d73eafb2efd2417c724543", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n                                                <div class=\"dx-form-group \">\r\n\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeaccf86239a73f9130d904d73eafb2efd2417c724952", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 109 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 109 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
AddHtmlAttributeValue("", 6330, localizer["Description"], 6330, 25, false);

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
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeaccf86239a73f9130d904d73eafb2efd2417c727104", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 110 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                                    <input type=\"hidden\" name=\"replierAdress\"");
                BeginWriteAttribute("value", " value=\"", 6580, "\"", 6607, 1);
#nullable restore
#line 112 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 6588, User.Identity.Name, 6588, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aeaccf86239a73f9130d904d73eafb2efd2417c729316", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 114 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TicketId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
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
                WriteLiteral(@"

                                                    <input type=""hidden"" name=""asp-action"" value=""myTickets"" />
                                                    <input type=""hidden"" name=""asp-controller"" value=""Agent"" />
                                                    <input type=""hidden"" name=""destination""");
                BeginWriteAttribute("value", " value=\"", 7063, "\"", 7105, 1);
#nullable restore
#line 118 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
WriteAttributeValue("", 7071, ViewBag.Ticket.creator_user.Email, 7071, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

                                                </div>

                                                <div class=""dx-form-group"">

                                                    <div class=""input-group mb-3 mt-3"">
                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aeaccf86239a73f9130d904d73eafb2efd2417c732812", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 125 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.r_uploadedFileFile);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        <label class=\"custom-file-label\">");
#nullable restore
#line 126 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                    Write(localizer["Choosefile"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                                    </div>

                                                </div>


                                                <div class=""dx-box-content p-6 pb-15"" style=""width: 100%;display: flex;justify-content: space-around;padding-bottom: 20px;"">
                                                    <a data-dismiss=""modal"" class=""btn btn-outline-dark btn-sm mr-10""><i class=""fas fa-times-circle""></i>&nbsp;");
#nullable restore
#line 133 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                                                                                          Write(localizer["Close"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                    <button type=\"submit\" class=\"btn btn-success btn-sm ml-30\"><i class=\"fas fa-paper-plane\"></i>&nbsp; ");
#nullable restore
#line 134 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                                                                                                                                   Write(localizer["Reply"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                                </div>\r\n\r\n\r\n\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 141 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\ticketInfo.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n</div>");
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
