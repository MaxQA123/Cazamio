using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTenantTests.ApiPagesObjects.ApiTenantPages.LogInApiTenant
{
    public partial class RequestSignUpTenant
    {
        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("RememberMe")]
        public bool RememberMe { get; set; }

        [JsonProperty("DeviceFingerprint")]
        public string DeviceFingerprint { get; set; }
    }
}
