using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium_SYE;

namespace Selenium_SYE_Tests
{
    [TestClass]
    public class Selenium_Tests
    {
        private readonly Selenium_Setup browser = new Selenium_Setup();
        private readonly HomePageElements elements = new HomePageElements();

        [TestMethod]
        [TestCategory("SiteTest")]
        public void TestSiteOpens()
        {
            try
            {
                browser.StartBrowser();
            }
            catch (Exception)
            {
                throw new Exception("Browser did not start");
            }
            browser.KillBrowser();
        }

        [TestMethod]
        [TestCategory("Quotes")]
        public void TestElectricityQuote()
        {
            browser.StartBrowser();
            elements.GetElectricity();
            
        }


        [TestMethod]
        [TestCategory("Quotes")]
        public void TestGasQuote()
        {

        }


        [TestMethod]
        [TestCategory("Quotes")]
        public void TestDualQuote()
        {

        }
    }
}
