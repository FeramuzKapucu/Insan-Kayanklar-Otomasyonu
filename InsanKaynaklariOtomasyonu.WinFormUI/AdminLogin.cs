using InsanKaynaklari.ORM.Entity;
using InsanKaynaklari.ORM.Facade;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        Login lg = new Login();

        private void btnback_Click(object sender, EventArgs e)
        {
            lg.Show();
            this.Close();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            AdminlerORM aorm = new AdminlerORM(); 
            Adminler admin = new Adminler();   // buton tıklanınca adminler sınıfından bir instance oluşturup usernmae ve password bilgisi textboxlara göre oluşturuluyor oluşturulan nesne ardminlerorm deki girişyap fonskiyonunda kontrol ediliyor veri tabanından bir eşleşme varsa o aktif admin sayılıp adminmain formu açılıyır.
            //Eşleşme yoksa ise null geri dönüyor.Bu durumda kullanıcı adı ya da şifresi hatalı mesajı veriliyor.
            admin.UserName = txtname.Text;
            admin.Password = txtpassword.Text;

            Adminler aktif = aorm.Girisyap(admin);
            if (aktif == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Parlo Yanlış");

            }
            else
            {
                AdminlerORM.AktifAdmin = aktif;

                AdminMain frm = new AdminMain();

                this.Hide();
                frm.Show();
            }
        }

    }
}

