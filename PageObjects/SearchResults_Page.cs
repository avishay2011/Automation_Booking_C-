using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Automation.PageObjects
{

    internal class SearchResults_Page : BasePage
    {
        public SearchResults_Page(IWebDriver driver)
              : base(driver)
        {
        }
        public IWebElement cityHeadLine => driver.FindElement(By.CssSelector("input[name=\"ss\"]"));
        public IWebElement currentMonthAndYear => driver.FindElement(By.CssSelector(".f261b68fe6>h3"));
        public IWebElement nextMonthButton => driver.FindElement(By.CssSelector("div[data-testid=\"searchbox-datepicker-calendar\"]>button"));
        public IWebElement departurDay => driver.FindElement(By.CssSelector(".a97110d8d3 > div > button > span"));
        public IWebElement returnDateField => driver.FindElement(By.CssSelector("div[data-testid=\"searchbox-checkout-container\"]>button"));
        public IWebElement searchHotelsButton => driver.FindElement(By.CssSelector("button[type=\"submit\"]"));
        public IWebElement tripDates => driver.FindElement(By.CssSelector(".caab4cf6d1"));









        public void SelectDepartureDate(String departureDay, String departureMonth, String departureYear)
        {   
            nextMonthButton.Click();
            Wait(2500);
            for (int i = 0; i <= 13; i++)
            {
                if (currentMonthAndYear.Text.Contains(departureMonth) && currentMonthAndYear.Text.Contains(departureYear))
                    break;
                else
                {
                    driver.FindElement(By.CssSelector("div[data-testid=\"searchbox-datepicker-calendar\"]>button:nth-child(2)")).Click();
                }
            }
            Wait(3500);
            Click(driver.FindElement(By.CssSelector("td[role=\"gridcell\"]>span[aria-label=\""+departureDay+" "  + departureMonth+" " + departureYear +"\"]")));
        }

        public void SelectReturnDate(String returnDay, String returnMonth, String returnYear)
        {
            Click(returnDateField);
            Wait(2000);
            for (int i = 0; i <= 13; i++)
            {
                if (currentMonthAndYear.Text.Contains(returnMonth) && currentMonthAndYear.Text.Contains(returnYear))
                    break;
                else
                {
                    driver.FindElement(By.CssSelector("div[data-testid=\"searchbox-datepicker-calendar\"]>button:nth-child(2)")).Click();
                }
            }
            Click(driver.FindElement(By.CssSelector("td[role=\"gridcell\"]>span[aria-label=\"" + returnDay + " " + returnMonth + " " + returnYear + "\"]")));


        }

        public void SearchHotels()
        {
            Click(searchHotelsButton);
        }
    }
}

