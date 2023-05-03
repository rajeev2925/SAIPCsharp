using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SAIPCsharp
{
    [TestClass]
    public class UnitTest2
    {
        public static WebDriver driver;
        [TestInitialize]
        public void BMsetups()
        {
            driver = new ChromeDriver();
           driver.Manage().Window.Maximize();
        }

        [TestMethod]
        [TestCategory("validateURL")]
        [DataTestMethod]
        [DataRow("https://meet.google.com/", "Google Meet")]
        [DataRow("https://meet.google.com/","Google  eMeet")]
        [DataRow("https://www.facebook.com/login/","Log in to Facebook")]
        [DataRow("https://opensource.zalando.com/zalenium/","Zalenium - A flexible and scalable Selenium Grid.")]
        public void TestMethod1(String url,String exptitle)
        {
            driver.Url = url;
            string acttitle=driver.Title;
            Console.WriteLine(acttitle);
            try
            {
                Assert.Equals(exptitle, acttitle);
                Console.WriteLine("title matched");

            }
            catch (Exception e)
            {
                try
                {
                    Assert.IsTrue(exptitle.Contains(acttitle));

                    Console.WriteLine("title contains actual title");

                }
                catch
                {
                    Console.WriteLine("title not match");
                    Console.WriteLine(e.StackTrace);
                }
            }
        }


        [TestCleanup]
        public void AMsetups()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
