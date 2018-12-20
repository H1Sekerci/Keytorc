using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Tests1.Pages;

namespace NUnit.Tests1.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.n11.com");

        }

        [Test]
        public void KeytorcTest()
        {
            HomePage ObjHomePage = new HomePage(driver);
            LoginPage ObjLoginPage = new LoginPage(driver);
            SelectedProductPage ObjSelecProdPage = new SelectedProductPage(driver);
            WishListsPage ObjWishListPage = new WishListsPage(driver);
            FavouritesPage ObjFavouritesPage = new FavouritesPage(driver);

            string Homepagetitle = ObjHomePage.getHomePageTitle();
            Assert.AreEqual("n11.com - Alışverişin Uğurlu Adresi", Homepagetitle);   
            ObjHomePage.ClickSignIn();                               
            string LoginPageTitle = ObjLoginPage.LogintoN11("shequerchi@gmail.com", "hikmet1994");
            Assert.AreEqual("Giriş Yap - n11.com", LoginPageTitle);
            string SearchingVerify = ObjHomePage.Searching("Samsung");
            Assert.AreEqual("Samsung - n11.com", SearchingVerify);
            string SelectedProductVerify = ObjHomePage.SelectPruduct();
            //Assert.AreEqual("Samsung S6 Silikon Kılıf - n11.com", SelectedProductVerify);
            //Assert.AreEqual("Samsung Galaxy A8 2016 Kılıf Kapaklı Kılıf+a8 2016 Kırılmaz Cam - n11.com", SelectedProductVerify);
            //Assert.AreEqual("Samsung Samsung Sm-j400f Galaxy J4 Lavender 13mp 4.5g 5.5 16 Gb - n11.com", SelectedProductVerify);
            Assert.AreEqual("Samsung Samsung Sm-j250f Glaxy Grand Prime Pro Blue Silver 8 Mp - n11.com", SelectedProductVerify);
            //ObjSelecProdPage.ChangeColor();
            ObjSelecProdPage.ClickAddWishList();
            ObjSelecProdPage.ClickFavouriteWishList();
            ObjHomePage.ClickAddWishListConfirm();
            ObjHomePage.MouseOver();
            ObjHomePage.ClickFavouritewishList();
            ObjWishListPage.ClickMyWishesList();
            string VerifyFavouriteProduct = ObjFavouritesPage.VerifyProductExist();
            Assert.AreEqual("Samsung Samsung SM-J250F Glaxy Grand Prime Pro Blue Silver 8 MP\r\nTükenmek üzere", VerifyFavouriteProduct);
            ObjFavouritesPage.ClikDeleteFavouritesButton();
            ObjHomePage.ClickDeleteFavouritesConfirm();
            string VerifyFavouriteDeleted = ObjFavouritesPage.VerifyProductDeleted();
            Assert.AreEqual("İzlediğiniz bir ürün bulunmamaktadır.", VerifyFavouriteDeleted);

        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
