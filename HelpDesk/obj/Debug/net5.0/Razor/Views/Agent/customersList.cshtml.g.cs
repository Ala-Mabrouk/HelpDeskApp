#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34f87f40c2731000a5c5d7c1312e44025b024ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agent_customersList), @"mvc.1.0.view", @"/Views/Agent/customersList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34f87f40c2731000a5c5d7c1312e44025b024ab", @"/Views/Agent/customersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Agent_customersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.Entities.Client>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "clientDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>

    //for Product details
    $(function () {
        var placeholder = $('#placeholder');
        $('a[data-toggle=""productsList""]').click(function (event) {

            var url = $(this).data('url');
            $.get(url).done(function (data) {
                placeholder.html(data);
                placeholder.find('.modal').modal('show');
            })


        })

    })
    //adding client
    $(function () {
        var placeholder = $('#placeholder');
        $('a[data-toggle=""addClient""]').click(function (event) {

            var url = $(this).data('url');
            $.get(url).done(function (data) {
                placeholder.html(data);
                placeholder.find('.modal').modal('show');
            })


        })

    })


</script>





<div id=""placeholder""></div>

<div class=""card-header"" >
     <div style=""display: flex;justify-content: space-between; align-items:center;"">
        <div>
            <span onclick=""history.");
            WriteLiteral(@"back(-1)"" style=""cursor:pointer;""><i class=""fas fa-long-arrow-alt-left""></i>&nbsp;&nbsp;</span>

            <i class=""fas fa-table mr-1""></i>
            Customers table
        </div>
        <a href=""#"" data-toggle=""addClient"" data-target=""#addClient"" data-url=""");
#nullable restore
#line 59 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
                                                                          Write(Url.Action("addClient"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
           class=""btn btn-primary"">
            <i class=""fas fa-plus""></i>&nbsp;Add costumer
        </a>
    </div>
</div>

<div class=""card-body"">
    <table class=""table align-middle "" id=""dataTable"" width=""100%"" cellspacing=""0"">
        <thead>
            <tr class=""table-info table-bordered "">

                <th>
                    ");
#nullable restore
#line 72 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 75 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label> </label>\r\n                    ");
#nullable restore
#line 77 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 80 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 84 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tfoot>\r\n            <tr class=\"table-info table-bordered \">\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 94 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 97 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label> </label>\r\n                    ");
#nullable restore
#line 99 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 102 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 106 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n            </tr>\r\n        </tfoot>\r\n        <tbody>\r\n");
#nullable restore
#line 113 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"align-middle\">\r\n                    <td>\r\n                      ");
#nullable restore
#line 117 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 121 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <label> </label>");
#nullable restore
#line 121 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
                                                    Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 125 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 128 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a href=\"#\" data-toggle=\"productsList\" data-target=\"#productsList\" data-url=\"");
#nullable restore
#line 131 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
                                                                                                Write(Url.Action("afectProduct",new { clientMail = item.Email }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Affect Product</a> |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c34f87f40c2731000a5c5d7c1312e44025b024ab12044", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mailClient", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
                                                                                       WriteLiteral(item.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mailClient"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mailClient", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mailClient"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                     </td>\r\n                </tr>\r\n");
#nullable restore
#line 135 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Agent\customersList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.Entities.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
