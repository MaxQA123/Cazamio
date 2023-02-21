using CazamioProject.ApiHelpers;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTests.ApiPagesObjects.ApiBrokerPages.CreateNewAgent
{
    public partial class CreateNewAgent
    {
        public static RequestCreateNewAgent RequestBody(string firstName, string lastName, string email, string phoneNumber, string cell)
        {
            var payload = new RequestCreateNewAgent();
            payload.FirstName = firstName;
            payload.LastName = lastName;
            payload.Email = email;
            payload.PhoneNumber = phoneNumber;
            payload.Cell = cell;

            return payload;
        }

        public static ResponsetCreateNewAgent ExecuteCreateNewAgent(string firstName, string lastName, string email, string phoneNumber, string cell)
        {
            var restClient = new RestClient(EndPointsApi.API_HOST_WEBSITE_ADMIN);

            var restRequest = new RestRequest("/api/brokers/registerBroker", Method.Post);
            restRequest.AddHeaders(Headers.HeadersAdmins());

            restRequest.AddJsonBody(RequestBody(firstName, lastName, email, phoneNumber, cell));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponsetCreateNewAgent>(content);

            return dtoObject;
        }
    }
}
