using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewAgentPage
{
    public partial class ModalWindowCreateNewAgent
    {
        [AllureStep("VerifyFieldsOnMdlWndwCreateBroker")]
        public ModalWindowCreateNewAgent VerifyFieldsOnMdlWndwCreateBroker()
        {
            Assert.IsTrue(Errors.IsInvisible(ErrorFirstNameCrtNwBrkrOnMdlwndw));

            return this;
        }

        [AllureStep("VerifyMessageNewAgentCreatedSuccessfullyCrtNwAgntOnMdlwndw")]
        public ModalWindowCreateNewAgent VerifyMessageNewAgentCreatedSuccessfullyCrtNwAgntOnMdlwndw()
        {
            WaitUntil.CustomElementIsVisible(MessageNewAgentCreatedSuccessfullyCrtNwAgntOnMdlwndw);
            Assert.IsTrue(Successfully.IsVisible(MessageNewAgentCreatedSuccessfullyCrtNwAgntOnMdlwndw));
            

            return this;
        }
    }
}
