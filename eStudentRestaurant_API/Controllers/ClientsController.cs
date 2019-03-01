using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eStudentRestaurant_API.Models;

namespace eStudentRestaurant_API.Controllers
{
    public class ClientsController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        // GET: api/Clients
        public IQueryable<Client> GetClient()
        {
            return db.Client.Include(c=>c.City);
        }

        // GET: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult GetClient(int id)
        {
            Client client = db.Client.Where(x=>x.ClientID == id).Include(c=>c.City).FirstOrDefault();
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        [HttpGet]
        [ResponseType(typeof(Client))]
        [Route("api/Clients/GetClientByUsername/{username?}")]
        public IHttpActionResult GetClientByUsername(string username)
        {
            Client client = db.esp_ClientSelectByUsername(username).FirstOrDefault();

            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        // Username exist
        [HttpGet]
        [ResponseType(typeof(Client))]
        [Route("api/Clients/UsernameExist/{username?}")]
        public IHttpActionResult UsernameExist(string username)
        {
            Client client = db.Client.Where(x => x.Username == username).FirstOrDefault();

            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }


        // PUT: api/Clients/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClient(int id, Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != client.ClientID)
            {
                return BadRequest();
            }

            db.esp_ClientUpdate(client.ClientID, client.FirstName, client.LastName,
                client.Phone, client.CityID, client.Active, client.Username, client.PaswordHash, client.PasswordSalt, client.OrganizationName);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Clients
        [ResponseType(typeof(Client))]
        public IHttpActionResult PostClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Client.Add(client);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = client.ClientID }, client);
        }

        // DELETE: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult DeleteClient(int id)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            db.Client.Remove(client);
            db.SaveChanges();

            return Ok(client);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientExists(int id)
        {
            return db.Client.Count(e => e.ClientID == id) > 0;
        }
    }
}