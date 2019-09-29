namespace WaterOrders
{
    partial class FormCustOrderDetail
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
            this.lblOrderProductName = new System.Windows.Forms.Label();
            this.txtOrderProductName = new System.Windows.Forms.TextBox();
            this.txtOrderBranchName = new System.Windows.Forms.TextBox();
            this.lblOrderBranchName = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.txtOrderUnitPrice = new System.Windows.Forms.TextBox();
            this.lblOrderUnitPrice = new System.Windows.Forms.Label();
            this.txtOrderTotalUnit = new System.Windows.Forms.TextBox();
            this.lblOrderTotalUnit = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOrderStatu = new System.Windows.Forms.Label();
            this.lbl2OrderStatu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrderProductName
            // 
            this.lblOrderProductName.AutoSize = true;
            this.lblOrderProductName.Location = new System.Drawing.Point(69, 49);
            this.lblOrderProductName.Name = "lblOrderProductName";
            this.lblOrderProductName.Size = new System.Drawing.Size(33, 13);
            this.lblOrderProductName.TabIndex = 0;
            this.lblOrderProductName.Text = "Ürün ";
            // 
            // txtOrderProductName
            // 
            this.txtOrderProductName.Location = new System.Drawing.Point(160, 46);
            this.txtOrderProductName.Name = "txtOrderProductName";
            this.txtOrderProductName.Size = new System.Drawing.Size(137, 20);
            this.txtOrderProductName.TabIndex = 1;
            // 
            // txtOrderBranchName
            // 
            this.txtOrderBranchName.Location = new System.Drawing.Point(160, 83);
            this.txtOrderBranchName.Name = "txtOrderBranchName";
            this.txtOrderBranchName.Size = new System.Drawing.Size(137, 20);
            this.txtOrderBranchName.TabIndex = 3;
            // 
            // lblOrderBranchName
            // 
            this.lblOrderBranchName.AutoSize = true;
            this.lblOrderBranchName.Location = new System.Drawing.Point(69, 86);
            this.lblOrderBranchName.Name = "lblOrderBranchName";
            this.lblOrderBranchName.Size = new System.Drawing.Size(27, 13);
            this.lblOrderBranchName.TabIndex = 2;
            this.lblOrderBranchName.Text = "Bayi";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(160, 123);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(137, 20);
            this.txtOrderDate.TabIndex = 5;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(69, 126);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(31, 13);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "Tarih";
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(160, 161);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(137, 20);
            this.txtOrderQuantity.TabIndex = 7;
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.Location = new System.Drawing.Point(69, 164);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(29, 13);
            this.lblOrderQuantity.TabIndex = 6;
            this.lblOrderQuantity.Text = "Adet";
            // 
            // txtOrderUnitPrice
            // 
            this.txtOrderUnitPrice.Location = new System.Drawing.Point(160, 197);
            this.txtOrderUnitPrice.Name = "txtOrderUnitPrice";
            this.txtOrderUnitPrice.Size = new System.Drawing.Size(137, 20);
            this.txtOrderUnitPrice.TabIndex = 9;
            // 
            // lblOrderUnitPrice
            // 
            this.lblOrderUnitPrice.AutoSize = true;
            this.lblOrderUnitPrice.Location = new System.Drawing.Point(69, 200);
            this.lblOrderUnitPrice.Name = "lblOrderUnitPrice";
            this.lblOrderUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblOrderUnitPrice.TabIndex = 8;
            this.lblOrderUnitPrice.Text = "Fiyat";
            // 
            // txtOrderTotalUnit
            // 
            this.txtOrderTotalUnit.Location = new System.Drawing.Point(160, 234);
            this.txtOrderTotalUnit.Name = "txtOrderTotalUnit";
            this.txtOrderTotalUnit.Size = new System.Drawing.Size(137, 20);
            this.txtOrderTotalUnit.TabIndex = 11;
            // 
            // lblOrderTotalUnit
            // 
            this.lblOrderTotalUnit.AutoSize = true;
            this.lblOrderTotalUnit.Location = new System.Drawing.Point(69, 237);
            this.lblOrderTotalUnit.Name = "lblOrderTotalUnit";
            this.lblOrderTotalUnit.Size = new System.Drawing.Size(70, 13);
            this.lblOrderTotalUnit.TabIndex = 10;
            this.lblOrderTotalUnit.Text = "Toplam Tutar";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(160, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Siparişi İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblOrderStatu
            // 
            this.lblOrderStatu.AutoSize = true;
            this.lblOrderStatu.Location = new System.Drawing.Point(69, 273);
            this.lblOrderStatu.Name = "lblOrderStatu";
            this.lblOrderStatu.Size = new System.Drawing.Size(72, 13);
            this.lblOrderStatu.TabIndex = 12;
            this.lblOrderStatu.Text = "Sipariş Durum";
            // 
            // lbl2OrderStatu
            // 
            this.lbl2OrderStatu.AutoSize = true;
            this.lbl2OrderStatu.Location = new System.Drawing.Point(157, 273);
            this.lbl2OrderStatu.Name = "lbl2OrderStatu";
            this.lbl2OrderStatu.Size = new System.Drawing.Size(66, 13);
            this.lbl2OrderStatu.TabIndex = 15;
            this.lbl2OrderStatu.Text = "Sipariş Alındı";
            // 
            // FormMyOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.lbl2OrderStatu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblOrderStatu);
            this.Controls.Add(this.txtOrderTotalUnit);
            this.Controls.Add(this.lblOrderTotalUnit);
            this.Controls.Add(this.txtOrderUnitPrice);
            this.Controls.Add(this.lblOrderUnitPrice);
            this.Controls.Add(this.txtOrderQuantity);
            this.Controls.Add(this.lblOrderQuantity);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txtOrderBranchName);
            this.Controls.Add(this.lblOrderBranchName);
            this.Controls.Add(this.txtOrderProductName);
            this.Controls.Add(this.lblOrderProductName);
            this.Name = "FormMyOrderDetail";
            this.ShowIcon = false;
            this.Text = "Sipariş Detay";
            this.Load += new System.EventHandler(this.FormMyOrderDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderProductName;
        private System.Windows.Forms.TextBox txtOrderProductName;
        private System.Windows.Forms.TextBox txtOrderBranchName;
        private System.Windows.Forms.Label lblOrderBranchName;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.TextBox txtOrderUnitPrice;
        private System.Windows.Forms.Label lblOrderUnitPrice;
        private System.Windows.Forms.TextBox txtOrderTotalUnit;
        private System.Windows.Forms.Label lblOrderTotalUnit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOrderStatu;
        private System.Windows.Forms.Label lbl2OrderStatu;
    }
}