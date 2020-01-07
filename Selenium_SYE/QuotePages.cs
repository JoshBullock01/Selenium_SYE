//using OpenQA.Selenium;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Selenium_SYE
//{
//    public class QuotePages
//    {
//        Quote_Elements element;

//        public void QuotePageOne(IWebDriver _driver, string email)
//        {
//            //Possibly convert to a helper method
//            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//            var emailInput = _driver.FindElement(By.XPath("//*[@id='Email']"));
//            emailInput.SendKeys(email);

//            var check = _driver.FindElement(By.XPath("//*[@id='Consent']"));
//            check.Click();

//            ClickNext(_driver);
//        }

//        public void QuotePageTwo(IWebDriver _driver, string companyName)
//        {
//            var companyFinder = _driver.FindElement(By.XPath("//*[@id='coSearch']/div/div/input"));
//            companyFinder.SendKeys(companyName);

//            var searchButton = _driver.FindElement(By.XPath("//*[@id='coSearch']/div/span/button/span[2]/i"));
//            searchButton.Click();

//            var companyDropdown = GetCompanyResult(_driver, 0);
//            companyDropdown.Click();

//            ClickNext(_driver);

//        }

//        public void QuotePageThree(IWebDriver _driver, string mpan, string usageAmount, string usageType, string contractEnd, int supplierIndex)
//        {
//            var mpanInput = _driver.FindElement(By.XPath("//*[@id='PC']"));
//            mpanInput.SendKeys(mpan);

//            var usage = _driver.FindElement(By.XPath("/html/body/div[1]/div/div/form/div/div[1]/div[2]/div/div/div/div[2]/div/estimated-usage/div[1]/div[1]/input"));
//            usage.SendKeys(usageAmount);

//            SelectElement supplier = new SelectElement(_driver.FindElement(By.XPath("//*[@id='supplier']/select")));
//            supplier.SelectByIndex(1);

//            var date = _driver.FindElement(By.XPath("//*[@id='datepicker']/div/input"));
//            date.SendKeys(contractEnd);

//            ClickNext(_driver);
//        }

//        /// <summary>
//        /// Method used for picking the first quote that pops up just to finish cycle
//        /// </summary>
//        /// <param name="_driver"></param>
//        public void ListOfQuotes(IWebDriver _driver)
//        {
//            ////TODO add a wait to visible function 
//            //Thread.Sleep(10000);
//            //var quote = _driver.FindElement(By.XPath("//*[@id='71ec5654 - f3ad - 4611 - 967a - 2aa452ab9f1f']/div/ul/li[5]/button[1]"));
//            //quote.Click();
//            //_driver.Close();

//            SelectQuote(_driver, 1);
//        }

//        public void ContactDetails(IWebDriver _driver, string title, string firstName, string lastName, string position, string phone)
//        {
//            // Add code to decide what index is what title
//            SelectElement supplier = new SelectElement(_driver.FindElement(By.XPath("//*[@id='titleselect']")));
//            supplier.SelectByIndex(1);

//            var first = _driver.FindElement(By.XPath("//*[@id='firstname']"));
//            first.SendKeys(firstName);
//            var last = _driver.FindElement(By.XPath("//*[@id='surname']"));
//            last.SendKeys(lastName);
//            var pos = _driver.FindElement(By.XPath("//*[@id='position']"));
//            pos.SendKeys(position);
//            var phoneNum = _driver.FindElement(By.XPath("/html/body/div[1]/div/div/form/div/div[1]/div[2]/div/div/div/div[1]/div[5]/div/input"));
//            phoneNum.SendKeys(phone);
//        }

//        public void BankDetails(IWebDriver _driver, string bankName, string accountName, string sortCode, string accountNumber)
//        {
//            var bank = _driver.FindElement(By.XPath("//*[@id='bankname']"));
//            bank.SendKeys(bankName);
//            var account = _driver.FindElement(By.XPath("//*[@id='accountname']"));
//            account.SendKeys(accountName);
//            var sort = _driver.FindElement(By.XPath("//*[@id='sortcode']"));
//            sort.SendKeys(sortCode);
//            var accountNum = _driver.FindElement(By.XPath("//*[@id='accountnumber']"));
//            accountNum.SendKeys(accountNumber);

//            ClickNext(_driver);
//        }

//        private void ClickNext(IWebDriver _driver)
//        {
//            var next = _driver.FindElement(By.XPath("//*[@id='next']"));
//            next.Click();
//        }

//        public void SelectQuote(IWebDriver _driver, int resultListIndex, int timeout = 30000)
//        {
//            ReadOnlyCollection<IWebElement> buttons = null;

//            resultListIndex += 1;

//            var watch = Stopwatch.StartNew();
//            while (buttons == null && watch.ElapsedMilliseconds < timeout)
//            {
//                try
//                {
//                    var tmp = _driver.FindElements(By.XPath("//button[@class='btn btn-success']"));
//                    if (tmp.Count > resultListIndex)
//                        buttons = tmp;
//                }
//                catch
//                {
//                    Thread.Sleep(1);
//                }
//            }
//            watch.Stop();
//            var choice = buttons.Where(b => b.Displayed && b.Text.Contains("Select")).ToList()[resultListIndex];

//            choice.Click();
//        }

//        private IWebElement GetCompanyResult(IWebDriver _driver, int index)
//        {
//            try
//            {
//                var loc = By.XPath("//a[@data-bind=\"click: $parent.Select.bind($data)\"]");

//                //_driver.WaitForElement(_driver, loc);

//                return _driver.FindElements(loc)[index];
//            }
//            catch (Exception e)
//            {
//                throw new Exception("Company Result: " + index, e);
//            }
//        }

//        public void SubmitQuote(IWebDriver _driver)
//        {
//            var submit = _driver.FindElement(By.XPath("//*[@id='complete']"));
     
//            Actions actions = new Actions(_driver);
//            actions.MoveToElement(submit);
//            actions.Perform();

//            submit.Click();
//        }
//    }
//}
