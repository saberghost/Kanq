using Kanq.Model;
using Kanq.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IBLL
{
    public partial interface ID_RECService : IBaseService<D_REC>
    {
        IQueryable<object> LoadSerachEntities(YgdbpxmSearch ygdbpxmSearch);
        object GetEntity(string slid);
        IQueryable<object> loadHbjdsData(HbjdsSearch hbjdsSearch);
        IQueryable<object> loadCrhtData(CrhtSearch crhtSearch);
    }
}
