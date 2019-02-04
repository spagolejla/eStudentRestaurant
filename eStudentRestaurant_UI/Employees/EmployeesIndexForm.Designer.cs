namespace eStudentRestaurant_UI.Employees
{
    partial class EmployeesIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesIndexForm));
            this.SearchEmployeesButton = new System.Windows.Forms.Button();
            this.SearchEmpoyeesInput = new System.Windows.Forms.TextBox();
            this.SearchEmployeesLabel = new System.Windows.Forms.Label();
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.PassChangeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchEmployeesButton
            // 
            this.SearchEmployeesButton.FlatAppearance.BorderSize = 0;
            this.SearchEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchEmployeesButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchEmployeesButton.Image")));
            this.SearchEmployeesButton.Location = new System.Drawing.Point(352, 73);
            this.SearchEmployeesButton.Name = "SearchEmployeesButton";
            this.SearchEmployeesButton.Size = new System.Drawing.Size(30, 21);
            this.SearchEmployeesButton.TabIndex = 26;
            this.SearchEmployeesButton.UseVisualStyleBackColor = true;
            this.SearchEmployeesButton.Click += new System.EventHandler(this.SearchEmployeesButton_Click);
            // 
            // SearchEmpoyeesInput
            // 
            this.SearchEmpoyeesInput.Location = new System.Drawing.Point(80, 74);
            this.SearchEmpoyeesInput.Name = "SearchEmpoyeesInput";
            this.SearchEmpoyeesInput.Size = new System.Drawing.Size(266, 20);
            this.SearchEmpoyeesInput.TabIndex = 25;
            // 
            // SearchEmployeesLabel
            // 
            this.SearchEmployeesLabel.AutoSize = true;
            this.SearchEmployeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmployeesLabel.ForeColor = System.Drawing.Color.White;
            this.SearchEmployeesLabel.Location = new System.Drawing.Point(21, 74);
            this.SearchEmployeesLabel.Name = "SearchEmployeesLabel";
            this.SearchEmployeesLabel.Size = new System.Drawing.Size(53, 17);
            this.SearchEmployeesLabel.TabIndex = 24;
            this.SearchEmployeesLabel.Text = "Search";
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditEmployeeButton.FlatAppearance.BorderSize = 0;
            this.EditEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EditEmployeeButton.Location = new System.Drawing.Point(545, 73);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(91, 30);
            this.EditEmployeeButton.TabIndex = 28;
            this.EditEmployeeButton.Text = "Edit Employee";
            this.EditEmployeeButton.UseVisualStyleBackColor = false;
            this.EditEmployeeButton.Click += new System.EventHandler(this.EditEmployeeButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddEmployeeButton.FlatAppearance.BorderSize = 0;
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.Location = new System.Drawing.Point(672, 74);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(92, 29);
            this.AddEmployeeButton.TabIndex = 27;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmployeesDataGrid);
            this.panel1.Location = new System.Drawing.Point(24, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 397);
            this.panel1.TabIndex = 29;
            // 
            // EmployeesDataGrid
            // 
            this.EmployeesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.FirstName,
            this.LastName,
            this.Address_,
            this.Phone,
            this.City,
            this.Username,
            this.Active});
            this.EmployeesDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.EmployeesDataGrid.Location = new System.Drawing.Point(0, 0);
            this.EmployeesDataGrid.MultiSelect = false;
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.ReadOnly = true;
            this.EmployeesDataGrid.Size = new System.Drawing.Size(740, 380);
            this.EmployeesDataGrid.TabIndex = 0;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address_
            // 
            this.Address_.DataPropertyName = "Address_";
            this.Address_.HeaderText = "Address";
            this.Address_.Name = "Address_";
            this.Address_.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Employees";
            // 
            // PassChangeButton
            // 
            this.PassChangeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.PassChangeButton.FlatAppearance.BorderSize = 0;
            this.PassChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassChangeButton.ForeColor = System.Drawing.Color.White;
            this.PassChangeButton.Location = new System.Drawing.Point(24, 554);
            this.PassChangeButton.Name = "PassChangeButton";
            this.PassChangeButton.Size = new System.Drawing.Size(140, 30);
            this.PassChangeButton.TabIndex = 41;
            this.PassChangeButton.Text = "Change password";
            this.PassChangeButton.UseVisualStyleBackColor = false;
            this.PassChangeButton.Click += new System.EventHandler(this.PassChangeButton_Click);
            // 
            // EmployeesIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(790, 605);
            this.Controls.Add(this.PassChangeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.SearchEmployeesButton);
            this.Controls.Add(this.SearchEmpoyeesInput);
            this.Controls.Add(this.SearchEmployeesLabel);
            this.Name = "EmployeesIndexForm";
            this.Text = "EmployeesIndexForm";
            this.Load += new System.EventHandler(this.EmployeesIndexForm_Load);
            this.Controls.SetChildIndex(this.SearchEmployeesLabel, 0);
            this.Controls.SetChildIndex(this.SearchEmpoyeesInput, 0);
            this.Controls.SetChildIndex(this.SearchEmployeesButton, 0);
            this.Controls.SetChildIndex(this.AddEmployeeButton, 0);
            this.Controls.SetChildIndex(this.EditEmployeeButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.PassChangeButton, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchEmployeesButton;
        private System.Windows.Forms.TextBox SearchEmpoyeesInput;
        private System.Windows.Forms.Label SearchEmployeesLabel;
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView EmployeesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PassChangeButton;
    }
}