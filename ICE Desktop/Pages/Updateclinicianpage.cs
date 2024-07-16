using BDD_AutomationTests.Behavior;
using BDD_AutomationTests.Drivers;
using Nest;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        By _deselect = By.XPath("//select[@id='ClinicianListBox']");
        By _leftarrow = By.XPath("//input[@id='RemoveButton']");
        By _updateclini = By.XPath("//input[@id='btnUpdate']");
        By _gpcheckbox = By.XPath("//input[@id='chkGP']");

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

            IWebElement dropdown = driver.FindElement(_loc1);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // JavaScript to select an option by its visible text if it exists
            string visibleText = "(AHSL1) Babbage Unit";
            string script = @"
                var select = arguments[0];
                var text = arguments[1];
                var found = false;
                for (var i = 0; i < select.options.length; i++) {
                    if (select.options[i].text === text) {
                        select.selectedIndex = i;
                        var event = document.createEvent ? new Event('change', { bubbles: true }) : document.createEventObject();
                        if (document.createEvent) {
                            select.dispatchEvent(event);
                        } else {
                            select.fireEvent('onchange', event);
                        }
                        found = true;
                        break;
                    }
                }
                return found;"; // return whether the option was found or not

            // Execute the script and get the result
            bool isOptionFound = (bool)jsExecutor.ExecuteScript(script, dropdown, visibleText);

           
            SelectElement selectElement = new SelectElement(dropdown);
            if (isOptionFound && selectElement.SelectedOption.Text == visibleText)
            {
               
                Thread.Sleep(5000);
                driver.FindElement(_selectloc).Click();
                driver.FindElement(_updateclini).Click();
                IAlert Ok = driver.SwitchTo().Alert();
                Ok.Accept();
            }
            else
            {
               
                driver.FindElement(_updateclini).Click();
                IAlert Ok = driver.SwitchTo().Alert();
                Ok.Accept();
            }
            var listelements=driver.FindElements(_deselect);
            string exptext = "(AHSL1) Babbage Unit";
            bool found = listelements.Any(element => element.Text.Contains(exptext));
            if (!found)
            {
                throw new Exception($"'{exptext}' not found in the list");
            }
        }

       
        public void DeselectspecificLocation()
        {
            
            Thread.Sleep(5000);
            /* driver.FindElement(_org).Click();
             OpenQA.Selenium.Interactions.Actions actions1 = new OpenQA.Selenium.Interactions.Actions(driver);
             actions1.SendKeys(Keys.Tab);
             for (int i = 0; i < 3; i++)
             {
                 actions1.SendKeys(Keys.Tab).Perform();
             }
             Thread.Sleep(5000);
             actions1.SendKeys(Keys.ArrowUp).Perform();*/

            IWebElement dropdown = driver.FindElement(_deselect);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            // JavaScript to select an option by its visible text if it exists
            string visibleText = "(AHSL1) Babbage Unit";
            string script = @"
                var select = arguments[0];
                var text = arguments[1];
                var found = false;
                for (var i = 0; i < select.options.length; i++) {
                    if (select.options[i].text === text) {
                        select.selectedIndex = i;
                        var event = document.createEvent ? new Event('change', { bubbles: true }) : document.createEventObject();
                        if (document.createEvent) {
                            select.dispatchEvent(event);
                        } else {
                            select.fireEvent('onchange', event);
                        }
                        found = true;
                        break;
                    }
                }
                return found;"; // return whether the option was found or not

            // Execute the script and get the result
            bool isOptionFound = (bool)jsExecutor.ExecuteScript(script, dropdown, visibleText);


            SelectElement selectElement = new SelectElement(dropdown);
            if (isOptionFound && selectElement.SelectedOption.Text == visibleText)
            {

                Thread.Sleep(5000);
                driver.FindElement(_leftarrow).Click();
                driver.FindElement(_updateclini).Click();
                IAlert Ok = driver.SwitchTo().Alert();
                Ok.Accept();
            }
            else
            {

                driver.FindElement(_updateclini).Click();
                IAlert Ok = driver.SwitchTo().Alert();
                Ok.Accept();
            }

            var listelements = driver.FindElements(_deselect);
            string exptext = "(AHSL1) Babbage Unit";
            bool found = listelements.Any(element => element.Text.Contains(exptext));
            if (found)
            {
                throw new Exception($"'{exptext}'  found in the list");
            }
        }
        public void leftarrow()
        {
            Thread.Sleep(5000);
           
            driver.FindElement(_updateclini).Click();
            IAlert Ok = driver.SwitchTo().Alert();
            Ok.Accept();
        }

        public void verifycheckbox()
        {

            Baseclass.WaitForElementToBeVisible(driver, _gpcheckbox, 10);
            IWebElement checkbox = driver.FindElement(_gpcheckbox);
            if(!checkbox.Selected)
            {
                checkbox.Click();
                driver.FindElement(_updateclini).Click();
                IAlert Ok = driver.SwitchTo().Alert();
                Ok.Accept();
            }
           
        }
    }
}
