using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_SYE
{
    public class Selenium_Setup
    {
        public void StartBrowser(IWebDriver _driver)
        {
            _driver.Url = "https://www.switchyourenergy.com/";
        }

        public void KillBrowser(IWebDriver _driver)
        {
            _driver.Close();
        }
    }
}
