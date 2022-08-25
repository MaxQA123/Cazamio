using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    public class EndPoints
    {
        public const string urlHomePageTenantWebSiteCazamio = "https://cazamiodemo.com/";
        public const string urlHomePageTenantWebSiteAbodeo = "https://abodebyreside.cazamiodemo.com/";
        public const string urlLogInPageLandlordBrokerWebSite = "https://landlord.cazamiodemo.com/";
    }

    public class GeneralTestDataForAllUsers
    {
        public const string passwordGeneral = "Qwerty123!";
    }

    public class TestDataForWebSiteCazamio
    {
        public const string emailTenantWife = "tenantswife@gmail.com";
        public const string firstNameTenantWife = "Tenant";
    }

    public class TestDataForWebSiteLandlord
    {
        public const string emailLandlordTest = "testlivelandlord@gmail.com";
        public const string userNameLandlord = "Landlord Test";

        public const string emailBroker = "cazamioportal@gmail.com";
        public const string userNameBroker = "Broker Tests";
    }

    public class NameDomen
    {
        public static string Xitroo = "@xitroo.com";
    }

    public class UploadImages
    {
        public const string avatarImgTenant = $"\\UploadImages\\ImagePandaStudent.jpg";
    }
}
