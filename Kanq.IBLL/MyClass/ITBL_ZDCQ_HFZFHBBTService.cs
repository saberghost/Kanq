using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IBLL
{
    public partial interface ITBL_ZDCQ_HFZFHBBTService : IBaseService<TBL_ZDCQ_HFZFHBBT>
    {
        void CUD(List<TBL_ZDCQ_HFZFHBBT> insertedList, List<TBL_ZDCQ_HFZFHBBT> updatedList, List<TBL_ZDCQ_HFZFHBBT> deletedList, decimal? year);
        List<TBL_ZDCQ_HFZFHBBT> GetTotalEntitis(decimal? year);
    }
}
