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
    public partial class StartFrm : Form
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
        public StartFrm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Method to Show entersnce pic and hide 
            this.Opacity = this.Opacity + .05;
            if (this.Opacity == 1)
            {
                this.timer1.Enabled = false;
                this.Hide();
                LoginFrm lf = new LoginFrm();
                lf.ShowDialog();
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
