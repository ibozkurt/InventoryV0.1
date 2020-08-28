namespace WebFormsUI
{
    partial class frmTenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTenant));
            this.btnRefreshTenant = new System.Windows.Forms.Button();
            this.gbxFilterWorker = new System.Windows.Forms.GroupBox();
            this.tbxSearchFirstName = new System.Windows.Forms.TextBox();
            this.lblSearchFirstName = new System.Windows.Forms.Label();
            this.cbxLocationTenant = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbxSearchCompany = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxEditTenant = new System.Windows.Forms.GroupBox();
            this.tbxPhoneNumberEditTenant = new System.Windows.Forms.MaskedTextBox();
            this.tbxGsmNumberEditTenant = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.cbxCompanyEditTenant = new System.Windows.Forms.ComboBox();
            this.lblCompanyEditTenant = new System.Windows.Forms.Label();
            this.tbxInternalPhoneNumberEditTenant = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblInternalPhoneNumberEdit = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblGsmNumberEditTenant = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPhoneNumberEditTenant = new System.Windows.Forms.Label();
            this.tbxTitleEditTenant = new System.Windows.Forms.TextBox();
            this.lblTitleEditTenant = new System.Windows.Forms.Label();
            this.tbxLastNameEditTenant = new System.Windows.Forms.TextBox();
            this.lblLastNameEditTenant = new System.Windows.Forms.Label();
            this.tbxFirstNameEditTenant = new System.Windows.Forms.TextBox();
            this.lblFirstNameTenant = new System.Windows.Forms.Label();
            this.cbxLocationEditTenant = new System.Windows.Forms.ComboBox();
            this.lblLocationEditTenant = new System.Windows.Forms.Label();
            this.dgwTenant = new System.Windows.Forms.DataGridView();
            this.gbxFilterWorker.SuspendLayout();
            this.gbxEditTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTenant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshTenant
            // 
            this.btnRefreshTenant.Location = new System.Drawing.Point(464, 38);
            this.btnRefreshTenant.Name = "btnRefreshTenant";
            this.btnRefreshTenant.Size = new System.Drawing.Size(98, 73);
            this.btnRefreshTenant.TabIndex = 17;
            this.btnRefreshTenant.Text = "EKRANI YENILE";
            this.btnRefreshTenant.UseVisualStyleBackColor = true;
            this.btnRefreshTenant.Click += new System.EventHandler(this.btnRefreshTenant_Click);
            // 
            // gbxFilterWorker
            // 
            this.gbxFilterWorker.Controls.Add(this.tbxSearchFirstName);
            this.gbxFilterWorker.Controls.Add(this.lblSearchFirstName);
            this.gbxFilterWorker.Controls.Add(this.cbxLocationTenant);
            this.gbxFilterWorker.Controls.Add(this.lblLocation);
            this.gbxFilterWorker.Controls.Add(this.tbxSearchCompany);
            this.gbxFilterWorker.Controls.Add(this.lblSearch);
            this.gbxFilterWorker.Location = new System.Drawing.Point(12, 16);
            this.gbxFilterWorker.Name = "gbxFilterWorker";
            this.gbxFilterWorker.Size = new System.Drawing.Size(429, 105);
            this.gbxFilterWorker.TabIndex = 16;
            this.gbxFilterWorker.TabStop = false;
            this.gbxFilterWorker.Text = "Filter";
            // 
            // tbxSearchFirstName
            // 
            this.tbxSearchFirstName.Location = new System.Drawing.Point(122, 72);
            this.tbxSearchFirstName.Name = "tbxSearchFirstName";
            this.tbxSearchFirstName.Size = new System.Drawing.Size(289, 20);
            this.tbxSearchFirstName.TabIndex = 6;
            this.tbxSearchFirstName.TextChanged += new System.EventHandler(this.tbxSearchFirstName_TextChanged);
            // 
            // lblSearchFirstName
            // 
            this.lblSearchFirstName.AutoSize = true;
            this.lblSearchFirstName.Location = new System.Drawing.Point(39, 75);
            this.lblSearchFirstName.Name = "lblSearchFirstName";
            this.lblSearchFirstName.Size = new System.Drawing.Size(77, 13);
            this.lblSearchFirstName.TabIndex = 5;
            this.lblSearchFirstName.Text = "Ada Göre Ara: ";
            // 
            // cbxLocationTenant
            // 
            this.cbxLocationTenant.FormattingEnabled = true;
            this.cbxLocationTenant.Location = new System.Drawing.Point(123, 19);
            this.cbxLocationTenant.Name = "cbxLocationTenant";
            this.cbxLocationTenant.Size = new System.Drawing.Size(289, 21);
            this.cbxLocationTenant.TabIndex = 2;
            this.cbxLocationTenant.SelectedIndexChanged += new System.EventHandler(this.cbxLocationTenant_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(63, 22);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 13);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location :";
            // 
            // tbxSearchCompany
            // 
            this.tbxSearchCompany.Location = new System.Drawing.Point(123, 46);
            this.tbxSearchCompany.Name = "tbxSearchCompany";
            this.tbxSearchCompany.Size = new System.Drawing.Size(289, 20);
            this.tbxSearchCompany.TabIndex = 4;
            this.tbxSearchCompany.TextChanged += new System.EventHandler(this.tbxSearchTenant_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 49);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Firma İsmine Göre :";
            // 
            // gbxEditTenant
            // 
            this.gbxEditTenant.Controls.Add(this.tbxPhoneNumberEditTenant);
            this.gbxEditTenant.Controls.Add(this.tbxGsmNumberEditTenant);
            this.gbxEditTenant.Controls.Add(this.lblEmail);
            this.gbxEditTenant.Controls.Add(this.tbxEmail);
            this.gbxEditTenant.Controls.Add(this.cbxCompanyEditTenant);
            this.gbxEditTenant.Controls.Add(this.lblCompanyEditTenant);
            this.gbxEditTenant.Controls.Add(this.tbxInternalPhoneNumberEditTenant);
            this.gbxEditTenant.Controls.Add(this.btnDelete);
            this.gbxEditTenant.Controls.Add(this.lblInternalPhoneNumberEdit);
            this.gbxEditTenant.Controls.Add(this.btnUpdate);
            this.gbxEditTenant.Controls.Add(this.lblGsmNumberEditTenant);
            this.gbxEditTenant.Controls.Add(this.btnAdd);
            this.gbxEditTenant.Controls.Add(this.lblPhoneNumberEditTenant);
            this.gbxEditTenant.Controls.Add(this.tbxTitleEditTenant);
            this.gbxEditTenant.Controls.Add(this.lblTitleEditTenant);
            this.gbxEditTenant.Controls.Add(this.tbxLastNameEditTenant);
            this.gbxEditTenant.Controls.Add(this.lblLastNameEditTenant);
            this.gbxEditTenant.Controls.Add(this.tbxFirstNameEditTenant);
            this.gbxEditTenant.Controls.Add(this.lblFirstNameTenant);
            this.gbxEditTenant.Controls.Add(this.cbxLocationEditTenant);
            this.gbxEditTenant.Controls.Add(this.lblLocationEditTenant);
            this.gbxEditTenant.Location = new System.Drawing.Point(12, 386);
            this.gbxEditTenant.Name = "gbxEditTenant";
            this.gbxEditTenant.Size = new System.Drawing.Size(550, 200);
            this.gbxEditTenant.TabIndex = 15;
            this.gbxEditTenant.TabStop = false;
            this.gbxEditTenant.Text = "Edit Tenant";
            // 
            // tbxPhoneNumberEditTenant
            // 
            this.tbxPhoneNumberEditTenant.Location = new System.Drawing.Point(365, 72);
            this.tbxPhoneNumberEditTenant.Mask = "(999) 000-0000";
            this.tbxPhoneNumberEditTenant.Name = "tbxPhoneNumberEditTenant";
            this.tbxPhoneNumberEditTenant.Size = new System.Drawing.Size(168, 20);
            this.tbxPhoneNumberEditTenant.TabIndex = 15;
            // 
            // tbxGsmNumberEditTenant
            // 
            this.tbxGsmNumberEditTenant.Location = new System.Drawing.Point(365, 47);
            this.tbxGsmNumberEditTenant.Mask = "(999) 000-0000";
            this.tbxGsmNumberEditTenant.Name = "tbxGsmNumberEditTenant";
            this.tbxGsmNumberEditTenant.Size = new System.Drawing.Size(168, 20);
            this.tbxGsmNumberEditTenant.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(302, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "E-Mail :";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(364, 125);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(169, 20);
            this.tbxEmail.TabIndex = 17;
            // 
            // cbxCompanyEditTenant
            // 
            this.cbxCompanyEditTenant.FormattingEnabled = true;
            this.cbxCompanyEditTenant.Location = new System.Drawing.Point(100, 47);
            this.cbxCompanyEditTenant.Name = "cbxCompanyEditTenant";
            this.cbxCompanyEditTenant.Size = new System.Drawing.Size(169, 21);
            this.cbxCompanyEditTenant.TabIndex = 23;
            // 
            // lblCompanyEditTenant
            // 
            this.lblCompanyEditTenant.AutoSize = true;
            this.lblCompanyEditTenant.Location = new System.Drawing.Point(35, 51);
            this.lblCompanyEditTenant.Name = "lblCompanyEditTenant";
            this.lblCompanyEditTenant.Size = new System.Drawing.Size(57, 13);
            this.lblCompanyEditTenant.TabIndex = 22;
            this.lblCompanyEditTenant.Text = "Company :";
            // 
            // tbxInternalPhoneNumberEditTenant
            // 
            this.tbxInternalPhoneNumberEditTenant.Location = new System.Drawing.Point(364, 99);
            this.tbxInternalPhoneNumberEditTenant.Name = "tbxInternalPhoneNumberEditTenant";
            this.tbxInternalPhoneNumberEditTenant.Size = new System.Drawing.Size(169, 20);
            this.tbxInternalPhoneNumberEditTenant.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblInternalPhoneNumberEdit
            // 
            this.lblInternalPhoneNumberEdit.AutoSize = true;
            this.lblInternalPhoneNumberEdit.Location = new System.Drawing.Point(300, 102);
            this.lblInternalPhoneNumberEdit.Name = "lblInternalPhoneNumberEdit";
            this.lblInternalPhoneNumberEdit.Size = new System.Drawing.Size(56, 13);
            this.lblInternalPhoneNumberEdit.TabIndex = 20;
            this.lblInternalPhoneNumberEdit.Text = "Dahili No :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(331, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "GUNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblGsmNumberEditTenant
            // 
            this.lblGsmNumberEditTenant.AutoSize = true;
            this.lblGsmNumberEditTenant.Location = new System.Drawing.Point(307, 49);
            this.lblGsmNumberEditTenant.Name = "lblGsmNumberEditTenant";
            this.lblGsmNumberEditTenant.Size = new System.Drawing.Size(51, 13);
            this.lblGsmNumberEditTenant.TabIndex = 16;
            this.lblGsmNumberEditTenant.Text = "Gsm No :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(227, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPhoneNumberEditTenant
            // 
            this.lblPhoneNumberEditTenant.AutoSize = true;
            this.lblPhoneNumberEditTenant.Location = new System.Drawing.Point(292, 75);
            this.lblPhoneNumberEditTenant.Name = "lblPhoneNumberEditTenant";
            this.lblPhoneNumberEditTenant.Size = new System.Drawing.Size(66, 13);
            this.lblPhoneNumberEditTenant.TabIndex = 18;
            this.lblPhoneNumberEditTenant.Text = "Telefon No :";
            // 
            // tbxTitleEditTenant
            // 
            this.tbxTitleEditTenant.Location = new System.Drawing.Point(364, 20);
            this.tbxTitleEditTenant.Name = "tbxTitleEditTenant";
            this.tbxTitleEditTenant.Size = new System.Drawing.Size(169, 20);
            this.tbxTitleEditTenant.TabIndex = 13;
            // 
            // lblTitleEditTenant
            // 
            this.lblTitleEditTenant.AutoSize = true;
            this.lblTitleEditTenant.Location = new System.Drawing.Point(313, 23);
            this.lblTitleEditTenant.Name = "lblTitleEditTenant";
            this.lblTitleEditTenant.Size = new System.Drawing.Size(45, 13);
            this.lblTitleEditTenant.TabIndex = 14;
            this.lblTitleEditTenant.Text = "Ünvan :";
            // 
            // tbxLastNameEditTenant
            // 
            this.tbxLastNameEditTenant.Location = new System.Drawing.Point(100, 99);
            this.tbxLastNameEditTenant.Name = "tbxLastNameEditTenant";
            this.tbxLastNameEditTenant.Size = new System.Drawing.Size(169, 20);
            this.tbxLastNameEditTenant.TabIndex = 12;
            // 
            // lblLastNameEditTenant
            // 
            this.lblLastNameEditTenant.AutoSize = true;
            this.lblLastNameEditTenant.Location = new System.Drawing.Point(51, 102);
            this.lblLastNameEditTenant.Name = "lblLastNameEditTenant";
            this.lblLastNameEditTenant.Size = new System.Drawing.Size(43, 13);
            this.lblLastNameEditTenant.TabIndex = 12;
            this.lblLastNameEditTenant.Text = "Soyad :";
            // 
            // tbxFirstNameEditTenant
            // 
            this.tbxFirstNameEditTenant.Location = new System.Drawing.Point(100, 73);
            this.tbxFirstNameEditTenant.Name = "tbxFirstNameEditTenant";
            this.tbxFirstNameEditTenant.Size = new System.Drawing.Size(169, 20);
            this.tbxFirstNameEditTenant.TabIndex = 11;
            // 
            // lblFirstNameTenant
            // 
            this.lblFirstNameTenant.AutoSize = true;
            this.lblFirstNameTenant.Location = new System.Drawing.Point(68, 76);
            this.lblFirstNameTenant.Name = "lblFirstNameTenant";
            this.lblFirstNameTenant.Size = new System.Drawing.Size(26, 13);
            this.lblFirstNameTenant.TabIndex = 10;
            this.lblFirstNameTenant.Text = "Ad :";
            // 
            // cbxLocationEditTenant
            // 
            this.cbxLocationEditTenant.FormattingEnabled = true;
            this.cbxLocationEditTenant.Location = new System.Drawing.Point(100, 19);
            this.cbxLocationEditTenant.Name = "cbxLocationEditTenant";
            this.cbxLocationEditTenant.Size = new System.Drawing.Size(169, 21);
            this.cbxLocationEditTenant.TabIndex = 7;
            // 
            // lblLocationEditTenant
            // 
            this.lblLocationEditTenant.AutoSize = true;
            this.lblLocationEditTenant.Location = new System.Drawing.Point(35, 23);
            this.lblLocationEditTenant.Name = "lblLocationEditTenant";
            this.lblLocationEditTenant.Size = new System.Drawing.Size(59, 13);
            this.lblLocationEditTenant.TabIndex = 6;
            this.lblLocationEditTenant.Text = "Lokasyon :";
            // 
            // dgwTenant
            // 
            this.dgwTenant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTenant.Location = new System.Drawing.Point(12, 127);
            this.dgwTenant.Name = "dgwTenant";
            this.dgwTenant.RowHeadersWidth = 51;
            this.dgwTenant.Size = new System.Drawing.Size(1257, 252);
            this.dgwTenant.TabIndex = 14;
            this.dgwTenant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTenant_CellClick);
            // 
            // frmTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1281, 593);
            this.Controls.Add(this.btnRefreshTenant);
            this.Controls.Add(this.dgwTenant);
            this.Controls.Add(this.gbxEditTenant);
            this.Controls.Add(this.gbxFilterWorker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTenant";
            this.Text = "WamTurkey Phone Tenant - [ibozkurt]";
            this.Load += new System.EventHandler(this.frmTenant_Load);
            this.gbxFilterWorker.ResumeLayout(false);
            this.gbxFilterWorker.PerformLayout();
            this.gbxEditTenant.ResumeLayout(false);
            this.gbxEditTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTenant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshTenant;
        private System.Windows.Forms.GroupBox gbxFilterWorker;
        private System.Windows.Forms.ComboBox cbxLocationTenant;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbxSearchCompany;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxEditTenant;
        private System.Windows.Forms.TextBox tbxInternalPhoneNumberEditTenant;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblInternalPhoneNumberEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblGsmNumberEditTenant;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPhoneNumberEditTenant;
        private System.Windows.Forms.TextBox tbxTitleEditTenant;
        private System.Windows.Forms.Label lblTitleEditTenant;
        private System.Windows.Forms.TextBox tbxLastNameEditTenant;
        private System.Windows.Forms.Label lblLastNameEditTenant;
        private System.Windows.Forms.TextBox tbxFirstNameEditTenant;
        private System.Windows.Forms.Label lblFirstNameTenant;
        private System.Windows.Forms.ComboBox cbxLocationEditTenant;
        private System.Windows.Forms.Label lblLocationEditTenant;
        private System.Windows.Forms.DataGridView dgwTenant;
        private System.Windows.Forms.ComboBox cbxCompanyEditTenant;
        private System.Windows.Forms.Label lblCompanyEditTenant;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSearchFirstName;
        private System.Windows.Forms.Label lblSearchFirstName;
        private System.Windows.Forms.MaskedTextBox tbxPhoneNumberEditTenant;
        private System.Windows.Forms.MaskedTextBox tbxGsmNumberEditTenant;
    }
}