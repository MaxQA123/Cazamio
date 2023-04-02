using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ListOfCommissionsPage
{
    public partial class ListOfCommissions
    {
        [AllureStep("VerifyTitleListOfCommissionsPg")]
        public ListOfCommissions VerifyTitleListOfCommissionsPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleListOfCommissions));

            return this;
        }
    }
}
