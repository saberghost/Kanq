using Kanq.IBLL;
using Kanq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.BLL
{
    public partial class TBL_ZDCQ_ZFHBBTService : BaseService<TBL_ZDCQ_ZFHBBT>, ITBL_ZDCQ_ZFHBBTService
    {
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="insertedList"></param>
        /// <param name="updatedList"></param>
        /// <param name="deletedList"></param>
        public void CUD(List<TBL_ZDCQ_ZFHBBT> insertedList, List<TBL_ZDCQ_ZFHBBT> updatedList, List<TBL_ZDCQ_ZFHBBT> deletedList, decimal? year)
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
        public List<TBL_ZDCQ_ZFHBBT> GetTotalEntitis( decimal? year)
        {
            List<TBL_ZDCQ_ZFHBBT> list = new List<TBL_ZDCQ_ZFHBBT>();
            if (year == null)
            {
                return list;
            }
            TBL_ZDCQ_ZFHBBT entity = new TBL_ZDCQ_ZFHBBT();
            var entitis = CurrentDal.LoadEntities(t => t.YEAR==year);
            entity.XMMC = "合计";
            entity.HS = entitis.Sum(t => t.HS);
            entity.NYRK = entitis.Sum(t => t.NYRK);
            entity.DSZN = entitis.Sum(t => t.DSZN);
            entity.FNYRK = entitis.Sum(t => t.FNYRK);
            entity.XJ = entitis.Sum(t => t.XJ);
            entity.ZXCZ1 = entitis.Sum(t => t.ZXCZ1);
            entity.ZXCZ2 = entitis.Sum(t => t.ZXCZ2);
            entity.ZXCZ3 = entitis.Sum(t => t.ZXCZ3);
            entity.CJTCZ = entitis.Sum(t => t.CJTCZ);
            entity.LJTCZ = entitis.Sum(t => t.LJTCZ);
            entity.CQZXCZ = entitis.Sum(t => t.CQZXCZ);
            entity.SGGJCZ = entitis.Sum(t => t.SGGJCZ);
            entity.XZGYYCZ = entitis.Sum(t => t.XZGYYCZ);
            entity.KGCGWHCZ = entitis.Sum(t => t.KGCGWHCZ);
            entity.ZDGCJ = entitis.Sum(t => t.ZDGCJ);
            entity.SLJ = entitis.Sum(t => t.SLJ);
            entity.HHZBQ = entitis.Sum(t => t.HHZBQ);
            entity.HJT = entitis.Sum(t => t.HJT);
            entity.GTJCZ = entitis.Sum(t => t.GTJCZ);
            entity.HJJE = entitis.Sum(t => t.HJJE);
            list.Add(entity);
            return list;
        }
    }
}
