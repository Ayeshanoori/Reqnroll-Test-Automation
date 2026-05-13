using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Reqnroll;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class InvalidloginStepDefinitions
    {
       ChromeDriver chromedriver = new ChromeDriver();
        [Given("open browser window go to url and click on make appointment button")]
        public void GivenOpenBrowserWindowGoToUrlAndClickOnMakeAppointmentButton()
        {
            chromedriver.Manage().Window.Maximize();
            chromedriver.Navigate().GoToUrl("https://katalon-demo-cura.herokuapp.com/");
            Thread.Sleep(2000);
            chromedriver.FindElement(By.Id("btn-make-appointment")).Click();
        }

        [Given("enter invalid username and password")]
        public void GivenEnterInvalidUsernameAndPassword()
        {
            chromedriver.FindElement(By.Id("txt-username")).SendKeys("John");
            chromedriver.FindElement(By.Id("txt-password")).SendKeys("ThisIsAPassword");
        }

        [When("click login button")]
        public void WhenClickLoginButton()
        {
            chromedriver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(2000);
        }

        [Then("Login failed... Please ensure the username and password are valid.")]
        public void ThenLoginFailed_PleaseEnsureTheUsernameAndPasswordAreValid_()
        {
            string expectedtext = "Login failed! Please ensure the username and password are valid.";
            string actualtext = chromedriver.FindElement(By.XPath("//p[@class='lead text-danger']")).Text;
            Assert.AreEqual(expectedtext, actualtext);
            chromedriver.Quit();

        }

    }
}
