using System;
using Reqnroll;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class ValidLoginStepDefinitions
    {
        ChromeDriver chromeDriver = new ChromeDriver();

        [Given("open browser goto url click on make appointment button")]
        public void GivenOpenBrowserGotoUrlClickOnMakeAppointmentButton()
        {
            //opening browser and clicking on make appointment button
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl("https://katalon-demo-cura.herokuapp.com/");
            chromeDriver.FindElement(By.Id("btn-make-appointment")).Click();
        }

        [Given("enter valid username and password")]
        public void GivenEnterValidUsernameAndPassword()
        {
            chromeDriver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            chromeDriver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
        }

        [When("click on login btn")]
        public void WhenClickOnLoginBtn()
        {
            chromeDriver.FindElement(By.Id("btn-login")).Click();
        }

        [Then("user logged in successfully")]
        public void ThenUserLoggedInSuccessfully()
        {
            string expectedText = "Make Appointment";
            string actualText = chromeDriver.FindElement(By.XPath("//h2[normalize-space()='Make Appointment']")).Text;
            Assert.AreEqual(expectedText, actualText);
            chromeDriver.Quit();
        }

    }
}