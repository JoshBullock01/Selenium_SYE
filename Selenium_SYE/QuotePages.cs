using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_SYE
{
    public class QuotePages
    {
        public void QuotePageOne(IWebDriver _driver, string email)
        {
            //Possibly convert to a helper method
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var emailInput = _driver.FindElement(By.XPath("//*[@id='Email']"));

            emailInput.Click();
            emailInput.SendKeys(email);

            var check = _driver.FindElement(By.XPath("//*[@id='Consent']"));
            check.Click();

            ClickNext(_driver);
        }

        public void QuotePageTwo(IWebDriver _driver, string companyName)
        {
            var companyFinder = _driver.FindElement(By.XPath("//*[@id='coSearch']/div/div/input"));
            companyFinder.SendKeys(companyName);

            var searchButton = _driver.FindElement(By.XPath("//*[@id='coSearch']/div/span/button/span[2]/i"));
            searchButton.Click();

            var companyDropdown = GetCompanyResult(_driver, 0);
            companyDropdown.Click();

            ClickNext(_driver);

        }

        public void QuotePageThree(IWebDriver _driver, string mpan, string usageAmount, string usageType, string contractEnd, int supplierIndex)
        {
            var mpanInput = _driver.FindElement(By.XPath("//*[@id='PC']"));
            mpanInput.SendKeys(mpan);

            var usage = _driver.FindElement(By.XPath("/html/body/div[1]/div/div/form/div/div[1]/div[2]/div/div/div/div[2]/div/estimated-usage/div[1]/div[1]/input"));
            usage.SendKeys(usageAmount);

            SelectElement supplier = new SelectElement(_driver.FindElement(By.XPath("//*[@id='supplier']/select")));
            supplier.SelectByIndex(1);

            var date = _driver.FindElement(By.XPath("//*[@id='datepicker']/div/input"));
            date.SendKeys(contractEnd);

            ClickNext(_driver);
        }

        private void ClickNext(IWebDriver _driver)
        {
            var next = _driver.FindElement(By.XPath("//*[@id='next']"));
            next.Click();
        }

        private IWebElement GetCompanyResult(IWebDriver _driver, int index)
        {
            try
            {
                var loc = By.XPath("//a[@data-bind=\"click: $parent.Select.bind($data)\"]");

                //_driver.WaitForElement(_driver, loc);

                return _driver.FindElements(loc)[index];
            }
            catch (Exception e)
            {
                throw new Exception("Company Result: " + index, e);
            }
        }

        //private static void WaitForElement(this IWebDriver _driver, By locator, int waitTime = 2000)
        //{
        //    var waiter = new WebDriverWait(_driver, TimeSpan.FromMilliseconds(waitTime));

        //    waiter.Until(ExpectedConditions.ElementIsVisible(locator));

        //}
    }
}
