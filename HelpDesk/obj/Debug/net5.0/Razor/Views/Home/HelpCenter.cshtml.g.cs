#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\HelpCenter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "660d3a819e11ad569cb4a116114acdb0df232de5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HelpCenter), @"mvc.1.0.view", @"/Views/Home/HelpCenter.cshtml")]
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
#line 1 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\HelpCenter.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660d3a819e11ad569cb4a116114acdb0df232de5", @"/Views/Home/HelpCenter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HelpCenter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-btn dx-btn-link d-flex dx-feature-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\HelpCenter.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"dx-main\">\r\n\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "660d3a819e11ad569cb4a116114acdb0df232de55525", async() => {
                WriteLiteral("go to settings");
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
            WriteLiteral(@"


    <div class=""dx-separator""></div>

    <div class=""dx-box-5 bg-grey-6"">
        <div class=""container"">
            <div class=""row justify-content-center vertical-gap"">


                <div class=""col-12 col-md-4 col-lg-3 dx-feature-variable"">

                    <div class=""dx-feature dx-feature-3 dx-feature-color-2 dx-block-decorated"">
                        <div class=""dx-feature-icon"">
                            <span class=""icon pe-7s-notebook""></span>
                        </div>
                        <div class=""dx-feature-cont"">
                            <div class=""dx-feature-title""><a href=""articles.html"">Knowledge Base</a></div>
                            <div class=""dx-feature-text"">Aliquam id nisi sit amet massa mollis lobortis interdum felis integer at arcu mattis</div>
                            <a href=""articles.html"" class=""dx-btn dx-btn-link d-flex dx-feature-link"">Read More <span class=""icon pe-7s-angle-right""></span></a>
                        </div");
            WriteLiteral(@">
                    </div>

                </div>

                <div class=""col-12 col-md-4 col-lg-3 dx-feature-variable"">

                    <div class=""dx-feature dx-feature-3 dx-feature-color-4 dx-block-decorated"">
                        <div class=""dx-feature-icon"">
                            <span class=""icon pe-7s-ticket""></span>
                        </div>
                        <div class=""dx-feature-cont"">
                            <div class=""dx-feature-title"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "660d3a819e11ad569cb4a116114acdb0df232de58492", async() => {
                WriteLiteral("Ticket System");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                            <div class=\"dx-feature-text\">Vivamus sceleriue libero velit blandit, hendrerit nisl at,dapibus sollicitudin</div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "660d3a819e11ad569cb4a116114acdb0df232de510041", async() => {
                WriteLiteral("Read More <span class=\"icon pe-7s-angle-right\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class=""dx-separator""></div>


    <div class=""dx-box-5 pb-100"">
        <div class=""container mt-4 mnb-7"">
            <div class=""row align-items-center vertical-gap mnt-30 sm-gap mb-50"">
                <h2 class=""col-auto h4 mb-0 mt-0"">");
#nullable restore
#line 63 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\HelpCenter.cshtml"
                                             Write(localizer["Popular Articles"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <div class=\"col pl-30 pr-30 d-none d-sm-block\">\r\n                    <div class=\"dx-separator\"></div>\r\n                </div>\r\n                <div class=\"col-auto dx-slider-arrows-clone\"></div>\r\n            </div>\r\n");
            WriteLiteral(@"

            <div class=""swiper-container dx-slider dx-slider-arrows dx-slider-articles""
                 data-swiper-speed=""400""
                 data-swiper-space=""50""
                 data-swiper-slides=""3""
                 data-swiper-breakpoints=""true""
                 data-swiper-arrows=""true""
                 data-swiper-arrows-clone=""true""
                 data-swiper-loop=""true""
                 data-swiper-autoHeight=""true""
                 data-swiper-grabCursor=""true"">

                <div class=""swiper-wrapper"">
                    <div class=""swiper-slide"">
                        <div class=""dx-article dx-article-list"">
                            <h4 class=""h6 mt-0"">Quantial</h4>
                            <ul class=""dx-list"">
                                <li><a href=""single-article.html"">Make menu dropdown working without JavaScript</a></li>
                                <li><a href=""single-article.html"">Google Analytics</a></li>
                                <li");
            WriteLiteral(@"><a href=""single-article.html"">How to manually import Demo data (if you faced with problems in one-click demo import)</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""swiper-slide"">
                        <div class=""dx-article dx-article-list"">
                            <h4 class=""h6 mt-0"">Sensific</h4>
                            <ul class=""dx-list"">
                                <li><a href=""single-article.html"">WordPress Themes FAQ</a></li>
                                <li><a href=""single-article.html"">Change navbar background color</a></li>
                                <li><a href=""single-article.html"">Change images and banners overlay color</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""swiper-slide"">
                        <div class=""dx-article dx-article-list"">
                            <h4 class=""h6 mt-");
            WriteLiteral(@"0"">Minist</h4>
                            <ul class=""dx-list"">
                                <li><a href=""single-article.html"">Add top menu link inside dropdown on mobile devices</a></li>
                                <li><a href=""single-article.html"">Google Map API Warning (NoApiKeys)</a></li>
                                <li><a href=""single-article.html"">Make dropdown items links working</a></li>
                            </ul>
                        </div>
                    </div>
                </div>

                <div class=""swiper-button-prev""><span class=""icon pe-7s-angle-left""></span></div>
                <div class=""swiper-button-next""><span class=""icon pe-7s-angle-right""></span></div>
            </div>

        </div>
    </div>
   
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591