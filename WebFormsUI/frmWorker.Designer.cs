namespace WebFormsUI
{
    partial class frmWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorker));
            this.dgwWorker = new System.Windows.Forms.DataGridView();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxEditWorker = new System.Windows.Forms.GroupBox();
            this.tbxPhoneNumberEdit = new System.Windows.Forms.MaskedTextBox();
            this.tbxGsmNumberEdit = new System.Windows.Forms.MaskedTextBox();
            this.tbxInternalPhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblInternalPhoneNumberEdit = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblGsmNumberTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPhoneNumberEdit = new System.Windows.Forms.Label();
            this.tbxTitleEdit = new System.Windows.Forms.TextBox();
            this.lblTitleEdit = new System.Windows.Forms.Label();
            this.tbxLastNameEdit = new System.Windows.Forms.TextBox();
            this.lblLastNameEdit = new System.Windows.Forms.Label();
            this.tbxFirstNameEdit = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbxDepartmentEdit = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbxLocationEdit = new System.Windows.Forms.ComboBox();
            this.lblLocationEdit = new System.Windows.Forms.Label();
            this.gbxFilterWorker = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorker)).BeginInit();
            this.gbxEditWorker.SuspendLayout();
            this.gbxFilterWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwWorker
            // 
            this.dgwWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWorker.Location = new System.Drawing.Point(5, 97);
            this.dgwWorker.Name = "dgwWorker";
            this.dgwWorker.Size = new System.Drawing.Size(1133, 340);
            this.dgwWorker.TabIndex = 70;
            this.dgwWorker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwWorker_CellClick);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(10, 22);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 13);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location :";
            // 
            // cbxLocation
            // 
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(69, 19);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(289, 21);
            this.cbxLocation.TabIndex = 1;
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(17, 49);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search :";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(69, 46);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(289, 20);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // gbxEditWorker
            // 
            this.gbxEditWorker.Controls.Add(this.tbxPhoneNumberEdit);
            this.gbxEditWorker.Controls.Add(this.tbxGsmNumberEdit);
            this.gbxEditWorker.Controls.Add(this.tbxInternalPhoneNumberEdit);
            this.gbxEditWorker.Controls.Add(this.btnDelete);
            this.gbxEditWorker.Controls.Add(this.lblInternalPhoneNumberEdit);
            this.gbxEditWorker.Controls.Add(this.btnUpdate);
            this.gbxEditWorker.Controls.Add(this.lblGsmNumberTitle);
            this.gbxEditWorker.Controls.Add(this.btnAdd);
            this.gbxEditWorker.Controls.Add(this.lblPhoneNumberEdit);
            this.gbxEditWorker.Controls.Add(this.tbxTitleEdit);
            this.gbxEditWorker.Controls.Add(this.lblTitleEdit);
            this.gbxEditWorker.Controls.Add(this.tbxLastNameEdit);
            this.gbxEditWorker.Controls.Add(this.lblLastNameEdit);
            this.gbxEditWorker.Controls.Add(this.tbxFirstNameEdit);
            this.gbxEditWorker.Controls.Add(this.lblFirstName);
            this.gbxEditWorker.Controls.Add(this.cbxDepartmentEdit);
            this.gbxEditWorker.Controls.Add(this.lblDepartment);
            this.gbxEditWorker.Controls.Add(this.cbxLocationEdit);
            this.gbxEditWorker.Controls.Add(this.lblLocationEdit);
            this.gbxEditWorker.Location = new System.Drawing.Point(12, 443);
            this.gbxEditWorker.Name = "gbxEditWorker";
            this.gbxEditWorker.Size = new System.Drawing.Size(550, 180);
            this.gbxEditWorker.TabIndex = 5;
            this.gbxEditWorker.TabStop = false;
            this.gbxEditWorker.Text = "groupBox1";
            // 
            // tbxPhoneNumberEdit
            // 
            this.tbxPhoneNumberEdit.Location = new System.Drawing.Point(365, 73);
            this.tbxPhoneNumberEdit.Mask = "(999) 000-0000";
            this.tbxPhoneNumberEdit.Name = "tbxPhoneNumberEdit";
            this.tbxPhoneNumberEdit.Size = new System.Drawing.Size(168, 20);
            this.tbxPhoneNumberEdit.TabIndex = 15;
            // 
            // tbxGsmNumberEdit
            // 
            this.tbxGsmNumberEdit.Location = new System.Drawing.Point(364, 46);
            this.tbxGsmNumberEdit.Mask = "(999) 000-0000";
            this.tbxGsmNumberEdit.Name = "tbxGsmNumberEdit";
            this.tbxGsmNumberEdit.Size = new System.Drawing.Size(169, 20);
            this.tbxGsmNumberEdit.TabIndex = 14;
            // 
            // tbxInternalPhoneNumberEdit
            // 
            this.tbxInternalPhoneNumberEdit.Location = new System.Drawing.Point(364, 102);
            this.tbxInternalPhoneNumberEdit.Name = "tbxInternalPhoneNumberEdit";
            this.tbxInternalPhoneNumberEdit.Size = new System.Drawing.Size(169, 20);
            this.tbxInternalPhoneNumberEdit.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 136);
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
            this.lblInternalPhoneNumberEdit.Location = new System.Drawing.Point(300, 105);
            this.lblInternalPhoneNumberEdit.Name = "lblInternalPhoneNumberEdit";
            this.lblInternalPhoneNumberEdit.Size = new System.Drawing.Size(56, 13);
            this.lblInternalPhoneNumberEdit.TabIndex = 20;
            this.lblInternalPhoneNumberEdit.Text = "Dahili No :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(331, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "GUNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblGsmNumberTitle
            // 
            this.lblGsmNumberTitle.AutoSize = true;
            this.lblGsmNumberTitle.Location = new System.Drawing.Point(307, 49);
            this.lblGsmNumberTitle.Name = "lblGsmNumberTitle";
            this.lblGsmNumberTitle.Size = new System.Drawing.Size(51, 13);
            this.lblGsmNumberTitle.TabIndex = 16;
            this.lblGsmNumberTitle.Text = "Gsm No :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(227, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPhoneNumberEdit
            // 
            this.lblPhoneNumberEdit.AutoSize = true;
            this.lblPhoneNumberEdit.Location = new System.Drawing.Point(292, 75);
            this.lblPhoneNumberEdit.Name = "lblPhoneNumberEdit";
            this.lblPhoneNumberEdit.Size = new System.Drawing.Size(66, 13);
            this.lblPhoneNumberEdit.TabIndex = 18;
            this.lblPhoneNumberEdit.Text = "Telefon No :";
            // 
            // tbxTitleEdit
            // 
            this.tbxTitleEdit.Location = new System.Drawing.Point(364, 20);
            this.tbxTitleEdit.Name = "tbxTitleEdit";
            this.tbxTitleEdit.Size = new System.Drawing.Size(169, 20);
            this.tbxTitleEdit.TabIndex = 13;
            // 
            // lblTitleEdit
            // 
            this.lblTitleEdit.AutoSize = true;
            this.lblTitleEdit.Location = new System.Drawing.Point(313, 23);
            this.lblTitleEdit.Name = "lblTitleEdit";
            this.lblTitleEdit.Size = new System.Drawing.Size(45, 13);
            this.lblTitleEdit.TabIndex = 14;
            this.lblTitleEdit.Text = "Ünvan :";
            // 
            // tbxLastNameEdit
            // 
            this.tbxLastNameEdit.Location = new System.Drawing.Point(100, 99);
            this.tbxLastNameEdit.Name = "tbxLastNameEdit";
            this.tbxLastNameEdit.Size = new System.Drawing.Size(169, 20);
            this.tbxLastNameEdit.TabIndex = 12;
            // 
            // lblLastNameEdit
            // 
            this.lblLastNameEdit.AutoSize = true;
            this.lblLastNameEdit.Location = new System.Drawing.Point(51, 102);
            this.lblLastNameEdit.Name = "lblLastNameEdit";
            this.lblLastNameEdit.Size = new System.Drawing.Size(43, 13);
            this.lblLastNameEdit.TabIndex = 12;
            this.lblLastNameEdit.Text = "Soyad :";
            // 
            // tbxFirstNameEdit
            // 
            this.tbxFirstNameEdit.Location = new System.Drawing.Point(100, 73);
            this.tbxFirstNameEdit.Name = "tbxFirstNameEdit";
            this.tbxFirstNameEdit.Size = new System.Drawing.Size(169, 20);
            this.tbxFirstNameEdit.TabIndex = 11;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(68, 76);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 13);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "Ad :";
            // 
            // cbxDepartmentEdit
            // 
            this.cbxDepartmentEdit.FormattingEnabled = true;
            this.cbxDepartmentEdit.Location = new System.Drawing.Point(100, 46);
            this.cbxDepartmentEdit.Name = "cbxDepartmentEdit";
            this.cbxDepartmentEdit.Size = new System.Drawing.Size(169, 21);
            this.cbxDepartmentEdit.TabIndex = 9;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(29, 49);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Departman :";
            // 
            // cbxLocationEdit
            // 
            this.cbxLocationEdit.FormattingEnabled = true;
            this.cbxLocationEdit.Location = new System.Drawing.Point(100, 19);
            this.cbxLocationEdit.Name = "cbxLocationEdit";
            this.cbxLocationEdit.Size = new System.Drawing.Size(169, 21);
            this.cbxLocationEdit.TabIndex = 7;
            // 
            // lblLocationEdit
            // 
            this.lblLocationEdit.AutoSize = true;
            this.lblLocationEdit.Location = new System.Drawing.Point(35, 23);
            this.lblLocationEdit.Name = "lblLocationEdit";
            this.lblLocationEdit.Size = new System.Drawing.Size(59, 13);
            this.lblLocationEdit.TabIndex = 6;
            this.lblLocationEdit.Text = "Lokasyon :";
            // 
            // gbxFilterWorker
            // 
            this.gbxFilterWorker.Controls.Add(this.cbxLocation);
            this.gbxFilterWorker.Controls.Add(this.lblLocation);
            this.gbxFilterWorker.Controls.Add(this.tbxSearch);
            this.gbxFilterWorker.Controls.Add(this.lblSearch);
            this.gbxFilterWorker.Location = new System.Drawing.Point(12, 12);
            this.gbxFilterWorker.Name = "gbxFilterWorker";
            this.gbxFilterWorker.Size = new System.Drawing.Size(372, 79);
            this.gbxFilterWorker.TabIndex = 6;
            this.gbxFilterWorker.TabStop = false;
            this.gbxFilterWorker.Text = "Filter";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(390, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 73);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "EKRANI YENILE";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1150, 625);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gbxFilterWorker);
            this.Controls.Add(this.gbxEditWorker);
            this.Controls.Add(this.dgwWorker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWorker";
            this.Text = "WamTurkey Phone Worker - [ibozkurt]";
            this.Load += new System.EventHandler(this.frmWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorker)).EndInit();
            this.gbxEditWorker.ResumeLayout(false);
            this.gbxEditWorker.PerformLayout();
            this.gbxFilterWorker.ResumeLayout(false);
            this.gbxFilterWorker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwWorker;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox gbxEditWorker;
        private System.Windows.Forms.ComboBox cbxDepartmentEdit;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbxLocationEdit;
        private System.Windows.Forms.Label lblLocationEdit;
        private System.Windows.Forms.GroupBox gbxFilterWorker;
        private System.Windows.Forms.TextBox tbxInternalPhoneNumberEdit;
        private System.Windows.Forms.Label lblInternalPhoneNumberEdit;
        private System.Windows.Forms.Label lblPhoneNumberEdit;
        private System.Windows.Forms.Label lblGsmNumberTitle;
        private System.Windows.Forms.TextBox tbxTitleEdit;
        private System.Windows.Forms.Label lblTitleEdit;
        private System.Windows.Forms.TextBox tbxLastNameEdit;
        private System.Windows.Forms.Label lblLastNameEdit;
        private System.Windows.Forms.TextBox tbxFirstNameEdit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MaskedTextBox tbxGsmNumberEdit;
        private System.Windows.Forms.MaskedTextBox tbxPhoneNumberEdit;
    }
}