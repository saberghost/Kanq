using Kanq.Common;
using Kanq.IBLL;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Kanq.WebApp.Controllers
{
    public class WageStatisticsController : Controller
    {
        public ITBL_GZMXBService TBL_GZMXBService { get; set; }
        public ITBL_GZMXB_TJService TBL_GZMXB_TJService { get; set; }

        public ActionResult statistics(DateTime? txtTjrq, string txtBM, int rows, int page)
        {
            TBL_GZMXBService.GetPageListEx();
            if (txtTjrq == null)
            {
                return Content(SerializeHelper.SerializeToList(0, new List<Model.TBL_GZMXB_TJ>()).Callback());
            }
            DateTime tjrq = Convert.ToDateTime(txtTjrq);
            int total;
            IQueryable<Model.TBL_GZMXB_TJ> list;
            if (string.IsNullOrEmpty(txtBM))
            {
                list = TBL_GZMXB_TJService.LoadPageEntities(page, rows, out total, t => t.TJRQ.Year == tjrq.Year && t.TJRQ.Month == tjrq.Month, t => t.XM);
            }
            else
            {
                list = TBL_GZMXB_TJService.LoadPageEntities(page, rows, out total, t => t.TJRQ.Year == tjrq.Year && t.TJRQ.Month == tjrq.Month && t.BM == txtBM, t => t.XM);
            }
            return Content(SerializeHelper.SerializeToList(total, list).Callback());
        }

        /// <summary>
        /// 获取统计日期
        /// </summary>
        /// <returns></returns>
        public ActionResult GetSingleTjrq()
        {
            List<DateTime> timeList = TBL_GZMXB_TJService.LoadEntities(t => true).Select(t => t.TJRQ).Distinct().ToList();
            var list = timeList.OrderByDescending(t => t).
                Select(t => t.ToString("yyyy年MM月")).Distinct().
                Select(t => new
                {
                    VALUE = DateTime.ParseExact(t, "yyyy年MM月", System.Globalization.CultureInfo.CurrentCulture),
                    TJRQ = t
                });
            return Content(SerializeHelper.SerializeToString(list).Callback());
        }

        public ActionResult ExportExcel(DateTime? txtTjrq, string txtBM, string lableBM)
        {
            string filePath = Request.MapPath("/ExcelTemplate/tbl_gzmxb_tj.xlsx");
            //创建Excel工作薄
            XSSFWorkbook workbook = new XSSFWorkbook(filePath);
            //创建单元格样式
            ICellStyle cellStyle = workbook.CreateCellStyle();
            //设置单元格居中显示
            cellStyle.Alignment = HorizontalAlignment.Center;
            //设置文本换行显示
            cellStyle.WrapText = true;
            //设置单元格边框样式
            cellStyle.BorderTop = BorderStyle.Thin;
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            //创建Excel工作表
            ISheet sheet = workbook.GetSheetAt(0);
            var tempList = TBL_GZMXB_TJService.LoadEntities(t => true);
            if (txtTjrq == null)
            {
                tempList = tempList.Where(t => false);
            }
            else
            {
                DateTime tjrq = Convert.ToDateTime(txtTjrq);
                tempList = tempList.Where(t => t.TJRQ.Year == tjrq.Year && t.TJRQ.Month == tjrq.Month);
            }
            if (!string.IsNullOrEmpty(txtBM))
            {
                tempList = tempList.Where(t => t.BM==txtBM);
                IRow row = sheet.GetRow(1);
                ICell cell = row.GetCell(0);
                cell.SetCellValue("单位：" + lableBM);
            }
            List<Model.TBL_GZMXB_TJ> tjList = tempList.ToList();
            string[] pros = { "XM", "XB", "WHCD", "JRBDWSJ", "SFZHM", "GZGW", "JBGZ", "GWGZ", "HSBZ", "JTBZ", "BYXZJBGZ", "BYXZGWGZ", "HJ", "ZXSJ", "BZ" };
            for (int i = 0; i < tjList.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 4);
                ICell cell0 = row.CreateCell(0);
                cell0.SetCellValue(i + 1);
                cell0.CellStyle = cellStyle;
                Type t = tjList[i].GetType();
                foreach (PropertyInfo pi in t.GetProperties())
                {
                    object value = pi.GetValue(tjList[i]);
                    string name = pi.Name;
                    string type = pi.PropertyType.Name;
                    for (int j = 0; j < pros.Length; j++)
                    {
                        if (name == pros[j])
                        {
                            ICell cell = row.CreateCell(j + 1);
                            cell.CellStyle = cellStyle;
                            double result;
                            if (value == null)
                            {
                                continue;
                            }
                            if ((!double.TryParse(value.ToString(), out result)) && type == "Nullable`1")
                            {
                                cell.SetCellValue(Convert.ToDateTime(value).ToShortDateString());
                            }
                            else
                            {
                                cell.SetCellValue(value.ToString());
                            }
                        }
                    }
                }
            }
            var ms = new NpoiMemoryStream();
            ms.AllowClose = false;
            workbook.Write(ms);
            ms.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            ms.AllowClose = true;
            return File(ms, "application/ vnd.ms-excel", "长沙县国土资源局劳务派遣人员调整工资明细表.xlsx");
        }
    }
}