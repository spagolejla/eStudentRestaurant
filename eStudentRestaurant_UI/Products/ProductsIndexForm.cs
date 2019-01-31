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
    public partial class ProductsIndexForm : ChildForm
    {
        private WebAPIHelper productsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProductsRoutes);


        public ProductsIndexForm()
        {
            InitializeComponent();
            ProductsDataGrid.AutoGenerateColumns = false;
        }


        private void BindGrid()
        {
            HttpResponseMessage response = productsService.GetActionResponse("GetProductsByName", SearchProductsInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Product> products = response.Content.ReadAsAsync<List<Product>>().Result;
                if (products.Count > 0)
                {
                    ProductsDataGrid.DataSource = products;
                    ProductsDataGrid.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Error Code" +
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductAddForm frm = new ProductAddForm();

            frm.ShowDialog();
            BindGrid();
        }

        private void ProductsIndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void SearchProductsButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
