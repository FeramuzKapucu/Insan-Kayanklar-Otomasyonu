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
    public partial class ViewApptitudeQuestion : Form
    {
        public ViewApptitudeQuestion()
        {
            InitializeComponent();
        }
        int id;
        int atype;// Apprittude Type i select edebilmek için
        ApptitudeQuestionsORM appquesorm = new ApptitudeQuestionsORM();
        IslemKayitORM ikorm = new IslemKayitORM();

        private void Loading() //Update Delete ve Form load sonrası çalışacak method
        {
            dataGridView1.DataSource = appquesorm.Select();
            id = 0;
            cmbanswer.SelectedIndex = -1;
            rchquestion.Clear();
            rcho1.Clear();
            rcho2.Clear();
            rcho3.Clear();
            rcho4.Clear();
            lblanswer.Text = "";
            lbltype.Text = "";
        }

        private void ViewApptitudeQuestion_Load(object sender, EventArgs e)
        {
            Loading();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells["QuestionID"].Value;
                SqlCommand cmd = new SqlCommand("select* from ApptitudeQuestions where QuestionID=@a1 ", Tools.Baglanti);
                cmd.Parameters.AddWithValue("@a1", id);

                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rchquestion.Text = dr["Question"].ToString();
                    atype = Convert.ToInt32(dr["ApptitudeType"]);
                    rcho1.Text = dr["Secenek1"].ToString();
                    rcho2.Text = dr["Secenek2"].ToString();
                    rcho3.Text = dr["Secenek3"].ToString();
                    rcho4.Text = dr["Secenek4"].ToString();
                    lblanswer.Text = dr["Cevap"].ToString();
                }
                dr.Close();

                SqlCommand cmd2 = new SqlCommand("select* from ApptitudeTypes where ID=@a1 ", Tools.Baglanti);
                cmd2.Parameters.AddWithValue("@a1", atype);
                if (cmd2.Connection.State != ConnectionState.Open)
                    cmd2.Connection.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    lbltype.Text = dr2["ApptitudeName"].ToString();
                }
                dr2.Close();
            }

            catch
            {
                MessageBox.Show("Lütfen Listeden Uygun Bir Yere Tıklayınız");
                Loading();
            }
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if ((rchquestion.Text != "") && (rcho1.Text != "") && (rcho2.Text != "") && (rcho3.Text != "") && (rcho4.Text != ""))//Boş Bırakılan Bir Yer Yok
                {
                    errorProvider1.Clear();
                    if (cmbanswer.SelectedIndex != -1)
                    {
                        DialogResult cevap = MessageBox.Show(string.Format("{0} ID li Soru İçin\n\n Question ---{1}\n\n\n A Şıkkı ---{2}\n\nB Şıkkı ---{3}\n\nC Şıkkı ---{4}\n\nD Şıkkı ---{5}\n\nCevap  ---{6}", id, rchquestion.Text, rcho1.Text, rcho2.Text, rcho3.Text, rcho4.Text, cmbanswer.Text), "\n\nGüncelleme İşleme Aşağıda Belirtildiği Gibi Yapılsın mı?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (cevap == DialogResult.Yes) // Güncelleme Yapılmak İsteniyor
                        {
                            ApptitudeQuestions appques = new ApptitudeQuestions();
                            appques.QuestionID = id;
                            appques.ApptitudeType = atype;
                            appques.Question = rchquestion.Text;
                            appques.Secenek1 = rcho1.Text;
                            appques.Secenek2 = rcho2.Text;
                            appques.Secenek3 = rcho3.Text;
                            appques.Secenek4 = rcho4.Text;
                            appques.Cevap = cmbanswer.Text;

                            int etk = Convert.ToInt32(appquesorm.Update(appques));

                            if (etk > 0) // Güncelleme Yapıldı
                            {
                                MessageBox.Show(string.Format("{0} ID'li Soru İçin Update İşlemi Başarılı Bir Şekilde Yapıldı", id));
                                IslemKayit ik = new IslemKayit();
                                ik.NesneID = id;
                                ik.IslemForm = IslemForm.ApptitudeQuestion;
                                ik.IslemTipi = IslemTipi.Updating;
                                ik.IslemTarihi = DateTime.Now;
                                ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                                ikorm.Insert(ik);
                                Loading();

                            }
                            else
                            {
                                MessageBox.Show("Güncelleme Sırasında Bir Hata Meydana Geldi");
                                Loading();
                            }
                        }
                        else // Güncellemekten Vazgeçildi
                        {
                            MessageBox.Show(string.Format("{0} ID'li Soru İçin Güncelleme İşlemi İptal Edildi", id));
                            Loading();
                        }
                    }
                    else
                    {
                        MessageBox.Show(String.Format("{0} ID li Soru İçin Combobox 'tan Uygun Bir Cevap Seçiniz", id));
                    }
                }
                else // Boş Yerler var
                {
                    errorProvider1.SetError(rchquestion, "Lütfen Soruyu Giriniz");
                    errorProvider1.SetError(rcho1, "Lütfen A Şıkkını Giriniz");
                    errorProvider1.SetError(rcho2, "Lütfen B Şıkkını Giriniz");
                    errorProvider1.SetError(rcho3, "Lütfen C Şıkkını Giriniz");
                    errorProvider1.SetError(rcho4, "Lütfen D ŞıkkınıGiriniz");

                }
            }
            else //Data grid e Tıklanmamış
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Soruya Aşağıdaki Listeden Tıklayınız");
            }
        } //Update Sonu

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID li Soru ('{1}' )Silinsin mi", id, rchquestion.Text), "\n\nSilme  İşleme Aşağıda Belirtilen Soru İçin Yapılsın mı?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) // Sime İşlemi İsteniyor
                {
                    ApptitudeQuestions appques = new ApptitudeQuestions();
                    appques.QuestionID = id;
                    appques.ApptitudeType = atype;
                    appques.Question = rchquestion.Text;
                    appques.Secenek1 = rcho1.Text;
                    appques.Secenek2 = rcho2.Text;
                    appques.Secenek3 = rcho3.Text;
                    appques.Secenek4 = rcho4.Text;
                    appques.Cevap = cmbanswer.Text;

                    int etk = Convert.ToInt32(appquesorm.Delete(appques));

                    if(etk>0) // Silme  İşlemi İsteniyor
                    {
                        MessageBox.Show(string.Format("{0} ID'li Soru Sistemden Silindi", id));
                        IslemKayit ik = new IslemKayit();
                        ik.NesneID = id;
                        ik.IslemForm = IslemForm.ApptitudeQuestion;
                        ik.IslemTipi = IslemTipi.Deleting;
                        ik.IslemTarihi = DateTime.Now;
                        ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                        ikorm.Insert(ik);
                        Loading();

                    }
                }
                else // Silme İşeleminden Vazgeçildi
                {
                    MessageBox.Show(string.Format("{0} ID'li Soru İçin Silme İşleminden Vazgeçildi", id));
                    Loading();
                }
            }
            else // Data Grid ten Seçim Yapılmamışsa
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Soruyu Aşağıdaki Listeden Seçiniz");
                Loading();

            }
        }
    }
}
