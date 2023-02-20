using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCazamioTests.ApiHelpers
{
    public class EndPointsApi
    {
        public const string API_HOST_WEBSITE_ADMIN = "https://api-cazamio-staging.azurewebsites.net";
    }

    public class ApiRequestData
    {
        public const string DEVICE_FINGERPRINT = "5ab5f20f5788afc5e04f1bd0317c8356";
        public const bool TRUE = true;
    }

    public class ApiTestDataGeneral
    {
        public const string BRAND_NAME_MARKETPLACE_ONE = "Beautiful Life";
    }

    public class ApiTestDataBroker
    {
        public const string DEVICE_FINGERPRINT = "5ab5f20f5788afc5e04f1bd0317c8356";
    }

    public class ApiTestDataTenants
    {
        public const string DEVICE_FINGERPRINT = "";
    }
}
