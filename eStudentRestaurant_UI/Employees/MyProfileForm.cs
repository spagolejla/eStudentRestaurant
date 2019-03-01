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
    public partial class MyProfileForm : ChildForm
    {
        private WebAPIHelper employeesServices = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.EmployeesRoutes);
        Employee employee = new Employee();

        public MyProfileForm()
        {
            InitializeComponent();
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage responseMessage = employeesServices.GetResponse(Global.LoggedUser.EmployeeID.ToString());
            if (responseMessage.IsSuccessStatusCode)
            {
                employee = responseMessage.Content.ReadAsAsync<Employee>().Result;
               
            }
            else
            {
                MessageBox.Show("Error: " + responseMessage.ReasonPhrase);
            }
            FillForm();
          
          
        }

        private void FillForm()
        {
            FirstNameLabel.Text = employee.FirstName;
            LastNameLabel.Text = employee.LastName;
            JmbgLabel.Text = employee.JMBG;
            BirthDateLabel.Text = employee.BirthDate.ToString("MM/dd/yyyy");
            AddressLabel.Text = employee.Address_;
            CityNameLabel.Text = employee.City.Name;
            EmployDate.Text = employee.EmploymentDate.ToShortDateString();
            PhoneLabel.Text = employee.Phone;
            UsernameLabel.Text = employee.Username;
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {

            EditEmployeeForm frm = new EditEmployeeForm(employee.EmployeeID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                HttpResponseMessage responseMessage = employeesServices.GetResponse(employee.EmployeeID.ToString());
                if (responseMessage.IsSuccessStatusCode)
                {
                    employee = responseMessage.Content.ReadAsAsync<Employee>().Result;
                    Global.LoggedUser = employee;
                }
                else
                {
                    MessageBox.Show("Error: " + responseMessage.ReasonPhrase);
                }
            }

        }
    }
}
