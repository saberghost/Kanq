using Kanq.DAL;
using Kanq.IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.DALFactory
{
    public partial class DBSession : IDBSession
    {
        public ID_RECDal D_RECDal { get; set; } = SpringNetHelper.GetObject<D_RECDal>("D_RECDal");
        public IOA2_FINSTDal OA2_FINSTDal { get; set; } = SpringNetHelper.GetObject<OA2_FINSTDal>("OA2_FINSTDal");
        public ITBL_GZMXBDal TBL_GZMXBDal { get; set; } = SpringNetHelper.GetObject<TBL_GZMXBDal>("TBL_GZMXBDal");
        public ITBL_GZMXB_LOGDal TBL_GZMXB_LOGDal { get; set; } = SpringNetHelper.GetObject<TBL_GZMXB_LOGDal>("TBL_GZMXB_LOGDal");
        public ITBL_GZMXB_TJDal TBL_GZMXB_TJDal { get; set; } = SpringNetHelper.GetObject<TBL_GZMXB_TJDal>("TBL_GZMXB_TJDal");
        public ITBL_HBGYTDSYQ_QBSPDDal TBL_HBGYTDSYQ_QBSPDDal { get; set; } = SpringNetHelper.GetObject<TBL_HBGYTDSYQ_QBSPDDal>("TBL_HBGYTDSYQ_QBSPDDal");
        public ITBL_HBGYTDSYQ_QBSPD_ZBDal TBL_HBGYTDSYQ_QBSPD_ZBDal { get; set; } = SpringNetHelper.GetObject<TBL_HBGYTDSYQ_QBSPD_ZBDal>("TBL_HBGYTDSYQ_QBSPD_ZBDal");
        public ITBL_JSYDBP_BCGDDJK_DETAILDal TBL_JSYDBP_BCGDDJK_DETAILDal { get; set; } = SpringNetHelper.GetObject<TBL_JSYDBP_BCGDDJK_DETAILDal>("TBL_JSYDBP_BCGDDJK_DETAILDal");
        public ITBL_JSYDBP_BCGDDJK_ZB1Dal TBL_JSYDBP_BCGDDJK_ZB1Dal { get; set; } = SpringNetHelper.GetObject<TBL_JSYDBP_BCGDDJK_ZB1Dal>("TBL_JSYDBP_BCGDDJK_ZB1Dal");
        public ITBL_JSYDBP_BCGDDJK_ZB2Dal TBL_JSYDBP_BCGDDJK_ZB2Dal { get; set; } = SpringNetHelper.GetObject<TBL_JSYDBP_BCGDDJK_ZB2Dal>("TBL_JSYDBP_BCGDDJK_ZB2Dal");
        public ITBL_SJSLDDal TBL_SJSLDDal { get; set; } = SpringNetHelper.GetObject<TBL_SJSLDDal>("TBL_SJSLDDal");
        public ITBL_TDFHDJ_BPPDDal TBL_TDFHDJ_BPPDDal { get; set; } = SpringNetHelper.GetObject<TBL_TDFHDJ_BPPDDal>("TBL_TDFHDJ_BPPDDal");
        public ITBL_TDFHDJ_BPPD_ZBDal TBL_TDFHDJ_BPPD_ZBDal { get; set; } = SpringNetHelper.GetObject<TBL_TDFHDJ_BPPD_ZBDal>("TBL_TDFHDJ_BPPD_ZBDal");
        public ITBL_TDGY_HBJDSDal TBL_TDGY_HBJDSDal { get; set; } = SpringNetHelper.GetObject<TBL_TDGY_HBJDSDal>("TBL_TDGY_HBJDSDal");
        public ITBL_TDTJBG_HTJBXXDal TBL_TDTJBG_HTJBXXDal { get; set; } = SpringNetHelper.GetObject<TBL_TDTJBG_HTJBXXDal>("TBL_TDTJBG_HTJBXXDal");
    }
}