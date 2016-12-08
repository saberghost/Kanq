using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IBLL
{
    public partial interface ITBL_HBGYTDSYQ_QBSPD_ZBService : IBaseService<TBL_HBGYTDSYQ_QBSPD_ZB>
    {
        IQueryable<object> loadGyqkData(string BPSLH);
    }
}
