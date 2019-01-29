namespace eStudentRestaurant_UI.Students
{
    partial class StudentEditForm
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
            this.EditStudent = new System.Windows.Forms.Button();
            this.ActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneInput = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.JmbgInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EditStudent
            // 
            this.EditStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.EditStudent.FlatAppearance.BorderSize = 0;
            this.EditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStudent.ForeColor = System.Drawing.Color.White;
            this.EditStudent.Location = new System.Drawing.Point(338, 436);
            this.EditStudent.Name = "EditStudent";
            this.EditStudent.Size = new System.Drawing.Size(92, 30);
            this.EditStudent.TabIndex = 103;
            this.EditStudent.Text = "Save";
            this.EditStudent.UseVisualStyleBackColor = false;
            this.EditStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // ActiveCheckBox
            // 
            this.ActiveCheckBox.AutoSize = true;
            this.ActiveCheckBox.ForeColor = System.Drawing.Color.White;
            this.ActiveCheckBox.Location = new System.Drawing.Point(305, 271);
            this.ActiveCheckBox.Name = "ActiveCheckBox";
            this.ActiveCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ActiveCheckBox.TabIndex = 102;
            this.ActiveCheckBox.Text = "Active";
            this.ActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(212, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 101;
            this.label14.Text = "Status:";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDatePicker.Location = new System.Drawing.Point(98, 215);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(107, 20);
            this.BirthDatePicker.TabIndex = 99;
            this.BirthDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.BirthDatePicker_Validating);
            // 
            // PhoneInput
            // 
            this.PhoneInput.Location = new System.Drawing.Point(309, 219);
            this.PhoneInput.Mask = "(999) 000-0000";
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(121, 20);
            this.PhoneInput.TabIndex = 98;
            this.PhoneInput.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneInput_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 20);
            this.label11.TabIndex = 97;
            this.label11.Text = "Account information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Personal information";
            // 
            // CityComboBox
            // 
            this.CityComboBox.DisplayMember = "Text";
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(309, 167);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(121, 21);
            this.CityComboBox.TabIndex = 95;
            this.CityComboBox.ValueMember = "ID";
            this.CityComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.CityComboBox_Validating);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(305, 360);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(125, 20);
            this.PasswordInput.TabIndex = 94;
            this.PasswordInput.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordInput_Validating);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(105, 363);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(95, 20);
            this.UsernameInput.TabIndex = 93;
            this.UsernameInput.Validating += new System.ComponentModel.CancelEventHandler(this.UsernameInput_Validating);
            // 
            // AddressInput
            // 
            this.AddressInput.Location = new System.Drawing.Point(98, 264);
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(107, 20);
            this.AddressInput.TabIndex = 92;
            this.AddressInput.Validating += new System.ComponentModel.CancelEventHandler(this.AddressInput_Validating);
            // 
            // JmbgInput
            // 
            this.JmbgInput.Location = new System.Drawing.Point(98, 164);
            this.JmbgInput.Name = "JmbgInput";
            this.JmbgInput.Size = new System.Drawing.Size(107, 20);
            this.JmbgInput.TabIndex = 91;
            this.JmbgInput.Validating += new System.ComponentModel.CancelEventHandler(this.JmbgInput_Validating);
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(309, 123);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(121, 20);
            this.LastNameInput.TabIndex = 90;
            this.LastNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameInput_Validating);
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(98, 124);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(107, 20);
            this.FirstNameInput.TabIndex = 89;
            this.FirstNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameInput_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 87;
            this.label13.Text = "Username:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(213, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 86;
            this.label12.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(211, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "City name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(211, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Last name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "JMBG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "Birthdate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "First name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(138, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 78;
            this.label6.Text = "Edit Student";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(443, 489);
            this.Controls.Add(this.EditStudent);
            this.Controls.Add(this.ActiveCheckBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.PhoneInput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.AddressInput);
            this.Controls.Add(this.JmbgInput);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "StudentEditForm";
            this.Text = "StudentEditForm";
            this.Load += new System.EventHandler(this.StudentEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditStudent;
        private System.Windows.Forms.CheckBox ActiveCheckBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.MaskedTextBox PhoneInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.TextBox JmbgInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}