namespace eStudentRestaurant_UI.Orders
{
    partial class OrdersIndexForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TodayButton = new System.Windows.Forms.Button();
            this.OrderDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Orders";
            // 
            // OrderDatePicker
            // 
            this.OrderDatePicker.Location = new System.Drawing.Point(39, 137);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(200, 20);
            this.OrderDatePicker.TabIndex = 41;
            this.OrderDatePicker.ValueChanged += new System.EventHandler(this.OrderDatePicker_ValueChanged);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderDate,
            this.TotalPrice,
            this.Student,
            this.Employee,
            this.OrderStatus});
            this.OrdersGridView.Location = new System.Drawing.Point(39, 181);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.ReadOnly = true;
            this.OrdersGridView.Size = new System.Drawing.Size(556, 280);
            this.OrdersGridView.TabIndex = 42;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Visible = false;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            // 
            // OrderStatus
            // 
            this.OrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderStatus.DataPropertyName = "Status";
            this.OrderStatus.HeaderText = "Status";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 106;
            this.label2.Text = "Choose a date:";
            // 
            // TodayButton
            // 
            this.TodayButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TodayButton.FlatAppearance.BorderSize = 0;
            this.TodayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodayButton.ForeColor = System.Drawing.Color.White;
            this.TodayButton.Location = new System.Drawing.Point(270, 134);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(91, 23);
            this.TodayButton.TabIndex = 107;
            this.TodayButton.Text = "Today";
            this.TodayButton.UseVisualStyleBackColor = false;
            this.TodayButton.Click += new System.EventHandler(this.TodayButton_Click);
            // 
            // OrderDetailsButton
            // 
            this.OrderDetailsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.OrderDetailsButton.FlatAppearance.BorderSize = 0;
            this.OrderDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderDetailsButton.ForeColor = System.Drawing.Color.White;
            this.OrderDetailsButton.Location = new System.Drawing.Point(632, 181);
            this.OrderDetailsButton.Name = "OrderDetailsButton";
            this.OrderDetailsButton.Size = new System.Drawing.Size(120, 42);
            this.OrderDetailsButton.TabIndex = 108;
            this.OrderDetailsButton.Text = "Order details";
            this.OrderDetailsButton.UseVisualStyleBackColor = false;
            this.OrderDetailsButton.Click += new System.EventHandler(this.OrderDetailsButton_Click);
            // 
            // OrdersIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 605);
            this.Controls.Add(this.OrderDetailsButton);
            this.Controls.Add(this.TodayButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrdersGridView);
            this.Controls.Add(this.OrderDatePicker);
            this.Controls.Add(this.label1);
            this.Name = "OrdersIndexForm";
            this.Text = "OrdersIndexForm";
            this.Load += new System.EventHandler(this.OrdersIndexForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.OrderDatePicker, 0);
            this.Controls.SetChildIndex(this.OrdersGridView, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TodayButton, 0);
            this.Controls.SetChildIndex(this.OrderDetailsButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker OrderDatePicker;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TodayButton;
        private System.Windows.Forms.Button OrderDetailsButton;
    }
}