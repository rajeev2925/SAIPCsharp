using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace SAIPCsharp
{
    [TestClass]
    public class Datadrivenclass
    {

        [DataTestMethod]
        [DataRow ("Rajeev", 1)]
        [DataRow("naga",2)]
        [DataRow("Exam",3)]
        [TestCategory("DataDriven")]
        [TestMethod]
        public void DataDriven1(String a,int b)
        {
            Console.WriteLine(a + " " + b);
            MessageBox.Show(a + " " + b);

        }
    }
}
