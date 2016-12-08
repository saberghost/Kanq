using Kanq.DALFactory;
using Kanq.IBLL;
using Kanq.IDAL;
using Kanq.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.BLL
{
    public class FwcqHzService: IFwcqHzService
    {
        public IDBSession CurrentDBSession
        {
            get
            {
                return DBSessionFactory.CreateDBSession();
            }
        }

        public IEnumerable<FwcqHz> GetListByPage(string strWhere, string orderby, out int total, int page, int rows)
        {
            return CurrentDBSession.FwcqHzDal.GetListByPage(strWhere, orderby, out total, page, rows);
        }
    }
}
