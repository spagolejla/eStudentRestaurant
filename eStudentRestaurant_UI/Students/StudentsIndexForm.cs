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

namespace eStudentRestaurant_UI.Students
{
    public partial class StudentsIndexForm : ChildForm
    {
        private WebAPIHelper studentsServices = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.StudentsRoutes);


        public StudentsIndexForm()
        {
            InitializeComponent();
            StudentsDataGrid.AutoGenerateColumns = false;
        }

        private void BindGrid()
        {
            HttpResponseMessage response = studentsServices.GetActionResponse("GetStudentsByName", SearchStudentsInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Student_Result> employees = response.Content.ReadAsAsync<List<Student_Result>>().Result;
                StudentsDataGrid.DataSource = employees;
                StudentsDataGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void StudentsIndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void SearchStudentsButton_Click(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            StudentAddForm frm = new StudentAddForm();
            frm.ShowDialog();
            BindGrid();
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentsDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error! You didnt select an employee to edit!");
            }
            else
            {
                StudentEditForm frm = new StudentEditForm(Convert.ToInt32(StudentsDataGrid.SelectedRows[0].Cells[0].Value));

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

            }
            BindGrid();
        }
    }
}
