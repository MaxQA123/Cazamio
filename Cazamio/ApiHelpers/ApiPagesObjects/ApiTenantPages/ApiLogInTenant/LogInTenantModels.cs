using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.ApiPagesObjects.ApiTenantPages.ApiLogInTenant
{
    public class RequestLogInTenant
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string DeviceFingerprint { get; set; }
    }

    public class ResponseLogInTenant
    {
        public Authdata authData { get; set; }
        public Identitychecks identityChecks { get; set; }
    }

    public class Authdata
    {
        public string token { get; set; }
        public string refreshToken { get; set; }
        public DateTime expireDate { get; set; }
        public User user { get; set; }
    }

    public class User
    {
        public string userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public int userRoleId { get; set; }
        public string userPhoto { get; set; }
    }

    public class Identitychecks
    {
        public bool backgroundIsNotChecked { get; set; }
        public bool isNeedToBackgroundCheckAgain { get; set; }
        public bool backgroundCheckIsPending { get; set; }
        public bool creditScreeningIsNotChecked { get; set; }
        public bool isNeedToCreditScreeningCheckAgain { get; set; }
        public bool creditScreeningIsPending { get; set; }
        public bool isMatch { get; set; }
    }

}
