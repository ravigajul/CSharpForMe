using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCsharpForMe.Configuration;
using SeleniumWithCsharpForMe.Interfaces;

namespace SeleniumWithCsharpForMe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Obsolete]
        public void TestMethod1()
        {
            //Reading Data from app.config
            Console.WriteLine(ConfigurationSettings.AppSettings.Get("Browser"));
            Console.WriteLine(ConfigurationSettings.AppSettings.Get("UserName"));
            Console.WriteLine((int)BrowserType.Chrome);


            IConfig config = new AppConfigReader();
            Console.WriteLine("Browser  : {0}" , config.GetBrowser());
            Console.WriteLine("UserName : {0}" , config.GetUserName());
            Console.WriteLine("Browser  : {0}" , config.GetPassword());
            /* IWebDriver driver = new ChromeDriver();
             driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/datepicker");*/
        }
    }
}
