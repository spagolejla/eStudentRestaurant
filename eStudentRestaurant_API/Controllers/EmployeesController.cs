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
    public class EmployeesController : ApiController
    {
        private eStudentRestaurantEntities db = new eStudentRestaurantEntities(false);

        // GET: api/Employees
        [HttpGet]
        public List<Employe_Result> GetEmployee()
        {
            return db.esp_EmployeSelectALL().ToList();
        }

        // GET: api/Employees/5
        [HttpGet]
        [ResponseType(typeof(Employee))]
        public IHttpActionResult GetEmployee(int id)
        {
            Employee employee = db.Employee.Where(x=> x.EmployeeID == id).Include(c=>c.City).FirstOrDefault();
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // GET: api/Employees/5
        [HttpGet]
        [ResponseType(typeof(Employe_Result))]
        [Route("api/Employees/GetEmployeesByName/{name?}")]
        public List<Employe_Result> GetEmployeesByName(string name = "")
        {
            return db.esp_EmployeeSelectByName(name).ToList();
        }

        // GET: api/Employees/5
        [HttpGet]
        [ResponseType(typeof(Employee))]
        [Route("api/Employees/GetEmployeeByUsername/{username?}")]
        public IHttpActionResult GetEmployeeByUsername(string username )
        {
            Employee employee = db.esp_EmployeSelectByUsername(username).FirstOrDefault();

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, Employee employee)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != employee.EmployeeID)
                return BadRequest();

            db.esp_EmployeeUpdate(id, employee.FirstName, employee.LastName, employee.JMBG, employee.BirthDate, employee.EmploymentDate,
              employee.Address_, employee.Phone,   employee.CityID, employee.Active, employee.Username, employee.PaswordHash, employee.PasswordSalt );

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employee.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.EmployeeID }, employee);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Employee.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employee.Count(e => e.EmployeeID == id) > 0;
        }
    }
}