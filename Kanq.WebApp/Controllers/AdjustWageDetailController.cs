using Kanq.Common;
using Kanq.IBLL;
using Kanq.Model;
using Kanq.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanq.WebApp.Controllers
{
    public class AdjustWageDetailController : Controller
    {
        public ITBL_GZMXBService TBL_GZMXBService { get; set; }
        public ITBL_GZMXB_LOGService TBL_GZMXB_LOGService { get; set; }
        public ITBL_GZMXB_TJService TBL_GZMXB_TJService { get; set; }

        /// <summary>
        /// 加薪提示表列表展示
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="txtBM"></param>
        /// <returns></returns>
        public ActionResult ShowAdjust(int page,int rows,string txtBM)
        {
            int total;
            List<TBL_GZMXB> list = TBL_GZMXBService.GetPageListEx(page, rows, txtBM, out total);
            return Content(SerializeHelper.SerializeToList(total, list).Callback());
        }

        /// <summary>
        /// 加薪提示表执行加工资
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public ActionResult Define(string data)
        {
            List<TBL_GZMXB_PARTIAL> list = SerializeHelper.DeserializeToObject<List<TBL_GZMXB_PARTIAL>>(data);
            foreach (TBL_GZMXB_PARTIAL item in list)
            {
                TBL_GZMXB model = TBL_GZMXBService.LoadEntities(t=>t.ID==item.ID).FirstOrDefault();
                TBL_GZMXB_TJ tjModel = TBL_GZMXB_TJService.LoadEntities(t => t.MID == item.ID).OrderByDescending(t => t.TJRQ).FirstOrDefault();
                if (!(item.BYXZJBGZ == null && item.BYXZGWGZ == null))
                {
                    TBL_GZMXB_LOG logModel = new TBL_GZMXB_LOG()
                    {
                        ID = TBL_GZMXB_LOGService.GetMaxId("ID", "TBL_GZMXB_LOG"),
                        XM = model.XM,
                        BZ = model.BZ,
                        MID = model.ID,
                        JBGZ = model.JBGZ,
                        GWGZ = model.GWGZ,
                        JTBZ = model.JTBZ,
                        HSBZ = model.HSBZ,
                        HJ = Convert.ToDecimal(model.HJ) + Convert.ToDecimal(item.BYXZJBGZ) + Convert.ToDecimal(item.BYXZGWGZ),
                        BYXZJBGZ = item.BYXZJBGZ,
                        BYXZGWGZ = item.BYXZGWGZ,
                        ZXSJ = DateTime.Now
                    };
                    TBL_GZMXB_LOGService.AddEntity(logModel);
                }
                model.BYXZJBGZ = item.BYXZJBGZ;
                model.BYXZGWGZ = item.BYXZGWGZ;
                model.FLAG = item.YEARLESS;
                model.ZXSJ = DateTime.Now;
                if (model.JBGZ == null)
                {
                    model.JBGZ = item.BYXZJBGZ;
                }
                else
                {
                    if (item.BYXZJBGZ != null)
                    {
                        model.JBGZ += item.BYXZJBGZ;
                    }
                }
                if (model.GWGZ == null)
                {
                    model.GWGZ = item.BYXZGWGZ;
                }
                else
                {
                    if (item.BYXZGWGZ != null)
                    {
                        model.GWGZ += item.BYXZGWGZ;
                    }
                }
                decimal? sum = 0;
                if (model.JBGZ != null)
                {
                    sum += model.JBGZ;
                }
                if (model.GWGZ != null)
                {
                    sum += model.GWGZ;
                }
                if (model.HSBZ != null)
                {
                    sum += model.HSBZ;
                }
                if (model.JTBZ != null)
                {
                    sum += model.JTBZ;
                }
                if (sum == 0)
                {
                    sum = null;
                }
                model.HJ = sum;
                TBL_GZMXBService.EditEntity(model);
                EntityHelper.EntityToEntity(model, tjModel, "ID", "TJRQ", "MID");
                TBL_GZMXB_TJService.EditEntity(tjModel);
            }
            return Content(SerializeHelper.SerializeToString(new { success = "ok" }).Callback());
        }
    }
}