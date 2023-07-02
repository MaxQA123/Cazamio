using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ReportsPage
{
    public partial class Reports
    {
        [AllureStep("VerifyTitleReportsPage")]
        public Reports VerifyTitleReportsPage()
        {
            WaitUntil.WaitSomeInterval(1000);
            Assert.IsTrue(Successfully.IsVisible(TitleReportsPage));

            return this;
        }
    }
}
