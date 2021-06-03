using HomeWork6.Pages;
using OpenQA.Selenium;

namespace HomeWork6.Framework
{
    public class SiteNavigator
    {
        public static LoginPage NavigateToLoginPage(IWebDriver driver)
        {
            string url = "http://testingchallenges.thetestingmap.org/challenge10.php";
            driver.Navigate().GoToUrl(url);
            return new LoginPage(driver);
        }
        public static SiteLoginPage NavigateToSiteLoginPage(IWebDriver driver)
        {
            string url = "http://testingchallenges.thetestingmap.org/login/login.php";
            driver.Navigate().GoToUrl(url);
            return new SiteLoginPage(driver);
        }
        public static WebFormPage NavigateToWebFormPage(IWebDriver driver)
        {
            string url = "https://demoqa.com/automation-practice-form";
            driver.Navigate().GoToUrl(url);
            return new WebFormPage(driver);
        }
    }

}