#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8b53fa0a70f02baf3ac9d70eef7f3777124836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KnowledgeBase_singleArticleInfo), @"mvc.1.0.view", @"/Views/KnowledgeBase/singleArticleInfo.cshtml")]
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
#line 2 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8b53fa0a70f02baf3ac9d70eef7f3777124836", @"/Views/KnowledgeBase/singleArticleInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_KnowledgeBase_singleArticleInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Entities.Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "KnowledgeBase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "singleArticleCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-form dx-form-group-inputs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n<div class=\"dx-box bg-white\">\r\n    <div class=\"container\">\r\n        <ul class=\"dx-links text-center\">\r\n            <li><a ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8b53fa0a70f02baf3ac9d70eef7f37771248366146", async() => {
#nullable restore
#line 12 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                          Write(localizer["SupportHome"]);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</li>\r\n            <li class=\"active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8b53fa0a70f02baf3ac9d70eef7f37771248367776", async() => {
#nullable restore
#line 13 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                                               Write(localizer["KnowledgeBase"]);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</li>\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8b53fa0a70f02baf3ac9d70eef7f37771248369412", async() => {
#nullable restore
#line 14 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                          Write(localizer["TicketSystem"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
        </ul>
    </div>
</div>
<div class=""dx-separator""></div>

<div class=""dx-box-5 pb-100 bg-grey-6"">
    <div class=""container"">
        <div class=""row vertical-gap md-gap"">
            <div class=""col-lg-8"">
                <div class=""dx-box dx-box-decorated"">
                    <div class=""dx-blog-post"">
                        <div class=""dx-blog-post-box pt-30 pb-30"">
                            <h2 class=""h4 mnt-5 mb-8"">");
#nullable restore
#line 27 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n                            <!-- START: Breadcrumbs -->\r\n                            <ul class=\"dx-breadcrumbs text-left dx-breadcrumbs-dark mnb-8\">\r\n\r\n                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8b53fa0a70f02baf3ac9d70eef7f377712483611970", async() => {
#nullable restore
#line 33 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                                           Write(localizer["SupportHome"]);

#line default
#line hidden
#nullable disable
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8b53fa0a70f02baf3ac9d70eef7f377712483613629", async() => {
#nullable restore
#line 36 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                                                    Write(localizer["Articles"]);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</li>\r\n\r\n\r\n                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8b53fa0a70f02baf3ac9d70eef7f377712483615294", async() => {
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 40 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                               Write(Model.articleCategory.categoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                                                                                 WriteLiteral(Model.articleCategory.categoryName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n                                <li>");
#nullable restore
#line 42 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>


                            </ul>
                        </div>


                        <div class=""dx-separator""></div>

                        <div class=""dx-separator""></div>
                        <div class=""dx-blog-post-box"">
                            ");
#nullable restore
#line 53 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                       Write(Model.content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                        <div class=""dx-separator""></div>
                        <div class=""dx-blog-post-box pt-30 pb-30"">
                            <ul class=""dx-blog-post-info mnt-15 mnb-2"">
                                <li>Date: ");
#nullable restore
#line 59 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                     Write(Model.lastModified);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                            </ul>
                            <ul class=""dx-social-links dx-social-links-style-2 mt-20"">
                                <li>
                                    <a href=""#"" class=""dx-social-twitter""><span class=""icon fab fa-twitter""></span> Twitter</a>
                                </li>
                                <li>
                                    <a href=""#"" class=""dx-social-facebook""><span class=""icon fab fa-facebook""></span> Facebook</a>
                                </li>
                                <li>
                                    <a href=""#"" class=""dx-social-google""><span class=""icon fab fa-google""></span> Google</a>
                                </li>
                                <li>
                                    <a href=""#"" class=""dx-social-pinterest""><span class=""icon fab fa-pinterest""></span> Pinterest</a>
                                </li>
                            </ul>
                        </div");
            WriteLiteral(@">
                    </div>
                </div>

                <div class=""dx-box dx-box-content dx-box-decorated mt-40"">
                    <div class=""row vertical-gap align-items-center justify-content-center"">
                        <div class=""col-auto"">
                            <h3 class=""h5 mnt-6 mnb-6"">");
#nullable restore
#line 82 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                  Write(localizer["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("Was this helpful to you?</h3>\r\n                        </div>\r\n                        <div class=\"col-auto d-flex\">\r\n                            <a href=\"#\" class=\"dx-btn dx-btn-md dx-btn-main-1\">");
#nullable restore
#line 85 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                                          Write(localizer["Yes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <a href=\"#\" class=\"dx-btn dx-btn-md dx-btn-grey-2 ml-20\">");
#nullable restore
#line 86 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                                                Write(localizer["No"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""dx-sticky dx-sidebar"" data-sticky-offsetTop=""120"" data-sticky-offsetBot=""40"">


                    <div class=""dx-widget dx-box dx-box-decorated"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8b53fa0a70f02baf3ac9d70eef7f377712483622501", async() => {
                WriteLiteral("\r\n                            <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 4452, "\"", 4459, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4460, "\"", 4468, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control form-control-style-2\" placeholder=\"Search...\">\r\n                            <button class=\"dx-btn dx-btn-lg dx-btn-grey dx-btn-grey-style-2 dx-btn-icon\"><span class=\"icon fas fa-search\"></span></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"dx-widget dx-box dx-box-decorated\">\r\n                        <div class=\"dx-widget-title\">");
#nullable restore
#line 102 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                                                Write(localizer["ArticlesCategories"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        ");
#nullable restore
#line 103 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\singleArticleInfo.cshtml"
                   Write(await Component.InvokeAsync("ArticlesCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Entities.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
