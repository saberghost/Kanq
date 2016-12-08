using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.DAL
{
    public class BaseDal<T> where T : class, new()
    {
        public DbContext db = DbContextFactory.CreateDbContext();

        public T AddEntity(T entity)
        {
            db.Entry(entity).State = EntityState.Added;
            return entity;
        }

        public bool DeleteEntity(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            return true;
        }

        public bool EditEntity(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return true;
        }

        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().Where(whereLambda);
        }

        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int pageTotal, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderbyLamdba, bool isAsc = true)
        {
            var temp = db.Set<T>().Where(whereLambda);
            pageTotal = temp.Count();
            if (isAsc)
            {
                temp = temp.OrderBy(orderbyLamdba).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            else
            {
                temp = temp.OrderByDescending(orderbyLamdba).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            return temp;
        }

        public int GetMaxId(string fieldName, string tableName)
        {
            string strsql = $"select nvl(max(to_number({fieldName})),0)+1 from {tableName}";
            int maxId = db.Database.SqlQuery<int>(strsql).First();
            return maxId;
        }
    }
}
