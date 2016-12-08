using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IBLL
{
    public partial interface ITBL_GZMXB_LOGService : IBaseService<TBL_GZMXB_LOG>
    {
        bool DeleteEntitys(string MID);
    }
}
