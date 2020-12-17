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
    public partial class UserRegister2 : Form
    {
        public UserRegister2()
        {
            InitializeComponent();
        }
        public int id;
        ApptitudeTypesORM aporm = new ApptitudeTypesORM();
        UserSkillsORM usskillorm = new UserSkillsORM();


        private void UserRegister2_Load(object sender, EventArgs e)
        {
            lblid.Text = id.ToString(); // User Register formundan gelen id Bilgisi formun Açlışında gösterilecek

            lbluni.Visible = false;
            txtuni.Visible = false;

            cmbkeyskill.DataSource = aporm.Select();
            cmbkeyskill.DisplayMember = "ApptitudeName";
            cmbkeyskill.ValueMember = "ID";
            cmbkeyskill.SelectedIndex = -1;


            lblks1.Text = "";
            lblks2.Text = "";
            lblks3.Text = "";


        }

        private void rdbevet_CheckedChanged(object sender, EventArgs e) // Evet e tıklanırsa  textbox ve label ortaya çıkıp userdan universite bilgisi girmesi bekleniyor.
        {
            errorProvider1.Clear();
            txtuni.Clear();

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

        private void btnyetenek_Click(object sender, EventArgs e)
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
                            errorProvider1.Clear();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblks1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblks2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblks3.Text = "";

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if ((rdbevet.Checked == true) || (rdbhayır.Checked == true)) // Butonlardan Birisi İşaretlendi
            {
                errorProvider1.Clear();
                if (((rdbevet.Checked == true) && (txtuni.Text != "")) || (rdbhayır.Checked == true)) //Butonlardan Evet Seçilmiş ve Uni Bilgisi Girilmiş
                    errorProvider1.Clear();
                {
                    if ((lblks1.Text != "") && (lblks2.Text != "") && (lblks3.Text != "")) // Yetenek Seçilmiş İse
                    {
                        errorProvider1.Clear();

                      if(rchozet.Text!="") //Özet Yazılmış
                        {
                            bool lisans; // Son durumda butonlardan hangisi işaretlenmiş kontrol için
                            if (rdbevet.Checked)
                                lisans = true;
                            else
                                lisans = false;

                            errorProvider1.Clear();

                            UserSkills useskill = new UserSkills();

                            useskill.UserID = id;
                            useskill.KeySKill1 =(int)lblks1.Tag;
                            useskill.KeySKill2 = (int)lblks2.Tag;
                            useskill.KeySKill3 = (int)lblks3.Tag;
                            useskill.Lisans = lisans;
                            useskill.University = txtuni.Text;
                            useskill.Ozet = rchozet.Text;
                            useskill.PersonalityTest = 0; //UserRegister3'te Güncellemesi Yapılacak

                            int etk =Convert.ToInt32(usskillorm.InsertScalar(useskill)); 
                            if(etk>0)
                            {
                                MessageBox.Show("Kaydınız Devam Ediyor...");
                                UserRegister3 frm3 = new UserRegister3();
                                frm3.userskillid = etk; // Ekleme İşlemi Bu formda yapılıyor USerRegister3'Te ise Personlity Soruları İçin Puan Hesabı Yapılıp Update İşlemi İle Tabloya Ekleniyor
                                frm3.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kayıt Sırasında Bir Hata Oluştu Lütfen Daha Sonra Tekrar Deneyiniz");
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
                if ((rdbevet.Checked == true) && txtuni.Text == "") //Butonlardan Evet Seçilmiş ama Uni Bilgisi Girilmemiş
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtuni, "Lütfen Üniversite Bilgisi Giriniz ya da Butonlardan 'HAYIR' olanı tıklayınız");
                }

            }
            else // Butonlardan Hiçbiri İşaretlenmedi
            {
                errorProvider1.SetError(rdbevet, "Belirtilen Butonlardan Birisini İşaretleyiniz");
                errorProvider1.SetError(rdbhayır, "Belirtilen Butonlardan Birisini İşaretleyiniz");
            }
        }
    }
}
