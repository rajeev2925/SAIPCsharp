using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.COM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace SAIPCsharp.Practice
{
    [TestClass]
    public class UnitTest1
    {

        public static string fPath = "C:\\Users\\Rajeev\\source\\repos\\SAIPCsharp\\SAIPCsharp\\file\\dataex.xlsx";
        public static string sname = "Sheet1";
       
        [TestMethod]
        [TestCategory("Read_Singe_Data_From_Excell")]
        public void TestMethod1()
        {   
            int row = 3;
            int cel= 0;
            Spreadsheet sp = new Spreadsheet();
            sp.LoadFromFile(fPath);
            string sdata=sp.Workbook.Worksheets.ByName(sname).Cell(row, cel).ToString();
            MessageBox.Show(sdata);
        }

        [TestMethod]
        [TestCategory("Read_multiple_data_from_excell")]
        public void TestMethod2()
        {
            Spreadsheet sp = new Spreadsheet();
            sp.LoadFromFile(fPath);
            int lrow=sp.Workbook.Worksheets.ByName(sname).UsedRangeRowMax;
            for(int i=0; i<lrow;i++)
            {
                string sdata = sp.Workbook.Worksheets.ByName(sname).Cell(i,0 ).ToString();
                Console.WriteLine("data " + i + ":" + sdata);

            }
        }

    }
}
