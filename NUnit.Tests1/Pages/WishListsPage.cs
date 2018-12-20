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
    class WishListsPage
    {
        IWebDriver webdriver;
        public WishListsPage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }
        #region objects
        private IWebElement MyWishesList
        {
            get
            {
                return webdriver.FindElement(By.XPath("//*[@id='myAccount']/div[3]/ul/li[1]/div/a[1]"));
            }
        }
        #endregion
        #region Methods
        public void ClickMyWishesList()
        {
            MyWishesList.Click();
        }
        #endregion
    }
}
