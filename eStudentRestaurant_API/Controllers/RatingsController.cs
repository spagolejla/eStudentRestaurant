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
    public class RatingsController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        // GET: api/Ratings
        public IQueryable<Rating> GetRating()
        {
            return db.Rating;
        }

        // GET: api/Ratings/5
        [ResponseType(typeof(Rating))]
        public IHttpActionResult GetRating(int id)
        {
            Rating rating = db.Rating.Find(id);
            if (rating == null)
            {
                return NotFound();
            }

            return Ok(rating);
        }

        [ResponseType(typeof(Rating))]
        [Route("api/Ratings/GetRatingByProductIdAndStudentId/{productId?}/{studentId?}")]
        public IHttpActionResult GetRatingByProductIdAndStudentId(int productId, int studentId)
        {
            Rating rating = db.Rating.Where(p => p.ProductID == productId).Where(s => s.StudentID == studentId)
                            .FirstOrDefault();
            if (rating == null)
            {
                return NotFound();
            }

            return Ok(rating);
        }


        [ResponseType(typeof(double))]
        [Route("api/Ratings/GetAverageRating/{productId?}")]
        public decimal GetAverageRating(int productId)
        {
          return  db.esp_GetProductAverageRating(productId).FirstOrDefault().Value;

          
        }

        // PUT: api/Ratings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRating(int id, Rating rating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rating.RatingID)
            {
                return BadRequest();
            }

            db.Entry(rating).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RatingExists(id))
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

        // POST: api/Ratings
        [ResponseType(typeof(Rating))]
        public IHttpActionResult PostRating(Rating rating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rating.Add(rating);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rating.RatingID }, rating);
        }

        // DELETE: api/Ratings/5
        [ResponseType(typeof(Rating))]
        public IHttpActionResult DeleteRating(int id)
        {
            Rating rating = db.Rating.Find(id);
            if (rating == null)
            {
                return NotFound();
            }

            db.Rating.Remove(rating);
            db.SaveChanges();

            return Ok(rating);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RatingExists(int id)
        {
            return db.Rating.Count(e => e.RatingID == id) > 0;
        }
    }
}