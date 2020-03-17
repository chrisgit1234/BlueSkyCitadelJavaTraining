using BlueSkyProject1.Hooks;
using OpenQA.Selenium;

namespace BlueSkyProject1.PageObjects
{
    class DataTablePage
    {
        IWebDriver driver;

        IWebElement enterEmailAddress => driver.FindElement(By.Name("email"));

        IWebElement passwordText => driver.FindElement(By.Id("nf-field-144"));

        public void EnterEmailAndPassword(string email, string password)
        {
            enterEmailAddress.SendKeys(email);
            passwordText.SendKeys(password);
        }

        public DataTablePage()
        {
            driver = Hook.driver;
        }

    }
}
