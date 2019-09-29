namespace WaterOrders
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.pnlProductSearch = new System.Windows.Forms.Panel();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.grpProductIslemler = new System.Windows.Forms.GroupBox();
            this.pctProductEdit = new System.Windows.Forms.PictureBox();
            this.pctProductRefresh = new System.Windows.Forms.PictureBox();
            this.pctProductAdd = new System.Windows.Forms.PictureBox();
            this.pctProductDelete = new System.Windows.Forms.PictureBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.lsvOrders = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemainingStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlProductSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).BeginInit();
            this.grpProductIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductDelete)).BeginInit();
            this.grpProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProductSearch
            // 
            this.pnlProductSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlProductSearch.Controls.Add(this.txtProductSearch);
            this.pnlProductSearch.Controls.Add(this.panel2);
            this.pnlProductSearch.Location = new System.Drawing.Point(604, 29);
            this.pnlProductSearch.Name = "pnlProductSearch";
            this.pnlProductSearch.Size = new System.Drawing.Size(173, 23);
            this.pnlProductSearch.TabIndex = 7;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductSearch.Location = new System.Drawing.Point(1, 1);
            this.txtProductSearch.Multiline = true;
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(137, 21);
            this.txtProductSearch.TabIndex = 1;
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
            // grpProductIslemler
            // 
            this.grpProductIslemler.Controls.Add(this.pctProductEdit);
            this.grpProductIslemler.Controls.Add(this.pctProductRefresh);
            this.grpProductIslemler.Controls.Add(this.pctProductAdd);
            this.grpProductIslemler.Controls.Add(this.pctProductDelete);
            this.grpProductIslemler.Location = new System.Drawing.Point(476, 297);
            this.grpProductIslemler.Name = "grpProductIslemler";
            this.grpProductIslemler.Size = new System.Drawing.Size(284, 74);
            this.grpProductIslemler.TabIndex = 5;
            this.grpProductIslemler.TabStop = false;
            this.grpProductIslemler.Text = "İşlemler";
            // 
            // pctProductEdit
            // 
            this.pctProductEdit.Image = ((System.Drawing.Image)(resources.GetObject("pctProductEdit.Image")));
            this.pctProductEdit.Location = new System.Drawing.Point(145, 17);
            this.pctProductEdit.Name = "pctProductEdit";
            this.pctProductEdit.Size = new System.Drawing.Size(63, 50);
            this.pctProductEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctProductEdit.TabIndex = 2;
            this.pctProductEdit.TabStop = false;
            this.pctProductEdit.Click += new System.EventHandler(this.PctProductEdit_Click);
            // 
            // pctProductRefresh
            // 
            this.pctProductRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pctProductRefresh.Image")));
            this.pctProductRefresh.Location = new System.Drawing.Point(7, 17);
            this.pctProductRefresh.Name = "pctProductRefresh";
            this.pctProductRefresh.Size = new System.Drawing.Size(63, 50);
            this.pctProductRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctProductRefresh.TabIndex = 4;
            this.pctProductRefresh.TabStop = false;
            this.pctProductRefresh.Click += new System.EventHandler(this.PctProductRefresh_Click);
            // 
            // pctProductAdd
            // 
            this.pctProductAdd.Image = ((System.Drawing.Image)(resources.GetObject("pctProductAdd.Image")));
            this.pctProductAdd.Location = new System.Drawing.Point(76, 17);
            this.pctProductAdd.Name = "pctProductAdd";
            this.pctProductAdd.Size = new System.Drawing.Size(63, 50);
            this.pctProductAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctProductAdd.TabIndex = 0;
            this.pctProductAdd.TabStop = false;
            this.pctProductAdd.Click += new System.EventHandler(this.PctProductAdd_Click);
            // 
            // pctProductDelete
            // 
            this.pctProductDelete.Image = ((System.Drawing.Image)(resources.GetObject("pctProductDelete.Image")));
            this.pctProductDelete.Location = new System.Drawing.Point(214, 17);
            this.pctProductDelete.Name = "pctProductDelete";
            this.pctProductDelete.Size = new System.Drawing.Size(63, 50);
            this.pctProductDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctProductDelete.TabIndex = 1;
            this.pctProductDelete.TabStop = false;
            this.pctProductDelete.Click += new System.EventHandler(this.PctProductDelete_Click);
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.lsvOrders);
            this.grpProduct.Controls.Add(this.grpProductIslemler);
            this.grpProduct.Location = new System.Drawing.Point(22, 61);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(766, 377);
            this.grpProduct.TabIndex = 6;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Ürünler";
            // 
            // lsvOrders
            // 
            this.lsvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.ProductName,
            this.UnitPrice,
            this.RemainingStock,
            this.TotalInStock,
            this.Categories});
            this.lsvOrders.FullRowSelect = true;
            this.lsvOrders.GridLines = true;
            this.lsvOrders.Location = new System.Drawing.Point(20, 41);
            this.lsvOrders.Name = "lsvOrders";
            this.lsvOrders.Size = new System.Drawing.Size(733, 250);
            this.lsvOrders.TabIndex = 12;
            this.lsvOrders.UseCompatibleStateImageBehavior = false;
            this.lsvOrders.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "ID";
            this.ProductID.Width = 45;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Ürün Adı";
            this.ProductName.Width = 149;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Fiyatı";
            this.UnitPrice.Width = 132;
            // 
            // RemainingStock
            // 
            this.RemainingStock.Text = "Kalan Stok";
            this.RemainingStock.Width = 125;
            // 
            // TotalInStock
            // 
            this.TotalInStock.Text = "Toplam Stok";
            this.TotalInStock.Width = 129;
            // 
            // Categories
            // 
            this.Categories.Text = "Kategorisi";
            this.Categories.Width = 148;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlProductSearch);
            this.Controls.Add(this.grpProduct);
            this.Name = "FormProduct";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlProductSearch.ResumeLayout(false);
            this.pnlProductSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).EndInit();
            this.grpProductIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctProductEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProductDelete)).EndInit();
            this.grpProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductSearch;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctCustomerSearch;
        private System.Windows.Forms.GroupBox grpProductIslemler;
        private System.Windows.Forms.PictureBox pctProductEdit;
        private System.Windows.Forms.PictureBox pctProductRefresh;
        private System.Windows.Forms.PictureBox pctProductAdd;
        private System.Windows.Forms.PictureBox pctProductDelete;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.ListView lsvOrders;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader TotalInStock;
        private System.Windows.Forms.ColumnHeader Categories;
        private System.Windows.Forms.ColumnHeader RemainingStock;
    }
}