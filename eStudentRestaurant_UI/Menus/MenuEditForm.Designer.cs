namespace eStudentRestaurant_UI.Menus
{
    partial class MenuEditForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MenuNameInput = new System.Windows.Forms.TextBox();
            this.MenuPriceInput = new System.Windows.Forms.TextBox();
            this.MenuDescriptionInput = new System.Windows.Forms.RichTextBox();
            this.EditMenuButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 94;
            this.label9.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(62, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 93;
            this.label8.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(165, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Edit menu";
            // 
            // MenuNameInput
            // 
            this.MenuNameInput.Location = new System.Drawing.Point(130, 74);
            this.MenuNameInput.Name = "MenuNameInput";
            this.MenuNameInput.Size = new System.Drawing.Size(159, 20);
            this.MenuNameInput.TabIndex = 96;
            this.MenuNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.MenuNameInput_Validating);
            // 
            // MenuPriceInput
            // 
            this.MenuPriceInput.Location = new System.Drawing.Point(130, 104);
            this.MenuPriceInput.Name = "MenuPriceInput";
            this.MenuPriceInput.Size = new System.Drawing.Size(159, 20);
            this.MenuPriceInput.TabIndex = 97;
            this.MenuPriceInput.Validating += new System.ComponentModel.CancelEventHandler(this.MenuPriceInput_Validating);
            // 
            // MenuDescriptionInput
            // 
            this.MenuDescriptionInput.Location = new System.Drawing.Point(130, 151);
            this.MenuDescriptionInput.Name = "MenuDescriptionInput";
            this.MenuDescriptionInput.Size = new System.Drawing.Size(159, 96);
            this.MenuDescriptionInput.TabIndex = 98;
            this.MenuDescriptionInput.Text = "";
            this.MenuDescriptionInput.Validating += new System.ComponentModel.CancelEventHandler(this.MenuDescriptionInput_Validating);
            // 
            // EditMenuButton
            // 
            this.EditMenuButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditMenuButton.FlatAppearance.BorderSize = 0;
            this.EditMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditMenuButton.ForeColor = System.Drawing.Color.White;
            this.EditMenuButton.Location = new System.Drawing.Point(197, 269);
            this.EditMenuButton.Name = "EditMenuButton";
            this.EditMenuButton.Size = new System.Drawing.Size(92, 30);
            this.EditMenuButton.TabIndex = 104;
            this.EditMenuButton.Text = "Save";
            this.EditMenuButton.UseVisualStyleBackColor = false;
            this.EditMenuButton.Click += new System.EventHandler(this.EditMenuButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MenuEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 366);
            this.Controls.Add(this.EditMenuButton);
            this.Controls.Add(this.MenuDescriptionInput);
            this.Controls.Add(this.MenuPriceInput);
            this.Controls.Add(this.MenuNameInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "MenuEditForm";
            this.Text = "MenuEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MenuNameInput;
        private System.Windows.Forms.TextBox MenuPriceInput;
        private System.Windows.Forms.RichTextBox MenuDescriptionInput;
        private System.Windows.Forms.Button EditMenuButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}