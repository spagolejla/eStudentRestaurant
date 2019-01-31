namespace eStudentRestaurant_UI.Menus
{
    partial class MenusIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenusIndexForm));
            this.label1 = new System.Windows.Forms.Label();
            this.MenusComboBox = new System.Windows.Forms.ComboBox();
            this.AddMenuButton = new System.Windows.Forms.Button();
            this.SearchClientsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MenuNameLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuItemsGrid = new System.Windows.Forms.DataGridView();
            this.MenuItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Menus";
            // 
            // MenusComboBox
            // 
            this.MenusComboBox.DisplayMember = "Text";
            this.MenusComboBox.FormattingEnabled = true;
            this.MenusComboBox.Location = new System.Drawing.Point(143, 100);
            this.MenusComboBox.Name = "MenusComboBox";
            this.MenusComboBox.Size = new System.Drawing.Size(193, 21);
            this.MenusComboBox.TabIndex = 50;
            this.MenusComboBox.ValueMember = "ID";
            // 
            // AddMenuButton
            // 
            this.AddMenuButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddMenuButton.FlatAppearance.BorderSize = 0;
            this.AddMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMenuButton.ForeColor = System.Drawing.Color.White;
            this.AddMenuButton.Location = new System.Drawing.Point(462, 94);
            this.AddMenuButton.Name = "AddMenuButton";
            this.AddMenuButton.Size = new System.Drawing.Size(92, 27);
            this.AddMenuButton.TabIndex = 49;
            this.AddMenuButton.Text = "Add";
            this.AddMenuButton.UseVisualStyleBackColor = false;
            // 
            // SearchClientsLabel
            // 
            this.SearchClientsLabel.AutoSize = true;
            this.SearchClientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClientsLabel.ForeColor = System.Drawing.Color.White;
            this.SearchClientsLabel.Location = new System.Drawing.Point(28, 101);
            this.SearchClientsLabel.Name = "SearchClientsLabel";
            this.SearchClientsLabel.Size = new System.Drawing.Size(111, 17);
            this.SearchClientsLabel.TabIndex = 48;
            this.SearchClientsLabel.Text = "Choose a menu:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.MenuNameLabel);
            this.panel1.Controls.Add(this.MenuPriceLabel);
            this.panel1.Location = new System.Drawing.Point(31, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 225);
            this.panel1.TabIndex = 51;
            // 
            // MenuPriceLabel
            // 
            this.MenuPriceLabel.AutoSize = true;
            this.MenuPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPriceLabel.ForeColor = System.Drawing.Color.White;
            this.MenuPriceLabel.Location = new System.Drawing.Point(22, 183);
            this.MenuPriceLabel.Name = "MenuPriceLabel";
            this.MenuPriceLabel.Size = new System.Drawing.Size(68, 29);
            this.MenuPriceLabel.TabIndex = 44;
            this.MenuPriceLabel.Text = "8 KM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(572, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 52;
            this.button1.Text = "Edit ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(679, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 27);
            this.button2.TabIndex = 53;
            this.button2.Text = "Delete ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MenuNameLabel
            // 
            this.MenuNameLabel.AutoSize = true;
            this.MenuNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuNameLabel.ForeColor = System.Drawing.Color.White;
            this.MenuNameLabel.Location = new System.Drawing.Point(17, 14);
            this.MenuNameLabel.Name = "MenuNameLabel";
            this.MenuNameLabel.Size = new System.Drawing.Size(139, 29);
            this.MenuNameLabel.TabIndex = 55;
            this.MenuNameLabel.Text = "Menu name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(22, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(675, 114);
            this.richTextBox1.TabIndex = 56;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Menu items";
            // 
            // MenuItemsGrid
            // 
            this.MenuItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuItemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuItemID,
            this.MenuID,
            this.Name_,
            this.Quantity});
            this.MenuItemsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.MenuItemsGrid.Location = new System.Drawing.Point(31, 456);
            this.MenuItemsGrid.Name = "MenuItemsGrid";
            this.MenuItemsGrid.ReadOnly = true;
            this.MenuItemsGrid.Size = new System.Drawing.Size(243, 137);
            this.MenuItemsGrid.TabIndex = 55;
            // 
            // MenuItemID
            // 
            this.MenuItemID.DataPropertyName = "MenuItemID";
            this.MenuItemID.HeaderText = "MenuItemID";
            this.MenuItemID.Name = "MenuItemID";
            this.MenuItemID.ReadOnly = true;
            this.MenuItemID.Visible = false;
            // 
            // MenuID
            // 
            this.MenuID.DataPropertyName = "MenuID";
            this.MenuID.HeaderText = "MenuID";
            this.MenuID.Name = "MenuID";
            this.MenuID.ReadOnly = true;
            this.MenuID.Visible = false;
            // 
            // Name_
            // 
            this.Name_.DataPropertyName = "Name_";
            this.Name_.HeaderText = "Product";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // MenusIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 605);
            this.Controls.Add(this.MenuItemsGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenusComboBox);
            this.Controls.Add(this.AddMenuButton);
            this.Controls.Add(this.SearchClientsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenusIndexForm";
            this.Text = "MenusIndexForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.SearchClientsLabel, 0);
            this.Controls.SetChildIndex(this.AddMenuButton, 0);
            this.Controls.SetChildIndex(this.MenusComboBox, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.MenuItemsGrid, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MenusComboBox;
        private System.Windows.Forms.Button AddMenuButton;
        private System.Windows.Forms.Label SearchClientsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MenuPriceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MenuNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MenuItemsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}