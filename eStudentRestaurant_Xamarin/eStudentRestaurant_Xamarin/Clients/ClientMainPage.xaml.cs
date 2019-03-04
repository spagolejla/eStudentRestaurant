using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudentRestaurant_Xamarin.Clients
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClientMainPage : ContentPage
	{
		public ClientMainPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Clients.ReservationAddPage());

        }
    }
}