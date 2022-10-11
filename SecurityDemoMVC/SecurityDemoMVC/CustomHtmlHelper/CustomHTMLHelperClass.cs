using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityDemoMVC.CustomHtmlHelper
{
    public static class CustomHTMLHelperClass
    {
        static IEnumerable<SecurityDemoMVC.Employee> model;
        public static MvcHtmlString CreateLabel(this HtmlHelper obj, string content)
        {
            string customLabel = "<label style='background: orange; colow: white'>" + content + "</label>";
            return new MvcHtmlString(customLabel);
        }

        public static MvcHtmlString CreateInput(this HtmlHelper obj)
        {
            string customInput = "<input type='text'> /";
            return new MvcHtmlString(customInput);
        }

        public static MvcHtmlString CreateInputValue(this HtmlHelper obj, string content)
        {
            string customInput = "<input type='text' value='" + content + "' />";
            return new MvcHtmlString(customInput);
        }

        public static MvcHtmlString CreateHr(this HtmlHelper obj)
        {
            string custombr = "<br />";
            return new MvcHtmlString(custombr);
        }
    }
}