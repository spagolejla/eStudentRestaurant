namespace eStudentRestaurant_UI.Menus
{
    partial class MenuAddForn
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
            this.AddMenuButton = new System.Windows.Forms.Button();
            this.MenuDescriptionInput = new System.Windows.Forms.RichTextBox();
            this.MenuPriceInput = new System.Windows.Forms.TextBox();
            this.MenuNameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMenuButton
            // 
            this.AddMenuButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddMenuButton.FlatAppearance.BorderSize = 0;
            this.AddMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMenuButton.ForeColor = System.Drawing.Color.White;
            this.AddMenuButton.Location = new System.Drawing.Point(208, 290);
            this.AddMenuButton.Name = "AddMenuButton";
            this.AddMenuButton.Size = new System.Drawing.Size(92, 30);
            this.AddMenuButton.TabIndex = 112;
            this.AddMenuButton.Text = "Save";
            this.AddMenuButton.UseVisualStyleBackColor = false;
            this.AddMenuButton.Click += new System.EventHandler(this.AddMenuButton_Click);
            // 
            // MenuDescriptionInput
            // 
            this.MenuDescriptionInput.Location = new System.Drawing.Point(141, 172);
            this.MenuDescriptionInput.Name = "MenuDescriptionInput";
            this.MenuDescriptionInput.Size = new System.Drawing.Size(159, 96);
            this.MenuDescriptionInput.TabIndex = 111;
            this.MenuDescriptionInput.Text = "";
            this.MenuDescriptionInput.Validating += new System.ComponentModel.CancelEventHandler(this.MenuDescriptionInput_Validating);
            // 
            // MenuPriceInput
            // 
            this.MenuPriceInput.Location = new System.Drawing.Point(141, 125);
            this.MenuPriceInput.Name = "MenuPriceInput";
            this.MenuPriceInput.Size = new System.Drawing.Size(159, 20);
            this.MenuPriceInput.TabIndex = 110;
            this.MenuPriceInput.Validating += new System.ComponentModel.CancelEventHandler(this.MenuPriceInput_Validating);
            // 
            // MenuNameInput
            // 
            this.MenuNameInput.Location = new System.Drawing.Point(141, 95);
            this.MenuNameInput.Name = "MenuNameInput";
            this.MenuNameInput.Size = new System.Drawing.Size(159, 20);
            this.MenuNameInput.TabIndex = 109;
            this.MenuNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.MenuNameInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(176, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 108;
            this.label6.Text = "Add Menu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 107;
            this.label9.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 106;
            this.label8.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MenuAddForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 366);
            this.Controls.Add(this.AddMenuButton);
            this.Controls.Add(this.MenuDescriptionInput);
            this.Controls.Add(this.MenuPriceInput);
            this.Controls.Add(this.MenuNameInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "MenuAddForn";
            this.Text = "MenuAddForn";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMenuButton;
        private System.Windows.Forms.RichTextBox MenuDescriptionInput;
        private System.Windows.Forms.TextBox MenuPriceInput;
        private System.Windows.Forms.TextBox MenuNameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}