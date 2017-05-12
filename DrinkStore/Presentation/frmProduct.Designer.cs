namespace DrinkStore.Presentation
{
    partial class frmProduct
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlProductImg = new System.Windows.Forms.Panel();
            this.picProImg = new System.Windows.Forms.PictureBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.productTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProQuant = new System.Windows.Forms.Label();
            this.lblProPrice = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtPBox = new System.Windows.Forms.TextBox();
            this.txtPUnit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitQuantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxQuantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wholeSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BrandID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProCat = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lineSeparator2 = new DrinkStore.Presentation.LineSeparator();
            this.lineSeparator1 = new DrinkStore.Presentation.LineSeparator();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.plusButton2 = new DrinkStore.GUI_component.PlusButton();
            this.btnAddCate = new DrinkStore.GUI_component.PlusButton();
            this.btnAddBrand = new DrinkStore.GUI_component.PlusButton();
            this.searchButton1 = new DrinkStore.GUI_component.SearchButton();
            this.pnlProductImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBBindingSource)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(87, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product";
            // 
            // pnlProductImg
            // 
            this.pnlProductImg.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlProductImg.Controls.Add(this.picProImg);
            this.pnlProductImg.Location = new System.Drawing.Point(20, 55);
            this.pnlProductImg.Name = "pnlProductImg";
            this.pnlProductImg.Size = new System.Drawing.Size(150, 150);
            this.pnlProductImg.TabIndex = 2;
            // 
            // picProImg
            // 
            this.picProImg.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "Avatar", true));
            this.picProImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProImg.Location = new System.Drawing.Point(0, 0);
            this.picProImg.Name = "picProImg";
            this.picProImg.Size = new System.Drawing.Size(150, 150);
            this.picProImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProImg.TabIndex = 0;
            this.picProImg.TabStop = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DrinkStore.Entities.Product);
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProName.Location = new System.Drawing.Point(190, 55);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(54, 17);
            this.lblProName.TabIndex = 3;
            this.lblProName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(302, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 0;
            // 
            // productTBBindingSource
            // 
            this.productTBBindingSource.DataSource = typeof(DrinkStore.Entities.Product);
            // 
            // lblProQuant
            // 
            this.lblProQuant.AutoSize = true;
            this.lblProQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProQuant.Location = new System.Drawing.Point(190, 155);
            this.lblProQuant.Name = "lblProQuant";
            this.lblProQuant.Size = new System.Drawing.Size(74, 17);
            this.lblProQuant.TabIndex = 5;
            this.lblProQuant.Text = "Quantity:";
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProPrice.Location = new System.Drawing.Point(192, 189);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(50, 17);
            this.lblProPrice.TabIndex = 8;
            this.lblProPrice.Text = "Price:";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblSell.Location = new System.Drawing.Point(445, 172);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(43, 13);
            this.lblSell.TabIndex = 14;
            this.lblSell.Text = "Per unit";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBase.Location = new System.Drawing.Point(301, 172);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(43, 13);
            this.lblBase.TabIndex = 13;
            this.lblBase.Text = "Per box";
            // 
            // txtPBox
            // 
            this.txtPBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "WholeSale", true));
            this.txtPBox.Location = new System.Drawing.Point(304, 184);
            this.txtPBox.Name = "txtPBox";
            this.txtPBox.Size = new System.Drawing.Size(135, 20);
            this.txtPBox.TabIndex = 1;
            this.txtPBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPBox_KeyPress);
            this.txtPBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPBox_KeyUp);
            // 
            // txtPUnit
            // 
            this.txtPUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "RetailSale", true));
            this.txtPUnit.Location = new System.Drawing.Point(448, 184);
            this.txtPUnit.Name = "txtPUnit";
            this.txtPUnit.Size = new System.Drawing.Size(135, 20);
            this.txtPUnit.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(302, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(399, 226);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.Color.Red;
            this.btnImg.FlatAppearance.BorderSize = 0;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnImg.Location = new System.Drawing.Point(21, 226);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(149, 26);
            this.btnImg.TabIndex = 22;
            this.btnImg.Text = "Add Image";
            this.btnImg.UseVisualStyleBackColor = false;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.Controls.Add(this.dgvProduct);
            this.pnlData.Location = new System.Drawing.Point(21, 288);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(560, 300);
            this.pnlData.TabIndex = 23;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitQuantDataGridViewTextBoxColumn,
            this.boxQuantDataGridViewTextBoxColumn,
            this.wholeSaleDataGridViewTextBoxColumn,
            this.retailSaleDataGridViewTextBoxColumn,
            this.CategoryID,
            this.BrandID});
            this.dgvProduct.DataSource = this.productTBBindingSource;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(560, 300);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProduct_DataError);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitQuantDataGridViewTextBoxColumn
            // 
            this.unitQuantDataGridViewTextBoxColumn.DataPropertyName = "UnitQuant";
            this.unitQuantDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitQuantDataGridViewTextBoxColumn.Name = "unitQuantDataGridViewTextBoxColumn";
            this.unitQuantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boxQuantDataGridViewTextBoxColumn
            // 
            this.boxQuantDataGridViewTextBoxColumn.DataPropertyName = "BoxQuant";
            this.boxQuantDataGridViewTextBoxColumn.HeaderText = "Box";
            this.boxQuantDataGridViewTextBoxColumn.Name = "boxQuantDataGridViewTextBoxColumn";
            this.boxQuantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wholeSaleDataGridViewTextBoxColumn
            // 
            this.wholeSaleDataGridViewTextBoxColumn.DataPropertyName = "WholeSale";
            this.wholeSaleDataGridViewTextBoxColumn.HeaderText = "WholeSale";
            this.wholeSaleDataGridViewTextBoxColumn.Name = "wholeSaleDataGridViewTextBoxColumn";
            this.wholeSaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retailSaleDataGridViewTextBoxColumn
            // 
            this.retailSaleDataGridViewTextBoxColumn.DataPropertyName = "RetailSale";
            this.retailSaleDataGridViewTextBoxColumn.HeaderText = "RetailSale";
            this.retailSaleDataGridViewTextBoxColumn.Name = "retailSaleDataGridViewTextBoxColumn";
            this.retailSaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.DataSource = this.categoryBindingSource;
            this.CategoryID.DisplayMember = "Name";
            this.CategoryID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CategoryID.HeaderText = "Category";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CategoryID.ValueMember = "CategoryID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DrinkStore.Entities.Category);
            // 
            // BrandID
            // 
            this.BrandID.DataPropertyName = "BrandID";
            this.BrandID.DataSource = this.brandBindingSource;
            this.BrandID.DisplayMember = "CompanyName";
            this.BrandID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.BrandID.HeaderText = "Brand";
            this.BrandID.Name = "BrandID";
            this.BrandID.ReadOnly = true;
            this.BrandID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BrandID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BrandID.ValueMember = "BrandID";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataSource = typeof(DrinkStore.Entities.Brand);
            // 
            // lblProCat
            // 
            this.lblProCat.AutoSize = true;
            this.lblProCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProCat.Location = new System.Drawing.Point(192, 87);
            this.lblProCat.Name = "lblProCat";
            this.lblProCat.Size = new System.Drawing.Size(78, 17);
            this.lblProCat.TabIndex = 24;
            this.lblProCat.Text = "Category:";
            // 
            // cboBrand
            // 
            this.cboBrand.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "BrandID", true));
            this.cboBrand.DataSource = this.brandBindingSource;
            this.cboBrand.DisplayMember = "CompanyName";
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(302, 115);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(241, 21);
            this.cboBrand.TabIndex = 25;
            this.cboBrand.ValueMember = "BrandID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(498, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 26);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator2.AutoSize = true;
            this.lineSeparator2.Location = new System.Drawing.Point(21, 270);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(560, 2);
            this.lineSeparator2.TabIndex = 20;
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
            this.lineSeparator1.TabIndex = 1;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBrand.Location = new System.Drawing.Point(192, 119);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 17);
            this.lblBrand.TabIndex = 27;
            this.lblBrand.Text = "Brand:";
            // 
            // cboCate
            // 
            this.cboCate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryID", true));
            this.cboCate.DataSource = this.categoryBindingSource;
            this.cboCate.DisplayMember = "Name";
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(302, 86);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(241, 21);
            this.cboCate.TabIndex = 28;
            this.cboCate.ValueMember = "CategoryID";
            // 
            // plusButton2
            // 
            this.plusButton2.Location = new System.Drawing.Point(-15, -15);
            this.plusButton2.Margin = new System.Windows.Forms.Padding(0);
            this.plusButton2.Name = "plusButton2";
            this.plusButton2.Size = new System.Drawing.Size(20, 20);
            this.plusButton2.TabIndex = 30;
            // 
            // btnAddCate
            // 
            this.btnAddCate.Location = new System.Drawing.Point(557, 86);
            this.btnAddCate.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(20, 20);
            this.btnAddCate.TabIndex = 31;
            this.btnAddCate.ButtonClick += new System.EventHandler(this.btnAddCate_Click);
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(557, 116);
            this.btnAddBrand.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(20, 20);
            this.btnAddBrand.TabIndex = 32;
            this.btnAddBrand.ButtonClick += new System.EventHandler(this.btnAddBrand_Click);
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // searchButton1
            // 
            this.searchButton1.Location = new System.Drawing.Point(557, 56);
            this.searchButton1.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.Size = new System.Drawing.Size(20, 20);
            this.searchButton1.TabIndex = 33;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.searchButton1);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.btnAddCate);
            this.Controls.Add(this.plusButton2);
            this.Controls.Add(this.cboCate);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.lblProCat);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPUnit);
            this.Controls.Add(this.txtPBox);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblProPrice);
            this.Controls.Add(this.lblProQuant);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.pnlProductImg);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.pnlProductImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTBBindingSource)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Presentation.LineSeparator lineSeparator1;
        private System.Windows.Forms.Panel pnlProductImg;
        private System.Windows.Forms.PictureBox picProImg;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProQuant;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtPBox;
        private System.Windows.Forms.TextBox txtPUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private Presentation.LineSeparator lineSeparator2;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblProCat;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource productTBBindingSource;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholeSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewComboBoxColumn BrandID;
        private GUI_component.PlusButton plusButton2;
        private GUI_component.PlusButton btnAddCate;
        private GUI_component.PlusButton btnAddBrand;
        private GUI_component.SearchButton searchButton1;
    }
}