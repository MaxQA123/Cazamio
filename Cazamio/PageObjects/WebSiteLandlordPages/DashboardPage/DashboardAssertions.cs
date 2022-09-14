using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.DashboardPage
{
    public partial class Dashboard
    {
        [AllureStep("GetUserNameFromSideBar")]
        public string GetTitler()
        {
            WaitUntil.WaitSomeInterval(1000);
            string getUserName = Browser._Driver.FindElement(By.XPath("//div[@class = 'user-name']")).Text;
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }

        [AllureStep("VerifyLandlordUserName")]
        public Dashboard VerifyLandlordUserName(string getUserNameActual)
        {
            WaitUntil.WaitSomeInterval(500);
            string getUserNameExpected = TestDataForWebSiteLandlord.userNameLandlord;

            Assert.AreEqual(getUserNameActual, getUserNameExpected);

            return this;
        }
    }
}
