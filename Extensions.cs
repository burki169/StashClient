using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StashClient
{
    public static class Extensions
    {
        public static string EnsureEndsWithForwardSlash(this string str)
        {
            return str.EndsWith("/") ? str : str + "/";
        }
    }
}
