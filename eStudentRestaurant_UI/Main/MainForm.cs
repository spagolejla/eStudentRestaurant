﻿using eStudentRestaurant_UI.Clients;
using eStudentRestaurant_UI.Employees;
using eStudentRestaurant_UI.Home;
using eStudentRestaurant_UI.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudentRestaurant_UI.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                   
                    frm.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ToHomeButton_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["HomeForm"] as HomeForm) != null)
            {
                //Form is already open
            }
            else
            {
                foreach (Form fr in this.MdiChildren)
                {

                    fr.Dispose();
                    fr.Close();

                }

                HomeForm frm = new HomeForm();
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }
            
        }

        private void ToEmployeesButton_Click(object sender, EventArgs e)
        {
            
            if ((Application.OpenForms["EmployeesIndexForm"] as EmployeesIndexForm) != null)
            {
                
            }
            else
            {
               
                foreach (Form fr in this.MdiChildren)
                {
                  
                        fr.Dispose();
                        fr.Close();
                    
                }
                EmployeesIndexForm frm = new EmployeesIndexForm();
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }
        }

        private void ToStudentButton_Click(object sender, EventArgs e)
        {

            if ((Application.OpenForms["StudentsIndexForm"] as StudentsIndexForm) != null)
            {

            }
            else
            {

                foreach (Form fr in this.MdiChildren)
                {

                    fr.Dispose();
                    fr.Close();

                }
                StudentsIndexForm frm = new StudentsIndexForm();
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }
        }

        private void ToClientsButton_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["ClientsIndexForm"] as ClientsIndexForm) != null)
            {

            }
            else
            {

                foreach (Form fr in this.MdiChildren)
                {

                    fr.Dispose();
                    fr.Close();

                }
                ClientsIndexForm frm = new ClientsIndexForm();
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }

        }
    }
}