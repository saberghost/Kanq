using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kanq.IBLL;
using Kanq.Common;
using Kanq.WebApp.Models;
using Kanq.Model.Search;

namespace Kanq.WebApp.Controllers
{
    public class YGDBPXMController : Controller
    {
        public ID_RECService D_RECService { get; set; }
        public ITBL_TDGY_HBJDSService TBL_TDGY_HBJDSService { get; set; }
        public ITBL_TDTJBG_HTJBXXService TBL_TDTJBG_HTJBXXService { get; set; }
        public ITBL_HBGYTDSYQ_QBSPD_ZBService TBL_HBGYTDSYQ_QBSPD_ZBService { get; set; }

        /// <summary>
        /// 加载已供地报批项目列表
        /// </summary>
        public ActionResult ShowList(YgdbpxmSearch ygdbpxmSearch)
        {
            ygdbpxmSearch.PageIndex = Convert.ToInt32(Request["page"]);
            ygdbpxmSearch.PageSize = Convert.ToInt32(Request["rows"]);
            var list = D_RECService.LoadSerachEntities(ygdbpxmSearch);
            return Content(SerializeHelper.SerializeToList(ygdbpxmSearch.TotalCount, list).Callback());
        }

        /// <summary>
        /// 加载供应情况列表
        /// </summary>
        public ActionResult ShowGyqkList(string BPSLH)
        {
            var list = TBL_HBGYTDSYQ_QBSPD_ZBService.loadGyqkData(BPSLH).ToList();
            return Content(SerializeHelper.SerializeToList(list).Callback());
        }

        /// <summary>
        /// 展示报批项目数据
        /// </summary>
        public ActionResult ShowBpxmData(string GY_BPID)
        {
            var list = TBL_HBGYTDSYQ_QBSPD_ZBService.LoadEntities(t => t.GY_BPID.Equals(GY_BPID)).
                Select(t => new
                {
                    BPSLH = t.BPSLH,
                    PCMC = t.PCMC,
                    GDMJ = t.GDMJ
                });
            return Content(SerializeHelper.SerializeToList(list).Callback());
        }

        /// <summary>
        /// 获取报批项目查询数据
        /// </summary>
        public ActionResult GetQueryData(string BPSLH)
        {
            var model = D_RECService.GetEntity(BPSLH);
            return Content(SerializeHelper.SerializeToString(model).Callback());
        }


        /// <summary>
        /// 加载划拨决定书数据
        /// </summary>
        public ActionResult loadHbjdsData(HbjdsSearch hbjdsSearch)
        {
            hbjdsSearch.PageIndex = Convert.ToInt32(Request["page"]);
            hbjdsSearch.PageSize = Convert.ToInt32(Request["rows"]);
            var list = D_RECService.loadHbjdsData(hbjdsSearch);
            return Content(SerializeHelper.SerializeToList(hbjdsSearch.TotalCount, list).Callback());
        }

        /// <summary>
        /// 加载出让合同数据
        /// </summary>
        public ActionResult loadCrhtData(CrhtSearch crhtSearch)
        {
            crhtSearch.PageIndex = Convert.ToInt32(Request["page"]);
            crhtSearch.PageSize = Convert.ToInt32(Request["rows"]);
            var list = D_RECService.loadCrhtData(crhtSearch);
            return Content(SerializeHelper.SerializeToList(crhtSearch.TotalCount, list).Callback());
        }

        /// <summary>
        /// 展示划拨决定书详细数据
        /// </summary>
        public ActionResult ShowHbjdsDetail(string HBJDSID)
        {
            var model = TBL_TDGY_HBJDSService.LoadEntities(t => t.HBJDSID.Equals(HBJDSID)).FirstOrDefault();
            return Content(SerializeHelper.SerializeToString(model).Callback());
        }


        /// <summary>
        /// 展示出让合同详细数据
        /// </summary>
        public ActionResult ShowCrhtDetail(string HTJBXXID)
        {
            var model = TBL_TDTJBG_HTJBXXService.LoadEntities(t => t.HTJBXXID.Equals(HTJBXXID)).FirstOrDefault();
            return Content(SerializeHelper.SerializeToString(model).Callback());
        }
    }
}