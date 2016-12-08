using Kanq.Model;
using Kanq.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IBLL
{
    public partial interface ITBL_GZMXBService : IBaseService<TBL_GZMXB>
    {
        IQueryable<TBL_GZMXB> LoadSerachEntities(TBL_GZMXBSearch searchModel);
        List<TBL_GZMXB> GetPageListEx(int pageIndex, int pageSize, string where, out int count);
        List<TBL_GZMXB> GetPageListEx();
    }
}
