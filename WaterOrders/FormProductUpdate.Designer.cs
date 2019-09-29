namespace WaterOrders
{
    partial class FormProductUpdate
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
            this.txtProductTotalStock = new System.Windows.Forms.TextBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(140, 157);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(156, 21);
            this.cmbProductCategory.TabIndex = 50;
            // 
            // lblProductTotalStock
            // 
            this.lblProductTotalStock.AutoSize = true;
            this.lblProductTotalStock.Location = new System.Drawing.Point(54, 121);
            this.lblProductTotalStock.Name = "lblProductTotalStock";
            this.lblProductTotalStock.Size = new System.Drawing.Size(73, 13);
            this.lblProductTotalStock.TabIndex = 49;
            this.lblProductTotalStock.Text = "Toplam Stoğu";
            // 
            // txtProductTotalStock
            // 
            this.txtProductTotalStock.Location = new System.Drawing.Point(140, 114);
            this.txtProductTotalStock.Name = "txtProductTotalStock";
            this.txtProductTotalStock.Size = new System.Drawing.Size(156, 20);
            this.txtProductTotalStock.TabIndex = 48;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(54, 160);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(53, 13);
            this.lblProductCategory.TabIndex = 47;
            this.lblProductCategory.Text = "Kategorisi";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(140, 79);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(156, 20);
            this.txtProductPrice.TabIndex = 46;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.CausesValidation = false;
            this.lblProductPrice.Location = new System.Drawing.Point(54, 82);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(57, 13);
            this.lblProductPrice.TabIndex = 45;
            this.lblProductPrice.Text = "Ürün Fiyatı";
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(221, 206);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnProductUpdate.TabIndex = 44;
            this.btnProductUpdate.Text = "Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.BtnProductUpdate_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(140, 42);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(156, 20);
            this.txtProductName.TabIndex = 43;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(54, 45);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 42;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // FormProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 281);
            this.Controls.Add(this.cmbProductCategory);
            this.Controls.Add(this.lblProductTotalStock);
            this.Controls.Add(this.txtProductTotalStock);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Name = "FormProductUpdate";
            this.ShowIcon = false;
            this.Text = "Ürün Güncelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProductUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label lblProductTotalStock;
        private System.Windows.Forms.TextBox txtProductTotalStock;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
    }
}