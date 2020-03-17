Feature: DataDrivenWithTable
		In order not to repeat my data or to be able to update my data
	As a guru tester
	I want to add my data to the feature file

@mytag
Scenario: Validate Form With Table
	Given I navigate to site"https://blueskycitadel.com/automation-testing-form/"
	And I enter email and password
	| Email             | Password   |
	| mytest1l@test.com | mypassword |
