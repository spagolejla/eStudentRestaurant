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
    public class OrderMenusController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities();

        // GET: api/OrderMenus
        public IQueryable<OrderMenu> GetOrderMenu()
        {
            return db.OrderMenu;
        }

        // GET: api/OrderMenus/5
        [ResponseType(typeof(OrderMenu))]
        public IHttpActionResult GetOrderMenu(int id)
        {
            OrderMenu orderMenu = db.OrderMenu.Find(id);
            if (orderMenu == null)
            {
                return NotFound();
            }

            return Ok(orderMenu);
        }

        // PUT: api/OrderMenus/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrderMenu(int id, OrderMenu orderMenu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orderMenu.OrderMenuID)
            {
                return BadRequest();
            }

            db.Entry(orderMenu).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderMenuExists(id))
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

        // POST: api/OrderMenus
        [ResponseType(typeof(OrderMenu))]
        public IHttpActionResult PostOrderMenu(OrderMenu orderMenu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OrderMenu.Add(orderMenu);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = orderMenu.OrderMenuID }, orderMenu);
        }

        // DELETE: api/OrderMenus/5
        [ResponseType(typeof(OrderMenu))]
        public IHttpActionResult DeleteOrderMenu(int id)
        {
            OrderMenu orderMenu = db.OrderMenu.Find(id);
            if (orderMenu == null)
            {
                return NotFound();
            }

            db.OrderMenu.Remove(orderMenu);
            db.SaveChanges();

            return Ok(orderMenu);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderMenuExists(int id)
        {
            return db.OrderMenu.Count(e => e.OrderMenuID == id) > 0;
        }
    }
}