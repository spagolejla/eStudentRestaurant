namespace eStudentRestaurant_UI.Products
{
    partial class ProductsIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsIndexForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastPurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SearchProductsButton = new System.Windows.Forms.Button();
            this.SearchProductsInput = new System.Windows.Forms.TextBox();
            this.SearchStudentsLabel = new System.Windows.Forms.Label();
            this.EditProductButton = new System.Windows.Forms.Button();
            this.PurchaseProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Products";
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.ForeColor = System.Drawing.Color.White;
            this.AddProductButton.Location = new System.Drawing.Point(466, 85);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(92, 27);
            this.AddProductButton.TabIndex = 45;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Name_,
            this.Price,
            this.LastPurchaseDate,
            this.Quantity,
            this.Status});
            this.ProductsDataGrid.Location = new System.Drawing.Point(43, 134);
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.ReadOnly = true;
            this.ProductsDataGrid.Size = new System.Drawing.Size(637, 385);
            this.ProductsDataGrid.TabIndex = 46;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // Name_
            // 
            this.Name_.DataPropertyName = "Name_";
            this.Name_.HeaderText = "Name_";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // LastPurchaseDate
            // 
            this.LastPurchaseDate.DataPropertyName = "LastPurchaseDate";
            this.LastPurchaseDate.HeaderText = "Last purchase";
            this.LastPurchaseDate.Name = "LastPurchaseDate";
            this.LastPurchaseDate.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "QuantityStock";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // SearchProductsButton
            // 
            this.SearchProductsButton.FlatAppearance.BorderSize = 0;
            this.SearchProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchProductsButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchProductsButton.Image")));
            this.SearchProductsButton.Location = new System.Drawing.Point(371, 91);
            this.SearchProductsButton.Name = "SearchProductsButton";
            this.SearchProductsButton.Size = new System.Drawing.Size(30, 21);
            this.SearchProductsButton.TabIndex = 49;
            this.SearchProductsButton.UseVisualStyleBackColor = true;
            this.SearchProductsButton.Click += new System.EventHandler(this.SearchProductsButton_Click);
            // 
            // SearchProductsInput
            // 
            this.SearchProductsInput.Location = new System.Drawing.Point(99, 92);
            this.SearchProductsInput.Name = "SearchProductsInput";
            this.SearchProductsInput.Size = new System.Drawing.Size(266, 20);
            this.SearchProductsInput.TabIndex = 48;
            // 
            // SearchStudentsLabel
            // 
            this.SearchStudentsLabel.AutoSize = true;
            this.SearchStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudentsLabel.ForeColor = System.Drawing.Color.White;
            this.SearchStudentsLabel.Location = new System.Drawing.Point(40, 92);
            this.SearchStudentsLabel.Name = "SearchStudentsLabel";
            this.SearchStudentsLabel.Size = new System.Drawing.Size(53, 17);
            this.SearchStudentsLabel.TabIndex = 47;
            this.SearchStudentsLabel.Text = "Search";
            // 
            // EditProductButton
            // 
            this.EditProductButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditProductButton.FlatAppearance.BorderSize = 0;
            this.EditProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProductButton.ForeColor = System.Drawing.Color.White;
            this.EditProductButton.Location = new System.Drawing.Point(588, 85);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(92, 27);
            this.EditProductButton.TabIndex = 50;
            this.EditProductButton.Text = "Edit Product";
            this.EditProductButton.UseVisualStyleBackColor = false;
            // 
            // PurchaseProductButton
            // 
            this.PurchaseProductButton.BackColor = System.Drawing.Color.SteelBlue;
            this.PurchaseProductButton.FlatAppearance.BorderSize = 0;
            this.PurchaseProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseProductButton.ForeColor = System.Drawing.Color.White;
            this.PurchaseProductButton.Location = new System.Drawing.Point(43, 548);
            this.PurchaseProductButton.Name = "PurchaseProductButton";
            this.PurchaseProductButton.Size = new System.Drawing.Size(120, 36);
            this.PurchaseProductButton.TabIndex = 51;
            this.PurchaseProductButton.Text = "Purchase products";
            this.PurchaseProductButton.UseVisualStyleBackColor = false;
            // 
            // ProductsIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 605);
            this.Controls.Add(this.PurchaseProductButton);
            this.Controls.Add(this.EditProductButton);
            this.Controls.Add(this.SearchProductsButton);
            this.Controls.Add(this.SearchProductsInput);
            this.Controls.Add(this.SearchStudentsLabel);
            this.Controls.Add(this.ProductsDataGrid);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label1);
            this.Name = "ProductsIndexForm";
            this.Text = "ProductsIndexForm";
            this.Load += new System.EventHandler(this.ProductsIndexForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.AddProductButton, 0);
            this.Controls.SetChildIndex(this.ProductsDataGrid, 0);
            this.Controls.SetChildIndex(this.SearchStudentsLabel, 0);
            this.Controls.SetChildIndex(this.SearchProductsInput, 0);
            this.Controls.SetChildIndex(this.SearchProductsButton, 0);
            this.Controls.SetChildIndex(this.EditProductButton, 0);
            this.Controls.SetChildIndex(this.PurchaseProductButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.Button SearchProductsButton;
        private System.Windows.Forms.TextBox SearchProductsInput;
        private System.Windows.Forms.Label SearchStudentsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastPurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.Button EditProductButton;
        private System.Windows.Forms.Button PurchaseProductButton;
    }
}