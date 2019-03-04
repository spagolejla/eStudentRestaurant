using eStudentRestaurant_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace eStudentRestaurant_Xamarin.Clients
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClientEditPage : ContentPage
	{
        private WebAPIHelper clientsService = new WebAPIHelper("http://172.21.184.193/", "api/Clients");

        public ClientEditPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        { 

            FillForm();
            base.OnAppearing();
        }

        private void FillForm()
        {
            phoneInput.Text = Global.loggedClient.Phone;
            
        }

        private void ClientEditButton_Clicked(object sender, EventArgs e)
        {
            bool validate = false;
            #region Validating
            if (phoneInput.Text == null)
            {

                DisplayAlert("Error!", "Phone is required!", "OK");

            }
            else if (!phoneInput.Text.Any(char.IsDigit))
            {
                DisplayAlert("Error!", "Phone input - Only digit are allowed!", "OK");
            }
            else if (phoneInput.Text.Length > 50)
            {
                DisplayAlert("Error!", "Size of input text is to large!", "OK");
            }
            else if (passwordInputOld.Text != null)
            {

                if (Global.loggedClient.PaswordHash != UIHelper.GenerateHash(Global.loggedClient.PasswordSalt, passwordInputOld.Text.ToString()))
                {
                    DisplayAlert("Error!", "Old password is incorrect", "OK");
                }
                else if (passwordInputNew.Text == null)
                {

                    DisplayAlert("Error!", "New password is required!", "OK");

                }
                else if (passwordInputNew.Text.Length < 6)
                {

                    DisplayAlert("Error!", "Password must be at least 6 characters!", "OK");

                }

                else if (passwordInputOld.Text.ToString().Equals(passwordInputNew.Text.ToString()))
                {
                    DisplayAlert("Error!", "New password is same as old!", "OK");
                }
               
                else if (passwordInputNew.Text.Length > 50)
                {
                DisplayAlert("Error!", "Size of input text is to large!", "OK");

                }
                else 
                {

                    validate = true;

                }
            }

            else
            {

                validate = true;

            }

            #endregion

            if (validate)
            {
                Global.loggedClient.Phone = phoneInput.Text;
                if (passwordInputNew.Text != null)
                {
                    Global.loggedClient.PasswordSalt = UIHelper.GenerateSalt();
                    Global.loggedClient.PaswordHash = UIHelper.GenerateHash(Global.loggedClient.PasswordSalt, passwordInputNew.Text.ToString());
                }
               
                HttpResponseMessage responseMessage = clientsService.PutResponse(Global.loggedClient.ClientID, Global.loggedClient);

                if (responseMessage.IsSuccessStatusCode)
                {
                    DisplayAlert("Success!", "Profile edited successfully!", "OK");
                    this.Navigation.PushAsync(new Clients.ClientProfilePage());

                }
                else
                {
                    DisplayAlert("Error!", "Code: " + responseMessage.StatusCode + " Message: " + responseMessage.ReasonPhrase, "OK");

                }
            }

        }
    }
}