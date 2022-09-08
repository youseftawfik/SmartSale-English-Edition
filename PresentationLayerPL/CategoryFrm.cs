using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;
using DataAccessLayerDAL;

namespace PresentationLayerPL
{
    public partial class CategoryFrm : Form
    {
        CategoryOperationBL NewCategory = new CategoryOperationBL(ConfigurationManager.ConnectionStrings["AaserCon"].ConnectionString);
        public CategoryFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method to clear all control after inserting process
        /// </summary>
        private void ClearControl()
        {
            txtcategoryname.Text = rtxtDescription.Text = string.Empty;
        }
        /// <summary>
        /// Method to fill all controls with data came from database
        /// </summary>
        /// <param name="ID"> </param>
        public void UpdateProduct(int ID)
        {
            CategoryBL SelectData = NewCategory.ReadByID(ID);
            lblCategoryID.Text = SelectData.CategoryID.ToString();
            txtcategoryname.Text = SelectData.Name;
            rtxtDescription.Text = SelectData.Description;
            
        }
        private void CategoryFrm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Inserting Action To Save Data in Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcategoryname.Text == "")
                {
                    MessageBox.Show("Please Fill All Fields !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int C = NewCategory.Insert(new CategoryBL
                    {
                        Name = txtcategoryname.Text,
                        Description = rtxtDescription.Text
                    });
                    if (C > 0)
                    {
                        MessageBox.Show("Save Sucessful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControl();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        /// <summary>
        /// Method To Show Data From Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvcategory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 135, 189);
            dgvcategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            dgvcategory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvcategory.EnableHeadersVisualStyles = false;
            try
            {
                dgvcategory.DataSource = NewCategory.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvcategory.Columns[0].Visible = false;
            dgvcategory.Columns[3].Visible = false;
        }
        /// <summary>
        /// Updating Method
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCategoryID.Text != "")
                {
                    int UP = NewCategory.Update(new CategoryBL
                    {
                        CategoryID = int.Parse(lblCategoryID.Text),
                        Name = txtcategoryname.Text,
                        Description = rtxtDescription.Text
                    });
                    if (UP > 0)
                    {
                        MessageBox.Show("Update Sucessful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnShow.PerformClick();
                        ClearControl();
                    }
                }
                else
                {
                    MessageBox.Show("Please Choose Category To Update !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Number = (int)dgvcategory.Rows[e.RowIndex].Cells[0].Value;
                UpdateProduct(Number);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        ///  Deleteing Action 
        /// </summary>
        /// <param name="lblCategoryID" >ID</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCategoryID.Text == "")
                {
                    MessageBox.Show("Please Choose The Product to Delete !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (lblCategoryID.Text != "")
                    {
                        if (MessageBox.Show("Do you Want to Delete this Product ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int P = NewCategory.Delete(int.Parse(lblCategoryID.Text));
                            if (P > 0)
                            {
                                MessageBox.Show("Delete Sucessful", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnShow.PerformClick();
                                ClearControl();
                            }
                        }
                    }
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

