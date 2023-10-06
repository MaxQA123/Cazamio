using CazamioProgect.Helpers;
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
        [AllureStep("FillInMandatoryFields")]
        public MdlWndwCreateANewMarketplaceAdmin FillInMandatoryFields()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFirstName);
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, Name.FirstName());
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, Name.LastName());
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, GenerateRandomDataHelper.RandomEmail(5) + GenerateRandomDataHelper.RandomNumber(3) + GenerateRandomDataHelper.RandomEmail(2) + NameDomen.PUTS_BOX);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMarketplaceSubdomain, TestDataForWebSiteAdmin.MARKETPLACE_SUBDOMAIN);

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
