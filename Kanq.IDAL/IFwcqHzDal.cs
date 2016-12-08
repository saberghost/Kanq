using Kanq.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IDAL
{
    public interface IFwcqHzDal
    {
        IEnumerable<FwcqHz> GetListByPage(string strWhere, string orderby, out int total, int page, int rows);
    }
}
