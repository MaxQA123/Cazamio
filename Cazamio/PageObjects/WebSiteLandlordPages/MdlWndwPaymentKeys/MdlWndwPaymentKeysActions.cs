using CazamioProgect.Helpers;
using CazamioProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.MdlWndwPaymentKeys
{
    public partial class MdlWndwPaymentKeys
    {
        Building building = new Building().Generate();

        [AllureStep("GetItemCardknox")]
        public string GetItemCardknox()
        {
            WaitUntil.CustomElementIsVisible(ItemCardknox);
            string getItemCardknox = (ItemCardknox).Text;
            string getItemCardknoxActual = getItemCardknox.ToString();

            return getItemCardknoxActual;
        }

        [AllureStep("GetItemApiKeyCardknox")]
        public string GetItemApiKeyCardknox()
        {
            WaitUntil.CustomElementIsVisible(ItemApiKeyCardknox);
            string getItemApiKeyCardknox = (ItemApiKeyCardknox).Text;
            string getItemApiKeyCardknoxActual = getItemApiKeyCardknox.ToString();

            return getItemApiKeyCardknoxActual;
        }

        [AllureStep("GetItemAuthorizeNet")]
        public string GetItemAuthorizeNet()
        {
            WaitUntil.CustomElementIsVisible(ItemAuthorizeNet);
            string getItemCardknox = (ItemAuthorizeNet).Text;
            string getItemCardknoxActual = getItemCardknox.ToString();

            return getItemCardknoxActual;
        }

        [AllureStep("GetItemApiKeyAuthorizeNet")]
        public string GetItemApiKeyAuthorizeNet()
        {
            WaitUntil.CustomElementIsVisible(ItemApiKeyAuthorizeNet);
            string getItemApiKeyCardknox = (ItemApiKeyAuthorizeNet).Text;
            string getItemApiKeyCardknoxActual = getItemApiKeyCardknox.ToString();

            return getItemApiKeyCardknoxActual;
        }

        [AllureStep("ClickButtonCross")]
        public MdlWndwPaymentKeys ClickButtonSearchPaymentSystem()
        {
            WaitUntil.CustomElementIsVisible(ButtonSearchPaymentSystem);
            WaitUntil.CustomElementIsClickable(ButtonSearchPaymentSystem);
            Button.Click(ButtonSearchPaymentSystem);

            return this;
        }

        [AllureStep("SelectItemAuthorizeNet")]
        public MdlWndwPaymentKeys SelectItemAuthorizeNet()
        {
            WaitUntil.CustomElementIsVisible(ItemAuthorizeNet);
            WaitUntil.CustomElementIsClickable(ItemAuthorizeNet);
            Button.Click(ItemAuthorizeNet);

            return this;
        }

        [AllureStep("ClickButtonSave")]
        public MdlWndwPaymentKeys ClickButtonSave()
        {
            WaitUntil.CustomElementIsVisible(ButtonSave);
            WaitUntil.CustomElementIsClickable(ButtonSave);
            Button.Click(ButtonSave);

            return this;
        }

        [AllureStep("ClickButtonCross")]
        public MdlWndwPaymentKeys ClickButtonCross()
        {
            WaitUntil.CustomElementIsClickable(ButtonCross);
            Button.Click(ButtonCross);

            return this;
        }
    }
}
