namespace eStudentRestaurant_UI.Orders
{
    partial class OrderDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrderDetailsDataGrid = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(193, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Order details";
            // 
            // OrderDetailsDataGrid
            // 
            this.OrderDetailsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.Price});
            this.OrderDetailsDataGrid.Location = new System.Drawing.Point(46, 82);
            this.OrderDetailsDataGrid.Name = "OrderDetailsDataGrid";
            this.OrderDetailsDataGrid.ReadOnly = true;
            this.OrderDetailsDataGrid.Size = new System.Drawing.Size(422, 213);
            this.OrderDetailsDataGrid.TabIndex = 42;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ProcessOrderButton
            // 
            this.ProcessOrderButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ProcessOrderButton.FlatAppearance.BorderSize = 0;
            this.ProcessOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessOrderButton.ForeColor = System.Drawing.Color.White;
            this.ProcessOrderButton.Location = new System.Drawing.Point(348, 350);
            this.ProcessOrderButton.Name = "ProcessOrderButton";
            this.ProcessOrderButton.Size = new System.Drawing.Size(120, 42);
            this.ProcessOrderButton.TabIndex = 109;
            this.ProcessOrderButton.Text = "Process order";
            this.ProcessOrderButton.UseVisualStyleBackColor = false;
            this.ProcessOrderButton.Click += new System.EventHandler(this.ProcessOrderButton_Click);
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.ProcessOrderButton);
            this.Controls.Add(this.OrderDetailsDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrderDetailsDataGrid;
        private System.Windows.Forms.Button ProcessOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}