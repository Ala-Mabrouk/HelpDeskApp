#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "089f281de33e6507d0e42e2db6bc97099ae90a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideNavbarAdmin_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideNavbarAdmin/Default.cshtml")]
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
#line 2 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089f281de33e6507d0e42e2db6bc97099ae90a15", @"/Views/Shared/Components/SideNavbarAdmin/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideNavbarAdmin_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Entities.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DashBoardAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "listTickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n<div id=\"layoutSidenav_nav\">\r\n    <nav class=\"sb-sidenav accordion sb-sidenav-dark\" id=\"sidenavAccordion\">\r\n        <div class=\"sb-sidenav-menu\">\r\n            <div class=\"nav\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089f281de33e6507d0e42e2db6bc97099ae90a155633", async() => {
                WriteLiteral("\r\n\r\n                    <div class=\"sb-nav-link-icon\"><i class=\"fas fa-tachometer-alt\"></i></div>\r\n                    ");
#nullable restore
#line 17 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
               Write(localizer["Dashboard"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
                 if (Model.role.roleName.Equals("Admin") || Model.role.roleName.Equals("SupperAdmin"))
                {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <a class=""nav-link collapsed"" href=""#collapseLayouts"" data-toggle=""collapse"" data-target=""#collapseLayouts"" aria-expanded=""false"" aria-controls=""collapseLayouts"">
                        <div class=""sb-nav-link-icon""><i class=""fas fa-columns""></i></div>
                        ");
#nullable restore
#line 27 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
                   Write(localizer["users"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                    </a>
                    <div class=""collapse"" id=""collapseLayouts"" aria-labelledby=""headingOne"" data-parent=""#sidenavAccordion"">
                        <nav class=""sb-sidenav-menu-nested nav"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089f281de33e6507d0e42e2db6bc97099ae90a158594", async() => {
#nullable restore
#line 32 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
                                                                                         Write(localizer["Agents"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
                             if (Model.role.roleName.Equals("SupperAdmin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"nav-link\">\r\n                                    ");
#nullable restore
#line 36 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
                               Write(localizer["Admins"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 38 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </nav>\r\n                    </div>\r\n");
#nullable restore
#line 41 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089f281de33e6507d0e42e2db6bc97099ae90a1511629", async() => {
                WriteLiteral("\r\n                    <div class=\"sb-nav-link-icon\"><i class=\"fas fa-chart-area\"></i></div>\r\n                    ");
#nullable restore
#line 45 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
               Write(localizer["Manage_Tickets"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a class=\"nav-link\">\r\n                    <div class=\"sb-nav-link-icon\"><i class=\"fas fa-chart-area\"></i></div>\r\n                    ");
#nullable restore
#line 49 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\SideNavbarAdmin\Default.cshtml"
               Write(localizer["Knowledge_Base"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </a>
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""false"" aria-controls=""collapsePages"">
                    <div class=""sb-nav-link-icon""><i class=""fas fa-book-open""></i></div>
                    Configs
                    <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                </a>
");
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </nav>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Entities.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
