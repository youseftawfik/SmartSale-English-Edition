using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using BusinessLayer;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PresentationLayerPL
{
    public partial class LoginFrm : Form
    {
        EmployeeOperationBL NewEmployee = new EmployeeOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);

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

        public LoginFrm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void PBAaserStart_Click(object sender, EventArgs e)
        {

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("Please Enter your Username and Password !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int LOG = (int)NewEmployee.Login(txtusername.Text, txtpassword.Text);
                    if (LOG == 1)
                    {
                        MessageBox.Show("Welcome In SmartSale System", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainFrm MF = new MainFrm();
                        MF.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is Incorrect", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtusername.Text = txtpassword.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }
    }
}
