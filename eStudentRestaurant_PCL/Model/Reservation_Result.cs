using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_PCL.Model
{
     public class Reservation_Result
    {
        public int ReservationID { get; set; }
        public int ClinetID { get; set; }
        public Nullable<int> ReservationTypeID { get; set; }
        public System.DateTime ReservationDateTime { get; set; }
        public int PlacesNamber { get; set; }
        public string Note { get; set; }
        public bool Approved { get; set; }

        public  Client Client { get; set; }
        public  ReservationType ReservationType { get; set; }
    }
}
