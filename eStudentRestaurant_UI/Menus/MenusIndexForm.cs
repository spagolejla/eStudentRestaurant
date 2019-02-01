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

            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage rsp = menuItemsService.GetActionResponseIdParam("GetItemsByMenuID", menu.MenuID);
            if (rsp.IsSuccessStatusCode)
            {
                List<MenuItem> menuItems = rsp.Content.ReadAsAsync<List<MenuItem>>().Result;
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
            HttpResponseMessage rsp = menusService.DeleteResponse(menu.MenuID);
            GetMenus();
        }

        private void AddMenuButton_Click(object sender, EventArgs e)
        {
            MenuAddForn frm = new MenuAddForn();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GetMenus();
            }
           
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {
            if (menu.MenuID == 0)
            {
                MessageBox.Show("Error! MenuID is incorrect!");
            }
            else
            {
                MenuItemAddForm frm = new MenuItemAddForm(menu.MenuID);
                if(frm.ShowDialog()== DialogResult.OK)
                {
                    BindGrid();
                }
            }
           
        }
    }
}
