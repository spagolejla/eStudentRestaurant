namespace eStudentRestaurant_UI.Products
{
    partial class ProductAddForm
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
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductNameInput = new System.Windows.Forms.TextBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.InitialQuantityInput = new System.Windows.Forms.TextBox();
            this.PictureInput = new System.Windows.Forms.TextBox();
            this.ChoosePictureButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.SaveProductButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.White;
            this.ProductNameLabel.Location = new System.Drawing.Point(52, 104);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(49, 17);
            this.ProductNameLabel.TabIndex = 43;
            this.ProductNameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Picture:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Initial quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(153, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "Add new product";
            // 
            // ProductNameInput
            // 
            this.ProductNameInput.Location = new System.Drawing.Point(168, 104);
            this.ProductNameInput.Name = "ProductNameInput";
            this.ProductNameInput.Size = new System.Drawing.Size(163, 20);
            this.ProductNameInput.TabIndex = 48;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(168, 141);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(163, 20);
            this.PriceInput.TabIndex = 49;
            // 
            // InitialQuantityInput
            // 
            this.InitialQuantityInput.Location = new System.Drawing.Point(168, 186);
            this.InitialQuantityInput.Name = "InitialQuantityInput";
            this.InitialQuantityInput.Size = new System.Drawing.Size(163, 20);
            this.InitialQuantityInput.TabIndex = 50;
            // 
            // PictureInput
            // 
            this.PictureInput.Location = new System.Drawing.Point(168, 233);
            this.PictureInput.Name = "PictureInput";
            this.PictureInput.Size = new System.Drawing.Size(163, 20);
            this.PictureInput.TabIndex = 51;
            // 
            // ChoosePictureButton
            // 
            this.ChoosePictureButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ChoosePictureButton.FlatAppearance.BorderSize = 0;
            this.ChoosePictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePictureButton.ForeColor = System.Drawing.Color.White;
            this.ChoosePictureButton.Location = new System.Drawing.Point(348, 233);
            this.ChoosePictureButton.Name = "ChoosePictureButton";
            this.ChoosePictureButton.Size = new System.Drawing.Size(81, 24);
            this.ChoosePictureButton.TabIndex = 54;
            this.ChoosePictureButton.Text = "Choose";
            this.ChoosePictureButton.UseVisualStyleBackColor = false;
            this.ChoosePictureButton.Click += new System.EventHandler(this.ChoosePictureButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(168, 271);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.TabIndex = 55;
            this.pictureBox.TabStop = false;
            // 
            // SaveProductButton
            // 
            this.SaveProductButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SaveProductButton.FlatAppearance.BorderSize = 0;
            this.SaveProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProductButton.ForeColor = System.Drawing.Color.White;
            this.SaveProductButton.Location = new System.Drawing.Point(348, 427);
            this.SaveProductButton.Name = "SaveProductButton";
            this.SaveProductButton.Size = new System.Drawing.Size(81, 38);
            this.SaveProductButton.TabIndex = 56;
            this.SaveProductButton.Text = "Save";
            this.SaveProductButton.UseVisualStyleBackColor = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 489);
            this.Controls.Add(this.SaveProductButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ChoosePictureButton);
            this.Controls.Add(this.PictureInput);
            this.Controls.Add(this.InitialQuantityInput);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.ProductNameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNameLabel);
            this.Name = "ProductAddForm";
            this.Text = "ProductAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductNameInput;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.TextBox InitialQuantityInput;
        private System.Windows.Forms.TextBox PictureInput;
        private System.Windows.Forms.Button ChoosePictureButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button SaveProductButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}