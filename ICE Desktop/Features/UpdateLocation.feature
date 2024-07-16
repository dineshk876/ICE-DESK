Feature: UpdateLocation using organization and verify required options are enabled

User can update location editor and verify required options are enabled

@tag1
Scenario: Verify mandatory check box are enabled
	Given user Login with ICE application
	When Navigate to Desktop configuration
	And click Locations editor 
	And Select required organization from Dropdown 
	And Search Location 
	And Click edit buuton
	Then Verify Is a GP practice Check box is enabled
	And verify Allow Interop to forward to New ICE checkbox is enabled
	And verify ActiveCheck box is enabled