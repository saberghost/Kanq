using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IBLL
{
    public partial interface ITBL_ZDCQ_ZFHBBTService : IBaseService<TBL_ZDCQ_ZFHBBT>
    {
        void CUD(List<TBL_ZDCQ_ZFHBBT> insertedList, List<TBL_ZDCQ_ZFHBBT> updatedList, List<TBL_ZDCQ_ZFHBBT> deletedList, decimal? year);
        List<TBL_ZDCQ_ZFHBBT> GetTotalEntitis(decimal? year);
    }
}
