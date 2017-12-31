using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            IWebDriver driver = WebDriverFactory.getInstance("chrome");
            GithubLoginPage page = new GithubLoginPage(driver, "https://github.com/login");
            page.Navigate();
            page.setUserName("dummy1");
            page.setPassword("dummy2");
            page.Commit();
            page.locateNameRepository("dummy1", "WebDriverAPI-II");
            /*     
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            IWebElement webElement = driver.FindElement(By.XPath("//input[@name='q']"));
            webElement.SendKeys("News");
            IWebElement button = driver.FindElement(By.XPath("//input[@name='btnK']"));
            button.Click ();
    */     }
    }


}
