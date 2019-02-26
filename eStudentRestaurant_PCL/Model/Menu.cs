using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_PCL.Model
{
    public class Menu
    {
        public Menu()
        {
            this.MenuItem = new HashSet<MenuItem>();
            this.OrderMenu = new HashSet<OrderMenu>();
        }

        public int MenuID { get; set; }
        public string Name_ { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuItem> MenuItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderMenu> OrderMenu { get; set; }
    }
}
