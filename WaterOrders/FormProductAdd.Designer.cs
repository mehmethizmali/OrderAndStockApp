namespace WaterOrders
{
    partial class FormProductAdd
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
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.lblProductTotalStock = new System.Windows.Forms.Label();
            this.txtUProductTotalStock = new System.Windows.Forms.TextBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(162, 150);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(156, 21);
            this.cmbProductCategory.TabIndex = 36;
            // 
            // lblProductTotalStock
            // 
            this.lblProductTotalStock.AutoSize = true;
            this.lblProductTotalStock.Location = new System.Drawing.Point(76, 114);
            this.lblProductTotalStock.Name = "lblProductTotalStock";
            this.lblProductTotalStock.Size = new System.Drawing.Size(73, 13);
            this.lblProductTotalStock.TabIndex = 35;
            this.lblProductTotalStock.Text = "Toplam Stoğu";
            // 
            // txtUProductTotalStock
            // 
            this.txtUProductTotalStock.Location = new System.Drawing.Point(162, 107);
            this.txtUProductTotalStock.Name = "txtUProductTotalStock";
            this.txtUProductTotalStock.Size = new System.Drawing.Size(156, 20);
            this.txtUProductTotalStock.TabIndex = 34;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(76, 153);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(53, 13);
            this.lblProductCategory.TabIndex = 33;
            this.lblProductCategory.Text = "Kategorisi";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(162, 72);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(156, 20);
            this.txtProductPrice.TabIndex = 32;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.CausesValidation = false;
            this.lblProductPrice.Location = new System.Drawing.Point(76, 75);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(57, 13);
            this.lblProductPrice.TabIndex = 31;
            this.lblProductPrice.Text = "Ürün Fiyatı";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(243, 208);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 31);
            this.btnProductAdd.TabIndex = 30;
            this.btnProductAdd.Text = "Kaydet";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.BtnProductAdd_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(162, 35);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(156, 20);
            this.txtProductName.TabIndex = 29;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(76, 38);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 28;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 271);
            this.Controls.Add(this.cmbProductCategory);
            this.Controls.Add(this.lblProductTotalStock);
            this.Controls.Add(this.txtUProductTotalStock);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Name = "FormProductAdd";
            this.Text = "Yeni Ürün";
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label lblProductTotalStock;
        private System.Windows.Forms.TextBox txtUProductTotalStock;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
    }
}