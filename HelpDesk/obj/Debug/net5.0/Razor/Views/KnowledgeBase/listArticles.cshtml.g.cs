#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b1fa2439d74357ee27b203994cd8131aeddff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KnowledgeBase_listArticles), @"mvc.1.0.view", @"/Views/KnowledgeBase/listArticles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b1fa2439d74357ee27b203994cd8131aeddff6", @"/Views/KnowledgeBase/listArticles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_KnowledgeBase_listArticles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Entities.Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "KnowledgeBase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 5%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "updateArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"
   Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>

    $(function () {
        var placeholder = $('#placeholder');
        $('a[data-toggle=""deleteArticle""]').click(function (event) {

            var url = $(this).data('url');
            $.get(url).done(function (data) {
                placeholder.html(data);
                placeholder.find('.modal').modal('show');
            })


        })

    })

    $(function () {
        var placeholder = $('#placeholder');
        $('a[data-toggle=""infoArticle""]').click(function (event) {

            var url = $(this).data('url');
            $.get(url).done(function (data) {
                placeholder.html(data);
                placeholder.find('.modal').modal('show');
            })


        })

    })
</script>

<div id=""placeholder""></div>

<div class=""card-header"" style=""display: flex;justify-content: space-between;"">
    <span>
        <i class=""fas fa-table mr-1""></i>
        Articles
    </span>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b1fa2439d74357ee27b203994cd8131aeddff66421", async() => {
                WriteLiteral(" <i class=\"fas fa-plus\"></i>&nbsp; add new article");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<div class=""card-body"">
    <div class=""dx-isotope-container"">


        <div class=""dx-box bg-white "">
            <div class=""container"">
                <ul class=""dx-links dx-isotope-filter text-center p-10"" style=""background-color: gainsboro;margin:0px -24px;"">
                    <li class=""active"" data-filter=""*"">All Items</li>
                    <li data-filter="".info"">info</li>
                    <li data-filter="".stylo"">stylo</li>
                    <li data-filter="".smart_phone"">smart phone</li>
                </ul>
            </div>
        </div>
        <div class=""dx-separator""></div>


        <div class=""dx-box-5 pb-100 bg-grey-6"">
            <div class=""container"">



                <div class=""row vertical-gap dx-isotope-grid"">
                    <div class=""card-deck"">
");
#nullable restore
#line 74 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"
                         foreach (var item in ViewBag.Articles)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 2204, "\"", 2247, 2);
            WriteAttributeValue("", 2212, "dx-isotope-grid-item", 2212, 20, true);
#nullable restore
#line 77 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"
WriteAttributeValue(" ", 2232, item.category, 2233, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                                <div class=\"card border-dark mb-3\" style=\"width:18rem;\">\r\n\r\n                                    <a href=\"#\" data-toggle=\"infoArticle\" data-target=\"#infoArticle\"\r\n                                       data-url=\"");
#nullable restore
#line 83 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"
                                            Write(Url.Action("infoArticle","KnowledgeBase",new { idArticle = item.ArticleId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                       class=\"nav-link\">\r\n                                        <div class=\"card-header\">\r\n\r\n                                            <h5 class=\"card-title  text-center\">");
#nullable restore
#line 87 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"
                                                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                                            <h6 class=\"card-subtitle mb-2 text-muted\"> ");
#nullable restore
#line 88 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"
                                                                                  Write(item.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        </div>\r\n                                        <div class=\"card-body\">\r\n                                            <p style=\"color:black;\" class=\"card-text\">");
#nullable restore
#line 91 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"
                                                                                 Write(item.content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            <p class=""card-text""><small class=""text-muted"">Last updated 20/20/2021</small></p>

                                        </div>
                                    </a>

                                    <div class=""card-footer text-center"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b1fa2439d74357ee27b203994cd8131aeddff612085", async() => {
                WriteLiteral("<i class=\"far fa-edit\"></i>&nbsp;Edit");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"
                                                                                                       WriteLiteral(item.ArticleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <a style=\"color:red;\"\r\n                                           href=\"#\" data-toggle=\"deleteArticle\" data-target=\"#deleteArticle\"\r\n                                           data-url=\"");
#nullable restore
#line 101 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"
                                                Write(Url.Action("deleteArticle","KnowledgeBase",new { articleId = item.ArticleId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                           class=""card-link"">
                                            <i class=""fas fa-trash-alt""></i>
                                            &nbsp;Delete
                                        </a>
                                    </div>

                                </div>

                            </div>
");
#nullable restore
#line 111 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\KnowledgeBase\listArticles.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Entities.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
