namespace PresentationLayerPL
{
    partial class RequestsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestsFrm));
            this.PHeader = new System.Windows.Forms.Panel();
            this.lblRequestInovice = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.gbRequestInfo = new System.Windows.Forms.GroupBox();
            this.cmbvendor = new System.Windows.Forms.ComboBox();
            this.txtemployeeno = new System.Windows.Forms.TextBox();
            this.lblvendorno = new System.Windows.Forms.Label();
            this.lblemployeeno = new System.Windows.Forms.Label();
            this.txtrequestno = new System.Windows.Forms.TextBox();
            this.txtrequestdate = new System.Windows.Forms.TextBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.lblrequestdate = new System.Windows.Forms.Label();
            this.lblRequstno = new System.Windows.Forms.Label();
            this.gbrequestdetails = new System.Windows.Forms.GroupBox();
            this.dgvorderdetails = new System.Windows.Forms.DataGridView();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtquntity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtordertotal = new System.Windows.Forms.TextBox();
            this.lblordertotal = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.PHeader.SuspendLayout();
            this.gbRequestInfo.SuspendLayout();
            this.gbrequestdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // PHeader
            // 
            this.PHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(189)))));
            this.PHeader.Controls.Add(this.lblRequestInovice);
            this.PHeader.Controls.Add(this.btnclose);
            this.PHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PHeader.Location = new System.Drawing.Point(0, 0);
            this.PHeader.Name = "PHeader";
            this.PHeader.Size = new System.Drawing.Size(800, 43);
            this.PHeader.TabIndex = 54;
            // 
            // lblRequestInovice
            // 
            this.lblRequestInovice.AutoSize = true;
            this.lblRequestInovice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestInovice.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblRequestInovice.Location = new System.Drawing.Point(287, 8);
            this.lblRequestInovice.Name = "lblRequestInovice";
            this.lblRequestInovice.Size = new System.Drawing.Size(232, 32);
            this.lblRequestInovice.TabIndex = 53;
            this.lblRequestInovice.Text = "Requests Invoice";
            // 
            // btnclose
            // 
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(753, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 39);
            this.btnclose.TabIndex = 52;
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // gbRequestInfo
            // 
            this.gbRequestInfo.Controls.Add(this.cmbvendor);
            this.gbRequestInfo.Controls.Add(this.txtemployeeno);
            this.gbRequestInfo.Controls.Add(this.lblvendorno);
            this.gbRequestInfo.Controls.Add(this.lblemployeeno);
            this.gbRequestInfo.Controls.Add(this.txtrequestno);
            this.gbRequestInfo.Controls.Add(this.txtrequestdate);
            this.gbRequestInfo.Controls.Add(this.txtbarcode);
            this.gbRequestInfo.Controls.Add(this.lblbarcode);
            this.gbRequestInfo.Controls.Add(this.lblrequestdate);
            this.gbRequestInfo.Controls.Add(this.lblRequstno);
            this.gbRequestInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRequestInfo.Location = new System.Drawing.Point(2, 47);
            this.gbRequestInfo.Name = "gbRequestInfo";
            this.gbRequestInfo.Size = new System.Drawing.Size(798, 159);
            this.gbRequestInfo.TabIndex = 55;
            this.gbRequestInfo.TabStop = false;
            this.gbRequestInfo.Text = "Request Information";
            this.gbRequestInfo.Enter += new System.EventHandler(this.gbRequestInfo_Enter);
            // 
            // cmbvendor
            // 
            this.cmbvendor.FormattingEnabled = true;
            this.cmbvendor.Location = new System.Drawing.Point(566, 72);
            this.cmbvendor.Name = "cmbvendor";
            this.cmbvendor.Size = new System.Drawing.Size(223, 37);
            this.cmbvendor.TabIndex = 10;
            // 
            // txtemployeeno
            // 
            this.txtemployeeno.Location = new System.Drawing.Point(566, 28);
            this.txtemployeeno.Name = "txtemployeeno";
            this.txtemployeeno.ReadOnly = true;
            this.txtemployeeno.Size = new System.Drawing.Size(223, 34);
            this.txtemployeeno.TabIndex = 9;
            this.txtemployeeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblvendorno
            // 
            this.lblvendorno.AutoSize = true;
            this.lblvendorno.Location = new System.Drawing.Point(429, 75);
            this.lblvendorno.Name = "lblvendorno";
            this.lblvendorno.Size = new System.Drawing.Size(174, 29);
            this.lblvendorno.TabIndex = 7;
            this.lblvendorno.Text = "Vendor Name :";
            // 
            // lblemployeeno
            // 
            this.lblemployeeno.AutoSize = true;
            this.lblemployeeno.Location = new System.Drawing.Point(406, 30);
            this.lblemployeeno.Name = "lblemployeeno";
            this.lblemployeeno.Size = new System.Drawing.Size(205, 29);
            this.lblemployeeno.TabIndex = 6;
            this.lblemployeeno.Text = "Employee Name :";
            // 
            // txtrequestno
            // 
            this.txtrequestno.Location = new System.Drawing.Point(142, 29);
            this.txtrequestno.Name = "txtrequestno";
            this.txtrequestno.ReadOnly = true;
            this.txtrequestno.Size = new System.Drawing.Size(223, 34);
            this.txtrequestno.TabIndex = 5;
            this.txtrequestno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtrequestdate
            // 
            this.txtrequestdate.Location = new System.Drawing.Point(142, 75);
            this.txtrequestdate.Name = "txtrequestdate";
            this.txtrequestdate.ReadOnly = true;
            this.txtrequestdate.Size = new System.Drawing.Size(223, 34);
            this.txtrequestdate.TabIndex = 4;
            this.txtrequestdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(142, 119);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(223, 34);
            this.txtbarcode.TabIndex = 0;
            this.txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Location = new System.Drawing.Point(55, 124);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(116, 29);
            this.lblbarcode.TabIndex = 2;
            this.lblbarcode.Text = "Barcode :";
            // 
            // lblrequestdate
            // 
            this.lblrequestdate.AutoSize = true;
            this.lblrequestdate.Location = new System.Drawing.Point(12, 80);
            this.lblrequestdate.Name = "lblrequestdate";
            this.lblrequestdate.Size = new System.Drawing.Size(171, 29);
            this.lblrequestdate.TabIndex = 1;
            this.lblrequestdate.Text = "Request Date :";
            // 
            // lblRequstno
            // 
            this.lblRequstno.AutoSize = true;
            this.lblRequstno.Location = new System.Drawing.Point(26, 34);
            this.lblRequstno.Name = "lblRequstno";
            this.lblRequstno.Size = new System.Drawing.Size(153, 29);
            this.lblRequstno.TabIndex = 0;
            this.lblRequstno.Text = "Request No :";
            // 
            // gbrequestdetails
            // 
            this.gbrequestdetails.Controls.Add(this.dgvorderdetails);
            this.gbrequestdetails.Controls.Add(this.txttotalprice);
            this.gbrequestdetails.Controls.Add(this.lbltotal);
            this.gbrequestdetails.Controls.Add(this.txtquntity);
            this.gbrequestdetails.Controls.Add(this.label7);
            this.gbrequestdetails.Controls.Add(this.txtsellprice);
            this.gbrequestdetails.Controls.Add(this.label6);
            this.gbrequestdetails.Controls.Add(this.txtproductname);
            this.gbrequestdetails.Controls.Add(this.label4);
            this.gbrequestdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrequestdetails.Location = new System.Drawing.Point(2, 209);
            this.gbrequestdetails.Name = "gbrequestdetails";
            this.gbrequestdetails.Size = new System.Drawing.Size(798, 378);
            this.gbrequestdetails.TabIndex = 56;
            this.gbrequestdetails.TabStop = false;
            this.gbrequestdetails.Text = "Request Details";
            // 
            // dgvorderdetails
            // 
            this.dgvorderdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvorderdetails.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvorderdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvorderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderdetails.ColumnHeadersVisible = false;
            this.dgvorderdetails.Location = new System.Drawing.Point(6, 97);
            this.dgvorderdetails.Name = "dgvorderdetails";
            this.dgvorderdetails.RowTemplate.Height = 24;
            this.dgvorderdetails.Size = new System.Drawing.Size(789, 275);
            this.dgvorderdetails.TabIndex = 29;
            // 
            // txttotalprice
            // 
            this.txttotalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalprice.Location = new System.Drawing.Point(617, 63);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.ReadOnly = true;
            this.txttotalprice.Size = new System.Drawing.Size(173, 34);
            this.txttotalprice.TabIndex = 28;
            this.txttotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Location = new System.Drawing.Point(617, 28);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(173, 36);
            this.lbltotal.TabIndex = 27;
            this.lbltotal.Text = "Total";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtquntity
            // 
            this.txtquntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquntity.Location = new System.Drawing.Point(206, 63);
            this.txtquntity.Name = "txtquntity";
            this.txtquntity.Size = new System.Drawing.Size(107, 34);
            this.txtquntity.TabIndex = 0;
            this.txtquntity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(206, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 36);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsellprice
            // 
            this.txtsellprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsellprice.Location = new System.Drawing.Point(426, 63);
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.ReadOnly = true;
            this.txtsellprice.Size = new System.Drawing.Size(192, 34);
            this.txtsellprice.TabIndex = 22;
            this.txtsellprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(426, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 36);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sell Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtproductname
            // 
            this.txtproductname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproductname.Location = new System.Drawing.Point(17, 63);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(190, 34);
            this.txtproductname.TabIndex = 18;
            this.txtproductname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Product Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(305, 654);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(125, 40);
            this.btndelete.TabIndex = 61;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.Location = new System.Drawing.Point(193, 654);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 40);
            this.btnsave.TabIndex = 60;
            this.btnsave.Text = "Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(436, 653);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 40);
            this.btnPrint.TabIndex = 59;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtordertotal
            // 
            this.txtordertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtordertotal.Location = new System.Drawing.Point(594, 593);
            this.txtordertotal.Name = "txtordertotal";
            this.txtordertotal.ReadOnly = true;
            this.txtordertotal.Size = new System.Drawing.Size(185, 34);
            this.txtordertotal.TabIndex = 58;
            this.txtordertotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblordertotal
            // 
            this.lblordertotal.AutoSize = true;
            this.lblordertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordertotal.Location = new System.Drawing.Point(462, 595);
            this.lblordertotal.Name = "lblordertotal";
            this.lblordertotal.Size = new System.Drawing.Size(176, 29);
            this.lblordertotal.TabIndex = 57;
            this.lblordertotal.Text = "Request Total :";
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
            // RequestsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 705);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtordertotal);
            this.Controls.Add(this.lblordertotal);
            this.Controls.Add(this.gbrequestdetails);
            this.Controls.Add(this.gbRequestInfo);
            this.Controls.Add(this.PHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestsFrm";
            this.PHeader.ResumeLayout(false);
            this.PHeader.PerformLayout();
            this.gbRequestInfo.ResumeLayout(false);
            this.gbRequestInfo.PerformLayout();
            this.gbrequestdetails.ResumeLayout(false);
            this.gbrequestdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PHeader;
        private System.Windows.Forms.Label lblRequestInovice;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox gbRequestInfo;
        private System.Windows.Forms.ComboBox cmbvendor;
        private System.Windows.Forms.TextBox txtemployeeno;
        private System.Windows.Forms.Label lblvendorno;
        private System.Windows.Forms.Label lblemployeeno;
        private System.Windows.Forms.TextBox txtrequestno;
        private System.Windows.Forms.TextBox txtrequestdate;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.Label lblrequestdate;
        private System.Windows.Forms.Label lblRequstno;
        private System.Windows.Forms.GroupBox gbrequestdetails;
        private System.Windows.Forms.DataGridView dgvorderdetails;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtquntity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsellprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtordertotal;
        private System.Windows.Forms.Label lblordertotal;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}