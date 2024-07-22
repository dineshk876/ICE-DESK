using BDD_AutomationTests.Pages;
using ICE_Desktop.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Runtime.Intrinsics.X86;
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


        [When(@"Select (.*) from Organisation Dropdown")]
        public void WhenSelectAllOrganisationsFromOrganisationDropdown(string name1)
        {
            _updateLocationPage.Locationorg(name1);
        }

        [When(@"Search (.*) for location")]
        public void WhenSearchZtestForLocation(string name)
        {
            _updateLocationPage.searchlocation(name);
        }

        [When(@"Click Edit button")]
        public void WhenClickEditButton()
        {
            _updateLocationPage.editlocation();
        }

        [When(@"select main or sub (.*) from dropdown")]
        public void WhenSelectMainOrSubAllOrganisationsFromDropdown(string loc)
        {
            _updateLocationPage.orglocation(loc);
            
        }


        /*  [When(@"Click edit button")]
          public void WhenClickEditButton(string loc)
          {
              _updateLocationPage.editlocation();
              
          }*/

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


        [When(@"Click Add/update Rooms button")]
        public void WhenClickAddUpdateRoomsButton()
        {
            _updateLocationPage.Locroom(); 
        }

        [When(@"Click edit button on required room")]
        public void WhenClickEditButtonOnRequiredRoom()
        {
            _updateLocationPage.Locroomname(); 
        }

        [Then(@"Verify Location room is active")]
        public void ThenVerifyLocationRoomIsActive()
        {
            _updateLocationPage.Roomactive();
        }

        [When(@"Select Active location dropdown")]
        public void WhenSelectActiveLocationDropdown()
        {
            _updateLocationPage.Activelocfilter();
        }

        [When(@"Search for Inactive (.*)")]
        public void WhenSearchForInactiveJacksonWard(string locat)
        {
            _updateLocationPage.searchlocations(locat);
        }


      /*  [Then(@"Verify only Active locations are displayed")]
        public void ThenVerifyOnlyActiveLocationsAreDisplayed()
        {
            //_updateLocationPage.verifyactiveloc();
            *//*Assert.IsTrue(locationSearchPage.IsSearchResultDisplayed(searchText));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(noresult,"no result");*//*
        }*/

        [Then(@"Verify only Active (.*) are displayed")]
        public void ThenVerifyOnlyActiveJacksonWardAreDisplayed(string locat)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(_updateLocationPage.VerifyActiveloc(locat));
        }


        [When(@"Select InActive location dropdown")]
        public void WhenSelectInActiveLocationDropdown()
        {
            _updateLocationPage.InActivelocfilter();
        }

        [When(@"Search for Active (.*)")]
        public void WhenSearchForActiveICEFT_Acc(string locat)
        {
            _updateLocationPage.searchlocations(locat);
        }

        [Then(@"Verify only InActive (.*) are displayed")]
        public void ThenVerifyOnlyInActiveICEFT_AccAreDisplayed(string locat)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(_updateLocationPage.VerifyInActiveloc(locat));
        }

    }
}
