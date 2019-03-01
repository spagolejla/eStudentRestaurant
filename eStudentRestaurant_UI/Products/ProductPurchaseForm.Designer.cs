namespace eStudentRestaurant_UI.Products
{
    partial class ProductPurchaseForm
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
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityInput = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SavePurchaseButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(117, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "Purchase product";
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Location = new System.Drawing.Point(134, 75);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(154, 21);
            this.ProductsComboBox.TabIndex = 80;
            this.ProductsComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductsComboBox_SelectedIndexChanged);
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(134, 120);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(154, 20);
            this.QuantityInput.TabIndex = 81;
            this.QuantityInput.Validating += new System.ComponentModel.CancelEventHandler(this.QuantityInput_Validating);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.White;
            this.ProductNameLabel.Location = new System.Drawing.Point(39, 75);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(61, 17);
            this.ProductNameLabel.TabIndex = 82;
            this.ProductNameLabel.Text = "Product:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Quantity:";
            // 
            // SavePurchaseButton
            // 
            this.SavePurchaseButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SavePurchaseButton.FlatAppearance.BorderSize = 0;
            this.SavePurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePurchaseButton.ForeColor = System.Drawing.Color.White;
            this.SavePurchaseButton.Location = new System.Drawing.Point(207, 198);
            this.SavePurchaseButton.Name = "SavePurchaseButton";
            this.SavePurchaseButton.Size = new System.Drawing.Size(81, 38);
            this.SavePurchaseButton.TabIndex = 84;
            this.SavePurchaseButton.Text = "Save";
            this.SavePurchaseButton.UseVisualStyleBackColor = false;
            this.SavePurchaseButton.Click += new System.EventHandler(this.SavePurchaseButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProductPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 278);
            this.Controls.Add(this.SavePurchaseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.ProductsComboBox);
            this.Controls.Add(this.label6);
            this.Name = "ProductPurchaseForm";
            this.Text = "ProductPurchaseForm";
            this.Load += new System.EventHandler(this.ProductPurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.TextBox QuantityInput;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SavePurchaseButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}