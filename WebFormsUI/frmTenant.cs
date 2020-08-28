using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Business.DependencyResovers.Ninject;
using Entities.Concrete;

namespace WebFormsUI
{
    public partial class frmTenant : Form
    {
        public frmTenant()
        {
            InitializeComponent();
        }

        private ITenantService _tenantService = InstanceFactory.GetInstance<ITenantService>();
        private ICompanyService _companyService = InstanceFactory.GetInstance<ICompanyService>();
        private ILocationService _locationService = InstanceFactory.GetInstance<ILocationService>();
        private ITenantDetailService _tenantDetailService = InstanceFactory.GetInstance<ITenantDetailService>();
        private IUserService _userService = InstanceFactory.GetInstance<IUserService>();


        public void frmTenant_Load(object sender, EventArgs e)
        {
            LoadLocations();
            LoadCompany();
            LoadTenantDetails();
        }

        private void LoadTenantDetails()
        {
            dgwTenant.DataSource = _tenantDetailService.GetAllTenantDetails();
        }

        public void LocationNameFilter(string locationName)
        {
            //dgwTenant.DataSource = _tenantDetailService.GetAllTenantDetails().Where(p => p.LocationName.Contains(locationName)).ToList();
            dgwTenant.DataSource = _tenantDetailService.GetAllTenantDetails().Where(p => p.LocationId == 2).ToList();

        }

        

        private void ClearScreen()
        {
            cbxCompanyEditTenant.Text = "";
            cbxLocationEditTenant.Text = "";
            cbxLocationTenant.Text = "";
            tbxFirstNameEditTenant.Clear();
            tbxLastNameEditTenant.Clear();
            tbxTitleEditTenant.Clear();
            tbxGsmNumberEditTenant.Clear();
            tbxPhoneNumberEditTenant.Clear();
            tbxInternalPhoneNumberEditTenant.Clear();
            tbxSearchCompany.Clear();


            tbxEmail.Clear();
        }

        public void SearchCompanyName(string companyName)
        {
            dgwTenant.DataSource = _tenantDetailService.GetAllTenantDetails().Where(p => p.CompanyName.ToLower().Contains(companyName)).ToList();
        }

        public void SearchFirstName(string firstName)
        {
            dgwTenant.DataSource = _tenantDetailService.GetAllTenantDetails().Where(p => p.FirstName.ToLower().Contains(firstName)).ToList();
        }

        private void LoadLocations()
        {
            
            cbxLocationTenant.DataSource = _locationService.GetAllLocations();
            cbxLocationTenant.DisplayMember = "LocationName";
            cbxLocationTenant.ValueMember = "LocationId";

            cbxLocationEditTenant.DataSource = _locationService.GetAllLocations();
            cbxLocationEditTenant.DisplayMember = "LocationName";
            cbxLocationEditTenant.ValueMember = "LocationId";
        }

        private void LoadCompany()
        {
            cbxCompanyEditTenant.DataSource = _companyService.GetAllCompany();
            cbxCompanyEditTenant.DisplayMember = "CompanyName";
            cbxCompanyEditTenant.ValueMember = "CompanyId";
        }

        private void btnRefreshTenant_Click(object sender, EventArgs e)
        {
            LoadLocations();
            LoadTenantDetails();
            ClearScreen();

        }

