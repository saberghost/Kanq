using Kanq.IBLL;
using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.BLL
{
    public partial class TBL_HBGYTDSYQ_QBSPD_ZBService : BaseService<TBL_HBGYTDSYQ_QBSPD_ZB>, ITBL_HBGYTDSYQ_QBSPD_ZBService
    {
        public IQueryable<object> loadGyqkData(string BPSLH)
        {
            var list = from a in LoadEntities(t => true)
                       join b in CurrentDBSession.TBL_TDTJBG_HTJBXXDal.LoadEntities(t => true)
                       on a.GY_BPID equals b.HTJBXXID
                       join c in CurrentDBSession.TBL_HBGYTDSYQ_QBSPDDal.LoadEntities(t => true)
                       on a.QBSPDID equals c.QBSPDID
                       join d in CurrentDBSession.D_RECDal.LoadEntities(t => true)
                       on a.GY_BPID equals d.SLID
                       join e in CurrentDBSession.TBL_TDGY_HBJDSDal.LoadEntities(t => true)
                       on d.HBJDSID equals e.HBJDSID
                       where !string.IsNullOrEmpty(a.BPSLH) && a.BPSLH.Equals(BPSLH)
                       select new
                       {
                           a.QBSPDID,
                           a.GY_BPID,
                           a.BPSLH,
                           b.ZDBH,
                           b.XMMC,
                           b.PZWH,
                           a.GDMJ,
                           c.TDGYFS,
                           d.HBJDSID,
                           PZWHHB = e.PZWH
                       };
            return list;
        }
    }
}
