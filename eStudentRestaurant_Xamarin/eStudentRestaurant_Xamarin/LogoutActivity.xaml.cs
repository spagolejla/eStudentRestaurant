using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudentRestaurant_Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogoutActivity : ContentPage
	{
		public LogoutActivity ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            Global.loggedStudent = null;
            Global.loggedClient = null;

            this.Navigation.PopModalAsync();
            this.Navigation.PushModalAsync(new Login());
            base.OnAppearing();
        }
    }
}