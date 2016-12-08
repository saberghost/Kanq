using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.Model.Search
{
    public class HbjdsSearch:BaseSearch
    {
        /// <summary>
        /// 划拨编号
        /// </summary>
        public string HBJDSWH { get; set; }

        /// <summary>
        /// 电子监管号
        /// </summary>
        public string DZJGH { get; set; }

        /// <summary>
        /// 行政区
        /// </summary>
        public string SSXZ { get; set; }

        /// <summary>
        /// 宗地编号
        /// </summary>
        public string ZDBH { get; set; }
    }
}
