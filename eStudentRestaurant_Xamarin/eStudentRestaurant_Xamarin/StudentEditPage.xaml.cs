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
	public partial class StudentEditPage : ContentPage
	{
        private WebAPIHelper studentService = new WebAPIHelper("http://172.21.184.193/", "api/Students");

        public StudentEditPage ()
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
            phoneInput.Text = Global.loggedStudent.Phone;

        }

        private void StudentEditButton_Clicked(object sender, EventArgs e)
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

                if (Global.loggedStudent.PaswordHash != UIHelper.GenerateHash(Global.loggedStudent.PasswordSalt, passwordInputOld.Text.ToString()))
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
                Global.loggedStudent.Phone = phoneInput.Text;
                if (passwordInputNew.Text != null)
                {
                    Global.loggedStudent.PasswordSalt = UIHelper.GenerateSalt();
                    Global.loggedStudent.PaswordHash = UIHelper.GenerateHash(Global.loggedStudent.PasswordSalt, passwordInputNew.Text.ToString());
                }
              
                HttpResponseMessage responseMessage = studentService.PutResponse(Global.loggedStudent.StudentID, Global.loggedStudent);

                if (responseMessage.IsSuccessStatusCode)
                {
                    DisplayAlert("Success!", "Prodile edited successfully!", "OK");
                    this.Navigation.PushAsync(new StudentProfilePage());

                }
                else
                {
                    DisplayAlert("Error!", "Code: " + responseMessage.StatusCode + " Message: " + responseMessage.ReasonPhrase, "OK");

                }
            }

        }
    }
}