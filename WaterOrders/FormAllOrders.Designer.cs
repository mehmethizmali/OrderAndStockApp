namespace WaterOrders
{
    partial class FormAllOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllOrders));
            this.pnlOrdersSearch = new System.Windows.Forms.Panel();
            this.txtPOrdersSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.lsvAllOrders = new System.Windows.Forms.ListView();
            this.OrdersID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BranchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.pnlOrdersSearch.Location = new System.Drawing.Point(594, 20);
            this.pnlOrdersSearch.Name = "pnlOrdersSearch";
            this.pnlOrdersSearch.Size = new System.Drawing.Size(173, 23);
            this.pnlOrdersSearch.TabIndex = 15;
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
            this.grpOrders.Controls.Add(this.lsvAllOrders);
            this.grpOrders.Location = new System.Drawing.Point(12, 52);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(766, 377);
            this.grpOrders.TabIndex = 14;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Tüm Siparişler";
            // 
            // lsvAllOrders
            // 
            this.lsvAllOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrdersID,
            this.BranchName,
            this.CustomerName,
            this.ProductName,
            this.OrdersDate,
            this.OrdersStatu});
            this.lsvAllOrders.FullRowSelect = true;
            this.lsvAllOrders.GridLines = true;
            this.lsvAllOrders.Location = new System.Drawing.Point(22, 42);
            this.lsvAllOrders.Name = "lsvAllOrders";
            this.lsvAllOrders.Size = new System.Drawing.Size(733, 306);
            this.lsvAllOrders.TabIndex = 12;
            this.lsvAllOrders.UseCompatibleStateImageBehavior = false;
            this.lsvAllOrders.View = System.Windows.Forms.View.Details;
            // 
            // OrdersID
            // 
            this.OrdersID.Text = "Sipariş ID";
            this.OrdersID.Width = 110;
            // 
            // BranchName
            // 
            this.BranchName.Text = "Bayi";
            this.BranchName.Width = 159;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "Adı Soyadı";
            this.CustomerName.Width = 144;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Ürün Adı";
            this.ProductName.Width = 120;
            // 
            // OrdersDate
            // 
            this.OrdersDate.Text = "Sipariş Tarihi";
            this.OrdersDate.Width = 98;
            // 
            // OrdersStatu
            // 
            this.OrdersStatu.Text = "Sipariş Durumu";
            this.OrdersStatu.Width = 98;
            // 
            // FormAllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOrdersSearch);
            this.Controls.Add(this.grpOrders);
            this.Name = "FormAllOrders";
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
        private System.Windows.Forms.ListView lsvAllOrders;
        private System.Windows.Forms.ColumnHeader OrdersID;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader OrdersDate;
        private System.Windows.Forms.ColumnHeader OrdersStatu;
        private System.Windows.Forms.ColumnHeader BranchName;
    }
}