using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eStudentRestaurant_Xamarin;

namespace eStudentRestaurant_Xamarin.Navigations
{

    public class StudentNavigationMenuItem
    {
        public StudentNavigationMenuItem()
        {
            TargetType = typeof(StudentMainPage);
        }
        public string Icon { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}