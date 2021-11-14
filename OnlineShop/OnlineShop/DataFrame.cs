using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace OnlineShop
{
    class DataFrame
    {
        public static DataTable Shoes { get; set; }
        public static DataTable Product { get; set; }
        public static DataTable Order { get; set; }
        public static DataTable History { get; set; }

        public static int ID { get; set; }
        public static DataTable New_DataHistory()
        {
            DataTable myTable = new DataTable();

            myTable.Columns.Add("ID", typeof(int));
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Brand", typeof(string));
            myTable.Columns.Add("Pay", typeof(int));
            myTable.Columns.Add("Amount", typeof(int));
            myTable.Columns.Add("Size", typeof(int));
            myTable.Columns.Add("SDT", typeof(int));
            myTable.Columns.Add("Adress", typeof(string));
            myTable.Columns.Add("Date", typeof(DateTime));
            myTable.Columns.Add("Status", typeof(string));

            ID = 0;
            return myTable;
        }

        public static DataTable New_DataOrder()
        {
            DataTable myTable = new DataTable();

            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Brand", typeof(string));
            myTable.Columns.Add("Pay", typeof(int));
            myTable.Columns.Add("Amount", typeof(int));
            myTable.Columns.Add("Size", typeof(int));
            myTable.Columns.Add("SDT", typeof(int));
            myTable.Columns.Add("Adress", typeof(string));

            return myTable;
        }

        public static DataTable New_DataShoes()
        {
            DataTable myTable = new DataTable();

            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Brand", typeof(string));
            myTable.Columns.Add("Price", typeof(int));

            return myTable;
        }

        public static DataTable Read_File(string url)//Excel File
        { 
            return ReadExcel(url);
        }

        //Read datatable
        public static DataTable ReadExcel(string url)
        {
            ExcelApp.Application excelApp = new ExcelApp.Application();
            DataRow myNewRow;
            DataTable myTable;

            //if (excelApp == null)
            //{
            //    Console.WriteLine("Excel is not installed!!");
            //    return;
            //}

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;

            //Set DataTable Name and Columns Name
            myTable = new DataTable("MyDataTable");
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Brand", typeof(string));
            ///myTable.Columns.Add("Description", typeof(string));
            myTable.Columns.Add("Price", typeof(int));

            for (int i = 2; i <= rows; i++)
            {
                myNewRow = myTable.NewRow();
                myNewRow["Name"] = excelRange.Cells[i, 1].Value2.ToString(); //string
                myNewRow["Brand"] = excelRange.Cells[i, 2].Value2.ToString(); //string
                //myNewRow["Description"] = excelRange.Cells[i, 3].Value2.ToString();//string
                myNewRow["Price"] = Convert.ToInt32(excelRange.Cells[i, 3].Value2.ToString()); //string

                myTable.Rows.Add(myNewRow);
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;
        }
    }
}
