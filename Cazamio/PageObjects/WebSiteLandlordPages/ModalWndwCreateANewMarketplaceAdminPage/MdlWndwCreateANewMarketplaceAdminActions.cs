using CazamioProgect.Helpers;
using CazamioProject.Objects;
using NUnit.Allure.Attributes;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.ModalWndwCreateANewMarketplaceAdminPage
{
    public partial class MdlWndwCreateANewMarketplaceAdmin
    {
        MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();

        [AllureStep("FillInMandatoryFields")]
        public MdlWndwCreateANewMarketplaceAdmin FillInMandatoryFields()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFirstName);
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, marketplaceAdmin.FirstName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, marketplaceAdmin.LastName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, marketplaceAdmin.EmailAddress);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMarketplaceSubdomain, marketplaceAdmin.SubdomainMySpace);

            return this;
        }

        [AllureStep("ClickButtonCreate")]
        public MdlWndwCreateANewMarketplaceAdmin ClickButtonCreate()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonCreate);

            return this;
        }

        [AllureStep("CopyEmailBeforeDogFromFieldInputEmail")]
        public string CopyEmailBeforeDogFromFieldInputEmail()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputEmail.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^..........");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("CopyFullEmailFromFieldInputEmail")]
        public string CopyFullEmailFromFieldInputEmail()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyFullEmail = FieldInputEmail.GetAttribute("value");

            return copyFullEmail;
        }
    }
}
