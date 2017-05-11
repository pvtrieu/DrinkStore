namespace DrinkStore.Presentation
{
    partial class frmImport
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.importBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlData = new System.Windows.Forms.Panel();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.importIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importQuantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentUnitQuantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentBoxQuantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wholeCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineSeparator2 = new DrinkStore.Presentation.LineSeparator();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblProQuant = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lineSeparator1 = new DrinkStore.Presentation.LineSeparator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.lblExpired = new System.Windows.Forms.Label();
            this.dateExpired = new System.Windows.Forms.DateTimePicker();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImportDate = new System.Windows.Forms.Label();
            this.dateImport = new System.Windows.Forms.DateTimePicker();
            this.txtCurrUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProCat = new System.Windows.Forms.Label();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.plusButton1 = new DrinkStore.GUI_component.PlusButton();
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(197, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 26);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboProduct
            // 
            this.cboProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.importBindingSource, "ProductID", true));
            this.cboProduct.DataSource = this.productBindingSource;
            this.cboProduct.DisplayMember = "Name";
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(114, 90);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(163, 21);
            this.cboProduct.TabIndex = 48;
            this.cboProduct.ValueMember = "ProductID";
            // 
            // importBindingSource
            // 
            this.importBindingSource.DataSource = typeof(DrinkStore.Entities.Import);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DrinkStore.Entities.Product);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.Controls.Add(this.grdProduct);
            this.pnlData.Location = new System.Drawing.Point(21, 288);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(560, 300);
            this.pnlData.TabIndex = 46;
            // 
            // grdProduct
            // 
            this.grdProduct.AutoGenerateColumns = false;
            this.grdProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.importIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.importQuantDataGridViewTextBoxColumn,
            this.currentUnitQuantDataGridViewTextBoxColumn,
            this.currentBoxQuantDataGridViewTextBoxColumn,
            this.wholeCostDataGridViewTextBoxColumn,
            this.retailCostDataGridViewTextBoxColumn,
            this.importDateDataGridViewTextBoxColumn,
            this.expiredDateDataGridViewTextBoxColumn});
            this.grdProduct.DataSource = this.importTBBindingSource;
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.Location = new System.Drawing.Point(0, 0);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.ReadOnly = true;
            this.grdProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProduct.Size = new System.Drawing.Size(560, 300);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellContentClick);
            this.grdProduct.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdProduct_DataError);
            // 
            // importIDDataGridViewTextBoxColumn
            // 
            this.importIDDataGridViewTextBoxColumn.DataPropertyName = "ImportID";
            this.importIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.importIDDataGridViewTextBoxColumn.Name = "importIDDataGridViewTextBoxColumn";
            this.importIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.importIDDataGridViewTextBoxColumn.Width = 43;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.productIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.productIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIDDataGridViewTextBoxColumn.ValueMember = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Width = 69;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.DataSource = this.supplierBindingSource;
            this.supplierIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.supplierIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplierIDDataGridViewTextBoxColumn.ValueMember = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(DrinkStore.Entities.Supplier);
            // 
            // importQuantDataGridViewTextBoxColumn
            // 
            this.importQuantDataGridViewTextBoxColumn.DataPropertyName = "ImportQuant";
            this.importQuantDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.importQuantDataGridViewTextBoxColumn.Name = "importQuantDataGridViewTextBoxColumn";
            this.importQuantDataGridViewTextBoxColumn.ReadOnly = true;
            this.importQuantDataGridViewTextBoxColumn.Width = 71;
            // 
            // currentUnitQuantDataGridViewTextBoxColumn
            // 
            this.currentUnitQuantDataGridViewTextBoxColumn.DataPropertyName = "CurrentUnitQuant";
            this.currentUnitQuantDataGridViewTextBoxColumn.HeaderText = "CurrUnit";
            this.currentUnitQuantDataGridViewTextBoxColumn.Name = "currentUnitQuantDataGridViewTextBoxColumn";
            this.currentUnitQuantDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentUnitQuantDataGridViewTextBoxColumn.Width = 70;
            // 
            // currentBoxQuantDataGridViewTextBoxColumn
            // 
            this.currentBoxQuantDataGridViewTextBoxColumn.DataPropertyName = "CurrentBoxQuant";
            this.currentBoxQuantDataGridViewTextBoxColumn.HeaderText = "CurrBox";
            this.currentBoxQuantDataGridViewTextBoxColumn.Name = "currentBoxQuantDataGridViewTextBoxColumn";
            this.currentBoxQuantDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentBoxQuantDataGridViewTextBoxColumn.Width = 69;
            // 
            // wholeCostDataGridViewTextBoxColumn
            // 
            this.wholeCostDataGridViewTextBoxColumn.DataPropertyName = "WholeCost";
            this.wholeCostDataGridViewTextBoxColumn.HeaderText = "WholeCost";
            this.wholeCostDataGridViewTextBoxColumn.Name = "wholeCostDataGridViewTextBoxColumn";
            this.wholeCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.wholeCostDataGridViewTextBoxColumn.Width = 84;
            // 
            // retailCostDataGridViewTextBoxColumn
            // 
            this.retailCostDataGridViewTextBoxColumn.DataPropertyName = "RetailCost";
            this.retailCostDataGridViewTextBoxColumn.HeaderText = "RetailCost";
            this.retailCostDataGridViewTextBoxColumn.Name = "retailCostDataGridViewTextBoxColumn";
            this.retailCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.retailCostDataGridViewTextBoxColumn.Width = 80;
            // 
            // importDateDataGridViewTextBoxColumn
            // 
            this.importDateDataGridViewTextBoxColumn.DataPropertyName = "ImportDate";
            this.importDateDataGridViewTextBoxColumn.HeaderText = "ImportDate";
            this.importDateDataGridViewTextBoxColumn.Name = "importDateDataGridViewTextBoxColumn";
            this.importDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.importDateDataGridViewTextBoxColumn.Width = 84;
            // 
            // expiredDateDataGridViewTextBoxColumn
            // 
            this.expiredDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiredDate";
            this.expiredDateDataGridViewTextBoxColumn.HeaderText = "ExpiredDate";
            this.expiredDateDataGridViewTextBoxColumn.Name = "expiredDateDataGridViewTextBoxColumn";
            this.expiredDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expiredDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // importTBBindingSource
            // 
            this.importTBBindingSource.DataSource = typeof(DrinkStore.Entities.Import);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator2.AutoSize = true;
            this.lineSeparator2.Location = new System.Drawing.Point(21, 272);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(560, 2);
            this.lineSeparator2.TabIndex = 44;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(110, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(21, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCost
            // 
            this.txtCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importBindingSource, "WholeCost", true));
            this.txtCost.Location = new System.Drawing.Point(418, 127);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(163, 20);
            this.txtCost.TabIndex = 40;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblCost.Location = new System.Drawing.Point(327, 126);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(85, 17);
            this.lblCost.TabIndex = 34;
            this.lblCost.Text = "Total cost:";
            // 
            // lblProQuant
            // 
            this.lblProQuant.AutoSize = true;
            this.lblProQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProQuant.Location = new System.Drawing.Point(18, 127);
            this.lblProQuant.Name = "lblProQuant";
            this.lblProQuant.Size = new System.Drawing.Size(74, 17);
            this.lblProQuant.TabIndex = 32;
            this.lblProQuant.Text = "Quantity:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProduct.Location = new System.Drawing.Point(18, 91);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 17);
            this.lblProduct.TabIndex = 30;
            this.lblProduct.Text = "Product:";
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
            this.lblTitle.Size = new System.Drawing.Size(74, 26);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Import";
            // 
            // txtQuant
            // 
            this.txtQuant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importBindingSource, "ImportQuant", true));
            this.txtQuant.Location = new System.Drawing.Point(114, 125);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(163, 20);
            this.txtQuant.TabIndex = 53;
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblExpired.Location = new System.Drawing.Point(18, 158);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(67, 17);
            this.lblExpired.TabIndex = 56;
            this.lblExpired.Text = "Expired:";
            // 
            // dateExpired
            // 
            this.dateExpired.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.importBindingSource, "ExpiredDate", true));
            this.dateExpired.Location = new System.Drawing.Point(114, 159);
            this.dateExpired.Name = "dateExpired";
            this.dateExpired.Size = new System.Drawing.Size(163, 20);
            this.dateExpired.TabIndex = 57;
            // 
            // cboSupplier
            // 
            this.cboSupplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.importBindingSource, "SupplierID", true));
            this.cboSupplier.DataSource = this.supplierBindingSource;
            this.cboSupplier.DisplayMember = "Name";
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(418, 93);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(136, 21);
            this.cboSupplier.TabIndex = 59;
            this.cboSupplier.ValueMember = "SupplierID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(339, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Supplier:";
            // 
            // lblImportDate
            // 
            this.lblImportDate.AutoSize = true;
            this.lblImportDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblImportDate.Location = new System.Drawing.Point(312, 158);
            this.lblImportDate.Name = "lblImportDate";
            this.lblImportDate.Size = new System.Drawing.Size(95, 17);
            this.lblImportDate.TabIndex = 61;
            this.lblImportDate.Text = "Import date:";
            // 
            // dateImport
            // 
            this.dateImport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importBindingSource, "ImportDate", true));
            this.dateImport.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.importBindingSource, "ImportDate", true));
            this.dateImport.Enabled = false;
            this.dateImport.Location = new System.Drawing.Point(418, 159);
            this.dateImport.Name = "dateImport";
            this.dateImport.Size = new System.Drawing.Size(163, 20);
            this.dateImport.TabIndex = 62;
            // 
            // txtCurrUnit
            // 
            this.txtCurrUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importTBBindingSource, "CurrentUnitQuant", true));
            this.txtCurrUnit.Location = new System.Drawing.Point(114, 189);
            this.txtCurrUnit.Name = "txtCurrUnit";
            this.txtCurrUnit.ReadOnly = true;
            this.txtCurrUnit.Size = new System.Drawing.Size(163, 20);
            this.txtCurrUnit.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(18, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Unit instock:";
            // 
            // txtCurrBox
            // 
            this.txtCurrBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importTBBindingSource, "CurrentBoxQuant", true));
            this.txtCurrBox.Location = new System.Drawing.Point(418, 190);
            this.txtCurrBox.Name = "txtCurrBox";
            this.txtCurrBox.ReadOnly = true;
            this.txtCurrBox.Size = new System.Drawing.Size(163, 20);
            this.txtCurrBox.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(312, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Box instock:";
            // 
            // lblProCat
            // 
            this.lblProCat.AutoSize = true;
            this.lblProCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProCat.Location = new System.Drawing.Point(18, 55);
            this.lblProCat.Name = "lblProCat";
            this.lblProCat.Size = new System.Drawing.Size(78, 17);
            this.lblProCat.TabIndex = 47;
            this.lblProCat.Text = "Category:";
            // 
            // cbxCat
            // 
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Location = new System.Drawing.Point(114, 53);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(163, 21);
            this.cbxCat.TabIndex = 50;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBrand.Location = new System.Drawing.Point(350, 54);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 17);
            this.lblBrand.TabIndex = 54;
            this.lblBrand.Text = "Brand:";
            // 
            // cboBrand
            // 
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(418, 55);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(163, 21);
            this.cboBrand.TabIndex = 58;
            // 
            // plusButton1
            // 
            this.plusButton1.Location = new System.Drawing.Point(561, 94);
            this.plusButton1.Margin = new System.Windows.Forms.Padding(0);
            this.plusButton1.Name = "plusButton1";
            this.plusButton1.Size = new System.Drawing.Size(20, 20);
            this.plusButton1.TabIndex = 68;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.plusButton1);
            this.Controls.Add(this.txtCurrBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateImport);
            this.Controls.Add(this.lblImportDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.dateExpired);
            this.Controls.Add(this.lblExpired);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.cbxCat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.lblProCat);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblProQuant);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImport";
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView grdProduct;
        private Presentation.LineSeparator lineSeparator2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblProQuant;
        private System.Windows.Forms.Label lblProduct;
        private Presentation.LineSeparator lineSeparator1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.DateTimePicker dateExpired;
        private System.Windows.Forms.BindingSource importBindingSource;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImportDate;
        private System.Windows.Forms.DateTimePicker dateImport;
        private System.Windows.Forms.TextBox txtCurrUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Label lblProCat;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboBrand;
        private GUI_component.PlusButton plusButton1;
        private System.Windows.Forms.BindingSource importTBBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn importIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentUnitQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentBoxQuantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholeCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDateDataGridViewTextBoxColumn;
    }
}