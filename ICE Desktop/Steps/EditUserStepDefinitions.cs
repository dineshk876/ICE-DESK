using ICE_Desktop.Pages;
using OpenQA.Selenium;
using System;
using System.Runtime.Intrinsics.X86;
using TechTalk.SpecFlow;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace ICE_Desktop.Steps
{
    [Binding]
   
    public class EditUserStepDefinitions
    { 
         IWebDriver driver;
        EditUserpage _edituserpage;
        public EditUserStepDefinitions(IWebDriver driver ,EditUserpage edituserpage)
    {
        this.driver = driver;
        _edituserpage = edituserpage;
    }

        [When(@"Navigate to Add or Edit User")]
        public void WhenNavigateToAddOrEditUser()
        {
            _edituserpage.AddeditUser();
        }


        [When(@"Select (.*) from the list")]
        public void WhenSelectZtestFromTheList(string user)
        {
            _edituserpage.SelectUser(user);
        }

        [When(@"Click on add button near Toolbar Options")]
        public void WhenClickOnAddButtonNearToolbarOptions()
        {
            _edituserpage.Toolbar();
        }

        [When(@"Scroll down to specific module")]
        public void WhenScrollDownToSpecificModule()
        {
            _edituserpage.Scrolldown();
        }

        [When(@"Enable or disable the required options")]
        public void WhenEnableOrDisableTheRequiredOptions()
        {
            _edituserpage.options();
        }

        [When(@"Click on Save Changes button")]
        public void WhenClickOnSaveChangesButton()
        {
            _edituserpage.Savechanges();
        }

        [Then(@"User will able to get(.*)")]
        public void ThenUserWillAbleToGetTheUserHasBeenSuccessfullyUpdated(string expmessage)
        {
           var actmessage = _edituserpage.successmessage();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expmessage, actmessage,"this message is not crt");
        }

    }
}
