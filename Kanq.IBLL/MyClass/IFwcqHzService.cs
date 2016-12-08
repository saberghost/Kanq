using Kanq.IDAL;
using Kanq.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IBLL
{
    public interface IFwcqHzService
    {
        IEnumerable<FwcqHz> GetListByPage(string strWhere, string orderby, out int total, int page, int rows);
    }
}
