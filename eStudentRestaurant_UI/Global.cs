using eStudentRestaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_UI
{
    class Global
    {

        public static Employee LoggedUser { get; set; }

        #region API routes

        public const string EmployeesRoutes = "api/Employees";

        public const string StudentsRoutes = "api/Students";

        public const string CitiesRoutes = "api/Cities";

        public const string ClientsRoutes = "api/Clients";

        public const string ReservationsRoutes = "api/Reservations";

        public const string ProductsRoutes = "api/Products";









        #endregion
    }
}
