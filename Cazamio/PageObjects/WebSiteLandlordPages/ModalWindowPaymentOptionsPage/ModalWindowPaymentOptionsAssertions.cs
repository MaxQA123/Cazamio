using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowPaymentOptionsPage
{
    public partial class ModalWindowPaymentOptions
    {
        [AllureStep("VerifySuccessSelectPmntMthds")]
        public ModalWindowPaymentOptions VerifySuccessSelectPmntMthds()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageSuccessMdlWndwOptns));

            return this;
        }
        
    }
}
