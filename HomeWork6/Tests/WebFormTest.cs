using System;
using HomeWork6.Framework;
using HomeWork6.Framework.Models;
using HomeWork6.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HomeWork6.Tests
{
    [TestFixture]
    public class WebFormTest : BaseTest
    {
        private User _user;

        [SetUp]
        protected void Initialize()
        {
            _user = User.RandomUser();
        }
        [Test]
        public void LoginTest()
        {

            WebFormPage webForm = SiteNavigator.NavigateToWebFormPage(Driver).Login(_user);
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("example-modal-sizes-title-lg")));
            Assert.IsTrue(Driver.FindElement(By.Id("example-modal-sizes-title-lg")).Displayed);

        }
    }
}
