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
    public partial class MenuAddForn : ChildDialogForm
    {
        WebAPIHelper menusService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.MenusRoutes);

        Menu menu = new Menu();

        public MenuAddForn()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
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
                menu.Name_ = MenuNameInput.Text;
                menu.Price = Convert.ToDecimal(MenuPriceInput.Text);
                menu.Description = MenuDescriptionInput.Text;

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
}
