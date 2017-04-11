using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
namespace ArizonaIndustryForTheBlindPay
{
    class ExcelFunctions
    {

        public ExcelFunctions(string fileName)
        {
        }

        public void insertHour(double[] hours, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open(fileName);
            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            Microsoft.Office.Interop.Excel.Range userRange = x.UsedRange;

            /*Saving into excel
             */

            sheet.Close(true, fileName, Type.Missing);
            excel.Quit();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.FinalReleaseComObject(sheet);
            Marshal.FinalReleaseComObject(x);
            Marshal.FinalReleaseComObject(userRange);
            Marshal.FinalReleaseComObject(excel);


        }
    }
}
