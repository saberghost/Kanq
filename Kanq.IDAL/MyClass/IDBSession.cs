using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.IDAL
{
    public partial interface IDBSession
    {
        DbContext db { get; }
        bool SaveChanges();
        IFwcqHzDal FwcqHzDal { get; set; }
    }
}
