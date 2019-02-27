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
        public int EmployeeID { get; set; }




        public  List<OrderItem> OrderItem { get; set; }
       
        public  List<OrderMenu> OrderMenu { get; set; }
        public  OrderStatus OrderStatus { get; set; }
        
        
    }
}
