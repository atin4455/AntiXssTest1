using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ganss.Xss;

namespace AntiXssTest.Models
{
    public static class HtmlSanitizerExtensions
    {
        private static readonly HtmlSanitizer _sanitizer = new HtmlSanitizer();

        public static MvcHtmlString SanitizedRaw(this HtmlHelper htmlHelper, string input)
        {
            return MvcHtmlString.Create(_sanitizer.Sanitize(input ?? ""));
        }
    }
}