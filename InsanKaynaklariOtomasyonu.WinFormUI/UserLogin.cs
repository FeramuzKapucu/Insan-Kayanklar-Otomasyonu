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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
       
        private void btnback_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {

            UsersORM uorm = new UsersORM();
            Users user = new Users(); // buton tıklanınca users sınıfından bir instance oluşturup usernmae ve password bilgisi textboxlara göre oluşturuluyor oluşturulan nesne usersorm deki girişyap fonskiyonunda kontrol ediliyor veri tabanından bir eşleşme varsa o aktif user sayılıp usermain formu açılıyır.
            //Eşleşme yoksa ise null geri dönüyor.Bu durumda kullanıcı adı ya da şifresi hatalı mesajı veriliyor.
            user.Email = txtmail.Text;
            user.Password = txtpassword.Text;

            Users aktif = uorm.Girisyap(user);
            if (aktif == null)
            {
                MessageBox.Show("Yanlış E Mail veya Parola");

            }
            else
            {
              UsersORM.AktifUser = aktif;


                UserMain umain = new UserMain();
                umain.Show();
                this.Hide();
                
            }
        }

        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegister uregister = new UserRegister();
            uregister.Show();
            this.Hide();
        }
    }
}
