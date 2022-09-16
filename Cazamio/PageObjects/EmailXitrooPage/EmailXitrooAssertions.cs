using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.EmailXitrooPage
{
    public partial class EmailXitroo
    {
        [AllureStep("GetEmailFromXitrooPage")]
        public string GetEmailFromXitrooPage()
        {
            WaitUntil.WaitSomeInterval(1000);
            string getEmail = Browser._Driver.FindElement(By.XPath("//input[@id = 'mailInput']")).GetAttribute("value");
            string getEmailExpected = getEmail.ToString();

            return getEmailExpected;
        }

        [AllureStep("VerifyEmailForCretingBroker")]
        public EmailXitroo VerifyEmailForCretingBroker(string getEmailExpected)
        {
            WaitUntil.WaitSomeInterval(500);
            string getEmailActual = Browser._Driver.FindElement(By.XPath("//tbody//tr[last()]//td[3]")).Text;

            Assert.AreEqual(getEmailExpected, getEmailActual);

            return this;
        }
    }
}
