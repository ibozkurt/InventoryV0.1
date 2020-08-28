using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResovers.Ninject;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.NHibernate;
using Entities.Concrete;

namespace WebFormsUI
{
    public partial class frmWorker : Form
    {
        public frmWorker()
        {
            InitializeComponent();
        }

        private IWorkerService _workerService = InstanceFactory.GetInstance<IWorkerService>();
        private ILocationService _locationService = InstanceFactory.GetInstance<ILocationService>();
        private IDepartmentService _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        private IWorkerDetailService _workerDetailService = InstanceFactory.GetInstance<IWorkerDetailService>();


        public DialogResult SelectResult { get; set; }

        private void frmWorker_Load(object sender, EventArgs e)
        {
            LoadLocations();
            LoadDepartments();
            LoadWorkerDetails();
        }

        private void LoadWorkerDetails()
        {
            dgwWorker.DataSource = _workerDetailService.GetAllWorkerDetail();
 
        }

        private void LoadLocations()
        {

            cbxLocation.DataSource = _locationService.GetAllLocations();
            cbxLocation.DisplayMember = "LocationName";
            cbxLocation.ValueMember = "LocationId";

            cbxLocationEdit.DataSource = _locationService.GetAllLocations();
            cbxLocationEdit.DisplayMember = "LocationName";
            cbxLocationEdit.ValueMember = "LocationId";
        }
        public void LoadDepartments()
        {
            cbxDepartmentEdit.DataSource = _departmentService.GetAllDepartments();
            cbxDepartmentEdit.DisplayMember = "DepartmentName";
            cbxDepartmentEdit.ValueMember = "DepartmentId";
        }
        public void LoadWorkers()
        {
            dgwWorker.DataSource = _workerService.GetAllWorkers();
        }
        private void ClearScreen()
        {
            cbxLocationEdit.Text = "";
            cbxDepartmentEdit.Text = "";
            tbxSearch.Clear();
            tbxFirstNameEdit.Clear();
            tbxLastNameEdit.Clear();
            tbxTitleEdit.Clear();
            tbxGsmNumberEdit.Clear();
            tbxPhoneNumberEdit.Clear();
            tbxInternalPhoneNumberEdit.Clear();
        }
        public void LocationNameFilter(string locationName)
        {
            dgwWorker.DataSource = _workerDetailService.GetAllWorkerDetail().Where(p => p.LocationName.Contains(locationName)).ToList();
        }

        public void SearchFirstName(string firstName)
        {
            dgwWorker.DataSource = _workerDetailService.GetAllWorkerDetail().Where(p => p.FirstName.ToLower().Contains(firstName)).ToList();
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocationNameFilter(cbxLocation.Text);
            }
            catch
            {

            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearch.Text))
            {
                SearchFirstName(tbxSearch.Text);
            }
            else
            {
                LoadWorkerDetails();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _workerService.Add(new Worker()
                {
                    LocationId = Convert.ToInt32(cbxLocationEdit.SelectedValue),
                    DepartmentId = Convert.ToInt32(cbxDepartmentEdit.SelectedValue),
                    FirstName = tbxFirstNameEdit.Text,
                    LastName = tbxLastNameEdit.Text,
                    Title = tbxTitleEdit.Text,
                    GsmNumber = tbxGsmNumberEdit.Text,
                    PhoneNumber = tbxPhoneNumberEdit.Text,
                    InternalPhoneNumber = tbxInternalPhoneNumberEdit.Text
                });

                LoadWorkerDetails();
                ClearScreen();
                MessageBox.Show("Worker Added!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SelectResult = MessageBox.Show("Seçmiş Olduğunuz Kaydı Güncellemek İstediğinize Emin Misiniz ?", "i.bozkurt", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (SelectResult == DialogResult.Yes)
            {
                try
                {
                    _workerService.Update(new Worker
                    {
                        WorkerId = Convert.ToInt32(dgwWorker.CurrentRow.Cells[0].Value),
                        LocationId = Convert.ToInt32(cbxLocationEdit.SelectedValue),
                        DepartmentId = Convert.ToInt32(cbxDepartmentEdit.SelectedValue),
                        FirstName = tbxFirstNameEdit.Text,
                        LastName = tbxLastNameEdit.Text,
                        Title = tbxTitleEdit.Text,
                        GsmNumber = tbxGsmNumberEdit.Text,
                        PhoneNumber = tbxPhoneNumberEdit.Text,
                        InternalPhoneNumber = tbxInternalPhoneNumberEdit.Text
                    });

                    LoadWorkerDetails();
                    MessageBox.Show("Worker Updated!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            if (SelectResult == DialogResult.No)
            {
                MessageBox.Show("Çalışan Kaydı Güncelleme İşleminden Vazgeçildi !!!");
            }
        }

        private void dgwWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxLocationEdit.SelectedValue = dgwWorker.CurrentRow.Cells[1].Value;
            cbxDepartmentEdit.SelectedValue = dgwWorker.CurrentRow.Cells[2].Value;
            tbxFirstNameEdit.Text = dgwWorker.CurrentRow.Cells[5].Value.ToString();
            tbxLastNameEdit.Text = dgwWorker.CurrentRow.Cells[6].Value.ToString();
            tbxTitleEdit.Text = dgwWorker.CurrentRow.Cells[7].Value.ToString();
            tbxGsmNumberEdit.Text = dgwWorker.CurrentRow.Cells[8].Value.ToString();
            tbxPhoneNumberEdit.Text = dgwWorker.CurrentRow.Cells[9].Value.ToString();
            tbxInternalPhoneNumberEdit.Text = dgwWorker.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SelectResult = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "i.bozkurt", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (SelectResult == DialogResult.Yes)
            {

                if (dgwWorker.CurrentRow != null)
                {
                    try
                    {
                        _workerService.Delete(new Worker
                        {
                            WorkerId = Convert.ToInt32(dgwWorker.CurrentRow.Cells[0].Value)

                        });
                        MessageBox.Show("Worker Deleted!");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            

            if (SelectResult == DialogResult.No)
            {
                MessageBox.Show("Çalışan Silme İşleminden Vazgeçtiniz!");
            }
            LoadWorkerDetails();
            ClearScreen();
           
        }

        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadWorkerDetails();
            ClearScreen();
        }

        private void telefonRehberiKiracıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTenant frmTenants = new frmTenant();
            frmTenants.Show();
            this.Hide();
        }
    }
}