using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class WebDriverFactory
    {
        public static IWebDriver getInstance(string browser)
        {
            if (browser.Equals("chrome"))
            {
                return new ChromeDriver();
            }
            return null;
        }
    }
}
