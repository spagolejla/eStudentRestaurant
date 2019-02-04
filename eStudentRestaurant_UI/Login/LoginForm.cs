using eStudentRestaurant_API.Models;
using eStudentRestaurant_UI.Main;
using eStudentRestaurant_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudentRestaurant_UI.Login
{
    public partial class LoginForm : Form
    {
        private WebAPIHelper employeesService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.EmployeesRoutes);


        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login()
        {

            HttpResponseMessage response = employeesService.GetActionResponse("GetEmployeeByUsername", usernameInput.Text);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound || usernameInput.Text == "")
                MessageBox.Show("Username not found or is empty!");

            else if (response.IsSuccessStatusCode)
            {
                Employee e = response.Content.ReadAsAsync<Employee>().Result;

                if (UIHelper.GenerateHash(e.PasswordSalt, passwordInput.Text) == e.PaswordHash)
                {
                    this.DialogResult = DialogResult.OK;
                    Global.LoggedUser = e;
                    this.Close();

               
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                    passwordInput.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " Message - " + response.ReasonPhrase);
            }



        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
