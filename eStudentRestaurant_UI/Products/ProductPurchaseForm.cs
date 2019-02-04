using eStudentRestaurant_API.Models;
using eStudentRestaurant_UI.Main;
using eStudentRestaurant_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudentRestaurant_UI.Products
{
    public partial class ProductPurchaseForm : ChildDialogForm
    {
        WebAPIHelper productsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProductsRoutes);

        List<Product> products;
        Product product { get; set; }

        public ProductPurchaseForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void ProductPurchaseForm_Load(object sender, EventArgs e)
        {
            #region GetProducts

            HttpResponseMessage res = productsService.GetResponse();

            if (res.IsSuccessStatusCode)
            {
                products = res.Content.ReadAsAsync<List<Product>>().Result;
                if (products.Count > 0)
                {
                    ProductsComboBox.DataSource = products;
                    ProductsComboBox.DisplayMember = "Name_";
                    ProductsComboBox.ValueMember = "ProductID";
                    product = products[ProductsComboBox.SelectedIndex];
                }
            }


            #endregion
        }

        private void SavePurchaseButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                product.LastPurchaseDate = DateTime.Now;
                product.QuantityStock +=  Convert.ToInt32(QuantityInput.Text);

                HttpResponseMessage httpResponseMessage = productsService.PutResponse(product.ProductID, product);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.msg_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" +
                    httpResponseMessage.StatusCode + " : Message - " + httpResponseMessage.ReasonPhrase);
                }
            }
        }

        private void QuantityInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(QuantityInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(QuantityInput, Messages.Required_Error);
            }
            else if (QuantityInput.TextLength > 5 || QuantityInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(QuantityInput, "Only numbers are allowed, the highest is 5-digit");
            }
            else if (Convert.ToInt32(QuantityInput.Text) <=0)
            {
                e.Cancel = true;
                errorProvider.SetError(QuantityInput, "Negative or zero values are not allowed");
            }
            else
            {
                errorProvider.SetError(QuantityInput, "");
            }
        }

        private void ProductsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (products.Count() > 0)
            {
               
                product = products[ProductsComboBox.SelectedIndex];
            }
        }
    }
}
