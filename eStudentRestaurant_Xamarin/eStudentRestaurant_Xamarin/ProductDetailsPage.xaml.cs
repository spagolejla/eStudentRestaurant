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

        private  void AddToBasketButton_OnClicked(object sender, EventArgs e)
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
    }
