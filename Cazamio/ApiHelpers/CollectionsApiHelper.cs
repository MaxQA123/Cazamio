using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.ApiHelpers
{
    public class Headers
    {
        public static ICollection<KeyValuePair<string, string>> HeadersTenant()

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));
            headersCommon.Add(new KeyValuePair<string, string>("marketplace", "https://testlandlord-demo.cazamiodemo.com"));

            return headersCommon;
        }

        public static ICollection<KeyValuePair<string, string>> HeadersAdmins()

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
            headersCommon.Add(new KeyValuePair<string, string>("api-version", "1"));

            return headersCommon;
        }
    }
}
