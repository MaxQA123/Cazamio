using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.ApiHelpers.ApiPagesObjects.ApiTenantPages.SignUpTenant
{
    public class RequestSignUpTenant
    {
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string returnUrl { get; set; }
        public bool isNeedToVisit { get; set; }
        public string role { get; set; }
        public bool toHowToVisit { get; set; }
    }
}
