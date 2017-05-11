using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrinkStore.Entities;
using DrinkStore.BUS;

namespace DrinkStore.Presentation
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
            importBindingSource.DataSource = new Import();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            importBindingSource.DataSource = ImportBUS.getAll();
            productBindingSource.DataSource = ProductBUS.getAll();
            supplierBindingSource.DataSource = SupplierBUS.getAll();
        }

        private void dateExpired_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportBUS.insert(importBindingSource.Current as Import);
            productBindingSource.DataSource = ImportBUS.getAll();
            importBindingSource.DataSource = new Import();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ImportBUS.update(importBindingSource.Current as Import);
            productBindingSource.DataSource = ImportBUS.getAll();
            importBindingSource.DataSource = new Import();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Do you want to cancle this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportBUS.insert(importBindingSource.Current as Import);
            productBindingSource.DataSource = ImportBUS.getAll();
            importBindingSource.DataSource = new Import();
        }

        private void grdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            importBindingSource.DataSource = productBindingSource.Current;
            importBindingSource.DataSource = supplierBindingSource.Current;
        }
    }
}
