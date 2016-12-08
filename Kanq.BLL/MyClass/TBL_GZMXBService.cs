using Kanq.Common;
using Kanq.IBLL;
using Kanq.Model;
using Kanq.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.BLL
{
    public partial class TBL_GZMXBService : BaseService<TBL_GZMXB>, ITBL_GZMXBService
    {
        public IQueryable<TBL_GZMXB> LoadSerachEntities(TBL_GZMXBSearch searchModel)
        {
            var temp = CurrentDal.LoadEntities(t => true);
            if (!string.IsNullOrEmpty(searchModel.XM))
            {
                temp = temp.Where(t => t.XM.Contains(searchModel.XM));
            }
            if (!string.IsNullOrEmpty(searchModel.XB))
            {
                temp = temp.Where(t => t.XB.Contains(searchModel.XB));
            }
            if (!string.IsNullOrEmpty(searchModel.WHCD))
            {
                temp = temp.Where(t => t.WHCD.Contains(searchModel.WHCD));
            }
            if (!string.IsNullOrEmpty(searchModel.XLLB))
            {
                temp = temp.Where(t => t.XLLB.Contains(searchModel.XLLB));
            }
            if (!string.IsNullOrEmpty(searchModel.SFZHM))
            {
                temp = temp.Where(t => t.SFZHM.Contains(searchModel.SFZHM));
            }
            if (!string.IsNullOrEmpty(searchModel.GZGW))
            {
                temp = temp.Where(t => t.GZGW.Contains(searchModel.GZGW));
            }
            if (!string.IsNullOrEmpty(searchModel.BM))
            {
                temp = temp.Where(t => t.BM.Contains(searchModel.BM));
            }
            if (searchModel.JRBDWSJ != null)
            {
                temp = temp.Where(t => t.JRBDWSJ == searchModel.JRBDWSJ);
            }
            if (searchModel.ZXSJ != null)
            {
                temp = temp.Where(t => t.ZXSJ == searchModel.ZXSJ);
            }
            searchModel.TotalCount = temp.Count();
            return temp.OrderBy(u => u.XM).Skip((searchModel.PageIndex - 1) * searchModel.PageSize).Take(searchModel.PageSize);
        }

        public List<TBL_GZMXB> GetPageListEx(int pageIndex, int pageSize, string where, out int count)
        {
            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;
            List<TBL_GZMXB> listTarget = GetTempList();
            if (string.IsNullOrEmpty(where))
            {
                count = listTarget.Count;
                listTarget = (from items in listTarget orderby items.XM select items).Where((item, index) => index >= startIndex - 1 && index <= endIndex - 1).ToList();
            }
            else
            {
                count = (from items in listTarget orderby items.XM select items).Where(item => item.BM == where).ToList().Count;
                listTarget = (from items in listTarget orderby items.XM select items).Where(item => item.BM == where).Where((item, index) => index >= startIndex - 1 && index <= endIndex - 1).ToList();
            }

            return listTarget;
        }

        public List<TBL_GZMXB> GetPageListEx()
        {
            List<TBL_GZMXB> listTarget = GetTempList();
            return listTarget;
        }

        private List<TBL_GZMXB> GetTempList()
        {
            decimal MAXCQ = Convert.ToDecimal(ConfigHelper.Get("MAXCQ"));
            decimal MAXQT = Convert.ToDecimal(ConfigHelper.Get("MAXQT"));
            List<TBL_GZMXB> listSource = CurrentDal.LoadEntities(t=>true).ToList();
            List<TBL_GZMXB> listTarget = new List<TBL_GZMXB>();
            foreach (TBL_GZMXB model in listSource)
            {
                if (model.BM == "拆迁中心" && model.HJ >= MAXCQ)
                {
                    continue;
                }
                if (model.BM != "拆迁中心" && model.HJ >= MAXQT)
                {
                    continue;
                }
                if (model.JRBDWSJ != null)
                {
                    DateTime timeTarget = Convert.ToDateTime(model.JRBDWSJ);
                    DateTime timeNow = DateTime.Now;
                    int month = (timeNow.Year - timeTarget.Year) * 12 + (timeNow.Month - timeTarget.Month);
                    if (month >= 12 && month <= 12 * 2 - 1)
                    {
                        if (model.FLAG != "1")
                        {
                            model.BYXZJBGZ = 500;
                            model.BYXZGWGZ = null;
                            model.YEARLESS = "1";
                            listTarget.Add(model);
                        }
                    }
                    if (month >= 12 * 2 && month <= 12 * 3 - 1)
                    {
                        if (model.FLAG != "2")
                        {
                            model.BYXZJBGZ = 100;
                            model.BYXZGWGZ = null;
                            model.YEARLESS = "2";
                            listTarget.Add(model);
                        }
                    }
                    int maxYear = 100;
                    List<int> listNum = new List<int>();
                    for (int i = 1; i <= maxYear; i++)
                    {
                        if (i % 2 == 0)
                        {
                            listNum.Add(i + 2);
                        }
                    }
                    foreach (int item in listNum)
                    {
                        if (month >= 12 * item && month <= 12 * (item + 2) - 1)
                        {
                            if (model.FLAG != item.ToString())
                            {
                                model.BYXZJBGZ = 100;
                                model.BYXZGWGZ = null;
                                model.YEARLESS = item.ToString();
                                listTarget.Add(model);
                            }
                        }
                    }
                }
            }
           
            int recordCount = CurrentDBSession.TBL_GZMXB_TJDal.GetRecordCount();
            if (recordCount == 0)
            {
                foreach (TBL_GZMXB item in listTarget)
                {
                    TBL_GZMXB_TJ tjModel = new TBL_GZMXB_TJ();
                    EntityHelper.EntityToEntity(item, tjModel, "TJRQ", "MID");
                    tjModel.ID = CurrentDBSession.TBL_GZMXB_TJDal.GetMaxId("ID", "TBL_GZMXB_TJ").ToString();
                    tjModel.TJRQ = DateTime.Now;
                    tjModel.HJ = Convert.ToDecimal(tjModel.HJ) + Convert.ToDecimal(tjModel.BYXZJBGZ) + Convert.ToDecimal(tjModel.BYXZGWGZ);
                    tjModel.MID = item.ID;
                    CurrentDBSession.TBL_GZMXB_TJDal.AddEntity(tjModel);
                    CurrentDBSession.SaveChanges();
                }
            }
            return listTarget;
        }
    }
}
