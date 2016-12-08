using Kanq.Common;
using Kanq.IBLL;
using Kanq.Model;
using Kanq.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanq.WebApp.Controllers
{
    public class WageDetailController : Controller
    {
        public ITBL_GZMXBService TBL_GZMXBService { get; set; }
        public ITBL_GZMXB_LOGService TBL_GZMXB_LOGService { get; set; }

        /// <summary>
        /// 修改设置
        /// </summary>
        /// <param name="MAXCQ">拆迁中心最高工资</param>
        /// <param name="MAXQT">其他科室最高工资</param>
        public ActionResult SetEdit(string MAXCQ, string MAXQT)
        {
            ConfigHelper.Set("MAXCQ", MAXCQ);
            ConfigHelper.Set("MAXQT", MAXQT);
            return Content("ok");
        }

        /// <summary>
        /// 显示设置
        /// </summary>
        public ActionResult SetView()
        {
            string MAXCQ = ConfigHelper.Get("MAXCQ");
            string MAXQT = ConfigHelper.Get("MAXQT");
            return Content(SerializeHelper.SerializeToString(new { MAXCQ = MAXCQ, MAXQT = MAXQT }).Callback());
        }

        /// <summary>
        /// 基本工资表员工加薪历史记录查看
        /// </summary>
        /// <param name="MID"></param>
        /// <returns></returns>
        public ActionResult showLog(string MID)
        {
            var list = TBL_GZMXB_LOGService.LoadEntities(t => t.MID.Equals(MID)).OrderBy(t => t.ZXSJ);
            return Content(SerializeHelper.SerializeToString(list).Callback());
        }

        /// <summary>
        /// 基本工资表删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Remove(string ID)
        {
            var model = TBL_GZMXBService.LoadEntities(t => t.ID.Equals(ID)).FirstOrDefault();
            if (TBL_GZMXBService.DeleteEntity(model))
            {
                TBL_GZMXB_LOGService.DeleteEntitys(ID);
                return Content(SerializeHelper.SerializeToString(new { success = "ok" }).Callback());
            }
            else
            {
                return Content(SerializeHelper.SerializeToString(new { success = "no" }).Callback());
            }
        }

        /// <summary>
        /// 基本工资表编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Edit(TBL_GZMXB model)
        {
            TBL_GZMXBService.EditEntity(model);
            return Content("ok");
        }

        /// <summary>
        /// 基本工资表查看
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public new ActionResult View(string ID)
        {
            var model = TBL_GZMXBService.LoadEntities(t => t.ID.Equals(ID)).FirstOrDefault();
            return Content(SerializeHelper.SerializeToString(model).Callback());
        }

        /// <summary>
        /// 基本工资表增加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Add(TBL_GZMXB model)
        {
            int maxId = TBL_GZMXBService.GetMaxId("ID", "TBL_GZMXB");
            model.ID = maxId.ToString();
            TBL_GZMXBService.AddEntity(model);
            return Content("ok");
        }

        /// <summary>
        /// 基本工资表列表展示
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="page"></param>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public ActionResult ShowModify(int rows, int page, TBL_GZMXBSearch searchModel)
        {
            searchModel.PageIndex = page;
            searchModel.PageSize = rows;
            var list = TBL_GZMXBService.LoadSerachEntities(searchModel);
            return Content(SerializeHelper.SerializeToList(searchModel.TotalCount, list).Callback());
        }
    }
}