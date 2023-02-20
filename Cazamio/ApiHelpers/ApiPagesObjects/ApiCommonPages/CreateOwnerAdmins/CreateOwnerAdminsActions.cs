using CazamioProject.ApiHelpers;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.ApiPagesObjects.ApiCommonPages.CreateOwnerAdmins
{
    public partial class CreateOwnerAdmins
    {
        public static RequestCreateOwner RequestBody(string companyName, string ownerEmail, string ownerName, string officeLocation)
        {
            var payload = new RequestCreateOwner();
            payload.CompanyName = companyName;
            payload.OwnerEmail = ownerEmail;
            payload.OwnerName = ownerName;
            payload.OfficeLocation = officeLocation;

            return payload;
        }

        public static string ExecuteCreateOwner(string companyName, string ownerEmail, string ownerName, string officeLocation)
        {
            var restClient = new RestClient(EndPointsApi.API_HOST_WEBSITE_ADMIN);

            var restRequest = new RestRequest("/api/owners/createOwner", Method.Post);
            restRequest.AddHeaders(Headers.HeadersAdmins());

            restRequest.AddJsonBody(RequestBody(companyName, ownerEmail, ownerName, officeLocation));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            return content;
        }
    }
}
