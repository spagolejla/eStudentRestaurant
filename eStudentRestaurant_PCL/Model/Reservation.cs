using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_PCL.Model
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int ClinetID { get; set; }
        public Nullable<int> ReservationTypeID { get; set; }
        public System.DateTime ReservationDateTime { get; set; }
        public int PlacesNamber { get; set; }
        public string Note { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> ReservationStatusID { get; set; }
    }
}
