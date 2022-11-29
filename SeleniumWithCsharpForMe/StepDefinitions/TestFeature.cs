using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumWithCsharpForMe.StepDefinitions
{
    [Binding]
    public class TestFeature
    {
        IWebDriver Driver ;
        public TestFeature() { }
        [Given(@"I launch the formy-heroku app url ""([^""]*)""")]
        public void GivenILaunchTheFormy_HerokuAppUrl(string url)
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
        }

       
        [When(@"I click on Form")]
        public void WhenIClickOnForm()
        {
            Driver.FindElement(By.LinkText("Form")).Click();
        }
        [Then(@"The form should be displayed")]
        public void ThenTheFormShouldBeDisplayed()
        {
            Assert.IsTrue(Driver.FindElement(By.CssSelector("h1")).Displayed);
            Thread.Sleep(3000);
        }
        [Then(@"I Enter FirstName, LastName, JobTitle and Submit the form")]
        public void ThenIEnterFirstNameLastNameJobTitleAndSubmitTheForm(Table table)
        {
            foreach (var row in table.Rows)
            {
                Driver.FindElement(By.Id("first-name")).SendKeys(row["FirstName"]);
                Driver.FindElement(By.Id("last-name")).SendKeys(row["LastName"]);
                Driver.FindElement(By.Id("job-title")).SendKeys(row["JobTitle"]);
            }
        }


    }
}
