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
        private WebAPIHelper ratingsService = new WebAPIHelper("http://172.21.184.193/", "api/Ratings");


        Product product;
        Rating rate;
        bool isProductRated;
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

                HttpResponseMessage responseRate = ratingsService
                      .GetActionResponseTwoParam("GetRatingByProductIdAndStudentId", product.ProductID, Global.loggedStudent.StudentID);
                HttpResponseMessage responseAverageRating = ratingsService.GetActionResponse("GetAverageRating", product.ProductID.ToString());

                HttpResponseMessage responseRecommendedProducts = productsService.GetActionResponse("RecommendedProducts",product.ProductID.ToString());

                if (responseRecommendedProducts.IsSuccessStatusCode)
                {
                    var recomenndedObjectsJson = responseRecommendedProducts.Content.ReadAsStringAsync();
                    List<Product> recommendedProducts = JsonConvert.DeserializeObject<List<Product>>(recomenndedObjectsJson.Result);

                    RecommendedProductList.ItemsSource = recommendedProducts;


                }
                else
                {
                    DisplayAlert("Error", "Error code: " + responseRecommendedProducts.StatusCode
                        + "Message: " + responseRecommendedProducts.ReasonPhrase, "OK");
                }
               

                if (responseAverageRating.IsSuccessStatusCode)
                {
                    var jsonObjectAverageRating = responseAverageRating.Content.ReadAsStringAsync();
                    product.AverageRating = JsonConvert.DeserializeObject<decimal?>(jsonObjectAverageRating.Result);

                    if (product.AverageRating != null)
                    {
                        RatingLabel.Text ="Average rating: " + product.AverageRating.ToString();
                    }
                }


                if (responseRate.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    isProductRated = false;
                    YourRatingLabel.Text = "Your rating: Not rated";
                    RatingLayout.IsVisible = true;

                }
                else if (responseRate.IsSuccessStatusCode)
                {
                    isProductRated = true;
                    var jsonObjectRate = responseRate.Content.ReadAsStringAsync();
                    rate = JsonConvert.DeserializeObject<Rating>(jsonObjectRate.Result);
                    if (rate != null)
                    {
                        YourRatingLabel.Text = "Your rating: " + rate.Rating1;

                    }
                }
                else
                {
                    DisplayAlert("Error", "Error code: " + responseRate.StatusCode
                         + "Message: " + responseRate.ReasonPhrase, "OK");
                }
            }

        }

        private void AddToBasketButton_OnClicked(object sender, EventArgs e)
        {
            #region Validating
            bool isValidate = false;
            if (QuantityInput.Text == null)
            {
                DisplayAlert("Error!", "Quantity is required!", "OK");

            }
            else if (!QuantityInput.Text.Any(char.IsDigit))
            {
                DisplayAlert("Error!", "Quantity input - Only digit are allowed!", "OK");


            }
            else if (QuantityInput.Text.Length > 2)
            {
                DisplayAlert("Error!", "Max length is 2!", "OK");


            }
            else if (Convert.ToInt32(QuantityInput.Text) <= 0 || Convert.ToInt32(QuantityInput.Text) > 10)
            {
                DisplayAlert("Error!", "Min quantity is 1 and max is 10", "OK");

            }
            else
            {

                isValidate = true;

            }
            #endregion

            if (isValidate)
            {
                if (Global.ActiveOrder == null)
                {
                    Global.ActiveOrder = new Order();
                    Global.ActiveOrder.OrderDate = DateTime.Now;
                    Global.ActiveOrder.OrderStatusID = 1;
                    Global.ActiveOrder.StudentID = Global.loggedStudent.StudentID;
                    Global.ActiveOrder.EmployeeID = 1;

                }
                bool exists = false;
                foreach (var item in Global.ActiveOrder.OrderItem)
                {
                    if (item.ProductID == product.ProductID)
                    {
                        item.Quantity += Convert.ToInt32(QuantityInput.Text);
                        Global.ActiveOrder.TotalPrice += product.Price * Convert.ToInt32(QuantityInput.Text);
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    OrderItem item = new OrderItem();
                    item.ProductID = product.ProductID;
                    item.Quantity = Convert.ToInt32(QuantityInput.Text);
                    item.Product = product;
                    item.Product.Picture = null;
                    Global.ActiveOrder.TotalPrice += product.Price * Convert.ToInt32(QuantityInput.Text);

                    Global.ActiveOrder.OrderItem.Add(item);

                }


                DisplayAlert("Success!", "Product added to your basket!", "Done");


                Page page = this.Navigation.NavigationStack.FirstOrDefault();

                this.Navigation.PushAsync(new Orders.ActiveOrder());

                this.Navigation.RemovePage(page);
            }


        }

        private void RateButton_Clicked(object sender, EventArgs e)
        {
            #region Validating
            bool isValidate = false;
            if (RateInput.Text == null)
            {
                DisplayAlert("Error!", "Rate is required!", "OK");

            }
            else if (!RateInput.Text.Any(char.IsDigit))
            {
                DisplayAlert("Error!", "Rate input - Only digit are allowed!", "OK");


            }
            else if (RateInput.Text.Length > 2)
            {
                DisplayAlert("Error!", "Max length is 2!", "OK");


            }
            else if (Convert.ToInt32(RateInput.Text) <= 0 || Convert.ToInt32(RateInput.Text) > 10)
            {
                DisplayAlert("Error!", "Allowed ratings are from 1 to 10", "OK");

            }
            else
            {

                isValidate = true;

            }
            #endregion


            if (isValidate)
            {
                rate = new Rating()
                {
                    ProductID = product.ProductID,
                    StudentID = Global.loggedStudent.StudentID,
                    Rating1 = Convert.ToInt32(RateInput.Text)
                };

                HttpResponseMessage responseMessage = ratingsService.PostResponse(rate);
                if (responseMessage.IsSuccessStatusCode)
                {
                    DisplayAlert("Success!", "You successfully rated this product!", "OK");
                    RatingLayout.IsVisible = false;
                }
                else
                {
                    DisplayAlert("Error!", "Message: "
                        + responseMessage.ReasonPhrase + "Error code: " + responseMessage.StatusCode, "OK");

                }

            }

        }

        private void RecommendedProductList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}
