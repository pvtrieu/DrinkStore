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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblProCat = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineSeparator2 = new DrinkStore.Designer.LineSeparator();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtPcask = new System.Windows.Forms.TextBox();
            this.lblCask = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblProQuant = new System.Windows.Forms.Label();
            this.lblProTitle = new System.Windows.Forms.Label();
            this.lineSeparator1 = new DrinkStore.Designer.LineSeparator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.txtBottle = new System.Windows.Forms.TextBox();
            this.lblBottle = new System.Windows.Forms.Label();
            this.txtCask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProID = new System.Windows.Forms.ComboBox();
            this.lblExpired = new System.Windows.Forms.Label();
            this.dateExpired = new System.Windows.Forms.DateTimePicker();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Bottle";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "P. Bottle";
            this.Column7.Name = "Column7";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(326, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 26);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 21);
            this.comboBox1.TabIndex = 48;
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
            this.grdProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.Location = new System.Drawing.Point(0, 0);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.Size = new System.Drawing.Size(560, 300);
            this.grdProduct.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cask";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "P. Cask";
            this.Column6.Name = "Column6";
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
            this.btnUpdate.Location = new System.Drawing.Point(227, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 26);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnImport.Location = new System.Drawing.Point(130, 229);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 26);
            this.btnImport.TabIndex = 42;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // txtPcask
            // 
            this.txtPcask.Location = new System.Drawing.Point(130, 188);
            this.txtPcask.Name = "txtPcask";
            this.txtPcask.Size = new System.Drawing.Size(276, 20);
            this.txtPcask.TabIndex = 40;
            // 
            // lblCask
            // 
            this.lblCask.AutoSize = true;
            this.lblCask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblCask.Location = new System.Drawing.Point(127, 126);
            this.lblCask.Name = "lblCask";
            this.lblCask.Size = new System.Drawing.Size(31, 13);
            this.lblCask.TabIndex = 35;
            this.lblCask.Text = "Cask";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblCost.Location = new System.Drawing.Point(18, 191);
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
            this.lblProQuant.Location = new System.Drawing.Point(18, 145);
            this.lblProQuant.Name = "lblProQuant";
            this.lblProQuant.Size = new System.Drawing.Size(74, 17);
            this.lblProQuant.TabIndex = 32;
            this.lblProQuant.Text = "Quantity:";
            // 
            // lblProTitle
            // 
            this.lblProTitle.AutoSize = true;
            this.lblProTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProTitle.Location = new System.Drawing.Point(18, 101);
            this.lblProTitle.Name = "lblProTitle";
            this.lblProTitle.Size = new System.Drawing.Size(45, 17);
            this.lblProTitle.TabIndex = 30;
            this.lblProTitle.Text = "Title:";
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
            // cbxCat
            // 
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Location = new System.Drawing.Point(130, 54);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(276, 21);
            this.cbxCat.TabIndex = 50;
            // 
            // txtBottle
            // 
            this.txtBottle.Location = new System.Drawing.Point(271, 142);
            this.txtBottle.Name = "txtBottle";
            this.txtBottle.Size = new System.Drawing.Size(135, 20);
            this.txtBottle.TabIndex = 52;
            // 
            // lblBottle
            // 
            this.lblBottle.AutoSize = true;
            this.lblBottle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBottle.Location = new System.Drawing.Point(268, 126);
            this.lblBottle.Name = "lblBottle";
            this.lblBottle.Size = new System.Drawing.Size(34, 13);
            this.lblBottle.TabIndex = 51;
            this.lblBottle.Text = "Bottle";
            // 
            // txtCask
            // 
            this.txtCask.Location = new System.Drawing.Point(130, 142);
            this.txtCask.Name = "txtCask";
            this.txtCask.Size = new System.Drawing.Size(135, 20);
            this.txtCask.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(424, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Product ID:";
            // 
            // cbxProID
            // 
            this.cbxProID.FormattingEnabled = true;
            this.cbxProID.Location = new System.Drawing.Point(427, 99);
            this.cbxProID.Name = "cbxProID";
            this.cbxProID.Size = new System.Drawing.Size(154, 21);
            this.cbxProID.TabIndex = 55;
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblExpired.Location = new System.Drawing.Point(424, 145);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(98, 17);
            this.lblExpired.TabIndex = 56;
            this.lblExpired.Text = "Expired day:";
            // 
            // dateExpired
            // 
            this.dateExpired.Location = new System.Drawing.Point(427, 188);
            this.dateExpired.Name = "dateExpired";
            this.dateExpired.Size = new System.Drawing.Size(154, 20);
            this.dateExpired.TabIndex = 57;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.dateExpired);
            this.Controls.Add(this.lblExpired);
            this.Controls.Add(this.cbxProID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCask);
            this.Controls.Add(this.txtBottle);
            this.Controls.Add(this.lblBottle);
            this.Controls.Add(this.cbxCat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblProCat);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtPcask);
            this.Controls.Add(this.lblCask);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblProQuant);
            this.Controls.Add(this.lblProTitle);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImport";
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblProCat;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Designer.LineSeparator lineSeparator2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtPcask;
        private System.Windows.Forms.Label lblCask;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblProQuant;
        private System.Windows.Forms.Label lblProTitle;
        private Designer.LineSeparator lineSeparator1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.TextBox txtBottle;
        private System.Windows.Forms.Label lblBottle;
        private System.Windows.Forms.TextBox txtCask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProID;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.DateTimePicker dateExpired;
    }
}