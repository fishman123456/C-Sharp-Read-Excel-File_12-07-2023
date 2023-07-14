using IronXL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Read_Excel_File_12_07_2023
{
    public class New_Files_Excel
    {
        public static void NewFiles()
        {
            // Create new Excel WorkBook document
            WorkBook workBook = WorkBook.Create();

            // Convert XLSX to XLS
            WorkBook xlsWorkBook = WorkBook.Create(ExcelFileFormat.XLS);

            // Create a blank WorkSheet
            WorkSheet workSheet = workBook.CreateWorkSheet("new_sheet");

            // Add data and styles to the new worksheet
            workSheet["A1"].Value = "Hello World";
            workSheet["A1"].Style.WrapText = true;
            workSheet["A2"].BoolValue = true;
            workSheet["A2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
            // Save the excel file as XLS, XLSX, CSV, TSV, JSON, XML, HTML and streams
            workBook.SaveAs("C:\\Users\\Fishman_1\\Documents\\sample.xlsx");
        }
        public static void LoadFiles()
        {
            // Supported for XLSX, XLS, XLSM, XLTX, CSV and TSV
            WorkBook workBook = WorkBook.Load("C:\\Users\\Fishman_1\\Documents\\sample.xlsx");

            // Select worksheet at index 0
            WorkSheet workSheet = workBook.WorkSheets[0];

            // Get any existing worksheet
            WorkSheet firstSheet = workBook.DefaultWorkSheet;

            // Select a cell and return the converted value
            int cellValue = workSheet["A2"].IntValue;

            // Read from ranges of cells elegantly.
            foreach (var cell in workSheet["A2:A10"])
            {
                Console.WriteLine("Cell {0} has value '{1}'", cell.AddressString, cell.Text);
            }

            // Calculate aggregate values such as Min, Max and Sum
            decimal sum = workSheet["A2:A10"].Sum();

            // Linq compatible
            decimal max = workSheet["A2:A10"].Max(c => c.DecimalValue);
        }
       
    }
}
