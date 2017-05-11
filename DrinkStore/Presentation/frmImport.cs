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
            importTBBindingSource.DataSource = ImportBUS.getAll();
            productBindingSource.DataSource = ProductBUS.getAll();
            supplierBindingSource.DataSource = SupplierBUS.getAll();
        }

       

        private void grdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            importBindingSource.DataSource = productBindingSource.Current;
            importBindingSource.DataSource = supplierBindingSource.Current;
        }

        private void grdProduct_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
