using Kanq.Common;
using Kanq.IBLL;
using Kanq.Model;
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
    public class ZDCQ_HFZFHBBTController : Controller
    {
        public ITBL_ZDCQ_HFZFHBBTService TBL_ZDCQ_HFZFHBBTService { get; set; }
        // GET: ZDCQ_HFZFHBBT
        public ActionResult Query(decimal? year)
        {
            var list = TBL_ZDCQ_HFZFHBBTService.LoadEntities(t => t.YEAR != null && t.YEAR == year).OrderBy(t => t.ID);
            var totalEntitis = TBL_ZDCQ_HFZFHBBTService.GetTotalEntitis(year);
            return Content(SerializeHelper.SerializeToString(new { rows = list, footer = totalEntitis }).Callback());
        }

        public ActionResult CUD(string inserted, string updated, string deleted, decimal? year)
        {
            List<TBL_ZDCQ_HFZFHBBT> insertedList = SerializeHelper.DeserializeToObject<List<TBL_ZDCQ_HFZFHBBT>>(inserted);
            List<TBL_ZDCQ_HFZFHBBT> updatedList = SerializeHelper.DeserializeToObject<List<TBL_ZDCQ_HFZFHBBT>>(updated);
            List<TBL_ZDCQ_HFZFHBBT> deletedList = SerializeHelper.DeserializeToObject<List<TBL_ZDCQ_HFZFHBBT>>(deleted);
            TBL_ZDCQ_HFZFHBBTService.CUD(insertedList, updatedList, deletedList, year);
            return Content("ok");
        }

        public ActionResult GetYear()
        {
            var list = TBL_ZDCQ_HFZFHBBTService.LoadEntities(t => t.YEAR != null).Select(t => t.YEAR).Distinct().ToList().OrderByDescending(t => t);
            var data = list.Select(t => new { id = t.Value, text = t.Value });
            return Content(SerializeHelper.SerializeToString(data).Callback());
        }

        public ActionResult ExportExcel(decimal? year)
        {
            string filePath = Request.MapPath("/ExcelTemplate/TBL_ZDCQ_HFZFHBBT.xlsx");
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
            ICell cellTitle = sheet.GetRow(0).GetCell(0);
            string title = cellTitle.StringCellValue;
            title = title.Replace("{year}", year?.ToString());
            cellTitle.SetCellValue(title);
            title = title.Replace("\n", null);
            var List = TBL_ZDCQ_HFZFHBBTService.LoadEntities(t => t.YEAR != null && t.YEAR == year).OrderBy(t => t.ID).ToList();
            var totalEntitis = TBL_ZDCQ_HFZFHBBTService.GetTotalEntitis(year);
            List.AddRange(totalEntitis);
            string[] pros = { "XMMC", "PC", "HS", "NYRK", "ZXCZ1", "ZXCZ2", "HJJE", "QKSJ", "BZ" };
            for (int i = 0; i < List.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 4);
                ICell cell0 = row.CreateCell(0);
                cell0.SetCellValue(i + 1);
                cell0.CellStyle = cellStyle;
                Type t = List[i].GetType();
                foreach (PropertyInfo pi in t.GetProperties())
                {
                    object value = pi.GetValue(List[i]);
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
            return File(ms, "application/ vnd.ms-excel", $"{title}.xlsx");
        }
    }
}