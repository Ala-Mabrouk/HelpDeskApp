#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eed579382141e4a98ba11fb0277f6a15ec94f7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_singleTicketInfo), @"mvc.1.0.view", @"/Views/Tickets/singleTicketInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eed579382141e4a98ba11fb0277f6a15ec94f7f", @"/Views/Tickets/singleTicketInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_singleTicketInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-form dx-form-group-inputs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
  
    ViewData["Title"] = "singleTicketInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""dx-separator""></div>

<div class=""dx-box-5 pb-100 bg-grey-6"">
    <div class=""container"">
        <div class=""row vertical-gap md-gap"">
            <div class=""col-lg-8"">
                <div class=""dx-box dx-box-decorated"">
                    <div class=""dx-blog-post dx-ticket "">
                        <div class=""dx-blog-post-box pt-30 pb-30"">
                            <h2 class=""h4 mnt-5 mb-9 dx-ticket-title"">");
#nullable restore
#line 21 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                                 Write(ViewBag.Ticket.ticketTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n                            <!-- START: Breadcrumbs -->\r\n                            <ul class=\"dx-breadcrumbs text-left dx-breadcrumbs-dark mnb-6 fs-14\">\r\n\r\n                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eed579382141e4a98ba11fb0277f6a15ec94f7f6631", async() => {
                WriteLiteral("Support Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n\r\n                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eed579382141e4a98ba11fb0277f6a15ec94f7f8047", async() => {
                WriteLiteral("Ticket System");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n                                <li>");
#nullable restore
#line 32 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                               Write(ViewBag.Ticket.ticketTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n\r\n                            </ul>\r\n                            <!-- END: Breadcrumbs -->\r\n\r\n                            <span class=\"dx-ticket-status\">");
#nullable restore
#line 38 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                      Write(ViewBag.Ticket.ticketStatut);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                        <div class=""dx-separator""></div>

                        <div style=""background-color: #fafafa;"">

                            <ul class=""dx-blog-post-info dx-blog-post-info-style-2 mb-0 mt-0"">
                                <li><span><span class=""dx-blog-post-info-title"" asp-for=""ticketId""></span># ");
#nullable restore
#line 45 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                                                                       Write(ViewBag.Ticket.ticketId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li><span><span class=\"dx-blog-post-info-title\" asp-for=\"ticketStatut\"></span>");
#nullable restore
#line 46 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                                                                         Write(ViewBag.Ticket.ticketStatut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li><span><span class=\"dx-blog-post-info-title\" asp-for=\"ticketDate\"></span>");
#nullable restore
#line 47 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                                                                       Write(ViewBag.Ticket.ticketDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
            WriteLiteral("                                <li><span><span class=\"dx-blog-post-info-title\" asp-for=\"ticketPriority\"></span>");
#nullable restore
#line 48 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                                                                               Write(ViewBag.Ticket.ticketPriority);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                            </ul>
                        </div>
                        <div class=""dx-separator""></div>

                        <div class=""dx-comment dx-ticket-comment"">
                            <div>
                                <div class=""dx-comment-img"">
                                    <img");
            BeginWriteAttribute("src", " src=", 2377, "", 2419, 1);
#nullable restore
#line 56 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
WriteAttributeValue("", 2382, ViewBag.Ticket.creator_user.ThumbUrl, 2382, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"user ThumbUrl\">\r\n                                </div>\r\n                                <div class=\"dx-comment-cont\">\r\n                                    <a href=\"#\" class=\"dx-comment-name\">");
#nullable restore
#line 59 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                                   Write(ViewBag.Ticket.creator_user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 59 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                                                                          Write(ViewBag.Ticket.creator_user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <div class=\"dx-comment-date\">");
#nullable restore
#line 60 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                            Write(ViewBag.Ticket.ticketDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"dx-comment-text\">\r\n                                        <p class=\"mb-0\">");
#nullable restore
#line 62 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Tickets\singleTicketInfo.cshtml"
                                                   Write(ViewBag.Ticket.ticketDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n\r\n");
            WriteLiteral(@"                                </div>
                            </div>
                        </div>

                        <div class=""dx-separator mnt-1""></div>

                        <div class=""dx-blog-post-box"">
                            <h3 class=""h6 mb-25"">Write a Reply</h3>

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eed579382141e4a98ba11fb0277f6a15ec94f7f15260", async() => {
                WriteLiteral(@"
                                <div class=""dx-form-group"">
                                    <div class=""dx-editor-quill"">
                                        <div class=""dx-editor"" data-editor-height=""150"" data-editor-maxHeight=""250""></div>
                                    </div>
                                </div>
                                <div class=""dx-form-group"">
                                    <!-- STRART: Dropzone

                                        Additional Attributes:
                                        data-dropzone-action
                                        data-dropzone-maxMB
                                        data-dropzone-maxFiles
                                    -->
                                    <div class=""dx-dropzone"" data-dropzone-action=""#"" data-dropzone-maxMB=""5"" data-dropzone-maxFiles=""5"">
                                        <div class=""dz-message"">
                                            <div class=""dx-dropzone");
                WriteLiteral(@"-icon"">
                                                <span class=""icon pe-7s-cloud-upload""></span>
                                            </div>
                                            <div class=""h6 dx-dropzone-title"">Drop files here or click to upload</div>
                                            <div class=""dx-dropzone-text"">
                                                <p class=""mnb-5 mnt-1"">You can upload up to 5 files (maximum 5 MB each) of the following types: .jpg, .jpeg, .png, .zip.</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row justify-content-between vertical-gap dx-dropzone-attachment"">
                                        <div class=""col-auto dx-dropzone-attachment-add"">
                                            <label class=""mb-0"" class=""mnt-7""><span class=""icon fas fa-paperclip mr-10""></span><span>Add Attachment<");
                WriteLiteral(@"/span></label>
                                        </div>
                                        <div class=""col-auto dx-dropzone-attachment-btn"">
                                            <button class=""dx-btn dx-btn-lg"" type=""button"" name=""button"">Submit a ticket</button>
                                        </div>
                                    </div>
                                    <!-- END: Dropzone -->
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4\">\r\n                <div class=\"dx-widget dx-box dx-box-decorated\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eed579382141e4a98ba11fb0277f6a15ec94f7f19572", async() => {
                WriteLiteral("\r\n                        <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 6938, "\"", 6945, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 6946, "\"", 6954, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control form-control-style-2\" placeholder=\"Search...\">\r\n                        <button class=\"dx-btn dx-btn-lg dx-btn-grey dx-btn-grey-style-2 dx-btn-icon\"><span class=\"icon fas fa-search\"></span></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>


                <div class=""dx-widget dx-box dx-box-decorated"">
                    <div class=""dx-widget-title"">
                        Latest Articles
                    </div>
                    <a href=""single-article.html"" class=""dx-widget-link"">
                        <span class=""dx-widget-link-text"">How to manually import Demo data (if you faced with problems in one-click demo import)</span>
                        <span class=""dx-widget-link-date"">6 Sep 2018</span>
                    </a>
                    <a href=""single-article.html"" class=""dx-widget-link"">
                        <span class=""dx-widget-link-text"">Make menu dropdown working without JavaScript</span>
                        <span class=""dx-widget-link-date"">2 Sep 2018</span>
                    </a>
                    <a href=""single-article.html"" class=""dx-widget-link"">
                        <span class=""dx-widget-link-text"">Add top menu link inside dropdown on mobile devices</sp");
            WriteLiteral("an>\r\n                        <span class=\"dx-widget-link-date\">27 Aug 2018</span>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
