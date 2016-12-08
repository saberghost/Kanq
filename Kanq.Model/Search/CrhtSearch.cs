using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.Model.Search
{
    public class CrhtSearch:BaseSearch
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        public string XMMC { get; set; }

        /// <summary>
        /// 电子监管号
        /// </summary>
        public string DJGH { get; set; }

        /// <summary>
        /// 行政区
        /// </summary>
        public string SSXZ { get; set; }

        /// <summary>
        /// 宗地编号
        /// </summary>
        public string ZDBH { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        public string HTBH { get; set; }

        /// <summary>
        /// 土地用途
        /// </summary>
        public string TDYT { get; set; }
    }
}
