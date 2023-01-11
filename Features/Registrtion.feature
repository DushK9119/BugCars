Feature: Registration 

Background:
	Given I am in registration page

@registration
Scenario: Register with valid data
	Given I enter  user credentials
	| Username | FirstName | LastName | Password | ConfirmPassword |
	| Ginny   | Ginny      | Georgia     | Pa$$w0rd | Pa$$w0rd|
	When I click on register button
	Then I will be registered
		And I should be able to login using the registered login credentials

@registration
Scenario: Register as an existing user
	Given I enter my user detail
	| Username | FirstName | LastName | Password | ConfirmPassword |
	| Ginny  | Ginny      | Georgia    | Pa$$w0rd | Pa$$w0rd|
	When I click on register button
	Then I should see user already exist error
