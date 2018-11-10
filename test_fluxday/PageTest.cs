using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace test_fluxday
{
    public class PageTest
    {
        [Test]
        public void site_login_page()
        {
            
            IWebDriver browser = new FirefoxDriver();
            browser.Navigate().GoToUrl("https://app.fluxday.io/");
            //IWebElement header = browser.FindElement(By.Id("Fluxday"));
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Assert.True(header.Displayed);
            browser.Close();

        }
    }
}
