using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.Common
{
    public class SerializeHelper
    {
        /// <summary>
        /// 对数据进行序列化
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SerializeToString(object value)
        {
            IsoDateTimeConverter timeFormat = new IsoDateTimeConverter();
            timeFormat.DateTimeFormat = "yyyy-MM-dd";
            return JsonConvert.SerializeObject(value, Formatting.Indented, timeFormat);
        }

        /// <summary>
        /// 对数据列表进行序列化
        /// </summary>
        public static string SerializeToList<T>(int total, IEnumerable<T> rows)
        {
            IsoDateTimeConverter timeFormat = new IsoDateTimeConverter();
            timeFormat.DateTimeFormat = "yyyy-MM-dd";
            return JsonConvert.SerializeObject(new { total = total, rows = rows }, Formatting.Indented, timeFormat);
        }

        /// <summary>
        /// 对数据列表进行序列化
        /// </summary>
        public static string SerializeToList<T>(IEnumerable<T> rows)
        {
            IsoDateTimeConverter timeFormat = new IsoDateTimeConverter();
            timeFormat.DateTimeFormat = "yyyy-MM-dd";
            return JsonConvert.SerializeObject(rows, Formatting.Indented, timeFormat);
        }

        /// <summary>
        /// 反序列化操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T DeserializeToObject<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
