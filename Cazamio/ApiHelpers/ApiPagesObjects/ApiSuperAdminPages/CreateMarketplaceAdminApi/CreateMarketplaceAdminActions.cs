using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.ApiHelpers.ApiPagesObjects.ApiSuperAdminPages.CreateMarketplaceAdminApi
{
    public partial class CreateMarketplaceAdmin
    {
        //public static RequestCreateMarketplaceAdmin RequestBody(string firstName, string lastName, string email, string password, string subDomain)
        //{
        //    var payload = new RequestCreateMarketplaceAdmin();
        //    payload.firstName = firstName;
        //    payload.lastName = lastName;
        //    payload.email = email;
        //    payload.password = password;
        //    payload.subDomain = subDomain;

        //    return payload;
        //}

        //public static ResponseLogInAdmins ExecuteLogIn(string firstName, string lastName, string email, string password, string subDomain)
        //{
        //    var restClient = new RestClient(EndPointsApi.API_HOST_WEBSITE_ADMIN);

        //    var restRequest = new RestRequest("/api/identity/registerMarketplaceAdmin", Method.Post);
        //    restRequest.AddHeaders(Headers.HeadersAdmins());

        //    restRequest.AddJsonBody(RequestBody(firstName, lastName, email, password, subDomain));

        //    var response = restClient.Execute(restRequest);

        //    var content = response.Content;

        //    if (response.StatusDescription == "Bad Request")
        //    {
        //        Console.WriteLine(response.Content);
        //    }

        //    var dtoObject = JsonConvert.DeserializeObject<ResponseLogInAdmins>(content);

        //    return dtoObject;
        //}
    }
}
