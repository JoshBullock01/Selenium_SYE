using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_SYE
{
    public class QuotePage_One
    {
        public void QuotePageOne(IWebDriver _driver, string email)
        {
            var emailInput = _driver.FindElement(By.XPath("//*[@id='Email']"));
            emailInput.Click();
            emailInput.SendKeys(email);

            var check = _driver.FindElement(By.XPath("//*[@id='Consent']"));
            check.Click();

            // May have to add a wait to visible check
            var next = _driver.FindElement(By.XPath("//*[@id='next']"));
            next.Click();
        }
    }
}
