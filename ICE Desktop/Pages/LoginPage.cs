using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace BDD_AutomationTests.Pages
{
    public class LoginPage
    {

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By usernameTextbox = By.XPath("//input[@id='txtName']");
        By passwordTextbox = By.XPath("//input[@id='txtPassword']");
        By bt_sub = By.Id("btnSubmit");
        By invalidAccountMessage = By.XPath("//td[normalize-space()='Login failed.']");       

        public void ExecuteLogin(string userName, string password)
        {
            driver.Url = BDD_AutomationTests.Hooks.Hooks.config.ApplicationURL;         
            driver.FindElement(usernameTextbox).SendKeys(userName);
            driver.FindElement(passwordTextbox).SendKeys(password);
            driver.FindElement(bt_sub).Click();
        }

        public void InvalidAccountMessage()
        {
            IWebElement _err = driver.FindElement(invalidAccountMessage);
            string _er = _err.Text;
            Assert.That(_er, Is.EqualTo("Login failed."), "error");
        }

        public void login()
        {
            driver.Url = BDD_AutomationTests.Hooks.Hooks.config.ApplicationURL;
            driver.FindElement(usernameTextbox).SendKeys("sunquest");
            driver.FindElement(passwordTextbox).SendKeys("");
            driver.FindElement(bt_sub).Click();
        }
    }
}