using CazamioProject.ApiHelpers;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.ApiPagesObjects.ApiTenantPages.ApiLogInTenant
{
    public partial class LogInTenant
    {
        public static RequestLogInTenant RequestBody(string email, string password, string deviceFingerprint, bool rememberMe)
        {
            var payload = new RequestLogInTenant();
            payload.Email = email;
            payload.Password = password;
            payload.DeviceFingerprint = deviceFingerprint;
            payload.RememberMe = rememberMe;

            return payload;
        }

        public static ResponseLogInTenant ExecuteLogIn(string email, string password, string deviceFingerprint, bool rememberMe)
        {
            var restClient = new RestClient(EndPointsApi.API_HOST_WEBSITE_ADMIN);

            var restRequest = new RestRequest("/api/identity/login", Method.Post);
            restRequest.AddHeaders(Headers.HeadersTenant());

            restRequest.AddJsonBody(RequestBody(email, password, deviceFingerprint, rememberMe));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseLogInTenant>(content);

            return dtoObject;
        }
    }
}
