namespace eStudentRestaurant_UI.Main
{
    partial class ChildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            this.LogoutReceptionButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogoutReceptionButton
            // 
            this.LogoutReceptionButton.FlatAppearance.BorderSize = 0;
            this.LogoutReceptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutReceptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutReceptionButton.ForeColor = System.Drawing.Color.White;
            this.LogoutReceptionButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutReceptionButton.Image")));
            this.LogoutReceptionButton.Location = new System.Drawing.Point(728, 22);
            this.LogoutReceptionButton.Name = "LogoutReceptionButton";
            this.LogoutReceptionButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.LogoutReceptionButton.Size = new System.Drawing.Size(49, 31);
            this.LogoutReceptionButton.TabIndex = 35;
            this.LogoutReceptionButton.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(616, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 25);
            this.label19.TabIndex = 34;
            this.label19.Text = "Lejla Špago";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(513, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 25);
            this.label18.TabIndex = 33;
            this.label18.Text = "Welcome,   ";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(790, 605);
            this.Controls.Add(this.LogoutReceptionButton);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutReceptionButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}