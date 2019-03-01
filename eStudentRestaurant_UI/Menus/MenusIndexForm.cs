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
using MenuItem = eStudentRestaurant_API.Models.MenuItem;

namespace eStudentRestaurant_UI.Menus
{
    public partial class MenusIndexForm : ChildForm
    {
        private WebAPIHelper menusService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.MenusRoutes);
        WebAPIHelper menuItemsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.MenuItemsRoutes);


        private eStudentRestaurant_API.Models.Menu menu;
        List<eStudentRestaurant_API.Models.Menu> menus;

        public MenusIndexForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

        }

        private void MenusIndexForm_Load(object sender, EventArgs e)
        {
            MenuItemsGrid.AutoGenerateColumns = false;
            MenuItemsGrid.Select();
            MenuItemsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GetMenus();
        }

        private void GetMenus()
        {
         
            HttpResponseMessage response = menusService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                menus = response.Content.ReadAsAsync<List<eStudentRestaurant_API.Models.Menu>>().Result;
                if (menus.Count() > 0)
                {
                    MenusComboBox.DataSource = menus;
                    MenusComboBox.ValueMember = "MenuID";
                    MenusComboBox.DisplayMember = "Name_";
                    menu = menus[MenusComboBox.SelectedIndex];
                    FillDetails();
                }
                else
                {
                    MenuNameLabel.Text = "NO MENU";
                    MenuPriceLabel.Text = " 0.00 KM";
                    DescriptionRichBox.Text = "No menu!";
                }
               

            }
            else
            {
                MessageBox.Show("Error Code" +
               response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void FillDetails()
        {
            MenuNameLabel.Text = menu.Name_;
            DescriptionRichBox.Text = menu.Description;
            MenuPriceLabel.Text = menu.Price.ToString() + " KM";
            ActiveCheckBox.Checked = (bool)menu.Active;
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage rsp = menuItemsService.GetActionResponseIdParam("GetItemsByMenuID", menu.MenuID);
            if (rsp.IsSuccessStatusCode)
            {
                List<MenuItem_Result> menuItems = rsp.Content.ReadAsAsync<List<MenuItem_Result>>().Result;
                MenuItemsGrid.DataSource = menuItems;
            }
            else
            {
                MessageBox.Show("Error code: " + rsp.StatusCode + " Message: " + rsp.ReasonPhrase);
            }
        }

        private void MenusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            menu = menus[MenusComboBox.SelectedIndex];
            FillDetails();
        }

        private void EditMenuButton_Click(object sender, EventArgs e)
        {
            MenuEditForm frm = new MenuEditForm(menu);

            frm.ShowDialog();
            GetMenus();
        }

        private void DeleteMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete menu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                HttpResponseMessage rsp = menusService.DeleteResponse(menu.MenuID);
                GetMenus();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
         
        }

        private void AddMenuButton_Click(object sender, EventArgs e)
        {
            MenuAddForn frm = new MenuAddForn();
            frm.ShowDialog();
            GetMenus();
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {
            if (menu.MenuID == 0)
            {
                MessageBox.Show("Error! MenuID is incorrect!");
            }
            else
            {
               
                BindGrid();
            }
           
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
                    HttpResponseMessage rsp = menuItemsService.DeleteResponse(Convert.ToInt32(MenuItemsGrid.SelectedRows[0].Cells[0].Value));
                    if (rsp.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.msg_succ);
                    }
                    else
                    {
                        MessageBox.Show("Error Code" +
                        rsp.StatusCode + " : Message - " + rsp.ReasonPhrase);
                    }

                    BindGrid();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
               
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
