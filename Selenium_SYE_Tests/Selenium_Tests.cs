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
        private readonly QuotePages quoteElements = new QuotePages();

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
            quoteElements.QuotePageTwo(_driver, "Fidelity Energy Limited");
            quoteElements.QuotePageThree(_driver, "038012011300001439650", "20000", null, "01012020", 3);
            quoteElements.ListOfQuotes(_driver);
            quoteElements.ContactDetails(_driver, null, "test", "testing", "Software Engineer", "11111111111");
            quoteElements.BankDetails(_driver, "FakeBank", "Fake Account", "000000", "12121212");
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
