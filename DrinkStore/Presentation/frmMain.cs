using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkStore.Designer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmProduct FormProduct = new frmProduct();
            FormProduct.TopLevel = false;
            FormProduct.AutoScroll = false;
            FormProduct.Dock = DockStyle.Fill;
            FormProduct.AutoSize = true;
            this.pnlBody.Controls.Add(FormProduct);
            FormProduct.Show();
        }

        // Form border movable
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
