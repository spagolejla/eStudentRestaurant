namespace eStudentRestaurant_UI.Main
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ToClientsButton = new System.Windows.Forms.Button();
            this.ToMenusButton = new System.Windows.Forms.Button();
            this.ToOrdersButton = new System.Windows.Forms.Button();
            this.ToEmployeesButton = new System.Windows.Forms.Button();
            this.MainLogoPanel = new System.Windows.Forms.Panel();
            this.MainLogoRestaurant = new System.Windows.Forms.Label();
            this.MainLogoStudent = new System.Windows.Forms.Label();
            this.ToStudentButton = new System.Windows.Forms.Button();
            this.ToHomeButton = new System.Windows.Forms.Button();
            this.ToProductButton = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.MainLogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.MainMenuPanel.Controls.Add(this.LogoutButton);
            this.MainMenuPanel.Controls.Add(this.ToClientsButton);
            this.MainMenuPanel.Controls.Add(this.ToMenusButton);
            this.MainMenuPanel.Controls.Add(this.ToOrdersButton);
            this.MainMenuPanel.Controls.Add(this.ToEmployeesButton);
            this.MainMenuPanel.Controls.Add(this.MainLogoPanel);
            this.MainMenuPanel.Controls.Add(this.ToStudentButton);
            this.MainMenuPanel.Controls.Add(this.ToHomeButton);
            this.MainMenuPanel.Controls.Add(this.ToProductButton);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(240, 611);
            this.MainMenuPanel.TabIndex = 1;
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(3, 565);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.LogoutButton.Size = new System.Drawing.Size(237, 46);
            this.LogoutButton.TabIndex = 16;
            this.LogoutButton.Text = "Logut";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // ToClientsButton
            // 
            this.ToClientsButton.FlatAppearance.BorderSize = 0;
            this.ToClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClientsButton.ForeColor = System.Drawing.Color.White;
            this.ToClientsButton.Image = ((System.Drawing.Image)(resources.GetObject("ToClientsButton.Image")));
            this.ToClientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToClientsButton.Location = new System.Drawing.Point(1, 422);
            this.ToClientsButton.Name = "ToClientsButton";
            this.ToClientsButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ToClientsButton.Size = new System.Drawing.Size(236, 46);
            this.ToClientsButton.TabIndex = 15;
            this.ToClientsButton.Text = "     Clients";
            this.ToClientsButton.UseVisualStyleBackColor = true;
            this.ToClientsButton.Click += new System.EventHandler(this.ToClientsButton_Click);
            // 
            // ToMenusButton
            // 
            this.ToMenusButton.FlatAppearance.BorderSize = 0;
            this.ToMenusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMenusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMenusButton.ForeColor = System.Drawing.Color.White;
            this.ToMenusButton.Image = ((System.Drawing.Image)(resources.GetObject("ToMenusButton.Image")));
            this.ToMenusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToMenusButton.Location = new System.Drawing.Point(0, 370);
            this.ToMenusButton.Name = "ToMenusButton";
            this.ToMenusButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ToMenusButton.Size = new System.Drawing.Size(240, 46);
            this.ToMenusButton.TabIndex = 14;
            this.ToMenusButton.Text = "     Menus";
            this.ToMenusButton.UseVisualStyleBackColor = true;
            this.ToMenusButton.Click += new System.EventHandler(this.ToMenusButton_Click);
            // 
            // ToOrdersButton
            // 
            this.ToOrdersButton.FlatAppearance.BorderSize = 0;
            this.ToOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToOrdersButton.ForeColor = System.Drawing.Color.White;
            this.ToOrdersButton.Image = ((System.Drawing.Image)(resources.GetObject("ToOrdersButton.Image")));
            this.ToOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToOrdersButton.Location = new System.Drawing.Point(0, 318);
            this.ToOrdersButton.Name = "ToOrdersButton";
            this.ToOrdersButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ToOrdersButton.Size = new System.Drawing.Size(237, 46);
            this.ToOrdersButton.TabIndex = 13;
            this.ToOrdersButton.Text = "     Orders";
            this.ToOrdersButton.UseVisualStyleBackColor = true;
            this.ToOrdersButton.Click += new System.EventHandler(this.ToOrdersButton_Click);
            // 
            // ToEmployeesButton
            // 
            this.ToEmployeesButton.FlatAppearance.BorderSize = 0;
            this.ToEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToEmployeesButton.ForeColor = System.Drawing.Color.White;
            this.ToEmployeesButton.Image = ((System.Drawing.Image)(resources.GetObject("ToEmployeesButton.Image")));
            this.ToEmployeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToEmployeesButton.Location = new System.Drawing.Point(1, 171);
            this.ToEmployeesButton.Name = "ToEmployeesButton";
            this.ToEmployeesButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ToEmployeesButton.Size = new System.Drawing.Size(236, 46);
            this.ToEmployeesButton.TabIndex = 12;
            this.ToEmployeesButton.Text = "       Employees";
            this.ToEmployeesButton.UseVisualStyleBackColor = false;
            this.ToEmployeesButton.Click += new System.EventHandler(this.ToEmployeesButton_Click);
            // 
            // MainLogoPanel
            // 
            this.MainLogoPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.MainLogoPanel.Controls.Add(this.MainLogoRestaurant);
            this.MainLogoPanel.Controls.Add(this.MainLogoStudent);
            this.MainLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLogoPanel.Name = "MainLogoPanel";
            this.MainLogoPanel.Size = new System.Drawing.Size(240, 90);
            this.MainLogoPanel.TabIndex = 0;
            // 
            // MainLogoRestaurant
            // 
            this.MainLogoRestaurant.AutoSize = true;
            this.MainLogoRestaurant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLogoRestaurant.ForeColor = System.Drawing.Color.White;
            this.MainLogoRestaurant.Location = new System.Drawing.Point(65, 49);
            this.MainLogoRestaurant.Name = "MainLogoRestaurant";
            this.MainLogoRestaurant.Size = new System.Drawing.Size(98, 18);
            this.MainLogoRestaurant.TabIndex = 1;
            this.MainLogoRestaurant.Text = "Restaurant";
            // 
            // MainLogoStudent
            // 
            this.MainLogoStudent.AutoSize = true;
            this.MainLogoStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLogoStudent.ForeColor = System.Drawing.Color.White;
            this.MainLogoStudent.Location = new System.Drawing.Point(48, 21);
            this.MainLogoStudent.Name = "MainLogoStudent";
            this.MainLogoStudent.Size = new System.Drawing.Size(115, 28);
            this.MainLogoStudent.TabIndex = 0;
            this.MainLogoStudent.Text = "eStudent";
            // 
            // ToStudentButton
            // 
            this.ToStudentButton.FlatAppearance.BorderSize = 0;
            this.ToStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToStudentButton.ForeColor = System.Drawing.Color.White;
            this.ToStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("ToStudentButton.Image")));
            this.ToStudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToStudentButton.Location = new System.Drawing.Point(1, 214);
            this.ToStudentButton.Name = "ToStudentButton";
            this.ToStudentButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ToStudentButton.Size = new System.Drawing.Size(236, 46);
            this.ToStudentButton.TabIndex = 11;
            this.ToStudentButton.Text = "    Students";
            this.ToStudentButton.UseVisualStyleBackColor = true;
            this.ToStudentButton.Click += new System.EventHandler(this.ToStudentButton_Click);
            // 
            // ToHomeButton
            // 
            this.ToHomeButton.FlatAppearance.BorderSize = 0;
            this.ToHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToHomeButton.ForeColor = System.Drawing.Color.White;
            this.ToHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("ToHomeButton.Image")));
            this.ToHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToHomeButton.Location = new System.Drawing.Point(1, 119);
            this.ToHomeButton.Name = "ToHomeButton";
            this.ToHomeButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ToHomeButton.Size = new System.Drawing.Size(236, 46);
            this.ToHomeButton.TabIndex = 9;
            this.ToHomeButton.Text = "Home";
            this.ToHomeButton.UseVisualStyleBackColor = true;
            this.ToHomeButton.Click += new System.EventHandler(this.ToHomeButton_Click);
            // 
            // ToProductButton
            // 
            this.ToProductButton.FlatAppearance.BorderSize = 0;
            this.ToProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToProductButton.ForeColor = System.Drawing.Color.White;
            this.ToProductButton.Image = ((System.Drawing.Image)(resources.GetObject("ToProductButton.Image")));
            this.ToProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToProductButton.Location = new System.Drawing.Point(1, 266);
            this.ToProductButton.Name = "ToProductButton";
            this.ToProductButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ToProductButton.Size = new System.Drawing.Size(236, 46);
            this.ToProductButton.TabIndex = 10;
            this.ToProductButton.Text = "     Products";
            this.ToProductButton.UseVisualStyleBackColor = true;
            this.ToProductButton.Click += new System.EventHandler(this.ToProductButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.MainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainMenuPanel.ResumeLayout(false);
            this.MainLogoPanel.ResumeLayout(false);
            this.MainLogoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button ToMenusButton;
        private System.Windows.Forms.Button ToOrdersButton;
        private System.Windows.Forms.Button ToEmployeesButton;
        private System.Windows.Forms.Panel MainLogoPanel;
        private System.Windows.Forms.Label MainLogoRestaurant;
        private System.Windows.Forms.Label MainLogoStudent;
        private System.Windows.Forms.Button ToStudentButton;
        private System.Windows.Forms.Button ToHomeButton;
        private System.Windows.Forms.Button ToProductButton;
        private System.Windows.Forms.Button ToClientsButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}