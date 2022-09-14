using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.PreApprovalsPage
{
    public partial class PreApprovals
    {
        [AllureStep("VerifyTitlePreApprovalsPagePg")]
        public PreApprovals VerifyTitlePreApprovalsPagePg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitlePreApprovalsPage));

            return this;
        }
    }
}
