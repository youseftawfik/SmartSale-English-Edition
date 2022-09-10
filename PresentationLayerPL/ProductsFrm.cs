using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;
using DataAccessLayerDAL;
using BusinessLayer;

namespace PresentationLayerPL
{
    public partial class ProductsFrm : Form
    {
        ProductsOperationBL NewProduct = new ProductsOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        CategoryOperationBL NewCategory = new CategoryOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        OpenFileDialog OFD = new OpenFileDialog();
        string path = (Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\index.jpg").ToString();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
                (
                    int nLeftRect,
                    int nTopRect,
                    int nRightRect,
                    int nBottomRect,
                    int nWidthEllipse,
                    int nHeightEllipse
                );
        private void ClearControl(Control objControl, Bitmap PictureBox = null, string PbImage = null)
        {
            foreach (Control item in objControl.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
                if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
                if (item is PictureBox && item.Name == PbImage)
                {
                    ((PictureBox)item).Image = Image.FromHbitmap(PictureBox.GetHbitmap());
                }
                if (item is RichTextBox)
                    item.Text = string.Empty;
            }
        }

        public ProductsFrm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        public byte[] Images()
        {
            byte[] pbImage;
            FileStream FS = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader BR = new BinaryReader(FS);
            FileInfo FI = new FileInfo(path);
            return pbImage = BR.ReadBytes((int)FI.Length);
        }
        private void ProductsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                lblfilenamephoto.Visible = false;
                cmbcategory.DataSource = NewCategory.ReadAll();
                cmbcategory.DisplayMember = "Name";
                cmbcategory.ValueMember = "CategoryID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = OFD.FileName;
                PbImage.ImageLocation = OFD.FileName;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ClearControl(this);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" || txtBarcode.Text == "")
                {
                    MessageBox.Show("Please Fill All The Fields !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int P = NewProduct.Insert(new ProductsBL
                    {
                        ProductName = txtProductName.Text,
                        CategoryID = (int)cmbcategory.SelectedValue,
                        BuyPrice = (decimal)nudBuyPrice.Value,
                        SellPrice = (decimal)nudSellPrice.Value,
                        Barcode = txtBarcode.Text,
                        Alert = (int)nudquantity.Value,
                        Image = Images()
                    }) ;
                    if (P > 0)
                    {
                        MessageBox.Show("Save Sucessful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControl(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
