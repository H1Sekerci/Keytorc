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
    class FavouritesPage
    {
        IWebDriver webdriver;
        public FavouritesPage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }
        #region objects
        private IWebElement DeleteFavouritesButton
        {
            get
            {
                return webdriver.FindElement(By.XPath("//*[@id='p-296504208']/div[3]/span"));
            }
        }
        #endregion

        #region Methods
        public void ClikDeleteFavouritesButton()
        {
            DeleteFavouritesButton.Click();
        }

        public string VerifyProductExist()
        {
            string product = webdriver.FindElement(By.XPath("//*[@id='p-296504208']/div[1]/a[1]")).Text;
            return product;
        }

        public string VerifyProductDeleted()
        {
            string empty = webdriver.FindElement(By.XPath("//*[@id='watchList']/div")).Text;          
            return empty;
        }
        #endregion
    }
}
