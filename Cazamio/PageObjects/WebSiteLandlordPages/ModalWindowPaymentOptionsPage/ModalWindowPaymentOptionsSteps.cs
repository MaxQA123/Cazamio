using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.PageObjects.WebSiteLandlordPages.ModalWindowPaymentOptionsPage
{
    public partial class ModalWindowPaymentOptions
    {
        [AllureStep("SelectAllPaymentMethods")]
        public ModalWindowPaymentOptions SelectAllPaymentMethods()
        {
            Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            Button.Click(ItemVenmo);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNote, paymentOptions.DeliverCheckNote.ForBuildingScreening);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhone, paymentOptions.Zelle.ForBuildingScreening);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_SCREENING));
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();

            return this;
        }

        [AllureStep("SelectAllPaymentMethodsForHoldBuilding")]
        public ModalWindowPaymentOptions SelectAllPaymentMethodsForHoldBuilding()
        {
            Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            Button.Click(ItemVenmo);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNote, paymentOptions.DeliverCheckNote.ForBuildingHold);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhone, paymentOptions.Zelle.ForBuildingHold);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_HOLD_BUILDING));
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();

            return this;
        }

        [AllureStep("SelectPaymentMethodsCrdtCrdAchZll")]
        public ModalWindowPaymentOptions SelectPaymentMethodsCrdtCrdAchZll()
        {
            Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNote, paymentOptions.DeliverCheckNote.ForBuildingHold);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhone, paymentOptions.Zelle.ForBuildingHold);
            Button.Click(ButtonSaveMdlWndwOptns);
            VerifySuccessSelectPmntMthds();

            return this;
        }
    }
}
