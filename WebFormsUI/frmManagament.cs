using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormsUI
{
    public partial class frmManagament : Form
    {
        public frmManagament()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        

        private void frmManagament_Load(object sender, EventArgs e)
        {

        }

       


        private void telefonRehberiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTenant frmTenants = new frmTenant();
            frmTenants.MdiParent = this;
            frmTenants.Show();
        }

        private void kiracıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany frmCompanys = new frmCompany();
            frmCompanys.MdiParent = this;
            frmCompanys.Show();
        }

        private void telefonRehberiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmWorker frmWorkers = new frmWorker();
            frmWorkers.MdiParent = this;
            frmWorkers.Show();
        }
    }
}
