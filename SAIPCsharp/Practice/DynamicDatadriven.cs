using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAIPCsharp.Practice
{
    [TestClass]
    public class DynamicDatadriven
    {
        public static IEnumerable<Object[]> data
        {
            get
            {
                return new[]
                {
                    new Object[] { 1, 2 },
                    new Object[] { 2, 3 },
                    new Object[] { 3, 4 },
                    new Object[] { 4, 5 },
                };
            }
        }
        [TestMethod]
        [TestCategory("DynamicDataDriven")]
        [DynamicData(nameof(data))]
        public void TestMethod3(int a, int b)
        {
            Console.WriteLine(a + " " + b);
            MessageBox.Show(a + " " + b);

        }
    }
}
