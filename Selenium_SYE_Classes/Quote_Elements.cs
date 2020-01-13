using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_SYE_Classes
{
    public class Quote_Elements
    {
        public IWebDriver _driver { get; set; }

        #region HomePage

        public void Electricity()
        {
            var getElec = _driver.FindElement(By.XPath("//*[@id='top']/div/div/div/div[2]/div/div/quote-starter/div/div[1]/div[2]/a[1]/span/img"));
            getElec.Click();
        }

        public void Gas()
        {
            var getGas = _driver.FindElement(By.XPath("//*[@id='top']/div/div/div/div[2]/div/div/quote-starter/div/div[1]/div[2]/a[3]"));
            getGas.Click();
        }

        public void DualEnergy()
        {
            var getDual = _driver.FindElement(By.XPath("//*[@id='top']/div/div/div/div[2]/div/div/quote-starter/div/div[1]/div[2]/a[2]"));
            getDual.Click();
        }

        #endregion

        #region Specific Elec

        /// <summary>
        /// Input MPAN
        /// Need to update this code so we can input individual values to do a check sum etc
        /// </summary>
        /// <param name="_driver"></param>
        /// <param name="mpan"></param>
        public void MPAN_Input(string mpan)
        {
            var xpath = "//*[@id='PC']";
            WaitForElement(xpath);

            var mpanInput = _driver.FindElement(By.XPath(xpath));
            mpanInput.SendKeys(mpan);
        }




        #endregion

        #region Specific Gas

        public void MPRN_Input(string mprn)
        {
            var mprnIn = _driver.FindElement(By.XPath("/html/body/div[1]/div/div/form/div/div[1]/div[2]/div/div/div/div[1]/div/input"));
            mprnIn.SendKeys(mprn);
        }

        #endregion

        #region Shared Elements

        #region Page 1
        /// <summary>
        /// Finds the email input for page 1 of the quoting stage
        /// </summary>
        /// <param name="_driver"></param>
        /// <param name="email"></param>
        public IWebElement Email_Input(string email)
        {
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var emailXpath = "//*[@id='Email']";
            WaitForElement(emailXpath);

            var emailIn = _driver.FindElement(By.XPath(emailXpath));
            emailIn.SendKeys(email);

            return emailIn;
        }


        /// <summary>
        /// Clicks the consent tick box on page 1
        /// </summary>
        /// <param name="_driver"></param>
        public void ConsentBox_Clicker()
        {
            var check = _driver.FindElement(By.XPath("//*[@id='Consent']"));
            check.Click();
        }

        #endregion

        #region Page 2

        /// <summary>
        /// Company lookup - Finds the company and clicks on whichever index you tell it to
        /// </summary>
        /// <param name="_driver"></param>
        /// <param name="companyName"></param>
        /// <param name="index"></param>
        public void CompanyChoice_Input(string companyName, int index)
        {
            //Inputs company name
            var companyXpath = "//*[@id='coSearch']/div/div/input";

            WaitForElement(companyXpath);

            var companyFinder = _driver.FindElement(By.XPath(companyXpath));
            companyFinder.SendKeys(companyName);

            //Clicks search
            var searchButton = _driver.FindElement(By.XPath("//*[@id='coSearch']/div/span/button/span[2]/i"));
            searchButton.Click();

            //Chooses result
            var companyDropdown = GetCompanyResult(_driver, index);
            companyDropdown.Click();
        }

        #endregion

        #region Page 3

        /// <summary>
        /// Input the usage p/kwh
        /// </summary>
        /// <param name="_driver"></param>
        /// <param name="usageAmount"></param>
        public void Usage_Input(string usageAmount, bool isGas)
        {
            var elecXpath = "/html/body/div[1]/div/div/form/div/div[1]/div[2]/div/div/div/div[2]/div/estimated-usage/div[1]/div[1]/input";
            var gasXpath = "/html/body/div[1]/div/div/form/div/div[1]/div[2]/div/div/div/div[3]/div/div/estimated-usage/div[1]/div[1]/input";
            
            WaitForElement(elecXpath);
            WaitForElement(gasXpath);

            var usage = _driver.FindElement(By.XPath(elecXpath));
            var gasUsage = _driver.FindElement(By.XPath(gasXpath));

            if (!isGas) 
                usage.SendKeys(usageAmount);
            else 
                gasUsage.SendKeys(usageAmount);
        }

        /// <summary>
        /// Chooses supplier based on the index given
        /// </summary>
        /// <param name="_driver"></param>
        /// <param name="supplierIndex"></param>
        public void Current_Supplier_Input(int supplierIndex)
        {
            SelectElement supplier = new SelectElement(_driver.FindElement(By.XPath("//*[@id='supplier']/select")));
            supplier.SelectByIndex(1);
        }

        /// <summary>
        /// Inputs the date given
        /// </summary>
        /// <param name="_driver"></param>
        /// <param name="contractEnd"></param>
        public void ContractEnd_Input(string contractEnd)
        {
            var date = _driver.FindElement(By.XPath("//*[@id='datepicker']/div/input"));
            date.SendKeys(contractEnd);
        }

        #endregion

        #region Results

        public void SelectQuote(int resultListIndex, int timeout = 30000)
        {
            ReadOnlyCollection<IWebElement> buttons = null;

            resultListIndex += 1;

            var watch = Stopwatch.StartNew();
            while (buttons == null && watch.ElapsedMilliseconds < timeout)
            {
                try
                {
                    var tmp = _driver.FindElements(By.XPath("//button[@class='btn btn-success']"));
                    if (tmp.Count > resultListIndex)
                        buttons = tmp;
                }
                catch
                {
                    Thread.Sleep(1);
                }
            }
            watch.Stop();
            var choice = buttons.Where(b => b.Displayed && b.Text.Contains("Select")).ToList()[resultListIndex];

            choice.Click();
        }

        #endregion

        #region Contact Info
        /// <summary>
        /// Choose what title for the contact
        /// </summary>
        /// <param name="_driver"></param>
        /// <param name="index"></param>
        public void Title_Picker(int index)
        {
            SelectElement supplier = new SelectElement(_driver.FindElement(By.XPath("//*[@id='titleselect']")));
            supplier.SelectByIndex(1);
        }

        public void FirstName_Input(string firstName)
        {
            var first = _driver.FindElement(By.XPath("//*[@id='firstname']"));
            first.SendKeys(firstName);
        }
        public void Surname_Input(string lastName)
        {
            var last = _driver.FindElement(By.XPath("//*[@id='surname']"));
            last.SendKeys(lastName);
        }
        public void Job_Input(string position)
        {
            var pos = _driver.FindElement(By.XPath("//*[@id='position']"));
            pos.SendKeys(position);
        }
        public void PhoneNumber_Input(string phone)
        {
            var phoneNum = _driver.FindElement(By.XPath("/html/body/div[1]/div/div/form/div/div[1]/div[2]/div/div/div/div[1]/div[5]/div/input"));
            phoneNum.SendKeys(phone);
        }
        #endregion

        #region Bank Details
        public void BankName_Input(string bankName)
        {
            var bank = _driver.FindElement(By.XPath("//*[@id='bankname']"));
            bank.SendKeys(bankName);
        }
        public void AccountName_Input(string accountName)
        {
            var account = _driver.FindElement(By.XPath("//*[@id='accountname']"));
            account.SendKeys(accountName);
        }
        public void SortCode_Input(string sortCode)
        {
            var sort = _driver.FindElement(By.XPath("//*[@id='sortcode']"));
            sort.SendKeys(sortCode);
        }
        public void AccountNumber_Input(string accountNumber)
        {
            var accountNum = _driver.FindElement(By.XPath("//*[@id='accountnumber']"));
            accountNum.SendKeys(accountNumber);
        }
        #endregion

        //Needs finishing once I have the demo url
        #region Submit
        #endregion

        #endregion

        #region helper
        private IWebElement GetCompanyResult(IWebDriver _driver, int index)
        {
            try
            {
                WaitForElement("//a[@data-bind=\"click: $parent.Select.bind($data)\"]");
                var loc = By.XPath("//a[@data-bind=\"click: $parent.Select.bind($data)\"]");

                //_driver.WaitForElement(_driver, loc);

                return _driver.FindElements(loc)[index];
            }
            catch (Exception e)
            {
                throw new Exception("Company Result: " + index, e);
            }
        }

        /// <summary>
        /// Finds the next button for moving between quote stages
        /// </summary>
        public void ClickNext()
        {
            var xpath = "//*[@id='next']";

            WaitForElement(xpath);

            var next = _driver.FindElement(By.XPath(xpath));
            next.Click();
        }

        private void WaitForElement(string xpath)
        {
            WebDriverWait waitForElement = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }

        #endregion
    }
}
 