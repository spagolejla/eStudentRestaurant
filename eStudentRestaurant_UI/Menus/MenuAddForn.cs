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
using MenuItem = eStudentRestaurant_API.Models.MenuItem;

namespace eStudentRestaurant_UI.Menus
{
    public partial class MenuAddForn : ChildDialogForm
    {
        WebAPIHelper menusService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.MenusRoutes);
        WebAPIHelper productsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProductsRoutes);
        WebAPIHelper menuItemsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.MenuItemsRoutes);

        Menu menu = new Menu();
        private int id { get; set; }
        eStudentRestaurant_API.Models.MenuItem menuItem = new eStudentRestaurant_API.Models.MenuItem();
        List<MenuItemHelper> items = new List<MenuItemHelper>();

        public MenuAddForn()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            MenuItemsGrid.AutoGenerateColumns = false;
            MenuItemsGrid.Select();
            MenuItemsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        #region Validating

        private void MenuNameInput_Validating(object sender, CancelEventArgs e)
        {
            HttpResponseMessage res = menusService.GetActionResponse("NameExist", MenuNameInput.Text);

            if (String.IsNullOrEmpty(MenuNameInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(MenuNameInput, Messages.Required_Error);
            }
            else if (MenuNameInput.TextLength > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(MenuNameInput, Messages.overflow_err);
            }
            else if (MenuNameInput.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(MenuNameInput, Messages.number_err);
            }
            else if (res.StatusCode != System.Net.HttpStatusCode.NotFound)
            {


                e.Cancel = true;
                errorProvider.SetError(MenuNameInput, Messages.name_ex_err);


            }
            else
            {
                errorProvider.SetError(MenuNameInput, "");
            }
        }

        private void MenuPriceInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(MenuPriceInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(MenuPriceInput, Messages.Required_Error);
            }
            else if (MenuPriceInput.TextLength > 5 || MenuPriceInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(MenuPriceInput, "Only numbers are allowed, the highest is 5-digit");
            }

            else
            {
                errorProvider.SetError(MenuPriceInput, "");
            }
        }

        private void MenuDescriptionInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(MenuDescriptionInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(MenuDescriptionInput, Messages.Required_Error);
            }

            else
            {
                errorProvider.SetError(MenuDescriptionInput, "");
            }
        }


        #endregion

        private void AddMenuButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (items.Count()<=1)
                {
                    MessageBox.Show("Error! Not enough items in menu!");
                }
                else
                {
                    menu.Name_ = MenuNameInput.Text;
                    menu.Price = Convert.ToDecimal(MenuPriceInput.Text);
                    menu.Description = MenuDescriptionInput.Text;
                    List<MenuItem> menuItems = new List<MenuItem>();
                    foreach (var item in items)
                    {
                        menuItems.Add(new MenuItem { ProductID = item.Product.ProductID, Quantity = item.Quantity });
                    }
                    menu.MenuItem = menuItems;
                    HttpResponseMessage rsp = menusService.PostResponse(menu);

                    if (rsp.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.msg_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Code" +
                        rsp.StatusCode + " : Message - " + rsp.ReasonPhrase);
                    }
                }
             
            }
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {

            using (var form = new MenuItemAddForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MenuItemHelper addedItem = form.ReturnValue1;

                    bool exist = false;
                    foreach (var item in items)
                    {
                        if (item.ProductName == addedItem.ProductName)
                        {
                            exist = true;
                            item.Quantity += addedItem.Quantity;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        items.Add(addedItem);

                    }

                    BindGrid();


                }
            }
            BindGrid();

        }

        private void BindGrid()
        {
            List<MenuItemHelper> newItems = new List<MenuItemHelper>();
            foreach (var item in items)
            {
                newItems.Add(item);
            }
            MenuItemsGrid.DataSource = newItems;

        }

        private void DeleteMenuItemButton_Click(object sender, EventArgs e)
        {
            if (MenuItemsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error! You didnt select menu item to delete!");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete menu item", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    // .SelectedRows[0].Cells[0].Value
                    items.Remove(MenuItemsGrid.SelectedRows[0].DataBoundItem as MenuItemHelper);
                    BindGrid();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}
