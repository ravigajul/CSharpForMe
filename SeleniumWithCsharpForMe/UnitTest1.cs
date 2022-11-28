using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithCsharpForMe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(ConfigurationSettings.AppSettings.Get("Browser"));
            Console.WriteLine(ConfigurationSettings.AppSettings.Get("UserName"));
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/datepicker");
        }
    }
}
