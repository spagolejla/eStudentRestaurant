using eStudentRestaurant_PCL.Model;
using eStudentRestaurant_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace eStudentRestaurant_Xamarin.Clients
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReservationDetailsPage : ContentPage
    {
        private WebAPIHelper reservationsService = new WebAPIHelper("http://172.21.184.193/", "api/Reservations");

        Reservation_Result reservation;

        public ReservationDetailsPage(int id)
        {
            InitializeComponent();
            BindData(id);
        }

        private void BindData(int id)
        {
            HttpResponseMessage response = reservationsService.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                reservation = JsonConvert.DeserializeObject<Reservation_Result>(jsonObject.Result);

                ReservationNameLabel.Text = reservation.Name_;
                ReservationNoteLabel.Text = "Description: " + reservation.Note;
                PlacesNumberLabel.Text = "Number of places: " + reservation.PlacesNamber.ToString();
                DateLabel.Text = "Date: " + reservation.ReservationDateTime.ToString("MM/dd/yyyy");

                AprovedLabel.Text = reservation.Status;

            }
            else
            {
                DisplayAlert("Error!", "Status code: " + response.StatusCode + " Message: " + response.ReasonPhrase, "OK");

            }

        }
    }
}