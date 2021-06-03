using HomeWork6.Framework;
using HomeWork6.Framework.Models;
using HomeWork6.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace HomeWork6.Tests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        private List<User> _user;



        [SetUp]
        protected void Initialize()
        {
            _user = User.GetUsersFromCSVFile();
        }

        [Test]
        public void ValidLoginTest()
        {
            for (int i = 0; i < _user.Count; i++)
            {
                LoginPage loginPage = SiteNavigator.NavigateToLoginPage(Driver).Login(_user[i]);
                SiteLoginPage siteLogin = SiteNavigator.NavigateToSiteLoginPage(Driver).Login(_user[i]);

                Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/table/tbody/tr/th/img")).Displayed);
            }
        }
    } 
}