using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kanq.IBLL;
using Kanq.Common;
using Kanq.Model;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.Reflection;
using System.IO;

namespace Kanq.WebApp.Controllers
{
    public class ZBPHController : Controller
    {
        public ITBL_JSYDBP_BCGDDJK_ZB2Service ZB2Service { get; set; }
        public ITBL_JSYDBP_BCGDDJK_DETAILService DETAILService { get; set; }
        public ActionResult ShowList(int rows, int page)
        {
            int total;
            var list = ZB2Service.LoadPageEntities(page, rows, out total, t => true, t => t.GLID);
            return Content(SerializeHelper.SerializeToList(total, list).Callback());
        }

        public ActionResult Update(TBL_JSYDBP_BCGDDJK_ZB2 model)
        {
            ZB2Service.EditEntity(model);
            return Content("ok");
        }

        public ActionResult ShowChildList(int rows, int page, string BCGDDJKID, int? OID)
        {
            int total;
            var list = DETAILService.LoadPageEntities(page, rows, out total, t => t.BCGDDJKID == BCGDDJKID && t.OID == OID, t => t.ID);
            return Content(SerializeHelper.SerializeToList(total, list).Callback());
        }

        public ActionResult ChildMerge(TBL_JSYDBP_BCGDDJK_DETAIL model)
        {
            var list = DETAILService.LoadEntities(u => u.BCGDDJKID == model.BCGDDJKID && u.OID == model.OID);
            if (list.Where(u => u.ID == model.ID).Count() == 0)
            {
                if (list.Count() == 0)
                {
                    model.ID = 1;
                }
                else
                {
                    model.ID = list.Max(u => u.ID) + 1;
                }
                DETAILService.AddEntity(model);
            }
            else
            {
                DETAILService.EditEntity(model);
            }
            return Content(SerializeHelper.SerializeToString(new { id = model.ID }).Callback());
        }

        public ActionResult Delete(string BCGDDJKID, int? OID, int? ID)
        {
            var model = DETAILService.LoadEntities(u => u.BCGDDJKID == BCGDDJKID && u.OID == OID && u.ID == ID).FirstOrDefault();
            string state = string.Empty;
            if (model == null)
            {
                state = "no";
            }
            else
            {
                DETAILService.DeleteEntity(model);
                state = "ok";
            }
            return Content(SerializeHelper.SerializeToString(new { scuess = state }).Callback());
        }

