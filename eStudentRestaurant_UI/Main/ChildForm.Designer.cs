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
            this.LogutButton = new System.Windows.Forms.Button();
            this.LoggeUserLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogutButton
            // 
            this.LogutButton.FlatAppearance.BorderSize = 0;
            this.LogutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogutButton.ForeColor = System.Drawing.Color.White;
            this.LogutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogutButton.Image")));
            this.LogutButton.Location = new System.Drawing.Point(728, 22);
            this.LogutButton.Name = "LogutButton";
            this.LogutButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.LogutButton.Size = new System.Drawing.Size(49, 31);
            this.LogutButton.TabIndex = 35;
            this.LogutButton.UseVisualStyleBackColor = true;
            this.LogutButton.Click += new System.EventHandler(this.LogutButton_Click);
            // 
            // LoggeUserLabel
            // 
            this.LoggeUserLabel.AutoSize = true;
            this.LoggeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggeUserLabel.ForeColor = System.Drawing.Color.White;
            this.LoggeUserLabel.Location = new System.Drawing.Point(530, 22);
            this.LoggeUserLabel.Name = "LoggeUserLabel";
            this.LoggeUserLabel.Size = new System.Drawing.Size(53, 25);
            this.LoggeUserLabel.TabIndex = 34;
            this.LoggeUserLabel.Text = "User";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(409, 22);
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
            this.Controls.Add(this.LogutButton);
            this.Controls.Add(this.LoggeUserLabel);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChildForm";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogutButton;
        private System.Windows.Forms.Label LoggeUserLabel;
        private System.Windows.Forms.Label label18;
    }
}