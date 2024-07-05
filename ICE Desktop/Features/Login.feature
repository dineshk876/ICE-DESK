Feature: Login with valid and invalid credentials

	//@DataSource:..\TestData\ReportPart.xlsx
	@220267
	Scenario: Login with valid credentials
		Given Login with credentials <UserName> and <Password>
		Then Verify home page is dispalyed
		And Logout the user

		Examples:
			| UserName| Password  |
			| ice\sunquest | ice4dmin |
		
	
	Scenario: Login with invalid credentials
		Given Login with credentials <UserName> and <Password>
		Then Verify invalid credential message is displaying

		Examples:
			| UserName| Password  |
			| ice\sunquest | icedmin |

