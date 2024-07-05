using Microsoft.Extensions.Options;
using Nest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace BDD_AutomationTests.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By Location = By.XPath("//select[@id='selUserLocationIndex']");
        By Location1 = By.XPath("//select[@id='selUserLocationIndex']");
        By submit = By.XPath("//input[@id='btnSubmit']");
        By Frame = By.XPath("//iframe[@id='iframeMain']");
        By homePageAssertion = By.XPath("//*[@id='NonGridArea']//child::td[@title='View my notes']");
        By logoff = By.XPath("//*[text()='Log Off']");
        By _sig = By.XPath("//*[@id='LogOffDetail']/child::a[text()='Log Off and Close Window']");
        // By _admin = By.XPath("//*[@id='Administration']//child::a[@id='a300']");
         By _patientsearch = By.XPath("//input[@id='PatientSearch1_txtSearch']");
          By _patientclick = By.XPath("//input[@id='PatientSearch1_btnSearch']");
          By _selectpatient = By.XPath("//*[@id='tblMain']//child::tr[@patientid='21711']");
          By _Req = By.XPath("//*[@id='Requesting']");
          By _newreq = By.XPath("//*[@id='a18']");
          By _frame_1 = By.XPath("//*[@id='iframeMain']");
          By _frame_2 = By.XPath("//*[@name='appFrame']");
          By _frame_3 = By.XPath("//*[@id='ifPages']");
          By _testserch = By.XPath("//*[@pageid='s']");
          By _testname = By.XPath("//*[text()='Name:']//child::input[@id='txtSearch']");
       

        public void HomePageDisplayed()
        {
            driver.FindElement(Location).Click();
           IWebElement _secloc = driver.FindElement(Location1);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            wait.Until(e => (_secloc));
            OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(driver);
                for (int i=0; i<17; i++) 
            { 
                actions.SendKeys(Keys.ArrowDown).Perform(); 
            }
            driver.FindElement(submit).Click();

            
        }
        public void Logout()
        {
            Thread.Sleep(3000);
            
            IWebElement _frame = driver.FindElement(Frame);
           driver.SwitchTo().Frame(_frame);
            IWebElement _assert = driver.FindElement(homePageAssertion);
            string _valid = _assert.Text;
            Assert.That(_valid, Is.EqualTo("User:sunquest"), "error");
            driver.SwitchTo().DefaultContent();

            //driver.FindElement(_admin).Click();

            /*IWebElement _logoff = driver.FindElement(table);
           
            IJavaScriptExecutor _executor = (IJavaScriptExecutor)driver;
            _executor.ExecuteScript("arguments[0].click();", _logoff);
            Thread.Sleep(5000);
            driver.FindElement(_sig).Click();*/


            /* driver.FindElement(logoff).Click();
              driver.FindElement(_sig).Click();*/
            /*------------------------------------------------------------------------------------------------------------------------------------------*/
            /* driver.SwitchTo().Frame(_frame);
             driver.FindElement(_patientsearch).SendKeys("kumar");
             driver.FindElement(_patientclick).Click();
             driver.FindElement(_selectpatient).Click();
             driver.SwitchTo().DefaultContent();
             driver.FindElement(_Req).Click();
             driver.FindElement(_newreq).Click();
             Thread.Sleep(3000);
             IWebElement _frame_ = driver.FindElement(_frame_1);
             driver.SwitchTo().Frame(_frame_);
             Thread.Sleep(5000);
             IWebElement _frame_s = driver.FindElement(_frame_2);
             driver.SwitchTo().Frame(_frame_s);

             IWebElement _frame_s1 = driver.FindElement(_frame_3);
             driver.SwitchTo().Frame(_frame_s1);
             driver.FindElement(_testserch).Click();
             Thread.Sleep(5000);
             driver.FindElement(_testname).SendKeys("magnesium");*/
            /*------------------------------------------------------------------------------------------------------------------------------------------*/
            

        }
    }
}