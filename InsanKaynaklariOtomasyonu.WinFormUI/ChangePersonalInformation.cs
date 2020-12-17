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
    public partial class ChangePersonalInformation : Form
    {
        public ChangePersonalInformation()
        {
            InitializeComponent();
        }
        int id; //Aktif Kullanıcı için
        byte[] rsm; //Resim dosya yolu için

        UsersORM usorm = new UsersORM();

        private void Loading() // İşlemler Sonrası Çalışacak Method
        {
            errorProvider2.Clear();
            id = UsersORM.AktifUser.ID; // Aktif Kullanıcın Id'si
            errorProvider1.SetError(label4, "E Mail Adresini Değiştiremezssiniz\n\nDiğer Bilgilerini Değiştirebilirsiniz");
            SqlCommand cmd = new SqlCommand("Select * from Users where ID=@u1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@u1", id);

            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtname.Text = dr["Name"].ToString();
                txtsurname.Text = dr["Surname"].ToString();
                txtpassword.Text = dr["Password"].ToString();
                txtmail.Text = dr["Email"].ToString();
                nudexp.Value = Convert.ToDecimal(dr["Experience"]);
                byte[] resim = (byte[])dr["Picture"];
                MemoryStream ms = new MemoryStream(resim, 0, resim.Length);
                ms.Write(resim, 0, resim.Length);
                Image img = Image.FromStream(ms);
                pictureBox1.BackgroundImage = img;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                
            }
            dr.Close();
           
        }


        private void ChangeUserInformation_Load(object sender, EventArgs e)
        {
            Loading();
        }


        private void btnpicture_Click(object sender, EventArgs e)
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

        private void btnuptade_Click(object sender, EventArgs e)
        {
            if ((txtname.Text != "") && (txtsurname.Text != "") && (txtpassword.Text != ""))  //Alanlar Doldurulmuş
            {
                if (pictureBox1.ImageLocation != null) // Resim Ekli
                {
                   
                    DialogResult cevap = MessageBox.Show(string.Format("İsim : {0}\nSoyisim : {1}\nPassword : {2}\nExperience : {3}\n\nBilgiler Belirtildiği Gibi ve Resim Ekranda Görüldüğü Gibi Düzenlensin mi ", txtname.Text, txtsurname.Text, txtpassword.Text, nudexp.Value), "Güncelleme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes) // Bilgilerin Güncellenmesi İsteniyor.
                    {
                        Users user = new Users();
                        user.ID = id;
                        user.Name = txtname.Text.Trim();
                        user.Surname = txtsurname.Text.Trim();
                        user.Password = txtpassword.Text.Trim();
                        user.Email = txtmail.Text.Trim();
                        user.Picture = rsm;
                        user.Experience = Convert.ToInt32(nudexp.Value);

                        int etk = Convert.ToInt32(usorm.Update(user));
                        if (etk > 0) // Güncelleme Oldu
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarıyla Tamamlandı.");
                            Loading();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oldu.");
                            Loading();

                        }
                    }
                    else //Güncellenme İşelminde Vazgeçildi.
                    {
                        MessageBox.Show("Güncelleme İşleminden Vazgeçildi.");
                        Loading();
                    }


                }
                else  //Resim Eklenmemiş
                {
                    MessageBox.Show("Lütfen Uygun Bir Resim Ekleyiniz");
                }
            }
            else // Boş Alanlar Bırakılmış
            {
                errorProvider2.SetError(txtname, "Bu Alan Boş Bırakılamaz.");
                errorProvider2.SetError(txtsurname, "Bu Alan Boş Bırakılamaz.");
                errorProvider2.SetError(txtpassword, "Bu Alan Boş Bırakılamaz.");
            }
        }
    }
}
