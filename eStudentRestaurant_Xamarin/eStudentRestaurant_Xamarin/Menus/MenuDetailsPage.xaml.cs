using eStudentRestaurant_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eStudentRestaurant_PCL.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menu = eStudentRestaurant_PCL.Model.Menu;
using System.Net.Http;
using Newtonsoft.Json;

namespace eStudentRestaurant_Xamarin.Menus
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuDetailsPage : ContentPage
	{
        private WebAPIHelper menusService = new WebAPIHelper("http://172.21.184.193/", "api/Menus");

        Menu menu;

        public MenuDetailsPage (int id)
		{
			InitializeComponent ();
            BindData(id);
		}

        private void BindData(int id)
        {
            HttpResponseMessage response = menusService.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                menu = JsonConvert.DeserializeObject<Menu>(jsonObject.Result);

                MenuNameLabel.Text = menu.Name_;
                PriceLabel.Text = menu.Price.ToString() + " KM";
                MenuDescriptionLabel.Text = menu.Description;
               
            }

        }

        private void AddToBasketButton_Clicked(object sender, EventArgs e)
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
            foreach (var item in Global.ActiveOrder.OrderMenu)
            {
                if (item.MenuID == menu.MenuID)
                {
                    item.Quantity += Convert.ToInt32(QuantityInput.Text);
                    Global.ActiveOrder.TotalPrice += menu.Price * Convert.ToInt32(QuantityInput.Text);
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                OrderMenu item = new OrderMenu();
                item.MenuID = menu.MenuID;
                item.Quantity = Convert.ToInt32(QuantityInput.Text);
                item.Menu = menu;
               
                Global.ActiveOrder.TotalPrice += menu.Price * Convert.ToInt32(QuantityInput.Text);

                Global.ActiveOrder.OrderMenu.Add(item);

            }


            DisplayAlert("Success!", "Menu added to your basket!", "Done");
            this.Navigation.PushAsync(new Orders.ActiveOrder());

            
        }
    }
    }
