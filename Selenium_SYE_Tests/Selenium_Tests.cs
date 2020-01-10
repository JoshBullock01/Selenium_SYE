using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_SYE_Classes;

namespace Selenium_SYE_Tests
{
    [TestClass]
    public class Selenium_Tests
    {
        private readonly IWebDriver _driver = new ChromeDriver();
        private readonly Selenium_Setup browser = new Selenium_Setup();
        private readonly Quote_Elements element = new Quote_Elements();

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
        [TestCategory("Electricity Quote")]
        public void Electricity_Run_Smooth()
        {
            try
            {
                StartTest();

                // Home Page
                element.Electricity();

                PageOne();
                PageTwo();

                // Page Three
                ElecPresetValues();

                QuoteAndContact();

                // Close Browser
                browser.KillBrowser(_driver);
            }
            catch (Exception)
            {
                _driver.Close();
                throw;
            }
        }

        [TestMethod]
        [TestCategory("Quotes")]
        public void Gas_Run_Smooth()
        {
            StartTest();

            // Home Page
            element.Gas();

            PageOne();
            PageTwo();

            // Page Three
            GasPresetValues();

            // List of Quote Results
            QuoteAndContact();

            // Close Browser
            browser.KillBrowser(_driver);

        }


        [TestMethod]
        [TestCategory("Quotes")]
        public void TestDualQuote()
        {
            StartTest();
            element.DualEnergy();

            PageOne();
            PageTwo();
            ElecPresetValues();
            QuoteAndContact();

        }

        #region Quick Test Inputs
        /// <summary>
        /// Opens Browser
        /// </summary>
        private void StartTest()
        {
            element._driver = _driver;
            browser.StartBrowser(_driver);
        }

        private void PageOne()
        {
            element.Email_Input("testemail@test.co.uk");
            element.ConsentBox_Clicker();
            element.ClickNext();
        }
        private void PageTwo()
        {
            element.CompanyChoice_Input("Fidelity Energy Limited", 0);
            element.ClickNext();
        }
        private void ElecPresetValues()
        {
            element.MPAN_Input("038012011300001439650");
            element.Usage_Input("20000", true);
            element.Current_Supplier_Input(0);
            element.ContractEnd_Input("01012020");
            element.ClickNext();
        }
        private void GasPresetValues()
        {
            element.MPRN_Input("5006715910");
            element.Usage_Input("20000", true);
            element.Current_Supplier_Input(0);
            element.ContractEnd_Input("01012020");
            element.ClickNext();
        }
        private void QuoteAndContact()
        {
            element.SelectQuote(0); // take the top quote
            element.Title_Picker(1);
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
        }
        #endregion
    }
}
