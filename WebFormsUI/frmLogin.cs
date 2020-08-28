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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = tbxUserName.Text;
            var password = tbxPassword.Text;

            var loginState = Login(userName, password);

            if (loginState)
                MessageBox.Show("Giriş Başarılı.");
            else
                MessageBox.Show("Giriş Başarısız!!!");


        }

        public bool Login(string userName, string password)
        {


            return false;
        }
    }
}
