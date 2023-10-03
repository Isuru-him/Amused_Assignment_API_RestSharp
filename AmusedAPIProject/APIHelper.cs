using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusedAPIProject
{
    public class APIHelper
    {

        public RestResponse getResponse(string url, string endPoint, String type)
        {
            var restClient = new RestClient(url);

            var restRequest = new RestRequest(endPoint, Method.Get);

            if (type.Equals("GET"))
            {
                restRequest = new RestRequest(endPoint, Method.Get);
                restRequest.AddParameter("Accept", "application/json");
                restRequest.RequestFormat = DataFormat.Json;
            }
            else if (type.Equals("POST"))
            {
                restRequest = new RestRequest(endPoint, Method.Post);
            }
            else if (type.Equals("PUT"))
            {
                restRequest = new RestRequest(endPoint, Method.Put);
            }
            else if (type.Equals("DELETE"))
            {
                restRequest = new RestRequest(endPoint, Method.Delete);
            }

            RestResponse response = restClient.Execute(restRequest);

            return response;
        }

        public RestResponse getResponse(string url, string endPoint, String type, string payload)
        {
            var restClient = new RestClient(url);

            var restRequest = new RestRequest(endPoint, Method.Get);

            if (type.Equals("GET"))
            {
                restRequest = new RestRequest(endPoint, Method.Get);
                restRequest.AddParameter("Accept", "application/json");
                restRequest.RequestFormat = DataFormat.Json;
            }
            else if (type.Equals("POST"))
            {
                restRequest = new RestRequest(endPoint, Method.Post);
                restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
                restRequest.RequestFormat = DataFormat.Json;
            }
            else if (type.Equals("PUT"))
            {
                restRequest = new RestRequest(endPoint, Method.Put);
                restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
                restRequest.RequestFormat = DataFormat.Json;
            }
            else if (type.Equals("DELETE"))
            {
                restRequest = new RestRequest(endPoint, Method.Delete);
                restRequest.AddParameter("Accept", "application/json");
                restRequest.RequestFormat = DataFormat.Json;
            }

            RestResponse response = restClient.Execute(restRequest);

            return response;
        }


    }
}
