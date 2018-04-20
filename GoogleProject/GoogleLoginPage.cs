using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace GoogleProject
{
    class GoogleLoginPage
    {
        [FindsBy(How = How.Id, Using = "identifierId")]
        private IWebElement _inputField;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement _inputPwdField;

        [FindsBy(How = How.Id, Using = "identifierNext")]
        private IWebElement _emailSubmitBtn;

        [FindsBy(How = How.ClassName, Using = "dEOOab")]
        private IWebElement _errorMsg;

        [FindsBy(How = How.Id, Using = "passwordNext")]
        private IWebElement _pwdSubmitBtn;


        WebDriverWait wait = new WebDriverWait(PropertyCollection.driver, TimeSpan.FromMinutes(1));
        public void Login(string email, string pwd)
        {
            _inputField.SendKeys(email);
            _emailSubmitBtn.Click();

 //           System.Threading.Thread.Sleep(5);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("passwordNext")));

            _inputPwdField.SendKeys(pwd);
            _pwdSubmitBtn.Click();
        }

        public bool ErrorMessageIsDisplayed
        {
            get { return _errorMsg.Displayed; }
        }
    }
}
