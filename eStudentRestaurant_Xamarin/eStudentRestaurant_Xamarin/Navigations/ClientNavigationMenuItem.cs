using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStudentRestaurant_Xamarin.Navigations
{

    public class ClientNavigationMenuItem
    {
        public ClientNavigationMenuItem()
        {
            TargetType = typeof(MainPage);
        }
        public string Icon { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}