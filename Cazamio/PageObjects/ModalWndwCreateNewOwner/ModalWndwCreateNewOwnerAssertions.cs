using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.ModalWndwCreateNewOwner
{
    public partial class ModalWndwCreateNewOwner
    {
        [AllureStep("VerifyTitleCreateANewOwnerg")]
        public ModalWndwCreateNewOwner VerifyTitleCreateANewOwnerg()
        {
            WaitUntil.CustomElementIsVisible(TitleCreateANewOwner);
            Assert.IsTrue(Successfully.IsVisible(TitleCreateANewOwner));

            return this;
        }

        [AllureStep("GetEmailFromFieldOwnerEmail")]
        public string GetEmailFromFieldOwnerEmail()
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserName = FieldInputOwnerEmail.GetAttribute("value");
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }
    }
}
