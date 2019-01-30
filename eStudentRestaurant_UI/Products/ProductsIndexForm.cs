using eStudentRestaurant_UI.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudentRestaurant_UI.Products
{
    public partial class ProductsIndexForm : ChildForm
    {
        public ProductsIndexForm()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductAddForm frm = new ProductAddForm();

            frm.ShowDialog();
        }
    }
}
