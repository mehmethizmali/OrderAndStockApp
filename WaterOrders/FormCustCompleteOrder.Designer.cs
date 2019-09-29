namespace WaterOrders
{
    partial class FormCustCompleteOrder
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
            this.grpCustOrderComplete = new System.Windows.Forms.GroupBox();
            this.lblRemainingStock = new System.Windows.Forms.Label();
            this.lblBranchRemainingStock = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblCustTotalPrice = new System.Windows.Forms.Label();
            this.nudCustProductCount = new System.Windows.Forms.NumericUpDown();
            this.lblCustProductCount = new System.Windows.Forms.Label();
            this.cmbCustBranchName = new System.Windows.Forms.ComboBox();
            this.lblCustBranchName = new System.Windows.Forms.Label();
            this.txtCustProductName = new System.Windows.Forms.TextBox();
            this.lblCustProductName = new System.Windows.Forms.Label();
            this.btnNewOrders = new System.Windows.Forms.Button();
            this.grpCustOrderComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustOrderComplete
            // 
            this.grpCustOrderComplete.BackColor = System.Drawing.Color.Transparent;
            this.grpCustOrderComplete.Controls.Add(this.lblRemainingStock);
            this.grpCustOrderComplete.Controls.Add(this.lblBranchRemainingStock);
            this.grpCustOrderComplete.Controls.Add(this.lblTotalPrice);
            this.grpCustOrderComplete.Controls.Add(this.lblCustTotalPrice);
            this.grpCustOrderComplete.Controls.Add(this.nudCustProductCount);
            this.grpCustOrderComplete.Controls.Add(this.lblCustProductCount);
            this.grpCustOrderComplete.Controls.Add(this.cmbCustBranchName);
            this.grpCustOrderComplete.Controls.Add(this.lblCustBranchName);
            this.grpCustOrderComplete.Controls.Add(this.txtCustProductName);
            this.grpCustOrderComplete.Controls.Add(this.lblCustProductName);
            this.grpCustOrderComplete.Controls.Add(this.btnNewOrders);
            this.grpCustOrderComplete.Location = new System.Drawing.Point(15, 32);
            this.grpCustOrderComplete.Name = "grpCustOrderComplete";
            this.grpCustOrderComplete.Size = new System.Drawing.Size(522, 387);
            this.grpCustOrderComplete.TabIndex = 10;
            this.grpCustOrderComplete.TabStop = false;
            this.grpCustOrderComplete.Text = "Sipariş Tamamlama";
            // 
            // lblRemainingStock
            // 
            this.lblRemainingStock.AutoSize = true;
            this.lblRemainingStock.Location = new System.Drawing.Point(136, 232);
            this.lblRemainingStock.Name = "lblRemainingStock";
            this.lblRemainingStock.Size = new System.Drawing.Size(16, 13);
            this.lblRemainingStock.TabIndex = 56;
            this.lblRemainingStock.Text = "0 ";
            // 
            // lblBranchRemainingStock
            // 
            this.lblBranchRemainingStock.AutoSize = true;
            this.lblBranchRemainingStock.Location = new System.Drawing.Point(57, 232);
            this.lblBranchRemainingStock.Name = "lblBranchRemainingStock";
            this.lblBranchRemainingStock.Size = new System.Drawing.Size(54, 13);
            this.lblBranchRemainingStock.TabIndex = 55;
            this.lblBranchRemainingStock.Text = "Stok Adet";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(136, 196);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(25, 13);
            this.lblTotalPrice.TabIndex = 54;
            this.lblTotalPrice.Text = "0 ₺ ";
            // 
            // lblCustTotalPrice
            // 
            this.lblCustTotalPrice.AutoSize = true;
            this.lblCustTotalPrice.Location = new System.Drawing.Point(57, 196);
            this.lblCustTotalPrice.Name = "lblCustTotalPrice";
            this.lblCustTotalPrice.Size = new System.Drawing.Size(42, 13);
            this.lblCustTotalPrice.TabIndex = 53;
            this.lblCustTotalPrice.Text = "Toplam";
            // 
            // nudCustProductCount
            // 
            this.nudCustProductCount.Location = new System.Drawing.Point(139, 149);
            this.nudCustProductCount.Name = "nudCustProductCount";
            this.nudCustProductCount.Size = new System.Drawing.Size(185, 20);
            this.nudCustProductCount.TabIndex = 52;
            this.nudCustProductCount.ValueChanged += new System.EventHandler(this.NudCustProductCount_ValueChanged);
            // 
            // lblCustProductCount
            // 
            this.lblCustProductCount.AutoSize = true;
            this.lblCustProductCount.Location = new System.Drawing.Point(57, 149);
            this.lblCustProductCount.Name = "lblCustProductCount";
            this.lblCustProductCount.Size = new System.Drawing.Size(29, 13);
            this.lblCustProductCount.TabIndex = 51;
            this.lblCustProductCount.Text = "Adet";
            // 
            // cmbCustBranchName
            // 
            this.cmbCustBranchName.FormattingEnabled = true;
            this.cmbCustBranchName.Location = new System.Drawing.Point(139, 105);
            this.cmbCustBranchName.Name = "cmbCustBranchName";
            this.cmbCustBranchName.Size = new System.Drawing.Size(185, 21);
            this.cmbCustBranchName.TabIndex = 50;
            this.cmbCustBranchName.SelectedIndexChanged += new System.EventHandler(this.CmbCustBranchName_SelectedIndexChanged);
            this.cmbCustBranchName.TextUpdate += new System.EventHandler(this.CmbCustBranchName_TextUpdate);
            // 
            // lblCustBranchName
            // 
            this.lblCustBranchName.AutoSize = true;
            this.lblCustBranchName.Location = new System.Drawing.Point(59, 108);
            this.lblCustBranchName.Name = "lblCustBranchName";
            this.lblCustBranchName.Size = new System.Drawing.Size(27, 13);
            this.lblCustBranchName.TabIndex = 49;
            this.lblCustBranchName.Text = "Bayi";
            // 
            // txtCustProductName
            // 
            this.txtCustProductName.Enabled = false;
            this.txtCustProductName.Location = new System.Drawing.Point(139, 64);
            this.txtCustProductName.Name = "txtCustProductName";
            this.txtCustProductName.Size = new System.Drawing.Size(185, 20);
            this.txtCustProductName.TabIndex = 48;
            // 
            // lblCustProductName
            // 
            this.lblCustProductName.AutoSize = true;
            this.lblCustProductName.Location = new System.Drawing.Point(59, 64);
            this.lblCustProductName.Name = "lblCustProductName";
            this.lblCustProductName.Size = new System.Drawing.Size(48, 13);
            this.lblCustProductName.TabIndex = 47;
            this.lblCustProductName.Text = "Ürün Adı";
            // 
            // btnNewOrders
            // 
            this.btnNewOrders.BackColor = System.Drawing.Color.Red;
            this.btnNewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewOrders.ForeColor = System.Drawing.Color.White;
            this.btnNewOrders.Location = new System.Drawing.Point(139, 271);
            this.btnNewOrders.Name = "btnNewOrders";
            this.btnNewOrders.Size = new System.Drawing.Size(185, 41);
            this.btnNewOrders.TabIndex = 46;
            this.btnNewOrders.Text = "Sipariş Ver";
            this.btnNewOrders.UseVisualStyleBackColor = false;
            this.btnNewOrders.Click += new System.EventHandler(this.BtnNewOrders_Click);
            // 
            // FormCustCompleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.grpCustOrderComplete);
            this.Name = "FormCustCompleteOrder";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCustCompleteOrder_Load);
            this.grpCustOrderComplete.ResumeLayout(false);
            this.grpCustOrderComplete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustProductCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustOrderComplete;
        private System.Windows.Forms.TextBox txtCustProductName;
        private System.Windows.Forms.Label lblCustProductName;
        private System.Windows.Forms.Button btnNewOrders;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblCustTotalPrice;
        private System.Windows.Forms.NumericUpDown nudCustProductCount;
        private System.Windows.Forms.Label lblCustProductCount;
        private System.Windows.Forms.ComboBox cmbCustBranchName;
        private System.Windows.Forms.Label lblCustBranchName;
        private System.Windows.Forms.Label lblRemainingStock;
        private System.Windows.Forms.Label lblBranchRemainingStock;
    }
}