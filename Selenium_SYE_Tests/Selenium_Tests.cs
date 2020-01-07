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
        private readonly HomePageElements fuelType = new HomePageElements();
        private readonly Quote_Elements element = new Quote_Elements();
        //private readonly QuotePages quoteElements = new QuotePages();

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

        //[TestMethod]
        //[TestCategory("Quotes")]
        //public void TestElectricityQuote()
        //{
        //    browser.StartBrowser(_driver);
        //    elements.ChooseElectricity(_driver);

        //    quoteElements.QuotePageOne(_driver, "test@test.com");
        //    quoteElements.QuotePageTwo(_driver, "Fidelity Energy Limited");
        //    quoteElements.QuotePageThree(_driver, "038012011300001439650", "20000", null, "01012020", 3);
        //    quoteElements.ListOfQuotes(_driver);
        //    quoteElements.ContactDetails(_driver, null, "test", "testing", "Software Engineer", "11111111111");
        //    quoteElements.BankDetails(_driver, "FakeBank", "Fake Account", "000000", "12121212");
        //}


        [TestMethod]
        [TestCategory("Electricity Quote")]
        public void Electricity()
        {
            element._driver = _driver;
            browser.StartBrowser(_driver);

            // Home Page
            fuelType.ChooseElectricity(_driver);

            // Page One
            element.Email_Input("testemail@test.co.uk");
            element.ConsentBox_Clicker();
            element.ClickNext();

            // Page Two
            element.CompanyChoice_Input("Fidelity Energy Limited", 0);
            element.ClickNext();

            // Page Three
            element.MPAN_Input("038012011300001439650");
            element.Usage_Input("20000");
            element.Current_Supplier_Input(0);
            element.ContractEnd_Input("01012020");
            element.ClickNext();

            // List of Quote Results
            element.SelectQuote(0); // take the top quote
            element.FirstName_Input("Josh");
            element.Surname_Input("Bullock");
            element.Job_Input("Software Engineer");
            element.PhoneNumber_Input("11111111111");

            // Bank Details
            element.BankName_Input("Fake Bank Name");
            element.AccountName_Input("Fake Account Name");
            element.SortCode_Input("123456");
            element.AccountNumber_Input("12345678");
            element.ClickNext();

            browser.KillBrowser(_driver);
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
