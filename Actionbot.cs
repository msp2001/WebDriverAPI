﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Actionbot
    {
        private IWebDriver driver;
        public Actionbot(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void SetText(By locator, string text)
        {
            this.findElement(locator).SendKeys(text);
        }
        public void SetClick(By locator)
        {
            this.findElement(locator).Click();
        }
        public IWebElement findElement(By by, int timeoutInSeconds = 0)
        {
            return this.wait(timeoutInSeconds).Until<IWebElement>(drv => drv.FindElement(by));
        }
        private WebDriverWait wait(int timeoutInSeconds)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        }
    }
}
