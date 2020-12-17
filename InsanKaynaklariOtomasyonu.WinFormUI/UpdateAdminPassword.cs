using InsanKaynaklari.ORM;
using InsanKaynaklari.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    public partial class UpdateAdminPassword : Form
    {
        public UpdateAdminPassword()
        {
            InitializeComponent();
        }

        private void UpdateAdminPassword_Load(object sender, EventArgs e)
        {
            txtadmin.Text = AdminlerORM.AktifAdmin.UserName.ToString();
            MessageBox.Show("Şifrenizi Değiştirmek İstiyorsanız Önce Eski Şifrenizi Ardından Yeni Şifrenizi Doğu Bir Şekilde Yazıp Butona Basınız");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtsifre.Text!= AdminlerORM.AktifAdmin.Password)
            {
                MessageBox.Show("Mevcut Şifrenizi Yanlış Girdiniz");
            }
            else
            {
                if(txtnew.Text!="")
                {
                    SqlCommand cmd = new SqlCommand("Update Adminler set Password=@a1 where UserName=@a2", Tools.Baglanti);
                    cmd.Parameters.AddWithValue("@a1", txtnew.Text);
                    cmd.Parameters.AddWithValue("@a2", txtadmin.Text);
                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();
                    int etk = cmd.ExecuteNonQuery();

                    if(etk>0)
                    {
                        MessageBox.Show("Şifreniz Başarıyla Değiştirildi");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Şifre Değiştirme İşlemi Sırasında Bir Hata Oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Yeni Şifrenizi Giriniz");
                }
            }
        }
    }
}
