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
        [AllureStep("VerifyTitleOfDashboardPg")]
        public Dashboard VerifyTitleOfDashboardPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleDashboardPage));

            return this;
        }
    }
}
