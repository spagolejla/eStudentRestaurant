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
using eStudentRestaurant_PCL;

namespace eStudentRestaurant_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentMainPage : ContentPage
    {
        private WebAPIHelper productsService = new WebAPIHelper("http://172.21.184.193/", "api/Products");

        public StudentMainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            HttpResponseMessage response = productsService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsonObject.Result);

                ProductsList.ItemsSource = products;


            }

            base.OnAppearing();
        }

        public void ProductsList_ItemTapped (object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new ProductDetailsPage((e.Item as Product).ProductID));
            }
        }
    }
}