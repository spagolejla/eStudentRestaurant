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
using Menu = eStudentRestaurant_API.Models.Menu;

namespace eStudentRestaurant_UI.Menus
{
    public partial class MenuItemAddForm : ChildDialogForm
    {
        WebAPIHelper productsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProductsRoutes);
        WebAPIHelper menuItemsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.MenuItemsRoutes);

        public MenuItemHelper ReturnValue1 { get; set; }
        

        int MenuID { get; set; }
        List<Product> products;
        MenuItemHelper menuItemHelper = new MenuItemHelper();
        eStudentRestaurant_API.Models.MenuItem menuItem = new eStudentRestaurant_API.Models.MenuItem();
        public MenuItemAddForm()
        {
            InitializeComponent();
           
        }

        #region Validation

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
            else if (Convert.ToInt32(QuantityInput.Text) <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(QuantityInput, "Negative or zero values are not allowed");
            }
            else
            {
                errorProvider.SetError(QuantityInput, "");
            }
        }
        #endregion

        private void MenuItemAddForm_Load(object sender, EventArgs e)
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
                    menuItemHelper.Product = products[ProductsComboBox.SelectedIndex];
                  

                }
            }


            #endregion
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //menuItem.MenuID = MenuID;

                //menuItem.ProductID = products[ProductsComboBox.SelectedIndex].ProductID;
                //menuItem.Quantity =Convert.ToInt32(QuantityInput.Text);


                //HttpResponseMessage httpResponseMessage = menuItemsService.PostResponse(menuItem);

                //if (httpResponseMessage.IsSuccessStatusCode)
                //{
                //    MessageBox.Show(Messages.msg_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Error Code" +
                //    httpResponseMessage.StatusCode + " : Message - " + httpResponseMessage.ReasonPhrase);
                //}

                menuItemHelper.Quantity = Convert.ToInt32(QuantityInput.Text);
                menuItemHelper.ProductName = menuItemHelper.Product.Name_;
                this.ReturnValue1 = menuItemHelper;
               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ProductsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (products.Count()>0)
            {
                menuItemHelper.Product = products[ProductsComboBox.SelectedIndex];

            }

        }

       
    }
}
