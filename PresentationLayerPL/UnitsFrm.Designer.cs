namespace PresentationLayerPL
{
    partial class UnitsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitsFrm));
            this.btnadd = new System.Windows.Forms.Button();
            this.lblUnitname = new System.Windows.Forms.Label();
            this.txtunitname = new System.Windows.Forms.TextBox();
            this.cmbunittype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(267, 108);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(90, 41);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Save";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblUnitname
            // 
            this.lblUnitname.AutoSize = true;
            this.lblUnitname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitname.Location = new System.Drawing.Point(61, 22);
            this.lblUnitname.Name = "lblUnitname";
            this.lblUnitname.Size = new System.Drawing.Size(108, 24);
            this.lblUnitname.TabIndex = 6;
            this.lblUnitname.Text = "Unit Name :";
            // 
            // txtunitname
            // 
            this.txtunitname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunitname.Location = new System.Drawing.Point(178, 24);
            this.txtunitname.Name = "txtunitname";
            this.txtunitname.Size = new System.Drawing.Size(257, 27);
            this.txtunitname.TabIndex = 5;
            // 
            // cmbunittype
            // 
            this.cmbunittype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbunittype.FormattingEnabled = true;
            this.cmbunittype.Location = new System.Drawing.Point(178, 58);
            this.cmbunittype.Name = "cmbunittype";
            this.cmbunittype.Size = new System.Drawing.Size(257, 28);
            this.cmbunittype.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Unit Type Name :";
            // 
            // UnitsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(475, 162);
            this.Controls.Add(this.cmbunittype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblUnitname);
            this.Controls.Add(this.txtunitname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UnitsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnitsFrm";
            this.Load += new System.EventHandler(this.UnitsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblUnitname;
        private System.Windows.Forms.TextBox txtunitname;
        private System.Windows.Forms.ComboBox cmbunittype;
        private System.Windows.Forms.Label label4;
    }
}