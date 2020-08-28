using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResovers.Ninject;
using Entities.Concrete;
using String = System.String;

namespace WebFormsUI
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        //private IWorkerService _workerService = InstanceFactory.GetInstance<IWorkerService>();
        //private ILocationService _locationService = InstanceFactory.GetInstance<ILocationService>();
        //private IDepartmentService _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        //private IWorkerDetailService _workerDetailService = InstanceFactory.GetInstance<IWorkerDetailService>();



        //private ITenantService _tenantService = InstanceFactory.GetInstance<ITenantService>();
        private ICompanyService _companyService = InstanceFactory.GetInstance<ICompanyService>();
        //private ILocationService _locationService = InstanceFactory.GetInstance<ILocationService>();
        //private ITenantDetailService _tenantDetailService = InstanceFactory.GetInstance<ITenantDetailService>();

        private void frmCompany_Load(object sender, EventArgs e)
        {
           
            LoadCompany();
            
        }

        private void LoadCompany()
        {
            dgwCompany.DataSource = _companyService.GetAllCompany();
        }

        public void CompanyNameFilter(string companyName)
        {
            dgwCompany.DataSource = _companyService.GetAllCompany().Where(p => p.CompanyName.Contains(companyName)).ToList();
        }

        public void SearchCompanyName(string companyName)
        {
            dgwCompany.DataSource = _companyService.GetAllCompany().Where(p => p.CompanyName.ToLower().Contains(companyName)).ToList();


            //dgwWorker.DataSource = _workerDetailService.GetAllWorkerDetail().Where(p => p.FirstName.ToLower().Contains(firstName)).ToList();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _companyService.Add(new Company()
                {
                    CompanyName = tbxCompanyNameEdit.Text,
                });
                LoadCompany();
                ClearScreen();
                MessageBox.Show("Company Added!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _companyService.Update(new Company
                {
                    CompanyId = Convert.ToInt32(dgwCompany.CurrentRow.Cells[0].Value),
                    CompanyName = tbxCompanyNameEdit.Text,
                });
                LoadCompany();
                MessageBox.Show("Company Updated");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwCompany.CurrentRow != null)
            {
                try
                {
                    _companyService.Delete(new Company
                    {
                        CompanyId = Convert.ToInt32(dgwCompany.CurrentRow.Cells[0].Value)
                    });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            LoadCompany();
            ClearScreen();
            MessageBox.Show("Company Deleted!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearScreen();
            LoadCompany();
        }

        private void ClearScreen()
        {
            tbxCompanyNameEdit.Clear();
            tbxSearchCompanyName.Clear();
        }

        private void dgwCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCompanyNameEdit.Text = dgwCompany.CurrentRow.Cells[1].Value.ToString();
        }

        private void tbxSearchCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchCompanyName.Text))
            {
                SearchCompanyName(tbxSearchCompanyName.Text);
            }
            else
            {
                LoadCompany();
            }
        }

        private void telefonRehberiKiracıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTenant frmTenants = new frmTenant();
            frmTenants.Show();
            this.Hide();
        }
    }
}
