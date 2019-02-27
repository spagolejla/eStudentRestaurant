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
            Order_ order_ = db.Order_.Where(x => x.OrderID == id).FirstOrDefault();
            if (order_ == null)
            {
                return NotFound();
            }

            return Ok(order_);
        }

        [ResponseType(typeof(OrderItem))]
        [Route("api/Orders/GetOrderItems/{id}")]
        public List<OrderItem> GetOrderItems(int id)
        {
            List<OrderItem> orderItems = db.OrderItem.Where(x => x.OrderID == id).Include(p=>p.Product).ToList();

            return orderItems;
        }

        [ResponseType(typeof(OrderMenu))]
        [Route("api/Orders/GetOrderMenus/{id}")]
        public List<OrderMenu> GetOrderMenus(int id)
        {
            List<OrderMenu> orderMenus = db.OrderMenu.Where(x => x.OrderID == id).Include(m=>m.Menu).ToList();

            return orderMenus;
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

        [ResponseType(typeof(OrderDetails_Result))]
        [Route("api/Orders/GetOrderDetailsByOrderID/{id?}")]
        public List<OrderDetails_Result> GetOrderDetailsByOrderID(int id)
        {
            return db.esp_OrderDetailsSelectByOrderID(id).ToList();
        }

        [ResponseType(typeof(OrderDetails_Result))]
        [Route("api/Orders/GetOrdersByStudentID/{id?}")]
        public List<Order_> GetOrdersByStudentID(int id)
        {
            return db.Order_.Where(x => x.StudentID == id).Include(os => os.OrderStatus).OrderByDescending(d=>d.OrderDate).ToList();
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

            Order_ newOrder = new Order_();
            newOrder.EmployeeID = order_.EmployeeID;
            newOrder.StudentID = order_.StudentID;
            newOrder.OrderDate = order_.OrderDate;
            newOrder.TotalPrice = order_.TotalPrice;
            newOrder.OrderStatusID = order_.OrderStatusID;
            

            db.Order_.Add(newOrder);
            db.SaveChanges();

            if (order_.OrderItem.Count != 0)
            {
                foreach (var item in order_.OrderItem)
                {
                    OrderItem oi = new OrderItem()
                    {
                        OrderID = newOrder.OrderID,
                        ProductID = item.ProductID,
                        Quantity = item.Quantity
                    };

                    db.OrderItem.Add(oi);
                }
            }

            if (order_.OrderMenu.Count != 0)
            {
                foreach (var menu in order_.OrderMenu)
                {
                    OrderMenu mi = new OrderMenu()
                    {
                        OrderID = newOrder.OrderID,
                        MenuID = menu.MenuID,
                        Quantity = menu.Quantity
                    };

                    db.OrderMenu.Add(mi);
                }

            }

            db.SaveChanges();


            return CreatedAtRoute("DefaultApi", new { id = newOrder.OrderID }, order_);
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