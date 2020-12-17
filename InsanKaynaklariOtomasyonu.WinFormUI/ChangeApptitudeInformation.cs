using InsanKaynaklari.ORM;
using InsanKaynaklari.ORM.Entity;
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
    public partial class ChangeApptitudeInformation : Form
    {
        public ChangeApptitudeInformation()
        {
            InitializeComponent();
        }
        int id,ky_skillid, ks1, ks2, ks3; //User id ,userkeyskill id, sistemde kayıtlı diğer 3 skilin numarası
        bool lisans;
        double persnolity_test;

        ApptitudeTypesORM aporm = new ApptitudeTypesORM();
        UserSkillsORM usskorm = new UserSkillsORM();

        private void KeyskillToLabel(Label lb, int apid) //Keys Skilleri Label e taşıyan method
        {
            lb.Tag = apid;
            SqlCommand cmd2 = new SqlCommand("Select ApptitudeName from ApptitudeTypes where ID=@a1", Tools.Baglanti);
            cmd2.Parameters.AddWithValue("@a1", apid);

            if (cmd2.Connection.State != ConnectionState.Open)
                cmd2.Connection.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lb.Text = dr2["ApptitudeName"].ToString();
            }
            dr2.Close();
        }

        private void Loading() //İşlemler Sonrası Çalışacak Method
        {
            id = UsersORM.AktifUser.ID;// Aktif Kullanıcın Id'si

            cmbkeyskill.DataSource = aporm.Select();
            cmbkeyskill.DisplayMember = "ApptitudeName";
            cmbkeyskill.ValueMember = "ID";
            cmbkeyskill.SelectedIndex = -1;

            SqlCommand cmd = new SqlCommand("Select * from UserSkills where UserID=@u1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@u1", id);

            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ky_skillid =Convert.ToInt32(dr["UserSkilID"]);
                lisans = (bool)dr["Lisans"];
                txtuni.Text = dr["University"].ToString();
                ks1 = Convert.ToInt32(dr["KeySkill1"]);
                ks2 = Convert.ToInt32(dr["KeySkill2"]);
                ks3 = Convert.ToInt32(dr["KeySkill3"]);
                rchozet.Text = dr["OZet"].ToString();
                persnolity_test = Convert.ToDouble(dr["PersonalityTest"]);

            }
            dr.Close();
            if (lisans)
                rdbevet.Checked = true;
            else
            {
                rdbevet.Checked = true; //rdb evet checked change metodunu tetiklemek için yazıldı bu iki satır
                rdbevet.Checked = false;
                rdbhayır.Checked = true;
            }

            KeyskillToLabel(lblks1, ks1);
            KeyskillToLabel(lblks2, ks2);
            KeyskillToLabel(lblks3, ks3);
        }

        private void rdbevet_CheckedChanged(object sender, EventArgs e) //Evet Butonunun Tıklanıp Tıklanmamasına Göre Senaryo Değişimi
        {
            

            if (rdbevet.Checked == true)
            {
                lbluni.Visible = true;
                txtuni.Visible = true;
                txtuni.Focus();
            }
            else
            {
                lbluni.Visible = false;
                txtuni.Visible = false;
            }
        }

        private void btnks1_Click(object sender, EventArgs e)
        {
            lblks1.Text = "";
        }

        private void btnks2_Click(object sender, EventArgs e)
        {
            lblks2.Text = "";
        }

        private void btnks3_Click(object sender, EventArgs e)
        {
            lblks3.Text = "";
        }

        private void btnaddskill_Click(object sender, EventArgs e)
        {
            if (cmbkeyskill.SelectedIndex != -1)
            {
                if (lblks1.Text == "") //Hiç Yetenek Eklenmemiş
                {
                    lblks1.Text = cmbkeyskill.Text;
                    lblks1.Tag = cmbkeyskill.SelectedValue; // Daha sonra yaratılacak UserSkills nesnesinin KeySkill1 attribute i seçilen yeteneğin index numarası saklandı.
                    cmbkeyskill.SelectedIndex = -1;
                }
                else // 1.yetenek dolu
                {
                    if (lblks2.Text == "") // 1 dolu 2.sekme boş
                    {
                        if (lblks1.Text != cmbkeyskill.Text) //Aynı yetenek daha önce ekli değilse
                        {
                            lblks2.Text = cmbkeyskill.Text;
                            lblks2.Tag = cmbkeyskill.SelectedValue; // Daha sonra yaratılacak UserSkills nesnesinin KeySkill2 attribute i seçilen yeteneğin index numarası saklandı.
                            cmbkeyskill.SelectedIndex = -1;
                        }
                        else //Aynı yetenek daha önce ekli ise
                        {
                            MessageBox.Show("Seçilen Yetenek Zaten Ekli Lütfen Başka Bir Yetenek Seçiniz.");
                        }

                    }
                    else  //ilk  2 sekme de dolu 
                    {
                        if (lblks3.Text == "")  //ilk 2 sekme  dolu 3.boş
                        {
                            if ((lblks1.Text != cmbkeyskill.Text) && (lblks2.Text != cmbkeyskill.Text)) //Aynı yetenek daha önce ekli değilse
                            {
                                lblks3.Text = cmbkeyskill.Text;
                                lblks3.Tag = cmbkeyskill.SelectedValue; // Daha sonra yaratılacak UserSkills nesnesinin KeySkill3 attribute i seçilen yeteneğin index numarası saklandı.
                                cmbkeyskill.SelectedIndex = -1;
                            }
                            else //Aynı yetenek daha önce ekli ise
                            {
                                MessageBox.Show("Seçilen Yetenek Zaten Ekli Lütfen Başka Bir Yetenek Seçiniz.");
                            }
                        }

                        else //Tüm  Haneler Dolu
                        {
                            MessageBox.Show("En Fazla 3 Adet Yetenek Eklemesi Yapabilirsiniz.Yeteneğin Yanındaki Kırmızı Çarpıya Tıklarsanız Daha Önceden Ekli Yeteneği Kaldırabilirsiniz ");
                            cmbkeyskill.SelectedIndex = -1;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Combobox 'tan Bir Yetenek Seçiniz.");
            }
        } // Add Skill Butonu Sonu

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if ((rdbevet.Checked == true) || (rdbhayır.Checked == true)) //Butomlardan Birisi Seçili
            {
                errorProvider1.Clear();
                if (((rdbevet.Checked == true) && (txtuni.Text != "")) || (rdbhayır.Checked == true)) //Butonlardan evet tıklanıp üni girilmiş ya da butonlardana hayır tıklanmış
                {

                    errorProvider1.Clear();
                    if ((lblks1.Text != "") && (lblks2.Text != "") && (lblks3.Text != "")) // Yetenek Seçilmiş İse
                    {
                        if (rchozet.Text != "") //Özet Yazılmış
                        {
                            if (rdbhayır.Checked)
                                txtuni.Text = "";
                            bool lisans; // Son durumda butonlardan hangisi işaretlenmiş kontrol için
                            string lis;
                            if (rdbevet.Checked)
                            {
                                lisans = true;
                                lis = "EVET";
                            }

                            else
                            {
                                lisans = false;
                                lis = "HAYIR";
                            }


                            DialogResult cevap = MessageBox.Show(string.Format("1.Keyskill-- {0}\n2.Keyskill -- {1}\n3.Keyskill -- {2}\nLisans -- {3}\nÜniversite --{4}\nÖzet --{5}\n\nBilgiler Ekranda Gösterildiği Gibi Güncellensin mi", lblks1.Text, lblks2.Text, lblks3.Text, lis, txtuni.Text, rchozet.Text), "Güncelleme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                            if(cevap==DialogResult.Yes) // Güncelleme Yapılmak İsteniyor
                            {

                                UserSkills useskill = new UserSkills();
                                useskill.UserSkillID = ky_skillid;
                                useskill.UserID = id;
                                useskill.KeySKill1 = (int)lblks1.Tag;
                                useskill.KeySKill2 = (int)lblks2.Tag;
                                useskill.KeySKill3 = (int)lblks3.Tag;
                                useskill.Lisans = lisans;
                                useskill.University = txtuni.Text;
                                useskill.Ozet = rchozet.Text;
                                useskill.PersonalityTest = persnolity_test;

                                int etk =Convert.ToInt32(usskorm.Update(useskill));

                                if(etk>0)//Güncelleme İşlemi Başarıyla Yapıldı
                                {
                                    MessageBox.Show("Güncelleme İşlemi Başarıyla Yapıldı");
                                    Loading();
                                }
                                else //Güncelleme İşlemi Sırasında Bir Hata Oluştu
                                {
                                    MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu");
                                    Loading();
                                }
                            }
                            else // Güncelleme İşleminden Vazgeçildi
                            {
                                MessageBox.Show("Güncelleme İşleminden Vazgeçildi");
                                Loading();
                            }

                        }
                        else // Özet Bölümü Boş Bırakılmı
                        {
                            errorProvider1.SetError(rchozet, "Lütfen Kendinizi Tanımlayan Uygun Bir Özet Yazınız.");
                        }
                    }
                    else // Yetenek Seçimi Yapılmamış İse
                    {
                        errorProvider1.SetError(cmbkeyskill, "Lütfen Listeden 3 Adet Size Uygun Yetenek Seçiniz");
                    }
                }
                else if ((rdbevet.Checked == true) && txtuni.Text == "") //Butonlardan Evet Seçilmiş ama Uni Bilgisi Girilmemiş
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtuni, "Lütfen Üniversite Bilgisi Giriniz ya da Butonlardan 'HAYIR' olanı tıklayınız");
                }
            }
            else //Butonnlardan Hiç biri Seçilmemiş
            {
                errorProvider1.SetError(rdbevet, "Belirtilen Butonlardan Birisini İşaretleyiniz");
                errorProvider1.SetError(rdbhayır, "Belirtilen Butonlardan Birisini İşaretleyiniz");
            }
        }

        
        private void ChangeApptitudeInformation_Load(object sender, EventArgs e)
        {
            Loading();

        }

    }
}
