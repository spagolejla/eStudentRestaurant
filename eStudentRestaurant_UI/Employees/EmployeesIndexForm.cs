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
    public partial class EmployeesIndexForm : Form
    {
        private WebAPIHelper employeesServices = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.EmployeesRoutes);

        public EmployeesIndexForm()
        {
            InitializeComponent();
            EmployeesDataGrid.AutoGenerateColumns = false;

        }



        private void BindGrid()
        {
            HttpResponseMessage response = employeesServices.GetActionResponse("GetEmployeesByName", SearchEmpoyeesInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Employe_Result> employees = response.Content.ReadAsAsync<List<Employe_Result>>().Result;
                EmployeesDataGrid.DataSource = employees;
                EmployeesDataGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void EmployeesIndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void SearchEmployeesButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm frm = new AddEmployeeForm();
            frm.ShowDialog();
            BindGrid();
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeesDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error! You didnt select an employee to edit!");
            }
            else
            {
                EditEmployeeForm frm = new EditEmployeeForm(Convert.ToInt32(EmployeesDataGrid.SelectedRows[0].Cells[0].Value));

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

            }
            BindGrid();
        }
    }
}
