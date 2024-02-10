using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.PageObjects.WebSiteLandlordPages.MdlWndwPaymentKeys
{
    public partial class MdlWndwPaymentKeysActions
    {
        public void VerifyApiKeyCardknox(string getApiKeyActual, string getItemApiKeyCardknoxActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getApiKeyActual, building.PaymentSystem.Cardknox);
                Assert.AreEqual(getItemApiKeyCardknoxActual, building.ApiKey.ApiKeyCardknox);
            });
        }
    }
}
