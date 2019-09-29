namespace WaterOrders
{
    partial class FormStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStocks));
            this.IslemDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Branches = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pctStockEdit = new System.Windows.Forms.PictureBox();
            this.pctStockRefresh = new System.Windows.Forms.PictureBox();
            this.pctStockAdd = new System.Windows.Forms.PictureBox();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvStocks = new System.Windows.Forms.ListView();
            this.pctStockDelete = new System.Windows.Forms.PictureBox();
            this.grpProductIslemler = new System.Windows.Forms.GroupBox();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.txtStockSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBranchStock = new System.Windows.Forms.GroupBox();
            this.RemainingStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pctStockEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStockRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStockAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStockDelete)).BeginInit();
            this.grpProductIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpBranchStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // IslemDurumu
            // 
            this.IslemDurumu.Text = "Satış Devam Ediyor Mu";
            this.IslemDurumu.Width = 184;
            // 
            // UnitInStock
            // 
            this.UnitInStock.Text = "Toplam Stok";
            this.UnitInStock.Width = 83;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Fiyatı";
            this.UnitPrice.Width = 102;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Ürün Adı";
            this.ProductName.Width = 125;
            // 
            // Branches
            // 
            this.Branches.Text = "Bayi";
            this.Branches.Width = 125;
            // 
            // pctStockEdit
            // 
            this.pctStockEdit.Image = ((System.Drawing.Image)(resources.GetObject("pctStockEdit.Image")));
            this.pctStockEdit.Location = new System.Drawing.Point(145, 17);
            this.pctStockEdit.Name = "pctStockEdit";
            this.pctStockEdit.Size = new System.Drawing.Size(63, 50);
            this.pctStockEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctStockEdit.TabIndex = 2;
            this.pctStockEdit.TabStop = false;
            this.pctStockEdit.Click += new System.EventHandler(this.PctStockEdit_Click);
            // 
            // pctStockRefresh
            // 
            this.pctStockRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pctStockRefresh.Image")));
            this.pctStockRefresh.Location = new System.Drawing.Point(7, 17);
            this.pctStockRefresh.Name = "pctStockRefresh";
            this.pctStockRefresh.Size = new System.Drawing.Size(63, 50);
            this.pctStockRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctStockRefresh.TabIndex = 4;
            this.pctStockRefresh.TabStop = false;
            this.pctStockRefresh.Click += new System.EventHandler(this.PctStockRefresh_Click);
            // 
            // pctStockAdd
            // 
            this.pctStockAdd.Image = ((System.Drawing.Image)(resources.GetObject("pctStockAdd.Image")));
            this.pctStockAdd.Location = new System.Drawing.Point(76, 17);
            this.pctStockAdd.Name = "pctStockAdd";
            this.pctStockAdd.Size = new System.Drawing.Size(63, 50);
            this.pctStockAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctStockAdd.TabIndex = 0;
            this.pctStockAdd.TabStop = false;
            this.pctStockAdd.Click += new System.EventHandler(this.PctStockAdd_Click);
            // 
            // ProductID
            // 
            this.ProductID.Text = "ID";
            this.ProductID.Width = 38;
            // 
            // lsvStocks
            // 
            this.lsvStocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.Branches,
            this.ProductName,
            this.UnitPrice,
            this.UnitInStock,
            this.RemainingStock,
            this.IslemDurumu});
            this.lsvStocks.FullRowSelect = true;
            this.lsvStocks.GridLines = true;
            this.lsvStocks.Location = new System.Drawing.Point(20, 41);
            this.lsvStocks.Name = "lsvStocks";
            this.lsvStocks.Size = new System.Drawing.Size(733, 250);
            this.lsvStocks.TabIndex = 12;
            this.lsvStocks.UseCompatibleStateImageBehavior = false;
            this.lsvStocks.View = System.Windows.Forms.View.Details;
            // 
            // pctStockDelete
            // 
            this.pctStockDelete.Image = ((System.Drawing.Image)(resources.GetObject("pctStockDelete.Image")));
            this.pctStockDelete.Location = new System.Drawing.Point(214, 17);
            this.pctStockDelete.Name = "pctStockDelete";
            this.pctStockDelete.Size = new System.Drawing.Size(63, 50);
            this.pctStockDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctStockDelete.TabIndex = 1;
            this.pctStockDelete.TabStop = false;
            this.pctStockDelete.Click += new System.EventHandler(this.PctStockDelete_Click);
            // 
            // grpProductIslemler
            // 
            this.grpProductIslemler.Controls.Add(this.pctStockEdit);
            this.grpProductIslemler.Controls.Add(this.pctStockRefresh);
            this.grpProductIslemler.Controls.Add(this.pctStockAdd);
            this.grpProductIslemler.Controls.Add(this.pctStockDelete);
            this.grpProductIslemler.Location = new System.Drawing.Point(476, 297);
            this.grpProductIslemler.Name = "grpProductIslemler";
            this.grpProductIslemler.Size = new System.Drawing.Size(284, 74);
            this.grpProductIslemler.TabIndex = 5;
            this.grpProductIslemler.TabStop = false;
            this.grpProductIslemler.Text = "İşlemler";
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
            // txtStockSearch
            // 
            this.txtStockSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStockSearch.Location = new System.Drawing.Point(1, 1);
            this.txtStockSearch.Multiline = true;
            this.txtStockSearch.Name = "txtStockSearch";
            this.txtStockSearch.Size = new System.Drawing.Size(137, 21);
            this.txtStockSearch.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.txtStockSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(599, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 23);
            this.panel1.TabIndex = 9;
            // 
            // grpBranchStock
            // 
            this.grpBranchStock.Controls.Add(this.lsvStocks);
            this.grpBranchStock.Controls.Add(this.grpProductIslemler);
            this.grpBranchStock.Location = new System.Drawing.Point(17, 53);
            this.grpBranchStock.Name = "grpBranchStock";
            this.grpBranchStock.Size = new System.Drawing.Size(766, 377);
            this.grpBranchStock.TabIndex = 8;
            this.grpBranchStock.TabStop = false;
            this.grpBranchStock.Text = "Bayi Stokları";
            // 
            // RemainingStock
            // 
            this.RemainingStock.Text = "Kalan Stok";
            this.RemainingStock.Width = 71;
            // 
            // FormStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBranchStock);
            this.Name = "FormStocks";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctStockEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStockRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStockAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStockDelete)).EndInit();
            this.grpProductIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBranchStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader IslemDurumu;
        private System.Windows.Forms.ColumnHeader UnitInStock;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Branches;
        private System.Windows.Forms.PictureBox pctStockEdit;
        private System.Windows.Forms.PictureBox pctStockRefresh;
        private System.Windows.Forms.PictureBox pctStockAdd;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ListView lsvStocks;
        private System.Windows.Forms.PictureBox pctStockDelete;
        private System.Windows.Forms.GroupBox grpProductIslemler;
        private System.Windows.Forms.PictureBox pctCustomerSearch;
        private System.Windows.Forms.TextBox txtStockSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBranchStock;
        private System.Windows.Forms.ColumnHeader RemainingStock;
    }
}