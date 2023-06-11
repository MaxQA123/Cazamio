using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowPaymentOptionsPage
{
    public partial class ModalWindowPaymentOptions
    {
        [AllureStep("SelectPaymentsMethodsNwBldngPg")]
        public ModalWindowPaymentOptions SelectPaymentsMethodsNwBldngPg()
        {
            Button.Click(CheckBoxCreditCardMdlWndwOptns);
            Button.Click(CheckBoxAchMdlWndwOptns);
            Button.Click(CheckBoxDeliverCheckMdlWndwOptns);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteMdlWndwOptns, Lorem.Sentence());
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);
            //Button.Click(ButtonInFormCrossMdlWndwOptns);

            return this;
        }
    }
}
