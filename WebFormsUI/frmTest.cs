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

namespace WebFormsUI
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }


        private ITenantService _tenantService = InstanceFactory.GetInstance<ITenantService>();
        private ICompanyService _companyService = InstanceFactory.GetInstance<ICompanyService>();
        private ILocationService _locationService = InstanceFactory.GetInstance<ILocationService>();
        private ITenantDetailService _tenantDetailService = InstanceFactory.GetInstance<ITenantDetailService>();

        
        private void frmTest_Load(object sender, EventArgs e)
        {
            dgwTenant.DataSource = _tenantDetailService.GetAllTenantDetails();
        }
    }
}
