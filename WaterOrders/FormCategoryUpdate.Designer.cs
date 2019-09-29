namespace WaterOrders
{
    partial class FormCategoryUpdate
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
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(134, 80);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(156, 73);
            this.txtCategoryDescription.TabIndex = 24;
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Location = new System.Drawing.Point(48, 83);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(50, 13);
            this.lblCategoryDescription.TabIndex = 23;
            this.lblCategoryDescription.Text = "Açıklama";
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(215, 174);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnCategoryUpdate.TabIndex = 22;
            this.btnCategoryUpdate.Text = "Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.BtnCategoryUpdate_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(134, 22);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(156, 20);
            this.txtCategoryName.TabIndex = 21;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(48, 25);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(64, 13);
            this.lblCategoryName.TabIndex = 20;
            this.lblCategoryName.Text = "Kategori Adı";
            // 
            // FormCategoryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.btnCategoryUpdate);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblCategoryName);
            this.Name = "FormCategoryUpdate";
            this.Text = "Kategori Güncelle";
            this.Load += new System.EventHandler(this.FormCategoryUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
    }
}