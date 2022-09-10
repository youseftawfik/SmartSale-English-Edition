namespace PresentationLayerPL
{
    partial class ShowOrdersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowOrdersFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblOrdercount = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.Pheader = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblRefund = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtorderno = new System.Windows.Forms.TextBox();
            this.lblorderno = new System.Windows.Forms.Label();
            this.dgvshoworders = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshoworders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrdercount
            // 
            this.lblOrdercount.AutoSize = true;
            this.lblOrdercount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdercount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrdercount.Location = new System.Drawing.Point(12, 7);
            this.lblOrdercount.Name = "lblOrdercount";
            this.lblOrdercount.Size = new System.Drawing.Size(79, 29);
            this.lblOrdercount.TabIndex = 2;
            this.lblOrdercount.Text = "label1";
            // 
            // btnclose
            // 
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(929, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 36);
            this.btnclose.TabIndex = 42;
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Pheader
            // 
            this.Pheader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pheader.Controls.Add(this.pictureBox5);
            this.Pheader.Controls.Add(this.lblRefund);
            this.Pheader.Controls.Add(this.btnclose);
            this.Pheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pheader.Location = new System.Drawing.Point(0, 0);
            this.Pheader.Name = "Pheader";
            this.Pheader.Size = new System.Drawing.Size(974, 43);
            this.Pheader.TabIndex = 53;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(378, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 75;
            this.pictureBox5.TabStop = false;
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefund.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblRefund.Location = new System.Drawing.Point(426, 9);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRefund.Size = new System.Drawing.Size(213, 36);
            this.lblRefund.TabIndex = 53;
            this.lblRefund.Text = "Sales Receipts";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblNo);
            this.panel1.Controls.Add(this.lblOrdercount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 560);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 43);
            this.panel1.TabIndex = 54;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNo.Location = new System.Drawing.Point(448, 7);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(102, 29);
            this.lblNo.TabIndex = 3;
            this.lblNo.Text = "lblOrder";
            this.lblNo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtorderno);
            this.groupBox1.Controls.Add(this.lblorderno);
            this.groupBox1.Controls.Add(this.dgvshoworders);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 517);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // txtorderno
            // 
            this.txtorderno.BackColor = System.Drawing.Color.AliceBlue;
            this.txtorderno.Location = new System.Drawing.Point(817, 9);
            this.txtorderno.Name = "txtorderno";
            this.txtorderno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtorderno.Size = new System.Drawing.Size(141, 30);
            this.txtorderno.TabIndex = 20;
            this.txtorderno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtorderno.TextChanged += new System.EventHandler(this.txtorderno_TextChanged);
            this.txtorderno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtorderno_KeyDown);
            // 
            // lblorderno
            // 
            this.lblorderno.AutoSize = true;
            this.lblorderno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderno.Location = new System.Drawing.Point(683, 9);
            this.lblorderno.Name = "lblorderno";
            this.lblorderno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblorderno.Size = new System.Drawing.Size(158, 29);
            this.lblorderno.TabIndex = 19;
            this.lblorderno.Text = "Receipt No :";
            // 
            // dgvshoworders
            // 
            this.dgvshoworders.AllowUserToAddRows = false;
            this.dgvshoworders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvshoworders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvshoworders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvshoworders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvshoworders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvshoworders.Location = new System.Drawing.Point(6, 48);
            this.dgvshoworders.Name = "dgvshoworders";
            this.dgvshoworders.ReadOnly = true;
            this.dgvshoworders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvshoworders.RowHeadersWidth = 51;
            this.dgvshoworders.RowTemplate.Height = 24;
            this.dgvshoworders.Size = new System.Drawing.Size(968, 469);
            this.dgvshoworders.TabIndex = 4;
            this.dgvshoworders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvshoworders_CellClick_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(964, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 517);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 517);
            this.panel3.TabIndex = 64;
            // 
            // ShowOrdersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(974, 603);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pheader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowOrdersFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Receipts";
            this.Load += new System.EventHandler(this.ShowOrdersFrm_Load);
            this.Pheader.ResumeLayout(false);
            this.Pheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshoworders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblOrdercount;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel Pheader;
        private System.Windows.Forms.Label lblRefund;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvshoworders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtorderno;
        private System.Windows.Forms.Label lblorderno;
        private System.Windows.Forms.Label lblNo;
    }
}