﻿using HowManyDaysTil.Web.Models;

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HowManyDaysTil.Web.Views.Home
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/EditEvent.cshtml")]
    public partial class EditEvent : System.Web.Mvc.WebViewPage<EditEventViewModel>
    {
        public EditEvent()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">×</a>\r\n    <h3>Edit Event</h3>\r\n</div>\r\n<div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Views\Home\EditEvent.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Home\EditEvent.cshtml"
     using (Html.BeginForm("EditEvent", "Home", FormMethod.Post))
    {

            
            #line default
            #line hidden
WriteLiteral("        <fieldset>\r\n            <div");

WriteLiteral(" class=\"control-group\"");

WriteLiteral(">\r\n                <!-- Username -->\r\n                <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(" for=\"Name\"");

WriteLiteral(">Name</label>\r\n                <div");

WriteLiteral(" class=\"controls\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 14 "..\..\Views\Home\EditEvent.cshtml"
               Write(Html.TextBoxFor(m => m.CalendarEvent.Name, new { @class = "input-xlarge", @required = "required" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"control-group\"");

WriteLiteral(">\r\n                <!-- E-mail -->\r\n                <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(" for=\"CalendarEventDate\"");

WriteLiteral(">Date</label>\r\n                <div");

WriteLiteral(" class=\"controls\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 21 "..\..\Views\Home\EditEvent.cshtml"
               Write(Html.TextBoxFor(m => m.CalendarEvent.CalendarEventDate, new { @Value = (String.Format("{0:MM/dd/yyyy}", Model.CalendarEvent.CalendarEventDate)), @class = "input-xlarge editDatepicker", @readonly = "readonly"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    \r\n                </div>\r\n            </div>\r\n        <div");

WriteLiteral(" class=\"control-group\"");

WriteLiteral(">\r\n            <!-- Button -->\r\n            <div");

WriteLiteral(" class=\"controls\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Home\EditEvent.cshtml"
           Write(Html.HiddenFor(m => m.CalendarEvent.CalendarEventId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <button");

WriteLiteral(" class=\"btn btn-success\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">Save</button>\r\n            </div>\r\n        </div>\r\n            </fieldset>\r\n");

            
            #line 33 "..\..\Views\Home\EditEvent.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"btn\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">Close</a>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591