using Kanq.DAL;
using Kanq.IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.DALFactory
{
    public partial class DBSession : IDBSession
    {
        public DbContext db
        {
            get
            {
                return DbContextFactory.CreateDbContext();
            }
        }

        public bool SaveChanges()
        {
            return db.SaveChanges() > 0;
        }

        public IFwcqHzDal FwcqHzDal { get; set; } = new FwcqHzDal();

    }
}
