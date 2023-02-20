using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.ApiPagesObjects.ApiCommonPages.CreateOwnerAdmins
{
    public partial class RequestCreateOwner
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("ownerEmail")]
        public string OwnerEmail { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("phoneNumbers")]
        public List<object> PhoneNumbers { get; set; }

        [JsonProperty("managements")]
        public List<object> Managements { get; set; }
    }
}
