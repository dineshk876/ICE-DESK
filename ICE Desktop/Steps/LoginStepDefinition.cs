using BDD_AutomationTests.Behavior;
using BDD_AutomationTests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static BDD_AutomationTests.Behavior.ExecuteLoginBehavior;

namespace BDD_AutomationTests.Steps
{
    [Binding]
    public class LoginStepDefinition

    {
        private LoginPage loginPage;  
        private HomePage homePage; 

        public LoginStepDefinition(IWebDriver driver)
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
        }

        [Given(@"Login with credentials (.*) and (.*)")]
        public void WhenLoginWithValidCredentials(string userName, string password)
        {
            new ExecuteLoginBehavior(loginPage, userName, password).Perform();

        }

        [Then(@"Verify home page is dispalyed")]
        public void ThenVerifyHomePageIsDispalyed()
        {
            new ExecuteLoginBehavior(homePage).Perform1();
        }

        [Then(@"Verify invalid credential message is displaying")]
        public void ThenVerifyInvalidCredentialMessageIsDisplaying()
        {
            new InvalidLoginBehavior(loginPage).Perform2();
        }
        [Then(@"Logout the user")]
        public void ThenLogoutTheUser()
        {
            new ExecuteLoginBehavior(homePage).Perform3();
        }

    }
}