using Booking_Automation.CommonOps;
using Booking_Automation.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Booking_Automation.Tests
{
    internal class Test_02_GeneralSearching : BaseTest


    {


        [Test]
        public void test1_SearchDestionation()
        {
            MainPage_Index mp = new MainPage_Index(driver);
            SearchResults_Page sr = new SearchResults_Page(driver);
            mp.SearchDestination("paris");
            Verifications.verify_ConditionIsMet(sr.cityHeadLine.GetAttribute("value").ToString() == "Paris");
        }

        [Test]
        public void test2_SearchDates()
        {
            SearchResults_Page sr = new SearchResults_Page(driver);
            sr.SelectDepartureDate("19", "October", "2023");
            sr.SelectReturnDate("26", "October", "2023");
            sr.SearchHotels();
            sr.Click(sr.returnDateField);
            Console.WriteLine(sr.tripDates.Text.Substring(9, 42));
            Assert.That(sr.tripDates.Text.Substring(9, 42), Is.EqualTo("19 October 2023 - Thursday 26 October 2023"));
        }
    }
}
