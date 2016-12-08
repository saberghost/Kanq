using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Kanq.Common
{
    public static class Extended
    {
        public static string Callback(this string str)
        {
            string callback = HttpContext.Current.Request["callback"];
            if (callback != null)
            {
                str = callback + "(" + str + ")";
            }
            return str;
        }
    }
}
