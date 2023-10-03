using AmusedAPIProject;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AmusedAPITestProject
{
    [TestClass]
    public class Regression
    {
        API_Methods c1 = new API_Methods();

        /*************************************** ALL Object - GET - Test scenarios ***********************************************************/

        [TestMethod]
        public void verifyAllObjects_AllAttributes()
        {
            // verifies all available attributes of the 1st object

            var response = c1.getAllObjects();
            Assert.AreEqual("Google Pixel 6 Pro", response.ElementAt(0).name);
            Assert.AreEqual("1", response.ElementAt(0).id);
            Assert.AreEqual("Cloudy White", response.ElementAt(0).data.color);
            Assert.AreEqual("128 GB", response.ElementAt(0).data.capacity);

        }

        [TestMethod]
        public void verifyAllObjects_NotPresentAttribute()
        {
            // verifies the value non present attribute capacity GB of the 1st object

            var response = c1.getAllObjects();
            Assert.AreEqual(0, response.ElementAt(0).data.capacityGB);

        }

        [TestMethod]
        public void verifyAllObjects_statusCode()
        {
            // verifies the status code of the response.

            RestResponse response = c1.getAllObjects_OtherDetails();
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

        }



        /*************************************** Single Object - GET - Test scenarios ***********************************************************/

        [TestMethod]
        public void verifySingleObject_OneAttribute()
        {
            //Verify the name of the object 

            var response = c1.getSingleObject(7);
            Assert.AreEqual("Apple MacBook Pro 16", response.name);

        }

        [TestMethod]
        public void verifySingleObject_AllAttributes()
        {
            //Verify all the attributes in the object

            var response = c1.getSingleObject(7);
            Assert.AreEqual(2019, response.data.year);
            Assert.AreEqual(1849.99, response.data.price);
            Assert.AreEqual("Intel Core i9", response.data.cpuModel);
            Assert.AreEqual("1 TB", response.data.Harddisksize);
            Assert.AreEqual("7", response.id);

        }

        [TestMethod]
        public void verifySingleObject_negativeInputs()
        {
            //Verify the name of the object while sending invalid user ID

            var response = c1.getSingleObject(-7);
            Assert.AreEqual(null, response.name);

        }

        [TestMethod]
        public void verifySingleObjects_statusCode()
        {
            // verifies the status code of the response.

            RestResponse response = c1.getSingleObjects_OtherDetails("7");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

        }



        /*************************************** Single Object - POST - Test scenarios ***********************************************************/

        [TestMethod]
        public void Verify_name_Attribute_CreateSingleObject()
        {
            //verify name attribute of the created object

            string payload = "{ \"name\": \"Apple MacBook Pro 167\",\"data\": {\"year\": 2019,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\"}}";
            var response = c1.AddObject(payload);
            Assert.AreEqual("Apple MacBook Pro 167", response.Name);

        }

        [TestMethod]
        public void Verify_All_Attributes_CreateSingleObject()
        {
            //verify all attribute of the created object

            string payload = "{ \"name\": \"Isuru\",\"data\": {\"year\": 20119,\"price\": 1550.99,\"CPU model\": \"Intel Core i99\",\"Hard disk size\": \"2 TB\"}}";
            var response = c1.AddObject(payload);
            Assert.AreEqual("Isuru", response.Name);
            Assert.AreEqual(1550.99, response.Data.price);
            Assert.AreEqual("Intel Core i99", response.Data.cpuModel);
            Assert.AreEqual("2 TB", response.Data.Harddisksize);
            Assert.AreEqual(20119, response.Data.year);
            Assert.IsTrue(response.AO_CreatedAt.ToString().Length > 0);

        }

        [TestMethod]
        public void verifyAddSingleObjects_statusCode()
        {
            //verify status code of the object creation

            string payload = "{ \"name\": \"Apple MacBook Pro 16\",\"data\": {\"year\": 2019,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\"}}";
            var response = c1.AddSingleObject_OtherDetails(payload);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

        }





        /*************************************** Single Object - PUT - Test scenarios ***********************************************************/

        //Existing ID's are not allwed to be modified hence we should create an object before updating the same. 

        [TestMethod]
        public void Verify_UpdateSingleObject_name()
        {
            // verify updating the name

            string create_payload = "{ \"name\": \"Apple MacBook Pro 16\",\"data\": {\"year\": 2019,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\"}}";
            var create_response = c1.AddObject(create_payload);
            string payload = "{ \"name\": \"iPhone 16\",\"data\": {\"year\": 2019,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\",\"color\": \"silver\"}}";
            var update_responses = c1.UpdateObject(create_response.Id, payload);
            Assert.AreEqual("iPhone 16", update_responses.Name);

        }

        [TestMethod]
        public void Verify_UpdateSingleObject_year()
        {
            // verify updating the year

            string create_payload = "{ \"name\": \"Apple MacBook Pro 16\",\"data\": {\"year\": 2019,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\"}}";
            var create_response = c1.AddObject(create_payload);
            string payload = "{ \"name\": \"iPhone 16\",\"data\": {\"year\": 2029,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\",\"color\": \"silver\"}}";
            var update_responses = c1.UpdateObject(create_response.Id, payload);
            Assert.AreEqual(2029, update_responses.Data.year);

        }

        [TestMethod]
        public void Verify_UpdateSingleObject_statusCode()
        {
            // verify update request status code

            string create_payload = "{ \"name\": \"Apple MacBook Pro 16\",\"data\": {\"year\": 2019,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\"}}";
            var create_response = c1.AddObject(create_payload);
            string payload = "{ \"name\": \"iPhone 16\",\"data\": {\"year\": 2029,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\",\"color\": \"silver\"}}";
            var update_responses = c1.UpdateSingleObject_OtherDetails(create_response.Id, payload);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, update_responses.StatusCode);

        }


        /*************************************** Single Object - DELETE - Test scenarios ***********************************************************/

        //Existing ID's are not allwed to be deleted hence we should create an object before deleting the same. 

        [TestMethod]
        public void Verify_DeleteSingleObject()
        {
            // verifies the success message of the delete request

            string create_payload = "{ \"name\": \"Apple MacBook Pro 16\",\"data\": {\"year\": 2019,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\"}}";
            var create_response = c1.AddObject(create_payload);
            var deleted_responses = c1.deleteSingleObject(create_response.Id);
            Assert.AreEqual("Object with id = " + create_response.Id + " has been deleted.", deleted_responses.Message);

        }


        [TestMethod]
        public void Verify_DeleteSingleObject_statusCode()
        {
            // verifies the status code of the delete request.  

            string create_payload = "{ \"name\": \"Apple MacBook Pro 16\",\"data\": {\"year\": 2019,\"price\": 1849.99,\"CPU model\": \"Intel Core i9\",\"Hard disk size\": \"1 TB\"}}";
            var create_response = c1.AddObject(create_payload);
            var deleted_responses = c1.DeleteSingleObject_OtherDetails(create_response.Id);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, deleted_responses.StatusCode);

        }


    }
}

