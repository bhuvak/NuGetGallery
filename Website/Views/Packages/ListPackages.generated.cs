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

namespace NuGetGallery.Views.Packages
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Packages/ListPackages.cshtml")]
    public class ListPackages : System.Web.Mvc.WebViewPage<PackageListViewModel>
    {
        public ListPackages()
        {
        }
        public override void Execute()
        {


            
            #line 2 "..\..\Views\Packages\ListPackages.cshtml"
  
    ViewBag.Tab = "Packages";


            
            #line default
            #line hidden
WriteLiteral("<div id=\"layout-before-main\" class=\"group\">\r\n    <section id=\"currentPageToolbar\"" +
">\r\n        <div class=\"zone zone-before-main\">\r\n            <form id=\"search-fil" +
"ter-form\" action=\"");


            
            #line 8 "..\..\Views\Packages\ListPackages.cshtml"
                                             Write(Url.Current());

            
            #line default
            #line hidden
WriteLiteral("\" method=\"get\">\r\n                ");



WriteLiteral("\r\n                <input type=\"hidden\" name=\"q\" value=\"");


            
            #line 10 "..\..\Views\Packages\ListPackages.cshtml"
                                                Write(Model.SearchTerm);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n                <div id=\"sort\">\r\n                    <label>Sort</label>\r\n " +
"                   <select name=\"sortOrder\" id=\"sortOrder\">\r\n                   " +
"     ");


            
            #line 14 "..\..\Views\Packages\ListPackages.cshtml"
                   Write(ViewHelpers.Option("package-title", "A-Z", Model.SortOrder));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        ");


            
            #line 15 "..\..\Views\Packages\ListPackages.cshtml"
                   Write(ViewHelpers.Option("package-download-count", "Popularity", Model.SortOrder));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        ");


            
            #line 16 "..\..\Views\Packages\ListPackages.cshtml"
                   Write(ViewHelpers.Option("package-created", "Recent", Model.SortOrder));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </form>\r\n   " +
"     </div>\r\n    </section>\r\n</div>\r\n\r\n<div id=\"layout-main\" class=\"group\">\r\n   " +
" <div id=\"layout-content\" class=\"group\">\r\n");


            
            #line 26 "..\..\Views\Packages\ListPackages.cshtml"
         if (TempData.ContainsKey("Message")) {

            
            #line default
            #line hidden
WriteLiteral("            <div id=\"messages\">\r\n                <div class=\"zone zone-messages\">" +
"\r\n                    <div class=\"message message-Information\">");


            
            #line 29 "..\..\Views\Packages\ListPackages.cshtml"
                                                        Write(TempData["Message"]);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");


            
            #line 32 "..\..\Views\Packages\ListPackages.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div id=\"content\" class=\"group\">\r\n            <div class=\"zone zone-con" +
"tent\">\r\n                <section>\r\n                    <header>\r\n               " +
"         <h2><span>");


            
            #line 38 "..\..\Views\Packages\ListPackages.cshtml"
                             Write(Model.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results for </span>Packages</h2>\r\n");


            
            #line 39 "..\..\Views\Packages\ListPackages.cshtml"
                         if (Model.Items.Count() > 0) {

            
            #line default
            #line hidden
WriteLiteral("                            <span class=\"displayResults\">Displaying results ");


            
            #line 40 "..\..\Views\Packages\ListPackages.cshtml"
                                                                       Write(Model.FirstResultIndex);

            
            #line default
            #line hidden
WriteLiteral(" - ");


            
            #line 40 "..\..\Views\Packages\ListPackages.cshtml"
                                                                                                 Write(Model.LastResultIndex);

            
            #line default
            #line hidden
WriteLiteral(".</span>\r\n");


            
            #line 41 "..\..\Views\Packages\ListPackages.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </header>\r\n                    <ul>\r\n");


            
            #line 44 "..\..\Views\Packages\ListPackages.cshtml"
                         foreach (var listPackage in Model.Items) {

            
            #line default
            #line hidden
WriteLiteral("                            <li class=\"first\">\r\n                                ");


            
            #line 46 "..\..\Views\Packages\ListPackages.cshtml"
                           Write(Html.Partial(MVC.Packages.Views._ListPackage, listPackage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </li>\r\n");


            
            #line 48 "..\..\Views\Packages\ListPackages.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                    <div id=\"pagination\">\r\n           " +
"             ");


            
            #line 51 "..\..\Views\Packages\ListPackages.cshtml"
                   Write(ViewHelpers.PreviousNextPager(Model.Pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </section>\r\n            </div>\r\n   " +
"     </div>\r\n    </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
