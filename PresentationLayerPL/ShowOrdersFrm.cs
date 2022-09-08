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

namespace PresentationLayerPL
{
    public partial class ShowOrdersFrm : Form
    {
        OrdersOpearationBL NewOrder = new OrdersOpearationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        OrderDetailsOperationBL NewOrderDetails = new OrderDetailsOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
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
        public ShowOrdersFrm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void ShowOrdersFrm_Load(object sender, EventArgs e)
        {
            // Method to read all orders in datagrifview
            dgvshoworders.DataSource = NewOrder.ReadAll();
            // Show the count of orders
            lblOrdercount.Text = "Number of Orders : " + NewOrder.OrdersCount().ToString();
            dgvshoworders.RowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dgvshoworders.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgvshoworders.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvshoworders.EnableHeadersVisualStyles = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtorderno_TextChanged(object sender, EventArgs e)
        {
            dgvshoworders.DataSource = null;
            DT.Columns.Clear();
            DT.Rows.Clear();
        }

        private void txtorderno_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtorderno.Text != string.Empty && e.KeyCode == Keys.Enter)
                {
                    OrdersBL Data = NewOrder.ReadByID(int.Parse(txtorderno.Text));
                    if (Convert.ToInt32(txtorderno.Text) != Convert.ToInt32(Data.OrderID.ToString()))
                    {
                        MessageBox.Show("Please Insert Valid Receipt No. !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lblNo.Text = Data.OrderID.ToString();
                        DT.Columns.Add("Receipt No");
                        DT.Columns.Add("Employee Name");
                        DT.Columns.Add("Client Name");
                        DT.Columns.Add("Receipt Date");
                        DT.Columns.Add("Total");
                        DataRow NewRow = DT.NewRow();
                        NewRow[0] = Data.OrderID.ToString();
                        NewRow[1] = Data.EmployeeName.ToString();
                        NewRow[2] = Data.CustomerName.ToString();
                        NewRow[3] = Data.OrderDate.ToString();
                        NewRow[4] = Data.OrderTotal.ToString();
                        DT.Rows.Add(NewRow);
                        dgvshoworders.DataSource = DT;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Receipt No. !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvshoworders_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Number = (int)dgvshoworders.Rows[e.RowIndex].Cells[0].Value;
                ShowOrderDetailsFrm SOD = new ShowOrderDetailsFrm(Number);
                SOD.ShowDialog();
            }
            catch (Exception)
            {
                int Number2 = Convert.ToInt32(lblNo.Text);
                ShowOrderDetailsFrm SOD = new ShowOrderDetailsFrm(Number2);
                SOD.ShowDialog();
            }

        }
    }
}