        public ActionResult ExportExcel()
        {
            string filePath = Request.MapPath("/ExcelTemplate/ZBPH.xlsx");
            //创建Excel工作薄
            XSSFWorkbook workbook = new XSSFWorkbook(filePath);
            //创建单元格样式
            ICellStyle cellStyle = workbook.CreateCellStyle();
            IFont font = workbook.CreateFont();
            font.FontName = "宋体";
            font.FontHeightInPoints = 10;
            cellStyle.SetFont(font);
            //设置单元格居中显示
            cellStyle.Alignment = HorizontalAlignment.Center;
            cellStyle.VerticalAlignment = VerticalAlignment.Center;
            //设置文本换行显示
            cellStyle.WrapText = true;
            //设置单元格边框样式
            cellStyle.BorderTop = BorderStyle.Thin;
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            //创建Excel工作表
            ISheet sheet = workbook.GetSheetAt(0);
            List<TBL_JSYDBP_BCGDDJK_ZB2> djkList = ZB2Service.LoadEntities(t=>true).OrderBy(t => t.GLID).ToList();
            List<TBL_JSYDBP_BCGDDJK_DETAIL> djkChildList = new List<TBL_JSYDBP_BCGDDJK_DETAIL>();
            foreach (var item in djkList)
            {
                var tempList = DETAILService.LoadEntities(t => t.BCGDDJKID == item.BCGDDJKID && t.OID == item.OID).ToList();
                if (tempList.Count == 0)
                {
                    djkChildList.Add(new TBL_JSYDBP_BCGDDJK_DETAIL());
                }
                else
                {
                    djkChildList.AddRange(tempList);
                }
            }
            foreach (var djk in djkList)
            {
                int count = DETAILService.LoadEntities(t => t.BCGDDJKID == djk.BCGDDJKID && t.OID == djk.OID).Count();
                count = count == 0 ? 1 : count;
                djk.COUNT = count;
            }
            string[] pros = { "APJSXMJZYGDDW", "YDWZ", "ZYGDDW", "ZYD", "NYD", "ZYGDMJ", "ST", "HD" };
            string[] prosChild = { "XSQ", "DKWZ", "DJTB", "DJTF", "YSMJ", "DKMJ", "QLQW", "BBH" };
            int add = 0;
            int first = 0;
            for (int i = 0; i < djkList.Count; i++)
            {
                add += (int)djkList[i].COUNT - 1;
                IRow row = sheet.CreateRow(i + 3 + first);
                ICell cell0 = row.CreateCell(0);
                cell0.SetCellValue(i + 1);
                CellRangeAddress regionOne = new CellRangeAddress(i + 3 + first, i + 3 + add, 0, 0);
                MergedStyle(cellStyle, sheet, regionOne);
                Type t = djkList[i].GetType();
                foreach (PropertyInfo pi in t.GetProperties())
                {
                    object value = pi.GetValue(djkList[i]);
                    string name = pi.Name;
                    string type = pi.PropertyType.Name;
                    for (int j = 0; j < pros.Length; j++)
                    {
                        if (name == pros[j])
                        {
                            CellRangeAddress region = new CellRangeAddress(i + 3 + first, i + 3 + add, j + 1, j + 1);
                            ICell cell = row.CreateCell(j + 1);
                            double result;
                            if (value != null)
                            {
                                if ((!double.TryParse(value.ToString(), out result)) && type == "Nullable`1")
                                {
                                    cell.SetCellValue(Convert.ToDateTime(value).ToShortDateString());
                                }
                                else
                                {
                                    cell.SetCellValue(value.ToString());
                                }
                            }
                            MergedStyle(cellStyle, sheet, region);
                        }
                    }
                }
                first = add;
            }
            for (int i = 0; i < djkChildList.Count; i++)
            {
                Type t = djkChildList[i].GetType();
                IRow row = sheet.GetRow(i + 3) == null ? sheet.CreateRow(i + 3) : sheet.GetRow(i + 3);
                foreach (PropertyInfo pi in t.GetProperties())
                {
                    object value = pi.GetValue(djkChildList[i]);
                    string name = pi.Name;
                    string type = pi.PropertyType.Name;
                    for (int j = 0; j < prosChild.Length; j++)
                    {
                        if (name == prosChild[j])
                        {
                            ICell cell = row.CreateCell(j + 1 + pros.Length);
                            double result;
                            if (value != null)
                            {
                                if ((!double.TryParse(value.ToString(), out result)) && type == "Nullable`1")
                                {
                                    cell.SetCellValue(Convert.ToDateTime(value).ToShortDateString());
                                }
                                else
                                {
                                    cell.SetCellValue(value.ToString());
                                }
                            }
                            cell.CellStyle = cellStyle;
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
            return File(ms, "application/ vnd.ms-excel", "占补平衡项目指标使用台帐.xlsx");
        }

        /// <summary>
        /// 合并单元格，并设置其样式
        /// </summary>
        /// <param name="cellStyle"></param>
        /// <param name="sheet"></param>
        /// <param name="region"></param>
        private void MergedStyle(ICellStyle cellStyle, ISheet sheet, CellRangeAddress region)
        {
            if (region.FirstRow != region.LastRow)
            {
                sheet.AddMergedRegion(region);
            }
            for (int m = region.FirstRow; m <= region.LastRow; m++)
            {
                IRow singleRow = sheet.GetRow(m) == null ? sheet.CreateRow(m) : sheet.GetRow(m);
                for (int n = region.FirstColumn; n <= region.LastColumn; n++)
                {
                    ICell singleCell = singleRow.GetCell(n) == null ? singleRow.CreateCell(n) : singleRow.GetCell(n);
                    singleCell.CellStyle = cellStyle;
                }
            }
        }
    }
}