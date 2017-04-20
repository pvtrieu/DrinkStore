namespace DrinkStore.Presentation
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lineSeparator1 = new DrinkStore.Designer.LineSeparator();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblProCat = new System.Windows.Forms.Label();
            this.lblBottle = new System.Windows.Forms.Label();
            this.lblCask = new System.Windows.Forms.Label();
            this.txtCask = new System.Windows.Forms.TextBox();
            this.lblProQuant = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.grdOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBottle = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lineSeparator2 = new DrinkStore.Designer.LineSeparator();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCostField = new System.Windows.Forms.Label();
            this.lblDateField = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdOrderList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 26);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Order";
            // 
            // lineSeparator1
            // 
            this.lineSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator1.AutoSize = true;
            this.lineSeparator1.Location = new System.Drawing.Point(21, 38);
            this.lineSeparator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator1.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator1.Name = "lineSeparator1";
            this.lineSeparator1.Size = new System.Drawing.Size(560, 2);
            this.lineSeparator1.TabIndex = 28;
            // 
            // cbxCategory
            // 
            this.cbxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(428, 91);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(156, 21);
            this.cbxCategory.TabIndex = 37;
            // 
            // lblProCat
            // 
            this.lblProCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProCat.AutoSize = true;
            this.lblProCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProCat.Location = new System.Drawing.Point(316, 91);
            this.lblProCat.Name = "lblProCat";
            this.lblProCat.Size = new System.Drawing.Size(78, 17);
            this.lblProCat.TabIndex = 36;
            this.lblProCat.Text = "Category:";
            // 
            // lblBottle
            // 
            this.lblBottle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBottle.AutoSize = true;
            this.lblBottle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBottle.Location = new System.Drawing.Point(508, 120);
            this.lblBottle.Name = "lblBottle";
            this.lblBottle.Size = new System.Drawing.Size(34, 13);
            this.lblBottle.TabIndex = 34;
            this.lblBottle.Text = "Bottle";
            // 
            // lblCask
            // 
            this.lblCask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCask.AutoSize = true;
            this.lblCask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblCask.Location = new System.Drawing.Point(425, 120);
            this.lblCask.Name = "lblCask";
            this.lblCask.Size = new System.Drawing.Size(31, 13);
            this.lblCask.TabIndex = 33;
            this.lblCask.Text = "Cask";
            // 
            // txtCask
            // 
            this.txtCask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCask.Location = new System.Drawing.Point(428, 136);
            this.txtCask.Name = "txtCask";
            this.txtCask.Size = new System.Drawing.Size(73, 20);
            this.txtCask.TabIndex = 32;
            // 
            // lblProQuant
            // 
            this.lblProQuant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProQuant.AutoSize = true;
            this.lblProQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProQuant.Location = new System.Drawing.Point(316, 136);
            this.lblProQuant.Name = "lblProQuant";
            this.lblProQuant.Size = new System.Drawing.Size(74, 17);
            this.lblProQuant.TabIndex = 31;
            this.lblProQuant.Text = "Quantity:";
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProduct.Location = new System.Drawing.Point(316, 49);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 17);
            this.lblProduct.TabIndex = 29;
            this.lblProduct.Text = "Product:";
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblCost.Location = new System.Drawing.Point(318, 188);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(45, 17);
            this.lblCost.TabIndex = 39;
            this.lblCost.Text = "Cost:";
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.Controls.Add(this.grdOrder);
            this.pnlData.Location = new System.Drawing.Point(23, 49);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(266, 203);
            this.pnlData.TabIndex = 40;
            // 
            // grdOrder
            // 
            this.grdOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrder.Location = new System.Drawing.Point(0, 0);
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.Size = new System.Drawing.Size(266, 203);
            this.grdOrder.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cost";
            this.Column3.Name = "Column3";
            // 
            // txtBottle
            // 
            this.txtBottle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBottle.Location = new System.Drawing.Point(511, 136);
            this.txtBottle.Name = "txtBottle";
            this.txtBottle.Size = new System.Drawing.Size(73, 20);
            this.txtBottle.TabIndex = 41;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnNew.Location = new System.Drawing.Point(319, 269);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 26);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(504, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 26);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(412, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 26);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator2.AutoSize = true;
            this.lineSeparator2.Location = new System.Drawing.Point(21, 306);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(560, 2);
            this.lineSeparator2.TabIndex = 44;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblDate.Location = new System.Drawing.Point(316, 235);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 17);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Date:";
            // 
            // lblCostField
            // 
            this.lblCostField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostField.AutoSize = true;
            this.lblCostField.Location = new System.Drawing.Point(427, 188);
            this.lblCostField.Name = "lblCostField";
            this.lblCostField.Size = new System.Drawing.Size(56, 13);
            this.lblCostField.TabIndex = 46;
            this.lblCostField.Text = "XXXX vnd";
            // 
            // lblDateField
            // 
            this.lblDateField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateField.AutoSize = true;
            this.lblDateField.Location = new System.Drawing.Point(425, 235);
            this.lblDateField.Name = "lblDateField";
            this.lblDateField.Size = new System.Drawing.Size(65, 13);
            this.lblDateField.TabIndex = 47;
            this.lblDateField.Text = "00/00/0000";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblTotal.Location = new System.Drawing.Point(72, 274);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 17);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "Total: XXXX vnd";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.grdOrderList);
            this.panel1.Location = new System.Drawing.Point(23, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 257);
            this.panel1.TabIndex = 49;
            // 
            // grdOrderList
            // 
            this.grdOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOrderList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column4,
            this.Column5,
            this.dataGridViewTextBoxColumn3});
            this.grdOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrderList.Location = new System.Drawing.Point(0, 0);
            this.grdOrderList.Name = "grdOrderList";
            this.grdOrderList.Size = new System.Drawing.Size(560, 257);
            this.grdOrderList.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cask";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Bottle";
            this.Column5.Name = "Column5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // cbxProduct
            // 
            this.cbxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(428, 48);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(156, 21);
            this.cbxProduct.TabIndex = 50;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.cbxProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDateField);
            this.Controls.Add(this.lblCostField);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtBottle);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lblProCat);
            this.Controls.Add(this.lblBottle);
            this.Controls.Add(this.lblCask);
            this.Controls.Add(this.txtCask);
            this.Controls.Add(this.lblProQuant);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Designer.LineSeparator lineSeparator1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblProCat;
        private System.Windows.Forms.Label lblBottle;
        private System.Windows.Forms.Label lblCask;
        private System.Windows.Forms.TextBox txtCask;
        private System.Windows.Forms.Label lblProQuant;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView grdOrder;
        private System.Windows.Forms.TextBox txtBottle;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private Designer.LineSeparator lineSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCostField;
        private System.Windows.Forms.Label lblDateField;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox cbxProduct;
    }
}