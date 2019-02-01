using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using eStudentRestaurant_API.Models;

namespace eStudentRestaurant_UI.Util
{
    class WebAPIHelper
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

        public HttpResponseMessage GetActionResponseIdParam(string action, int parameter )
        {
            return Client.GetAsync(Route + "/" + action + "/" + parameter).Result;
        }

        public HttpResponseMessage PostResponse(Object newObject)
        {
            return Client.PostAsJsonAsync(Route, newObject).Result;
        }

        public HttpResponseMessage PostActionResponse(string action, Object newObject)
        {
            return Client.PostAsJsonAsync(Route + "/" + action, newObject).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObject)
        {
            return Client.PutAsJsonAsync(Route + "/" + id, existingObject).Result;
        }

        public HttpResponseMessage DeleteResponse(int id)
        {
            return Client.DeleteAsync(Route + "/" + id).Result;
        }
    }
}
