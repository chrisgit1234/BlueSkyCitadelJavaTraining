using BlueSkyProject1.PageObjects;
using FluentAssertions;
using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;

namespace BlueSkyProject1.StepDefinitions
{
    [Binding]
    public class BlueSkyCitadelTestingFormSteps
    {

        AutomationTestingFormPage automationTestingFormPage;
        public BlueSkyCitadelTestingFormSteps()

        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }
        [Given(@"I navigate to the BlueSky Testing Form")]
        public void GivenINavigateToTheBlueSkyTestingForm()

        {
            automationTestingFormPage.NavigateToForm();

        }

        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            automationTestingFormPage.EnterPasswordText();
        }


        [When(@"I enter the Single Line Text")]
        public void WhenIEnterTheSingleLineText()
        {
            automationTestingFormPage.EnterSingleLineText();

        }

        [When(@"I select One in the Select box")]
        public void WhenISelectOneInTheSelectBox()
        {
            automationTestingFormPage.SelectOneFromSelectOneTwoThree();
        }

        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            automationTestingFormPage.EnterEmailAddress();

        }

        [When(@"I select the Multi-Select")]
        public void WhenISelectTheMulti_Select()
        {
            automationTestingFormPage.SelectMultiSelector();
        }

        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {
            automationTestingFormPage.SelectOneFromSelectOneTwoThree();
        }

        [When(@"I select the Checkbox List")]
        public void WhenISelectTheCheckboxList()
        {
            automationTestingFormPage.selectTwofromCheckBoxList();
        }

        [When(@"I select United Kingdom as Country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {
            automationTestingFormPage.SelectCountry();
        }

        [When(@"I select (.*)th of the current month")]
        public void WhenISelectThOfTheCurrentMonth(int p0)
        {
            automationTestingFormPage.SelectDateFromCalendar();
        }

        [When(@"I select Single Checkbox")]
        public void WhenISelectSingleCheckbox()
        {
            automationTestingFormPage.SingleCheckBox();
        }


        [When(@"I enter Paragraph Text ""(.*)""")]
        public void WhenIEnterParagraphText(string text)
        {
            automationTestingFormPage.EnterParagraphText();
        }


        [When(@"i click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            automationTestingFormPage.ClickOnSubmitButton();

        }

        [Then(@"the error message ""(.*)""")]
        public void ThenTheErrorMessage(string errorMessage)
        {
            //automationTestingFormPage.CheckErrorMsgIsDisplayed();
           //Thread.Sleep(1000);
            Assert.AreEqual(errorMessage, automationTestingFormPage.GetTextForErrorMsg());
        }


        [Then(@"the message ""(.*)""")]
        public void ThenTheMessage(string message)
        {
            //Assert.AreEqual(message, automationTestingFormPage.GetTextForMsg());
            Thread.Sleep(1000);
            Assert.AreEqual(message, automationTestingFormPage.GetTextForSuccessMessage());
        }

        [Then(@"the page url is ""(.*)""")]
        public void ThenThePageUrlIs(string url)
        {
            //Assert.AreEqual(url, automationTestingFormPage.GetPageUrl());

            url.Should().Be(automationTestingFormPage.GetPageUrl());
        }

    }
}
