﻿using CazamioProject.ApiHelpers;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.ApiHelpers.ApiPagesObjects.ApiTenantPages.SignUpTenant
{
    public partial class SignUpTenant
    {
        public static RequestSignUpTenant RequestBody(string email, string password, string firstName, string lastName, string returnUrl, bool isNeedToVisit, string role, bool toHowToVisit)
        {
            var payload = new RequestSignUpTenant();
            payload.email = email;
            payload.password = password;
            payload.firstName = firstName;
            payload.lastName = lastName;
            payload.returnUrl = returnUrl;
            payload.isNeedToVisit = isNeedToVisit;
            payload.role = role;
            payload.toHowToVisit = toHowToVisit;

            return payload;
        }

        public static string ExecuteSignUp(string email, string password, string firstName, string lastName, string returnUrl, bool isNeedToVisit, string role, bool toHowToVisit)
        {
            var restClient = new RestClient(EndPointsApi.API_HOST_WEBSITE_ADMIN);

            var restRequest = new RestRequest("/api/identity/register", Method.Post);
            restRequest.AddHeaders(Headers.HeadersTenant());

            restRequest.AddJsonBody(RequestBody(email, password, firstName, lastName, returnUrl, isNeedToVisit, role, toHowToVisit));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            return content;
        }

        //public static string ExecuteGetCodeUserId()
        //{
        //    var restClient = new RestClient(EndPointsApi.API_HOST_WEBSITE_ADMIN_CONFIRM_EMAIL);

        //    var restRequest = new RestRequest("/account/email-confirm", Method.Get);
        //    restRequest.AddHeaders(Headers.HeadersTenant());

        //    restRequest.AddJsonBody(RequestBody());

        //    var response = restClient.Execute(restRequest);

        //    var content = response.Content;

        //    if (response.StatusDescription == "Bad Request")
        //    {
        //        Console.WriteLine(response.Content);
        //    }

        //    return content;
        //}
    }
}
