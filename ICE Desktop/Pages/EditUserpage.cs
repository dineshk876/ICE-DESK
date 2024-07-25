using BDD_AutomationTests.Behavior;
using BDD_AutomationTests.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Nest.JoinField;

namespace ICE_Desktop.Pages
{
    public class EditUserpage
    {
        public IWebDriver driver;

        public EditUserpage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By _frame_1 = By.XPath("//*[@id='iframeMain']");
        By _frame_2 = By.XPath("//*[@name='appFrame']");
        By _Adduser = By.XPath("//*[@id='Administration']//child::a[@id='a151']");
        By _searchuser = By.XPath("//input[@id='SearchTextBox']");
        By _searchbutton = By.XPath("//input[@id='SearchButton']");
        By _user = By.XPath("//tr[@title='zuser (active)']//td[2]");
        By _toolbar = By.XPath("//*[@id='divToolBar']//child::img[@id='imgTB']");
        By _scrolldown = By.XPath("//*[@id='divTB']//child::td[text()='Clinician Referrals']");
        By _viewwardrep = By.XPath("//*[@id='EDMAC']//child::span[@toolbarItemIndex='5']");
        
        By _viewpatientrep = By.XPath("//*[@id='EDMAC']//child::span[@toolbarItemIndex='6']");
        By _hiderepbypatient = By.XPath("//*[@id='EDMAC']//child::span[@toolbarItemIndex='27']");
        By _hiderepbysample = By.XPath("//*[@id='EDMAC']//child::span[@toolbarItemIndex='28']");
        By _CumulativeReports = By.XPath("//*[@id='EDMAC']//child::span[@toolbarItemIndex='29']");
        By _LatestReports = By.XPath("//*[@id='EDMAC']//child::span[@toolbarItemIndex='80']");
        By _OpenNetPatientRep = By.XPath("//*[@id='EDMAC']//child::span[@toolbarItemIndex='166']");
        By _OpenNetWardrep = By.XPath("//*[@id='EDMAC']//child::span[@toolbarItemIndex='530']");
        By _savechanges = By.XPath("//*[@id='btnCommand']");
        By _successmessage = By.XPath("//*[@id='messageDisplay']");
        public void AddeditUser()
        {
            driver.FindElement(_Adduser).Click();

        }

        public void SelectUser(string user)
        {
            IWebElement _frame_ = driver.FindElement(_frame_1);
            driver.SwitchTo().Frame(_frame_);

            IWebElement _frame_s = driver.FindElement(_frame_2);
            driver.SwitchTo().Frame(_frame_s);
            driver.FindElement(_searchuser).SendKeys(user);
            driver.FindElement(_searchbutton).Click();
            Baseclass.WaitForElementToBeVisible(driver, _user, 10);
            driver.FindElement(_user).Click();
        }
        public void Toolbar()
        {
            driver.FindElement(_toolbar).Click();
        }

        public void Scrolldown()
        {
         IWebElement sd =   driver.FindElement(_scrolldown);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", sd);
        }

        public void options()
        {
            IWebElement checkbox = driver.FindElement(_viewwardrep);
            IWebElement vwrp = driver.FindElement(_viewwardrep);
            string vwp = vwrp.GetAttribute("style");
            if(vwp.Contains("COLOR: green") )
            {
                checkbox.Click();
            }

            /*driver.FindElement(_viewpatientrep).Click();
            driver.FindElement(_hiderepbypatient).Click();
            driver.FindElement(_hiderepbysample).Click();
            driver.FindElement(_CumulativeReports).Click();
            driver.FindElement(_LatestReports).Click();
            driver.FindElement(_OpenNetPatientRep).Click();
            driver.FindElement(_OpenNetWardrep).Click();*/
        }
        public void Savechanges()
        {
            driver.FindElement(_savechanges).Click();
        }
        public string successmessage()
        {
            Thread.Sleep(2000);
            return driver.FindElement(_successmessage).Text;           
        }
    }
}