using Kanq.IBLL;
using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.BLL
{
    public partial class TBL_ZDCQ_HFZFHBBTService : BaseService<TBL_ZDCQ_HFZFHBBT>, ITBL_ZDCQ_HFZFHBBTService
    {
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="insertedList"></param>
        /// <param name="updatedList"></param>
        /// <param name="deletedList"></param>
        public void CUD(List<TBL_ZDCQ_HFZFHBBT> insertedList, List<TBL_ZDCQ_HFZFHBBT> updatedList, List<TBL_ZDCQ_HFZFHBBT> deletedList, decimal? year)
        {
            if (year == null)
            {
                return;
            }
            foreach (var item in insertedList)
            {
                item.YEAR = year;
                CurrentDal.AddEntity(item);
            }
            foreach (var item in updatedList)
            {
                item.YEAR = year;
                CurrentDal.EditEntity(item);
            }
            foreach (var item in deletedList)
            {
                CurrentDal.DeleteEntity(item);
            }
            CurrentDBSession.SaveChanges();
        }

        /// <summary>
        /// 获取统计行
        /// </summary>
        /// <returns></returns>
        public List<TBL_ZDCQ_HFZFHBBT> GetTotalEntitis(decimal? year)
        {
            List<TBL_ZDCQ_HFZFHBBT> list = new List<TBL_ZDCQ_HFZFHBBT>();
            if (year == null)
            {
                return list;
            }
            TBL_ZDCQ_HFZFHBBT entity = new TBL_ZDCQ_HFZFHBBT();
            var entitis = CurrentDal.LoadEntities(t => t.YEAR == year);
            entity.XMMC = "合计";
            entity.HS = entitis.Sum(t => t.HS);
            entity.NYRK = entitis.Sum(t => t.NYRK);
            entity.ZXCZ1 = entitis.Sum(t => t.ZXCZ1);
            entity.ZXCZ2 = entitis.Sum(t => t.ZXCZ2);
            entity.HJJE = entitis.Sum(t => t.HJJE);
            list.Add(entity);
            return list;
        }
    }
}
