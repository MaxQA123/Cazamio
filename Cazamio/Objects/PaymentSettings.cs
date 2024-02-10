using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Objects
{
    public class PaymentSettingsObject
    {
        public PaymentSystemInfo PaymentSystem { get; set; }
        public ApiKeyInfo ApiKey { get; set; }
        public string EmailAddress { get; set; }
        public string ShortEmail { get; set; }
        public string EmailAddressBroker { get; set; }
        public string FullUserNameBroker { get; set; }

        public class PaymentSystemInfo
        {
            public string Cardknox { get; set; }
            public string AuthorizeNet { get; set; }
        }

        public class ApiKeyInfo
        {
            public string ForCardknox { get; set; }
            public string DefaultCardknoxBuilding { get; set; }
            public string ForAuthorizeNet { get; set; }
        }

        public PaymentSettingsObject Generate()
        {
            string cardknox = "Cardknox";
            string authorizeNea = "AuthorizeNet";
            string forCardknox = "";
            string forAuthorizeNet = "";
            string defaultCardknoxBuilding = "";

            var paymentSettings = new PaymentSettingsObject()
            {
                PaymentSystem = new PaymentSystemInfo
                {
                    Cardknox = cardknox,
                    AuthorizeNet = authorizeNea
                },
                ApiKey = new ApiKeyInfo
                {
                    ForCardknox = forCardknox,
                    DefaultCardknoxBuilding = defaultCardknoxBuilding,
                    ForAuthorizeNet = forAuthorizeNet
                },

            };
            return paymentSettings;
        }
    }
}
