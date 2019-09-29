namespace WaterOrders
{
    partial class FormCustNewOrders2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustNewOrders2));
            this.grpCustOrder = new System.Windows.Forms.GroupBox();
            this.btnNewOrders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCustTotalPrice = new System.Windows.Forms.TextBox();
            this.lblCustTotalPrice = new System.Windows.Forms.Label();
            this.nudCustProductCount = new System.Windows.Forms.NumericUpDown();
            this.lblCustProductCount = new System.Windows.Forms.Label();
            this.pnlCustOrderSearch = new System.Windows.Forms.Panel();
            this.txtCustOrderSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.cmbCustBranchName = new System.Windows.Forms.ComboBox();
            this.lblCustBranchName = new System.Windows.Forms.Label();
            this.cmbCustProductName = new System.Windows.Forms.ComboBox();
            this.lblCustProductName = new System.Windows.Forms.Label();
            this.lsvNewOrder = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalInPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpProductIslemler = new System.Windows.Forms.GroupBox();
            this.pctpctOrderDelete = new System.Windows.Forms.PictureBox();
            this.pctOrderAllDelete = new System.Windows.Forms.PictureBox();
            this.grpCustOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustProductCount)).BeginInit();
            this.pnlCustOrderSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).BeginInit();
            this.grpProductIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctpctOrderDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOrderAllDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustOrder
            // 
            this.grpCustOrder.BackColor = System.Drawing.Color.Transparent;
            this.grpCustOrder.Controls.Add(this.btnNewOrders);
            this.grpCustOrder.Controls.Add(this.pictureBox1);
            this.grpCustOrder.Controls.Add(this.txtCustTotalPrice);
            this.grpCustOrder.Controls.Add(this.lblCustTotalPrice);
            this.grpCustOrder.Controls.Add(this.nudCustProductCount);
            this.grpCustOrder.Controls.Add(this.lblCustProductCount);
            this.grpCustOrder.Controls.Add(this.pnlCustOrderSearch);
            this.grpCustOrder.Controls.Add(this.cmbCustBranchName);
            this.grpCustOrder.Controls.Add(this.lblCustBranchName);
            this.grpCustOrder.Controls.Add(this.cmbCustProductName);
            this.grpCustOrder.Controls.Add(this.lblCustProductName);
            this.grpCustOrder.Controls.Add(this.lsvNewOrder);
            this.grpCustOrder.Controls.Add(this.grpProductIslemler);
            this.grpCustOrder.Location = new System.Drawing.Point(12, 12);
            this.grpCustOrder.Name = "grpCustOrder";
            this.grpCustOrder.Size = new System.Drawing.Size(771, 418);
            this.grpCustOrder.TabIndex = 8;
            this.grpCustOrder.TabStop = false;
            this.grpCustOrder.Text = "Ürün Sepeti";
            // 
            // btnNewOrders
            // 
            this.btnNewOrders.BackColor = System.Drawing.Color.Gold;
            this.btnNewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewOrders.Location = new System.Drawing.Point(600, 352);
            this.btnNewOrders.Name = "btnNewOrders";
            this.btnNewOrders.Size = new System.Drawing.Size(153, 41);
            this.btnNewOrders.TabIndex = 46;
            this.btnNewOrders.Text = "Sipariş Ver";
            this.btnNewOrders.UseVisualStyleBackColor = false;
            this.btnNewOrders.Click += new System.EventHandler(this.BtnNewOrders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtCustTotalPrice
            // 
            this.txtCustTotalPrice.Location = new System.Drawing.Point(514, 32);
            this.txtCustTotalPrice.Name = "txtCustTotalPrice";
            this.txtCustTotalPrice.Size = new System.Drawing.Size(122, 20);
            this.txtCustTotalPrice.TabIndex = 45;
            // 
            // lblCustTotalPrice
            // 
            this.lblCustTotalPrice.AutoSize = true;
            this.lblCustTotalPrice.Location = new System.Drawing.Point(466, 36);
            this.lblCustTotalPrice.Name = "lblCustTotalPrice";
            this.lblCustTotalPrice.Size = new System.Drawing.Size(42, 13);
            this.lblCustTotalPrice.TabIndex = 44;
            this.lblCustTotalPrice.Text = "Toplam";
            // 
            // nudCustProductCount
            // 
            this.nudCustProductCount.Location = new System.Drawing.Point(384, 32);
            this.nudCustProductCount.Name = "nudCustProductCount";
            this.nudCustProductCount.Size = new System.Drawing.Size(63, 20);
            this.nudCustProductCount.TabIndex = 43;
            this.nudCustProductCount.ValueChanged += new System.EventHandler(this.NudCustProductCount_ValueChanged);
            // 
            // lblCustProductCount
            // 
            this.lblCustProductCount.AutoSize = true;
            this.lblCustProductCount.Location = new System.Drawing.Point(349, 36);
            this.lblCustProductCount.Name = "lblCustProductCount";
            this.lblCustProductCount.Size = new System.Drawing.Size(29, 13);
            this.lblCustProductCount.TabIndex = 42;
            this.lblCustProductCount.Text = "Adet";
            // 
            // pnlCustOrderSearch
            // 
            this.pnlCustOrderSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCustOrderSearch.Controls.Add(this.txtCustOrderSearch);
            this.pnlCustOrderSearch.Controls.Add(this.panel2);
            this.pnlCustOrderSearch.Location = new System.Drawing.Point(580, 91);
            this.pnlCustOrderSearch.Name = "pnlCustOrderSearch";
            this.pnlCustOrderSearch.Size = new System.Drawing.Size(173, 23);
            this.pnlCustOrderSearch.TabIndex = 41;
            // 
            // txtCustOrderSearch
            // 
            this.txtCustOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustOrderSearch.Location = new System.Drawing.Point(1, 1);
            this.txtCustOrderSearch.Multiline = true;
            this.txtCustOrderSearch.Name = "txtCustOrderSearch";
            this.txtCustOrderSearch.Size = new System.Drawing.Size(137, 21);
            this.txtCustOrderSearch.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pctCustomerSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(138, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 23);
            this.panel2.TabIndex = 0;
            // 
            // pctCustomerSearch
            // 
            this.pctCustomerSearch.Image = ((System.Drawing.Image)(resources.GetObject("pctCustomerSearch.Image")));
            this.pctCustomerSearch.Location = new System.Drawing.Point(1, 0);
            this.pctCustomerSearch.Name = "pctCustomerSearch";
            this.pctCustomerSearch.Size = new System.Drawing.Size(34, 23);
            this.pctCustomerSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCustomerSearch.TabIndex = 0;
            this.pctCustomerSearch.TabStop = false;
            // 
            // cmbCustBranchName
            // 
            this.cmbCustBranchName.FormattingEnabled = true;
            this.cmbCustBranchName.Location = new System.Drawing.Point(213, 32);
            this.cmbCustBranchName.Name = "cmbCustBranchName";
            this.cmbCustBranchName.Size = new System.Drawing.Size(122, 21);
            this.cmbCustBranchName.TabIndex = 40;
            this.cmbCustBranchName.TextUpdate += new System.EventHandler(this.CmbCustBranchName_TextUpdate);
            // 
            // lblCustBranchName
            // 
            this.lblCustBranchName.AutoSize = true;
            this.lblCustBranchName.Location = new System.Drawing.Point(180, 37);
            this.lblCustBranchName.Name = "lblCustBranchName";
            this.lblCustBranchName.Size = new System.Drawing.Size(27, 13);
            this.lblCustBranchName.TabIndex = 39;
            this.lblCustBranchName.Text = "Bayi";
            // 
            // cmbCustProductName
            // 
            this.cmbCustProductName.FormattingEnabled = true;
            this.cmbCustProductName.Location = new System.Drawing.Point(45, 32);
            this.cmbCustProductName.Name = "cmbCustProductName";
            this.cmbCustProductName.Size = new System.Drawing.Size(122, 21);
            this.cmbCustProductName.TabIndex = 38;
            this.cmbCustProductName.SelectedIndexChanged += new System.EventHandler(this.CmbCustProductName_SelectedIndexChanged);
            this.cmbCustProductName.TextUpdate += new System.EventHandler(this.CmbCustProductName_TextUpdate);
            // 
            // lblCustProductName
            // 
            this.lblCustProductName.AutoSize = true;
            this.lblCustProductName.Location = new System.Drawing.Point(9, 35);
            this.lblCustProductName.Name = "lblCustProductName";
            this.lblCustProductName.Size = new System.Drawing.Size(30, 13);
            this.lblCustProductName.TabIndex = 37;
            this.lblCustProductName.Text = "Ürün";
            // 
            // lsvNewOrder
            // 
            this.lsvNewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.ProductName,
            this.UnitPrice,
            this.ProductCount,
            this.TotalInPrice});
            this.lsvNewOrder.FullRowSelect = true;
            this.lsvNewOrder.GridLines = true;
            this.lsvNewOrder.Location = new System.Drawing.Point(17, 120);
            this.lsvNewOrder.Name = "lsvNewOrder";
            this.lsvNewOrder.Size = new System.Drawing.Size(736, 206);
            this.lsvNewOrder.TabIndex = 12;
            this.lsvNewOrder.UseCompatibleStateImageBehavior = false;
            this.lsvNewOrder.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "ID";
            this.ProductID.Width = 83;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Ürün Adı";
            this.ProductName.Width = 176;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Fiyatı";
            this.UnitPrice.Width = 163;
            // 
            // ProductCount
            // 
            this.ProductCount.Text = "Adet";
            this.ProductCount.Width = 145;
            // 
            // TotalInPrice
            // 
            this.TotalInPrice.Text = "Toplam Tutar";
            this.TotalInPrice.Width = 163;
            // 
            // grpProductIslemler
            // 
            this.grpProductIslemler.Controls.Add(this.pctpctOrderDelete);
            this.grpProductIslemler.Controls.Add(this.pctOrderAllDelete);
            this.grpProductIslemler.Location = new System.Drawing.Point(17, 334);
            this.grpProductIslemler.Name = "grpProductIslemler";
            this.grpProductIslemler.Size = new System.Drawing.Size(168, 74);
            this.grpProductIslemler.TabIndex = 5;
            this.grpProductIslemler.TabStop = false;
            this.grpProductIslemler.Text = "Sepetten Çıkar";
            // 
            // pctpctOrderDelete
            // 
            this.pctpctOrderDelete.Image = ((System.Drawing.Image)(resources.GetObject("pctpctOrderDelete.Image")));
            this.pctpctOrderDelete.Location = new System.Drawing.Point(87, 19);
            this.pctpctOrderDelete.Name = "pctpctOrderDelete";
            this.pctpctOrderDelete.Size = new System.Drawing.Size(63, 48);
            this.pctpctOrderDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctpctOrderDelete.TabIndex = 4;
            this.pctpctOrderDelete.TabStop = false;
            this.pctpctOrderDelete.Click += new System.EventHandler(this.PctpctOrderDelete_Click);
            // 
            // pctOrderAllDelete
            // 
            this.pctOrderAllDelete.Image = ((System.Drawing.Image)(resources.GetObject("pctOrderAllDelete.Image")));
            this.pctOrderAllDelete.Location = new System.Drawing.Point(18, 18);
            this.pctOrderAllDelete.Name = "pctOrderAllDelete";
            this.pctOrderAllDelete.Size = new System.Drawing.Size(57, 50);
            this.pctOrderAllDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOrderAllDelete.TabIndex = 1;
            this.pctOrderAllDelete.TabStop = false;
            this.pctOrderAllDelete.Click += new System.EventHandler(this.PctOrderAllDelete_Click);
            // 
            // FormCustNewOrders2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpCustOrder);
            this.Name = "FormCustNewOrders2";
            this.ShowIcon = false;
            this.Text = "Yeni Sipariş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpCustOrder.ResumeLayout(false);
            this.grpCustOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustProductCount)).EndInit();
            this.pnlCustOrderSearch.ResumeLayout(false);
            this.pnlCustOrderSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).EndInit();
            this.grpProductIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctpctOrderDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOrderAllDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCustOrder;
        private System.Windows.Forms.ListView lsvNewOrder;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader ProductCount;
        private System.Windows.Forms.ColumnHeader TotalInPrice;
        private System.Windows.Forms.GroupBox grpProductIslemler;
        private System.Windows.Forms.PictureBox pctpctOrderDelete;
        private System.Windows.Forms.PictureBox pctOrderAllDelete;
        private System.Windows.Forms.Panel pnlCustOrderSearch;
        private System.Windows.Forms.TextBox txtCustOrderSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctCustomerSearch;
        private System.Windows.Forms.ComboBox cmbCustBranchName;
        private System.Windows.Forms.Label lblCustBranchName;
        private System.Windows.Forms.ComboBox cmbCustProductName;
        private System.Windows.Forms.Label lblCustProductName;
        private System.Windows.Forms.NumericUpDown nudCustProductCount;
        private System.Windows.Forms.Label lblCustProductCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCustTotalPrice;
        private System.Windows.Forms.Label lblCustTotalPrice;
        private System.Windows.Forms.Button btnNewOrders;
    }
}