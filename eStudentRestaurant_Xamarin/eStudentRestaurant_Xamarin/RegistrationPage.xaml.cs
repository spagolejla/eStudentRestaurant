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
    public partial class RegistrationPage : ContentPage
    {
        private WebAPIHelper clientsService = new WebAPIHelper("http://172.21.184.193/", "api/Clients");
        private WebAPIHelper studentsService = new WebAPIHelper("http://172.21.184.193/", "api/Students");
        private WebAPIHelper citiesService = new WebAPIHelper("http://172.21.184.193/", "api/Cities");



        bool isStudent = true;
        bool isClient = false;
        public RegistrationPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            try
            {
                HttpResponseMessage response = citiesService.GetResponse();

                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();
                    List<City> cities = JsonConvert.DeserializeObject<List<City>>(jsonObject.Result);


                    CityPicker.ItemsSource = cities;
                    CityPicker.ItemDisplayBinding = new Binding("Name");

                }



                base.OnAppearing();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error!", ex.Message, "OK");
            }
        }

        private void StudentRegBtn_Clicked(object sender, EventArgs e)
        {
            isStudent = true;
            isClient = false;
            ClientRegBtn.IsEnabled = true;
            StudentRegBtn.IsEnabled = false;
            PageTitleLabel.Text = "Student Registration";
            StudentView.IsVisible = true;
            ClientView.IsVisible = false;

        }

        private void ClientRegBtn_Clicked(object sender, EventArgs e)
        {
            isStudent = false;
            isClient = true;
            StudentRegBtn.IsEnabled = true;
            ClientRegBtn.IsEnabled = false;
            PageTitleLabel.Text = "Client Registration";


            StudentView.IsVisible = false;
            ClientView.IsVisible = true;
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            #region Validating
            bool validate = false;
            if (!firstNameInput_Validating())
            {
              validate = false;

            }
            else if (!lastNameInput_Validating())
            {
                validate = false;

            }
            else if (!phoneInput_Validating())
            {
                validate = false;

            }
            else if (!CityPicker_Validating())
            {
                validate = false;

            }
            else if (!usernameInput_Validating())
            {
                validate = false;

            }
            else if (!passwordInput_Validating())
            {
                validate = false;

            }
            else if (isStudent)
            {
                if (!jmbgInput_Validating() || !addressInput_Validating())
                {
                    validate = false;

                }
                else
                {
                    validate = true;
                }
            }
            else if (isClient)
            {
                if (!organizationNameInput_Validating()
)
                {
                    validate = false;

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
                if (isStudent)
                {
                    Student student = new Student();

                    student.FirstName = firstNameInput.Text;
                    student.LastName = lastNameInput.Text;
                    student.JMBG = jmbgInput.Text;
                    student.CityID = (CityPicker.SelectedItem as City).CityID; ;
                    student.BirthDate = BirthdayPicker.Date;
                    student.Address_ = addressInput.Text;
                    student.Phone = phoneInput.Text;
                    student.Active = true;
                    student.Username = usernameInput.Text;
                    student.PasswordSalt = UIHelper.GenerateSalt();
                    student.PaswordHash = UIHelper.GenerateHash(student.PasswordSalt, passwordInput.Text);

                    try
                    {
                        studentsService.PostResponse(student);
                        DisplayAlert("Success!", "Registration has successfully passed", "OK");

                    }
                    catch (Exception ex)
                    {
                        DisplayAlert("Error!", ex.Message, "OK");
                    }
                }

                else
                {
                    Client client = new Client();

                    client.FirstName = firstNameInput.Text;
                    client.LastName = lastNameInput.Text;
                    client.OrganizationName = organizationNameInput.Text;
                    client.Phone = phoneInput.Text;
                    client.Active = true;
                    client.Username = usernameInput.Text;
                    client.PasswordSalt = UIHelper.GenerateSalt();
                    client.PaswordHash = UIHelper.GenerateHash(client.PasswordSalt, passwordInput.Text);
                    client.Points = 0;
                    client.CityID = (CityPicker.SelectedItem as City).CityID;
                    try
                    {
                        clientsService.PostResponse(client);
                        DisplayAlert("Success!", "Registration has successfully passed", "OK");


                    }
                    catch (AggregateException ex)
                    {

                        DisplayAlert("Error!", ex.InnerException.Message, "OK");

                    }
                }
            }

        }

        private bool firstNameInput_Validating()
        {


            if (firstNameInput.Text == null)
            {

                DisplayAlert("Error!", "First name is required!", "OK");
                return false;

            }
            else if (!firstNameInput.Text.Any(char.IsLetter))
            {
                DisplayAlert("Error!", "First name - only letters are allowed!", "OK");
                return false;

            }
            else if (firstNameInput.Text.Length > 50)
            {
                DisplayAlert("Error!", "Size of input text is to large!", "OK");
                return false;

            }



            else
            {

                return true;

            }
        }
        private bool lastNameInput_Validating()
        {


            if (lastNameInput.Text == null)
            {

                DisplayAlert("Error!", "Last name is required!", "OK");
                return false;

            }
            else if (!lastNameInput.Text.Any(char.IsLetter))
            {
                DisplayAlert("Error!", "Last name - only letters are allowed!", "OK");
                return false;

            }
            else if (lastNameInput.Text.Length > 50)
            {
                DisplayAlert("Error!", "Size of input text is to large!", "OK");
                return false;

            }



            else
            {

                return true;

            }
        }
        private bool phoneInput_Validating()
        {


            if (phoneInput.Text == null)
            {

                DisplayAlert("Error!", "Phone is required!", "OK");
                return false;

            }
            else if (!phoneInput.Text.Any(char.IsDigit))
            {
                DisplayAlert("Error!", "Phone input - Only digit are allowed!", "OK");
                return false;

            }
            else if (phoneInput.Text.Length > 50)
            {
                DisplayAlert("Error!", "Size of input text is to large!", "OK");
                return false;

            }
            else
            {

                return true;

            }
        }
        private bool CityPicker_Validating()
        {
            if (CityPicker.SelectedItem == null)
            {
                DisplayAlert("Error!", "You must select reservation type !", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool passwordInput_Validating()
        {
            if (passwordInput.Text == null)
            {

                DisplayAlert("Error!", "New password is required!", "OK");
                return false;

            }
            else if (passwordInput.Text.Length < 6)
            {

                DisplayAlert("Error!", "Password must be at least 6 characters!", "OK");
                return false;
            }


            else if (passwordInput.Text.Length > 50)
            {
                DisplayAlert("Error!", "Size of input text is to large!", "OK");
                return false;
            }
            else
            {
                return true;

            }
        }
        private bool jmbgInput_Validating()
        {

            if (jmbgInput.Text == null)
            {

                DisplayAlert("Error!", "Jmbg name is required!", "OK");
                return false;

            }
            else if (!jmbgInput.Text.Any(char.IsDigit))
            {
                DisplayAlert("Error!", "Jmbg- only numbers are allowed!", "OK");
                return false;

            }
            else if (jmbgInput.Text.Length != 13)
            {
                DisplayAlert("Error!", "Length of JMBG must be 13!", "OK");
                return false;

            }

            else
            {

                return true;

            }
        }
        private bool addressInput_Validating()
        {
            if (addressInput.Text == null)
            {

                DisplayAlert("Error!", "Address is required!", "OK");
                return false;

            }

            else if (addressInput.Text.Length > 50)
            {
                DisplayAlert("Error!", "Address - to much characters!", "OK");
                return false;

            }

            else
            {

                return true;

            }
        }

        private bool organizationNameInput_Validating()
        {
            if (organizationNameInput.Text == null)
            {

                DisplayAlert("Error!", "Organization name is required!", "OK");
                return false;

            }

            else if (organizationNameInput.Text.Length > 50)
            {
                DisplayAlert("Error!", "Organization  - to much characters!", "OK");
                return false;

            }

            else
            {

                return true;

            }
        }

        private bool usernameInput_Validating()
        {
            HttpResponseMessage res = studentsService.GetActionResponse("UsernameExist", usernameInput.Text);

            if (usernameInput.Text == null)
            {
                DisplayAlert("Error!", "Username is required!", "OK");
                return false;
            }
            else if (usernameInput.Text.Length < 3)
            {
                DisplayAlert("Error!", "Username - min length is > 3!", "OK");
                return false;
            }
            else if (usernameInput.Text.Length > 50)
            {
                DisplayAlert("Error!", "Username - max length is <50!", "OK");
                return false;
            }

            else if (res.StatusCode != System.Net.HttpStatusCode.NotFound)
            {

                DisplayAlert("Error!", "Username is already exist!", "OK");
                return false;
            }

            else
                return true;
        }


    }
}