using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Reqnroll;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class MakeappointmentStepDefinitionsa
    {
        ChromeDriver chromedriver = new ChromeDriver();
        [Given("open browser window click on make appointment button")]
        public void GivenOpenBrowserWindowClickOnMakeAppointmentButton()
        {
           chromedriver.Manage().Window.Maximize();
            chromedriver.Navigate().GoToUrl("https://katalon-demo-cura.herokuapp.com/");
            Thread.Sleep(2000);
            chromedriver.FindElement(By.Id("btn-make-appointment")).Click();
        }

        [When("enter valid username and pass")]
        public void WhenEnterValidUsernameAndPass()
        {
            chromedriver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            chromedriver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
        }

        [When("click on the login button")]
        public void WhenClickOnTheLoginButton()
        {
            chromedriver.FindElement(By.Id("btn-login")).Click();
            Thread.Sleep(2000);
        }

        [When("enter appointment details")]
        public void WhenEnterAppointmentDetails()
        {
            chromedriver.FindElement(By.Id("combo_facility"))
                        .SendKeys("Tokyo CURA Healthcare Center");

            chromedriver.FindElement(By.Id("chk_hospotal_readmission")).Click();

            chromedriver.FindElement(By.Id("radio_program_medicare")).Click();

            Thread.Sleep(1000);

            chromedriver.FindElement(By.Id("txt_visit_date")).Clear();

            chromedriver.FindElement(By.Id("txt_visit_date"))
                        .SendKeys("15/05/2026");

            Thread.Sleep(1000);

            chromedriver.FindElement(By.Id("txt_comment"))
                        .SendKeys("Appointment booking test");
        }

        [When("click on book appointment button")]
        public void WhenClickOnBookAppointmentButton()
        {
            chromedriver.FindElement(By.Id("btn-book-appointment")).Click();
            Thread.Sleep(2000);
        }

        [Then("appointment booked successfully")]
        public void ThenAppointmentBookedSuccessfully()
        {
            string expectedtext = "Appointment Confirmation";
            string actualtext = chromedriver.FindElement(By.XPath("//h2")).Text;
            Assert.AreEqual(expectedtext, actualtext);
            chromedriver.Quit();
        }

    }
}
