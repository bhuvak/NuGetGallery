﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Users
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Microsoft.Web.Helpers;
    using NuGetGallery;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Users/PasswordChanged.cshtml")]
    public class PasswordChanged : System.Web.Mvc.WebViewPage<dynamic>
    {
        public PasswordChanged()
        {
        }
        public override void Execute()
        {

            
            #line 1 "..\..\Views\Users\PasswordChanged.cshtml"
  
    Layout = "~/Views/Shared/TwoColumnLayout.cshtml";


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("LeftNav", () => {

WriteLiteral("\r\n    <img src=\"");


            
            #line 6 "..\..\Views\Users\PasswordChanged.cshtml"
         Write(Links.Content.Images.newAccountGraphic_png);

            
            #line default
            #line hidden
WriteLiteral("\" style=\"padding-left:50px\" alt=\"New Account Image\"/>\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("ContentHeader", () => {

WriteLiteral("\r\n    <h2>Password changed!</h2>\r\n");


});

WriteLiteral("\r\n\r\n<div class=\"description\">\r\n    <p>\r\n        Don&#8217;t forget to use your ne" +
"w password the next time you \r\n        <a href=\"");


            
            #line 16 "..\..\Views\Users\PasswordChanged.cshtml"
            Write(Url.LogOn());

            
            #line default
            #line hidden
WriteLiteral("\">log on</a>. \r\n    </p>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
