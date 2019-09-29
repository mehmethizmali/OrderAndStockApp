namespace WaterOrders
{
    partial class FormUserUpdate
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
            this.txtUserFirstNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUserNameUpdate = new System.Windows.Forms.Label();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.lblUserCityUpdate = new System.Windows.Forms.Label();
            this.txtUserCityUpdate = new System.Windows.Forms.TextBox();
            this.lblUserDistrictUpdate = new System.Windows.Forms.Label();
            this.txtUserDistrictUpdate = new System.Windows.Forms.TextBox();
            this.lblUserAddressUpdate = new System.Windows.Forms.Label();
            this.txtUserAddressUpdate = new System.Windows.Forms.TextBox();
            this.lblUserPhoneUpdate = new System.Windows.Forms.Label();
            this.txtUserPhoneUpdate = new System.Windows.Forms.TextBox();
            this.txtUserLastNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUserLastNameUpdate = new System.Windows.Forms.Label();
            this.txtUserNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUserFirstNameUpdate = new System.Windows.Forms.Label();
            this.chckUserContinue = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUserFirstNameUpdate
            // 
            this.txtUserFirstNameUpdate.BackColor = System.Drawing.Color.White;
            this.txtUserFirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserFirstNameUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtUserFirstNameUpdate.Location = new System.Drawing.Point(216, 79);
            this.txtUserFirstNameUpdate.Multiline = true;
            this.txtUserFirstNameUpdate.Name = "txtUserFirstNameUpdate";
            this.txtUserFirstNameUpdate.Size = new System.Drawing.Size(210, 34);
            this.txtUserFirstNameUpdate.TabIndex = 94;
            // 
            // lblUserNameUpdate
            // 
            this.lblUserNameUpdate.AutoSize = true;
            this.lblUserNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserNameUpdate.Location = new System.Drawing.Point(98, 42);
            this.lblUserNameUpdate.Name = "lblUserNameUpdate";
            this.lblUserNameUpdate.Size = new System.Drawing.Size(113, 24);
            this.lblUserNameUpdate.TabIndex = 93;
            this.lblUserNameUpdate.Text = "Kullanıcı Adı";
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.CausesValidation = false;
            this.btnUserUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserUpdate.Location = new System.Drawing.Point(316, 415);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(110, 34);
            this.btnUserUpdate.TabIndex = 88;
            this.btnUserUpdate.TabStop = false;
            this.btnUserUpdate.Text = "Güncelle";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.BtnUserUpdate_Click);
            // 
            // lblUserCityUpdate
            // 
            this.lblUserCityUpdate.AutoSize = true;
            this.lblUserCityUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserCityUpdate.Location = new System.Drawing.Point(98, 325);
            this.lblUserCityUpdate.Name = "lblUserCityUpdate";
            this.lblUserCityUpdate.Size = new System.Drawing.Size(18, 24);
            this.lblUserCityUpdate.TabIndex = 87;
            this.lblUserCityUpdate.Text = "İl";
            // 
            // txtUserCityUpdate
            // 
            this.txtUserCityUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserCityUpdate.Location = new System.Drawing.Point(216, 322);
            this.txtUserCityUpdate.Multiline = true;
            this.txtUserCityUpdate.Name = "txtUserCityUpdate";
            this.txtUserCityUpdate.Size = new System.Drawing.Size(210, 34);
            this.txtUserCityUpdate.TabIndex = 86;
            // 
            // lblUserDistrictUpdate
            // 
            this.lblUserDistrictUpdate.AutoSize = true;
            this.lblUserDistrictUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserDistrictUpdate.Location = new System.Drawing.Point(98, 284);
            this.lblUserDistrictUpdate.Name = "lblUserDistrictUpdate";
            this.lblUserDistrictUpdate.Size = new System.Drawing.Size(39, 24);
            this.lblUserDistrictUpdate.TabIndex = 85;
            this.lblUserDistrictUpdate.Text = "İlçe";
            // 
            // txtUserDistrictUpdate
            // 
            this.txtUserDistrictUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserDistrictUpdate.Location = new System.Drawing.Point(216, 281);
            this.txtUserDistrictUpdate.Multiline = true;
            this.txtUserDistrictUpdate.Name = "txtUserDistrictUpdate";
            this.txtUserDistrictUpdate.Size = new System.Drawing.Size(210, 34);
            this.txtUserDistrictUpdate.TabIndex = 84;
            // 
            // lblUserAddressUpdate
            // 
            this.lblUserAddressUpdate.AutoSize = true;
            this.lblUserAddressUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserAddressUpdate.Location = new System.Drawing.Point(98, 206);
            this.lblUserAddressUpdate.Name = "lblUserAddressUpdate";
            this.lblUserAddressUpdate.Size = new System.Drawing.Size(60, 24);
            this.lblUserAddressUpdate.TabIndex = 83;
            this.lblUserAddressUpdate.Text = "Adres";
            // 
            // txtUserAddressUpdate
            // 
            this.txtUserAddressUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserAddressUpdate.Location = new System.Drawing.Point(216, 203);
            this.txtUserAddressUpdate.Multiline = true;
            this.txtUserAddressUpdate.Name = "txtUserAddressUpdate";
            this.txtUserAddressUpdate.Size = new System.Drawing.Size(210, 72);
            this.txtUserAddressUpdate.TabIndex = 82;
            // 
            // lblUserPhoneUpdate
            // 
            this.lblUserPhoneUpdate.AutoSize = true;
            this.lblUserPhoneUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserPhoneUpdate.Location = new System.Drawing.Point(98, 166);
            this.lblUserPhoneUpdate.Name = "lblUserPhoneUpdate";
            this.lblUserPhoneUpdate.Size = new System.Drawing.Size(74, 24);
            this.lblUserPhoneUpdate.TabIndex = 81;
            this.lblUserPhoneUpdate.Text = "Telefon";
            // 
            // txtUserPhoneUpdate
            // 
            this.txtUserPhoneUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserPhoneUpdate.Location = new System.Drawing.Point(216, 163);
            this.txtUserPhoneUpdate.Multiline = true;
            this.txtUserPhoneUpdate.Name = "txtUserPhoneUpdate";
            this.txtUserPhoneUpdate.Size = new System.Drawing.Size(210, 34);
            this.txtUserPhoneUpdate.TabIndex = 80;
            // 
            // txtUserLastNameUpdate
            // 
            this.txtUserLastNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserLastNameUpdate.Location = new System.Drawing.Point(216, 119);
            this.txtUserLastNameUpdate.Multiline = true;
            this.txtUserLastNameUpdate.Name = "txtUserLastNameUpdate";
            this.txtUserLastNameUpdate.Size = new System.Drawing.Size(210, 34);
            this.txtUserLastNameUpdate.TabIndex = 79;
            // 
            // lblUserLastNameUpdate
            // 
            this.lblUserLastNameUpdate.AutoSize = true;
            this.lblUserLastNameUpdate.CausesValidation = false;
            this.lblUserLastNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserLastNameUpdate.Location = new System.Drawing.Point(98, 122);
            this.lblUserLastNameUpdate.Name = "lblUserLastNameUpdate";
            this.lblUserLastNameUpdate.Size = new System.Drawing.Size(63, 24);
            this.lblUserLastNameUpdate.TabIndex = 78;
            this.lblUserLastNameUpdate.Text = "Soyad";
            // 
            // txtUserNameUpdate
            // 
            this.txtUserNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserNameUpdate.Location = new System.Drawing.Point(216, 39);
            this.txtUserNameUpdate.Multiline = true;
            this.txtUserNameUpdate.Name = "txtUserNameUpdate";
            this.txtUserNameUpdate.Size = new System.Drawing.Size(210, 34);
            this.txtUserNameUpdate.TabIndex = 77;
            // 
            // lblUserFirstNameUpdate
            // 
            this.lblUserFirstNameUpdate.AutoSize = true;
            this.lblUserFirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserFirstNameUpdate.Location = new System.Drawing.Point(98, 82);
            this.lblUserFirstNameUpdate.Name = "lblUserFirstNameUpdate";
            this.lblUserFirstNameUpdate.Size = new System.Drawing.Size(34, 24);
            this.lblUserFirstNameUpdate.TabIndex = 76;
            this.lblUserFirstNameUpdate.Text = "Ad";
            // 
            // chckUserContinue
            // 
            this.chckUserContinue.AutoSize = true;
            this.chckUserContinue.Location = new System.Drawing.Point(216, 380);
            this.chckUserContinue.Name = "chckUserContinue";
            this.chckUserContinue.Size = new System.Drawing.Size(148, 17);
            this.chckUserContinue.TabIndex = 95;
            this.chckUserContinue.Text = "Üyelik Devam Ediyor Mu?";
            this.chckUserContinue.UseVisualStyleBackColor = true;
            // 
            // FormUserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 518);
            this.Controls.Add(this.chckUserContinue);
            this.Controls.Add(this.txtUserFirstNameUpdate);
            this.Controls.Add(this.lblUserNameUpdate);
            this.Controls.Add(this.btnUserUpdate);
            this.Controls.Add(this.lblUserCityUpdate);
            this.Controls.Add(this.txtUserCityUpdate);
            this.Controls.Add(this.lblUserDistrictUpdate);
            this.Controls.Add(this.txtUserDistrictUpdate);
            this.Controls.Add(this.lblUserAddressUpdate);
            this.Controls.Add(this.txtUserAddressUpdate);
            this.Controls.Add(this.lblUserPhoneUpdate);
            this.Controls.Add(this.txtUserPhoneUpdate);
            this.Controls.Add(this.txtUserLastNameUpdate);
            this.Controls.Add(this.lblUserLastNameUpdate);
            this.Controls.Add(this.txtUserNameUpdate);
            this.Controls.Add(this.lblUserFirstNameUpdate);
            this.Name = "FormUserUpdate";
            this.ShowIcon = false;
            this.Text = "Müşteri Güncelle";
            this.Load += new System.EventHandler(this.FormUserUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserFirstNameUpdate;
        private System.Windows.Forms.Label lblUserNameUpdate;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Label lblUserCityUpdate;
        private System.Windows.Forms.TextBox txtUserCityUpdate;
        private System.Windows.Forms.Label lblUserDistrictUpdate;
        private System.Windows.Forms.TextBox txtUserDistrictUpdate;
        private System.Windows.Forms.Label lblUserAddressUpdate;
        private System.Windows.Forms.TextBox txtUserAddressUpdate;
        private System.Windows.Forms.Label lblUserPhoneUpdate;
        private System.Windows.Forms.TextBox txtUserPhoneUpdate;
        private System.Windows.Forms.TextBox txtUserLastNameUpdate;
        private System.Windows.Forms.Label lblUserLastNameUpdate;
        private System.Windows.Forms.TextBox txtUserNameUpdate;
        private System.Windows.Forms.Label lblUserFirstNameUpdate;
        private System.Windows.Forms.CheckBox chckUserContinue;
    }
}