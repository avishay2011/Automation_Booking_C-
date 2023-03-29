using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Automation.PageObjects
{

      class MainPage_Index :BasePage            
    {    
        public MainPage_Index (IWebDriver driver)
              : base(driver)
        {
            
        }      
        
        public IWebElement x_Popup=> driver.FindElement(By.CssSelector(".e5aa33035e .b6dc9a9e69"));
        public IWebElement destination_Name_field => driver.FindElement(By.CssSelector("input[name=\"ss\"]"));
        public IWebElement searchButton => driver.FindElement(By.CssSelector("button[type=\"submit\"]"));
        public IWebElement signIn => driver.FindElement(By.CssSelector(".e5aa33035e .e57ffa4eb5"));
        public void SearchDestination(String destination)
        {
            Click(x_Popup);
            FillText(destination_Name_field,"Paris");

            Click(searchButton);
        }

        public void Signin()
        {
            
            Click(signIn);
        }
    }
}
