Feature: DataDrivenWithExamples
	In order not to repeat my data or to be able to update my data
	As a guru tester
	I want to add my data to the feature file

@mytag
Scenario Outline: Validate Form Examples
	Given I navigate to site"https://www.giftrete.com"
	And I navigate to site"https://blueskycitadel.com/automation-testing-form/"
	When I enter email "<Email>"
	And I enter password "<Password>"
	And I click on the Submit button
	Then the form will be submited
    Examples:
	| Email                | Password          |
	| testemail@yahoo.com  | mysecurepassword  |
	| testemail1@yahoo.com | mysecurepassword1 |