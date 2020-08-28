namespace WebFormsUI
{
    partial class frmCompany
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
            this.dgwCompany = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbxFilterWorker = new System.Windows.Forms.GroupBox();
            this.tbxSearchCompanyName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxCompanyNameEdit = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).BeginInit();
            this.gbxFilterWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCompany
            // 
            this.dgwCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompany.Location = new System.Drawing.Point(12, 98);
            this.dgwCompany.Name = "dgwCompany";
            this.dgwCompany.RowHeadersWidth = 51;
            this.dgwCompany.Size = new System.Drawing.Size(382, 226);
            this.dgwCompany.TabIndex = 0;
            this.dgwCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCompany_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(296, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 73);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "EKRANI YENILE";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbxFilterWorker
            // 
            this.gbxFilterWorker.Controls.Add(this.tbxSearchCompanyName);
            this.gbxFilterWorker.Controls.Add(this.lblSearch);
            this.gbxFilterWorker.Location = new System.Drawing.Point(12, 12);
            this.gbxFilterWorker.Name = "gbxFilterWorker";
            this.gbxFilterWorker.Size = new System.Drawing.Size(278, 79);
            this.gbxFilterWorker.TabIndex = 14;
            this.gbxFilterWorker.TabStop = false;
            this.gbxFilterWorker.Text = "Filter";
            // 
            // tbxSearchCompanyName
            // 
            this.tbxSearchCompanyName.Location = new System.Drawing.Point(69, 34);
            this.tbxSearchCompanyName.Name = "tbxSearchCompanyName";
            this.tbxSearchCompanyName.Size = new System.Drawing.Size(198, 20);
            this.tbxSearchCompanyName.TabIndex = 4;
            this.tbxSearchCompanyName.TextChanged += new System.EventHandler(this.tbxSearchCompanyName_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(17, 37);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search :";
            this.lblSearch.TextChanged += new System.EventHandler(this.tbxSearchCompanyName_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(227, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(123, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "GUNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 35);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxCompanyNameEdit
            // 
            this.tbxCompanyNameEdit.Location = new System.Drawing.Point(41, 336);
            this.tbxCompanyNameEdit.Name = "tbxCompanyNameEdit";
            this.tbxCompanyNameEdit.Size = new System.Drawing.Size(249, 20);
            this.tbxCompanyNameEdit.TabIndex = 20;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 339);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 13);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "Ad :";
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 414);
            this.Controls.Add(this.tbxCompanyNameEdit);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gbxFilterWorker);
            this.Controls.Add(this.dgwCompany);
            this.Name = "frmCompany";
            this.Text = "WamTurkey Phone Company - [ibozkurt]";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).EndInit();
            this.gbxFilterWorker.ResumeLayout(false);
            this.gbxFilterWorker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCompany;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbxFilterWorker;
        private System.Windows.Forms.TextBox tbxSearchCompanyName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxCompanyNameEdit;
        private System.Windows.Forms.Label lblFirstName;
    }
}