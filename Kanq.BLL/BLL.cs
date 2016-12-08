using Kanq.IBLL;
using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.BLL
{
    public partial class D_RECService : BaseService<D_REC>, ID_RECService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.D_RECDal;
        }
    }

    public partial class OA2_FINSTService : BaseService<OA2_FINST>, IOA2_FINSTService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.OA2_FINSTDal;
        }
    }

    public partial class TBL_GZMXBService : BaseService<TBL_GZMXB>, ITBL_GZMXBService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_GZMXBDal;
        }
    }

    public partial class TBL_GZMXB_LOGService : BaseService<TBL_GZMXB_LOG>, ITBL_GZMXB_LOGService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_GZMXB_LOGDal;
        }
    }

    public partial class TBL_GZMXB_TJService : BaseService<TBL_GZMXB_TJ>, ITBL_GZMXB_TJService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_GZMXB_TJDal;
        }
    }

    public partial class TBL_HBGYTDSYQ_QBSPDService : BaseService<TBL_HBGYTDSYQ_QBSPD>, ITBL_HBGYTDSYQ_QBSPDService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_HBGYTDSYQ_QBSPDDal;
        }
    }

    public partial class TBL_HBGYTDSYQ_QBSPD_ZBService : BaseService<TBL_HBGYTDSYQ_QBSPD_ZB>, ITBL_HBGYTDSYQ_QBSPD_ZBService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_HBGYTDSYQ_QBSPD_ZBDal;
        }
    }

    public partial class TBL_JSYDBP_BCGDDJK_DETAILService : BaseService<TBL_JSYDBP_BCGDDJK_DETAIL>, ITBL_JSYDBP_BCGDDJK_DETAILService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_JSYDBP_BCGDDJK_DETAILDal;
        }
    }

    public partial class TBL_JSYDBP_BCGDDJK_ZB1Service : BaseService<TBL_JSYDBP_BCGDDJK_ZB1>, ITBL_JSYDBP_BCGDDJK_ZB1Service
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_JSYDBP_BCGDDJK_ZB1Dal;
        }
    }

    public partial class TBL_JSYDBP_BCGDDJK_ZB2Service : BaseService<TBL_JSYDBP_BCGDDJK_ZB2>, ITBL_JSYDBP_BCGDDJK_ZB2Service
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_JSYDBP_BCGDDJK_ZB2Dal;
        }
    }

    public partial class TBL_SJSLDService : BaseService<TBL_SJSLD>, ITBL_SJSLDService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_SJSLDDal;
        }
    }

    public partial class TBL_TDFHDJ_BPPDService : BaseService<TBL_TDFHDJ_BPPD>, ITBL_TDFHDJ_BPPDService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_TDFHDJ_BPPDDal;
        }
    }

    public partial class TBL_TDGY_HBJDSService : BaseService<TBL_TDGY_HBJDS>, ITBL_TDGY_HBJDSService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_TDGY_HBJDSDal;
        }
    }

    public partial class TBL_TDTJBG_HTJBXXService : BaseService<TBL_TDTJBG_HTJBXX>, ITBL_TDTJBG_HTJBXXService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = CurrentDBSession.TBL_TDTJBG_HTJBXXDal;
        }
    }

}