using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace NUnit.Tests1.Pages
{
    public class SelectedProductPage
    {
        IWebDriver webdriver;
        public SelectedProductPage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }
        #region objects

        private IWebElement AddWishListButton
        {
            get
            {
                return webdriver.FindElement(By.Id("getWishList"));
            }
        }

        private IWebElement SelectColorDropDown
        {
            get
            {
                return webdriver.FindElement(By.Id("710164867"));
                //710164867 //a6 silikon kılıf
                //701222204 //a8 kapaklı kılıf
            }
        }

        private IWebElement FavouriteWishListButton
        {
            get
            {
                return webdriver.FindElement(By.Id("addToFavouriteWishListBtn"));
            }
        }

        private IWebElement FavouriteWishLisConfirmButton
        {
            get
            {
                return webdriver.FindElement(By.ClassName("btnHolder"));
            }
        }


        #endregion

        #region Methods

        public void ClickAddWishList()
        {
            AddWishListButton.Click();
        }
        public void ClickFavouriteWishList()
        {
            FavouriteWishListButton.Click();
        }

        public void ChangeColor()
        {
            var select_color = new SelectElement(SelectColorDropDown);
            select_color.SelectByValue("SİYAH");
        }
        #endregion
    }
}
