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
    public class StudentsController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        // GET: api/Students
        public IQueryable<Student> GetStudent()
        {
            return db.Student.Include(c => c.City);
        }

        // GET: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(int id)
        {
            Student student = db.Student.Where(x=>x.StudentID == id).Include(c => c.City).FirstOrDefault();
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // Get students by name
        [HttpGet]
        [ResponseType(typeof(Student_Result))]
        [Route("api/Students/GetStudentsByName/{name?}")]
        public List<Student_Result> GetStudentsByName(string name = "")
        {
            return db.esp_StudentSelectByName(name).ToList();
        }
        
 
        // Get student by username
        [HttpGet]
        [ResponseType(typeof(Student))]
        [Route("api/Students/GetStudentByUsername/{username?}")]
        public IHttpActionResult GetStudentByUsername(string username)
        {
            Student student = db.esp_StudentSelectByUsername(username).FirstOrDefault();

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // Username exist
        [HttpGet]
        [ResponseType(typeof(Student))]
        [Route("api/Students/UsernameExist/{username?}")]
        public IHttpActionResult UsernameExist(string username)
        {
            Student student = db.Student.Where(x => x.Username == username).FirstOrDefault();

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/Students/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != student.StudentID)
                return BadRequest();

            db.esp_StudentUpdate(student.StudentID, student.FirstName, student.LastName, student.JMBG, student.BirthDate,
              student.Address_, student.Phone, student.CityID, student.Active, student.Username, student.PaswordHash, student.PasswordSalt);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Students
        [ResponseType(typeof(Student))]
        public IHttpActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Student.Add(student);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = student.StudentID }, student);
        }

        // DELETE: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult DeleteStudent(int id)
        {
            Student student = db.Student.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            db.Student.Remove(student);
            db.SaveChanges();

            return Ok(student);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentExists(int id)
        {
            return db.Student.Count(e => e.StudentID == id) > 0;
        }
    }
}