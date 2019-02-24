using eStudentRestaurant_PCL.Model;
using eStudentRestaurant_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eStudentRestaurant_Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClientRegistration : ContentPage
	{
        private WebAPIHelper clientsService = new WebAPIHelper("http://172.21.184.193/", "api/Clients");

        public ClientRegistration ()
		{
			InitializeComponent ();
		}

        private void ClientRegBtn_Clicked(object sender, EventArgs e)
        {
            Client client = new Client();

            client.FirstName = firstNameInput.Text;
            client.LastName = lastNameInput.Text;
            client.OrganizationName = organizationInput.Text;
            client.Phone = phoneInput.Text;
            client.Active = true;
            client.Username = usernameInput.Text;
            client.PasswordSalt = UIHelper.GenerateSalt();
            client.PaswordHash = UIHelper.GenerateHash(client.PasswordSalt, passwordInput.Text);

            try
            {
                clientsService.PostResponse(client);
                DisplayAlert("Success!", "Registration has successfully passed", "OK");


            }
            catch (AggregateException ex)
            {

                DisplayAlert("Error!", ex.InnerException.Message, "OK");

            }


            /* try
             {
                 HttpResponseMessage response = clientsService.GetActionResponse("GetClientByUsername", "mirna");

                 if (response.IsSuccessStatusCode)
                 {

                 }
             }
             catch (AggregateException ex)
             {

                 throw;
             }*/





        }
    }
}