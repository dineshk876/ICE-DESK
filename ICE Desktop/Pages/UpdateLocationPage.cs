using BDD_AutomationTests.Behavior;
using Nest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using NUnit.Framework.Interfaces;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace ICE_Desktop.Pages
{
    public class UpdateLocationPage
    {
        public IWebDriver driver;

        public UpdateLocationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By _frame_1 = By.XPath("//*[@id='iframeMain']");
        By _frame_2 = By.XPath("//*[@name='appFrame']");
        By _Locationeditor = By.XPath("//a[normalize-space()='Locations editor']");
        By _locorg = By.XPath("//select[@id='filterByOrganisation']");
        By _locname = By.XPath("//input[@id='txtFindName']");
        By _edloc = By.XPath("//input[@name='dtaLocations$ctl03$ctl00']");
        By _orgloc = By.XPath("//select[@id='ddlOrganisationList']");
        By _serch = By.XPath("//input[@id='btnSearch']");
        By _gp = By.XPath("//input[@id='chkPractice']");
        By _interop = By.XPath("//input[@id='InteropAutoForwardCheckBox']");
        By _active = By.XPath("//input[@id='chkActive']");
        By _update = By.XPath("//input[@id='btnUpdate']");
        By _locroom = By.XPath("//input[@id='btnGotoRooms']");
        By _locroomname = By.XPath("//input[@name='dtaRooms$ctl03$ctl00']");
        By _roomactive = By.XPath("//input[@id='chkRoomActive']");
        By _updateroom = By.XPath("//input[@id='btnRoomUpdate']");
        By _backtoloc = By.XPath("//input[@id='btnGoToPage2']");
        By _activelocfilter = By.XPath("//select[@id='ddlFilter']");
        By _verifyactiveloc = By.XPath("//*[@class='dataGrid']//tr[3]");


        public void Locationeditor()
        {
            IWebElement _frame_ = driver.FindElement(_frame_1);
            driver.SwitchTo().Frame(_frame_);

            IWebElement _frame_s = driver.FindElement(_frame_2);
            driver.SwitchTo().Frame(_frame_s);
            driver.FindElement(_Locationeditor).Click();
        }
        public void Locationorg(string name1)
        {
            IWebElement s1 = driver.FindElement(_locorg);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            string script = @"
            var dropdown = arguments[0];
            var text = arguments[1];
            for (var i = 0; i < dropdown.options.length; i++) {
                if (dropdown.options[i].text === text) {
                    dropdown.selectedIndex = i;
                    var event;
                    if (typeof(Event) === 'function') {
                        event = new Event('change', { bubbles: true });
                    } else if (document.createEvent) {
                        event = document.createEvent('Event');
                        event.initEvent('change', true, true);
                    } else if (document.createEventObject) { // IE-specific
                        event = document.createEventObject();
                        event.eventType = 'change';
                    }
                    if (event) {
                        if (dropdown.dispatchEvent) {
                            dropdown.dispatchEvent(event);
                        } else if (dropdown.fireEvent) { // IE-specific
                            dropdown.fireEvent('onchange', event);
                        }
                    }
                    break;
                }
            }
        ";

            // Execute the script to select the option by visible text
            js.ExecuteScript(script, s1, name1);
        }

        public void searchlocation(string name)
        {
            Thread.Sleep(5000);
            driver.FindElement(_locname).SendKeys(name);
            driver.FindElement(_serch).Click();
        }

        public void editlocation()
        {

            driver.FindElement(_edloc).Click();

        }

        public void orglocation(string loc)
        {
            Thread.Sleep(5000);
            IWebElement s2 = driver.FindElement(_orgloc);

            // Initialize the SelectElement for the dropdown
            SelectElement selectElement = new SelectElement(s2);

            // Get the currently selected option using JavaScript
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string selectedOption = (string)js.ExecuteScript("return arguments[0].options[arguments[0].selectedIndex].text;", s2);

            // Check if the selected option is the same as the provided location
            if (selectedOption != loc)
            {
                // Use JavaScript to select the provided location
                js.ExecuteScript(@"
            var select = arguments[0];
            var loc = arguments[1];
            
            for (var i = 0; i < select.options.length; i++) {
               
                if (select.options[i].text === loc) {
                    select.selectedIndex = i;
                    
                    var event;
                    if (typeof(Event) === 'function') {
                        event = new Event('change', { bubbles: true });
                    } else {
                        if (document.createEvent) {
                            event = document.createEvent('HTMLEvents');
                            event.initEvent('change', true, false);
                        } else if (document.createEventObject) { // IE < 9
                            event = document.createEventObject();
                            select.fireEvent('onchange', event);
                            return;
                        }
                    }
                    select.dispatchEvent(event);
                    break;
                }
            }
        ", s2, loc);
                Thread.Sleep(5000);
                IAlert Ok = driver.SwitchTo().Alert();
                Ok.Accept();
            }
        }
        public void GP()
        {
            Baseclass.WaitForElementToBeVisible(driver, _gp, 10);
            IWebElement checkbox = driver.FindElement(_gp);
            if (!checkbox.Selected)
            {
                checkbox.Click();

            }
        }
        public void Interop()
        {
            Baseclass.WaitForElementToBeVisible(driver, _interop, 10);
            IWebElement checkbox = driver.FindElement(_interop);
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }
        }
        public void Active()
        {
            Baseclass.WaitForElementToBeVisible(driver, _active, 10);
            IWebElement checkbox = driver.FindElement(_active);
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }
        }

        public void Update()
        {
            driver.FindElement(_update).Click();
            IAlert Ok = driver.SwitchTo().Alert();
            Ok.Accept();
        }

        public void Locroom()
        {
            driver.FindElement(_locroom).Click();
        }

        public void Locroomname()
        {
            driver.FindElement(_locroomname).Click();
        }
        public void Roomactive()
        {
            Baseclass.WaitForElementToBeVisible(driver, _roomactive, 10);
            IWebElement checkbox = driver.FindElement(_roomactive);
            if (!checkbox.Selected)
            {
                checkbox.Click();
                driver.FindElement(_updateroom).Click();
            }
            else
            {
                driver.FindElement(_backtoloc).Click();
            }
        }

        public void Activelocfilter()
        {
            Thread.Sleep(4000);
            IWebElement s3 = driver.FindElement(_activelocfilter);
           
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            string script = @"
            var dropdown = arguments[0];
            var text = arguments[1];
            for (var i = 0; i < dropdown.options.length; i++) {
                if (dropdown.options[i].text === text) {
                    dropdown.selectedIndex = i;
                    var event;
                    if (typeof(Event) === 'function') {
                        event = new Event('change', { bubbles: true });
                    } else if (document.createEvent) {
                        event = document.createEvent('Event');
                        event.initEvent('change', true, true);
                    } else if (document.createEventObject) { // IE-specific
                        event = document.createEventObject();
                        event.eventType = 'change';
                    }
                    if (event) {
                        if (dropdown.dispatchEvent) {
                            dropdown.dispatchEvent(event);
                        } else if (dropdown.fireEvent) { // IE-specific
                            dropdown.fireEvent('onchange', event);
                        }
                    }
                    break;
                }
            }
        ";
            // Execute the script to select the option by visible text
            js.ExecuteScript(script, s3, "Only active locations");
            
        }

        public void searchlocations(string locat)
        {

            Thread.Sleep(5000);
            driver.FindElement(_locname).SendKeys(locat);
            
            driver.FindElement(_serch).Click();
                    
        }
        public bool VerifyActiveloc(string locat)
        {
           IWebElement loctext = driver.FindElement(_verifyactiveloc);
            return loctext.Text.Contains(locat);
        }
        public void InActivelocfilter()
        {
            Thread.Sleep(4000);
            IWebElement s3 = driver.FindElement(_activelocfilter);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            string script = @"
            var dropdown = arguments[0];
            var text = arguments[1];
            for (var i = 0; i < dropdown.options.length; i++) {
                if (dropdown.options[i].text === text) {
                    dropdown.selectedIndex = i;
                    var event;
                    if (typeof(Event) === 'function') {
                        event = new Event('change', { bubbles: true });
                    } else if (document.createEvent) {
                        event = document.createEvent('Event');
                        event.initEvent('change', true, true);
                    } else if (document.createEventObject) { // IE-specific
                        event = document.createEventObject();
                        event.eventType = 'change';
                    }
                    if (event) {
                        if (dropdown.dispatchEvent) {
                            dropdown.dispatchEvent(event);
                        } else if (dropdown.fireEvent) { // IE-specific
                            dropdown.fireEvent('onchange', event);
                        }
                    }
                    break;
                }
            }
        ";
            // Execute the script to select the option by visible text
            js.ExecuteScript(script, s3, "Only inactive locations");

        }
        public bool VerifyInActiveloc(string locat)
        {
            IWebElement loctext = driver.FindElement(_verifyactiveloc);
            return loctext.Text.Contains(locat);
        }
    }
}
    
        
    

