#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32fdd11ed30c15550f48ae9a56f924f94ba97978"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditAgentPermission), @"mvc.1.0.view", @"/Views/Admin/EditAgentPermission.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32fdd11ed30c15550f48ae9a56f924f94ba97978", @"/Views/Admin/EditAgentPermission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditAgentPermission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Entities.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "validatePermissions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dx-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
  
    ViewData["Title"] = "Update Agents info ";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Agent Permissions for ");
#nullable restore
#line 11 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
                     Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
                                                                Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<nav>
    <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
        <a class=""nav-item nav-link active"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#nav-profile"" role=""tab"" aria-controls=""nav-profile"" aria-selected=""true"">Profile</a>
        <a class=""nav-item nav-link "" id=""nav-permissions-tab"" data-toggle=""tab"" href=""#nav-permissions"" role=""tab"" aria-controls=""nav-permissions"" aria-selected=""false"">Permissions</a>

    </div>
</nav>
<div class=""tab-content"" id=""nav-tabContent"">

");
            WriteLiteral("\r\n    <div class=\"tab-pane fade \" id=\"nav-permissions\" role=\"tabpanel\" aria-labelledby=\"nav-permissions-tab\">\r\n        <div class=\"dx-box-decorated\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32fdd11ed30c15550f48ae9a56f924f94ba979786297", async() => {
                WriteLiteral("\r\n                <div class=\"dx-box-content\">\r\n\r\n");
#nullable restore
#line 30 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
                     foreach (var item in ViewBag.Permissions)
                    {
                        Boolean test = false;
                        if (ViewBag.AgentPermission.Contains(item))
                        {
                            test = true;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-check\">\r\n                            <input class=\"form-check-input\" name=\"AreChecked\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1554, "\"", 1580, 1);
#nullable restore
#line 38 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
WriteAttributeValue("", 1562, item.permissionId, 1562, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=", 1581, "", 1595, 1);
#nullable restore
#line 38 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
WriteAttributeValue("", 1590, test, 1590, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1659, "\"", 1685, 1);
#nullable restore
#line 39 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
WriteAttributeValue("", 1665, item.permissionName, 1665, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
#nullable restore
#line 40 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
                           Write(item.permissionName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </label>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 44 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"hidden\" name=\"agentId\"");
                BeginWriteAttribute("value", " value=\"", 1893, "\"", 1910, 1);
#nullable restore
#line 45 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
WriteAttributeValue("", 1901, Model.Id, 1901, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"agentMail\"");
                BeginWriteAttribute("value", " value=\"", 1973, "\"", 1993, 1);
#nullable restore
#line 46 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
WriteAttributeValue("", 1981, Model.Email, 1981, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"dx-btn-dark \">Click</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n");
            WriteLiteral("\r\n    <div class=\"tab-pane fade show active\" id=\"nav-profile\" role=\"tabpanel\" aria-labelledby=\"nav-profile-tab\">\r\n\r\n        ");
#nullable restore
#line 60 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Admin\EditAgentPermission.cshtml"
   Write(await Component.InvokeAsync("UpdateUserInfo" ,@Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("; \r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Entities.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