        private void cbxLocationTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocationNameFilter(cbxLocationTenant.Text);
            }
            catch
            {

            }
        }

        private void tbxSearchTenant_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchCompany.Text))
            {
                SearchCompanyName(tbxSearchCompany.Text);
            }
            else
            {
                LoadTenantDetails();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _tenantService.Add(new Tenant()
                {
                    LocationId = Convert.ToInt32(cbxLocationEditTenant.SelectedValue),
                    CompanyId = Convert.ToInt32(cbxCompanyEditTenant.SelectedValue),
                    FirstName = tbxFirstNameEditTenant.Text,
                    LastName = tbxLastNameEditTenant.Text,
                    Title = tbxTitleEditTenant.Text,
                    GsmNumber = tbxGsmNumberEditTenant.Text,
                    PhoneNumber = tbxPhoneNumberEditTenant.Text,
                    InternalPhoneNumber = tbxInternalPhoneNumberEditTenant.Text,
                    Email = tbxEmail.Text,
                });
                LoadTenantDetails();
                ClearScreen();
                MessageBox.Show("Tenant Added!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SelectResult = MessageBox.Show("Seçilen Kiracının Bilgilerini Güncellemeyi Onaylıyor Musunuz ?", "i.bozkurt", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (SelectResult == DialogResult.Yes)
            {

                try
                {
                    _tenantService.Update(new Tenant
                    {
                        TenantId = Convert.ToInt32(dgwTenant.CurrentRow.Cells[0].Value),
                        LocationId = Convert.ToInt32(cbxLocationEditTenant.SelectedValue),
                        CompanyId = Convert.ToInt32(cbxCompanyEditTenant.SelectedValue),
                        FirstName = tbxFirstNameEditTenant.Text,
                        LastName = tbxLastNameEditTenant.Text,
                        Title = tbxTitleEditTenant.Text,
                        GsmNumber = tbxGsmNumberEditTenant.Text,
                        PhoneNumber = tbxPhoneNumberEditTenant.Text,
                        InternalPhoneNumber = tbxInternalPhoneNumberEditTenant.Text,
                        Email = tbxEmail.Text

                    });
                    LoadTenantDetails();
                    MessageBox.Show("Tenant Updated");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            if (SelectResult == DialogResult.No)
            {
                MessageBox.Show("Güncelleme İşleminden Vazgeçtiniz !!!");
            }
        }

        public DialogResult SelectResult { get; set; }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dgwTenant.CurrentRow != null)
            {

                try
                {
                    _tenantService.Delete(new Tenant
                    {
                        TenantId = Convert.ToInt32(dgwTenant.CurrentRow.Cells[0].Value)
                    });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            LoadTenantDetails();
            ClearScreen();
            MessageBox.Show("Kiracı Kaydı Başarılı Bir Şekilde Silinmiştir.");
        }

        private void dgwTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxLocationEditTenant.SelectedValue = dgwTenant.CurrentRow.Cells[1].Value;
            cbxCompanyEditTenant.Text = dgwTenant.CurrentRow.Cells[4].Value.ToString();
            tbxFirstNameEditTenant.Text = dgwTenant.CurrentRow.Cells[5].Value.ToString();
            tbxLastNameEditTenant.Text = dgwTenant.CurrentRow.Cells[6].Value.ToString();
            tbxTitleEditTenant.Text = dgwTenant.CurrentRow.Cells[7].Value.ToString();
            tbxGsmNumberEditTenant.Text = dgwTenant.CurrentRow.Cells[8].Value.ToString();
            tbxPhoneNumberEditTenant.Text = dgwTenant.CurrentRow.Cells[9].Value.ToString();
            tbxInternalPhoneNumberEditTenant.Text = dgwTenant.CurrentRow.Cells[10].Value.ToString();
            tbxEmail.Text = dgwTenant.CurrentRow.Cells[11].Value.ToString();
        }

        private void telefonRehberiSirketİÇİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWorker frmWorkers = new frmWorker();
            frmWorkers.Show();
            this.Hide();
        }

        private void kiracıYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany frmCompanys = new frmCompany();
            frmCompanys.Show();
            this.Hide();
        }

        private void tbxSearchFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchFirstName.Text))
            {
                SearchFirstName(tbxSearchFirstName.Text);
            }
            else
            {
                LoadTenantDetails();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearchFirstName.Text))
            {
                SearchFirstName(tbxSearchFirstName.Text);
            }
            else
            {
                LoadTenantDetails();
            }
        }
    }
}
