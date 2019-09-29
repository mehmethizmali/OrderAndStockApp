namespace WaterOrders
{
    partial class FormBranches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBranches));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBranchSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.grpBranch = new System.Windows.Forms.GroupBox();
            this.grpBranchIslemler = new System.Windows.Forms.GroupBox();
            this.pctBranchEdit = new System.Windows.Forms.PictureBox();
            this.pctBranchRefresh = new System.Windows.Forms.PictureBox();
            this.pctBranchAdd = new System.Windows.Forms.PictureBox();
            this.pctBranchDelete = new System.Windows.Forms.PictureBox();
            this.lsvBranches = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BranchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.District = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).BeginInit();
            this.grpBranch.SuspendLayout();
            this.grpBranchIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.txtBranchSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(614, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 23);
            this.panel1.TabIndex = 9;
            // 
            // txtBranchSearch
            // 
            this.txtBranchSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBranchSearch.Location = new System.Drawing.Point(1, 1);
            this.txtBranchSearch.Multiline = true;
            this.txtBranchSearch.Name = "txtBranchSearch";
            this.txtBranchSearch.Size = new System.Drawing.Size(137, 21);
            this.txtBranchSearch.TabIndex = 1;
            this.txtBranchSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBranchSearch_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pctCustomerSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(138, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 23);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pctCustomerSearch
            // 
            this.pctCustomerSearch.Location = new System.Drawing.Point(1, 0);
            this.pctCustomerSearch.Name = "pctCustomerSearch";
            this.pctCustomerSearch.Size = new System.Drawing.Size(34, 23);
            this.pctCustomerSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCustomerSearch.TabIndex = 0;
            this.pctCustomerSearch.TabStop = false;
            // 
            // grpBranch
            // 
            this.grpBranch.Controls.Add(this.grpBranchIslemler);
            this.grpBranch.Controls.Add(this.lsvBranches);
            this.grpBranch.Location = new System.Drawing.Point(17, 53);
            this.grpBranch.Name = "grpBranch";
            this.grpBranch.Size = new System.Drawing.Size(789, 377);
            this.grpBranch.TabIndex = 8;
            this.grpBranch.TabStop = false;
            this.grpBranch.Text = "Bayiler";
            // 
            // grpBranchIslemler
            // 
            this.grpBranchIslemler.AccessibleName = "BRA";
            this.grpBranchIslemler.Controls.Add(this.pctBranchEdit);
            this.grpBranchIslemler.Controls.Add(this.pctBranchRefresh);
            this.grpBranchIslemler.Controls.Add(this.pctBranchAdd);
            this.grpBranchIslemler.Controls.Add(this.pctBranchDelete);
            this.grpBranchIslemler.Location = new System.Drawing.Point(486, 297);
            this.grpBranchIslemler.Name = "grpBranchIslemler";
            this.grpBranchIslemler.Size = new System.Drawing.Size(284, 74);
            this.grpBranchIslemler.TabIndex = 13;
            this.grpBranchIslemler.TabStop = false;
            this.grpBranchIslemler.Text = "İşlemler";
            // 
            // pctBranchEdit
            // 
            this.pctBranchEdit.Image = ((System.Drawing.Image)(resources.GetObject("pctBranchEdit.Image")));
            this.pctBranchEdit.Location = new System.Drawing.Point(145, 17);
            this.pctBranchEdit.Name = "pctBranchEdit";
            this.pctBranchEdit.Size = new System.Drawing.Size(63, 50);
            this.pctBranchEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBranchEdit.TabIndex = 2;
            this.pctBranchEdit.TabStop = false;
            this.pctBranchEdit.Click += new System.EventHandler(this.PctBranchEdit_Click);
            // 
            // pctBranchRefresh
            // 
            this.pctBranchRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pctBranchRefresh.Image")));
            this.pctBranchRefresh.Location = new System.Drawing.Point(7, 17);
            this.pctBranchRefresh.Name = "pctBranchRefresh";
            this.pctBranchRefresh.Size = new System.Drawing.Size(63, 50);
            this.pctBranchRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBranchRefresh.TabIndex = 4;
            this.pctBranchRefresh.TabStop = false;
            this.pctBranchRefresh.Click += new System.EventHandler(this.PctBranchRefresh_Click);
            // 
            // pctBranchAdd
            // 
            this.pctBranchAdd.Image = ((System.Drawing.Image)(resources.GetObject("pctBranchAdd.Image")));
            this.pctBranchAdd.Location = new System.Drawing.Point(76, 17);
            this.pctBranchAdd.Name = "pctBranchAdd";
            this.pctBranchAdd.Size = new System.Drawing.Size(63, 50);
            this.pctBranchAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBranchAdd.TabIndex = 0;
            this.pctBranchAdd.TabStop = false;
            this.pctBranchAdd.Click += new System.EventHandler(this.PctBranchAdd_Click);
            // 
            // pctBranchDelete
            // 
            this.pctBranchDelete.Image = ((System.Drawing.Image)(resources.GetObject("pctBranchDelete.Image")));
            this.pctBranchDelete.Location = new System.Drawing.Point(214, 17);
            this.pctBranchDelete.Name = "pctBranchDelete";
            this.pctBranchDelete.Size = new System.Drawing.Size(63, 50);
            this.pctBranchDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBranchDelete.TabIndex = 1;
            this.pctBranchDelete.TabStop = false;
            this.pctBranchDelete.Click += new System.EventHandler(this.PctBranchDelete_Click);
            // 
            // lsvBranches
            // 
            this.lsvBranches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.BranchName,
            this.FirstName,
            this.LastName,
            this.Phone,
            this.District,
            this.City,
            this.Status});
            this.lsvBranches.FullRowSelect = true;
            this.lsvBranches.GridLines = true;
            this.lsvBranches.Location = new System.Drawing.Point(13, 41);
            this.lsvBranches.Name = "lsvBranches";
            this.lsvBranches.Size = new System.Drawing.Size(763, 251);
            this.lsvBranches.TabIndex = 12;
            this.lsvBranches.UseCompatibleStateImageBehavior = false;
            this.lsvBranches.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "ID";
            this.ProductID.Width = 33;
            // 
            // BranchName
            // 
            this.BranchName.Text = "Bayi Adı";
            this.BranchName.Width = 115;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Ad";
            this.FirstName.Width = 108;
            // 
            // LastName
            // 
            this.LastName.Text = "Soyad";
            this.LastName.Width = 100;
            // 
            // Phone
            // 
            this.Phone.Text = "Telefon";
            this.Phone.Width = 114;
            // 
            // District
            // 
            this.District.Text = "İlçe";
            this.District.Width = 98;
            // 
            // City
            // 
            this.City.Text = "İl";
            this.City.Width = 112;
            // 
            // Status
            // 
            this.Status.Text = "Durumu";
            this.Status.Width = 78;
            // 
            // FormBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBranch);
            this.Name = "FormBranches";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).EndInit();
            this.grpBranch.ResumeLayout(false);
            this.grpBranchIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBranchSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctCustomerSearch;
        private System.Windows.Forms.GroupBox grpBranch;
        private System.Windows.Forms.ListView lsvBranches;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader BranchName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader District;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.GroupBox grpBranchIslemler;
        private System.Windows.Forms.PictureBox pctBranchEdit;
        private System.Windows.Forms.PictureBox pctBranchRefresh;
        private System.Windows.Forms.PictureBox pctBranchAdd;
        private System.Windows.Forms.PictureBox pctBranchDelete;
        private System.Windows.Forms.ColumnHeader Status;
    }
}