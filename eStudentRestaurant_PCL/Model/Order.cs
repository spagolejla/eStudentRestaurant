using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_PCL.Model
{
    public class Order
    {
        public Order()
        {
            this.OrderItem = new List<OrderItem>();
            this.OrderMenu = new List<OrderMenu>();
        }

        public int OrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int OrderStatusID { get; set; }
        public decimal TotalPrice { get; set; }
        public int StudentID { get; set; }
        

      
        public virtual List<OrderItem> OrderItem { get; set; }
       
        public virtual List<OrderMenu> OrderMenu { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual Student Student { get; set; }
        
    }
}
