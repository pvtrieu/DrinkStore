namespace DrinkStore.Presentation
{
    partial class frmOrderDetail
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
            this.components = new System.ComponentModel.Container();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.detailBindindSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtBottle = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProCat = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblBox = new System.Windows.Forms.Label();
            this.txtCask = new System.Windows.Forms.TextBox();
            this.lblProQuant = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.boxQuantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitQuantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.lblProfit = new System.Windows.Forms.Label();
            this.closeButton1 = new DrinkStore.Presentation.CloseButton();
            this.movePanel1 = new DrinkStore.GUI_component.MovePanel();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindindSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSale
            // 
            this.txtSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSale.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailBindindSource, "Sale", true));
            this.txtSale.Location = new System.Drawing.Point(432, 205);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(156, 20);
            this.txtSale.TabIndex = 68;
            // 
            // detailBindindSource
            // 
            this.detailBindindSource.DataSource = typeof(DrinkStore.Entities.OrderDetail);
            // 
            // cbxProduct
            // 
            this.cbxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detailBindindSource, "ProductID", true));
            this.cbxProduct.DataSource = this.productBindingSource;
            this.cbxProduct.DisplayMember = "Name";
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(432, 126);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(156, 21);
            this.cbxProduct.TabIndex = 66;
            this.cbxProduct.ValueMember = "ProductID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DrinkStore.Entities.Product);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(508, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 26);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(416, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnNew.Location = new System.Drawing.Point(323, 309);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 26);
            this.btnNew.TabIndex = 53;
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // txtBottle
            // 
            this.txtBottle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBottle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailBindindSource, "UnitQuant", true));
            this.txtBottle.Location = new System.Drawing.Point(515, 168);
            this.txtBottle.Name = "txtBottle";
            this.txtBottle.Size = new System.Drawing.Size(73, 20);
            this.txtBottle.TabIndex = 62;
            // 
            // lblSale
            // 
            this.lblSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblSale.Location = new System.Drawing.Point(322, 205);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(45, 17);
            this.lblSale.TabIndex = 61;
            this.lblSale.Text = "Sale:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryID", true));
            this.cbxCategory.DataSource = this.categoryBindingSource;
            this.cbxCategory.DisplayMember = "Name";
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(432, 58);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(156, 21);
            this.cbxCategory.TabIndex = 60;
            this.cbxCategory.ValueMember = "CategoryID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DrinkStore.Entities.Category);
            // 
            // lblProCat
            // 
            this.lblProCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProCat.AutoSize = true;
            this.lblProCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProCat.Location = new System.Drawing.Point(318, 58);
            this.lblProCat.Name = "lblProCat";
            this.lblProCat.Size = new System.Drawing.Size(78, 17);
            this.lblProCat.TabIndex = 59;
            this.lblProCat.Text = "Category:";
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit.AutoSize = true;
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblUnit.Location = new System.Drawing.Point(512, 152);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 58;
            this.lblUnit.Text = "Unit";
            // 
            // lblBox
            // 
            this.lblBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBox.AutoSize = true;
            this.lblBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBox.Location = new System.Drawing.Point(429, 152);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(25, 13);
            this.lblBox.TabIndex = 57;
            this.lblBox.Text = "Box";
            // 
            // txtCask
            // 
            this.txtCask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCask.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailBindindSource, "BoxQuant", true));
            this.txtCask.Location = new System.Drawing.Point(432, 168);
            this.txtCask.Name = "txtCask";
            this.txtCask.Size = new System.Drawing.Size(73, 20);
            this.txtCask.TabIndex = 56;
            // 
            // lblProQuant
            // 
            this.lblProQuant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProQuant.AutoSize = true;
            this.lblProQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProQuant.Location = new System.Drawing.Point(320, 168);
            this.lblProQuant.Name = "lblProQuant";
            this.lblProQuant.Size = new System.Drawing.Size(74, 17);
            this.lblProQuant.TabIndex = 55;
            this.lblProQuant.Text = "Quantity:";
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProduct.Location = new System.Drawing.Point(320, 127);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 17);
            this.lblProduct.TabIndex = 54;
            this.lblProduct.Text = "Product:";
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.Controls.Add(this.dgvOrderDetail);
            this.pnlData.Location = new System.Drawing.Point(12, 57);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(298, 278);
            this.pnlData.TabIndex = 69;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AutoGenerateColumns = false;
            this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.boxQuantDataGridViewTextBoxColumn,
            this.unitQuantDataGridViewTextBoxColumn,
            this.saleDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn});
            this.dgvOrderDetail.DataSource = this.detailTBBindingSource;
            this.dgvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.Size = new System.Drawing.Size(298, 278);
            this.dgvOrderDetail.TabIndex = 0;
            this.dgvOrderDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOrderDetail_DataError);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.productIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.productIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIDDataGridViewTextBoxColumn.ValueMember = "ProductID";
            // 
            // boxQuantDataGridViewTextBoxColumn
            // 
            this.boxQuantDataGridViewTextBoxColumn.DataPropertyName = "BoxQuant";
            this.boxQuantDataGridViewTextBoxColumn.HeaderText = "Box";
            this.boxQuantDataGridViewTextBoxColumn.Name = "boxQuantDataGridViewTextBoxColumn";
            // 
            // unitQuantDataGridViewTextBoxColumn
            // 
            this.unitQuantDataGridViewTextBoxColumn.DataPropertyName = "UnitQuant";
            this.unitQuantDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitQuantDataGridViewTextBoxColumn.Name = "unitQuantDataGridViewTextBoxColumn";
            // 
            // saleDataGridViewTextBoxColumn
            // 
            this.saleDataGridViewTextBoxColumn.DataPropertyName = "Sale";
            this.saleDataGridViewTextBoxColumn.HeaderText = "Sale";
            this.saleDataGridViewTextBoxColumn.Name = "saleDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // detailTBBindingSource
            // 
            this.detailTBBindingSource.DataSource = typeof(DrinkStore.Entities.OrderDetail);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(320, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Brand:";
            // 
            // cboBrand
            // 
            this.cboBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBrand.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "BrandID", true));
            this.cboBrand.DataSource = this.brandBindingSource;
            this.cboBrand.DisplayMember = "CompanyName";
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(432, 92);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(156, 21);
            this.cboBrand.TabIndex = 60;
            this.cboBrand.ValueMember = "BrandID";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataSource = typeof(DrinkStore.Entities.Brand);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.lblLogo.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblLogo.Location = new System.Drawing.Point(8, 6);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(165, 25);
            this.lblLogo.TabIndex = 70;
            this.lblLogo.Text = "Order details";
            // 
            // txtProfit
            // 
            this.txtProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailBindindSource, "Profit", true));
            this.txtProfit.Location = new System.Drawing.Point(432, 239);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(156, 20);
            this.txtProfit.TabIndex = 73;
            // 
            // lblProfit
            // 
            this.lblProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProfit.Location = new System.Drawing.Point(322, 239);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(52, 17);
            this.lblProfit.TabIndex = 72;
            this.lblProfit.Text = "Profit:";
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.closeButton1.Location = new System.Drawing.Point(564, 6);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(24, 24);
            this.closeButton1.TabIndex = 71;
            // 
            // movePanel1
            // 
            this.movePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(45)))));
            this.movePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel1.Location = new System.Drawing.Point(0, 0);
            this.movePanel1.Name = "movePanel1";
            this.movePanel1.Size = new System.Drawing.Size(600, 40);
            this.movePanel1.TabIndex = 0;
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 354);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.txtSale);
            this.Controls.Add(this.cbxProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtBottle);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lblProCat);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblBox);
            this.Controls.Add(this.txtCask);
            this.Controls.Add(this.lblProQuant);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.movePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderDetail";
            this.Text = "frmOrderDetail";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailBindindSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GUI_component.MovePanel movePanel1;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtBottle;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblProCat;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.TextBox txtCask;
        private System.Windows.Forms.Label lblProQuant;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label lblLogo;
        private CloseButton closeButton1;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.BindingSource detailBindindSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detailTBBindingSource;
        private System.Windows.Forms.BindingSource brandBindingSource;
    }
}