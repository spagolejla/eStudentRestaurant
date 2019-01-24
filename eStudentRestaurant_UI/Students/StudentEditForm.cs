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

namespace eStudentRestaurant_UI.Students
{
    public partial class StudentEditForm : Form
    {
        private WebAPIHelper citiesService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.CitiesRoutes);
        private WebAPIHelper studentService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.StudentsRoutes);

        private Student student { get; set; }

        public StudentEditForm(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = studentService.GetResponse(id.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                student = null;
            }
            else
            {
                student = response.Content.ReadAsAsync<Student>().Result;
                FillForm();
            }

        }

        private void FillForm()
        {
            FirstNameInput.Text = student.FirstName;
            LastNameInput.Text = student.LastName;
            JmbgInput.Text = student.JMBG;

            AddressInput.Text = student.Address_;
            PhoneInput.Text = student.Phone;
            UsernameInput.Text = student.Username;
            ActiveCheckBox.Checked = student.Active;
            BirthDatePicker.Value = student.BirthDate;


        }

        private void StudentEditForm_Load(object sender, EventArgs e)
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

            if (responseCities.IsSuccessStatusCode)
            {


                ComboItem CityComboItem = new ComboItem();
                CityComboItem.ID = (int)student.CityID;
                CityComboItem.Text = student.City.Name;


                CityComboBox.SelectedIndex = (int)(student.CityID - 1);




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
            HttpResponseMessage res = studentService.GetActionResponse("UsernameExist", UsernameInput.Text);

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
                Student std = res.Content.ReadAsAsync<Student>().Result;
                if (std.StudentID == student.StudentID)
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

        private void EditStudent_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (student != null)
                {
                    student.FirstName = FirstNameInput.Text;
                    student.LastName = LastNameInput.Text;
                    student.JMBG = JmbgInput.Text;
                    student.BirthDate = BirthDatePicker.Value;


                    student.Address_ = AddressInput.Text;
                    student.Phone = PhoneInput.Text;
                    student.Username = UsernameInput.Text;

                    if (PasswordInput.Text != String.Empty)
                    {
                        student.PasswordSalt = UIHelper.GenerateSalt();
                        student.PaswordHash = UIHelper.GenerateHash(student.PasswordSalt, PasswordInput.Text);
                    }

                    student.Active = ActiveCheckBox.Checked;

                    student.CityID = (int)(CityComboBox.SelectedValue);


                    HttpResponseMessage httpResponseMessage = studentService.PutResponse(student.StudentID, student);

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
    }
}
