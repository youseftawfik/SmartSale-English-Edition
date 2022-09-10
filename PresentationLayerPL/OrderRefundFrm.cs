using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PresentationLayerPL
{
    public partial class OrderRefundFrm : Form
    {
        string Con = ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString;
        OrdersOpearationBL NewOrder = new OrdersOpearationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        OrderDetailsOperationBL NewDetail = new OrderDetailsOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        OrderRefundOperationBL NewRefund = new OrderRefundOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        RefundDetailOperationBL NewRefundDetails = new RefundDetailOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        DataTable Dt = new DataTable();
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
        public OrderRefundFrm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            dgvorderDetails.BackgroundColor = Color.AliceBlue;
            dgvorderDetails.RowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dgvorderDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgvorderDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void CreateTable()
        {
            Dt.Columns.Add("Order ID");
            Dt.Columns.Add("Product ID");
            Dt.Columns.Add("Store ID");
            Dt.Columns.Add("Product Name");
            Dt.Columns.Add("Store Name");
            Dt.Columns.Add("Quantity Refunded");
            Dt.Columns.Add("Sell Price");
            Dt.Columns.Add("Total");
            dgvSalesReturn.DataSource = Dt;
        }
        public void ClearControls()
        {
            txtcustomer.Text = txtemployeeno.Text = txtorderdate.Text = txtorderno.Text = txtproductname.Text =
            txtQuantityRefund.Text = txtquntity.Text = txtsellprice.Text = txtstore.Text = txttotalprice.Text =
            string.Empty;
            dgvSalesReturn.DataSource = dgvorderDetails.DataSource = null;
        }
        private void OrderRefund_Load(object sender, EventArgs e)
        {
            txtRefundno.Text = NewRefund.RefundID().ToString();
        }
        private void txtorderno_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtorderno.Text == string.Empty && e.KeyCode == Keys.Enter)
                {
                    MessageBox.Show("Please Enter Sales Receipt Number !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtorderno.Text != string.Empty && e.KeyCode == Keys.Enter)
                    {
                        OrdersBL SelectData = NewOrder.ReadByID(int.Parse(txtorderno.Text));
                        txtorderdate.Text = SelectData.OrderDate.ToString();
                        txtemployeeno.Text = SelectData.EmployeeName;
                        txtcustomer.Text = SelectData.CustomerName;
                        //DataGridView Change Properities
                        dgvorderDetails.EnableHeadersVisualStyles = false;
                        dgvorderDetails.RowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        dgvorderDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                        dgvorderDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        //Method To Read Data by Order Number
                        using (SqlConnection con = new SqlConnection(Con))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("USP_RefundOrdersDetailsReadByID", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", int.Parse(txtorderno.Text));
                            DT.Load(cmd.ExecuteReader());
                            dgvorderDetails.DataSource = DT;
                            dgvorderDetails.Columns[0].Visible = false;
                            dgvorderDetails.Columns[1].Visible = false;
                            dgvorderDetails.Columns[2].Visible = false;
                        }
                        //Method to Add Button To DataGridView
                        DataGridViewButtonColumn Btn = new DataGridViewButtonColumn();
                        dgvorderDetails.Columns.Add(Btn);
                        Btn.HeaderText = "Refunds";
                        Btn.Name = "Refund";
                        Btn.Text = "Refund";
                        Btn.UseColumnTextForButtonValue = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Receipt Number isn't Exist !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtorderno_TextChanged(object sender, EventArgs e)
        {
            if (txtorderno.Text == string.Empty)
            {
                txtorderdate.Text = txtemployeeno.Text = txtcustomer.Text = string.Empty;
            }
        }
        /// <summary>
        ///  Method to Fill Control with Data from DataGridView
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void dgvorderdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    if (MessageBox.Show("Are you Sure To Refund This Order ?", "Cofirm Refundation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int Number1 = (int)dgvorderDetails.Rows[e.RowIndex].Cells[0].Value;
                        int Number2 = (int)dgvorderDetails.Rows[e.RowIndex].Cells[1].Value;
                        int Number3 = (int)dgvorderDetails.Rows[e.RowIndex].Cells[2].Value;
                        OrderDetailsBL Data = NewDetail.RefundReadByID(Number1, Number2, Number3);
                        lblOrderID.Text = Data.OrderID.ToString();
                        lblProductID.Text = Data.ProductID.ToString();
                        lblStoreID.Text = Data.StoreID.ToString();
                        txtproductname.Text = Data.ProductName;
                        txtstore.Text = Data.StoreName;
                        txtsellprice.Text = Data.SellPrice.ToString();
                        txtquntity.Text = Data.Quantity.ToString();
                        txttotalprice.Text = Data.TotalPrice.ToString();

                        dgvorderDetails.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        /// <summary>
        /// Method To Save Refund Details into Database
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgvorderDetails.Rows[0].Cells[0].Value) == 0)
                {
                    MessageBox.Show("No Order Selected !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int R = NewRefund.Insert(new OrderRefundBL
                    {
                        RefundDate = DateTime.Now,
                        EmployeeName = txtemployeeno.Text,
                        CustomerName = txtcustomer.Text
                    });
                    for (int i = 0; i < dgvorderDetails.RowCount - 1; i++)
                    {
                        NewDetail.Update(new OrderDetailsBL
                        {
                            OrderID = Convert.ToInt32(txtorderno.Text),
                            ProductID = Convert.ToInt32(dgvorderDetails.Rows[i].Cells[1].Value),
                            StoreID = Convert.ToInt32(dgvorderDetails.Rows[i].Cells[2].Value),
                            Quantity = Convert.ToDecimal(dgvorderDetails.Rows[i].Cells[5].Value),
                            SellPrice = Convert.ToDecimal(dgvorderDetails.Rows[i].Cells[6].Value),
                            OrderTotal = (from DataGridViewRow D in dgvorderDetails.Rows
                                          where D.Cells[7].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDecimal(D.Cells[7].FormattedValue)).Sum()
                        });
                    }

                    for (int i = 0; i < dgvSalesReturn.RowCount - 1; i++)
                    {
                        NewRefundDetails.Insert(new RefundDetailsBL
                        {
                            RefundID = Convert.ToInt32(txtRefundno.Text),
                            OrderID = Convert.ToInt32(txtorderno.Text),
                            ProductID = Convert.ToInt32(dgvSalesReturn.Rows[i].Cells[1].Value),
                            StoreID = Convert.ToInt32(dgvSalesReturn.Rows[i].Cells[2].Value),
                            Quantity = Convert.ToDecimal(dgvSalesReturn.Rows[i].Cells[5].Value),
                            SellPrice = Convert.ToDecimal(dgvSalesReturn.Rows[i].Cells[6].Value),
                        });
                    }
                    if (R > 0)
                    {
                        MessageBox.Show("Save Successful", "Confirm Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        private void txtQuantityRefund_KeyDown(object sender, KeyEventArgs e)
        {
            //Method to Add Data to DataGridView
            try
            {
                DataRow NewRow = Dt.NewRow();
                DataRow NewRow1 = DT.NewRow();
                if (e.KeyCode == Keys.Enter & txtquntity.Text != string.Empty)
                {
                    if (decimal.Parse(txtQuantityRefund.Text) == decimal.Parse(txtquntity.Text))
                    {
                        CreateTable();
                        dgvSalesReturn.DataSource = Dt;
                        dgvSalesReturn.Columns[0].Visible = false;
                        dgvSalesReturn.Columns[1].Visible = false;
                        dgvSalesReturn.Columns[2].Visible = false;
                        //DataGridView Change Properities
                        dgvSalesReturn.EnableHeadersVisualStyles = false;
                        dgvSalesReturn.RowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
                        dgvSalesReturn.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                        dgvSalesReturn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        // Method To Add Refunded Products
                        NewRow[0] = lblOrderID.Text;
                        NewRow[1] = lblProductID.Text;
                        NewRow[2] = lblStoreID.Text;
                        NewRow[3] = txtproductname.Text;
                        NewRow[4] = txtstore.Text;
                        NewRow[5] = txtQuantityRefund.Text;
                        NewRow[6] = txtsellprice.Text;
                        NewRow[7] = txttotalprice.Text;
                        Dt.Rows.Add(NewRow);
                    }
                    else
                    {
                        if (decimal.Parse(txtQuantityRefund.Text) <= decimal.Parse(txtquntity.Text))
                        {
                            // Method To Add Rest Products
                            dgvorderDetails.DataSource = DT;
                            dgvorderDetails.Columns[0].Visible = false;
                            dgvorderDetails.Columns[1].Visible = false;
                            dgvorderDetails.Columns[2].Visible = false;
                            //DataGridView Change Properities
                            dgvSalesReturn.EnableHeadersVisualStyles = false;
                            dgvSalesReturn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 135, 189);
                            dgvSalesReturn.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
                            dgvSalesReturn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            // Method To Add Products which Not Refunded
                            NewRow1[0] = lblOrderID.Text;
                            NewRow1[1] = lblProductID.Text;
                            NewRow1[2] = lblStoreID.Text;
                            NewRow1[3] = txtproductname.Text;
                            NewRow1[4] = txtstore.Text;
                            NewRow1[5] = decimal.Parse(txtquntity.Text) - decimal.Parse(txtQuantityRefund.Text);
                            NewRow1[6] = txtsellprice.Text;
                            NewRow1[7] = decimal.Parse(txtsellprice.Text) * Convert.ToDecimal(Convert.ToDecimal(txtquntity.Text) - Convert.ToDecimal(txtQuantityRefund.Text));
                            DT.Rows.Add(NewRow1);

                            // Method To Add Refunded Products
                            CreateTable();
                            dgvSalesReturn.DataSource = Dt;
                            dgvSalesReturn.Columns[0].Visible = false;
                            dgvSalesReturn.Columns[1].Visible = false;
                            dgvSalesReturn.Columns[2].Visible = false;
                            //DataGridView Change Properities
                            dgvSalesReturn.EnableHeadersVisualStyles = false;
                            dgvSalesReturn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 135, 189);
                            dgvSalesReturn.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
                            dgvSalesReturn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            // Method To Add Refunded Products
                            NewRow[0] = lblOrderID.Text;
                            NewRow[1] = lblProductID.Text;
                            NewRow[2] = lblStoreID.Text;
                            NewRow[3] = txtproductname.Text;
                            NewRow[4] = txtstore.Text;
                            NewRow[5] = txtQuantityRefund.Text;
                            NewRow[6] = txtsellprice.Text;
                            NewRow[7] = decimal.Parse(txtsellprice.Text) * decimal.Parse(txtQuantityRefund.Text);
                            Dt.Rows.Add(NewRow);
                        }
                        else
                        {
                            if (decimal.Parse(txtQuantityRefund.Text) > decimal.Parse(txtquntity.Text))
                            {
                                MessageBox.Show("The Refunded Quantity Can't Be More than Order Quantity !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
        private void txtQuantityRefund_TextChanged(object sender, EventArgs e)
        {
            //Method to change total price when choosing the quantity
            try
            {
                txttotalprice.Text = (Convert.ToDecimal(txtsellprice.Text) * Convert.ToDecimal(txtQuantityRefund.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Choose Products To Refund First !! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Method to Cancel All Process Of Refunding
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtorderno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

