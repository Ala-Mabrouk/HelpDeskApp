#pragma checksum "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\Notification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1229e7fa0f62056268567d4f5927c575ebf61c82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Notification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Notification/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1229e7fa0f62056268567d4f5927c575ebf61c82", @"/Views/Shared/Components/Notification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Notification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<style>
    .someImg {
        height: 22vmin;
        margin-left: -30%;
    }

    .profile {
        display: inline-block;
        width: 22vmin;
        height: 22vmin;
        border-radius: 50%;
        overflow: hidden;
        position: absolute;
        left: -16vmin;
        top: -1vmin;
        border: 1vmin solid #fff;
    }

    .message {
        background: #ffe271;
        padding: 2vmin 5vmin 2vmin 2vmin;
        border-radius: 0px 50px 50px 0px;
        font-size: 3vmin;
        text-align: left;
    }

    .user {
        text-align: left;
        padding: 2px 30px 5px 10px;
        border-radius: 0px 0px 20px;
        font-size: 3.2vmin;
        background: #fff;
        color: #83aebd;
        display: inline-block;
        float: left;
        font-weight: 600;
        font-style: normal;
    }





</style>



");
#nullable restore
#line 51 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\Notification\Default.cshtml"
 if (ViewBag.notifications != null)
{
     

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\Notification\Default.cshtml"
      foreach (var item in ViewBag.notifications)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"dropdown-item waves-effect waves-light\" href=\"#\">\r\n\r\n\r\n\r\n    <div style=\"width:min-content;\">\r\n        \r\n        <div class=\"message\">\r\n            ");
#nullable restore
#line 62 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\Notification\Default.cshtml"
       Write(item.notificationContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"user\">\r\n\r\n            ");
#nullable restore
#line 67 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\Notification\Default.cshtml"
       Write(item.notificationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n</a>\r\n");
#nullable restore
#line 73 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\Notification\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\Notification\Default.cshtml"
         
  
  
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a class=\"dropdown-item waves-effect waves-light\" href=\"#\">No notifications</a>\r\n    <a class=\"dropdown-item waves-effect waves-light\" href=\"#\">No notifications</a>\r\n    <a class=\"dropdown-item waves-effect waves-light\" href=\"#\">No notifications</a>\r\n");
#nullable restore
#line 83 "C:\Users\worrior107\source\repos\HelpDeskApp\HelpDesk\Views\Shared\Components\Notification\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
