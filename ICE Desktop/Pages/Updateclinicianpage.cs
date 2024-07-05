using BDD_AutomationTests.Drivers;
using Nest;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICE_Desktop.Pages
{
    public class Updateclinicianpage
    {
        public IWebDriver driver;

        public Updateclinicianpage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By _frame_1 = By.XPath("//*[@id='iframeMain']");
        By _frame_2 = By.XPath("//*[@name='appFrame']");
        By _Desktopconfig = By.XPath("//*[@id='Administration']//child::a[@id='a153']");
        By _cinician = By.XPath("//*[@name='frmIndex']//child::a[normalize-space()='Clinicians editor']");
        By _cliniciansrch = By.XPath("//*[@name='frmEditor']//child::input[@name='txtFindName']");
        By _clinsrch = By.XPath("//*[@name='frmEditor']//child::input[@name='btnSearch']");
        By _editclinician = By.XPath("//*[@class='searchResultsGrid']//child::input[@name='dtaClinicians$ctl03$ctl00']");
        By _locamap = By.XPath("//*[@valign='top']//child::img[@id='imgLM']");
        By _org = By.XPath("//select[@id='LocOrganisationList']");
        By _loc1 = By.XPath("//select[@id='LocationListBox']");
        By _selectloc = By.XPath("//input[@id='AddButton']");
        By _updateclini = By.XPath("//input[@id='btnUpdate']");

        public void DesktopConfig()
        {
            driver.FindElement(_Desktopconfig).Click();
        }
        public void Clinicianeditor()
        {
            IWebElement _frame_ = driver.FindElement(_frame_1);
            driver.SwitchTo().Frame(_frame_);
            Thread.Sleep(5000);
            IWebElement _frame_s = driver.FindElement(_frame_2);
            driver.SwitchTo().Frame(_frame_s);
            driver.FindElement(_cinician).Click();
        }
        public void Clinicianname()
        {
            driver.FindElement(_cliniciansrch).SendKeys("AGHA B");
        }

        public void Cliniciansearch()
        {
            driver.FindElement(_clinsrch).Click();
        }

        public void editclinician()
        {
            driver.FindElement(_editclinician).Click();
        }

        public void Clinicianlocation()
        {
            driver.FindElement(_locamap).Click();
        }

        public void Selectlocation()
        {
            Thread.Sleep(5000);
            driver.FindElement(_org).Click();
            OpenQA.Selenium.Interactions.Actions actions1 = new OpenQA.Selenium.Interactions.Actions(driver);
            actions1.SendKeys(Keys.Tab);
            for (int i = 0; i < 21; i++)
            {
                actions1.SendKeys(Keys.ArrowDown).Perform();
            }
        }

        public void rightarrow()
        {
            Thread.Sleep(5000);
            driver.FindElement(_selectloc).Click();
        }

        public void Updateclinician()
        {

            driver.FindElement(_updateclini).Click();
            IAlert Ok = driver.SwitchTo().Alert();
            Ok.Accept();
        }
    }
}
