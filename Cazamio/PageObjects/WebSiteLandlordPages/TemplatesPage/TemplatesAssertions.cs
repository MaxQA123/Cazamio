using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.TemplatesPage
{
    public partial class Templates
    {
        [AllureStep("VerifyTitleTemplatesPagePg")]
        public Templates VerifyTitleTemplatesPagePg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleTemplatesPage));

            return this;
        }
    }
}
