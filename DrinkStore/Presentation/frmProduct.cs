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
    public partial class frmProduct : Form
    {
        
        public frmProduct()
        {
            InitializeComponent();
            productBindingSource.DataSource = new Product();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            
            productTBBindingSource.DataSource = ProductBUS.getAll();
            categoryBindingSource.DataSource = CategoryBUS.getAll();
            brandBindingSource.DataSource = BrandBUS.getAll();

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            ProductBUS.insert(productBindingSource.Current as Product);
            productTBBindingSource.DataSource = ProductBUS.getAll();
            productBindingSource.DataSource = new Product();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productBindingSource.DataSource = productTBBindingSource.Current;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductBUS.update(productBindingSource.Current as Product);
            productTBBindingSource.DataSource = ProductBUS.getAll();
            productBindingSource.DataSource = new Product();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductBUS.delete(productBindingSource.Current as Product);
            productTBBindingSource.DataSource = ProductBUS.getAll();
            productBindingSource.DataSource = new Product();
        }
    }
}
