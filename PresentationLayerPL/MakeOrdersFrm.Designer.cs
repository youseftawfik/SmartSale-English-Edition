namespace PresentationLayerPL
{
    partial class MakeOrdersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeOrdersFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.cmbstore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            this.txtemployeeno = new System.Windows.Forms.TextBox();
            this.lblcustomerno = new System.Windows.Forms.Label();
            this.lblemployeeno = new System.Windows.Forms.Label();
            this.txtorderno = new System.Windows.Forms.TextBox();
            this.txtorderdate = new System.Windows.Forms.TextBox();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.lblorderdate = new System.Windows.Forms.Label();
            this.lblorderno = new System.Windows.Forms.Label();
            this.gborderdetails = new System.Windows.Forms.GroupBox();
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.txtquntity = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvorderdetails = new System.Windows.Forms.DataGridView();
            this.txtordertotal = new System.Windows.Forms.TextBox();
            this.lblordertotal = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PHeader = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblOrderInvoice = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.gborderdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdetails)).BeginInit();
            this.PHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbarcode);
            this.groupBox1.Controls.Add(this.cmbstore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbcustomer);
            this.groupBox1.Controls.Add(this.txtemployeeno);
            this.groupBox1.Controls.Add(this.lblcustomerno);
            this.groupBox1.Controls.Add(this.lblemployeeno);
            this.groupBox1.Controls.Add(this.txtorderno);
            this.groupBox1.Controls.Add(this.txtorderdate);
            this.groupBox1.Controls.Add(this.lblbarcode);
            this.groupBox1.Controls.Add(this.lblorderdate);
            this.groupBox1.Controls.Add(this.lblorderno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(403, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details :";
            // 
            // txtbarcode
            // 
            this.txtbarcode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtbarcode.Location = new System.Drawing.Point(176, 114);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(223, 34);
            this.txtbarcode.TabIndex = 0;
            this.txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbarcode_KeyDown);
            // 
            // cmbstore
            // 
            this.cmbstore.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbstore.FormattingEnabled = true;
            this.cmbstore.Location = new System.Drawing.Point(176, 237);
            this.cmbstore.Name = "cmbstore";
            this.cmbstore.Size = new System.Drawing.Size(223, 37);
            this.cmbstore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Stock No :";
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.Location = new System.Drawing.Point(176, 194);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(223, 37);
            this.cmbcustomer.TabIndex = 2;
            // 
            // txtemployeeno
            // 
            this.txtemployeeno.BackColor = System.Drawing.Color.AliceBlue;
            this.txtemployeeno.Enabled = false;
            this.txtemployeeno.Location = new System.Drawing.Point(176, 154);
            this.txtemployeeno.Name = "txtemployeeno";
            this.txtemployeeno.ReadOnly = true;
            this.txtemployeeno.Size = new System.Drawing.Size(223, 34);
            this.txtemployeeno.TabIndex = 21;
            this.txtemployeeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcustomerno
            // 
            this.lblcustomerno.AutoSize = true;
            this.lblcustomerno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerno.Location = new System.Drawing.Point(6, 198);
            this.lblcustomerno.Name = "lblcustomerno";
            this.lblcustomerno.Size = new System.Drawing.Size(171, 29);
            this.lblcustomerno.TabIndex = 20;
            this.lblcustomerno.Text = "Client Name :";
            // 
            // lblemployeeno
            // 
            this.lblemployeeno.AutoSize = true;
            this.lblemployeeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeeno.Location = new System.Drawing.Point(6, 157);
            this.lblemployeeno.Name = "lblemployeeno";
            this.lblemployeeno.Size = new System.Drawing.Size(220, 29);
            this.lblemployeeno.TabIndex = 19;
            this.lblemployeeno.Text = "Employee Name :";
            // 
            // txtorderno
            // 
            this.txtorderno.BackColor = System.Drawing.Color.AliceBlue;
            this.txtorderno.Enabled = false;
            this.txtorderno.Location = new System.Drawing.Point(176, 34);
            this.txtorderno.Name = "txtorderno";
            this.txtorderno.ReadOnly = true;
            this.txtorderno.Size = new System.Drawing.Size(223, 34);
            this.txtorderno.TabIndex = 18;
            this.txtorderno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtorderdate
            // 
            this.txtorderdate.BackColor = System.Drawing.Color.AliceBlue;
            this.txtorderdate.Enabled = false;
            this.txtorderdate.Location = new System.Drawing.Point(176, 74);
            this.txtorderdate.Name = "txtorderdate";
            this.txtorderdate.ReadOnly = true;
            this.txtorderdate.Size = new System.Drawing.Size(223, 34);
            this.txtorderdate.TabIndex = 17;
            this.txtorderdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.Location = new System.Drawing.Point(6, 117);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblbarcode.Size = new System.Drawing.Size(125, 29);
            this.lblbarcode.TabIndex = 16;
            this.lblbarcode.Text = "Barcode :";
            // 
            // lblorderdate
            // 
            this.lblorderdate.AutoSize = true;
            this.lblorderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderdate.Location = new System.Drawing.Point(6, 77);
            this.lblorderdate.Name = "lblorderdate";
            this.lblorderdate.Size = new System.Drawing.Size(178, 29);
            this.lblorderdate.TabIndex = 15;
            this.lblorderdate.Text = "Receipt Date :";
            // 
            // lblorderno
            // 
            this.lblorderno.AutoSize = true;
            this.lblorderno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderno.Location = new System.Drawing.Point(6, 34);
            this.lblorderno.Name = "lblorderno";
            this.lblorderno.Size = new System.Drawing.Size(158, 29);
            this.lblorderno.TabIndex = 14;
            this.lblorderno.Text = "Receipt No :";
            // 
            // gborderdetails
            // 
            this.gborderdetails.Controls.Add(this.txtsellprice);
            this.gborderdetails.Controls.Add(this.label6);
            this.gborderdetails.Controls.Add(this.txtStock);
            this.gborderdetails.Controls.Add(this.label1);
            this.gborderdetails.Controls.Add(this.txttotalprice);
            this.gborderdetails.Controls.Add(this.txtquntity);
            this.gborderdetails.Controls.Add(this.label7);
            this.gborderdetails.Controls.Add(this.txtproductname);
            this.gborderdetails.Controls.Add(this.lbltotal);
            this.gborderdetails.Controls.Add(this.label4);
            this.gborderdetails.Controls.Add(this.dgvorderdetails);
            this.gborderdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gborderdetails.Location = new System.Drawing.Point(409, 45);
            this.gborderdetails.Name = "gborderdetails";
            this.gborderdetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gborderdetails.Size = new System.Drawing.Size(767, 384);
            this.gborderdetails.TabIndex = 1;
            this.gborderdetails.TabStop = false;
            this.gborderdetails.Text = "Sales Details :";
            // 
            // txtsellprice
            // 
            this.txtsellprice.BackColor = System.Drawing.Color.AliceBlue;
            this.txtsellprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsellprice.Enabled = false;
            this.txtsellprice.Location = new System.Drawing.Point(396, 66);
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.ReadOnly = true;
            this.txtsellprice.Size = new System.Drawing.Size(192, 34);
            this.txtsellprice.TabIndex = 70;
            this.txtsellprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(396, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 36);
            this.label6.TabIndex = 69;
            this.label6.Text = "Sell Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.AliceBlue;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(294, 66);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(103, 34);
            this.txtStock.TabIndex = 67;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(294, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 68;
            this.label1.Text = "Stock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttotalprice
            // 
            this.txttotalprice.BackColor = System.Drawing.Color.AliceBlue;
            this.txttotalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalprice.Enabled = false;
            this.txttotalprice.Location = new System.Drawing.Point(587, 66);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.ReadOnly = true;
            this.txttotalprice.Size = new System.Drawing.Size(173, 34);
            this.txttotalprice.TabIndex = 64;
            this.txttotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtquntity
            // 
            this.txtquntity.BackColor = System.Drawing.Color.AliceBlue;
            this.txtquntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquntity.Location = new System.Drawing.Point(188, 66);
            this.txtquntity.Name = "txtquntity";
            this.txtquntity.Size = new System.Drawing.Size(107, 34);
            this.txtquntity.TabIndex = 34;
            this.txtquntity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquntity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtquntity_KeyDown);
            this.txtquntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquntity_KeyPress);
            this.txtquntity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtquntity_KeyUp);
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Location = new System.Drawing.Point(587, 31);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(173, 36);
            this.lbltotal.TabIndex = 63;
            this.lbltotal.Text = "Total";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(188, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 36);
            this.label7.TabIndex = 35;
            this.label7.Text = "Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtproductname
            // 
            this.txtproductname.BackColor = System.Drawing.Color.AliceBlue;
            this.txtproductname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproductname.Enabled = false;
            this.txtproductname.Location = new System.Drawing.Point(6, 66);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(183, 34);
            this.txtproductname.TabIndex = 33;
            this.txtproductname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "Product Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvorderdetails
            // 
            this.dgvorderdetails.AllowUserToAddRows = false;
            this.dgvorderdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvorderdetails.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvorderdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvorderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderdetails.ColumnHeadersVisible = false;
            this.dgvorderdetails.Location = new System.Drawing.Point(5, 106);
            this.dgvorderdetails.Name = "dgvorderdetails";
            this.dgvorderdetails.RowHeadersWidth = 51;
            this.dgvorderdetails.RowTemplate.Height = 24;
            this.dgvorderdetails.Size = new System.Drawing.Size(758, 275);
            this.dgvorderdetails.TabIndex = 0;
            this.dgvorderdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorderdetails_CellContentClick);
            this.dgvorderdetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvorderdetails_KeyDown);
            // 
            // txtordertotal
            // 
            this.txtordertotal.BackColor = System.Drawing.Color.AliceBlue;
            this.txtordertotal.Enabled = false;
            this.txtordertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtordertotal.Location = new System.Drawing.Point(984, 432);
            this.txtordertotal.Name = "txtordertotal";
            this.txtordertotal.ReadOnly = true;
            this.txtordertotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtordertotal.Size = new System.Drawing.Size(185, 34);
            this.txtordertotal.TabIndex = 7;
            this.txtordertotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblordertotal
            // 
            this.lblordertotal.AutoSize = true;
            this.lblordertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordertotal.Location = new System.Drawing.Point(907, 432);
            this.lblordertotal.Name = "lblordertotal";
            this.lblordertotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblordertotal.Size = new System.Drawing.Size(87, 29);
            this.lblordertotal.TabIndex = 6;
            this.lblordertotal.Text = "Total :";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PHeader
            // 
            this.PHeader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PHeader.Controls.Add(this.btnclose);
            this.PHeader.Controls.Add(this.pictureBox5);
            this.PHeader.Controls.Add(this.lblOrderInvoice);
            this.PHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PHeader.Location = new System.Drawing.Point(0, 0);
            this.PHeader.Name = "PHeader";
            this.PHeader.Size = new System.Drawing.Size(1192, 43);
            this.PHeader.TabIndex = 53;
            // 
            // btnclose
            // 
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1143, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 39);
            this.btnclose.TabIndex = 52;
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(479, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 77;
            this.pictureBox5.TabStop = false;
            // 
            // lblOrderInvoice
            // 
            this.lblOrderInvoice.AutoSize = true;
            this.lblOrderInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderInvoice.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblOrderInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOrderInvoice.Location = new System.Drawing.Point(537, 8);
            this.lblOrderInvoice.Name = "lblOrderInvoice";
            this.lblOrderInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOrderInvoice.Size = new System.Drawing.Size(198, 36);
            this.lblOrderInvoice.TabIndex = 53;
            this.lblOrderInvoice.Text = "Sales Receipt";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.AliceBlue;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(148, 432);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndelete.Size = new System.Drawing.Size(135, 40);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Cancel";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.AliceBlue;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.Location = new System.Drawing.Point(20, 432);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsave.Size = new System.Drawing.Size(122, 40);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(289, 432);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(110, 40);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblProID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 43);
            this.panel1.TabIndex = 54;
            // 
            // lblProID
            // 
            this.lblProID.AutoSize = true;
            this.lblProID.Location = new System.Drawing.Point(1141, 16);
            this.lblProID.Name = "lblProID";
            this.lblProID.Size = new System.Drawing.Size(46, 18);
            this.lblProID.TabIndex = 30;
            this.lblProID.Text = "label1";
            this.lblProID.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 442);
            this.panel3.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1182, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 442);
            this.panel2.TabIndex = 62;
            // 
            // MakeOrdersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1192, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PHeader);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtordertotal);
            this.Controls.Add(this.lblordertotal);
            this.Controls.Add(this.gborderdetails);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeOrdersFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Sales Receipt";
            this.Load += new System.EventHandler(this.MakeOrdersFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gborderdetails.ResumeLayout(false);
            this.gborderdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdetails)).EndInit();
            this.PHeader.ResumeLayout(false);
            this.PHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gborderdetails;
        private System.Windows.Forms.TextBox txtordertotal;
        private System.Windows.Forms.Label lblordertotal;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel PHeader;
        private System.Windows.Forms.Label lblOrderInvoice;
        private System.Windows.Forms.ComboBox cmbstore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.TextBox txtemployeeno;
        private System.Windows.Forms.Label lblcustomerno;
        private System.Windows.Forms.Label lblemployeeno;
        private System.Windows.Forms.TextBox txtorderno;
        private System.Windows.Forms.TextBox txtorderdate;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.Label lblorderdate;
        private System.Windows.Forms.Label lblorderno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsellprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.TextBox txtquntity;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvorderdetails;
    }
}