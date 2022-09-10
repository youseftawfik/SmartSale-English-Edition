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
//
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;
using System.IO;
using System.Data.SqlTypes;
using DataAccessLayerDAL;

namespace PresentationLayerPL
{
    public partial class AllProductsFrm : Form
    {
        ProductsOperationBL NewProduct = new ProductsOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        CategoryOperationBL NewCategory = new CategoryOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        OpenFileDialog OFD = new OpenFileDialog();
        string path = (Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\index.jpg").ToString();


        public void UpdateProduct(int ID)
        {
            ProductsBL SelectData = NewProduct.ReadByID(ID);
            lblID.Text = SelectData.ProductID.ToString();
            txtProductName.Text = SelectData.ProductName;
            txtBarcode.Text = SelectData.Barcode;
            cmbcategory.SelectedValue = SelectData.CategoryID;
            nudBuyPrice.Value = (decimal)SelectData.BuyPrice;
            nudSellPrice.Value = (decimal)SelectData.SellPrice;
            nudquantity.Value = (decimal)SelectData.Alert;

            if (SelectData.Image != null)
            {
                byte[] PI = (byte[])SelectData.Image;
                PbImage.Image = Image.FromStream(new MemoryStream(PI));
            }
        }
        private void ProductCount()
        {
            lblProductCount.Text = " Number of Products " + NewProduct.ProductsCount().ToString();
        }

        public byte[] Images()
        {
            byte[] pbImage;
            FileStream FS = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader BR = new BinaryReader(FS);
            FileInfo FI = new FileInfo(path);
            return pbImage = BR.ReadBytes((int)FI.Length);
        }
        private void ClearControl()
        {
            txtBarcode.Text = txtProductName.Text = nudquantity.Text = nudBuyPrice.Text = cmbcategory.Text =
            nudSellPrice.Text = string.Empty;
            PbImage.Image = null;
        }

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

        public AllProductsFrm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            ProductCount();
        }

        private void AllProductsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvallproducts.DataSource = NewProduct.ReadAll();
                dgvallproducts.Columns[0].Visible = false;
                dgvallproducts.BackgroundColor = Color.AliceBlue;
                //dgvallproducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
                //dgvallproducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
                dgvallproducts.RowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
                dgvallproducts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                ((DataGridViewImageColumn)dgvallproducts.Columns[7]).ImageLayout = DataGridViewImageCellLayout.Stretch;
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

        private void dgvallproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbcategory.DataSource = NewCategory.ReadAll();
                cmbcategory.DisplayMember = "Name";
                cmbcategory.ValueMember = "CategoryID";
                int Number = (int)dgvallproducts.Rows[e.RowIndex].Cells[0].Value;
                UpdateProduct(Number);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text != "")
                {
                    //if (txtProductName.Text = "" || txtBarcode.Text = "" ||) 
                    //{
                    //   // MessageBox.Show("Information Modified Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    if (MessageBox.Show("Do you want to modify this product ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int UP = NewProduct.Update(new ProductsBL
                        {
                            ProductID = int.Parse(lblID.Text),
                            ProductName = txtProductName.Text,
                            CategoryID = (int)cmbcategory.SelectedValue,
                            BuyPrice = (decimal)nudBuyPrice.Value,
                            SellPrice = (decimal)nudSellPrice.Value,
                            Barcode = txtBarcode.Text,
                            Alert = (int)nudquantity.Value,
                            Image = path == null || string.IsNullOrEmpty(OFD.FileName) ? NewProduct.ReadByID(int.Parse(lblID.Text)).Image : Images()
                        });

                        if (UP > 0)
                        {
                            MessageBox.Show("Information Modified Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearControl();
                            dgvallproducts.DataSource = NewProduct.ReadAll();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Product to Modify !! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text == "")
                {
                    MessageBox.Show("Please Select Product to Delete !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (lblID.Text != "")
                    {
                        if (MessageBox.Show("Do you want to delete this product ? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int P = NewProduct.Delete(int.Parse(lblID.Text));
                            if (P > 0)
                            {
                                MessageBox.Show(" Product Deleted Sucessfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ProductCount();
                                dgvallproducts.DataSource = NewProduct.ReadAll();
                                ClearControl();
                            }
                        }
                    }
                }
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
    }
}
