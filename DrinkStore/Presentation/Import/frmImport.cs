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
        }

        // Load database to view
        private void initLoad()
        {
            importTBBindingSource.DataSource = ImportBUS.getAll();
            importBindingSource.DataSource = new Import();
            categoryBindingSource.DataSource = CategoryBUS.getAll();
            brandBindingSource.DataSource = BrandBUS.getAll();
            productBindingSource.DataSource = ProductBUS.getAll();
            dgvImport.ClearSelection();
           
        }

        // Load datbase to view without change in category and brand
        private void onLoad()
        {
            importTBBindingSource.DataSource = ImportBUS.getAll();
            productBindingSource.DataSource = new Product();
            dgvImport.ClearSelection();
        }
        private void frmImport_Load(object sender, EventArgs e)
        {
            initLoad();
        }

       

        private void grdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            importBindingSource.DataSource = importTBBindingSource.Current;
 
        }

        private void grdProduct_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ImportBUS.insert(importBindingSource.Current as Import);
            onLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ImportBUS.update(importBindingSource.Current as Import);
            onLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ImportBUS.delete(importBindingSource.Current as Import);
            onLoad();
        }

        private void cboCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCate.SelectedValue != null)
                productBindingSource.DataSource =
                    ProductBUS.searchByCategory((int)cboCate.SelectedValue);
        }

        private void cboBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboBrand.SelectedValue != null)
                productBindingSource.DataSource =
                    ProductBUS.searchByBrand((int)cboBrand.SelectedValue);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (cboProduct.SelectedValue != null)
                importTBBindingSource.DataSource =
                    ImportBUS.searchByProduct((int)cboBrand.SelectedValue);
        }

        private void frmImport_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                onLoad();
        }
    }
}
