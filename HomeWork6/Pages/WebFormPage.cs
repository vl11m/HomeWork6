using HomeWork6.Framework.Models;
using OpenQA.Selenium;

namespace HomeWork6.Pages
{
    public class WebFormPage : BasePage
    {
        public WebFormPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement FirstName => Driver.FindElement(By.Id("firstName"));

        private IWebElement LastName => Driver.FindElement(By.Id("lastName"));

        private IWebElement SubmitButton => Driver.FindElement(By.Id("submit"));

        private IWebElement Email => Driver.FindElement(By.Id("userEmail"));

        private IWebElement MobileNomber => Driver.FindElement(By.Id("userNumber"));

        private IWebElement GenderMale => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[3]/div[2]/div[1]"));
        private IWebElement HobbiesSport => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[7]/div[2]/div[1]/label"));
        private IWebElement HobbiesReading => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[7]/div[2]/div[2]/label"));
        private IWebElement HobbiesMusic => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[7]/div[2]/div[3]/label"));
        private IWebElement CurrentAddress => Driver.FindElement(By.Id("currentAddress"));
        private IWebElement CurrentStateSelect => Driver.FindElement(By.CssSelector("#state > div > div.css-1hwfws3 > div.css-1wa3eu0-placeholder"));
        private IWebElement CurrentStateNCR => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[10]/div[2]/div/div/div[1]/div[1]"));
        private IWebElement CurrentStateUttar => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[10]/div[2]/div/div/div[1]/div[1]"));
        private IWebElement CurrentStateRajasthan => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[10]/div[2]/div/div/div[1]/div[3]"));
        private IWebElement CurrentStateHaryana => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/form/div[10]/div[2]/div/div/div[1]/div[4]"));



        public WebFormPage Login(User user)
        {
            FirstName.Clear();
            LastName.Clear();
            Email.Clear();
            MobileNomber.Clear();
            CurrentAddress.Clear();

            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Email.SendKeys(user.Email);
            MobileNomber.SendKeys(user.MobileNumber);
            GenderMale.Click();
            switch (user.Hobbies)
            {
                case 1:
                    HobbiesSport.Click();
                    break;
                case 2:
                    HobbiesReading.Click();
                    break;
                case 3:
                    HobbiesMusic.Click();
                    break;
                default:
                    HobbiesMusic.Click();
                    HobbiesReading.Click();
                    HobbiesSport.Click();
                    break;
            }
            CurrentAddress.SendKeys(user.CurrentAdress);
            if (user.CurrentState<5)
            {
                CurrentStateSelect.Click();
                switch (user.CurrentState)
                {
                    case 1:
                        CurrentStateNCR.Click();
                        break;
                    case 2:
                        CurrentStateUttar.Click();
                        break;
                    case 3:
                        CurrentStateRajasthan.Click();
                        break;
                    case 4:
                        CurrentStateHaryana.Click();
                        break;
                    default:
                        break;
                }
            }


            SubmitButton.Click();
            return new WebFormPage(Driver);
        }

    }
}
