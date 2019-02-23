using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace eStudentRestaurant_PCL.Util
{
    public class WebAPIHelper
    {
        private HttpClient Client { get; set; }
        private string Route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            Client = new HttpClient();

            Client.BaseAddress = new Uri("http://localhost:49641/");
            this.Route = route;

        }
        public HttpResponseMessage GetResponse(string parameter = "")
        {
            return Client.GetAsync(Route + "/" + parameter).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parameter = "")
        {
            return Client.GetAsync(Route + "/" + action + "/" + parameter).Result;
        }

        public HttpResponseMessage GetActionResponseIdParam(string action, int parameter)
        {
            return Client.GetAsync(Route + "/" + action + "/" + parameter).Result;
        }

        public HttpResponseMessage GetActionResponseDateParam(string action, int d, int m, int y)
        {
            return Client.GetAsync(Route + "/" + action + "/" + d + "/" + m + "/" + y).Result;
        }

        public HttpResponseMessage PostResponse(Object newObject)
        {
            StringContent jsonObject = new StringContent(JsonConvert.SerializeObject(newObject),
                Encoding.UTF8, "application/json");
            return Client.PostAsync(Route, jsonObject).Result;
        }


        //public HttpResponseMessage PostActionResponse(string action, Object newObject)
        //{
        //    return Client.PostAsJsonAsync(Route + "/" + action, newObject).Result;
        //}

        //public HttpResponseMessage PutResponse(int id, Object existingObject)
        //{
        //    return Client.PutAsJsonAsync(Route + "/" + id, existingObject).Result;
        //}

        public HttpResponseMessage DeleteResponse(int id)
        {
            return Client.DeleteAsync(Route + "/" + id).Result;
        }
    }
}
