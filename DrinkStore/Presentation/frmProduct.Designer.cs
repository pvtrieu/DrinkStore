namespace DrinkStore.Designer
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlProductImg = new System.Windows.Forms.Panel();
            this.picProImg = new System.Windows.Forms.PictureBox();
            this.lblProTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblProQuant = new System.Windows.Forms.Label();
            this.txtCask = new System.Windows.Forms.TextBox();
            this.lblProPrice = new System.Windows.Forms.Label();
            this.lblCask = new System.Windows.Forms.Label();
            this.lblBottle = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBottle = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineSeparator2 = new DrinkStore.Designer.LineSeparator();
            this.lineSeparator1 = new DrinkStore.Designer.LineSeparator();
            this.pnlProductImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pnlProductImg.Size = new System.Drawing.Size(100, 100);
            this.pnlProductImg.TabIndex = 2;
            // 
            // picProImg
            // 
            this.picProImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picProImg.Location = new System.Drawing.Point(0, 0);
            this.picProImg.Name = "picProImg";
            this.picProImg.Size = new System.Drawing.Size(100, 100);
            this.picProImg.TabIndex = 0;
            this.picProImg.TabStop = false;
            // 
            // lblProTitle
            // 
            this.lblProTitle.AutoSize = true;
            this.lblProTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProTitle.Location = new System.Drawing.Point(141, 55);
            this.lblProTitle.Name = "lblProTitle";
            this.lblProTitle.Size = new System.Drawing.Size(45, 17);
            this.lblProTitle.TabIndex = 3;
            this.lblProTitle.Text = "Title:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblProQuant
            // 
            this.lblProQuant.AutoSize = true;
            this.lblProQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProQuant.Location = new System.Drawing.Point(141, 96);
            this.lblProQuant.Name = "lblProQuant";
            this.lblProQuant.Size = new System.Drawing.Size(74, 17);
            this.lblProQuant.TabIndex = 5;
            this.lblProQuant.Text = "Quantity:";
            // 
            // txtCask
            // 
            this.txtCask.Location = new System.Drawing.Point(225, 96);
            this.txtCask.Name = "txtCask";
            this.txtCask.Size = new System.Drawing.Size(135, 20);
            this.txtCask.TabIndex = 7;
            // 
            // lblProPrice
            // 
            this.lblProPrice.AutoSize = true;
            this.lblProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblProPrice.Location = new System.Drawing.Point(141, 138);
            this.lblProPrice.Name = "lblProPrice";
            this.lblProPrice.Size = new System.Drawing.Size(50, 17);
            this.lblProPrice.TabIndex = 8;
            this.lblProPrice.Text = "Price:";
            // 
            // lblCask
            // 
            this.lblCask.AutoSize = true;
            this.lblCask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblCask.Location = new System.Drawing.Point(277, 80);
            this.lblCask.Name = "lblCask";
            this.lblCask.Size = new System.Drawing.Size(31, 13);
            this.lblCask.TabIndex = 9;
            this.lblCask.Text = "Cask";
            // 
            // lblBottle
            // 
            this.lblBottle.AutoSize = true;
            this.lblBottle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBottle.Location = new System.Drawing.Point(444, 80);
            this.lblBottle.Name = "lblBottle";
            this.lblBottle.Size = new System.Drawing.Size(34, 13);
            this.lblBottle.TabIndex = 10;
            this.lblBottle.Text = "Bottle";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblSell.Location = new System.Drawing.Point(444, 119);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(24, 13);
            this.lblSell.TabIndex = 14;
            this.lblSell.Text = "Sell";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lblBase.Location = new System.Drawing.Point(277, 119);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 13;
            this.lblBase.Text = "Base";
            // 
            // txtBottle
            // 
            this.txtBottle.Location = new System.Drawing.Point(395, 96);
            this.txtBottle.Name = "txtBottle";
            this.txtBottle.Size = new System.Drawing.Size(135, 20);
            this.txtBottle.TabIndex = 16;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(225, 138);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(135, 20);
            this.txtBase.TabIndex = 17;
            // 
            // txtSell
            // 
            this.txtSell.Location = new System.Drawing.Point(395, 135);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(135, 20);
            this.txtSell.TabIndex = 18;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAddNew.Location = new System.Drawing.Point(225, 174);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(135, 26);
            this.btnAddNew.TabIndex = 19;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(393, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 26);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.btnImg.FlatAppearance.BorderSize = 0;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnImg.Location = new System.Drawing.Point(21, 174);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(99, 26);
            this.btnImg.TabIndex = 22;
            this.btnImg.Text = "Add Image";
            this.btnImg.UseVisualStyleBackColor = false;
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.Controls.Add(this.dataGridView1);
            this.pnlData.Location = new System.Drawing.Point(21, 233);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(510, 205);
            this.pnlData.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator2.AutoSize = true;
            this.lineSeparator2.Location = new System.Drawing.Point(21, 214);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(510, 2);
            this.lineSeparator2.TabIndex = 20;
            // 
            // lineSeparator1
            // 
            this.lineSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator1.AutoSize = true;
            this.lineSeparator1.Location = new System.Drawing.Point(20, 39);
            this.lineSeparator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator1.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator1.Name = "lineSeparator1";
            this.lineSeparator1.Size = new System.Drawing.Size(510, 2);
            this.lineSeparator1.TabIndex = 1;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtSell);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtBottle);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblBottle);
            this.Controls.Add(this.lblCask);
            this.Controls.Add(this.lblProPrice);
            this.Controls.Add(this.txtCask);
            this.Controls.Add(this.lblProQuant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProTitle);
            this.Controls.Add(this.pnlProductImg);
            this.Controls.Add(this.lineSeparator1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.pnlProductImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProImg)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Designer.LineSeparator lineSeparator1;
        private System.Windows.Forms.Panel pnlProductImg;
        private System.Windows.Forms.PictureBox picProImg;
        private System.Windows.Forms.Label lblProTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblProQuant;
        private System.Windows.Forms.TextBox txtCask;
        private System.Windows.Forms.Label lblProPrice;
        private System.Windows.Forms.Label lblCask;
        private System.Windows.Forms.Label lblBottle;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtBottle;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private Designer.LineSeparator lineSeparator2;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}