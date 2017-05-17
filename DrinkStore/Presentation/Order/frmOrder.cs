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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            orderTBBindingSource.DataSource = OrderBUS.getAll();
            orderBindingSource.DataSource = new Order();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            OrderBUS.add(order);
            frmOrderDetail _frmDetail = new frmOrderDetail(order);
            if (_frmDetail.ShowDialog() == DialogResult.Cancel)
            {
                orderTBBindingSource.DataSource = OrderBUS.getAll();
            } 
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderBindingSource.DataSource = orderTBBindingSource.Current;
            
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            frmOrderDetail _frmDetail = new frmOrderDetail(orderBindingSource.Current as Order);
            
            if (_frmDetail.ShowDialog() == DialogResult.Cancel)
            {
                orderTBBindingSource.DataSource = OrderBUS.getAll();
            }
        }

        private void dgvOrderDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
