using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudentRestaurant_Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentProfilePage : ContentPage
	{
		public StudentProfilePage ()
		{
			InitializeComponent ();
            StudentNameLabel.Text = Global.loggedStudent.FirstName + " " + Global.loggedStudent.LastName;

        }

        protected override void OnAppearing()
        {
            FirstNameLabel.Text = Global.loggedStudent.FirstName;
            LastNameLabel.Text = Global.loggedStudent.LastName;
            JmbgLabel.Text = Global.loggedStudent.JMBG;
            BirthdayLabel.Text = Global.loggedStudent.BirthDate.ToString("MM/dd/yyyy");
            AddrressLabel.Text = Global.loggedStudent.Address_;
            PhoneLabel.Text = Global.loggedStudent.Phone;
            CityNameLabel.Text = "Mostar"; //0Global.loggedStudent.City.Name;
            UsernameLabel.Text = Global.loggedStudent.Username;

            base.OnAppearing();
        }
    }
}