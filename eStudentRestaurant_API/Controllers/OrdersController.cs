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
    public class OrdersController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        // GET: api/Orders
        public IQueryable<Order_> GetOrder_()
        {
            return db.Order_;
        }

        // GET: api/Orders/5
        [ResponseType(typeof(Order_))]
        public IHttpActionResult GetOrder_(int id)
        {
            Order_ order_ = db.Order_.Find(id);
            if (order_ == null)
            {
                return NotFound();
            }

            return Ok(order_);
        }

        [ResponseType(typeof(Order_Result))]
        [Route("api/Orders/GetOrdersByDate/{day?}/{month?}/{year?}")]
        public List<Order_Result> GetOrdersByDate(int day, int month, int year)
        {
            if (day == 0 || month == 0 || year == 0)
            {
                DateTime today = DateTime.Now;
                return db.esp_OrderSelectByDate(today.Day, today.Month, today.Year).ToList();
            }
            else
            {
                return db.esp_OrderSelectByDate(day, month, year).ToList();
            }
        }

        // PUT: api/Orders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrder_(int id, Order_ order_)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order_.OrderID)
            {
                return BadRequest();
            }

            db.Entry(order_).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Order_Exists(id))
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

        // POST: api/Orders
        [ResponseType(typeof(Order_))]
        public IHttpActionResult PostOrder_(Order_ order_)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Order_.Add(order_);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = order_.OrderID }, order_);
        }

        // DELETE: api/Orders/5
        [ResponseType(typeof(Order_))]
        public IHttpActionResult DeleteOrder_(int id)
        {
            Order_ order_ = db.Order_.Find(id);
            if (order_ == null)
            {
                return NotFound();
            }

            db.Order_.Remove(order_);
            db.SaveChanges();

            return Ok(order_);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Order_Exists(int id)
        {
            return db.Order_.Count(e => e.OrderID == id) > 0;
        }
    }
}