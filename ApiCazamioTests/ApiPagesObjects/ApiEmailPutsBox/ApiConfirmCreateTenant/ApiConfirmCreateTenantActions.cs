using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCazamioTests.ApiPagesObjects.ApiEmailPutsBox.ConfirmCreateTenant
{
    public partial class ApiConfirmCreateTenant
    {
        //public static ResponseLogIn PutsBox(string email, string password)
        //{
        //    var restClient = new RestClient(EndPointsApi.apiHost);

        //    var restRequest = new RestRequest($"https://preview.putsbox.com/p/{email}/last.text", Method.Get);

        //    restRequest.AddHeaders(Headers.HeadersCommon());

        //    restRequest.AddJsonBody(RequestBody(email, password));

        //    var response = restClient.Execute(restRequest);

        //    var content = response.Content;

        //    if (response.StatusDescription == "Bad Request")
        //    {
        //        Console.WriteLine(response.Content);
        //    }

        //    var dtoObject = JsonConvert.DeserializeObject<ResponseLogIn>(content);

        //    return dtoObject;
        //}
    }
}
