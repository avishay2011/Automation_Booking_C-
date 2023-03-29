using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Booking_Automation.PageObjects
{

    internal class BasePage
    {

        public IWebDriver driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
           
        }



        public void FillText(IWebElement el, String text)
        {
            HighlightElement(el, "green");
            Wait(1000);
            el.Clear();
            el.SendKeys(text);
        }

        public void Clear(IWebElement el)
        {     
            HighlightElement(el, "pink");
            Wait(1000);
            el.SendKeys(Keys.Control+"a"); ///(Keys.CONTROL + "a");
            el.SendKeys(Keys.Backspace);
        }

        public void Click(IWebElement el)
        {
            HighlightElement(el, "orange");
            Wait(1000);
            el.Click();
        }
        public string GetText(IWebElement el)
        {   

            return el.Text;
        }

        public void PrintText(WebElement el)
        {
           Console.WriteLine(GetText(el));
        }

        public void Wait(int miliseconds)
        {
            try
            {
                Thread.Sleep(miliseconds);
            }
            catch (Exception ex)
            {
            }
        }

        private void HighlightElement(IWebElement element, String color)
        {
            //keep the old style to change it back
            String originalStyle = element.GetAttribute("style");
            String newStyle = "background-color:"+color+";border: 1px solid " + color + ";" + originalStyle;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            // Change the style 
            js.ExecuteScript("var tmpArguments = arguments;setTimeout(function () {tmpArguments[0].setAttribute('style', '" + newStyle + "');},0);",
                    element);

            // Change the style back after few miliseconds
            js.ExecuteScript("var tmpArguments = arguments;setTimeout(function () {tmpArguments[0].setAttribute('style', '"
                    + originalStyle + "');},400);", element);

        }
    }
}
