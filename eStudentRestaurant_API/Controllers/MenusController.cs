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
    public class MenusController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        // GET: api/Menus
        public List<Menu> GetMenu()
        {
            return db.Menu.ToList();
        }

        // GET: api/Menus/5
        [ResponseType(typeof(Menu))]
        public IHttpActionResult GetMenu(int id)
        {
            Menu menu = db.Menu.Find(id);
            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }

        [HttpGet]
        [ResponseType(typeof(MenuItem))]
        [Route("api/Menus/GetMenuItems/{id}")]
        public List<MenuItem> GetMenuItems(int id)
        {
            List<MenuItem> menuItems = db.MenuItem.Where(x => x.MenuID == id).Include(p => p.Product).ToList();

            return menuItems;
        }

        // name exist
        [HttpGet]
        [ResponseType(typeof(Menu))]
        [Route("api/Menus/NameExist/{name}")]
        public IHttpActionResult NameExist(string name)
        {
            Menu menu = db.Menu.Where(x => x.Name_ == name).FirstOrDefault();

            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }

        // PUT: api/Menus/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMenu(int id, Menu menu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != menu.MenuID)
            {
                return BadRequest();
            }

            db.Entry(menu).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuExists(id))
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

        // POST: api/Menus
        [ResponseType(typeof(Menu))]
        public IHttpActionResult PostMenu(Menu menu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Menu.Add(menu);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = menu.MenuID }, menu);
        }

        // DELETE: api/Menus/5
        [ResponseType(typeof(Menu))]
        public IHttpActionResult DeleteMenu(int id)
        {
            Menu menu = db.Menu.Find(id);
            if (menu == null)
            {
                return NotFound();
            }

            List<MenuItem> menuItems = db.MenuItem.Where(x => x.MenuID == id).ToList();
            if (menuItems.Count()>0)
            {
                db.MenuItem.RemoveRange(menuItems);
                db.SaveChanges();
            }
            db.Menu.Remove(menu);
            db.SaveChanges();

            return Ok(menu);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MenuExists(int id)
        {
            return db.Menu.Count(e => e.MenuID == id) > 0;
        }
    }
}