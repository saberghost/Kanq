using Kanq.IBLL;
using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.BLL
{
    public partial class TBL_GZMXB_LOGService : BaseService<TBL_GZMXB_LOG>, ITBL_GZMXB_LOGService
    {
        public bool DeleteEntitys(string MID)
        {
            var TBL_GZMXB_LOGList = CurrentDal.LoadEntities(u => u.MID.Equals(MID));
            foreach (var TBL_GZMXB_LOG in TBL_GZMXB_LOGList)
            {
                CurrentDal.DeleteEntity(TBL_GZMXB_LOG);
            }
            return CurrentDBSession.SaveChanges();
        }
    }
}
