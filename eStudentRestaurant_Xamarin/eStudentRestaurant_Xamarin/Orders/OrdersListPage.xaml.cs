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

namespace eStudentRestaurant_Xamarin.Orders
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrdersListPage : ContentPage
	{
        private WebAPIHelper ordersService = new WebAPIHelper("http://172.21.184.193/", "api/Orders");


        public OrdersListPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            HttpResponseMessage response = ordersService.GetActionResponse("GetOrdersByStudentID", Global.loggedStudent.StudentID.ToString());

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(jsonObject.Result);

                OrdersList.ItemsSource = orders;


            }
            else
            {
                DisplayAlert("Error", "Something bad has happaned, status code: " + response.StatusCode, "OK");
            }

            base.OnAppearing();
        }
    }
}