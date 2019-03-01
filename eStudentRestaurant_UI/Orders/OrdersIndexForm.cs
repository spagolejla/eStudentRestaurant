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

namespace eStudentRestaurant_UI.Orders
{
    public partial class OrdersIndexForm : ChildForm
    {
        private WebAPIHelper ordersService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.OrdersRoutes);
        DateTime date =  DateTime.Now;
        public OrdersIndexForm()
        {
            InitializeComponent();
            OrdersGridView.AutoGenerateColumns = false;
            OrdersGridView.Select();
            OrdersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void OrderDatePicker_ValueChanged(object sender, EventArgs e)
        {
            BindGrid(OrderDatePicker.Value);
        }

        private void BindGrid(DateTime value)
        {
            date = value;
            HttpResponseMessage responseMessage = ordersService.GetActionResponseDateParam("GetOrdersByDate", date.Day, date.Month, date.Year);

            if (responseMessage.IsSuccessStatusCode)
            {
                List<Order_Result> orders = responseMessage.Content.ReadAsAsync<List<Order_Result>>().Result;
                if (orders.Count() > 0)
                {
                    OrdersGridView.DataSource = orders;
                }
                else
                {
                    OrdersGridView.DataSource = null;

                }

            }
            else
            {
                MessageBox.Show("Error code: " + responseMessage.StatusCode + " Messages: " + responseMessage.ReasonPhrase);
            }
        }

        private void OrdersIndexForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            BindGrid(today);
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            BindGrid(today);
        }

        private void OrderDetailsButton_Click(object sender, EventArgs e)
        {
            if (OrdersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error! You didnt select order!");
            }
            else if (Convert.ToString(OrdersGridView.SelectedRows[0].Cells[5].Value) == "Processed")
            {
                MessageBox.Show("Error! Order is already processed!");

            }
            else if (Convert.ToString(OrdersGridView.SelectedRows[0].Cells[5].Value) == "Refused")
            {
                MessageBox.Show("Error! Order is already processed, and refused!");

            }
            else
            {
                OrderDetailsForm frm = new OrderDetailsForm(Convert.ToInt32(OrdersGridView.SelectedRows[0].Cells[0].Value));

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid(Convert.ToDateTime( OrdersGridView.SelectedRows[0].Cells[1].Value));
                }


                BindGrid(Convert.ToDateTime(OrdersGridView.SelectedRows[0].Cells[1].Value));
            }
        }
    }
}
