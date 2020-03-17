Feature: BlueSkyCitadelTestingForm
	In order to be a guru tester
	I want to test the BlueSky Citadel Testing Form
	Which has a lot of elements that i will be automating in future

@regression @blueskyform
Scenario: Valid Form Submission
	Given I navigate to the BlueSky Testing Form
	When I enter the Single Line Text
	And I select One in the Select box
	And I enter Email
	And I enter Password
	And I select the Multi-Select
	And I select the Radio List
	And I select the Checkbox List
	And I select United Kingdom as Country
	And I select 12th of the current month
	And I select Single Checkbox
	And I enter Paragraph Text "Text"
	And i click on the Submit button
	Then the message "Your form has been successfully submitted. "
	And the page url is "https://blueskycitadel.com/automation-testing-form/"

	Scenario: Invalid Form Submission
	Given I navigate to the BlueSky Testing Form
	When I enter the Single Line Text
	And I select One in the Select box
	And I enter Email
	#And I enter Password
	And I select the Multi-Select
	And I select the Radio List
	And I select the Checkbox List
	And I select United Kingdom as Country
	And I select 12th of the current month
	And I select Single Checkbox
	And I enter Paragraph Text "Text"
	And i click on the Submit button
	Then the error message "Please correct errors before submitting this form."

#nf-form-9-cont > div > div.nf-response-msg > p:nth-child(1)

#nf-form-9-cont > div > div.nf-response-msg > p:nth-child(1)