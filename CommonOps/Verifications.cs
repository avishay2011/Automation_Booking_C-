using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Automation.CommonOps
{
    internal class Verifications
    {
        public static void verifyTextEquals(IWebElement el, String Expected)
        {
            Assert.That(el.Text, Is.EqualTo(Expected));
        }

        public static void verify_ConditionIsMet(bool Condion)
        {
            Assert.That(Condion==true);
        }
    }
}
