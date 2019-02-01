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
    public class MenuItemsController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        // GET: api/MenuItems
        public IQueryable<MenuItem> GetMenuItem()
        {
            return db.MenuItem;
        }

        // GET: api/MenuItems/5 GetItemsByMenuID
        [ResponseType(typeof(MenuItem))]
        public IHttpActionResult GetMenuItem(int id)
        {
            MenuItem menuItem = db.MenuItem.Find(id);
            if (menuItem == null)
            {
                return NotFound();
            }

            return Ok(menuItem);
        }


        // GET: api/MenuItems/5 GetItemsByMenuID
        [HttpGet]
        [ResponseType(typeof(List<MenuItem_Result>))]
        [Route("api/MenuItems/GetItemsByMenuID/{id}")]
        public List<MenuItem_Result> GetItemsByMenuID(int id)
        {
            return db.esp_SelectMenuItemByMenuID(id).ToList();
        }


        // PUT: api/MenuItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMenuItem(int id, MenuItem menuItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != menuItem.MenuItemID)
            {
                return BadRequest();
            }

            db.Entry(menuItem).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/MenuItems
        [ResponseType(typeof(MenuItem))]
        public IHttpActionResult PostMenuItem(MenuItem menuItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MenuItem.Add(menuItem);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = menuItem.MenuItemID }, menuItem);
        }

        // DELETE: api/MenuItems/5
        [ResponseType(typeof(MenuItem))]
        public IHttpActionResult DeleteMenuItem(int id)
        {
            MenuItem menuItem = db.MenuItem.Find(id);
            if (menuItem == null)
            {
                return NotFound();
            }

            db.MenuItem.Remove(menuItem);
            db.SaveChanges();

            return Ok(menuItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MenuItemExists(int id)
        {
            return db.MenuItem.Count(e => e.MenuItemID == id) > 0;
        }
    }
}