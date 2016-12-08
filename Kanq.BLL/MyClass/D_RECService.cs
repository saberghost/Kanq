using Kanq.IBLL;
using Kanq.Model;
using Kanq.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.BLL
{
    public partial class D_RECService : BaseService<D_REC>, ID_RECService
    {
        /// <summary>
        /// 加载已供地报批项目数据
        /// </summary>
        public IQueryable<object> LoadSerachEntities(YgdbpxmSearch ygdbpxmSearch)
        {
            var temp = from a in LoadEntities(t => true)
                       join b in CurrentDBSession.TBL_TDFHDJ_BPPDDal.LoadEntities(t => true)
                       on a.SLID equals b.ID
                       join c in CurrentDBSession.TBL_SJSLDDal.LoadEntities(t => true)
                       on a.SJSLDID equals c.SJSLDID
                       join d in CurrentDBSession.OA2_FINSTDal.LoadEntities(t => true)
                       on a.SLID equals d.FI_INST
                       where d.FI_STATE == 1
                       select new
                       {
                           a.SLID,
                           c.SSXZ,
                           b.XMMC,
                           b.ZMJ,
                           b.XMLX,
                           b.PZWH,
                           b.PZRQ,
                           b.PZDW,
                           b.GWYPFWH,
                           b.GWYPFRQ,
                           b.GWYPFBSMJ,
                           b.JSXMBH
                       };
            if (!string.IsNullOrEmpty(ygdbpxmSearch.SSXZ))
            {
                temp = temp.Where(t => t.SSXZ.Contains(ygdbpxmSearch.SSXZ));
            }
            if (!string.IsNullOrEmpty(ygdbpxmSearch.XMMC))
            {
                temp = temp.Where(t => t.XMMC.Contains(ygdbpxmSearch.XMMC));
            }
            if (!string.IsNullOrEmpty(ygdbpxmSearch.PZWH))
            {
                temp = temp.Where(t => t.PZWH.Contains(ygdbpxmSearch.PZWH));
            }
            ygdbpxmSearch.TotalCount = temp.Count();
            return temp.OrderBy(u => u.SLID).Skip((ygdbpxmSearch.PageIndex - 1) * ygdbpxmSearch.PageSize).Take(ygdbpxmSearch.PageSize);
        }

        public object GetEntity(string slid)
        {
            var Entity = LoadEntities(t => true).
                Join(new TBL_TDFHDJ_BPPDService().LoadEntities(t => true), t1 => t1.SLID, t2 => t2.ID,
                (t1, t2) => new
                {
                    t1 = t1,
                    t2 = t2
                }).
                Join(new TBL_SJSLDService().LoadEntities(t => true), a1 => a1.t1.SJSLDID, a2 => a2.SJSLDID,
                (a1, a2) => new
                {
                    SLID = a1.t1.SLID,
                    SSXZ = a2.SSXZ,
                    XMMC = a1.t2.XMMC,
                    ZMJ = a1.t2.ZMJ,
                    XMLX = a1.t2.XMLX,
                    PZWH = a1.t2.PZWH,
                    PZRQ = a1.t2.PZRQ,
                    PZDW = a1.t2.PZDW,
                    GWYPFWH = a1.t2.GWYPFWH,
                    GWYPFRQ = a1.t2.GWYPFRQ,
                    GWYPFBSMJ = a1.t2.GWYPFBSMJ
                }).
                Where(t => t.SLID.Equals(slid)).FirstOrDefault();
            return Entity;
        }

        /// <summary>
        /// 加载划拨决定书数据
        /// </summary>
        public IQueryable<object> loadHbjdsData(HbjdsSearch hbjdsSearch)
        {
            var temp = from a in LoadEntities(t => true)
                       join b in CurrentDBSession.TBL_TDGY_HBJDSDal.LoadEntities(t => true)
                       on a.HBJDSID equals b.HBJDSID
                       join c in CurrentDBSession.TBL_SJSLDDal.LoadEntities(t => true)
                       on a.SJSLDID equals c.SJSLDID
                       select new
                       {
                           a.SLID,
                           c.SSXZ,
                           b.DZJGH,
                           b.PZWH,
                           b.ZDYT,
                           b.HBZDMJ,
                           b.HBJK,
                           b.HBJDSWH,
                           b.ZDBH,
                           b.HBJDSID,
                           b.HBJDSQDSJ
                       };
            if (!string.IsNullOrEmpty(hbjdsSearch.HBJDSWH))
            {
                temp = temp.Where(t => t.HBJDSWH.Contains(hbjdsSearch.HBJDSWH));
            }
            if (!string.IsNullOrEmpty(hbjdsSearch.DZJGH))
            {
                temp = temp.Where(t => t.DZJGH.Contains(hbjdsSearch.DZJGH));
            }
            if (!string.IsNullOrEmpty(hbjdsSearch.SSXZ))
            {
                temp = temp.Where(t => t.SSXZ.Contains(hbjdsSearch.SSXZ));
            }
            if (!string.IsNullOrEmpty(hbjdsSearch.ZDBH))
            {
                temp = temp.Where(t => t.ZDBH.Contains(hbjdsSearch.ZDBH));
            }
            hbjdsSearch.TotalCount = temp.Count();
            return temp.OrderBy(u => u.SLID).Skip((hbjdsSearch.PageIndex - 1) * hbjdsSearch.PageSize).Take(hbjdsSearch.PageSize);
        }

        /// <summary>
        /// 加载出让合同数据
        /// </summary>
        public IQueryable<object> loadCrhtData(CrhtSearch crhtSearch)
        {
            var temp = from a in LoadEntities(t => true)
                       join b in CurrentDBSession.TBL_TDTJBG_HTJBXXDal.LoadEntities(t => true)
                       on a.SLID equals b.HTJBXXID
                       join c in CurrentDBSession.TBL_SJSLDDal.LoadEntities(t => true)
                       on a.SJSLDID equals c.SJSLDID
                       select new
                       {
                           a.SLID,
                           c.SSXZ,
                           b.DJGH,
                           b.HTBH,
                           b.SRDW,
                           b.TDYT,
                           b.CRMJ,
                           b.CRJKDJ,
                           b.HTQDSJ,
                           b.XMMC,
                           b.ZDBH
                       };
            if (!string.IsNullOrEmpty(crhtSearch.XMMC))
            {
                temp = temp.Where(t => t.XMMC.Contains(crhtSearch.XMMC));
            }
            if (!string.IsNullOrEmpty(crhtSearch.DJGH))
            {
                temp = temp.Where(t => t.DJGH.Contains(crhtSearch.DJGH));
            }
            if (!string.IsNullOrEmpty(crhtSearch.SSXZ))
            {
                temp = temp.Where(t => t.SSXZ.Contains(crhtSearch.SSXZ));
            }
            if (!string.IsNullOrEmpty(crhtSearch.ZDBH))
            {
                temp = temp.Where(t => t.ZDBH.Contains(crhtSearch.ZDBH));
            }
            if (!string.IsNullOrEmpty(crhtSearch.HTBH))
            {
                temp = temp.Where(t => t.HTBH.Contains(crhtSearch.HTBH));
            }
            if (!string.IsNullOrEmpty(crhtSearch.TDYT))
            {
                temp = temp.Where(t => t.TDYT.Contains(crhtSearch.TDYT));
            }
            crhtSearch.TotalCount = temp.Count();
            return temp.OrderBy(u => u.SLID).Skip((crhtSearch.PageIndex - 1) * crhtSearch.PageSize).Take(crhtSearch.PageSize);
        }
    }
}