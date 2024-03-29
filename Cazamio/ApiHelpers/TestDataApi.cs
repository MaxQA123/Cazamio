﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.ApiHelpers
{
    public class EndPointsApi
    {
        public const string API_HOST_WEBSITE_ADMIN = "https://api-cazamio-staging.azurewebsites.net";
        public const string API_HOST_WEBSITE_ADMIN_CONFIRM_EMAIL = "https://testlandlord15-demo.casamio-test.lol//account/email-confirm";
    }

    public class ApiRequestData
    {
        public const string DEVICE_FINGERPRINT = "5ab5f20f5788afc5e04f1bd0317c8356";
        public const bool TRUE = true;
        public const bool FALSE = false;
        public const string RETURN_URL = "/";
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
        public const string DEVICE_FINGERPRINT = "417d13cf3013cfd714a7c316d0415eca";
    }
}
