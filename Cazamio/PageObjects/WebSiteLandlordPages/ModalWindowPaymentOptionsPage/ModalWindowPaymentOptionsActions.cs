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

        [AllureStep("SelectPaymentMethodCreditCard")]
        public ModalWindowPaymentOptions SelectPaymentMethodCreditCard()
        {
            Button.Click(ItemCreditCard);
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }

        [AllureStep("SelectPaymentMethodAch")]
        public ModalWindowPaymentOptions SelectPaymentMethodAch()
        {
            Button.Click(ItemAch);
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }

        [AllureStep("SelectPaymentMethoddeliverCheck")]
        public ModalWindowPaymentOptions SelectPaymentMethoddeliverCheck()
        {
            Button.Click(ItemDeliverCheck);
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }

        [AllureStep("SelectPaymentMethodZelle")]
        public ModalWindowPaymentOptions SelectPaymentMethodZelle()
        {
            Button.Click(ItemZelle);
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }

        [AllureStep("SelectPaymentMethodVenmo")]
        public ModalWindowPaymentOptions SelectPaymentMethodVenmo()
        {
            Button.Click(ItemVenmo);
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }
    }
}
