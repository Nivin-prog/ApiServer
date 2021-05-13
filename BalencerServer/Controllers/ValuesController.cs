using DataAccess.Buisness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess.Models;
using Newtonsoft.Json;
using System.Text;

namespace BalencerServer.Controllers
{
    public class ValuesController : ApiController
    {
        DataPreprocessor DataAccesBuisness;
        public ValuesController()
        {
            this.DataAccesBuisness = new DataPreprocessor();
        }
        // GET api/values
        public HttpResponseMessage Get()
        {
           
            string responseMessage = DataAccesBuisness.LoadDataUsingDb(0);
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(responseMessage, Encoding.UTF8, "application/json");
            return response;
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            string responseMessage = DataAccesBuisness.LoadDataUsingDb(id);
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(responseMessage, Encoding.UTF8, "application/json");
            return response;
        }

        // POST api/values
        public HttpResponseMessage Post(StudentDetailsData dataTobeUpdated)
        {
            
            var responseMessage = DataAccesBuisness.InsertData(dataTobeUpdated);
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(responseMessage.ToString(), Encoding.UTF8, "application/json");
            return response;
        }

        // POST api/values/5
        public HttpResponseMessage Post(int id, StudentDetailsData dataTobeUpdated)
        {
            var responseMessage = DataAccesBuisness.UpdateToDb(dataTobeUpdated);
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(responseMessage.ToString(), Encoding.UTF8, "application/json");
            return response;

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
