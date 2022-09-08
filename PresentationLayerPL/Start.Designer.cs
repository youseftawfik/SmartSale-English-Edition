namespace AaserPresentationLayerPL
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PBAaserStart = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBAaserStart)).BeginInit();
            this.SuspendLayout();
            // 
            // PBAaserStart
            // 
            this.PBAaserStart.Image = global::AaserPresentationLayerPL.Properties.Resources._52029311_544575852692620_21486866683396096_n;
            this.PBAaserStart.Location = new System.Drawing.Point(0, -1);
            this.PBAaserStart.Margin = new System.Windows.Forms.Padding(4);
            this.PBAaserStart.Name = "PBAaserStart";
            this.PBAaserStart.Size = new System.Drawing.Size(681, 370);
            this.PBAaserStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBAaserStart.TabIndex = 0;
            this.PBAaserStart.TabStop = false;
            this.PBAaserStart.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 368);
            this.Controls.Add(this.PBAaserStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Start";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School";
            ((System.ComponentModel.ISupportInitialize)(this.PBAaserStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBAaserStart;
        private System.Windows.Forms.Timer timer1;
    }
}