using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace NUnit.Tests1.Pages
{
    class HomePage
    {
        IWebDriver webdriver;
        public HomePage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }
        #region objects

        private IWebElement SignInButton
        {
            get
            {
                return webdriver.FindElement(By.ClassName("btnSignIn"));
            }
        }

        private IWebElement SearchTextbox
        {
            get
            {
                return webdriver.FindElement(By.Id("searchData"));
            }
        }

        private IWebElement SearchButton
        {
            get
            {
                return webdriver.FindElement(By.ClassName("searchBtn"));
            }
        }

        private IWebElement PageNumberButton
        {
            get
            {
                return webdriver.FindElement(By.XPath("//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]"));
            }
        }

        private IWebElement SelectedProduct
        {
            get
            {
                //return webdriver.FindElement(By.XPath("//*[@id='p-192641906']/div[1]/a[1]")); //a6 silikon kılıf
                //return webdriver.FindElement(By.XPath("//*[@id='p-253287089']/div[1]/a[1]")); // a8 kapaklı kılıf 
                return webdriver.FindElement(By.XPath("//*[@id='p-296504208']/div[1]/a[1]")); // galaxy j4
                
                //return webdriver.FindElement(By.XPath("//*[@id='p-209303029']/div[1]/a[1]")); // galaxyNote8

            }
        }

        private IWebElement FavouriteWishLisConfirmButton
        {
            get
            {
                return webdriver.FindElement(By.XPath("/html/body/div[7]/div/div/span"));
                //return webdriver.FindElement(By.ClassName("btn btnBlack confirm"));

            }
        }

        private IWebElement DeleteFavouritesConfirmButton
        {
            get
            {
                return webdriver.FindElement(By.XPath("/html/body/div[5]/div/div/span"));
            }
        }

        private IWebElement ShowWishListButton
        {
            get
            {
                return webdriver.FindElement(By.XPath("//*[@id='header']/div/div/div[2]/div[2]/div[2]/div[1]/a[1]"));
                         
            }
        }

        private IWebElement ClickWishListButton
        {
            get
            {
                return webdriver.FindElement(By.XPath("//*[@id='header']/div/div/div[2]/div[2]/div[2]/div[2]/div/a[2]"));
            }
        }



        #endregion
        #region Methods
        public string getHomePageTitle()
        {
            string homepagetitle = webdriver.Title;
            return homepagetitle;
        }

        public void ClickAddWishListConfirm()
        {
            FavouriteWishLisConfirmButton.Click();
        }
        public void ClickDeleteFavouritesConfirm()
        {
            DeleteFavouritesConfirmButton.Click();
        }
        public void ClickSignIn()
        {
            SignInButton.Click();
        }

        public void ClickShowList()
        {
            ShowWishListButton.Click();
        }
        public void MouseOver()
        {
            Actions actions = new Actions(webdriver);
            actions.MoveToElement(ShowWishListButton).Build().Perform();
        }

        public string Searching(string searchdata)
        {
            SearchTextbox.Click();
            SearchTextbox.SendKeys(searchdata);
            SearchButton.Click();
            string AfterSearchTitle = webdriver.Title;
            return AfterSearchTitle;
        }

        public string SelectPruduct()
        {
            PageNumberButton.Click();
            SelectedProduct.Click();
            string SelectedProductTitle = webdriver.Title;
            return SelectedProductTitle;
        }

        public void ClickFavouritewishList()
        {
            ClickWishListButton.Click();
        }
        #endregion
    }
}
