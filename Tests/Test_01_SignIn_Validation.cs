using Booking_Automation.CommonOps;
using Booking_Automation.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Automation.Tests
{
    
    internal class Test_01_SignIn_Validation:BaseTest
    {
        [Test]
        public void Test1_signIn_Validation_Wrong_Email()
        {
            MainPage_Index mp = new MainPage_Index(driver);
            signIn_Page sp = new signIn_Page(driver);
            mp.Signin();
            sp.EnterEmail("avishaygmail.com");
            Verifications.verifyTextEquals(sp.ErrorMessage_WorngEmail, "Please check if the email address you've entered is correct.");

        }   

        [Test]
        public void Test2_signIn_Validation_Wrong_Password()
        {
            MainPage_Index mp = new MainPage_Index(driver);
            signIn_Page sp = new signIn_Page(driver);
            sp.Wait(2000);
            sp.Clear(sp.email_Field);
            sp.EnterEmail("Avishay2011@gmail.com");
            sp.EnterPassword("1233456");
            sp.Wait(1000);
            Verifications.verifyTextEquals(sp.ErrorMessage_WrongPassword, "The email and password combination you entered doesn't match");           
        }
    }
}
