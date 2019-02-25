using eStudentRestaurant_PCL.Model;
using eStudentRestaurant_PCL.Util;
using Newtonsoft.Json;
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
    public partial class Login : ContentPage
    {
        private WebAPIHelper studentsService = new WebAPIHelper("http://172.21.184.193/", "api/Students");
        private WebAPIHelper clientsService = new WebAPIHelper("http://172.21.184.193/", "api/Clients");

        public Login()
        {
            InitializeComponent();
        }
        private void StudentRegistrationButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new StudentRegistration());
        }

        private void ClientRegistrationButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ClientRegistration());
        }

        private void SignInButton_Clicked(object sender, EventArgs e)
        {

            try
            {
                HttpResponseMessage studentResponse = studentsService.GetActionResponse("GetStudentByUsername", usernameInput.Text);

                if (studentResponse.IsSuccessStatusCode)
                {
                    var jsonResult = studentResponse.Content.ReadAsStringAsync();
                    Student s = JsonConvert.DeserializeObject<Student>(jsonResult.Result);
                    if (s.PaswordHash == UIHelper.GenerateHash(s.PasswordSalt, passwordInput.Text))
                    {
                        this.Navigation.PushModalAsync(new Navigations.StudentNavigation());
                    }
                    else
                    {
                        DisplayAlert("Error!", " Wrong password!", "OK");
                    }
                }
                else if (studentResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    HttpResponseMessage clientResponse = clientsService.GetActionResponse("GetClientByUsername", usernameInput.Text);
                    if (clientResponse.IsSuccessStatusCode)
                    {
                        var jsonResult = clientResponse.Content.ReadAsStringAsync();
                        Client c = JsonConvert.DeserializeObject<Client>(jsonResult.Result);
                        if (c.PaswordHash == UIHelper.GenerateHash(c.PasswordSalt, passwordInput.Text))
                        {
                            this.Navigation.PushModalAsync(new Navigations.ClientNavigation());

                        }
                        else
                        {
                            DisplayAlert("Error!", "Wrong password!", "OK");
                        }
                    }
                    else
                    {
                        DisplayAlert("Error!", "Wrong input data!", "OK");
                    }


                }
                else
                {
                    DisplayAlert("Error!", "Wrong input data!", "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error!", ex.Message, "OK");

            }



        }

    }
}