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
    public partial class ViewApplicableJobs : Form
    {
        public ViewApplicableJobs()
        {
            InitializeComponent();
        }
        bool lisans; // Data Grid İşlemi 
        int id; //Tıklanan İşin ID'si Tutulacak
        int apptitudeid; //Tıklanan yetegin id'si için


        ApplicationsORM apporm = new ApplicationsORM();

        private void Loading() // İşlemler Sonrası Method
        {
            id = 0;
            txtexp.Clear();
            txtkeys.Clear();
            txtlis.Clear();
            txtplace.Clear();
            txtsalary.Clear();
            txttitle.Clear();
            rchdesig.Clear();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Jobs where Applicable=1", Tools.Baglanti);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private static double PersonalityPoint() // Personality Puanını Çeken Method
        {
            double perpoint = 0;
            SqlCommand cmd = new SqlCommand("Select PersonalityTest from UserSkills where UserID=@u1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@u1", UsersORM.AktifUser.ID);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                perpoint = Convert.ToDouble(dr["PersonalityTest"]);

            }
            dr.Close();
            return perpoint;
        }

        private static double SkillPoint(int apptitudeid) // Skill Point Hesaplamak İçin
        {

            SqlDataAdapter adp = new SqlDataAdapter("prc_ExamResuts_Resul", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@UserID", UsersORM.AktifUser.ID);
            adp.SelectCommand.Parameters.AddWithValue("@KeySkill", apptitudeid);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                double result = 0;
                SqlCommand cmd = new SqlCommand("prc_ExamResuts_Resul", Tools.Baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", UsersORM.AktifUser.ID);
                cmd.Parameters.AddWithValue("@KeySkill", apptitudeid);

                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    result =Convert.ToDouble(dr["Result"]);
                }
                dr.Close();
                return result;
            }
        }

        private string KeyskillToString(int apid) //Keys Skilleri String Hale Çevirmek İçin method
        {
            string st = "";
            SqlCommand cmd2 = new SqlCommand("Select ApptitudeName from ApptitudeTypes where ID=@a1", Tools.Baglanti);
            cmd2.Parameters.AddWithValue("@a1", apid);

            if (cmd2.Connection.State != ConnectionState.Open)
                cmd2.Connection.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                st = dr2["ApptitudeName"].ToString();
            }
            dr2.Close();

            return st;

        }

        private double RequirementPoint() // user req puanı hesaplamak için method
        {
            int ks1 = 0, ks2 = 0, ks3 = 0, exp = 0;
            bool lis = true;
            double point = 0;
            SqlCommand cmd = new SqlCommand("Select Experience,Lisans,KeySKill1,KeySKill2, KeySKill3 from Users U left join UserSkills US on U.ID=US.UserID  where UserID=@u1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@u1", UsersORM.AktifUser.ID);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                exp = Convert.ToInt32(dr["Experience"]);
                lis = (bool)dr["Lisans"];
                ks1 = Convert.ToInt32(dr["KeySkill1"]);
                ks2 = Convert.ToInt32(dr["KeySkill2"]);
                ks3 = Convert.ToInt32(dr["KeySkill3"]);
            }
            dr.Close();

            string st1 = KeyskillToString(ks1);
            string st2 = KeyskillToString(ks2);
            string st3 = KeyskillToString(ks3);

            if (exp >= Convert.ToInt32(txtexp.Text))
            {
                point++;
            }
            if (lis == lisans)
            {
                point++;
            }
            if ((st1 == txtkeys.Text) || (st2 == txtkeys.Text) || (st3 == txtkeys.Text))
            {
                point++;

            }
            return (100.0 * point) / 3.0;
        }


        private void ViewApplicableJobs_Load(object sender, EventArgs e)
        {
            Loading();
            KeyskillToString(4);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["JID"].Value);

                SqlCommand cmd = new SqlCommand("Select JID, Title, Designation, Salary, Place, Experience, Lisans, ApptitudeName,ID from Jobs J left join Requirements R on J.JID = R.JobID left join ApptitudeTypes A on R.KeySkill = A.ID where J.JID =@j1", Tools.Baglanti);
                cmd.Parameters.AddWithValue("@j1", id);
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    apptitudeid = Convert.ToInt32(dr["ID"]);
                    txttitle.Text = dr["Title"].ToString();
                    rchdesig.Text = dr["Designation"].ToString();
                    txtsalary.Text = dr["Salary"].ToString();
                    txtplace.Text = dr["Place"].ToString();
                    txtexp.Text = dr["Experience"].ToString();
                    txtkeys.Text = dr["ApptitudeName"].ToString();
                    lisans = (bool)dr["Lisans"];
                }
                dr.Close();
                if (lisans)
                {
                    txtlis.Text = "Lisans Mezunu";
                }
                else
                {
                    txtlis.Text = "Şart Yok";
                }
            }
            catch
            {
                MessageBox.Show("Lütfen İş Seçmek İçin Listeden Uygun Bir Yere Tıklayınız");
            }

        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlDataAdapter adp = new SqlDataAdapter("prc_Application_Control", Tools.Baglanti);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;

                adp.SelectCommand.Parameters.AddWithValue("@UserID", UsersORM.AktifUser.ID);
                adp.SelectCommand.Parameters.AddWithValue("@JobID", id);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(string.Format("{0} ID'li İş İçin İstenilen Nitelikler \n\nMin Experience : {1}\nLisan Durumu : {2}\nYetenek : {3}", id, txtexp.Text, txtlis.Text, txtkeys.Text));

                    MessageBox.Show(string.Format("{0} ID'li İşe Başvurmak  İçin {1} Yetenek Sınavından Sınav Puanınızın Olması Gerekmektedir.\n\nSon 30 Gün İçinde Belirtilen Yetenek Türünden Sınava Girdiyseniz.Bu Uyarıyı Dikkate Almayınız.\n\nSistemde Kayıtlı Bir Sınavınız Yoksa Sınav Notunuz Otomatik Olarak ' 0 (Sıfır) ' Girilecektir.\n\n\nSistemde Kayıtlı Sınav Bilginiz Olup Olmadığınız Öğrenmek İçin Ya da Sınav Olmak İçin Bu Bölümü Kapatıp 'Take An Exam For A Skill' Bölümüne Tıklayınız", id, txtkeys.Text));

                    DialogResult cevap = MessageBox.Show(string.Format("Tüm Uyarılarımızdan Sonra {0} ID'li İş İçin Başvuruda Bulunmayı İstiyor musunuz", id), "Başvuru Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)// Başvurulu Yapılmak İsteniyorsa
                    {
                        Applications app = new Applications();
                        app.UserID = UsersORM.AktifUser.ID;
                        app.JobID = id;

                        app.PersonalityPoint = PersonalityPoint(); //Personality Test Puanını Çekebilmek İçin
                        app.RequirementPoint = RequirementPoint(); //Requiremetn Puanını Çekebilmek İçin
                        app.SkillPoint = SkillPoint(apptitudeid); // Skillpoint Hesplamak İçin
                        app.Time = DateTime.Now;

                        int etk = Convert.ToInt32(apporm.Insert(app));

                        if(etk>0)
                        {
                            MessageBox.Show(string.Format("{0} ID'li İş İçin Başvurunuz Alınmıştır", id));
                            Loading();
                        }
                        else
                        {
                            MessageBox.Show("Başvuru Kaydı Sırasında Bir Hata Oluştu Lütfen Daha Sonra Tekrar Deneyiniz");
                            Loading();
                        }

                    }
                    else //Başvurudan Vazgeçildiyse
                    {
                        MessageBox.Show("Başvuru İşleminden Vazgeçildi.");
                        Loading();
                    }

                }
                else

                {
                    MessageBox.Show(string.Format("{0} ID'li İş İçin Daha Önceden Başvurunuz Mevcuttur\n\nMy Apllication Bölümünü Ve Messages Bölümünü Kontrol Ediniz", id));
                }

            }
            else
            {
                MessageBox.Show("Lütfen Başvurmak İstediğiniz İşi Listeden Seçiniz");
            }




        }




    }
}
