namespace WaterOrders
{
    partial class FormBranchMyOrdes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBranchMyOrdes));
            this.pnlOrdersSearch = new System.Windows.Forms.Panel();
            this.txtPOrdersSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.grpBranchNewOrders = new System.Windows.Forms.GroupBox();
            this.pctOrdersCancel = new System.Windows.Forms.PictureBox();
            this.pctOrdersReady = new System.Windows.Forms.PictureBox();
            this.lsvBranchOrders = new System.Windows.Forms.ListView();
            this.OrdersID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersStatu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlOrdersSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).BeginInit();
            this.grpOrders.SuspendLayout();
            this.grpBranchNewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctOrdersCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOrdersReady)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOrdersSearch
            // 
            this.pnlOrdersSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlOrdersSearch.Controls.Add(this.txtPOrdersSearch);
            this.pnlOrdersSearch.Controls.Add(this.panel2);
            this.pnlOrdersSearch.Location = new System.Drawing.Point(599, 21);
            this.pnlOrdersSearch.Name = "pnlOrdersSearch";
            this.pnlOrdersSearch.Size = new System.Drawing.Size(173, 23);
            this.pnlOrdersSearch.TabIndex = 11;
            // 
            // txtPOrdersSearch
            // 
            this.txtPOrdersSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPOrdersSearch.Location = new System.Drawing.Point(1, 1);
            this.txtPOrdersSearch.Multiline = true;
            this.txtPOrdersSearch.Name = "txtPOrdersSearch";
            this.txtPOrdersSearch.Size = new System.Drawing.Size(137, 21);
            this.txtPOrdersSearch.TabIndex = 1;
            this.txtPOrdersSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPOrdersSearch_KeyPress);
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
            // grpOrders
            // 
            this.grpOrders.Controls.Add(this.grpBranchNewOrders);
            this.grpOrders.Controls.Add(this.lsvBranchOrders);
            this.grpOrders.Location = new System.Drawing.Point(17, 53);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(766, 377);
            this.grpOrders.TabIndex = 10;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Yeni Siparişler";
            // 
            // grpBranchNewOrders
            // 
            this.grpBranchNewOrders.AccessibleName = "BRA";
            this.grpBranchNewOrders.Controls.Add(this.pctOrdersCancel);
            this.grpBranchNewOrders.Controls.Add(this.pctOrdersReady);
            this.grpBranchNewOrders.Location = new System.Drawing.Point(593, 299);
            this.grpBranchNewOrders.Name = "grpBranchNewOrders";
            this.grpBranchNewOrders.Size = new System.Drawing.Size(162, 74);
            this.grpBranchNewOrders.TabIndex = 14;
            this.grpBranchNewOrders.TabStop = false;
            this.grpBranchNewOrders.Text = "İşlemler";
            // 
            // pctOrdersCancel
            // 
            this.pctOrdersCancel.Image = ((System.Drawing.Image)(resources.GetObject("pctOrdersCancel.Image")));
            this.pctOrdersCancel.Location = new System.Drawing.Point(85, 17);
            this.pctOrdersCancel.Name = "pctOrdersCancel";
            this.pctOrdersCancel.Size = new System.Drawing.Size(63, 50);
            this.pctOrdersCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOrdersCancel.TabIndex = 2;
            this.pctOrdersCancel.TabStop = false;
            this.pctOrdersCancel.Click += new System.EventHandler(this.PctOrdersCancel_Click);
            // 
            // pctOrdersReady
            // 
            this.pctOrdersReady.Image = ((System.Drawing.Image)(resources.GetObject("pctOrdersReady.Image")));
            this.pctOrdersReady.Location = new System.Drawing.Point(7, 17);
            this.pctOrdersReady.Name = "pctOrdersReady";
            this.pctOrdersReady.Size = new System.Drawing.Size(63, 50);
            this.pctOrdersReady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOrdersReady.TabIndex = 4;
            this.pctOrdersReady.TabStop = false;
            this.pctOrdersReady.Click += new System.EventHandler(this.PctOrdersReady_Click);
            // 
            // lsvBranchOrders
            // 
            this.lsvBranchOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrdersID,
            this.ProductName,
            this.FullName,
            this.OrdersDate,
            this.OrdersStatu});
            this.lsvBranchOrders.FullRowSelect = true;
            this.lsvBranchOrders.GridLines = true;
            this.lsvBranchOrders.Location = new System.Drawing.Point(20, 41);
            this.lsvBranchOrders.Name = "lsvBranchOrders";
            this.lsvBranchOrders.Size = new System.Drawing.Size(733, 252);
            this.lsvBranchOrders.TabIndex = 12;
            this.lsvBranchOrders.UseCompatibleStateImageBehavior = false;
            this.lsvBranchOrders.View = System.Windows.Forms.View.Details;
            // 
            // OrdersID
            // 
            this.OrdersID.Text = "Sipariş ID";
            this.OrdersID.Width = 110;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Ürün Adı";
            this.ProductName.Width = 167;
            // 
            // FullName
            // 
            this.FullName.Text = "Adı Soyadı";
            this.FullName.Width = 122;
            // 
            // OrdersDate
            // 
            this.OrdersDate.Text = "Sipariş Tarihi";
            this.OrdersDate.Width = 153;
            // 
            // OrdersStatu
            // 
            this.OrdersStatu.Text = "Sipariş Durumu";
            this.OrdersStatu.Width = 173;
            // 
            // FormBranchMyOrdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.pnlOrdersSearch);
            this.Controls.Add(this.grpOrders);
            this.Name = "FormBranchMyOrdes";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlOrdersSearch.ResumeLayout(false);
            this.pnlOrdersSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).EndInit();
            this.grpOrders.ResumeLayout(false);
            this.grpBranchNewOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctOrdersCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOrdersReady)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrdersSearch;
        private System.Windows.Forms.TextBox txtPOrdersSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctCustomerSearch;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.ListView lsvBranchOrders;
        private System.Windows.Forms.ColumnHeader OrdersID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader OrdersDate;
        private System.Windows.Forms.ColumnHeader OrdersStatu;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.GroupBox grpBranchNewOrders;
        private System.Windows.Forms.PictureBox pctOrdersCancel;
        private System.Windows.Forms.PictureBox pctOrdersReady;
    }
}