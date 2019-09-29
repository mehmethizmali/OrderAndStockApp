namespace WaterOrders
{
    partial class FormStockUpdate
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
            this.cmbStockProductNameUpd = new System.Windows.Forms.ComboBox();
            this.lblStockProductUpd = new System.Windows.Forms.Label();
            this.cmbStockBranchNameUpd = new System.Windows.Forms.ComboBox();
            this.lblStockBranchUpd = new System.Windows.Forms.Label();
            this.chckStockOrderStart = new System.Windows.Forms.CheckBox();
            this.btnStockProductUpd = new System.Windows.Forms.Button();
            this.txtStockProductCountUpd = new System.Windows.Forms.TextBox();
            this.lblStockProductCountUpd = new System.Windows.Forms.Label();
            this.txtStockProRemanningUpd = new System.Windows.Forms.TextBox();
            this.lblStockProRemanningUpd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbStockProductNameUpd
            // 
            this.cmbStockProductNameUpd.FormattingEnabled = true;
            this.cmbStockProductNameUpd.Location = new System.Drawing.Point(112, 58);
            this.cmbStockProductNameUpd.Name = "cmbStockProductNameUpd";
            this.cmbStockProductNameUpd.Size = new System.Drawing.Size(156, 21);
            this.cmbStockProductNameUpd.TabIndex = 63;
            // 
            // lblStockProductUpd
            // 
            this.lblStockProductUpd.AutoSize = true;
            this.lblStockProductUpd.Location = new System.Drawing.Point(26, 61);
            this.lblStockProductUpd.Name = "lblStockProductUpd";
            this.lblStockProductUpd.Size = new System.Drawing.Size(48, 13);
            this.lblStockProductUpd.TabIndex = 62;
            this.lblStockProductUpd.Text = "Ürün Adı";
            // 
            // cmbStockBranchNameUpd
            // 
            this.cmbStockBranchNameUpd.FormattingEnabled = true;
            this.cmbStockBranchNameUpd.Location = new System.Drawing.Point(112, 31);
            this.cmbStockBranchNameUpd.Name = "cmbStockBranchNameUpd";
            this.cmbStockBranchNameUpd.Size = new System.Drawing.Size(156, 21);
            this.cmbStockBranchNameUpd.TabIndex = 61;
            // 
            // lblStockBranchUpd
            // 
            this.lblStockBranchUpd.AutoSize = true;
            this.lblStockBranchUpd.Location = new System.Drawing.Point(26, 34);
            this.lblStockBranchUpd.Name = "lblStockBranchUpd";
            this.lblStockBranchUpd.Size = new System.Drawing.Size(27, 13);
            this.lblStockBranchUpd.TabIndex = 60;
            this.lblStockBranchUpd.Text = "Bayi";
            // 
            // chckStockOrderStart
            // 
            this.chckStockOrderStart.AutoSize = true;
            this.chckStockOrderStart.Location = new System.Drawing.Point(112, 144);
            this.chckStockOrderStart.Name = "chckStockOrderStart";
            this.chckStockOrderStart.Size = new System.Drawing.Size(141, 17);
            this.chckStockOrderStart.TabIndex = 59;
            this.chckStockOrderStart.Text = "Satışı İşlemi Başlasın mı?";
            this.chckStockOrderStart.UseVisualStyleBackColor = true;
            // 
            // btnStockProductUpd
            // 
            this.btnStockProductUpd.Location = new System.Drawing.Point(193, 178);
            this.btnStockProductUpd.Name = "btnStockProductUpd";
            this.btnStockProductUpd.Size = new System.Drawing.Size(75, 31);
            this.btnStockProductUpd.TabIndex = 58;
            this.btnStockProductUpd.Text = "Güncelle";
            this.btnStockProductUpd.UseVisualStyleBackColor = true;
            this.btnStockProductUpd.Click += new System.EventHandler(this.BtnStockProductUpd_Click);
            // 
            // txtStockProductCountUpd
            // 
            this.txtStockProductCountUpd.Location = new System.Drawing.Point(112, 85);
            this.txtStockProductCountUpd.Name = "txtStockProductCountUpd";
            this.txtStockProductCountUpd.ReadOnly = true;
            this.txtStockProductCountUpd.Size = new System.Drawing.Size(156, 20);
            this.txtStockProductCountUpd.TabIndex = 57;
            // 
            // lblStockProductCountUpd
            // 
            this.lblStockProductCountUpd.AutoSize = true;
            this.lblStockProductCountUpd.Location = new System.Drawing.Point(26, 88);
            this.lblStockProductCountUpd.Name = "lblStockProductCountUpd";
            this.lblStockProductCountUpd.Size = new System.Drawing.Size(67, 13);
            this.lblStockProductCountUpd.TabIndex = 56;
            this.lblStockProductCountUpd.Text = "Toplam Adet";
            // 
            // txtStockProRemanningUpd
            // 
            this.txtStockProRemanningUpd.Location = new System.Drawing.Point(112, 118);
            this.txtStockProRemanningUpd.Name = "txtStockProRemanningUpd";
            this.txtStockProRemanningUpd.ReadOnly = true;
            this.txtStockProRemanningUpd.Size = new System.Drawing.Size(156, 20);
            this.txtStockProRemanningUpd.TabIndex = 65;
            // 
            // lblStockProRemanningUpd
            // 
            this.lblStockProRemanningUpd.AutoSize = true;
            this.lblStockProRemanningUpd.Location = new System.Drawing.Point(26, 121);
            this.lblStockProRemanningUpd.Name = "lblStockProRemanningUpd";
            this.lblStockProRemanningUpd.Size = new System.Drawing.Size(59, 13);
            this.lblStockProRemanningUpd.TabIndex = 64;
            this.lblStockProRemanningUpd.Text = "Kalan Adet";
            // 
            // FormStockUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 272);
            this.Controls.Add(this.txtStockProRemanningUpd);
            this.Controls.Add(this.lblStockProRemanningUpd);
            this.Controls.Add(this.cmbStockProductNameUpd);
            this.Controls.Add(this.lblStockProductUpd);
            this.Controls.Add(this.cmbStockBranchNameUpd);
            this.Controls.Add(this.lblStockBranchUpd);
            this.Controls.Add(this.chckStockOrderStart);
            this.Controls.Add(this.btnStockProductUpd);
            this.Controls.Add(this.txtStockProductCountUpd);
            this.Controls.Add(this.lblStockProductCountUpd);
            this.Name = "FormStockUpdate";
            this.Text = "FormStockUpdate";
            this.Load += new System.EventHandler(this.FormStockUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStockProductNameUpd;
        private System.Windows.Forms.Label lblStockProductUpd;
        private System.Windows.Forms.ComboBox cmbStockBranchNameUpd;
        private System.Windows.Forms.Label lblStockBranchUpd;
        private System.Windows.Forms.CheckBox chckStockOrderStart;
        private System.Windows.Forms.Button btnStockProductUpd;
        private System.Windows.Forms.TextBox txtStockProductCountUpd;
        private System.Windows.Forms.Label lblStockProductCountUpd;
        private System.Windows.Forms.TextBox txtStockProRemanningUpd;
        private System.Windows.Forms.Label lblStockProRemanningUpd;
    }
}