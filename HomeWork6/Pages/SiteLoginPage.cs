using HomeWork6.Framework.Models;
using OpenQA.Selenium;

namespace HomeWork6.Pages
{
    public class SiteLoginPage : BasePage
    {
        public SiteLoginPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement UsernameBox => Driver.FindElement(By.XPath("/html/body/div/div[2]/form/input[1]"));

        private IWebElement PasswordBox => Driver.FindElement(By.XPath("/html/body/div/div[2]/form/input[2]"));

        private IWebElement LoginButton => Driver.FindElement(By.XPath("/html/body/div/div[2]/form/button"));

        public SiteLoginPage Login(User user)
        {
            UsernameBox.Clear();
            PasswordBox.Clear();

            UsernameBox.SendKeys(user.Login);
            PasswordBox.SendKeys(user.Password);

            LoginButton.Click();
            return new SiteLoginPage(Driver);
        }

    }
}
