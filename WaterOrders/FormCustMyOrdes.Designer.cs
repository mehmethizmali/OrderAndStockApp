namespace WaterOrders
{
    partial class FormCustMyOrdes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustMyOrdes));
            this.pnlOrdersSearch = new System.Windows.Forms.Panel();
            this.txtPOrdersSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.btnOrderDetail = new System.Windows.Forms.Button();
            this.lsvOrders = new System.Windows.Forms.ListView();
            this.OrdersID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersStatu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlOrdersSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).BeginInit();
            this.grpOrders.SuspendLayout();
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
            this.pnlOrdersSearch.TabIndex = 9;
            // 
            // txtPOrdersSearch
            // 
            this.txtPOrdersSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPOrdersSearch.Location = new System.Drawing.Point(1, 1);
            this.txtPOrdersSearch.Multiline = true;
            this.txtPOrdersSearch.Name = "txtPOrdersSearch";
            this.txtPOrdersSearch.Size = new System.Drawing.Size(137, 21);
            this.txtPOrdersSearch.TabIndex = 1;
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
            this.grpOrders.Controls.Add(this.btnOrderDetail);
            this.grpOrders.Controls.Add(this.lsvOrders);
            this.grpOrders.Location = new System.Drawing.Point(17, 53);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(766, 377);
            this.grpOrders.TabIndex = 8;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Siparişlerim";
            // 
            // btnOrderDetail
            // 
            this.btnOrderDetail.BackColor = System.Drawing.Color.Yellow;
            this.btnOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderDetail.ForeColor = System.Drawing.Color.Black;
            this.btnOrderDetail.Location = new System.Drawing.Point(616, 325);
            this.btnOrderDetail.Name = "btnOrderDetail";
            this.btnOrderDetail.Size = new System.Drawing.Size(137, 35);
            this.btnOrderDetail.TabIndex = 15;
            this.btnOrderDetail.Text = "Sipariş Detay";
            this.btnOrderDetail.UseVisualStyleBackColor = false;
            this.btnOrderDetail.Click += new System.EventHandler(this.BtnOrderDetail_Click);
            // 
            // lsvOrders
            // 
            this.lsvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrdersID,
            this.ProductName,
            this.OrdersDate,
            this.OrdersStatu});
            this.lsvOrders.FullRowSelect = true;
            this.lsvOrders.GridLines = true;
            this.lsvOrders.Location = new System.Drawing.Point(20, 41);
            this.lsvOrders.Name = "lsvOrders";
            this.lsvOrders.Size = new System.Drawing.Size(733, 267);
            this.lsvOrders.TabIndex = 12;
            this.lsvOrders.UseCompatibleStateImageBehavior = false;
            this.lsvOrders.View = System.Windows.Forms.View.Details;
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
            // OrdersDate
            // 
            this.OrdersDate.Text = "Sipariş Tarihi";
            this.OrdersDate.Width = 289;
            // 
            // OrdersStatu
            // 
            this.OrdersStatu.Text = "Sipariş Durumu";
            this.OrdersStatu.Width = 160;
            // 
            // FormCustMyOrdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOrdersSearch);
            this.Controls.Add(this.grpOrders);
            this.Name = "FormCustMyOrdes";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlOrdersSearch.ResumeLayout(false);
            this.pnlOrdersSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).EndInit();
            this.grpOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrdersSearch;
        private System.Windows.Forms.TextBox txtPOrdersSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctCustomerSearch;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.ListView lsvOrders;
        private System.Windows.Forms.ColumnHeader OrdersID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader OrdersDate;
        private System.Windows.Forms.ColumnHeader OrdersStatu;
        private System.Windows.Forms.Button btnOrderDetail;
    }
}