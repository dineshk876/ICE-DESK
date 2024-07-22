Feature: UpdateLocation using organization and verify required options are enabled

User can update location editor and verify required options are enabled

@Validation
Scenario: Verify mandatory check box are enabled
	Given user Login with ICE application
	When Navigate to Desktop configuration
	And click Locations editor 
	And Select <organization> from Organisation Dropdown 
	And Search <Location> for location
	And Click Edit button
	And select main or sub <org> from dropdown
	Then Verify Is a GP practice Check box is enabled
	And verify Allow Interop to forward to New ICE checkbox is enabled
	And verify ActiveCheck box is enabled

Examples:
	| organization      | Location     | org               |
	| All organisations | ztest        | Anglia District Hospital (RGN42) |
	|Anglia (AHSL1)   | Johnson Ward | Anglia (AHSL1)    |
	
	
@Validation
Scenario: Verify Location room is active
	Given user Login with ICE application
	When Navigate to Desktop configuration
	And click Locations editor 
	And Select <organization> from Organisation Dropdown 
	And Search <Location> for location
	And Click Edit button
	And Click Add/update Rooms button
	And Click edit button on required room
	Then Verify Location room is active

Examples:
	| organization      | Location |
	| All organisations | ztest    |

@Regression
Scenario: Verify Active Location in search page
	Given user Login with ICE application
	When Navigate to Desktop configuration
	And click Locations editor 
	And Select <organization> from Organisation Dropdown 
	And Select Active location dropdown
	And Search for Inactive <loc>
	Then Verify only Active <loc> are displayed

	Examples:
	| organization      | loc        |
	| All organisations | Location X |

@Regression
Scenario: Verify InActive Location in search page
	Given user Login with ICE application
	When Navigate to Desktop configuration
	And click Locations editor 
	And Select <organization> from Organisation Dropdown 
	And Select InActive location dropdown
	And Search for Active <loc>
	Then Verify only InActive <loc> are displayed

	Examples:
	| organization      | loc       |
	| All organisations | ICEFT-Acc |