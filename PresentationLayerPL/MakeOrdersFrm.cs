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
using DataAccessLayerDAL;
using BusinessLayer;

namespace PresentationLayerPL
{
    public partial class MakeOrdersFrm : Form
    {
        OrdersOpearationBL NewOrder = new OrdersOpearationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        ProductsOperationBL NewProduct = new ProductsOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        OrderDetailsOperationBL NewOrderDetails = new OrderDetailsOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        StoresOperationBL NewStore = new StoresOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        CustomerOperationBL NewCustomer = new CustomerOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        EmployeeOperationBL NewEmployee = new EmployeeOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        DataTable DT = new DataTable();

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
        public MakeOrdersFrm()
        {
            InitializeComponent();
            txtbarcode.Focus();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        /// <summary>
        /// Method to Create Data Table
        /// </summary>
        public void CreateTable()
        {
            DT.Columns.Add("Product ID");
            DT.Columns.Add("Product Name");
            DT.Columns.Add("Store Name");
            DT.Columns.Add("Quantity");
            DT.Columns.Add("Sell Price");
            DT.Columns.Add("Total");
            dgvorderdetails.DataSource = DT;
        }
        /// <summary>
        /// Method to resize cells in datagridview
        /// </summary>
        public void size()
        {
            this.dgvorderdetails.RowHeadersWidth = 4;
            this.dgvorderdetails.Columns[0].Width = -1;
            this.dgvorderdetails.Columns[1].Width = 70;
            this.dgvorderdetails.Columns[2].Width = 5;
            this.dgvorderdetails.Columns[3].Width = 75;
            this.dgvorderdetails.Columns[4].Width = 75;
            this.dgvorderdetails.Columns[5].Width = 170;
            this.dgvorderdetails.Columns[2].Visible = false;
            this.dgvorderdetails.BackgroundColor = Color.AliceBlue;
            this.dgvorderdetails.RowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            this.dgvorderdetails.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgvorderdetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        /// <summary>
        /// Method to clear all control after each transuction
        /// </summary>
        private void ClearControl()
        {
            txtbarcode.Text = txtproductname.Text = txtquntity.Text = txttotalprice.Text = txtStock.Text =
            txtsellprice.Text = string.Empty;
            dgvorderdetails.DataSource = null;
        }
        private void ClearControl2()
        {
            txtbarcode.Text = txtproductname.Text = txtquntity.Text = txttotalprice.Text = txtStock.Text =
            txtsellprice.Text =  string.Empty;
        }
        private void MakeOrdersFrm_Load(object sender, EventArgs e)
        {
            txtorderno.Text = NewOrder.OrderID().ToString();
            txtorderdate.Text = DateTime.Now.ToString();
            txtemployeeno.Text = (string)NewEmployee.ReadAll2();
            CreateTable();
            size();
            cmbstore.DataSource = NewStore.ReadAll();
            cmbstore.DisplayMember = "StoreName";
            cmbstore.ValueMember = "StoreID";
            cmbcustomer.DataSource = NewCustomer.ReadAll();
            cmbcustomer.DisplayMember = "CustomerName";
            cmbcustomer.ValueMember = "CustomerID";
        }
        private void txtquntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Handle the entry from the user
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            //Retriving data when the brcode scanned
            // we Enter Product ID in Barcode Until Making The GUID

            try
            {
                if (e.KeyCode == Keys.Enter & txtbarcode.Text == "")
                {
                    MessageBox.Show("Please Insert The Barcode !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (e.KeyCode == Keys.Enter & txtbarcode.Text != "")
                    {
                        ProductsBL SelectData = NewProduct.ProStoreReadByID(int.Parse(txtbarcode.Text), (int)(cmbstore.SelectedValue));
                        lblProID.Text = SelectData.ProductID.ToString();
                        txtproductname.Text = SelectData.ProductName;
                        txtStock.Text = SelectData.Stock.ToString();
                        txtsellprice.Text = SelectData.SellPrice.ToString();
                        txtquntity.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This Product is Out of Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearControl2();
            }
        }

        /// <summary>
        /// Filling table with data which came from database
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void txtquntity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter & txtquntity.Text == string.Empty)
                {
                    //if (Convert.ToInt32(txtquntity.Text) > Convert.ToInt32(txtStock.Text))
                    //{
                    MessageBox.Show("Please Insert Valid Quantity !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //} 
                }
                else
                {
                    DataRow NewRow = DT.NewRow();
                    dgvorderdetails.Columns[0].Visible = false;
                    if (e.KeyCode == Keys.Enter & txtquntity.Text != string.Empty)
                    {
                        NewRow[0] = lblProID.Text;
                        NewRow[1] = txtproductname.Text;
                        NewRow[2] = cmbstore.SelectedValue;
                        NewRow[3] = txtquntity.Text;
                        NewRow[4] = txtsellprice.Text;
                        NewRow[5] = txttotalprice.Text;
                        DT.Rows.Add(NewRow);
                        txtordertotal.Text =
                            (from DataGridViewRow R in dgvorderdetails.Rows
                             where R.Cells[4].FormattedValue.ToString() != string.Empty
                             select Convert.ToDecimal(R.Cells[4].FormattedValue)).Sum().ToString();
                        txtbarcode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Instruction to Enter quantity of product after scanning 
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void txtquntity_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtquntity.Text == string.Empty)
                {
                    //MessageBox.Show("Please Enter The Quantity !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txttotalprice.Text = (Convert.ToDecimal(txtsellprice.Text) * Convert.ToDecimal(txtquntity.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Insert - save Action for the data 
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgvorderdetails.Rows[0].Cells[0].Value) == 0)
                {
                    MessageBox.Show("No Products Selected !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int O = NewOrder.Insert(new OrdersBL
                    {
                        CustomerID = Convert.ToInt32(cmbcustomer.SelectedValue),
                        EmployeeName = txtemployeeno.Text.ToString(),
                        OrderDate = Convert.ToDateTime(txtorderdate.Text),
                        OrderTotal = Convert.ToDecimal(txtordertotal.Text)
                    });

                    for (int i = 0; i < dgvorderdetails.RowCount; i++)
                    {
                        NewOrderDetails.Insert(new OrderDetailsBL
                        {
                            OrderID = Convert.ToInt32(txtorderno.Text),
                            ProductID = Convert.ToInt32(dgvorderdetails.Rows[i].Cells[0].Value),
                            StoreID = Convert.ToInt32(dgvorderdetails.Rows[i].Cells[2].Value),
                            Quantity = Convert.ToDecimal(dgvorderdetails.Rows[i].Cells[3].Value),
                            SellPrice = Convert.ToDecimal(dgvorderdetails.Rows[i].Cells[4].Value)
                        });
                    }
                    if (O > 0)
                    {
                        MessageBox.Show("Save Sucessful", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearControl();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            ClearControl();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Opening Print Dialog
           PrintDialog PD = new PrintDialog();
            PD.ShowDialog();
        }
        private void dgvorderdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvorderdetails.Columns[0].Visible = false;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvorderdetails_KeyDown(object sender, KeyEventArgs e)
        {
            //Delete the inserted rows in datagridview
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewCell item in this.dgvorderdetails.SelectedCells)
                {
                    dgvorderdetails.Rows.RemoveAt(item.RowIndex);
                }
            }
        }
    }
}
