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
	Then Select location from the list and Update
	

@tag2
Scenario: Remove location mapping
	Given user Login with ICE application
	When Navigate to Desktop configuration
	And Click Clinician editor
	And Enter Clinician name in search field
	And Click Search button
	And Select Edit button
	And Click Clinician Location Mappings add button
	Then Deselect specific Location from the list and update

@tag3
Scenario: Verify Clinician is a GP checkbox is selected
	Given user Login with ICE application
	When Navigate to Desktop configuration
	And Click Clinician editor
	And Enter Clinician name in search field
	And Click Search button
	And Select Edit button
	Then verify checkbox is selected or not
	
	