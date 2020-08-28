namespace WebFormsUI
{
    partial class frmManagament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagament));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonRehberiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kiracılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonRehberiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiracıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarToolStripMenuItem,
            this.kiracılarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonRehberiToolStripMenuItem1});
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            // 
            // telefonRehberiToolStripMenuItem1
            // 
            this.telefonRehberiToolStripMenuItem1.Name = "telefonRehberiToolStripMenuItem1";
            this.telefonRehberiToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.telefonRehberiToolStripMenuItem1.Text = "Telefon Rehberi";
            this.telefonRehberiToolStripMenuItem1.Click += new System.EventHandler(this.telefonRehberiToolStripMenuItem1_Click);
            // 
            // kiracılarToolStripMenuItem
            // 
            this.kiracılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonRehberiToolStripMenuItem,
            this.kiracıEkleToolStripMenuItem});
            this.kiracılarToolStripMenuItem.Name = "kiracılarToolStripMenuItem";
            this.kiracılarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.kiracılarToolStripMenuItem.Text = "Kiracılar";
            // 
            // telefonRehberiToolStripMenuItem
            // 
            this.telefonRehberiToolStripMenuItem.Name = "telefonRehberiToolStripMenuItem";
            this.telefonRehberiToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.telefonRehberiToolStripMenuItem.Text = "Telefon Rehberi";
            this.telefonRehberiToolStripMenuItem.Click += new System.EventHandler(this.telefonRehberiToolStripMenuItem_Click);
            // 
            // kiracıEkleToolStripMenuItem
            // 
            this.kiracıEkleToolStripMenuItem.Name = "kiracıEkleToolStripMenuItem";
            this.kiracıEkleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.kiracıEkleToolStripMenuItem.Text = "Kiracı Ekle";
            this.kiracıEkleToolStripMenuItem.Click += new System.EventHandler(this.kiracıEkleToolStripMenuItem_Click);
            // 
            // frmManagament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 506);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManagament";
            this.Text = "WamTurkey Phone Managament - [ibozkurt]";
            this.Load += new System.EventHandler(this.frmManagament_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiracılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonRehberiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiracıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonRehberiToolStripMenuItem1;
    }
}