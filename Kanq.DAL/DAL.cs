using Kanq.IDAL;
using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Kanq.DAL
{
    public partial class D_RECDal :BaseDal<D_REC>, ID_RECDal{}
    public partial class OA2_FINSTDal :BaseDal<OA2_FINST>, IOA2_FINSTDal{}
    public partial class TBL_GZMXBDal :BaseDal<TBL_GZMXB>, ITBL_GZMXBDal{}
    public partial class TBL_GZMXB_LOGDal :BaseDal<TBL_GZMXB_LOG>, ITBL_GZMXB_LOGDal{}
    public partial class TBL_GZMXB_TJDal :BaseDal<TBL_GZMXB_TJ>, ITBL_GZMXB_TJDal{}
    public partial class TBL_HBGYTDSYQ_QBSPDDal :BaseDal<TBL_HBGYTDSYQ_QBSPD>, ITBL_HBGYTDSYQ_QBSPDDal{}
    public partial class TBL_HBGYTDSYQ_QBSPD_ZBDal :BaseDal<TBL_HBGYTDSYQ_QBSPD_ZB>, ITBL_HBGYTDSYQ_QBSPD_ZBDal{}
    public partial class TBL_JSYDBP_BCGDDJK_DETAILDal :BaseDal<TBL_JSYDBP_BCGDDJK_DETAIL>, ITBL_JSYDBP_BCGDDJK_DETAILDal{}
    public partial class TBL_JSYDBP_BCGDDJK_ZB1Dal :BaseDal<TBL_JSYDBP_BCGDDJK_ZB1>, ITBL_JSYDBP_BCGDDJK_ZB1Dal{}
    public partial class TBL_JSYDBP_BCGDDJK_ZB2Dal :BaseDal<TBL_JSYDBP_BCGDDJK_ZB2>, ITBL_JSYDBP_BCGDDJK_ZB2Dal{}
    public partial class TBL_SJSLDDal :BaseDal<TBL_SJSLD>, ITBL_SJSLDDal{}
    public partial class TBL_TDFHDJ_BPPDDal :BaseDal<TBL_TDFHDJ_BPPD>, ITBL_TDFHDJ_BPPDDal{}
    public partial class TBL_TDFHDJ_BPPD_ZBDal :BaseDal<TBL_TDFHDJ_BPPD_ZB>, ITBL_TDFHDJ_BPPD_ZBDal{}
    public partial class TBL_TDGY_HBJDSDal :BaseDal<TBL_TDGY_HBJDS>, ITBL_TDGY_HBJDSDal{}
    public partial class TBL_TDTJBG_HTJBXXDal :BaseDal<TBL_TDTJBG_HTJBXX>, ITBL_TDTJBG_HTJBXXDal{}
}