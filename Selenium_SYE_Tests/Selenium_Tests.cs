using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_SYE;

namespace Selenium_SYE_Tests
{
    [TestClass]
    public class Selenium_Tests
    {
        private readonly IWebDriver _driver = new ChromeDriver();

        private readonly Selenium_Setup browser = new Selenium_Setup();
        private readonly HomePageElements elements = new HomePageElements();
        private readonly QuotePage_One quoteElements = new QuotePage_One();

        [TestMethod]
        [TestCategory("SiteTest")]
        public void TestSiteOpens()
        {
            try
            {
                browser.StartBrowser(_driver);
            }
            catch (Exception)
            {
                throw new Exception("Browser did not start");
            }
            browser.KillBrowser(_driver);
        }

        [TestMethod]
        [TestCategory("Quotes")]
        public void TestElectricityQuote()
        {
            browser.StartBrowser(_driver);
            elements.GetElectricity(_driver);

            quoteElements.QuotePageOne(_driver, "test@test.com");

            
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
