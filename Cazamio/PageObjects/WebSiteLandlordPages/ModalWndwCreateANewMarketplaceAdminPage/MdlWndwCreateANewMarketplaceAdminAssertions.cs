using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.ModalWndwCreateANewMarketplaceAdminPage
{
    public partial class MdlWndwCreateANewMarketplaceAdmin
    {
        [AllureStep("VerifyTitleCreateANewMarketplaceadmin")]
        public MdlWndwCreateANewMarketplaceAdmin VerifyTitleCreateANewMarketplaceadmin()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleCreateANewMarketplaceadmin));

            return this;
        }

        [AllureStep("VerifyNameHostMarketplaceSubdomain")]
        public MdlWndwCreateANewMarketplaceAdmin VerifyNameHostMarketplaceSubdomain()
        {
            Assert.IsTrue(Successfully.IsVisible(NameHostMarketplaceSubdomain));

            return this;
        }

        [AllureStep("GetEmailFromFieldInputEmail")]
        public string GetEmailFromFieldInputEmail()
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserName = FieldInputEmail.GetAttribute("value");
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }
    }
}
