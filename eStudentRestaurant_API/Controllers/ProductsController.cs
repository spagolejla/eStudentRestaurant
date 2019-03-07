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
using eStudentRestaurant_API.Util;

namespace eStudentRestaurant_API.Controllers
{
    public class ProductsController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        // GET: api/Products
        public List<Product> GetProduct()
        {
            List<Product> products =  db.Product.ToList();

            foreach (var item in products)
            {
                item.Picture = null;
            }

            return products;
        }
        [HttpGet]
        [ResponseType(typeof(List<Product>))]
        [Route("api/Products/GetAvaibleProduct")]
        public List<Product> GetAvaibleProduct()
        {
          
            List<Product> products = db.Product.Where(x => x.Status == true).ToList();

            foreach (var item in products)
            {
                item.Picture = null;
            }

            return products;
        }
        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            product.Picture = null;
            return Ok(product);
        }

        [HttpGet]
        [ResponseType(typeof(List<Product>))]
        [Route("api/Products/RecommendedProducts/{id?}")]
        public List<Product> RecommendedProducts(int id)
        {
            RecommenderSystem recommender = new RecommenderSystem();
          
            List<Product> recommendedProducts = recommender.GetRecommendedProducts(id);
            foreach (var item in recommendedProducts)
            {
                item.Picture = null;
            }


            return recommendedProducts;
        }

        [HttpGet]
        [ResponseType(typeof(Product))]
        [Route("api/Products/GetProductsByName/{name?}")]
        public List<Product> GetProductsByName(string name = "")
        {
            List<Product> products = db.Product.Where(x => x.Name_.Contains(name)).ToList();

            foreach (var item in products)
            {
                item.Picture = null;
            }

            return products;
            
        }


        // name exist
        [HttpGet]
        [ResponseType(typeof(Product))]
        [Route("api/Products/NameExist/{name}")]
        public IHttpActionResult NameExist(string name)
        {
            Product product = db.Product.Where(x => x.Name_ == name).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);

        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.ProductID)
            {
                return BadRequest();
            }

            db.Entry(product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Product.Add(product);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = product.ProductID }, product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            db.Product.Remove(product);
            db.SaveChanges();

            return Ok(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Product.Count(e => e.ProductID == id) > 0;
        }
    }
}