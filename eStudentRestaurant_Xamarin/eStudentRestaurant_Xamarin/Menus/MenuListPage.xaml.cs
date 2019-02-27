using eStudentRestaurant_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using eStudentRestaurant_PCL.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menu = eStudentRestaurant_PCL.Model.Menu;

namespace eStudentRestaurant_Xamarin.Menus
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuListPage : ContentPage
	{
        private WebAPIHelper menusService = new WebAPIHelper("http://172.21.184.193/", "api/Menus");

        public MenuListPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            HttpResponseMessage response = menusService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<eStudentRestaurant_PCL.Model.Menu> menus = JsonConvert.DeserializeObject<List<eStudentRestaurant_PCL.Model.Menu>>(jsonObject.Result);

                MenusList.ItemsSource = menus;

               
            }

            base.OnAppearing();
        }

        public void MenusList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
              this.Navigation.PushAsync(new Menus.MenuDetailsPage((e.Item as Menu).MenuID));
            }
        }
    }
}