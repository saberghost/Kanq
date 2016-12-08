using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanq.WebApp.Models
{
    public static class DicStorages
    {
        static DicStorages()
        {
            DicList = new List<Dic>
            {
                new Dic {Type="项目类型",Key="1",Value="城市分批次" },
                new Dic {Type="项目类型",Key="2",Value="单独选址" },
                new Dic {Type="项目类型",Key="3",Value="城市用地" }
            };
        }
        public static IEnumerable<Dic> DicList { get; set; }
    }

    public class Dic
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }
}