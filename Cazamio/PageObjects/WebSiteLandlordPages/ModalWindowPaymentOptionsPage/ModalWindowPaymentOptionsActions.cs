using CazamioProgect.Helpers;
using CazamioProject.Objects;
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
        PaymentOptions paymentOptions = new PaymentOptions().Generate();

        [AllureStep("SelectPaymentsMethodsNwBldngPg")]
        public ModalWindowPaymentOptions SelectPaymentsMethodsNwBldngPg()
        {
            Button.Click(CheckBoxCreditCardMdlWndwOptns);
            Button.Click(CheckBoxAchMdlWndwOptns);
            Button.Click(CheckBoxDeliverCheckMdlWndwOptns);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteMdlWndwOptns, paymentOptions.DeliverCheckNote.ForBuilding);
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);
            //Button.Click(ButtonInFormCrossMdlWndwOptns);

            return this;
        }
    }
}
