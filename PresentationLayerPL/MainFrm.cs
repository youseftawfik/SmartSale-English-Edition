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

namespace PresentationLayerPL
{
    public partial class MainFrm : Form
    {
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

        public MainFrm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout of the System ?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            CategoryFrm CF = new CategoryFrm();
            CF.Show();
        }

        private void btnstore_Click(object sender, EventArgs e)
        {
            StoresFrm SF = new StoresFrm();
            SF.Show();
        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {

        }

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^//
        private void MainFrm_Load(object sender, EventArgs e)
        {
            lblInfo.Text = " All Rights are Rserved to Eng:Youssef Tawfek " + "\u00a9" + " " + DateTime.Now.Year;
        }
        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MakeOrdersFrm MF = new MakeOrdersFrm();
            MF.Show();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            ProductsFrm PF = new ProductsFrm();
            PF.Show();
        }

        private void btnshoworders_Click(object sender, EventArgs e)
        {
            ShowOrdersFrm SF = new ShowOrdersFrm();
            SF.Show();
        }

        private void btnorderrefund_Click(object sender, EventArgs e)
        {
            OrderRefundFrm ORF = new OrderRefundFrm();
            ORF.Show();
        }

        private void btnallproducts_Click(object sender, EventArgs e)
        {
            AllProductsFrm AP = new AllProductsFrm();
            AP.Show();
        }

        private void Order_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
