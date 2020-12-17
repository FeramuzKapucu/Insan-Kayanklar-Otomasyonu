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
    public partial class TakeAnExam : Form
    {
        public TakeAnExam()
        {
            InitializeComponent();
        }
        ApptitudeTypesORM aporm = new ApptitudeTypesORM();
        int subtract_date;//Zamanlar Arası fark tutulacak
       

        private void Loading()
        {
            cmbskill.DataSource = aporm.Select();
            cmbskill.DisplayMember = "ApptitudeName";
            cmbskill.ValueMember = "ID";
            cmbskill.SelectedIndex = -1;
        }

        private bool ApptitudeQuestionControl() //Yapılmak İstenilen Sınav Türü İçin Soru Var Mı Yok mu Onu Kontrol Eden Method
        {
            bool soru = false;

            SqlDataAdapter adp = new SqlDataAdapter("prc_ApptitudeTypes_Control", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@ApptitudeType", cmbskill.SelectedValue);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)  //Kayıtlı soru yok
                soru = false;
            else //Kayıtlı soru var
                soru = true;

            return soru;

        }

        private void TakeAnExam_Load(object sender, EventArgs e)
        {
            Loading();
        }


        private void btnexam_Click(object sender, EventArgs e)
        {
            if (cmbskill.SelectedIndex != -1) //Seçim Yapılmış
            {
                if (ApptitudeQuestionControl()) // İstenilen Türde Sınav Var
                {
                    
                    SqlDataAdapter adp = new SqlDataAdapter("prc_ExamDate_Control", Tools.Baglanti);
                    adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adp.SelectCommand.Parameters.AddWithValue("@UserID", UsersORM.AktifUser.ID);
                    adp.SelectCommand.Parameters.AddWithValue("@KeySkill",cmbskill.SelectedValue);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count == 0)  //Bu user için bu sınav türü için kayıt yok
                    {

                        TakeAnExam2 tk2 = new TakeAnExam2();
                        tk2.KeySkillid =Convert.ToInt32(cmbskill.SelectedValue);
                        tk2.Kayitvar = false;
                        tk2.ShowDialog();

                    }
                    
                    else  //Bu user için bu sınav türü için kayıt var
                    {
                        DateTime time = new DateTime();
                        SqlCommand cmd = new SqlCommand("prc_ExamDate_Control", Tools.Baglanti);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", UsersORM.AktifUser.ID);
                        cmd.Parameters.AddWithValue("@KeySkill", cmbskill.SelectedValue);

                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            time = Convert.ToDateTime(dr["Date"]);

                        }
                        dr.Close();

                        SqlCommand cmd2 =new SqlCommand("prc_ExamDate_Subtract", Tools.Baglanti);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@Timenow ", DateTime.Now);
                        cmd2.Parameters.AddWithValue("@TimeExam",time);
                        if (cmd2.Connection.State != ConnectionState.Open)
                            cmd2.Connection.Open();
                        SqlDataReader dr2 = cmd2.ExecuteReader();

                        while (dr2.Read())
                        {
                            subtract_date = Convert.ToInt32(dr2[0]); // Şua nın Zamanı Ve En son YApılan Sınav Arası Geçen Süre Ay Cinsinden

                        }
                        dr2.Close();

                        if (Convert.ToInt32(subtract_date) >30) // Son sınavın üzerinden 30 günden fazla geçmiş
                        {
                            TakeAnExam2 tk2 = new TakeAnExam2();
                            tk2.KeySkillid = Convert.ToInt32(cmbskill.SelectedValue);
                            tk2.Kayitvar = true;
                            tk2.ShowDialog();
                        }
                        else //Son Sınavın Üzerinden 30 Günden Fazla Geçmemiş
                        {
                            MessageBox.Show(string.Format("{0} Yetenek Sınavı İçin Son Sınavınız Üzerinden {1} Gün Geçmiştir.\n\nBu Yetenek Sınavı İçin Son Sınavınız Üzerinden Fazla Geçmemiştir(Yetenek Sınavları 30 Günde Bir Tekrarlanabilir).\n\nSistemede Kayıtlı Olan Son Sonucunuz Geçerlidir.", cmbskill.Text, subtract_date));
                            Loading();
                        }
                    }
                }
                else  //istenilen Türde Sınav Yok
                {
                    MessageBox.Show("Yapılmak İstenen Sınav Türü Sistemde Kayıtlı Bir Sınav Yoktur.\n\nBaşka Bir Sınav Yapmak İstiyorsanız Seçinin Ya Da Ana Menüye Dönünüz");
                    Loading();

                }

            }
            else //Seçim Yapılmamış
            {
                MessageBox.Show("Lütfen Olmak İstediğiniz Sınav İçin Listeden Seçim Yapınız");
            }
        }


    }
}
