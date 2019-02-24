using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_PCL.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name_ { get; set; }
        public decimal Price { get; set; }
        public int QuantityStock { get; set; }
        public Nullable<System.DateTime> LastPurchaseDate { get; set; }
        public byte[] Picture { get; set; }
        public byte[] PictureThumb { get; set; }
        public bool Status { get; set; }
    }
}
