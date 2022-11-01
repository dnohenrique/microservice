using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.ExtensionMethod
{
    public static class FormatDocument
    {
        public static string FormatCNPJNoAccent(this string value)
        {
            return value.Replace(".", "").Replace("/", "").Replace("-", "");
        }
    }
}
