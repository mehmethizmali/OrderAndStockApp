namespace WaterOrders
{
    partial class FormCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.lsvCustomer = new System.Windows.Forms.ListView();
            this.CustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerDistrict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCustomerIslemler = new System.Windows.Forms.GroupBox();
            this.pctCustomerEdit = new System.Windows.Forms.PictureBox();
            this.pctCustomerRefresh = new System.Windows.Forms.PictureBox();
            this.pctCustomerAdd = new System.Windows.Forms.PictureBox();
            this.pctCustomerDelete = new System.Windows.Forms.PictureBox();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).BeginInit();
            this.grpCustomers.SuspendLayout();
            this.grpCustomerIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.txtCustomerSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(597, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 23);
            this.panel1.TabIndex = 7;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerSearch.Location = new System.Drawing.Point(1, 1);
            this.txtCustomerSearch.Multiline = true;
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(137, 21);
            this.txtCustomerSearch.TabIndex = 1;
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
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.lsvCustomer);
            this.grpCustomers.Controls.Add(this.grpCustomerIslemler);
            this.grpCustomers.Location = new System.Drawing.Point(15, 67);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(766, 377);
            this.grpCustomers.TabIndex = 6;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Müşteriler";
            // 
            // lsvCustomer
            // 
            this.lsvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerId,
            this.CustomerUserName,
            this.CustomerFirstName,
            this.CustomerLastName,
            this.CustomerPhone,
            this.CustomerDistrict,
            this.CustomerCity,
            this.Status});
            this.lsvCustomer.FullRowSelect = true;
            this.lsvCustomer.GridLines = true;
            this.lsvCustomer.Location = new System.Drawing.Point(6, 39);
            this.lsvCustomer.Name = "lsvCustomer";
            this.lsvCustomer.Size = new System.Drawing.Size(754, 241);
            this.lsvCustomer.TabIndex = 6;
            this.lsvCustomer.UseCompatibleStateImageBehavior = false;
            this.lsvCustomer.View = System.Windows.Forms.View.Details;
            // 
            // CustomerId
            // 
            this.CustomerId.Text = "ID";
            this.CustomerId.Width = 28;
            // 
            // CustomerUserName
            // 
            this.CustomerUserName.Text = "Kullanıcı Adı";
            this.CustomerUserName.Width = 133;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.Text = "Soyad";
            this.CustomerLastName.Width = 106;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.Text = "Telefon";
            this.CustomerPhone.Width = 108;
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.Text = "Ad";
            this.CustomerFirstName.Width = 126;
            // 
            // CustomerDistrict
            // 
            this.CustomerDistrict.Text = "İlçe";
            this.CustomerDistrict.Width = 98;
            // 
            // CustomerCity
            // 
            this.CustomerCity.Text = "İl";
            this.CustomerCity.Width = 88;
            // 
            // grpCustomerIslemler
            // 
            this.grpCustomerIslemler.Controls.Add(this.pctCustomerEdit);
            this.grpCustomerIslemler.Controls.Add(this.pctCustomerRefresh);
            this.grpCustomerIslemler.Controls.Add(this.pctCustomerAdd);
            this.grpCustomerIslemler.Controls.Add(this.pctCustomerDelete);
            this.grpCustomerIslemler.Location = new System.Drawing.Point(476, 297);
            this.grpCustomerIslemler.Name = "grpCustomerIslemler";
            this.grpCustomerIslemler.Size = new System.Drawing.Size(284, 74);
            this.grpCustomerIslemler.TabIndex = 5;
            this.grpCustomerIslemler.TabStop = false;
            this.grpCustomerIslemler.Text = "İşlemler";
            // 
            // pctCustomerEdit
            // 
            this.pctCustomerEdit.Image = ((System.Drawing.Image)(resources.GetObject("pctCustomerEdit.Image")));
            this.pctCustomerEdit.Location = new System.Drawing.Point(145, 17);
            this.pctCustomerEdit.Name = "pctCustomerEdit";
            this.pctCustomerEdit.Size = new System.Drawing.Size(63, 50);
            this.pctCustomerEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCustomerEdit.TabIndex = 2;
            this.pctCustomerEdit.TabStop = false;
            this.pctCustomerEdit.Click += new System.EventHandler(this.PctCustomerEdit_Click);
            // 
            // pctCustomerRefresh
            // 
            this.pctCustomerRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pctCustomerRefresh.Image")));
            this.pctCustomerRefresh.Location = new System.Drawing.Point(7, 17);
            this.pctCustomerRefresh.Name = "pctCustomerRefresh";
            this.pctCustomerRefresh.Size = new System.Drawing.Size(63, 50);
            this.pctCustomerRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCustomerRefresh.TabIndex = 4;
            this.pctCustomerRefresh.TabStop = false;
            this.pctCustomerRefresh.Click += new System.EventHandler(this.PctCustomerRefresh_Click);
            // 
            // pctCustomerAdd
            // 
            this.pctCustomerAdd.Image = ((System.Drawing.Image)(resources.GetObject("pctCustomerAdd.Image")));
            this.pctCustomerAdd.Location = new System.Drawing.Point(76, 17);
            this.pctCustomerAdd.Name = "pctCustomerAdd";
            this.pctCustomerAdd.Size = new System.Drawing.Size(63, 50);
            this.pctCustomerAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCustomerAdd.TabIndex = 0;
            this.pctCustomerAdd.TabStop = false;
            this.pctCustomerAdd.Click += new System.EventHandler(this.PctCustomerAdd_Click);
            // 
            // pctCustomerDelete
            // 
            this.pctCustomerDelete.Image = ((System.Drawing.Image)(resources.GetObject("pctCustomerDelete.Image")));
            this.pctCustomerDelete.Location = new System.Drawing.Point(214, 17);
            this.pctCustomerDelete.Name = "pctCustomerDelete";
            this.pctCustomerDelete.Size = new System.Drawing.Size(63, 50);
            this.pctCustomerDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCustomerDelete.TabIndex = 1;
            this.pctCustomerDelete.TabStop = false;
            this.pctCustomerDelete.Click += new System.EventHandler(this.PctCustomerDelete_Click);
            // 
            // Status
            // 
            this.Status.Text = "Durumu";
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpCustomers);
            this.Name = "FormCustomers";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).EndInit();
            this.grpCustomers.ResumeLayout(false);
            this.grpCustomerIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctCustomerSearch;
        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.ListView lsvCustomer;
        private System.Windows.Forms.ColumnHeader CustomerId;
        private System.Windows.Forms.ColumnHeader CustomerUserName;
        private System.Windows.Forms.ColumnHeader CustomerLastName;
        private System.Windows.Forms.GroupBox grpCustomerIslemler;
        private System.Windows.Forms.PictureBox pctCustomerEdit;
        private System.Windows.Forms.PictureBox pctCustomerRefresh;
        private System.Windows.Forms.PictureBox pctCustomerAdd;
        private System.Windows.Forms.PictureBox pctCustomerDelete;
        private System.Windows.Forms.ColumnHeader CustomerPhone;
        private System.Windows.Forms.ColumnHeader CustomerFirstName;
        private System.Windows.Forms.ColumnHeader CustomerDistrict;
        private System.Windows.Forms.ColumnHeader CustomerCity;
        private System.Windows.Forms.ColumnHeader Status;
    }
}