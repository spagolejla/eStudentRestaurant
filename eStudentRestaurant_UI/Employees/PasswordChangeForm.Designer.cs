namespace eStudentRestaurant_UI.Employees
{
    partial class PasswordChangeForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.OldPasswordInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NewPasswordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordChangeButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(130, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Change password";
            // 
            // OldPasswordInput
            // 
            this.OldPasswordInput.Location = new System.Drawing.Point(182, 92);
            this.OldPasswordInput.Name = "OldPasswordInput";
            this.OldPasswordInput.PasswordChar = '*';
            this.OldPasswordInput.Size = new System.Drawing.Size(153, 20);
            this.OldPasswordInput.TabIndex = 46;
            this.OldPasswordInput.Validating += new System.ComponentModel.CancelEventHandler(this.OldPasswordInput_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(65, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Old password:";
            // 
            // NewPasswordInput
            // 
            this.NewPasswordInput.Location = new System.Drawing.Point(182, 128);
            this.NewPasswordInput.Name = "NewPasswordInput";
            this.NewPasswordInput.PasswordChar = '*';
            this.NewPasswordInput.Size = new System.Drawing.Size(153, 20);
            this.NewPasswordInput.TabIndex = 48;
            this.NewPasswordInput.Validating += new System.ComponentModel.CancelEventHandler(this.NewPasswordInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "New password:";
            // 
            // PasswordChangeButton
            // 
            this.PasswordChangeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.PasswordChangeButton.FlatAppearance.BorderSize = 0;
            this.PasswordChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordChangeButton.ForeColor = System.Drawing.Color.White;
            this.PasswordChangeButton.Location = new System.Drawing.Point(243, 199);
            this.PasswordChangeButton.Name = "PasswordChangeButton";
            this.PasswordChangeButton.Size = new System.Drawing.Size(92, 30);
            this.PasswordChangeButton.TabIndex = 50;
            this.PasswordChangeButton.Text = "Save";
            this.PasswordChangeButton.UseVisualStyleBackColor = false;
            this.PasswordChangeButton.Click += new System.EventHandler(this.PasswordChangeButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 289);
            this.Controls.Add(this.PasswordChangeButton);
            this.Controls.Add(this.NewPasswordInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OldPasswordInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Name = "PasswordChangeForm";
            this.Text = "PasswordChangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OldPasswordInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NewPasswordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PasswordChangeButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}