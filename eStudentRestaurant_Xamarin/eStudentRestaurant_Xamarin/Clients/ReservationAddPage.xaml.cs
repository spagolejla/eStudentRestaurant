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
    public partial class ReservationAddPage : ContentPage
    {
        private WebAPIHelper reservationsService = new WebAPIHelper("http://172.21.184.193/", "api/Reservations");
        private WebAPIHelper clientsService = new WebAPIHelper("http://172.21.184.193/", "api/Clients");
        private WebAPIHelper reservationTypeService = new WebAPIHelper("http://172.21.184.193/", "api/ReservationTypes");

        double discount = 0;
        double price = 0;
        int reservationTypeId = 1;

        public ReservationAddPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            try
            {
                HttpResponseMessage response = reservationTypeService.GetResponse();

                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();
                    List<ReservationType> resrvationTypes = JsonConvert.DeserializeObject<List<ReservationType>>(jsonObject.Result);


                    ReservationTypesPicker.ItemsSource = resrvationTypes;
                    ReservationTypesPicker.ItemDisplayBinding = new Binding("Name_");

                }



                base.OnAppearing();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error!", ex.Message, "OK");
            }
        }



        private void CheckPriceButton_Clicked(object sender, EventArgs e)
        {

            price = 1000;
            if (Convert.ToInt32(NumberOfGuests.Text) > 100)
            {
                price += (Convert.ToInt32(NumberOfGuests.Text) - 100) * 10;


            }
            PriceLabel.Text = "Price:  " + price.ToString() + " KM";
            PriceView.IsVisible = true;
            AddReservationButton.IsEnabled = true;
            if (Global.loggedClient.Points >= 10)
            {
                UseDiscountButton.IsEnabled = true;
            }
            CheckPriceButton.IsEnabled = false;

        }

        private void UseDiscountButton_Clicked(object sender, EventArgs e)
        {
            //Global.loggedClient.Points -= 10;
            //izmijeniti u bazi
            //price -= price*discount
            discount = 0.2;
            price = price - (price * discount);
        }

        private void ReservationTypesPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReservationTypesPicker.SelectedItem != null)
            {
                reservationTypeId = (ReservationTypesPicker.SelectedItem as ReservationType).ReservationTypeID;

            }
        }

        private void AddReservationButton_Clicked(object sender, EventArgs e)
        {
            if (ResrvationDatePicker.Date <= DateTime.Now)
            {
                DisplayAlert("Error!", "This date is not allowed!", "OK");
            }
            else if (ReservationTypesPicker.SelectedItem == null)
            {
                DisplayAlert("Error!", "You must select reservation type !", "OK");

            }
            else if (NumberOfGuests.Text == null)
            {
                DisplayAlert("Error!", "Number of guests is not allowed!", "OK");

            }
            else if (!NumberOfGuests.Text.Any(char.IsDigit))
            {
                DisplayAlert("Error!", "Only digit are allowed!", "OK");
            }
        
            else if (Convert.ToInt32(NumberOfGuests.Text) <= 0 || Convert.ToInt32(NumberOfGuests.Text) > 1000)
            {
                DisplayAlert("Error!", "Number of guests is not allowed!", "OK");

            }

            else
            {
                Reservation newReservation = new Reservation()
                {
                    ReservationTypeID = reservationTypeId,
                    PlacesNamber = Convert.ToInt32(NumberOfGuests.Text),
                    Note = Note.Text,
                    ClinetID = Global.loggedClient.ClientID,
                    ReservationDateTime = ResrvationDatePicker.Date,
                    Discount = Convert.ToDecimal(discount),
                    Price = Convert.ToDecimal(price),
                    ReservationStatusID = 1
                };

                HttpResponseMessage response = reservationsService.PostResponse(newReservation);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Success! ", "You successfuly added request for reservation", "OK");
                    this.Navigation.PushAsync(new Clients.ReservationsListPage());

                }
                else
                {
                    DisplayAlert("Error! ", "Something bad was happend, please try again later!", "OK");
                
                }
            }

        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {

            Page page = this.Navigation.NavigationStack.FirstOrDefault();
            
            this.Navigation.PushAsync(new Clients.ClientMainPage());
            this.Navigation.RemovePage(page);
        }

        private void NumberOfGuests_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NumberOfGuests.Text != null)
            {
                if (!NumberOfGuests.Text.Any(char.IsDigit))
                {
                    DisplayAlert("Error!", "Only digit are allowed!", "OK");
                }
                else if (Convert.ToInt32(NumberOfGuests.Text.ToString()) > 100)
                {
                    price += (Convert.ToInt32(NumberOfGuests.Text) - 100) * 10;
                }
                else
                {
                    price = 1000;
                }

                CheckPriceButton.IsEnabled = true;
            }
        }
    }
}