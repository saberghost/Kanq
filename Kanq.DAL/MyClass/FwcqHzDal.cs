using Kanq.IDAL;
using Kanq.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.DAL
{
    public class FwcqHzDal: IFwcqHzDal
    {
        DbContext db = DbContextFactory.CreateDbContext();

        public IEnumerable<FwcqHz> GetListByPage(string strWhere, string orderby,out int total, int page, int rows)
        {
            int startIndex = (page - 1) * rows + 1;
            int endIndex = page * rows;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.t1 desc");
            }
            strSql.Append(")AS rn, T.*  from View_FwcqHzDal T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            string countSql = $"select count(1) from ({strSql.ToString()})";
            total = db.Database.SqlQuery<int>(countSql).First();
            strSql.AppendFormat(" WHERE TT.rn between {0} and {1}", startIndex, endIndex);
            return db.Database.SqlQuery<FwcqHz>(strSql.ToString());
        }
    }
}
