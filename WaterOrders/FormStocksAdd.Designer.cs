namespace WaterOrders
{
    partial class FormStocksAdd
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
            this.chckStockOrderStart = new System.Windows.Forms.CheckBox();
            this.btnStockProductAdd = new System.Windows.Forms.Button();
            this.txtStockProductCount = new System.Windows.Forms.TextBox();
            this.lblStockProductCount = new System.Windows.Forms.Label();
            this.cmbStockBranchName = new System.Windows.Forms.ComboBox();
            this.lblStockBranch = new System.Windows.Forms.Label();
            this.cmbStockProductName = new System.Windows.Forms.ComboBox();
            this.lblStockProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chckStockOrderStart
            // 
            this.chckStockOrderStart.AutoSize = true;
            this.chckStockOrderStart.Location = new System.Drawing.Point(144, 141);
            this.chckStockOrderStart.Name = "chckStockOrderStart";
            this.chckStockOrderStart.Size = new System.Drawing.Size(141, 17);
            this.chckStockOrderStart.TabIndex = 49;
            this.chckStockOrderStart.Text = "Satışı İşlemi Başlasın mı?";
            this.chckStockOrderStart.UseVisualStyleBackColor = true;
            // 
            // btnStockProductAdd
            // 
            this.btnStockProductAdd.Location = new System.Drawing.Point(225, 175);
            this.btnStockProductAdd.Name = "btnStockProductAdd";
            this.btnStockProductAdd.Size = new System.Drawing.Size(75, 31);
            this.btnStockProductAdd.TabIndex = 42;
            this.btnStockProductAdd.Text = "Kaydet";
            this.btnStockProductAdd.UseVisualStyleBackColor = true;
            this.btnStockProductAdd.Click += new System.EventHandler(this.BtnStockProductAdd_Click);
            // 
            // txtStockProductCount
            // 
            this.txtStockProductCount.Location = new System.Drawing.Point(144, 98);
            this.txtStockProductCount.Name = "txtStockProductCount";
            this.txtStockProductCount.Size = new System.Drawing.Size(156, 20);
            this.txtStockProductCount.TabIndex = 41;
            // 
            // lblStockProductCount
            // 
            this.lblStockProductCount.AutoSize = true;
            this.lblStockProductCount.Location = new System.Drawing.Point(58, 101);
            this.lblStockProductCount.Name = "lblStockProductCount";
            this.lblStockProductCount.Size = new System.Drawing.Size(29, 13);
            this.lblStockProductCount.TabIndex = 40;
            this.lblStockProductCount.Text = "Adet";
            // 
            // cmbStockBranchName
            // 
            this.cmbStockBranchName.FormattingEnabled = true;
            this.cmbStockBranchName.Location = new System.Drawing.Point(144, 44);
            this.cmbStockBranchName.Name = "cmbStockBranchName";
            this.cmbStockBranchName.Size = new System.Drawing.Size(156, 21);
            this.cmbStockBranchName.TabIndex = 53;
            // 
            // lblStockBranch
            // 
            this.lblStockBranch.AutoSize = true;
            this.lblStockBranch.Location = new System.Drawing.Point(58, 47);
            this.lblStockBranch.Name = "lblStockBranch";
            this.lblStockBranch.Size = new System.Drawing.Size(27, 13);
            this.lblStockBranch.TabIndex = 52;
            this.lblStockBranch.Text = "Bayi";
            // 
            // cmbStockProductName
            // 
            this.cmbStockProductName.FormattingEnabled = true;
            this.cmbStockProductName.Location = new System.Drawing.Point(144, 71);
            this.cmbStockProductName.Name = "cmbStockProductName";
            this.cmbStockProductName.Size = new System.Drawing.Size(156, 21);
            this.cmbStockProductName.TabIndex = 55;
            // 
            // lblStockProduct
            // 
            this.lblStockProduct.AutoSize = true;
            this.lblStockProduct.Location = new System.Drawing.Point(58, 74);
            this.lblStockProduct.Name = "lblStockProduct";
            this.lblStockProduct.Size = new System.Drawing.Size(48, 13);
            this.lblStockProduct.TabIndex = 54;
            this.lblStockProduct.Text = "Ürün Adı";
            // 
            // FormStocksAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 301);
            this.Controls.Add(this.cmbStockProductName);
            this.Controls.Add(this.lblStockProduct);
            this.Controls.Add(this.cmbStockBranchName);
            this.Controls.Add(this.lblStockBranch);
            this.Controls.Add(this.chckStockOrderStart);
            this.Controls.Add(this.btnStockProductAdd);
            this.Controls.Add(this.txtStockProductCount);
            this.Controls.Add(this.lblStockProductCount);
            this.Name = "FormStocksAdd";
            this.Text = "Bayi Yeni Stok Ekle";
            this.Load += new System.EventHandler(this.FormStocksAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chckStockOrderStart;
        private System.Windows.Forms.Button btnStockProductAdd;
        private System.Windows.Forms.TextBox txtStockProductCount;
        private System.Windows.Forms.Label lblStockProductCount;
        private System.Windows.Forms.ComboBox cmbStockBranchName;
        private System.Windows.Forms.Label lblStockBranch;
        private System.Windows.Forms.ComboBox cmbStockProductName;
        private System.Windows.Forms.Label lblStockProduct;
    }
}