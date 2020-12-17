using InsanKaynaklari.ORM;
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
    public partial class UserRegister3 : Form
    {
        public UserRegister3()
        {
            InitializeComponent();
        }
        public int userskillid;
        int sayi;
        int soru; //Random ile Belirlenecek Sorunun id'si
        int maxsoru; // Toplam Kaç adet soru olduğu bilgisi için
        double cevap;

        bool sorutip;
        List<int> sorulanlar = new List<int>(); //Sorular Sorular Bir liste İçinde Tutulup Kontrol Edilecek Böylece Tekrar Sorulmayacak

        private void timer1_Tick(object sender, EventArgs e) //Soru için saniye işlemleri
        {
            int sn = Convert.ToInt32(lbltimer.Text);
            sn--;
            if (sn > 0)
            {
                lbltimer.Text = sn.ToString();
            }
            else
            {
                if ((rdbevet.Checked != false) || (rdbkısmen.Checked != false) || (rdbnotr.Checked != false) || (rdbhayır.Checked != false))  //İşaretleme Yapmadan Süre Bitti
                {
                    timer1.Stop();
                    MessageBox.Show("Belirtilen Zamanda Seçim Yapmadınız. Bu Soruyu İşaretlemediniz Sayılacak.");
                    NextQuestion();
                }
                else // İşaeretleme Yapıldı , Süre Bitti Ama Next Question Butonuna Tıklanmadı
                {
                    timer1.Stop();
                    MessageBox.Show("Lütfen Süreyi Dikkatli Kullanın. Süre Bittiği Zaman En Son İşaretli SeÇenek Cevap Kabul Edilir.İşaretli Cevap Yoksa Cevap Vermediniz Kabul Edilir.");
                    NextQuestion();
                }

            }
        }

        private void ExamineResult()  //Verilen Cevaplara Göre Sonuçların Değerlendirilmesi
        {
            if (sorutip) //Olumlu tarz da cevap verilmesi istenilen soru
            {
                if (rdbevet.Checked)
                {
                    cevap += 4;
                }
                else if (rdbkısmen.Checked)
                {
                    cevap += 3;
                }
                else if (rdbnotr.Checked)
                {
                    cevap += 2;
                }
                else if (rdbhayır.Checked)
                {
                    cevap += 1;
                }
            }
            else //Olumsuz tarz da cevap verilmesi istenilen soru
            {
                if (rdbevet.Checked)
                {
                    cevap += 1;
                }
                else if (rdbkısmen.Checked)
                {
                    cevap += 2;
                }
                else if (rdbnotr.Checked)
                {
                    cevap += 3;
                }
                else if (rdbhayır.Checked)
                {
                    cevap += 4;
                }
            }
        }
        private void NextQuestion() //Yeni Soru İçin Tıklandığında ya da Süre Bitince
        {
            ExamineResult();
            sayi++;
            RandomQuestion();

            prob.Value = prob.Value + 10;
            lbltimer.Text = "60".ToString();
            timer1.Enabled = true;
            rdbevet.Checked = false;
            rdbhayır.Checked = false;
            rdbkısmen.Checked = false;
            rdbnotr.Checked = false;
            lblcevap.Text = cevap.ToString();
        }



        private void NumberofQuestions()  //Kayıtlı Soru Sayısını Bulmak İçin Method
        {
            SqlCommand cmd = new SqlCommand("Select MAX(PersonalityQID) as MAX from PersonalityQuestions", Tools.Baglanti);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader(); // veri tabanından okuma işlemi
            while (dr.Read())
            {
                maxsoru = Convert.ToInt32(dr["MAX"]);

            }
            if (cmd.Connection.State != ConnectionState.Closed)
                cmd.Connection.Close();
            dr.Close();
        }

        private void RandomQuestion() // VeriTabanından Rastgele Soru Çekmeyi sağlar
        {
            Random rand = new Random();
            soru = rand.Next(1, maxsoru + 1);
            SqlDataAdapter adp = new SqlDataAdapter("select* from PersonalityQuestions where PersonalityQID=@p1", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@p1", soru);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                RandomQuestion();  //Seçilen random sayı için o id'li soru daha önceden silinmişse başka soru seçmek için
                return;
            }
            else
            {
                if (sorulanlar.Contains(soru)) // Seçilen Soru Sorulanların Arasında Varsa Bir Daha Sorulmadı.
                {
                    RandomQuestion();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("select* from PersonalityQuestions where PersonalityQID=@p1 ", Tools.Baglanti);
                    cmd2.Parameters.AddWithValue("@p1", soru);

                    if (cmd2.Connection.State != ConnectionState.Open)
                        cmd2.Connection.Open();
                    SqlDataReader dr2 = cmd2.ExecuteReader();

                    while (dr2.Read())
                    {
                        rchquestion.Text = dr2["Question"].ToString();
                        if (Convert.ToInt16(dr2["SoruTipi"]) == 1) //Veri Tabanındaki kayıda göre yapılan bir sorgu.
                        {
                            sorutip = true;
                        }
                        else
                        {
                            sorutip = false;
                        }
                        lblsoru.Text = sayi.ToString();


                    }
                    sorulanlar.Add(soru);
                    dr2.Close();
                    return;
                }

            }
        }

        private void UserRegister3_Load(object sender, EventArgs e)
        {
            lblcevap.Visible = false;
            MessageBox.Show("Kayıdınız Devam Ediyor\n\nKayıt İşelminin Tamalanabilmesi İçin Lütfen Sorulan Soruları Size Uygun Bir Biçimde Yanıtlayınız");
            sayi = 1;
            cevap = 0;
            NumberofQuestions();
            RandomQuestion();
            timer1.Enabled = true;


        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (sayi < 10)
            {
                if ((rdbevet.Checked != false) || (rdbkısmen.Checked != false) || (rdbnotr.Checked != false) || (rdbhayır.Checked != false)) //Yeni Soru Öncesi Butonlardan Biri Seçiliyse
                {
                    NextQuestion();
                }

                else
                {
                    MessageBox.Show("Lütfen Butonlardan Birini Seçerek Soruyu Cevaplayınız");
                }

            }
            else
            {

                if ((rdbevet.Checked != false) || (rdbkısmen.Checked != false) || (rdbnotr.Checked != false) || (rdbhayır.Checked != false)) //Son Soru utonKontrolu
                {
                    
                    ExamineResult(); //Sonuncu Sorunun Cevap Kontrolü
                    cevap = ((cevap * 100.0) / 40.0);
                    MessageBox.Show("Tüm Soruları Yanıtladınız");
                    timer1.Stop();
                    SqlCommand cmd = new SqlCommand("Update USerSkills set PersonalityTest=@u1 where UserSkilID=@u2", Tools.Baglanti); // Personality Test kolonu İçin Ekleme
                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@u1", cevap);
                    cmd.Parameters.AddWithValue("@u2", userskillid);

                    int etk = cmd.ExecuteNonQuery();
                    if (etk > 0)
                    {
                        MessageBox.Show("Kayıt İşlemi Başarıyla Tamalandı");
                        UserLogin uslgn = new UserLogin();
                        uslgn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt İşlemi Sırasında Bir Hata Gerçekleşti");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Butonlardan Birini Seçerek Soruyu Cevaplayınız");
                }
               
                  
            }

        }


    }
}
