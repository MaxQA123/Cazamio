using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.ModalWndwCreateNewLandlordPage
{
    public partial class ModalWndwCreateNewLandlord
    {
        [AllureStep("FillMandatoryFields")]
        public ModalWndwCreateNewLandlord FillMandatoryFields()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstNameMdlWndwCrtNwLndlrd, Name.FirstName());
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastNameMdlWndwCrtNwLndlrd, Name.LastName());
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputEmailMdlWndwCrtNwLndlrd, GenerateRandomDataHelper.RandomEmail(5) + NameDomen.PUTS_BOX);
            InputGeneral.InputFunctionWithClear(FieldInputMarketplaceSubdomainMdlWndwCrtNwLndlrd, TestDataForWebSiteAdmin.MARKETPLACE_SUBDOMAIN);

            return this;
        }

        [AllureStep("CopyEmailBeforeDogFromMdlWndwCreateNewLandlord")]
        public string CopyEmailBeforeDogFromMdlWndwCreateNewLandlord()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputEmailMdlWndwCrtNwLndlrd.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^.....");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }
        
        

        [AllureStep("CopyFullEmailFromMdlWndwCreateNewLandlord")]
        public string CopyFullEmailFromMdlWndwCreateNewLandlord()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyFullEmail = FieldInputEmailMdlWndwCrtNwLndlrd.GetAttribute("value");

            return copyFullEmail;
        }

        [AllureStep("ClickButtonCreateMdlWndwCrtNwLndlrd")]
        public ModalWndwCreateNewLandlord ClickButtonCreateMdlWndwCrtNwLndlrd()
        {
            Button.Click(ButtonCreateMdlWndwCrtNwLndlrd);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }
    }
}
