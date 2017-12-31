using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{

    public class GithubLoginPage : NavigatablePageObject
    {
        public GithubLoginPage(IWebDriver driver, String url) : base(driver, url) { }

        By userNameFieldLocator = By.Id("login_field");
        public void setUserName(string username)
        {
            this.actionbot.SetText(userNameFieldLocator, username);
            this.actionbot.SetClick(userNameFieldLocator);
        }
        By passwordFieldLocator = By.Id("password");
        public void setPassword(string username)
        {
            this.actionbot.SetText(passwordFieldLocator, username);
            this.actionbot.SetClick(passwordFieldLocator);
        }
        By commitFieldLocator = By.Name("commit");
        public void Commit()
        {
            this.actionbot.SetClick(commitFieldLocator);
        }
        public void locateNameRepository(string username, string nameRepository)
        {
  //          IWebElement webElement1 = this.driver.FindElement(By.XPath("//span[@title=concat(username,'/',nameRepository)]"));
  //         webElement1.Click();
            IWebElement webElement2 = this.driver.FindElement(By.XPath("//span[@title='dummy1/WebDriverAPI-II']"));
            webElement2.Click();
        }
        //    public void SetUserName(string UserName)
        //    {
        //        IWebElement webElement = IWebDriver.driver.FindElement(By.XPath("//input[@name='user[login]']"));
        //        webElement.SendKeys(UserName);
        //    }
    }  
}
