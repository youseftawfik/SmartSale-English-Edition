using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using DataAccessLayerDAL;
using System.Configuration;
using System.Data.SqlClient;

namespace PresentationLayerPL
{
    public partial class UnitsFrm : Form
    {
        MeasurementTypeBL newunittype = new MeasurementTypeBL();
        MeasurementTypesOperationBL NewUnitType = new MeasurementTypesOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        UnitsBL newunit = new UnitsBL();
        UnitsOperationBL NewUnit = new UnitsOperationBL(ConfigurationManager.ConnectionStrings["SmartSaleCon"].ConnectionString);
        public UnitsFrm()
        {
            InitializeComponent();
        }
        private void UnitsFrm_Load(object sender, EventArgs e)
        {
            cmbunittype.DataSource = NewUnitType.ReadAll();
            cmbunittype.DisplayMember = "UnitTypeName";
            cmbunittype.ValueMember = "UnitTypeID";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            newunit.UnitName = txtunitname.Text;
            newunit.UnitTypeID = (int)cmbunittype.SelectedValue;
            if (txtunitname.Text == "")
            {
                MessageBox.Show("Please Enter The Unit Name !!","Information",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            else
            {
                int U = NewUnit.Insert(newunit);
                if (U > 0)
                {
                    MessageBox.Show("Save Sucessed","Confirm",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtunitname.Text = cmbunittype.Text = string.Empty;
                }
            }
        }
    }
}
