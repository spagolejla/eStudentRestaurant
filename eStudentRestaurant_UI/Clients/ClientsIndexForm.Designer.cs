namespace eStudentRestaurant_UI.Clients
{
    partial class ClientsIndexForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PointsInput = new System.Windows.Forms.TextBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrganizationNameInput = new System.Windows.Forms.TextBox();
            this.ActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PhoneInput = new System.Windows.Forms.MaskedTextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditClientButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.SearchClientsLabel = new System.Windows.Forms.Label();
            this.ClientsComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReservationsReportButton = new System.Windows.Forms.Button();
            this.ApproveReservationButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ReservationGridView = new System.Windows.Forms.DataGridView();
            this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Clients ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PointsInput);
            this.panel1.Controls.Add(this.CityComboBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.OrganizationNameInput);
            this.panel1.Controls.Add(this.ActiveCheckBox);
            this.panel1.Controls.Add(this.PasswordInput);
            this.panel1.Controls.Add(this.UsernameInput);
            this.panel1.Controls.Add(this.PhoneInput);
            this.panel1.Controls.Add(this.LastNameInput);
            this.panel1.Controls.Add(this.FirstNameInput);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(30, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 149);
            this.panel1.TabIndex = 46;
            // 
            // PointsInput
            // 
            this.PointsInput.Location = new System.Drawing.Point(641, 84);
            this.PointsInput.Name = "PointsInput";
            this.PointsInput.ReadOnly = true;
            this.PointsInput.Size = new System.Drawing.Size(94, 20);
            this.PointsInput.TabIndex = 110;
            // 
            // CityComboBox
            // 
            this.CityComboBox.DisplayMember = "Text";
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(641, 51);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(94, 21);
            this.CityComboBox.TabIndex = 109;
            this.CityComboBox.ValueMember = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(579, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 108;
            this.label8.Text = "Points:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(579, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 107;
            this.label7.Text = "City:";
            // 
            // OrganizationNameInput
            // 
            this.OrganizationNameInput.Location = new System.Drawing.Point(479, 51);
            this.OrganizationNameInput.Name = "OrganizationNameInput";
            this.OrganizationNameInput.Size = new System.Drawing.Size(94, 20);
            this.OrganizationNameInput.TabIndex = 106;
            this.OrganizationNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.OrganizationNameInput_Validating);
            // 
            // ActiveCheckBox
            // 
            this.ActiveCheckBox.AutoSize = true;
            this.ActiveCheckBox.ForeColor = System.Drawing.Color.White;
            this.ActiveCheckBox.Location = new System.Drawing.Point(95, 14);
            this.ActiveCheckBox.Name = "ActiveCheckBox";
            this.ActiveCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ActiveCheckBox.TabIndex = 105;
            this.ActiveCheckBox.Text = "Active";
            this.ActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(479, 81);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(94, 20);
            this.PasswordInput.TabIndex = 104;
            this.PasswordInput.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordInput_Validating);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(278, 81);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(95, 20);
            this.UsernameInput.TabIndex = 103;
            this.UsernameInput.Validating += new System.ComponentModel.CancelEventHandler(this.UsernameInput_Validating);
            // 
            // PhoneInput
            // 
            this.PhoneInput.Location = new System.Drawing.Point(95, 80);
            this.PhoneInput.Mask = "(999) 000-0000";
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(92, 20);
            this.PhoneInput.TabIndex = 75;
            this.PhoneInput.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneInput_Validating);
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(278, 50);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(94, 20);
            this.LastNameInput.TabIndex = 74;
            this.LastNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameInput_Validating);
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(95, 50);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(94, 20);
            this.FirstNameInput.TabIndex = 73;
            this.FirstNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(380, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Organization:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(194, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "Last name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(380, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(195, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Details";
            // 
            // EditClientButton
            // 
            this.EditClientButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditClientButton.FlatAppearance.BorderSize = 0;
            this.EditClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditClientButton.ForeColor = System.Drawing.Color.White;
            this.EditClientButton.Location = new System.Drawing.Point(578, 83);
            this.EditClientButton.Name = "EditClientButton";
            this.EditClientButton.Size = new System.Drawing.Size(92, 27);
            this.EditClientButton.TabIndex = 53;
            this.EditClientButton.Text = "Edit Client";
            this.EditClientButton.UseVisualStyleBackColor = false;
            this.EditClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddClientButton.FlatAppearance.BorderSize = 0;
            this.AddClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientButton.ForeColor = System.Drawing.Color.White;
            this.AddClientButton.Location = new System.Drawing.Point(685, 83);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(92, 27);
            this.AddClientButton.TabIndex = 44;
            this.AddClientButton.Text = "Add Client";
            this.AddClientButton.UseVisualStyleBackColor = false;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // SearchClientsLabel
            // 
            this.SearchClientsLabel.AutoSize = true;
            this.SearchClientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClientsLabel.ForeColor = System.Drawing.Color.White;
            this.SearchClientsLabel.Location = new System.Drawing.Point(27, 83);
            this.SearchClientsLabel.Name = "SearchClientsLabel";
            this.SearchClientsLabel.Size = new System.Drawing.Size(109, 17);
            this.SearchClientsLabel.TabIndex = 41;
            this.SearchClientsLabel.Text = "Choose a client:";
            // 
            // ClientsComboBox
            // 
            this.ClientsComboBox.DisplayMember = "Text";
            this.ClientsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientsComboBox.FormattingEnabled = true;
            this.ClientsComboBox.Location = new System.Drawing.Point(142, 82);
            this.ClientsComboBox.Name = "ClientsComboBox";
            this.ClientsComboBox.Size = new System.Drawing.Size(193, 21);
            this.ClientsComboBox.TabIndex = 47;
            this.ClientsComboBox.ValueMember = "ID";
            this.ClientsComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientsComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ReservationsReportButton);
            this.panel2.Controls.Add(this.ApproveReservationButton);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(30, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 283);
            this.panel2.TabIndex = 54;
            // 
            // ReservationsReportButton
            // 
            this.ReservationsReportButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ReservationsReportButton.FlatAppearance.BorderSize = 0;
            this.ReservationsReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationsReportButton.ForeColor = System.Drawing.Color.White;
            this.ReservationsReportButton.Location = new System.Drawing.Point(538, 18);
            this.ReservationsReportButton.Name = "ReservationsReportButton";
            this.ReservationsReportButton.Size = new System.Drawing.Size(92, 28);
            this.ReservationsReportButton.TabIndex = 57;
            this.ReservationsReportButton.Text = "Report";
            this.ReservationsReportButton.UseVisualStyleBackColor = false;
            this.ReservationsReportButton.Click += new System.EventHandler(this.ReservationsReportButton_Click);
            // 
            // ApproveReservationButton
            // 
            this.ApproveReservationButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ApproveReservationButton.FlatAppearance.BorderSize = 0;
            this.ApproveReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveReservationButton.ForeColor = System.Drawing.Color.White;
            this.ApproveReservationButton.Location = new System.Drawing.Point(641, 18);
            this.ApproveReservationButton.Name = "ApproveReservationButton";
            this.ApproveReservationButton.Size = new System.Drawing.Size(92, 28);
            this.ApproveReservationButton.TabIndex = 56;
            this.ApproveReservationButton.Text = "Approve ";
            this.ApproveReservationButton.UseVisualStyleBackColor = false;
            this.ApproveReservationButton.Click += new System.EventHandler(this.ApproveReservationButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ReservationGridView);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(743, 226);
            this.flowLayoutPanel1.TabIndex = 55;
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationID,
            this.ClientID,
            this.Name_,
            this.ReservationDateTime,
            this.PlacesNumber,
            this.Note,
            this.Discount,
            this.Price,
            this.Status});
            this.ReservationGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ReservationGridView.Location = new System.Drawing.Point(3, 3);
            this.ReservationGridView.MultiSelect = false;
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.ReadOnly = true;
            this.ReservationGridView.Size = new System.Drawing.Size(736, 223);
            this.ReservationGridView.TabIndex = 0;
            // 
            // ReservationID
            // 
            this.ReservationID.DataPropertyName = "ReservationID";
            this.ReservationID.HeaderText = "ReservationID";
            this.ReservationID.Name = "ReservationID";
            this.ReservationID.ReadOnly = true;
            this.ReservationID.Visible = false;
            // 
            // ClientID
            // 
            this.ClientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientID.DataPropertyName = "ClientID";
            this.ClientID.HeaderText = "ClientID";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Visible = false;
            // 
            // Name_
            // 
            this.Name_.DataPropertyName = "Name_";
            this.Name_.HeaderText = "Type";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            // 
            // ReservationDateTime
            // 
            this.ReservationDateTime.DataPropertyName = "ReservationDateTime";
            this.ReservationDateTime.HeaderText = "Date";
            this.ReservationDateTime.Name = "ReservationDateTime";
            this.ReservationDateTime.ReadOnly = true;
            // 
            // PlacesNumber
            // 
            this.PlacesNumber.DataPropertyName = "PlacesNamber";
            this.PlacesNumber.HeaderText = "Number of places";
            this.PlacesNumber.Name = "PlacesNumber";
            this.PlacesNumber.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(15, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 22);
            this.label15.TabIndex = 41;
            this.label15.Text = "Clients reservation";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ClientsIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClientsComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.SearchClientsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditClientButton);
            this.Name = "ClientsIndexForm";
            this.Text = "ClientsIndexForm";
            this.Load += new System.EventHandler(this.ClientsIndexForm_Load);
            this.Controls.SetChildIndex(this.EditClientButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.SearchClientsLabel, 0);
            this.Controls.SetChildIndex(this.AddClientButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ClientsComboBox, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Label SearchClientsLabel;
        private System.Windows.Forms.ComboBox ClientsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditClientButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PhoneInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.TextBox OrganizationNameInput;
        private System.Windows.Forms.CheckBox ActiveCheckBox;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView ReservationGridView;
        private System.Windows.Forms.Button ApproveReservationButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PointsInput;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacesNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button ReservationsReportButton;
    }
}