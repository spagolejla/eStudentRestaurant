using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudentRestaurant_UI.Reports
{
    public partial class TotalSalaryReportForm : Form
    {
        public TotalSalaryReportForm()
        {
            InitializeComponent();
        }

        private void TotalSalaryReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eStudentRestaurantDataSet.esp_TotalSalaryByOrders' table. You can move, or remove it, as needed.
            this.esp_TotalSalaryByOrdersTableAdapter.Fill(this.eStudentRestaurantDataSet.esp_TotalSalaryByOrders);
           
            this.reportViewer1.RefreshReport();
        }
    }
}
