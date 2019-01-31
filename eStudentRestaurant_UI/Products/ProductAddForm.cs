using eStudentRestaurant_API.Models;
using eStudentRestaurant_UI.Main;
using eStudentRestaurant_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudentRestaurant_UI.Products
{
    public partial class ProductAddForm : ChildDialogForm
    {
        WebAPIHelper productsService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProductsRoutes);

        Product product = new Product();

        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void ChoosePictureButton_Click(object sender, EventArgs e)
        {
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                PictureInput.Text = openFileDialog.FileName;
                Image orgImage = Image.FromFile(openFileDialog.FileName);

                MemoryStream ms = new MemoryStream();
                orgImage.Save(ms, ImageFormat.Jpeg);
                product.Picture = ms.ToArray();


                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                if (orgImage.Width > resizedImgWidth)
                {
                    Image resizedImg = UIHelper.ResizeImage(orgImage, new Size(resizedImgWidth,resizedImgHeight));
                    Image croppedImg = resizedImg;

                    if (resizedImg.Width >= croppedImgWidth && resizedImg.Height >= croppedImgHeight)
                    {
                        int croppedXPosition = (resizedImg.Width - croppedImgWidth) / 2;
                        int croppedYPosition = (resizedImg.Height - croppedImgHeight) / 2;

                        croppedImg = UIHelper.CropImage(resizedImg, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                        pictureBox.Image = croppedImg;
                        ms = new MemoryStream();
                        croppedImg.Save(ms, orgImage.RawFormat);

                        product.PictureThumb = ms.ToArray();
                    }
                }

               
            }
        }

        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            product.Name_ = ProductNameInput.Text;
            product.Price = Convert.ToDecimal(PriceInput.Text);
            product.QuantityStock = Convert.ToInt32(InitialQuantityInput.Text);
            product.LastPurchaseDate = DateTime.Now;
            product.Status = true;

            HttpResponseMessage response = productsService.PostResponse(product);

            if (response.IsSuccessStatusCode)
            {
                this.Close();
                MessageBox.Show(Messages.msg_succ);

            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + ". Message: " + response.ReasonPhrase);
            }


        }

        #region Validating
        private void ProductNameInput_Validating(object sender, CancelEventArgs e)
        {
            HttpResponseMessage res = productsService.GetActionResponse("NameExist", ProductNameInput.Text);

            if (String.IsNullOrEmpty(ProductNameInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(ProductNameInput, Messages.Required_Error);
            }
            else if (ProductNameInput.TextLength > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(ProductNameInput, Messages.overflow_err);
            }
            else if (ProductNameInput.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(ProductNameInput, Messages.number_err);
            }
            else if (res.StatusCode != System.Net.HttpStatusCode.NotFound)
            {
                e.Cancel = true;
                errorProvider.SetError(ProductNameInput, Messages.name_ex_err);
            }
            else
            {
                errorProvider.SetError(ProductNameInput, "");
            }
        }

        private void PriceInput_Validating(object sender, CancelEventArgs e)
        {


            if (String.IsNullOrEmpty(PriceInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(PriceInput, Messages.Required_Error);
            }
            else if (PriceInput.TextLength > 5 || PriceInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(PriceInput, "Dozvoljeni su samo petocifreni brojevi");
            }

            else
            {
                errorProvider.SetError(PriceInput, "");
            }
        }

        private void InitialQuantityInput_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(InitialQuantityInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(InitialQuantityInput, Messages.Required_Error);
            }
            else if (InitialQuantityInput.TextLength > 5 || InitialQuantityInput.Text.Any(char.IsLetter))
            {
                e.Cancel = true;
                errorProvider.SetError(InitialQuantityInput, Messages.Error);
            }

            else
            {
                errorProvider.SetError(InitialQuantityInput, "");
            }

        }
        #endregion
    }
}
