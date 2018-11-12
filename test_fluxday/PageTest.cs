using System;
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

            IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://app.fluxday.io/");
            driver.FindElement(By.Id("user_email")).Clear();
            driver.FindElement(By.Id("user_email")).SendKeys("admin@fluxday.io");
            driver.FindElement(By.Id("user_password")).Clear();
            driver.FindElement(By.Id("user_password")).SendKeys("password");
            driver.FindElement(By.ClassName("btn-login")).Click();
          
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
            driver.Close();

        }
    }
}
