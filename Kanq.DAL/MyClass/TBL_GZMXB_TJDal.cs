using Kanq.IDAL;
using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.DAL
{
    public partial class TBL_GZMXB_TJDal : BaseDal<TBL_GZMXB_TJ>, ITBL_GZMXB_TJDal
    {
        public int GetRecordCount()
        {
            int count= db.Database.SqlQuery<int>("select count(1) FROM TBL_GZMXB_TJ where to_char(tjrq,'yyyy-MM')=to_char(sysdate,'yyyy-MM')").First();
            return count;
        }
    }
}
