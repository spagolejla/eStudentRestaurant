using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eStudentRestaurant_API.Models
{
    public partial class eStudentRestaurantEntities
    {
        public eStudentRestaurantEntities( bool enableLazyLoading): base("eStudentRestaurantEntities")
        {
            this.Configuration.LazyLoadingEnabled = enableLazyLoading;
        }
    }
}