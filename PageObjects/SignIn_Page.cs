using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Automation.PageObjects
{
    internal class signIn_Page :BasePage
    {
        public signIn_Page(IWebDriver driver)
             : base(driver)
        {
        }
        public IWebElement email_Field => driver.FindElement(By.CssSelector(".access-panel input"));

        public IWebElement continueWithEmail => driver.FindElement(By.CssSelector("button[type=\"submit\"]"));

        public IWebElement password_Field => driver.FindElement(By.CssSelector("input[type=\"password\"]"));

        public IWebElement SignIn => driver.FindElement(By.CssSelector("button[type=\"submit\"]"));

        public IWebElement ErrorMessage_WrongPassword => driver.FindElement(By.CssSelector(".sOewt4Y1yBOPAIUGcJwH:nth-child(3)"));

        public IWebElement ErrorMessage_WorngEmail => driver.FindElement(By.CssSelector("#username-note"));

        public void EnterEmail(string email)
        {
            FillText(email_Field,email);
            Click(continueWithEmail);
            
        }

        public void EnterPassword(string password)
        {
            Wait(2000);
            FillText(password_Field, password);
            Click(SignIn);
        }


    }
}
