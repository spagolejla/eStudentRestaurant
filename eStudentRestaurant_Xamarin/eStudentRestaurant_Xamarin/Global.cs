using eStudentRestaurant_PCL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eStudentRestaurant_Xamarin
{
    public class Global
    {
        public static Student loggedStudent { get; set; }
        public static Client loggedClient { get; set; }

        public static Order ActiveOrder { get; set; }
    }
}
