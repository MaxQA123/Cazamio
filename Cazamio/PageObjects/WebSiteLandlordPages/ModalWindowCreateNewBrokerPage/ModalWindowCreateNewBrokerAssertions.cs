using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.ModalWindowCreateNewBrokerPage
{
    public partial class ModalWindowCreateNewBroker
    {
        [AllureStep("VerifyTitleCreateNewBroker")]
        public ModalWindowCreateNewBroker VerifyTitleCreateNewBroker()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleCreateNewBroker));

            return this;
        }
    }
}
