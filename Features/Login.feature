Feature: Login


@login
Scenario: Login with valid credentials
	Given I enter username Ginny and password Pa$$w0rd
	When I click login button
	Then I should be logged in

@login
Scenario: Login with invalid credentials
	Given I enter username reaper and password password
	When I click login button
	Then I should not be logged in