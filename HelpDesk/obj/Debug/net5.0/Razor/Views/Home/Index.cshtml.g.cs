#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f8cee4376e390921dd6275d406b476688095de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f8cee4376e390921dd6275d406b476688095de", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDisplay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-btn dx-btn-lg mt-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-portfolio-item-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-btn dx-btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HelpCenter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-btn dx-btn-lg dx-btn-transparent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<header class=\"dx-header dx-box-4\">\r\n    <div class=\"bg-image bg-image-parallax\">\r\n        <img src=\"/wwwroot/Content/images/bg-header.png\" class=\"jarallax-img\"");
            BeginWriteAttribute("alt", " alt=\"", 162, "\"", 168, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div style=""background-color: rgb(0, 0, 0,0.85);""></div>
    </div>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 col-md-8 col-lg-6 col-xl-5"">
                <h1 class=""display-3 text-white"">NST-Desk</h1>
                <p class=""lead text-1"">nst groupe is a tecsfjkhgksjkhsjkhgs</p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f8cee4376e390921dd6275d406b476688095de6726", async() => {
                WriteLiteral("View Products");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
</header>



<div class=""dx-box-1"">
    <div class=""container"">
        <div class=""row vertical-gap lg-gap"">
            <div class=""col-lg-4"">


                <div class=""dx-feature dx-feature-1"">
                    <div class=""dx-feature-decorated""></div>
                    <div class=""dx-feature-icon"">
                        <span class=""icon pe-7s-diamond""></span>
                    </div>
                    <div class=""dx-feature-cont"">
                        <div class=""dx-feature-title"">7700 +</div>
                        <div class=""dx-feature-text"">Happy Customers</div>
                    </div>
                </div>


                <div class=""dx-feature dx-feature-1"">
                    <div class=""dx-feature-decorated""></div>
                    <div class=""dx-feature-icon"">
                        <span class=""icon pe-7s-like""></span>
                    </div>
                    <div class=""dx-feature-co");
            WriteLiteral(@"nt"">
                        <div class=""dx-feature-title"">4.9</div>
                        <div class=""dx-feature-text"">Author Rating</div>
                    </div>
                </div>

            </div>
            <div class=""col-lg-6"">
                <h2>Who we are</h2>
                <p class=""mb-0"">Nous aimons notre travail et cela se voit.
                Une équipe jeune motivée formée principalement par des ingénieurs informatique ,
                nous connaissons ce milieu comme notre poche.
                Nous sommes prêts à relever tous les défis et nous nous impliquons à 100 % dans tous les projets que nous entreprenons.</p>
            </div>
        </div>
    </div>
</div>

<div class=""dx-box-1 bg-dark-1"">
    <div class=""container"">
        <div class=""row mnt-40 mnb-40"">

            <div class=""col-12 col-md-6 col-lg-4"">

                <div class=""dx-feature dx-feature-2"">
                    <div class=""dx-feature-cont"">
                        <div c");
            WriteLiteral(@"lass=""dx-feature-icon"">
                            <span class=""icon pe-7s-edit""></span>
                        </div>
                        <div class=""dx-feature-title"">Easy Setup</div>
                        <div class=""dx-feature-text"">We make our products easy to setup and customize.</div>
                    </div>
                    <span class=""dx-decorated"" style=""background-image: url('C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\wwwroot\Content\images\decorated-pattern-dark.svg')""></span>
                </div>

            </div>

            <div class=""col-12 col-md-6 col-lg-4"">

                <div class=""dx-feature dx-feature-2"">
                    <div class=""dx-feature-cont"">
                        <div class=""dx-feature-icon"">
                            <span class=""icon pe-7s-timer""></span>
                        </div>
                        <div class=""dx-feature-title"">Lifetime Updates</div>
                        <div class=""dx-feature-text"">We ");
            WriteLiteral(@"improve our products after release and you will get it for free.</div>
                    </div>
                    <span class=""dx-decorated"" style=""background-image: url('../../wwwroot/Content/images/decorated_pattern_dark.svg');""></span>
                </div>

            </div>


            <div class=""col-12 col-md-6 col-lg-4"">

                <div class=""dx-feature dx-feature-2"">
                    <div class=""dx-feature-cont"">
                        <div class=""dx-feature-icon"">
                            <span class=""icon pe-7s-headphones""></span>
                        </div>
                        <div class=""dx-feature-title"">Outstanding Support</div>
                        <div class=""dx-feature-text"">We provide fast and professional support through support system.</div>
                    </div>
                    <span class=""dx-decorated"" style=""background-image: url('../../wwwroot/Content/images/decorated_pattern_dark.svg');""></span>
                </div>

  ");
            WriteLiteral("          </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"dx-box-1 bg-grey-6\">\r\n    <div class=\"container\">\r\n        <h2 class=\"text-center mb-60\">Latest Products</h2>\r\n\r\n        <div class=\"row vertical-gap\">\r\n");
#nullable restore
#line 121 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.latestProduct)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-12 col-md-6 col-lg-4"">

                <div class=""dx-portfolio-item dx-block-decorated"">
                    <div class=""dx-portfolio-item-image"">
                        <div class=""dx-portfolio-item-overlay"" style=""background-color: rgba(27, 27, 27, .8);"">
                            <a href=""#"" class=""dx-btn dx-btn-md dx-btn-transparent-style-2 m-10"">Live Demo</a>
                            <a href=""#"" class=""dx-btn dx-btn-md dx-btn-transparent-style-2 m-10"">Buy Now</a>
                        </div>
                        <img");
            BeginWriteAttribute("src", " src=", 5607, "", 5637, 1);
#nullable restore
#line 133 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\Index.cshtml"
WriteAttributeValue("", 5612, Url.Content(item.imgUrl), 5612, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product Img\">\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f8cee4376e390921dd6275d406b476688095de14057", async() => {
                WriteLiteral("\r\n                        <span class=\"dx-portfolio-item-title\">");
#nullable restore
#line 136 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\Index.cshtml"
                                                         Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n                        <span class=\"dx-portfolio-item-price\">$");
#nullable restore
#line 138 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\Index.cshtml"
                                                          Write(item.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-refId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 135 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\Index.cshtml"
                                                                                WriteLiteral(item.refId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["refId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-refId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["refId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 144 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"text-center mt-70\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f8cee4376e390921dd6275d406b476688095de17607", async() => {
                WriteLiteral("View Products");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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

        <div class=""dx-box-1"">
            <span class=""dx-decorated"" style=""background-image: url('../../wwwroot/Content/images/decorated-pattern-light.svg');""></span>
        </div>

        <h2 class=""text-center mb-40"">Reviews</h2>

    </div>
</div>
<div class=""row no-gutters"">
");
            WriteLiteral(@"    <div class=""col-lg-12 bg-main-1"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-lg-10"">
                <div class=""container"">
                    <div class=""dx-box-1"">
                        <h2 class=""text-white"">Visit our Support Desk</h2>
                        <p class=""text-white op-8"">We have a Support Desk for our users and a well experienced team to quickly answer your questions.</p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f8cee4376e390921dd6275d406b476688095de19898", async() => {
                WriteLiteral("Get support");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
