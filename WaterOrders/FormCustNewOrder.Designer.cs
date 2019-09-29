namespace WaterOrders
{
    partial class FormCustNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustNewOrder));
            this.grpCustOrder = new System.Windows.Forms.GroupBox();
            this.btnNewOrders = new System.Windows.Forms.Button();
            this.pnlCustOrderSearch = new System.Windows.Forms.Panel();
            this.txtCustOrderSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.lsvNewOrder = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BranchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReamainingStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustOrder.SuspendLayout();
            this.pnlCustOrderSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustOrder
            // 
            this.grpCustOrder.BackColor = System.Drawing.Color.Transparent;
            this.grpCustOrder.Controls.Add(this.btnNewOrders);
            this.grpCustOrder.Controls.Add(this.pnlCustOrderSearch);
            this.grpCustOrder.Controls.Add(this.lsvNewOrder);
            this.grpCustOrder.Location = new System.Drawing.Point(15, 47);
            this.grpCustOrder.Name = "grpCustOrder";
            this.grpCustOrder.Size = new System.Drawing.Size(771, 387);
            this.grpCustOrder.TabIndex = 9;
            this.grpCustOrder.TabStop = false;
            this.grpCustOrder.Text = "Yeni Sipariş";
            // 
            // btnNewOrders
            // 
            this.btnNewOrders.BackColor = System.Drawing.Color.Gold;
            this.btnNewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewOrders.Location = new System.Drawing.Point(600, 319);
            this.btnNewOrders.Name = "btnNewOrders";
            this.btnNewOrders.Size = new System.Drawing.Size(153, 41);
            this.btnNewOrders.TabIndex = 46;
            this.btnNewOrders.Text = "Sepete Ekle";
            this.btnNewOrders.UseVisualStyleBackColor = false;
            this.btnNewOrders.Click += new System.EventHandler(this.BtnNewOrders_Click);
            // 
            // pnlCustOrderSearch
            // 
            this.pnlCustOrderSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlCustOrderSearch.Controls.Add(this.txtCustOrderSearch);
            this.pnlCustOrderSearch.Controls.Add(this.panel2);
            this.pnlCustOrderSearch.Location = new System.Drawing.Point(580, 38);
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
            // lsvNewOrder
            // 
            this.lsvNewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.ProductName,
            this.BranchName,
            this.ReamainingStock,
            this.UnitPrice});
            this.lsvNewOrder.FullRowSelect = true;
            this.lsvNewOrder.GridLines = true;
            this.lsvNewOrder.Location = new System.Drawing.Point(17, 75);
            this.lsvNewOrder.Name = "lsvNewOrder";
            this.lsvNewOrder.Size = new System.Drawing.Size(736, 238);
            this.lsvNewOrder.TabIndex = 12;
            this.lsvNewOrder.UseCompatibleStateImageBehavior = false;
            this.lsvNewOrder.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "Ürün Sırası";
            this.ProductID.Width = 191;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Ürün Adı";
            this.ProductName.Width = 115;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Fiyatı";
            this.UnitPrice.Width = 158;
            // 
            // BranchName
            // 
            this.BranchName.Text = "Bayi Adı";
            this.BranchName.Width = 145;
            // 
            // ReamainingStock
            // 
            this.ReamainingStock.Text = "Kalan Stok";
            this.ReamainingStock.Width = 114;
            // 
            // FormCustNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpCustOrder);
            this.Name = "FormCustNewOrder";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpCustOrder.ResumeLayout(false);
            this.pnlCustOrderSearch.ResumeLayout(false);
            this.pnlCustOrderSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustOrder;
        private System.Windows.Forms.Panel pnlCustOrderSearch;
        private System.Windows.Forms.TextBox txtCustOrderSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctCustomerSearch;
        private System.Windows.Forms.ListView lsvNewOrder;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.Button btnNewOrders;
        private System.Windows.Forms.ColumnHeader BranchName;
        private System.Windows.Forms.ColumnHeader ReamainingStock;
    }
}