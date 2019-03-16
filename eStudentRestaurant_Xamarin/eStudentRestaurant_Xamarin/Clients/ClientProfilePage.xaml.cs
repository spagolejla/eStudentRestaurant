using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudentRestaurant_Xamarin.Clients
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClientProfilePage : ContentPage
	{
		public ClientProfilePage ()
		{
			InitializeComponent ();
            ClientNameLabel.Text = Global.loggedClient.FirstName + " " + Global.loggedClient.LastName;
		}

        protected override void OnAppearing()
        {
            FirstNameLabel.Text = Global.loggedClient.FirstName;
            LastNameLabel.Text = Global.loggedClient.LastName;
            OrganizationLabel.Text = Global.loggedClient.OrganizationName;
            PhoneLabel.Text = Global.loggedClient.Phone;
            CityNameLabel.Text = "Mostar"; //Global.loggedStudent.City.Name;
            UsernameLabel.Text = Global.loggedClient.Username;
            PointsLabel.Text = Global.loggedClient.Points.ToString();
            base.OnAppearing();
        }

        private void EditProfileButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Clients.ClientEditPage());
        }
    }
}