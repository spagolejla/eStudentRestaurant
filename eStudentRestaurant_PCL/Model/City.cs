using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_PCL.Model
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public Nullable<int> StateID { get; set; }
    }
}
