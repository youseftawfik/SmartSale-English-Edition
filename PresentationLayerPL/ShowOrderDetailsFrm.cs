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
using DataAccessLayerDAL;

namespace PresentationLayerPL
{
    public partial class ShowOrderDetailsFrm : Form
    {
        string Con = ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString;
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
        public int x { get; set; }

        public ShowOrderDetailsFrm(int x)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            dgvshowordersdetails.BackgroundColor = Color.AliceBlue;
            dgvshowordersdetails.RowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dgvshowordersdetails.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgvshowordersdetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            using (SqlConnection con = new SqlConnection(Con))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("USP_OrdersDetailsReadByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", x);
                DT.Load(cmd.ExecuteReader());
                dgvshowordersdetails.DataSource = DT;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowOrderDetailsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvshowordersdetails.DataSource = NewOrderDetails.ReadByID(x);
            }
            catch (Exception)
            {

            }
            
        }
    }
}
