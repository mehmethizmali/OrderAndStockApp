namespace WaterOrders
{
    partial class FormCategoryAdd
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
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Location = new System.Drawing.Point(127, 97);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(156, 73);
            this.txtCategoryDescription.TabIndex = 19;
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Location = new System.Drawing.Point(41, 100);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(50, 13);
            this.lblCategoryDescription.TabIndex = 18;
            this.lblCategoryDescription.Text = "Açıklama";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(208, 191);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(75, 29);
            this.btnCategoryAdd.TabIndex = 17;
            this.btnCategoryAdd.Text = "Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.BtnCategoryAdd_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(127, 39);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(156, 20);
            this.txtCategoryName.TabIndex = 16;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(41, 42);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(64, 13);
            this.lblCategoryName.TabIndex = 15;
            this.lblCategoryName.Text = "Kategori Adı";
            // 
            // FormCategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 270);
            this.Controls.Add(this.txtCategoryDescription);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.btnCategoryAdd);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblCategoryName);
            this.Name = "FormCategoryAdd";
            this.Text = "Yeni Kategori";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
    }
}