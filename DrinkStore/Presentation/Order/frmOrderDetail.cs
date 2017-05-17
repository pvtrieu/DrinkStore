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
    public partial class frmOrderDetail : Form
    {
        private Order order;
        public frmOrderDetail(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {

        }

        private void dgvOrderDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
