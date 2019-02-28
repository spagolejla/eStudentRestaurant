using eStudentRestaurant_PCL.Model;
using eStudentRestaurant_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudentRestaurant_Xamarin.Clients
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReservationsListPage : ContentPage
	{
        private WebAPIHelper reservationsService = new WebAPIHelper("http://172.21.184.193/", "api/Reservations");

        public ReservationsListPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            HttpResponseMessage response = reservationsService.GetActionResponse("GetReservationByClient", Global.loggedClient.ClientID.ToString());

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<Reservation> reservations = JsonConvert.DeserializeObject<List<Reservation>>(jsonObject.Result);

                ReservationsList.ItemsSource = reservations;


            }
            else
            {
                DisplayAlert("Error!", "Status code: " + response.StatusCode + " Message: " + response.ReasonPhrase, "OK");
            }

            base.OnAppearing();
        }

        public void ReservationsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new Clients.ReservationDetailsPage((e.Item as Reservation).ReservationID));
            }
        }
    }
}