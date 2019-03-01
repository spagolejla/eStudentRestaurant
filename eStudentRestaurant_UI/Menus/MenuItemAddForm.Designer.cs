namespace eStudentRestaurant_UI.Menus
{
    partial class MenuItemAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.AddMenuItemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.QuantityInput = new System.Windows.Forms.TextBox();
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Add Menu Item";
            // 
            // AddMenuItemButton
            // 
            this.AddMenuItemButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddMenuItemButton.FlatAppearance.BorderSize = 0;
            this.AddMenuItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMenuItemButton.ForeColor = System.Drawing.Color.White;
            this.AddMenuItemButton.Location = new System.Drawing.Point(153, 96);
            this.AddMenuItemButton.Name = "AddMenuItemButton";
            this.AddMenuItemButton.Size = new System.Drawing.Size(81, 20);
            this.AddMenuItemButton.TabIndex = 89;
            this.AddMenuItemButton.Text = "Save";
            this.AddMenuItemButton.UseVisualStyleBackColor = false;
            this.AddMenuItemButton.Click += new System.EventHandler(this.AddMenuItemButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Quantity:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.White;
            this.ProductNameLabel.Location = new System.Drawing.Point(12, 62);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(61, 17);
            this.ProductNameLabel.TabIndex = 87;
            this.ProductNameLabel.Text = "Product:";
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(83, 96);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(46, 20);
            this.QuantityInput.TabIndex = 86;
            this.QuantityInput.Validating += new System.ComponentModel.CancelEventHandler(this.QuantityInput_Validating);
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Location = new System.Drawing.Point(79, 62);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(155, 21);
            this.ProductsComboBox.TabIndex = 85;
            this.ProductsComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductsComboBox_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MenuItemAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 132);
            this.Controls.Add(this.AddMenuItemButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.ProductsComboBox);
            this.Controls.Add(this.label2);
            this.Name = "MenuItemAddForm";
            this.Text = "MenuItemAddForm";
            this.Load += new System.EventHandler(this.MenuItemAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddMenuItemButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox QuantityInput;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}