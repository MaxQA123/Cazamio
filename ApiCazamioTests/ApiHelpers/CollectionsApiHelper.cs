using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCazamioTests.ApiHelpers
{
    public class Headers
    {
        public static ICollection<KeyValuePair<string, string>> HeadersCommon()

        {
            var headersCommon = new List<KeyValuePair<string, string>>();

            headersCommon.Add(new KeyValuePair<string, string>("accept", "application/json, text/plain, */*"));
            headersCommon.Add(new KeyValuePair<string, string>("accept-encoding", "gzip, deflate, br"));
            headersCommon.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));

            return headersCommon;
        }
    }
}
