using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_PCL.Model
{
    public class OrderMenu
    {
        public int OrderMenuID { get; set; }
        public int MenuID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }

        public  Menu Menu { get; set; }
       
    }
}
