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
    public partial class TakeAnExam2 : Form
    {
        public TakeAnExam2()
        {
            InitializeComponent();
        }
        ExamResultsORM erorm = new ExamResultsORM();
        double result;// User in Sonucunu Tutmak İçin
        public int KeySkillid;//Diğer Formdan Hangi Yeteneğin Sınavı İsteniyorsa Onun Id'si Gönderilecek.
        public bool Kayitvar;//Sistemde daha Önceden Kayıtlı Sınav Varsa Result Bölümü Update olacak yoksa yeni examresult oluşturulucak bu bilgi diğer formdan gönderilecek.

        int question_number; //İlgili yetenek için soru sayısı tutulacak
        int min_quesid; //İlgili yetenek için min question id
        int max_quesid; //İlgili yetenek için max question id

        int max_sorulacak;// Sorulacak Soru Sayısını Belirlemek İçin Eğer Veri Tabanındaki Soru Sayısı 10 Dan Büyük İse 10 Soru Sorulacak; Değilse Veri Tabanındaki Soru Sayısı Kadar Sorulacak
        int sayi; //O anki durumda kaçıncı soruda olduğu tutulacak
        int soru;// O an Sorulacak Sorunun ID'si
        List<int> sorulanlar = new List<int>(); //Sorular Sorular Bir liste İçinde Tutulup Kontrol Edilecek Böylece Tekrar Sorulmayacak
        private void timer1_Tick(object sender, EventArgs e)
        {
            int sn = Convert.ToInt32(lbltimer.Text);
            sn--;
            if (sn > 0)
            {
                lbltimer.Text = sn.ToString();
            }
            else
            {
                if ((rdbA.Checked == false) && (rdbB.Checked == false) && (rdbC.Checked == false) && (rdbD.Checked == false)) //İşaretleme Yapmadan Soru Bitti
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
        private void ExamineTheResult()
        {
            if ((rdbA.Checked) && (Convert.ToChar(rchquestion.Tag) == 'A'))
            {
                result++;
            }
            else if ((rdbB.Checked) && (Convert.ToChar(rchquestion.Tag) == 'B'))
            {
                result++;
            }
            else if ((rdbC.Checked) && (Convert.ToChar(rchquestion.Tag) == 'C'))
            {
                result++;
            }
            else if ((rdbD.Checked) && (Convert.ToChar(rchquestion.Tag) == 'D'))
            {
                result++;
            }
            lblcevap2.Text = result.ToString();
        }
        private void NextQuestion() //Yeni Soru İçin Tıklandığında ya da Süre Bitince
        {
            sayi++;
            ExamineTheResult();
            RandomQuestion();
            lbltimer.Text = "90".ToString();
            lblsayi.Text = string.Format("{0} . Question", sayi);
            timer1.Enabled = true;
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
        }

        private void RandomQuestion() // VeriTabanından Rastgele Soru Çekmeyi sağlar
        {

            Random rand = new Random();
            soru = rand.Next(min_quesid, max_quesid + 1);
            SqlDataAdapter adp = new SqlDataAdapter("select *  from ApptitudeQuestions where ApptitudeType=@a1 and QuestionID=@a2", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@a1", KeySkillid);
            adp.SelectCommand.Parameters.AddWithValue("@a2", soru);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                RandomQuestion();  //Seçilen random sayı için o id'li soru daha önceden silinmişse başka soru seçmek için
                return;
            }
            else //Rastgele Sayıya Karşılık Gelen Soru Var
            {
                if (sorulanlar.Contains(soru)) // Seçilen Soru Sorulanların Arasında Varsa Bir Daha Sorulmadı.
                {
                    RandomQuestion();
                }
                else  // Seçilen Soru Sorulanların Arasında Yok
                {
                    SqlCommand cmd = new SqlCommand("select *  from ApptitudeQuestions where ApptitudeType=@a1 and QuestionID=@a2", Tools.Baglanti);
                    cmd.Parameters.AddWithValue("@a1", KeySkillid);
                    cmd.Parameters.AddWithValue("@a2", soru);

                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rchquestion.Text = dr["Question"].ToString();
                        rcho1.Text = dr["Secenek1"].ToString();
                        rcho2.Text = dr["Secenek2"].ToString();
                        rcho3.Text = dr["Secenek3"].ToString();
                        rcho4.Text = dr["Secenek4"].ToString();
                        rchquestion.Tag = dr["Cevap"];
                        lblcevap.Text = dr["Cevap"].ToString();

                    }
                    sorulanlar.Add(soru);

                    dr.Close();
                    return;
                }
            }



        }
        private int NumberofQuestions() //İlgili Yetenek İçin Veri Tabanındaki Toplam Soru Sayısı
        {
            int quest = 0;
            SqlCommand cmd = new SqlCommand("select COUNT(QuestionID) from ApptitudeQuestions where ApptitudeType=@a1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@a1", KeySkillid);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                quest = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            return quest;
        }
        private int MinQuestID() // İlgili Yetenek İçin Veri Tabanındaki Min Soru Id'si
        {
            int min = 0;
            SqlCommand cmd = new SqlCommand("select MIN(QuestionID) from ApptitudeQuestions where ApptitudeType=@a1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@a1", KeySkillid);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                min = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            return min;
        }

        private int MAxQuestID() // İlgili Yetenek İçin Veri Tabanındaki Max Soru Id'si
        {
            int max = 0;
            SqlCommand cmd = new SqlCommand("select Max(QuestionID) from ApptitudeQuestions where ApptitudeType=@a1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@a1", KeySkillid);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                max = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            return max;
        }

        private void TakeAnExam2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Seçtiğiniz Yeteneğe Göre En Fazla 10 Adet Olmak Üzere Rastgele Sorular Sorulacaktır.\n\nSınav Başladıktan Sonra İptal Edemeyeceksiniz. Sınav Süresi 5-15 Dakika Arasında Olacaktır.\n\nEğer Sınava Girmekten Vazgeçtiyseniz.'Geri Dön' Butonuna Tıklayınız.\n\nSınava Girmek İçin 'Sınava Başla Butonuna Tıklayınız.'");
            rcho1.Visible = false;
            rcho2.Visible = false;
            rcho3.Visible = false;
            rcho4.Visible = false;
            rchquestion.Visible = false;
            lblsayi.Visible = false;
            lbltimer.Visible = false;
            lblsn.Visible = false;
            btnnext.Visible = false;
            rdbA.Visible = false;
            rdbB.Visible = false;
            rdbC.Visible = false;
            rdbD.Visible = false;

            SqlCommand cmd = new SqlCommand("Select ApptitudeName from ApptitudeTypes where ID=@a1 ", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@a1", KeySkillid);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[0] + " Sınavına Hoş Geldiniz";

            }
            dr.Close();
        }

        private void btngeri_Click(object sender, EventArgs e) // Sıanav Başlamadan Çıkış Yapılmak İstenirse
        {
            this.Close();
        }

        private void btnbasla_Click(object sender, EventArgs e) // Sınava Başlamak İstendi
        {
            sorulanlar.Clear();
            sayi = 1;
            result = 0;
            label1.Visible = false;
            question_number = NumberofQuestions();
            min_quesid = MinQuestID();
            max_quesid = MAxQuestID();
            btnbasla.Visible = false;
            btngeri.Visible = false;
            btnnext.Visible = true;
            rcho1.Visible = true;
            rcho2.Visible = true;
            rcho3.Visible = true;
            rcho4.Visible = true;
            rchquestion.Visible = true;
            rdbA.Visible = true;
            rdbB.Visible = true;
            rdbC.Visible = true;
            rdbD.Visible = true;
            lblsn.Visible = true;
            lbltimer.Visible = true;
            lblsayi.Visible = true;
            lblsayi.Text = string.Format("{0} . Question", sayi);
            lbltimer.Text = "90".ToString();
            timer1.Enabled = true;
            if (question_number >= 10) // Veri Tabanındaki Soru Sayısı 10'dan Fazla Toplam 10 Soru Sorulacak
            {
                max_sorulacak = 10;
            }
            else // Veri Tabanındaki Soru Sayısı 10'dan Az Veri Tabanında Ne kadar Soru Varsa O kadar Sorulacak
            {
                max_sorulacak = question_number;
            }
            RandomQuestion();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            if (sayi < max_sorulacak)
            {
                if ((rdbA.Checked != false) || (rdbB.Checked != false) || (rdbC.Checked != false) || (rdbD.Checked != false)) //Yeni Soru Öncesi Butonlardan Biri Seçiliyse
                {
                    NextQuestion();
                }
                else //Yeni Soru İçin Cevaplama Yapılmadıysa
                {
                    MessageBox.Show("Lütfen Soruyu Cevaplandırınız");
                }
            }
            else
            {
                if ((rdbA.Checked != false) || (rdbB.Checked != false) || (rdbC.Checked != false) || (rdbD.Checked != false))//Son sorun için tıklanma kontolü  
                {
                    ExamineTheResult(); //Sonuncu Sorunun Cevap Kontrolü
                    result = ((result * 100.0) / max_sorulacak);
                    MessageBox.Show(string.Format("Tüm Soruları Yanıtladınız {0} Puan Aldınız", result));
                    timer1.Stop();

                    if (Kayitvar) //Sistemde Daha Önceden Bu Kişi İçin Bu Sınav Türünde Kayıt Var Sadece Puan Güncellemesi Yapılcak
                    {
                        SqlCommand cmd = new SqlCommand("Update ExamResults set Result=@e1,Date=@e2 where UserID=@e3 and KeySkill=@e4", Tools.Baglanti); // Personality Test kolonu İçin Ekleme
                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();
                        cmd.Parameters.AddWithValue("@e1", result);
                        cmd.Parameters.AddWithValue("@e2", DateTime.Now);
                        cmd.Parameters.AddWithValue("@e3", UsersORM.AktifUser.ID);
                        cmd.Parameters.AddWithValue("@e4", KeySkillid);

                        int etk = cmd.ExecuteNonQuery();

                        if (etk > 0) //Sınav Sonucu İçin Güncelleme Başarılı Bir Şekilde Yapıldı
                        {
                            MessageBox.Show("Sınav Sonucunuz Sisteme Başarılı Bir Şekilde Eklenmiştir");
                        }
                        else //Sınav Sonucunu  Güncelleme Sırasında  Bir Hata Oluştu.
                        {
                            MessageBox.Show("Sınav Sonucunun Eklenmesi Sırasında Bir Hata Oluştu.Lütfen Daha Sonra Tekrar Deneyiniz");
                        }
                    }
                    else // Sistemde Bu Kişi İçin Bu Sınav Türünde Kayıt Yok Yeni Bir ExamResult Nesnesi Oluşturulup Eklenecek
                    {
                        ExamResults er = new ExamResults();
                        er.UserID = UsersORM.AktifUser.ID;
                        er.Keyskill = KeySkillid;
                        er.Result = result;
                        er.Date = DateTime.Now;

                        int etk = Convert.ToInt32(erorm.Insert(er));
                        if (etk > 0) //Sınav Sonucu İçin Güncelleme Başarılı Bir Şekilde Yapıldı
                        {
                            MessageBox.Show("Sınav Sonucunuz Sisteme Başarılı Bir Şekilde Eklenmiştir");
                        }
                        else //Sınav Sonucunu  Güncelleme Sırasında  Bir Hata Oluştu.
                        {
                            MessageBox.Show("Sınav Sonucunun Eklenmesi Sırasında Bir Hata Oluştu.Lütfen Daha Sonra Tekrar Deneyiniz");
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Soruyu Cevaplandırınız");
                }

            }



        }
    }
}
