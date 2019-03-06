namespace eStudentRestaurant_UI.Reports
{
    partial class TotalSalaryReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.espTotalSalaryByOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eStudentRestaurantDataSet = new eStudentRestaurant_UI.eStudentRestaurantDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TotalSalaryByOrders_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalSalaryByOrdersResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.esp_TotalSalaryByOrdersTableAdapter = new eStudentRestaurant_UI.eStudentRestaurantDataSetTableAdapters.esp_TotalSalaryByOrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.espTotalSalaryByOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStudentRestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSalaryByOrders_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSalaryByOrdersResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // espTotalSalaryByOrdersBindingSource
            // 
            this.espTotalSalaryByOrdersBindingSource.DataMember = "esp_TotalSalaryByOrders";
            this.espTotalSalaryByOrdersBindingSource.DataSource = this.eStudentRestaurantDataSet;
            // 
            // eStudentRestaurantDataSet
            // 
            this.eStudentRestaurantDataSet.DataSetName = "eStudentRestaurantDataSet";
            this.eStudentRestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsTotalSalary";
            reportDataSource1.Value = this.espTotalSalaryByOrdersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eStudentRestaurant_UI.Reports.TotalSalary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TotalSalaryByOrders_ResultBindingSource
            // 
            this.TotalSalaryByOrders_ResultBindingSource.DataSource = typeof(eStudentRestaurant_API.Models.TotalSalaryByOrders_Result);
            // 
            // totalSalaryByOrdersResultBindingSource
            // 
            this.totalSalaryByOrdersResultBindingSource.DataSource = typeof(eStudentRestaurant_API.Models.TotalSalaryByOrders_Result);
            // 
            // esp_TotalSalaryByOrdersTableAdapter
            // 
            this.esp_TotalSalaryByOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // TotalSalaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TotalSalaryReportForm";
            this.Text = "TotalSalaryReportForm";
            this.Load += new System.EventHandler(this.TotalSalaryReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.espTotalSalaryByOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eStudentRestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSalaryByOrders_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSalaryByOrdersResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TotalSalaryByOrders_ResultBindingSource;
        private System.Windows.Forms.BindingSource totalSalaryByOrdersResultBindingSource;
        private eStudentRestaurantDataSet eStudentRestaurantDataSet;
        private System.Windows.Forms.BindingSource espTotalSalaryByOrdersBindingSource;
        private eStudentRestaurantDataSetTableAdapters.esp_TotalSalaryByOrdersTableAdapter esp_TotalSalaryByOrdersTableAdapter;
    }
}