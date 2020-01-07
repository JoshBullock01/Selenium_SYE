using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_SYE
{
    public class HomePageElements
    {
        public void ChooseElectricity(IWebDriver _driver)
        {
            var getElec = _driver.FindElement(By.XPath("//*[@id='top']/div/div/div/div[2]/div/div/quote-starter/div/div[1]/div[2]/a[1]/span/img"));
            getElec.Click();
        }

        public void ChooseGas(IWebDriver _driver)
        {
            var getGas = _driver.FindElement(By.XPath("//*[@id='top']/div/div/div/div[2]/div/div/quote-starter/div/div[1]/div[2]/a[3]"));
            getGas.Click();
        }

        public void ChooseDualEnergy(IWebDriver _driver)
        {
            var getDual = _driver.FindElement(By.XPath("//*[@id='top']/div/div/div/div[2]/div/div/quote-starter/div/div[1]/div[2]/a[2]"));
            getDual.Click();
        }
    }
}
