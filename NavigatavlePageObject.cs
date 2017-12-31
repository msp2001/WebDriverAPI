using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public abstract class NavigatablePageObject : PageObject
    {
        private string url;
        public NavigatablePageObject(IWebDriver driver, String url) : base(driver)
        {
            this.url = url;
        }
        public void Navigate()
        {
            this.driver.Url = url;
        }
    }
}
