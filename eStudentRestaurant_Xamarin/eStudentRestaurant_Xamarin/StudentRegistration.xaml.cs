using eStudentRestaurant_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using eStudentRestaurant_PCL.Model;

namespace eStudentRestaurant_Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentRegistration : ContentPage
	{
        private WebAPIHelper studentsService = new WebAPIHelper("http://172.21.184.193/", "api/Students");

        public StudentRegistration ()
		{
			InitializeComponent ();
		}

        private void StudentRegBtn_Clicked(object sender, EventArgs e)
        {
            Student student = new Student();

            student.FirstName = firstNameInput.Text;
            student.LastName = lastNameInput.Text;
            student.JMBG = jmbgInput.Text;
            student.CityID = Convert.ToInt32(cityInput.Text);
            student.BirthDate = Convert.ToDateTime(birthdayInput.Text);
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
                DisplayAlert("Error!", ex.Message , "OK");
            }


        }

    }
}