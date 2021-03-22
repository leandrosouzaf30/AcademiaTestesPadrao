
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AcademiaTestePadra.Abstracoes
{
    public class SuperClass : IDisposable
    {
        protected IWebDriver driver { get; }
        public SuperClass()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void Dispose()
        {
            //driver?.Quit();
            //driver?.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
