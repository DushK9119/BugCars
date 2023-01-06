Feature: Logout
	

@logout
Scenario: Logout
	Given I am logged in
	When I click logout button
	Then I should be logged out