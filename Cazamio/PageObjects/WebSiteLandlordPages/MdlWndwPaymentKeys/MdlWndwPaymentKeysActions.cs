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
    public partial class MdlWndwPaymentKeysActions
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

        [AllureStep("ClickButtonCross")]
        public MdlWndwPaymentKeysActions ClickButtonCross()
        {
            WaitUntil.CustomElementIsClickable(ButtonCross);
            Button.Click(ButtonCross);

            return this;
        }
    }
}
