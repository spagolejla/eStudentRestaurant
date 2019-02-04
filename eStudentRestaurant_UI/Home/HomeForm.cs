using eStudentRestaurant_UI.Clients;
using eStudentRestaurant_UI.Employees;
using eStudentRestaurant_UI.Main;
using eStudentRestaurant_UI.Menus;
using eStudentRestaurant_UI.Orders;
using eStudentRestaurant_UI.Products;
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

namespace eStudentRestaurant_UI.Home
{
    public partial class HomeForm : ChildForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void ToEmployeesButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            this.Dispose();

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
            this.Dispose();

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

        private void ToProductButton_Click(object sender, EventArgs e)
        {
            this.Dispose();

            if ((Application.OpenForms["ProductsIndexForm"] as ProductsIndexForm) != null)
            {

            }
            else
            {

                foreach (Form fr in this.MdiChildren)
                {

                    fr.Dispose();
                    fr.Close();

                }
                ProductsIndexForm frm = new ProductsIndexForm();
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }

        }

        private void ToOrdersButton_Click(object sender, EventArgs e)
        {
            this.Dispose();

            if ((Application.OpenForms["OrdersIndexForm"] as OrdersIndexForm) != null)
            {

            }
            else
            {

                foreach (Form fr in this.MdiChildren)
                {

                    fr.Dispose();
                    fr.Close();

                }
                OrdersIndexForm frm = new OrdersIndexForm();
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }
        }

        private void ToMenusButton_Click(object sender, EventArgs e)
        {
            this.Dispose();

            if ((Application.OpenForms["MenusIndexForm"] as MenusIndexForm) != null)
            {

            }
            else
            {

                foreach (Form fr in this.MdiChildren)
                {

                    fr.Dispose();
                    fr.Close();

                }
                MenusIndexForm frm = new MenusIndexForm();
                frm.MdiParent = MainForm.ActiveForm;
                frm.Show();
            }
        }


    }
}
