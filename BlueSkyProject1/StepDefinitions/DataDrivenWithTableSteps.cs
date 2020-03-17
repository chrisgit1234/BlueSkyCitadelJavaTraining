using BlueSkyProject1.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BlueSkyProject1.StepDefinitions
{
    [Binding]
    public class DataDrivenWithTableSteps
    {
        DataTablePage dataTablePage;

        public DataDrivenWithTableSteps()
        {
            dataTablePage = new DataTablePage();
        }

        [Given(@"I enter email and password")]
        public void GivenIEnterEmailAndPassword(Table table)
        {
            var emailAndPassword = table.CreateInstance<Details>();

            string email = emailAndPassword.Email;
            string password = emailAndPassword.Password;

            dataTablePage.EnterEmailAndPassword(email, password);


        }
    }
}
