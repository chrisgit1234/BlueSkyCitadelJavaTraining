using BlueSkyProject1.PageObjects;
using TechTalk.SpecFlow;

namespace BlueSkyProject1.StepDefinitions
{
    [Binding]
    public class DataDrivenWithinFeatureStepSteps
    {

        AutomationTestingFormPage automationTestingFormPage;

        public DataDrivenWithinFeatureStepSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }



        [Given(@"I navigate to site""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            automationTestingFormPage.NavigateToFormWithParameter(url);
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            automationTestingFormPage.EnterEmailAddress(email);
        }

        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            automationTestingFormPage.EnterPasswordText(password);
        }

        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {

        }

        [Then(@"the form will be submited")]
        public void ThenTheFormWillBeSubmited()
        {

        }
    }
}
