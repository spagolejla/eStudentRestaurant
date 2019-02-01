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
using eStudentRestaurant_API.Models;
using System.Net.Http;
using eStudentRestaurant_UI.Util;
using System.Configuration;
using Menu = eStudentRestaurant_API.Models.Menu;

namespace eStudentRestaurant_UI.Menus
{
    public partial class MenuEditForm : ChildDialogForm
    {
        WebAPIHelper menusService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.MenusRoutes);

        eStudentRestaurant_API.Models.Menu menuEdit;

        public MenuEditForm(eStudentRestaurant_API.Models.Menu menu)
        {
            InitializeComponent();
            menuEdit = menu;

            if (menuEdit != null)
            {
                FillForm();
            }
        }

        private void FillForm()
        {
            MenuNameInput.Text = menuEdit.Name_;
            MenuPriceInput.Text = menuEdit.Price.ToString();
            MenuDescriptionInput.Text = menuEdit.Description;
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
                Menu men = res.Content.ReadAsAsync<Menu>().Result;
                if (men.MenuID == menuEdit.MenuID)
                {
                    errorProvider.SetError(MenuNameInput, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider.SetError(MenuNameInput, Messages.name_ex_err);
                }

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

        private void EditMenuButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                menuEdit.Name_ = MenuNameInput.Text;
                menuEdit.Price = Convert.ToDecimal( MenuPriceInput.Text);
                menuEdit.Description = MenuDescriptionInput.Text;

                HttpResponseMessage rsp = menusService.PutResponse(menuEdit.MenuID, menuEdit);

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
}
