using eStudentRestaurant_API.Models;
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
    public partial class ReservationsReportForm : Form
    {
        public Client client;
        public List<Reservation_Result> reservations;
        public ReservationsReportForm()
        {
            InitializeComponent();
        }

        private void ReservationsReportForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsReservationReport", reservations);
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Client", client.FirstName + " " + client.LastName));
            this.reportViewer1.RefreshReport();
        }
    }
}
