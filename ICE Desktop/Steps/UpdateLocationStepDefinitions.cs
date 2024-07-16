using BDD_AutomationTests.Pages;
using ICE_Desktop.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ICE_Desktop.Steps
{
    [Binding]
    public class UpdateLocationStepDefinitions
    {
        IWebDriver driver;
        UpdateLocationPage _updateLocationPage;

        public UpdateLocationStepDefinitions(IWebDriver driver, UpdateLocationPage updateLocationPage)
        {
            this.driver = driver;
            _updateLocationPage = updateLocationPage;
        }


        [When(@"click Locations editor")]
        public void WhenClickLocationsEditor()
        {
            _updateLocationPage.Locationeditor();
        }

        [When(@"Select required organization from Dropdown")]
        public void WhenSelectRequiredOrganizationFromDropdown()
        {
            _updateLocationPage.Locationorg();
        }

        [When(@"Search Location")]
        public void WhenSearchLocation()
        {
            _updateLocationPage.searchlocation();
        }

        [When(@"Click edit buuton")]
        public void WhenClickEditBuuton()
        {
            _updateLocationPage.editlocation();
            _updateLocationPage.orglocation();
        }

        [Then(@"Verify Is a GP practice Check box is enabled")]
        public void ThenVerifyIsAGPPracticeCheckBoxIsEnabled()
        {
            _updateLocationPage.GP();
        }

        [Then(@"verify Allow Interop to forward to New ICE checkbox is enabled")]
        public void ThenVerifyAllowInteropToForwardToNewICECheckboxIsEnabled()
        {
            _updateLocationPage.Interop();
        }

        [Then(@"verify ActiveCheck box is enabled")]
        public void ThenVerifyActiveCheckBoxIsEnabled()
        {
            _updateLocationPage.Active();
            _updateLocationPage.Update();
        }
    }
}
