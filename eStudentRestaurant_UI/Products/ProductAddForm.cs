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
            //try
            //{

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

                //if (orgImage.Width > resizedImgWidth)
                //{
                //    Image resizedImg = UIHelper.ResizeImage(orgImage, new Size(resizedImgWidth, resizedImgHeight));

                //    if (resizedImg.Width > croppedImgWidth && resizedImg.Height > croppedImgHeight)
                //    {
                //        int croppedXPosition = (resizedImg.Width - croppedImgWidth) / 2;
                //        int croppedYPosition = (resizedImg.Height - croppedImgHeight) / 2;

                //        Image croppedImg = UIHelper.CropImage(resizedImg, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                //        pictureBox.Image = croppedImg;

                //        MemoryStream ms = new MemoryStream();
                //        croppedImg.Save(ms, orgImage.RawFormat);

                //        product.PictureThumb = ms.ToArray();

                //    }
                //    else
                //    {
                //        MessageBox.Show(Messages.picture_war + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Messages.warning,
                //                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        product = null;
                //    }

                //}

                //    }
                //}
                //catch (Exception )
                //{

                //    product.Picture = null;
                //    product.PictureThumb = null;
                //    PictureInput.Text = null;
                //    pictureBox.Image = null;
                //}
            }
        }
    }
}
