namespace eStudentRestaurant_UI.Students
{
    partial class StudentsIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsIndexForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentsDataGrid = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.SearchStudentsButton = new System.Windows.Forms.Button();
            this.SearchStudentsInput = new System.Windows.Forms.TextBox();
            this.SearchStudentsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StudentsDataGrid);
            this.panel1.Location = new System.Drawing.Point(13, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 444);
            this.panel1.TabIndex = 38;
            // 
            // StudentsDataGrid
            // 
            this.StudentsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.StudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.Address_,
            this.Phone,
            this.City,
            this.Username,
            this.Active});
            this.StudentsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.StudentsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.StudentsDataGrid.MultiSelect = false;
            this.StudentsDataGrid.Name = "StudentsDataGrid";
            this.StudentsDataGrid.ReadOnly = true;
            this.StudentsDataGrid.Size = new System.Drawing.Size(740, 444);
            this.StudentsDataGrid.TabIndex = 0;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Visible = false;
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
            this.LastName.HeaderText = "Last name";
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
            // EditStudentButton
            // 
            this.EditStudentButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditStudentButton.FlatAppearance.BorderSize = 0;
            this.EditStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStudentButton.ForeColor = System.Drawing.Color.White;
            this.EditStudentButton.Location = new System.Drawing.Point(539, 86);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(91, 31);
            this.EditStudentButton.TabIndex = 37;
            this.EditStudentButton.Text = "Edit Student";
            this.EditStudentButton.UseVisualStyleBackColor = false;
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddStudentButton.FlatAppearance.BorderSize = 0;
            this.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentButton.ForeColor = System.Drawing.Color.White;
            this.AddStudentButton.Location = new System.Drawing.Point(661, 86);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(92, 31);
            this.AddStudentButton.TabIndex = 36;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // SearchStudentsButton
            // 
            this.SearchStudentsButton.FlatAppearance.BorderSize = 0;
            this.SearchStudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchStudentsButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchStudentsButton.Image")));
            this.SearchStudentsButton.Location = new System.Drawing.Point(341, 86);
            this.SearchStudentsButton.Name = "SearchStudentsButton";
            this.SearchStudentsButton.Size = new System.Drawing.Size(30, 21);
            this.SearchStudentsButton.TabIndex = 35;
            this.SearchStudentsButton.UseVisualStyleBackColor = true;
            this.SearchStudentsButton.Click += new System.EventHandler(this.SearchStudentsButton_Click);
            // 
            // SearchStudentsInput
            // 
            this.SearchStudentsInput.Location = new System.Drawing.Point(69, 87);
            this.SearchStudentsInput.Name = "SearchStudentsInput";
            this.SearchStudentsInput.Size = new System.Drawing.Size(266, 20);
            this.SearchStudentsInput.TabIndex = 34;
            // 
            // SearchStudentsLabel
            // 
            this.SearchStudentsLabel.AutoSize = true;
            this.SearchStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudentsLabel.ForeColor = System.Drawing.Color.White;
            this.SearchStudentsLabel.Location = new System.Drawing.Point(10, 87);
            this.SearchStudentsLabel.Name = "SearchStudentsLabel";
            this.SearchStudentsLabel.Size = new System.Drawing.Size(53, 17);
            this.SearchStudentsLabel.TabIndex = 33;
            this.SearchStudentsLabel.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Students  ";
            // 
            // StudentsIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(790, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditStudentButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.SearchStudentsButton);
            this.Controls.Add(this.SearchStudentsInput);
            this.Controls.Add(this.SearchStudentsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsIndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsIndexForm";
            this.Load += new System.EventHandler(this.StudentsIndexForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditStudentButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button SearchStudentsButton;
        private System.Windows.Forms.TextBox SearchStudentsInput;
        private System.Windows.Forms.Label SearchStudentsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}