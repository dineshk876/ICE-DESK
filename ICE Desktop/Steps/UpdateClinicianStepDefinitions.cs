using BDD_AutomationTests.Behavior;
using BDD_AutomationTests.Pages;
using ICE_Desktop.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using static BDD_AutomationTests.Behavior.ExecuteLoginBehavior;

namespace ICE_Desktop.Steps
{
    [Binding]
    public class UpdateClinicianStepDefinitions
    {
        IWebDriver driver;
        LoginPage _loginPage;
        Updateclinicianpage _updateClinicianPageDefinition;
        HomePage _homePage;
        public UpdateClinicianStepDefinitions(IWebDriver driver, Updateclinicianpage updateClinicianPageDefinition)
        {
            this.driver = driver;
            _loginPage = new LoginPage(driver);
            _updateClinicianPageDefinition = updateClinicianPageDefinition;
             _homePage = new HomePage(driver);
        }


        [Given(@"user Login with ICE application")]
        public void GivenUserLoginWithICEApplication()
        {
            new singlelogin(_loginPage).login();
            new ExecuteLoginBehavior(_homePage).Perform1();

        }

        [When(@"Navigate to Desktop configuration")]
        public void WhenNavigateToDesktopConfiguration()
        {
            _updateClinicianPageDefinition.DesktopConfig();
        }

        [When(@"Click Clinician editor")]
        public void WhenClickClinicianEditor()
        {
            _updateClinicianPageDefinition.Clinicianeditor();
        }

        [When(@"Enter Clinician name in search field")]
        public void WhenEnterClinicianNameInSearchField()
        {
            _updateClinicianPageDefinition.Clinicianname();
        }

        [When(@"Click Search button")]
        public void WhenClickSearchButton()
        {
            _updateClinicianPageDefinition.Cliniciansearch();
        }

        [When(@"Select Edit button")]
        public void WhenSelectEditButton()
        {
            _updateClinicianPageDefinition.editclinician();
        }

        [When(@"Click Clinician Location Mappings add button")]
        public void WhenClickClinicianLocationMappingsAddButton()
        {
            _updateClinicianPageDefinition.Clinicianlocation();
        }

        [When(@"Select location from the list")]
        public void WhenSelectLocationFromTheList()
        {
            _updateClinicianPageDefinition.Selectlocation();
        }

        [When(@"Click Right arrow")]
        public void WhenClickRightArrow()
        {
            _updateClinicianPageDefinition.rightarrow();
        }

        [Then(@"Click Update")]
        public void ThenClickUpdate()
        {
            _updateClinicianPageDefinition.Updateclinician();
        }
    }
}