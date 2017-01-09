using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IDAL
{
    public partial interface IDBSession
    {
        ID_RECDal D_RECDal { get; set; }
        IOA2_FINSTDal OA2_FINSTDal { get; set; }
        ITBL_GZMXBDal TBL_GZMXBDal { get; set; }
        ITBL_GZMXB_LOGDal TBL_GZMXB_LOGDal { get; set; }
        ITBL_GZMXB_TJDal TBL_GZMXB_TJDal { get; set; }
        ITBL_HBGYTDSYQ_QBSPDDal TBL_HBGYTDSYQ_QBSPDDal { get; set; }
        ITBL_HBGYTDSYQ_QBSPD_ZBDal TBL_HBGYTDSYQ_QBSPD_ZBDal { get; set; }
        ITBL_JSYDBP_BCGDDJK_DETAILDal TBL_JSYDBP_BCGDDJK_DETAILDal { get; set; }
        ITBL_JSYDBP_BCGDDJK_ZB1Dal TBL_JSYDBP_BCGDDJK_ZB1Dal { get; set; }
        ITBL_JSYDBP_BCGDDJK_ZB2Dal TBL_JSYDBP_BCGDDJK_ZB2Dal { get; set; }
        ITBL_SJSLDDal TBL_SJSLDDal { get; set; }
        ITBL_TDFHDJ_BPPDDal TBL_TDFHDJ_BPPDDal { get; set; }
        ITBL_TDFHDJ_BPPD_ZBDal TBL_TDFHDJ_BPPD_ZBDal { get; set; }
        ITBL_TDGY_HBJDSDal TBL_TDGY_HBJDSDal { get; set; }
        ITBL_TDTJBG_HTJBXXDal TBL_TDTJBG_HTJBXXDal { get; set; }
        ITBL_ZDCQ_HFZFHBBTDal TBL_ZDCQ_HFZFHBBTDal { get; set; }
        ITBL_ZDCQ_ZFHBBTDal TBL_ZDCQ_ZFHBBTDal { get; set; }
    }
}