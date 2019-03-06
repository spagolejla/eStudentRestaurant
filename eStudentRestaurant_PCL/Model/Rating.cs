using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_PCL.Model
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int ProductID { get; set; }
        public int StudentID { get; set; }
        public int Rating1 { get; set; }

        public  Product Product { get; set; }
        public  Student Student { get; set; }
    }
}
