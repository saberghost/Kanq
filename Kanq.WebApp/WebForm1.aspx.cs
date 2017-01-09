using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kanq.Model;
using Kanq.BLL;

namespace Kanq.WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OracleDbContext db = new OracleDbContext();
            //TBL_ZDCQ_ZFHBBT entity2 = new TBL_ZDCQ_ZFHBBT() { BZ = "ppppp2" };
            //db.Entry(entity2).State = System.Data.Entity.EntityState.Added;
            //for (int i = 0; i < 100; i++)
            //{
            //    TBL_ZDCQ_ZFHBBT entity = new TBL_ZDCQ_ZFHBBT() { BZ = "ppppp1" };
            //    db.Entry(entity).State = System.Data.Entity.EntityState.Added;
            //}
            TBL_ZDCQ_ZFHBBT entity1 = new TBL_ZDCQ_ZFHBBT() { XMMC="添加" };
            TBL_ZDCQ_ZFHBBT entity2 = new TBL_ZDCQ_ZFHBBT() { ID = 10,XMMC="修改" };
            TBL_ZDCQ_ZFHBBT entity3 = new TBL_ZDCQ_ZFHBBT() { ID = 11 };
            db.Entry(entity1).State = System.Data.Entity.EntityState.Added;
            db.Entry(entity2).State = System.Data.Entity.EntityState.Modified;
            db.Entry(entity3).State = System.Data.Entity.EntityState.Deleted;
            //List<decimal> list = new List<decimal>() { 4,5,6,7,8,9};
            //var query=db.TBL_ZDCQ_ZFHBBT.Where(t => list.Contains(t.ID));
            //foreach (var item in query)
            //{
            //    db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            //}
            db.SaveChanges();
        }
    }
}