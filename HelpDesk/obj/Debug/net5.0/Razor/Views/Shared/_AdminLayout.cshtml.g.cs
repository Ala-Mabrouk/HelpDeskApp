#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef435b0aa0f1767768f694376edcb50baedb596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
#line 1 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef435b0aa0f1767768f694376edcb50baedb596", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DashBoardAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-nav-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgentSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "log_out", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Log_in", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-btn dx-btn-md dx-btn-transparent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sign_Up", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef435b0aa0f1767768f694376edcb50baedb5966834", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 9 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" Amdesk-ADMIN_HOME</title>

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">

    <link rel=""icon"" type=""image/png"" href=""/Content/lib/images/favicon.png"">

    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- START: Styles -->
    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Nunito+Sans:400,600,700%7cMaven+Pro:400,500,700"" rel=""stylesheet""><!-- %7c -->
    <!-- Bootstrap -->
    <link rel=""stylesheet"" href=""/Content/lib/bootstrap/dist/css/bootstrap.min.css"">

    <!-- Bootstrap Select -->
    <link rel=""stylesheet"" type=""text/css"" href=""/Content/lib/bootstrap-select/dist/css/bootstrap-select.min.css"">

    <!-- Font Awesome -->
    <script defer src=""/Content/lib/fontawesome-free/js/all.js""></script>
    <script defer src=""/Content/lib/fontawesome-free/js/v4-shims.js""></script>

    <!-- Amdesk -->
    <link rel=""stylesheet"" href=""/Content/css/site.css"">
    <link href=");
                WriteLiteral(@"""/Content/css/costum.css"" rel=""stylesheet"" />


    <!-- for tables -->
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.24/css/jquery.dataTables.css"">

    <!-- END: Styles -->
    <!-- jQuery -->
    <script src=""/Content/lib/jquery/dist/jquery.min.js""></script>

    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.24/js/jquery.dataTables.js""></script>

    <script>
        $(document).ready(function () {
            $('#dataTable').DataTable();
        });

        $(function () {
            $(""#menu-toggle"").click(function (e) {
                e.preventDefault();
                $(""body"").toggleClass(""sb-sidenav-toggled"");
            
            });

            $(window).resize(function (e) {
                if ($(window).width() <= 768) {
                    $(""#wrapper"").removeClass(""toggled"");
                } else {
                    $(""#wrapper"").addClass(""toggled"");
                }
            }");
                WriteLiteral(");\r\n        });\r\n\r\n\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef435b0aa0f1767768f694376edcb50baedb59610290", async() => {
                WriteLiteral(@"
    <nav class=""dx-navbar dx-navbar-top dx-navbar-collapse dx-navbar-sticky dx-navbar-expand-lg dx-navbar-dropdown-triangle dx-navbar-autohide "" style=""z-index: 1039;"">
        <div class=""container"">

            <button class=""btn btn-link btn-sm order-1 order-lg-0 mr-10"" id=""menu-toggle"" href=""#""><i class=""fas fa-bars""></i></button>

            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef435b0aa0f1767768f694376edcb50baedb59610918", async() => {
                    WriteLiteral("\r\n                <img src=\"/Content/images/index12.png\"");
                    BeginWriteAttribute("alt", " alt=\"", 2749, "\"", 2755, 0);
                    EndWriteAttribute();
                    WriteLiteral(" width=\"150px\">\r\n\r\n            ");
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
            <button class=""dx-navbar-burger"">
                <span></span>
                <span></span>
                <span></span>
            </button>
            <div class=""dx-navbar-content"">

                <ul class=""dx-nav dx-nav-align-right"">
");
#nullable restore
#line 89 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li>

                            <div class=""dropdown dx-dropdown dx-dropdown-signin"">

                                <a id=""dropdownSignin"" class=""dx-nav-signin"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">

                                    ");
#nullable restore
#line 98 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                               Write(await Component.InvokeAsync("NavBarWithLog", User.Identity.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                </a>\r\n\r\n                                <ul class=\"dropdown-menu\" aria-labelledby=\"dropdownSignin\">\r\n\r\n                                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef435b0aa0f1767768f694376edcb50baedb59614091", async() => {
                    WriteLiteral("<span class=\"icon pe-7s-config\"></span>");
#nullable restore
#line 104 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                                                                                                                               Write(localizer["Settings"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                                    <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef435b0aa0f1767768f694376edcb50baedb59615932", async() => {
                    WriteLiteral("<span class=\"icon pe-7s-back\"></span>");
#nullable restore
#line 105 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                                                                                                                      Write(localizer["Log_out"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
                        </li>
                        <li>
                            <div class=""dropdown dx-dropdown dx-dropdown-signin"">
                                <a id=""dropdownNoti"" class=""dx-nav-signin"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">

                                    <i class=""fas fa-bell""></i>

                                </a>

                                <ul class=""dropdown-menu"" aria-labelledby=""dropdownNoti"">
                                    <li>


                                        ");
#nullable restore
#line 125 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                                   Write(await Component.InvokeAsync("Notification", User.Identity.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </li>\r\n                                </ul>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 130 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li>");
#nullable restore
#line 131 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                   Write(await Html.PartialAsync("_CulturePartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                </ul>
            </div>
        </div>
    </nav>

    <div class=""dx-navbar dx-navbar-fullscreen"">
        <div class=""container"">
            <button class=""dx-navbar-burger"">
                <span></span><span></span><span></span>
            </button>
            <div class=""dx-navbar-content"">


                <ul class=""dx-nav dx-nav-align-left"">

                    <li class=""dx-drop-item"">
                        <a href=""articles.html"">
                            ");
#nullable restore
#line 149 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                       Write(localizer["account"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </a>\r\n                        <ul class=\"dx-navbar-dropdown \"");
                BeginWriteAttribute("style", " style=\"", 5601, "\"", 5609, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                            <li>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef435b0aa0f1767768f694376edcb50baedb59620537", async() => {
                    WriteLiteral("\r\n                                   ");
#nullable restore
#line 155 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                              Write(localizer["Settings"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                            <li>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef435b0aa0f1767768f694376edcb50baedb59622414", async() => {
#nullable restore
#line 159 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                                                                         Write(localizer["Log_out"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n\r\n                        </ul>\r\n                    </li>\r\n\r\n\r\n                </ul>\r\n\r\n                <ul class=\"dx-nav dx-nav-align-right\">\r\n");
#nullable restore
#line 169 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li>

                            <div class=""dropdown dx-dropdown dx-dropdown-signin"">

                                <a id=""dropdownSignin"" class=""dx-nav-signin"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">


                                    ");
#nullable restore
#line 178 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                               Write(await Component.InvokeAsync("NavBarWithLog", User.Identity.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                                </a>


                            </div>

                        </li>
                        <li>
                            <div class=""dropdown dx-dropdown dx-dropdown-signin"">
                                <a id=""dropdownNoti"" class=""dx-nav-signin"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">

                                    <i class=""fas fa-bell""></i>

                                </a>

                                <ul class=""dropdown-menu"" aria-labelledby=""dropdownNoti"">
                                    <li>


                                        ");
#nullable restore
#line 199 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                                   Write(await Component.InvokeAsync("Notification", User.Identity.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </li>\r\n                                </ul>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 204 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"

                    }
                    else
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef435b0aa0f1767768f694376edcb50baedb59626728", async() => {
#nullable restore
#line 210 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                                                                    Write(localizer["Log_In"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <span> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ef435b0aa0f1767768f694376edcb50baedb59628483", async() => {
#nullable restore
#line 213 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                                                                                                                        Write(localizer["Sign_Up"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</span>\r\n                        </li>\r\n");
#nullable restore
#line 215 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 218 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
                   Write(await Html.PartialAsync("_CulturePartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    <div id=\"layoutSidenav\">\r\n        ");
#nullable restore
#line 230 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
   Write(await Component.InvokeAsync("SideNavbarAdmin", User.Identity.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <div id=\"layoutSidenav_content\" style=\"padding-left: 225px;\">\r\n            <main role=\"main\" class=\"pb-3\">\r\n                ");
#nullable restore
#line 234 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\_AdminLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </main>
        </div>

    </div>



    <!-- START: Scripts -->
    <!-- Object Fit Images -->
    <script src=""/Content/lib/object-fit-images/dist/ofi.min.js""></script>

    <!-- Popper -->
    <script src=""/Content/lib/popper.js/dist/umd/popper.min.js""></script>

    <!-- Bootstrap -->
    <script src=""/Content/lib/bootstrap/dist/js/bootstrap.min.js""></script>

    <!-- Fancybox -->
    <script src=""/Content/lib/fancybox/dist/jquery.fancybox.min.js""></script>

    <!-- Cleave -->
    <script src=""/Content/lib/cleave.js/dist/cleave.min.js""></script>

    <!-- Validator -->
    <script src=""/Content/lib/validator/validator.min.js""></script>

    <!-- Sticky Kit -->
    <script src=""/Content/lib/sticky-kit/dist/sticky-kit.min.js""></script>

    <!-- Jarallax -->
    <script src=""/Content/lib/jarallax/dist/jarallax.min.js""></script>
    <script src=""/Content/lib/jarallax/dist/jarallax-video.min.js""></script>

    <!-- Isotope -->
    <script src=""/Content/lib/is");
                WriteLiteral(@"otope-layout/dist/isotope.pkgd.min.js""></script>

    <!-- ImagesLoaded -->
    <script src=""/Content/lib/imagesloaded/imagesloaded.pkgd.min.js""></script>

    <!-- Swiper -->
    <script src=""/Content/lib/swiper/dist/js/swiper.min.js""></script>

    <!-- Gist Embed -->
    <script src=""/Content/lib/gist-embed/gist-embed.min.js""></script>

    <!-- Bootstrap Select -->
    <script src=""/Content/lib/bootstrap-select/dist/js/bootstrap-select.min.js""></script>

    <!-- Dropzone -->
    <script src=""/Content/lib/dropzone/dist/min/dropzone.min.js""></script>

    <!-- Quill -->
    <script src=""/Content/lib/quill/dist/quill.min.js""></script>

    <!-- The Amdesk -->
    <script src=""/Content/js/amdesk.min.js""></script>
    <script src=""/Content/js/amdesk-init.js""></script>


    <!-- for table -->
    <script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.24/js/jquery.dataTables.js""></script>
    <script src=""https://cdn.datatables.net/1.10.20/js/dataTables.bo");
                WriteLiteral("otstrap4.min.js\" crossorigin=\"anonymous\"></script>\r\n\r\n    <!-- END: Scripts -->\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
