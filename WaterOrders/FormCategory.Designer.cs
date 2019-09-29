namespace WaterOrders
{
    partial class FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCategorySearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctCustomerSearch = new System.Windows.Forms.PictureBox();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.lsvCategory = new System.Windows.Forms.ListView();
            this.CategoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpCategoryIslemler = new System.Windows.Forms.GroupBox();
            this.pctCategoryEdit = new System.Windows.Forms.PictureBox();
            this.pctCategoryRefresh = new System.Windows.Forms.PictureBox();
            this.pctCategoryAdd = new System.Windows.Forms.PictureBox();
            this.pctCategoryDelete = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).BeginInit();
            this.grpCategory.SuspendLayout();
            this.grpCategoryIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoryEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoryRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoryAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoryDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.txtCategorySearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(599, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 23);
            this.panel1.TabIndex = 5;
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategorySearch.Location = new System.Drawing.Point(1, 1);
            this.txtCategorySearch.Multiline = true;
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.Size = new System.Drawing.Size(137, 21);
            this.txtCategorySearch.TabIndex = 1;
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
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.lsvCategory);
            this.grpCategory.Controls.Add(this.grpCategoryIslemler);
            this.grpCategory.Location = new System.Drawing.Point(17, 53);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(766, 377);
            this.grpCategory.TabIndex = 4;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Kategoriler";
            // 
            // lsvCategory
            // 
            this.lsvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CategoryId,
            this.CategoryName,
            this.CategoryDescription});
            this.lsvCategory.FullRowSelect = true;
            this.lsvCategory.GridLines = true;
            this.lsvCategory.Location = new System.Drawing.Point(6, 39);
            this.lsvCategory.Name = "lsvCategory";
            this.lsvCategory.Size = new System.Drawing.Size(754, 241);
            this.lsvCategory.TabIndex = 6;
            this.lsvCategory.UseCompatibleStateImageBehavior = false;
            this.lsvCategory.View = System.Windows.Forms.View.Details;
            // 
            // CategoryId
            // 
            this.CategoryId.Text = "ID";
            this.CategoryId.Width = 61;
            // 
            // CategoryName
            // 
            this.CategoryName.Text = "Kategori Adı";
            this.CategoryName.Width = 178;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.Text = "Açıklama";
            this.CategoryDescription.Width = 510;
            // 
            // grpCategoryIslemler
            // 
            this.grpCategoryIslemler.Controls.Add(this.pctCategoryEdit);
            this.grpCategoryIslemler.Controls.Add(this.pctCategoryRefresh);
            this.grpCategoryIslemler.Controls.Add(this.pctCategoryAdd);
            this.grpCategoryIslemler.Controls.Add(this.pctCategoryDelete);
            this.grpCategoryIslemler.Location = new System.Drawing.Point(476, 297);
            this.grpCategoryIslemler.Name = "grpCategoryIslemler";
            this.grpCategoryIslemler.Size = new System.Drawing.Size(284, 74);
            this.grpCategoryIslemler.TabIndex = 5;
            this.grpCategoryIslemler.TabStop = false;
            this.grpCategoryIslemler.Text = "İşlemler";
            // 
            // pctCategoryEdit
            // 
            this.pctCategoryEdit.Image = ((System.Drawing.Image)(resources.GetObject("pctCategoryEdit.Image")));
            this.pctCategoryEdit.Location = new System.Drawing.Point(145, 17);
            this.pctCategoryEdit.Name = "pctCategoryEdit";
            this.pctCategoryEdit.Size = new System.Drawing.Size(63, 50);
            this.pctCategoryEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCategoryEdit.TabIndex = 2;
            this.pctCategoryEdit.TabStop = false;
            this.pctCategoryEdit.Click += new System.EventHandler(this.PictCustomerEdit_Click);
            // 
            // pctCategoryRefresh
            // 
            this.pctCategoryRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pctCategoryRefresh.Image")));
            this.pctCategoryRefresh.Location = new System.Drawing.Point(7, 17);
            this.pctCategoryRefresh.Name = "pctCategoryRefresh";
            this.pctCategoryRefresh.Size = new System.Drawing.Size(63, 50);
            this.pctCategoryRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCategoryRefresh.TabIndex = 4;
            this.pctCategoryRefresh.TabStop = false;
            this.pctCategoryRefresh.Click += new System.EventHandler(this.PctCategoryRefresh_Click);
            // 
            // pctCategoryAdd
            // 
            this.pctCategoryAdd.Image = ((System.Drawing.Image)(resources.GetObject("pctCategoryAdd.Image")));
            this.pctCategoryAdd.Location = new System.Drawing.Point(76, 17);
            this.pctCategoryAdd.Name = "pctCategoryAdd";
            this.pctCategoryAdd.Size = new System.Drawing.Size(63, 50);
            this.pctCategoryAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCategoryAdd.TabIndex = 0;
            this.pctCategoryAdd.TabStop = false;
            this.pctCategoryAdd.Click += new System.EventHandler(this.PctCategoryAdd_Click);
            // 
            // pctCategoryDelete
            // 
            this.pctCategoryDelete.Image = ((System.Drawing.Image)(resources.GetObject("pctCategoryDelete.Image")));
            this.pctCategoryDelete.Location = new System.Drawing.Point(214, 17);
            this.pctCategoryDelete.Name = "pctCategoryDelete";
            this.pctCategoryDelete.Size = new System.Drawing.Size(63, 50);
            this.pctCategoryDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCategoryDelete.TabIndex = 1;
            this.pctCategoryDelete.TabStop = false;
            this.pctCategoryDelete.Click += new System.EventHandler(this.PctCategoryDelete_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpCategory);
            this.Name = "FormCategory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCustomerSearch)).EndInit();
            this.grpCategory.ResumeLayout(false);
            this.grpCategoryIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoryEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoryRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoryAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCategoryDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCategorySearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctCustomerSearch;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.ListView lsvCategory;
        private System.Windows.Forms.GroupBox grpCategoryIslemler;
        private System.Windows.Forms.PictureBox pctCategoryEdit;
        private System.Windows.Forms.PictureBox pctCategoryRefresh;
        private System.Windows.Forms.PictureBox pctCategoryAdd;
        private System.Windows.Forms.PictureBox pctCategoryDelete;
        private System.Windows.Forms.ColumnHeader CategoryId;
        private System.Windows.Forms.ColumnHeader CategoryName;
        private System.Windows.Forms.ColumnHeader CategoryDescription;
    }
}