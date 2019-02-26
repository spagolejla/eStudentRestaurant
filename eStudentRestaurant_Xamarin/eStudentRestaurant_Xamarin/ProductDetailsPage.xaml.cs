using eStudentRestaurant_PCL.Model;
using eStudentRestaurant_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudentRestaurant_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailsPage : ContentPage
    {
        private WebAPIHelper productsService = new WebAPIHelper("http://172.21.184.193/", "api/Products");

        Product product;
        public ProductDetailsPage(int id)
        {
            InitializeComponent();
            BindData(id);

        }



        private void BindData(int id)
        {
            HttpResponseMessage response = productsService.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                product = JsonConvert.DeserializeObject<Product>(jsonObject.Result);

                ProducteNameLabel.Text = product.Name_;
                ProductImage.Source = ImageSource.FromStream(() => new MemoryStream(product.PictureThumb));
                PriceLabel.Text = product.Price.ToString() + " KM";
                InStockLabel.Text = product.QuantityStock > 0 ? "In stock" : "Not in stock";
                RatingLabel.Text = "Average rating: 10.0";
                if (product.AverageRating != null)
                {
                    RatingLabel.Text = product.AverageRating.ToString();
                }
            }

        }

        private async void AddToBasketButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Pie added to your basket!", "Done");
        }
    }
}