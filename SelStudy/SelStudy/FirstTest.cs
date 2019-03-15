using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace SelStudy
{
    [TestClass]
    public class FirstTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private const string URL = "http://google.ru";
        private const string IE_DRIVER_PATH = @"C:\Tools\";

        [TestMethod]
        public void start()
        {
            //driver = new ChromeDriver();
            var options = new InternetExplorerOptions()
            {
                InitialBrowserUrl = URL,
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };
            driver = new InternetExplorerDriver(IE_DRIVER_PATH, options);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate();
            driver.Close(); // closes browser
            driver.Quit(); // closes IEDriverServer process
        }
    }
}
