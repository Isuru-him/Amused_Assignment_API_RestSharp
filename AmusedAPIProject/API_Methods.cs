using AmusedAPIProject;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AmusedAPIProject
{
    public class API_Methods
    {

        APIHelper APIHelper = new APIHelper();
        string Baseurl = "https://api.restful-api.dev";


        public RestResponse getAllObjects_OtherDetails()
        {
            string endPoint = "/objects";
            return APIHelper.getResponse(Baseurl, endPoint, "GET");
        }

        public RestResponse getSingleObjects_OtherDetails(string value)
        {
            string endPoint = "/objects/" + value;
            return APIHelper.getResponse(Baseurl, endPoint, "GET");
        }

        public RestResponse AddSingleObject_OtherDetails(string payload)
        {
            string endPoint = "/objects";
            return APIHelper.getResponse(Baseurl, endPoint, "POST", payload);
        }

        public RestResponse UpdateSingleObject_OtherDetails(string value, string payload)
        {
            string endPoint = "/objects/" + value;
            return APIHelper.getResponse(Baseurl, endPoint, "PUT", payload);
        }

        public RestResponse DeleteSingleObject_OtherDetails(string value)
        {
            string endPoint = "/objects/" + value;
            return APIHelper.getResponse(Baseurl, endPoint, "DELETE");
        }


        public List<GetSingleObjectDTO> getAllObjects()
        {
            string endPoint = "/objects";
            RestResponse response = APIHelper.getResponse(Baseurl, endPoint, "GET");
            var content = response.Content;
            List<GetSingleObjectDTO> GAO = JsonConvert.DeserializeObject<List<GetSingleObjectDTO>>(content);
            return GAO;

        }


        public GetSingleObjectDTO getSingleObject(int value)
        {
            string val = value.ToString();
            string endPoint = "/objects/" + val;
            RestResponse response = APIHelper.getResponse(Baseurl, endPoint, "GET");
            var content = response.Content;
            GetSingleObjectDTO gso = JsonConvert.DeserializeObject<GetSingleObjectDTO>(content);
            return gso;

        }


        public AddObjectDTO AddObject(string payload)
        {
            string endPoint = "/objects";
            RestResponse response = APIHelper.getResponse(Baseurl, endPoint, "POST", payload);
            var content = response.Content;
            AddObjectDTO cso = JsonConvert.DeserializeObject<AddObjectDTO>(content);
            return cso;
        }


        public UpdateObjectDTO UpdateObject(string value, string payload)
        {
            string endPoint = "/objects/" + value;
            RestResponse response = APIHelper.getResponse(Baseurl, endPoint, "PUT", payload);
            var content = response.Content;
            UpdateObjectDTO uso = JsonConvert.DeserializeObject<UpdateObjectDTO>(content);


            return uso;

        }


        public DeleteObjectDTO deleteSingleObject(string value)
        {
            string endPoint = "/objects/" + value;
            RestResponse response = APIHelper.getResponse(Baseurl, endPoint, "DELETE");
            var content = response.Content;
            DeleteObjectDTO dso = JsonConvert.DeserializeObject<DeleteObjectDTO>(content);
            return dso;

        }



    }
}
