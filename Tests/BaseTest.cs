using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Booking_Automation.PageObjects;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;


namespace Booking_Automation.Tests
{
    public abstract class BaseTest
    {
        public IWebDriver driver;
        public static readonly IConfigurationRoot config = new ConfigurationBuilder()
           .SetBasePath("C:\\Users\\avish\\source\\repos\\Booking_Automation\\Booking_Automation\\Data")
           .AddJsonFile(path: "settings.json")
           .Build();
       


        [OneTimeSetUp] 
        public void setUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(config["Url"]);
            Thread.Sleep(1000);
        }
    
    }
}
