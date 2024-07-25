Feature: Check that an administrator can edit a user (Consultant).

User can edit toolbar options and verify required options are enabled or disabled

@tag1
Scenario: Edit Toolbar Options for a user
	Given user Login with ICE application
	When Navigate to Add or Edit User
	And Select <user> from the list
	And Click on add button near Toolbar Options
	And Scroll down to specific module
	And Enable or disable the required options
	And Click on Save Changes button
	Then User will able to get<successmessage>

	Examples:
	| user  | successmessage|
	| zuser |The user has been successfully updated.|