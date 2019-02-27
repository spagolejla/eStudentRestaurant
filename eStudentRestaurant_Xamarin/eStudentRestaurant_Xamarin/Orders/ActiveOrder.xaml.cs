using eStudentRestaurant_PCL.Util;
using eStudentRestaurant_Xamarin.Converters;
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
	public partial class ActiveOrder : ContentPage
	{
        private WebAPIHelper ordersService = new WebAPIHelper("http://172.21.184.193/", "api/Orders");
    
        public ActiveOrder ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            if (Global.ActiveOrder != null)
            {
                OrderDateLabel.Text = Global.ActiveOrder.OrderDate.ToString();
                TotalPriceLabel.Text = "Total price: " + Global.ActiveOrder.TotalPrice.ToString()+ " KM";
                List<OrderMenuItem> orderMenusItems = new List<OrderMenuItem>();
                if (Global.ActiveOrder.OrderItem.Count != 0)
                {
                    foreach (var item in Global.ActiveOrder.OrderItem)
                    {
                        OrderMenuItem omn = new OrderMenuItem()
                        {
                            Name = item.Product.Name_,
                            Price = item.Product.Price.ToString(),
                            Quantity = item.Quantity.ToString()
                        };

                        orderMenusItems.Add(omn);
                    }
                }

                if (Global.ActiveOrder.OrderMenu.Count != 0)
                {
                    foreach (var item in Global.ActiveOrder.OrderMenu)
                    {
                        OrderMenuItem omn = new OrderMenuItem()
                        {
                            Name = item.Menu.Name_,
                            Price = item.Menu.Price.ToString(),
                            Quantity = item.Quantity.ToString()
                        };

                        orderMenusItems.Add(omn);
                    }
                }

                OrderMenusItems.ItemsSource = orderMenusItems;
            }
            else
            {
                PageTitleLabel.Text = "Currently no active order";
                CancelButton.IsEnabled = false;
                MoreItemsButton.IsEnabled = false;
            }
          
            base.OnAppearing();
        }

        private void MoreItemsButton_Clicked( object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new StudentMainPage());
        }

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            Global.ActiveOrder = null;
            DisplayAlert("Info", "Order has been canceled!", "OK");
            this.Navigation.PushAsync(new StudentMainPage());

        }

        private void AddOrderButton_Clicked(object sender, EventArgs e)
        {
            if (Global.ActiveOrder == null)
            {
                this.Navigation.PushAsync(new StudentMainPage());
            }
            else
            {
                HttpResponseMessage response = ordersService.PostResponse(Global.ActiveOrder);
                DisplayAlert("Info",response.StatusCode.ToString(),"OK");
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Success!","Order successfully added", "OK");

                    Global.ActiveOrder = null;
                    this.Navigation.PushAsync(new StudentMainPage());
                }
            }
        }
    }
}