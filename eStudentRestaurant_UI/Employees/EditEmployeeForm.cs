using eStudentRestaurant_API.Models;
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
    public partial class EditEmployeeForm : Form
    {
        WebAPIHelper employeesService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAdress"], Global.EmployeesRoutes);
        WebAPIHelper citiesService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAdress"], Global.CitiesRoutes);

        private Employee employee { get; set; }

        public EditEmployeeForm(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = employeesService.GetResponse( id.ToString());

            if (response.StatusCode==System.Net.HttpStatusCode.NotFound)
            {
                employee = null;
            }
            else
            {
                employee = response.Content.ReadAsAsync<Employee>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            FirstNameInput.Text = employee.FirstName;
            LastNameInput.Text = employee.LastName;
            JmbgInput.Text = employee.JMBG;
            
            AddressInput.Text = employee.Address_;
            PhoneInput.Text = employee.Phone;
            UsernameInput.Text = employee.Username;
            ActiveCheckBox.Checked = employee.Active;
            BirthDatePicker.Value = employee.BirthDate;
            EmployDatePicker.Value = employee.EmploymentDate;

        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            #region GetCities
            HttpResponseMessage responseCities = citiesService.GetResponse();
            List<City> cities = new List<City>();
            if (responseCities.IsSuccessStatusCode)
            {
                cities = responseCities.Content.ReadAsAsync<List<City>>().Result;
            }
            List<ComboItem> comboItems = new List<ComboItem>();

            foreach (City item in cities)
            {
                comboItems.Add(new ComboItem { ID = item.CityID, Text = item.Name });
            }

            CityComboBox.DataSource = comboItems;
            #endregion

            if (responseCities.IsSuccessStatusCode )
            {
               

                ComboItem CityComboItem = new ComboItem();
                CityComboItem.ID = (int)employee.CityID;
                CityComboItem.Text = employee.City.Name;

             
                CityComboBox.SelectedIndex = CityComboBox.FindString(employee.City.Name);





            }
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (employee != null)
                {
                    employee.FirstName = FirstNameInput.Text;
                    employee.LastName = LastNameInput.Text;
                    employee.JMBG = JmbgInput.Text;
                    employee.BirthDate = BirthDatePicker.Value;
                    employee.EmploymentDate = EmployDatePicker.Value;

                    employee.Address_ = AddressInput.Text;
                    employee.Phone = PhoneInput.Text;
                    employee.Username = UsernameInput.Text;

                    if (PasswordInput.Text != String.Empty)
                    {
                        employee.PasswordSalt = UIHelper.GenerateSalt();
                        employee.PaswordHash = UIHelper.GenerateHash(employee.PasswordSalt, PasswordInput.Text);
                    }

                    employee.Active = ActiveCheckBox.Checked;

                    employee.CityID = (int)(CityComboBox.SelectedValue);
                    

                    HttpResponseMessage httpResponseMessage = employeesService.PutResponse(employee.EmployeeID, employee);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.msg_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Code" +
                        httpResponseMessage.StatusCode + " : Message - " + httpResponseMessage.ReasonPhrase);
                    }
                }
            }
        }

        #region validating

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

        private void JmbgInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(JmbgInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(JmbgInput, Messages.Required_Error);
            }
            else if (JmbgInput.TextLength != 13 || JmbgInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(JmbgInput, Messages.jmbg_err);
            }

            else
            {
                errorProvider.SetError(JmbgInput, "");
            }
        }



        private void AddressInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(AddressInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(AddressInput, Messages.Required_Error);
            }
            else if (AddressInput.TextLength > 100)
            {
                e.Cancel = true;
                errorProvider.SetError(AddressInput, Messages.overflow_err);
            }
            else
            {
                errorProvider.SetError(AddressInput, "");
            }
        }

        private void UsernameInput_Validating(object sender, CancelEventArgs e)
        {
            HttpResponseMessage res = employeesService.GetActionResponse("UsernameExist", UsernameInput.Text);

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
                Employee emp = res.Content.ReadAsAsync<Employee>().Result;
                if (emp.EmployeeID == employee.EmployeeID)
                {
                    errorProvider.SetError(UsernameInput, null);
                }
                else
                {
                e.Cancel = true;
                errorProvider.SetError(UsernameInput, Messages.username_ex_err);
                }
            }

            else
                errorProvider.SetError(UsernameInput, null);



        }

        private void PasswordInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordInput.Text))
            {
                errorProvider.SetError(PasswordInput, null);
            }
            else { 
            if (PasswordInput.TextLength < 6 || !PasswordInput.Text.Any(char.IsDigit) || !PasswordInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(PasswordInput, Messages.pass_err);
            }
            else
                errorProvider.SetError(PasswordInput, null);
            }

        }

        private void CityComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(CityComboBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(CityComboBox, Messages.Required_Error);
            }
            else
                errorProvider.SetError(CityComboBox, null);
        }

 private void BirthDatePicker_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(BirthDatePicker.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(BirthDatePicker, Messages.Required_Error);
            }
            else
                errorProvider.SetError(BirthDatePicker, null);
        }

        private void EmployDatePicker_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(EmployDatePicker.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(EmployDatePicker, Messages.Required_Error);
            }
            else
                errorProvider.SetError(EmployDatePicker, null);
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

       
    }
}
