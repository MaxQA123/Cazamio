using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewBrokerPage
{
    public partial class ModalWindowCreateNewBroker
    {
        [AllureStep("VerifyFieldsOnMdlWndwCreateBroker")]
        public ModalWindowCreateNewBroker VerifyFieldsOnMdlWndwCreateBroker()
        {
            Assert.IsTrue(Errors.IsInvisible(ErrorFirstNameCrtNwBrkrOnMdlwndw));

            return this;
        }

        [AllureStep("VerifyMessageNewBrokerCreatedSuccessfullyCrtNwBrkrOnMdlwndw")]
        public ModalWindowCreateNewBroker VerifyMessageNewBrokerCreatedSuccessfullyCrtNwBrkrOnMdlwndw()
        {
            WaitUntil.WaitSomeInterval(1000);
            Assert.IsTrue(Successfully.IsVisible(MessageNewBrokerCreatedSuccessfullyCrtNwBrkrOnMdlwndw));
            

            return this;
        }
    }
}
