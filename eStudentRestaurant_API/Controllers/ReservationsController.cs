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
    public class ReservationsController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);


        // GET: api/Reservations/5
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult GetReservation(int id)
        {
            Reservation reservation = db.Reservation.Find(id);
            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }


        [ResponseType(typeof(List<Reservation_Result>))]
        [Route("api/Reservations/GetReservationByClient/{id}")]
        public List<Reservation_Result> GetReservationByClient(int id)
        {

            return db.esp_ReservationSelectByClientId(id).ToList();
        }

        [HttpGet]
        [ResponseType(typeof(Reservation))]
        [Route("api/Reservations/ApprovedReservationExist/{id}")]
        public IHttpActionResult ApprovedReservationExist(int id)
        {
            
            Reservation res = db.Reservation.Find(id);

            Reservation resApproved = db.Reservation.Where(x => x.Approved == true).Where(d => d.ReservationDateTime.Day ==
            res.ReservationDateTime.Day && d.ReservationDateTime.Month == res.ReservationDateTime.Month
            && d.ReservationDateTime.Year == res.ReservationDateTime.Year).FirstOrDefault();

            if (resApproved == null)
            {
                res.Approved = true;
                db.SaveChanges();
                return NotFound();
            }

            return Ok(resApproved);



           
        }



        // PUT: api/Reservations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReservation(int id, Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reservation.ReservationID)
            {
                return BadRequest();
            }

            db.Entry(reservation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationExists(id))
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

        // POST: api/Reservations
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult PostReservation(Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reservation.Add(reservation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = reservation.ReservationID }, reservation);
        }

        // DELETE: api/Reservations/5
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult DeleteReservation(int id)
        {
            Reservation reservation = db.Reservation.Find(id);
            if (reservation == null)
            {
                return NotFound();
            }

            db.Reservation.Remove(reservation);
            db.SaveChanges();

            return Ok(reservation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReservationExists(int id)
        {
            return db.Reservation.Count(e => e.ReservationID == id) > 0;
        }
    }
}