using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kanq.IBLL;
using Kanq.Model.ViewModel;
using Kanq.Common;

namespace Kanq.WebApp.Controllers
{
    public class FwcqBcHzbController : Controller
    {
        public  IFwcqHzService FwcqHzService { get; set; }
        // GET: FwcqBcHzb
        public ActionResult Index(int rows, int page)
        {
            string T1 = Request["txtName"];
            string T2 = Request["txtIDCard"];
            List<string> list = new List<string>();
            if (!string.IsNullOrEmpty(T1))
            {
                list.Add($"T1 like '%{T1}%'");
            }
            if (!string.IsNullOrEmpty(T2))
            {
                list.Add($"T5 like '%{T2}%'");
            }
            string strWhere = "";
            if (list.Count > 0)
            {
                strWhere = string.Join(" and ", list);
            }
            int total;
            var modelList=FwcqHzService.GetListByPage(strWhere, "", out total, page, rows);
            return Content(SerializeHelper.SerializeToList(total,modelList).Callback());
        }
    }
}