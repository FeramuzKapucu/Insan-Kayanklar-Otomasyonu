using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminLogin adm = new AdminLogin();
            adm.Show();
            this.Hide();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            UserLogin user = new UserLogin();
            user.Show();
            this.Hide();
        }
    }
}
