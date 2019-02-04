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

namespace eStudentRestaurant_UI.Employees
{
    public partial class PasswordChangeForm : ChildDialogForm
    {
        private WebAPIHelper employeesServices = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.EmployeesRoutes);
        Employee emp = Global.LoggedUser;

        public PasswordChangeForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void PasswordChangeButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                emp.PasswordSalt = UIHelper.GenerateSalt();
                emp.PaswordHash = UIHelper.GenerateHash(emp.PasswordSalt, NewPasswordInput.Text);

                HttpResponseMessage responseMessage = employeesServices.PutResponse(emp.EmployeeID, emp);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.msg_succ);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Error code: " + responseMessage.StatusCode + " Message: " + responseMessage.ReasonPhrase);
                }
            }
        }


        #region Validating
        private void OldPasswordInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(OldPasswordInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(OldPasswordInput, Messages.Required_Error);
            }
          
           
            else if (UIHelper.GenerateHash(emp.PasswordSalt, OldPasswordInput.Text) != emp.PaswordHash)
            {

                e.Cancel = true;
                errorProvider.SetError(OldPasswordInput,"Old password is incorrcet!");

            }
            else
                errorProvider.SetError(OldPasswordInput, null);
        }

        private void NewPasswordInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(NewPasswordInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(NewPasswordInput, Messages.Required_Error);
            }
            else if (NewPasswordInput.TextLength < 6 || !NewPasswordInput.Text.Any(char.IsDigit) || !NewPasswordInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(NewPasswordInput, Messages.pass_err);
            }
            else
                errorProvider.SetError(NewPasswordInput, null);
        }
        #endregion

       
    }
}
