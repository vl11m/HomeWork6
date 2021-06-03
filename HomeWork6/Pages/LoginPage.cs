using HomeWork6.Framework.Models;
using OpenQA.Selenium;

namespace HomeWork6.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement UsernameBox => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/form/input[1]"));

        private IWebElement PasswordBox => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/form/input[2]"));

        private IWebElement FirstNameBox => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/form/input[3]"));

        private IWebElement LastNameBox => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/form/input[4]"));

        private IWebElement LoginButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div[2]/form/input[5]"));

        public LoginPage Login(User user)
        {
            UsernameBox.Clear();
            PasswordBox.Clear();
            FirstNameBox.Clear();
            LastNameBox.Clear();

            UsernameBox.SendKeys(user.Login);
            PasswordBox.SendKeys(user.Password);
            FirstNameBox.SendKeys(user.FirstName);
            LastNameBox.SendKeys(user.LastName);

            LoginButton.Click();
            return new LoginPage(Driver);
        }
    }
}