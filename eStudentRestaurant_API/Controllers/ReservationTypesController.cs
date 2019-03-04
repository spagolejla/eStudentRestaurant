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
    public class ReservationTypesController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        // GET: api/ReservationTypes
        public IQueryable<ReservationType> GetReservationType()
        {
            return db.ReservationType;
        }

        // GET: api/ReservationTypes/5
        [ResponseType(typeof(ReservationType))]
        public IHttpActionResult GetReservationType(int id)
        {
            ReservationType reservationType = db.ReservationType.Find(id);
            if (reservationType == null)
            {
                return NotFound();
            }

            return Ok(reservationType);
        }

        // PUT: api/ReservationTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReservationType(int id, ReservationType reservationType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reservationType.ReservationTypeID)
            {
                return BadRequest();
            }

            db.Entry(reservationType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationTypeExists(id))
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

        // POST: api/ReservationTypes
        [ResponseType(typeof(ReservationType))]
        public IHttpActionResult PostReservationType(ReservationType reservationType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ReservationType.Add(reservationType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = reservationType.ReservationTypeID }, reservationType);
        }

        // DELETE: api/ReservationTypes/5
        [ResponseType(typeof(ReservationType))]
        public IHttpActionResult DeleteReservationType(int id)
        {
            ReservationType reservationType = db.ReservationType.Find(id);
            if (reservationType == null)
            {
                return NotFound();
            }

            db.ReservationType.Remove(reservationType);
            db.SaveChanges();

            return Ok(reservationType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReservationTypeExists(int id)
        {
            return db.ReservationType.Count(e => e.ReservationTypeID == id) > 0;
        }
    }
}