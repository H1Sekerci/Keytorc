using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace NUnit.Tests1.Pages
{
    class LoginPage
    {
        IWebDriver webdriver;
        public LoginPage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        #region objects

        private IWebElement EmailTextBox
        {
            get
            {
                return webdriver.FindElement(By.Id("email"));
            }
        }
        private IWebElement PasswordTextBox
        {
            get
            {
                return webdriver.FindElement(By.Id("password"));
            }
        }
        private IWebElement LoginButton
        {
            get
            {
                return webdriver.FindElement(By.Id("loginButton"));
            }
        }
        #endregion

        #region Methods
        public string LogintoN11 (string username, string password)
        {
            EmailTextBox.SendKeys(username);
            PasswordTextBox.SendKeys(password);
            string LoginPageTitle = webdriver.Title;
            LoginButton.Click();
            return LoginPageTitle;
        }
        #endregion
    }
}
