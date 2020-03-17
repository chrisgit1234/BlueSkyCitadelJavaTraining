using BlueSkyProject1.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BlueSkyProject1.PageObjects
{
    class AutomationTestingFormPage
    {
        Waits waits;

        IWebElement singleLineText => driver.FindElement(By.Id("nf-field-135"));

        IWebElement selectOneTwoThree => driver.FindElement(By.Id("nf-field-136"));

        IWebElement multiSelect123 => driver.FindElement(By.CssSelector("#nf-field-137"));

        IWebElement selectRadio => driver.FindElement(By.Id("nf-label-class-field-138-0"));

        IWebElement dateFromCalendar => driver.FindElement(By.CssSelector("#nf-field-141-wrap > div.nf-field-element > div > input.pikaday__display.pikaday__display--pikaday.ninja-forms-field.nf-element.datepicker"));

        IWebElement emailAddress => driver.FindElement(By.Id("nf-field-124"));

        IWebElement submitButton => driver.FindElement(By.Id("nf-field-133"));

        IWebElement selectCountry => driver.FindElement(By.Id("nf-field-140"));

        IWebElement checkBoxList => driver.FindElement(By.Id("nf-label-field-139-1"));

        IWebElement paragraphText => driver.FindElement(By.Id("nf-field-143"));

        //IWebElement enterEmailAddress => driver.FindElement(By.Name("email"));

        IWebElement passwordText => driver.FindElement(By.Id("nf-field-144"));

        IWebElement singleCheckBox => driver.FindElement(By.Id("nf-label-field-142"));

        IWebElement errorMsg => driver.FindElement(By.CssSelector("#nf-form-errors-9 > nf-errors > nf-section > div"));


        IWebElement successMsg => driver.FindElement(By.CssSelector("#nf-form-9-cont > div > div.nf-response-msg > p:nth-child(1)"));


        public string GetPageUrl()
        {
            return driver.Url;
        }

        // public string GetPageTile()
        //{
        //  return driver.Title;
        //}

        public void SingleCheckBox()
        {
            singleCheckBox.Click();
        }


        public string GetTextForErrorMsg()
        {
            return waits.WaitForElement(driver, errorMsg).Text;
           // return errorMsg.Text;
        }

        public string GetTextForSuccessMessage()
        {
            return waits.WaitForElement(driver, successMsg).Text;
        }

        //public void CheckErrorMsgIsDisplayed()
       // {
           // Assert.IsTrue(errorMsg.Displayed);
       // }

       // public void CheckMsgIsDisplayed()
        //{
          //Assert.IsTrue(msg.Displayed);
        //}

        public void EnterPasswordText()
        {
            passwordText.SendKeys("nnenna123");
        }

        public void EnterEmailAddress()
        {
            emailAddress.SendKeys("christeze@yahoo.com");
        }

        public void EnterParagraphText()
        {
            paragraphText.SendKeys("Apologies for my late submision, this was challenging but glad i got here in the end");
        }


        public void selectTwofromCheckBoxList()
        {
            checkBoxList.Click();
        }

        public void EnterPasswordText(string password)
        {
            passwordText.SendKeys(password);
        }

        public void EnterEmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void SelectCountry()
        {
            selectCountry.SendKeys("United Kingdom");
        }

        public void ClickOnSubmitButton()

        {
            submitButton.Click();
        }


        public void SelectDateFromCalendar()
        {
            dateFromCalendar.SendKeys("01/01/2020");
        }

        public void SelectOneFromSelectRadio()
        {
            selectRadio.Click();
        }

        public void SelectMultiSelector()

        {
            SelectElement multiSelector = new SelectElement(multiSelect123);
            multiSelector.SelectByText("Two");
            multiSelector.SelectByText("Three");



        }

        public void SelectOneFromSelectOneTwoThree()
        {
            SelectElement select = new SelectElement(selectOneTwoThree);
            select.SelectByValue("one");
        }

        public void EnterSingleLineText()

        {
            singleLineText.SendKeys("Chris");
        }

        IWebDriver driver;
        public AutomationTestingFormPage()
        {
            driver = Hook.driver;
            waits = new Waits();
        }

        public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("https://blueskycitadel.com/automation-testing-form/");
        }

        public void NavigateToFormWithParameter(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
