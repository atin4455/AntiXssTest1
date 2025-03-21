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

        public static MvcHtmlString SanitizedRaw(this HtmlHelper htmlHelper, object input) //擴充方法
        {
            return MvcHtmlString.Create(_sanitizer.Sanitize(input as string ?? ""));
        }

        public static MvcHtmlString CustomRaw(this HtmlHelper htmlHelper, object input)
        {
            // 檢查 input 是否為 null，並轉換為字串
            string content = input as string ?? "";

            // 返回 MvcHtmlString，讓它在視圖中直接渲染 HTML
            return MvcHtmlString.Create(content);
        }
    }
}