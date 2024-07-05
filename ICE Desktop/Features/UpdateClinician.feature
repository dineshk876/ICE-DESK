Feature: Update Clinician with location Map and other options

User can add or remove location mapping and updating other options

@tag1
Scenario: Add location mapping
	Given user Login with ICE application
	When Navigate to Desktop configuration
	And Click Clinician editor
	And Enter Clinician name in search field
	And Click Search button
	And Select Edit button
	And Click Clinician Location Mappings add button
	And Select location from the list
	And Click Right arrow
	Then Click Update

