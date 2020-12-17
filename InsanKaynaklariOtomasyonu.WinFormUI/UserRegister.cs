using InsanKaynaklari.ORM;
using InsanKaynaklari.ORM.Entity;
using InsanKaynaklari.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }
        byte[] rsm; //Resim dosya yolu için
        UsersORM usorm = new UsersORM();
        private void btnresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpg|*.jpg| Png |*.png";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fs);
                rsm = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                pictureBox1.ImageLocation = openFileDialog1.FileName;

            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if ((txtname.Text != "") && (txtsurname.Text != "") && (txtemail.Text != "") && (txtpassword.Text != "")) //Bu Alanları Boş Geçmediyse
            {
                errorProvider1.Clear();

                if (pictureBox1.ImageLocation != null) // Resim Eklenmiş 
                {
                    SqlDataAdapter adp = new SqlDataAdapter("Select * from Users where Email=@u1", Tools.Baglanti);
                    adp.SelectCommand.Parameters.AddWithValue("@u1", txtemail.Text.Trim());
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (dt.Rows.Count == 0) // Email Sistemde Kayıtlı değil Kayıt Yapılabilir
                    {
                        Users user = new Users();

                        user.Name = txtname.Text.Trim();
                        user.Surname = txtsurname.Text.Trim();
                        user.Password = txtpassword.Text.Trim();
                        user.Email = txtemail.Text.Trim();
                        user.Picture = rsm;
                        user.Experience = Convert.ToInt32(nudexperience.Value);

                        int etk =Convert.ToInt32(usorm.InsertScalar(user));

                        if(etk>0) //KayıtBaşarılı Bir Şekilde Gerçekleşti
                        {
                            MessageBox.Show("Kaydınız Devam Ediyor...");

                            UserRegister2 frm = new UserRegister2(); //Kaydın İlk kısmı başarılı ise User Register2 Formu AÇılacak.

                            frm.id = etk;
                            frm.Show();
                            this.Hide();
                            
                        }
                        else //Kayıt Sırasında Bir Hata Oluştu
                        {
                            MessageBox.Show("Kayıt Sırasında Bir Hata Oluştu.Lütfen Daha Sonra Takrar Deneyiniz");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Girilen e mail Adresi Zaten Sistemde Kayıtlı"); //Emial Sistemde Kayıtlı Tekrar Kayıt Yapılamaz
                    }

                }
                else // Resim Eklenmemiş
                {
                    MessageBox.Show("Lütfen 'Resim Ekle' Butonuna Tıklayarak Resminizi Giriniz");
                }

            }
            else //  Alanlar Boş Geçildiyse
            {
                errorProvider1.SetError(txtname, "İsim Alanı Boş Geçilemez.Lütfen İsminizi Yazınız");
                errorProvider1.SetError(txtsurname, "Soyisim Alanı Boş Geçilemez.Lütfen Soyisminizi Yazınız");
                errorProvider1.SetError(txtemail, "Mail Alanı Boş Geçilemez.Lütfen Mailinizi Yazınız");
                errorProvider1.SetError(txtpassword, "Şifre Alanı Boş Geçilemez.Lütfen Uygun Bir Şifre Yazınız");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            UserLogin lg = new UserLogin();
            lg.Show();
            this.Hide();
        }
    }
}
