using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_SYE_Classes
{
    public class Selenium_Setup
    {
        public IWebDriver _driver { get; set; }

        public void StartBrowser()
        {
            _driver.Url = "https://www.switchyourenergy.com/";
        }

        public void KillBrowser()
        {
            _driver.Close();
        }
    }
}
