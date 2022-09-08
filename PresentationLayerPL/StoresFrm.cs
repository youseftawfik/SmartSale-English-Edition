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
using DataAccessLayerDAL;
using System.Configuration;
using System.Data.SqlClient;

namespace PresentationLayerPL
{
    public partial class StoresFrm : Form
    {
        StoresOperationBL NewStore = new StoresOperationBL(ConfigurationManager.ConnectionStrings["AaserCon"].ConnectionString);
        public StoresFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method to clear all control after inserting process
        /// </summary>
        /// <param name="objControl"> Controls </param>
        private void ClearControl(Control objControl)
        {
            foreach (Control item in objControl.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
        }
        /// <summary>
        /// Method to count the number of product existed
        /// </summary>
        private void StoreCount()
        {
            lblnumberofstores.Text = "Number of Stores : " + NewStore.StoresCount().ToString();
        }
        /// <summary>
        /// Method to fill all controls with data came from database
        /// </summary>
        /// <param name="ID"> </param>
        public void StoreData(int ID)
        { 
            StoresBL SelectData = NewStore.ReadByID(ID);
            lblID.Text = SelectData.StoreID.ToString();
            txtStoreName.Text = SelectData.StoreName;
            txtLocation.Text = SelectData.Location;
        }
        private void StoresFrm_Load(object sender, EventArgs e)
        {
            StoreCount();
        }
        /// <summary>
        ///  Inserting Method
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStoreName.Text == "" || txtLocation.Text == "")
                {
                    MessageBox.Show("Please Fill All Fields !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int S = NewStore.Insert(new StoresBL
                    {
                        StoreName = txtStoreName.Text,
                        Location = txtLocation.Text
                    });
                    if (S > 0)
                    {
                        MessageBox.Show("Save sucessful", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StoreCount();
                        btnShow.PerformClick();
                        ClearControl(this);
                    }
                    else
                    {
                        MessageBox.Show("Save Faild !!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvStores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 135, 189);
            dgvStores.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            dgvStores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStores.EnableHeadersVisualStyles = false;
            try
            {
                dgvStores.DataSource = NewStore.ReadAll();
                dgvStores.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvStores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Number = (int)dgvStores.Rows[e.RowIndex].Cells[0].Value;
                StoreData(Number);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        ///  Deleteing Action 
        /// </summary>
        /// <param name="lblID" >ID</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text != "")
                {
                    if (MessageBox.Show("Do you Want to Delete this Store ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int D = NewStore.Delete(int.Parse(lblID.Text));
                        if (D > 0)
                        {
                            MessageBox.Show("Delete Sucessful", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnShow.PerformClick();
                            StoreCount();
                            ClearControl(this);
                        }
                    }
                }
                else
                {
                    if (lblID.Text == "")
                    {
                        MessageBox.Show("Please Choose The Store to Delete !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Updating Method
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text != "")
                {
                    if (MessageBox.Show("Do you want to Update this Store ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int U = NewStore.Update(new StoresBL
                        {
                            StoreID = int.Parse(lblID.Text),
                            StoreName = txtStoreName.Text,
                            Location = txtLocation.Text
                        });
                        if (U > 0)
                        {
                            MessageBox.Show("Update Sucessfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        btnShow.PerformClick();
                        ClearControl(this);
                    }
                }
                else
                {
                    MessageBox.Show("Please Choose The Store to Update !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
