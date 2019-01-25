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

namespace eStudentRestaurant_UI.Clients
{
    public partial class ClientAddForm : ChildDialogForm
    {
        private WebAPIHelper clientsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ClientsRoutes);

        public ClientAddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }




        #region validation
        private void FirstNameInput_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(FirstNameInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(FirstNameInput, Messages.Required_Error);
            }
            else if (FirstNameInput.TextLength > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(FirstNameInput, Messages.overflow_err);
            }
            else if (FirstNameInput.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(FirstNameInput, Messages.number_err);
            }
            else
            {
                errorProvider.SetError(FirstNameInput, "");
            }


        }

        private void LastNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LastNameInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(LastNameInput, Messages.Required_Error);
            }
            else if (LastNameInput.TextLength > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(LastNameInput, Messages.overflow_err);
            }
            else if (LastNameInput.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(LastNameInput, Messages.number_err);
            }
            else
            {
                errorProvider.SetError(LastNameInput, "");
            }
        }
        private void OrganizationNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(OrganizationNameInput.Text))
            {
                
                errorProvider.SetError(PasswordInput, null);
            }
            else if (OrganizationNameInput.TextLength > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(OrganizationNameInput, Messages.overflow_err);
            }
            else if (OrganizationNameInput.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(OrganizationNameInput, Messages.number_err);
            }
            else
            {
                errorProvider.SetError(OrganizationNameInput, "");
            }

        }

        private void UsernameInput_Validating(object sender, CancelEventArgs e)
        {
            HttpResponseMessage res = clientsService.GetActionResponse("UsernameExist", UsernameInput.Text);

            if (String.IsNullOrEmpty(UsernameInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(UsernameInput, Messages.Required_Error);
            }
            else if (UsernameInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(UsernameInput, Messages.Error);
            }
            else if (UsernameInput.TextLength > 100)
            {
                e.Cancel = true;
                errorProvider.SetError(UsernameInput, Messages.overflow_err);
            }

            else if (res.StatusCode != System.Net.HttpStatusCode.NotFound)
            {
               
                
                    e.Cancel = true;
                    errorProvider.SetError(UsernameInput, Messages.username_ex_err);
                

            }

            else
                errorProvider.SetError(UsernameInput, null);



        }

        private void PasswordInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordInput.Text))
            {
                errorProvider.SetError(PasswordInput, Messages.Required_Error);
            }
            else
            {
                if (PasswordInput.TextLength < 6 || !PasswordInput.Text.Any(char.IsDigit) || !PasswordInput.Text.Any(char.IsLetter))
                {
                    e.Cancel = true;
                    errorProvider.SetError(PasswordInput, Messages.pass_err);
                }
                else
                    errorProvider.SetError(PasswordInput, null);
            }

        }

        private void PhoneInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PhoneInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(PhoneInput, Messages.Required_Error);
            }
            else
                errorProvider.SetError(PhoneInput, null);
        }

        #endregion

        private void SaveClientButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Client client = new Client();

                client.FirstName = FirstNameInput.Text;
                client.LastName = LastNameInput.Text;
                if (OrganizationNameInput.Text != String.Empty)
                {
                    client.OrganizationName = FirstNameInput.Text;

                }
                client.Phone = PhoneInput.Text;
                client.Username = UsernameInput.Text;
                client.PasswordSalt = UIHelper.GenerateSalt();
                client.PaswordHash = UIHelper.GenerateHash(client.PasswordSalt, PasswordInput.Text);
                client.Active = true;

                HttpResponseMessage resp = clientsService.PostResponse(client);

                if (resp.IsSuccessStatusCode)
                {
                    this.Close();
                    MessageBox.Show(Messages.msg_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {

                    MessageBox.Show("Error Code" +
                    resp.StatusCode + " : Message - " + resp.ReasonPhrase);
                }

            }
        }
    }
}
