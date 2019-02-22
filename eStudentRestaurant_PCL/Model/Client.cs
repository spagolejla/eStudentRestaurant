using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_PCL.Model
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Nullable<int> CityID { get; set; }
        public bool Active { get; set; }
        public string Username { get; set; }
        public string PaswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string OrganizationName { get; set; }

        public virtual City City { get; set; }
    }
}
