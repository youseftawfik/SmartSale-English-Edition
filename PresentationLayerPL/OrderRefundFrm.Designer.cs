namespace PresentationLayerPL
{
    partial class OrderRefundFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRefundFrm));
            this.gborderInformation = new System.Windows.Forms.GroupBox();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtorderdate = new System.Windows.Forms.TextBox();
            this.lblorderdate = new System.Windows.Forms.Label();
            this.lblcustomerno = new System.Windows.Forms.Label();
            this.txtemployeeno = new System.Windows.Forms.TextBox();
            this.txtorderno = new System.Windows.Forms.TextBox();
            this.txtRefundno = new System.Windows.Forms.TextBox();
            this.lblRefundno = new System.Windows.Forms.Label();
            this.lblemployeeno = new System.Windows.Forms.Label();
            this.lblorderno = new System.Windows.Forms.Label();
            this.gborderdetails = new System.Windows.Forms.GroupBox();
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtquntity = new System.Windows.Forms.TextBox();
            this.txtQuantityRefund = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstore = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvorderDetails = new System.Windows.Forms.DataGridView();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.gbsalesReturn = new System.Windows.Forms.GroupBox();
            this.dgvSalesReturn = new System.Windows.Forms.DataGridView();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblStoreID = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PHeader = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblOrderInvoice = new System.Windows.Forms.Label();
            this.gborderInformation.SuspendLayout();
            this.gborderdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderDetails)).BeginInit();
            this.gbsalesReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).BeginInit();
            this.panel1.SuspendLayout();
            this.PHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gborderInformation
            // 
            this.gborderInformation.BackColor = System.Drawing.Color.Gainsboro;
            this.gborderInformation.Controls.Add(this.txtcustomer);
            this.gborderInformation.Controls.Add(this.txtorderdate);
            this.gborderInformation.Controls.Add(this.lblorderdate);
            this.gborderInformation.Controls.Add(this.lblcustomerno);
            this.gborderInformation.Controls.Add(this.txtemployeeno);
            this.gborderInformation.Controls.Add(this.txtorderno);
            this.gborderInformation.Controls.Add(this.txtRefundno);
            this.gborderInformation.Controls.Add(this.lblRefundno);
            this.gborderInformation.Controls.Add(this.lblemployeeno);
            this.gborderInformation.Controls.Add(this.lblorderno);
            this.gborderInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gborderInformation.Location = new System.Drawing.Point(18, 53);
            this.gborderInformation.Name = "gborderInformation";
            this.gborderInformation.Size = new System.Drawing.Size(1164, 129);
            this.gborderInformation.TabIndex = 1;
            this.gborderInformation.TabStop = false;
            this.gborderInformation.Text = "بيانات فاتورة المبيعات :";
            // 
            // txtcustomer
            // 
            this.txtcustomer.Enabled = false;
            this.txtcustomer.Location = new System.Drawing.Point(773, 71);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.ReadOnly = true;
            this.txtcustomer.Size = new System.Drawing.Size(223, 34);
            this.txtcustomer.TabIndex = 4;
            this.txtcustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtorderdate
            // 
            this.txtorderdate.Enabled = false;
            this.txtorderdate.Location = new System.Drawing.Point(393, 31);
            this.txtorderdate.Name = "txtorderdate";
            this.txtorderdate.ReadOnly = true;
            this.txtorderdate.Size = new System.Drawing.Size(223, 34);
            this.txtorderdate.TabIndex = 1;
            this.txtorderdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblorderdate
            // 
            this.lblorderdate.AutoSize = true;
            this.lblorderdate.Location = new System.Drawing.Point(622, 34);
            this.lblorderdate.Name = "lblorderdate";
            this.lblorderdate.Size = new System.Drawing.Size(147, 29);
            this.lblorderdate.TabIndex = 1;
            this.lblorderdate.Text = "تاريخ الفاتورة :";
            // 
            // lblcustomerno
            // 
            this.lblcustomerno.AutoSize = true;
            this.lblcustomerno.Location = new System.Drawing.Point(1002, 74);
            this.lblcustomerno.Name = "lblcustomerno";
            this.lblcustomerno.Size = new System.Drawing.Size(115, 29);
            this.lblcustomerno.TabIndex = 7;
            this.lblcustomerno.Text = "اسم العميل :";
            // 
            // txtemployeeno
            // 
            this.txtemployeeno.Enabled = false;
            this.txtemployeeno.Location = new System.Drawing.Point(393, 71);
            this.txtemployeeno.Name = "txtemployeeno";
            this.txtemployeeno.ReadOnly = true;
            this.txtemployeeno.Size = new System.Drawing.Size(223, 34);
            this.txtemployeeno.TabIndex = 5;
            this.txtemployeeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtorderno
            // 
            this.txtorderno.BackColor = System.Drawing.Color.AliceBlue;
            this.txtorderno.Location = new System.Drawing.Point(773, 31);
            this.txtorderno.Name = "txtorderno";
            this.txtorderno.Size = new System.Drawing.Size(223, 34);
            this.txtorderno.TabIndex = 0;
            this.txtorderno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtorderno.TextChanged += new System.EventHandler(this.txtorderno_TextChanged);
            this.txtorderno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtorderno_KeyDown);
            this.txtorderno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtorderno_KeyPress);
            // 
            // txtRefundno
            // 
            this.txtRefundno.Enabled = false;
            this.txtRefundno.Location = new System.Drawing.Point(30, 31);
            this.txtRefundno.Name = "txtRefundno";
            this.txtRefundno.ReadOnly = true;
            this.txtRefundno.Size = new System.Drawing.Size(223, 34);
            this.txtRefundno.TabIndex = 2;
            this.txtRefundno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRefundno
            // 
            this.lblRefundno.AutoSize = true;
            this.lblRefundno.Location = new System.Drawing.Point(259, 34);
            this.lblRefundno.Name = "lblRefundno";
            this.lblRefundno.Size = new System.Drawing.Size(131, 29);
            this.lblRefundno.TabIndex = 2;
            this.lblRefundno.Text = "رقم المرتجع :";
            // 
            // lblemployeeno
            // 
            this.lblemployeeno.AutoSize = true;
            this.lblemployeeno.Location = new System.Drawing.Point(622, 74);
            this.lblemployeeno.Name = "lblemployeeno";
            this.lblemployeeno.Size = new System.Drawing.Size(131, 29);
            this.lblemployeeno.TabIndex = 6;
            this.lblemployeeno.Text = "اسم الموظف :";
            // 
            // lblorderno
            // 
            this.lblorderno.AutoSize = true;
            this.lblorderno.Location = new System.Drawing.Point(1002, 34);
            this.lblorderno.Name = "lblorderno";
            this.lblorderno.Size = new System.Drawing.Size(194, 29);
            this.lblorderno.TabIndex = 0;
            this.lblorderno.Text = "رقم فاتورة المبيعات :";
            // 
            // gborderdetails
            // 
            this.gborderdetails.Controls.Add(this.txtsellprice);
            this.gborderdetails.Controls.Add(this.label6);
            this.gborderdetails.Controls.Add(this.label7);
            this.gborderdetails.Controls.Add(this.txtquntity);
            this.gborderdetails.Controls.Add(this.txtQuantityRefund);
            this.gborderdetails.Controls.Add(this.label1);
            this.gborderdetails.Controls.Add(this.label2);
            this.gborderdetails.Controls.Add(this.txtstore);
            this.gborderdetails.Controls.Add(this.txtproductname);
            this.gborderdetails.Controls.Add(this.label4);
            this.gborderdetails.Controls.Add(this.dgvorderDetails);
            this.gborderdetails.Controls.Add(this.txttotalprice);
            this.gborderdetails.Controls.Add(this.lbltotal);
            this.gborderdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gborderdetails.Location = new System.Drawing.Point(18, 188);
            this.gborderdetails.Name = "gborderdetails";
            this.gborderdetails.Size = new System.Drawing.Size(1163, 210);
            this.gborderdetails.TabIndex = 55;
            this.gborderdetails.TabStop = false;
            this.gborderdetails.Text = "تفاصيل فاتورة المبيعات :";
            // 
            // txtsellprice
            // 
            this.txtsellprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsellprice.Location = new System.Drawing.Point(203, 65);
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
            this.label6.Location = new System.Drawing.Point(203, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 36);
            this.label6.TabIndex = 69;
            this.label6.Text = "سعر البيع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(394, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 36);
            this.label7.TabIndex = 68;
            this.label7.Text = "الكمية المباعة";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtquntity
            // 
            this.txtquntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquntity.Location = new System.Drawing.Point(394, 65);
            this.txtquntity.Name = "txtquntity";
            this.txtquntity.ReadOnly = true;
            this.txtquntity.Size = new System.Drawing.Size(190, 34);
            this.txtquntity.TabIndex = 67;
            this.txtquntity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantityRefund
            // 
            this.txtQuantityRefund.BackColor = System.Drawing.Color.AliceBlue;
            this.txtQuantityRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantityRefund.Location = new System.Drawing.Point(583, 65);
            this.txtQuantityRefund.Name = "txtQuantityRefund";
            this.txtQuantityRefund.Size = new System.Drawing.Size(185, 34);
            this.txtQuantityRefund.TabIndex = 65;
            this.txtQuantityRefund.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantityRefund.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantityRefund_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(583, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 36);
            this.label1.TabIndex = 66;
            this.label1.Text = "الكمية المرتجعة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(767, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 36);
            this.label2.TabIndex = 64;
            this.label2.Text = "المخزن";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtstore
            // 
            this.txtstore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstore.Location = new System.Drawing.Point(767, 65);
            this.txtstore.Name = "txtstore";
            this.txtstore.ReadOnly = true;
            this.txtstore.Size = new System.Drawing.Size(181, 34);
            this.txtstore.TabIndex = 63;
            this.txtstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtproductname
            // 
            this.txtproductname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproductname.Location = new System.Drawing.Point(947, 65);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(171, 34);
            this.txtproductname.TabIndex = 62;
            this.txtproductname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(947, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 36);
            this.label4.TabIndex = 61;
            this.label4.Text = "اسم المنتج";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvorderDetails
            // 
            this.dgvorderDetails.AllowUserToAddRows = false;
            this.dgvorderDetails.AllowUserToDeleteRows = false;
            this.dgvorderDetails.AllowUserToOrderColumns = true;
            this.dgvorderDetails.AllowUserToResizeColumns = false;
            this.dgvorderDetails.AllowUserToResizeRows = false;
            this.dgvorderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvorderDetails.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvorderDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvorderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvorderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderDetails.Location = new System.Drawing.Point(12, 103);
            this.dgvorderDetails.Name = "dgvorderDetails";
            this.dgvorderDetails.ReadOnly = true;
            this.dgvorderDetails.RowHeadersWidth = 51;
            this.dgvorderDetails.RowTemplate.Height = 24;
            this.dgvorderDetails.Size = new System.Drawing.Size(1151, 102);
            this.dgvorderDetails.TabIndex = 0;
            this.dgvorderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorderdetails_CellContentClick);
            // 
            // txttotalprice
            // 
            this.txttotalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalprice.Location = new System.Drawing.Point(14, 65);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.ReadOnly = true;
            this.txttotalprice.Size = new System.Drawing.Size(190, 34);
            this.txttotalprice.TabIndex = 28;
            this.txttotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Location = new System.Drawing.Point(14, 30);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(190, 36);
            this.lbltotal.TabIndex = 27;
            this.lbltotal.Text = "الإجمالى";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbsalesReturn
            // 
            this.gbsalesReturn.Controls.Add(this.dgvSalesReturn);
            this.gbsalesReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsalesReturn.Location = new System.Drawing.Point(18, 404);
            this.gbsalesReturn.Name = "gbsalesReturn";
            this.gbsalesReturn.Size = new System.Drawing.Size(1164, 169);
            this.gbsalesReturn.TabIndex = 56;
            this.gbsalesReturn.TabStop = false;
            this.gbsalesReturn.Text = "تفاصيل المرتجع من المرتجع :";
            // 
            // dgvSalesReturn
            // 
            this.dgvSalesReturn.AllowUserToAddRows = false;
            this.dgvSalesReturn.AllowUserToDeleteRows = false;
            this.dgvSalesReturn.AllowUserToResizeColumns = false;
            this.dgvSalesReturn.AllowUserToResizeRows = false;
            this.dgvSalesReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesReturn.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvSalesReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSalesReturn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReturn.Location = new System.Drawing.Point(6, 33);
            this.dgvSalesReturn.Name = "dgvSalesReturn";
            this.dgvSalesReturn.RowHeadersWidth = 51;
            this.dgvSalesReturn.RowTemplate.Height = 24;
            this.dgvSalesReturn.Size = new System.Drawing.Size(1151, 130);
            this.dgvSalesReturn.TabIndex = 29;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(29, 612);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(46, 18);
            this.lblOrderID.TabIndex = 57;
            this.lblOrderID.Text = "label3";
            this.lblOrderID.Visible = false;
            // 
            // lblStoreID
            // 
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Location = new System.Drawing.Point(29, 576);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(46, 18);
            this.lblStoreID.TabIndex = 58;
            this.lblStoreID.Text = "label5";
            this.lblStoreID.Visible = false;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(29, 594);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(46, 18);
            this.lblProductID.TabIndex = 59;
            this.lblProductID.Text = "label8";
            this.lblProductID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(589, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(685, 579);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(103, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(480, 580);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 40);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblProID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 625);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 43);
            this.panel1.TabIndex = 60;
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
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 625);
            this.panel3.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1188, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 582);
            this.panel2.TabIndex = 63;
            // 
            // PHeader
            // 
            this.PHeader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PHeader.Controls.Add(this.btnclose);
            this.PHeader.Controls.Add(this.pictureBox5);
            this.PHeader.Controls.Add(this.lblOrderInvoice);
            this.PHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PHeader.Location = new System.Drawing.Point(10, 0);
            this.PHeader.Name = "PHeader";
            this.PHeader.Size = new System.Drawing.Size(1188, 43);
            this.PHeader.TabIndex = 64;
            // 
            // btnclose
            // 
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1144, 1);
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
            this.pictureBox5.Location = new System.Drawing.Point(656, 0);
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
            this.lblOrderInvoice.Location = new System.Drawing.Point(495, 8);
            this.lblOrderInvoice.Name = "lblOrderInvoice";
            this.lblOrderInvoice.Size = new System.Drawing.Size(219, 36);
            this.lblOrderInvoice.TabIndex = 53;
            this.lblOrderInvoice.Text = "فاتورة مرتجع مبيعات";
            // 
            // OrderRefundFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1198, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PHeader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblStoreID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.gbsalesReturn);
            this.Controls.Add(this.gborderdetails);
            this.Controls.Add(this.gborderInformation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderRefundFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderRefund";
            this.Load += new System.EventHandler(this.OrderRefund_Load);
            this.gborderInformation.ResumeLayout(false);
            this.gborderInformation.PerformLayout();
            this.gborderdetails.ResumeLayout(false);
            this.gborderdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderDetails)).EndInit();
            this.gbsalesReturn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PHeader.ResumeLayout(false);
            this.PHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gborderInformation;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtemployeeno;
        private System.Windows.Forms.Label lblcustomerno;
        private System.Windows.Forms.Label lblemployeeno;
        private System.Windows.Forms.TextBox txtorderno;
        private System.Windows.Forms.TextBox txtorderdate;
        private System.Windows.Forms.TextBox txtRefundno;
        private System.Windows.Forms.Label lblRefundno;
        private System.Windows.Forms.Label lblorderdate;
        private System.Windows.Forms.Label lblorderno;
        private System.Windows.Forms.GroupBox gborderdetails;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView dgvorderDetails;
        private System.Windows.Forms.GroupBox gbsalesReturn;
        private System.Windows.Forms.DataGridView dgvSalesReturn;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblStoreID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PHeader;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblOrderInvoice;
        private System.Windows.Forms.TextBox txtsellprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtquntity;
        private System.Windows.Forms.TextBox txtQuantityRefund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstore;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label4;
    }
}