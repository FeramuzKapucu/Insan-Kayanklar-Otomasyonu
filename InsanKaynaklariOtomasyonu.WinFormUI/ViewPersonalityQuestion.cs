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
    public partial class ViewPersonalityQuestion : Form
    {
        public ViewPersonalityQuestion()
        {
            InitializeComponent();
        }

        int id = 0;
        string sorutip;

        IslemKayitORM ikorm = new IslemKayitORM();
        PersonalityQuestionsORM perquesorm = new PersonalityQuestionsORM();
        private void Loading() //Form Yüklemesi Silme Ve Update İşlemleri Sonrası
        {
            dataGridView1.DataSource = perquesorm.Select();
            rchperques.Clear();
            rdbolumlu.Checked = false;
            rdbolumsuz.Checked = false;
            id = 0;
        }

       
        private void ViewPersonalityQuestion_Load(object sender, EventArgs e)
        {
            Loading();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //Tıklanan soru textbox a ve radio butona taşınır
        {
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells["PersonalityQID"].Value;
                SqlCommand cmd = new SqlCommand("select* from PersonalityQuestions where PersonalityQID=@p1 ", Tools.Baglanti);
                cmd.Parameters.AddWithValue("@p1", id);

                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rchperques.Text = dr["Question"].ToString();
                    if (Convert.ToInt16(dr["SoruTipi"]) == 1) //Veri Tabanındaki kayıda göre yapılan bir sorgu.
                    {
                        rdbolumlu.Checked = true;
                    }
                    else
                    {
                        rdbolumsuz.Checked = true;
                    }

                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen Listeden Uygun Bir Yere Tıklayınız");
                Loading();
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            PersonalityQuestions perques = new PersonalityQuestions();
            perques.PersonalityQID = id;
            perques.Question = rchperques.Text;
            if (id!=0) //Data Grid'ten Seçim Yapılmış
            {
                if(rchperques.Text!="")  //Textbox dolu 
                {
                    if((rdbolumsuz.Checked==true) || (rdbolumlu.Checked==true)) // Radio Buton Sçeilmiş
                    {
                        if(rdbolumlu.Checked==true)
                        {
                            sorutip = "OLUMLU";
                            perques.Sorutipi = SoruTipi.OLUMLU;
                        }
                        else
                        {
                            sorutip = "OLUMSUZ";
                            perques.Sorutipi = SoruTipi.OLUMSUZ;
                        }

                        DialogResult cevap = MessageBox.Show(string.Format("{0} ID li Soru İçin\n\n Question ---{1}\n Soru Tipi ---{2}",id,rchperques.Text,sorutip), "\n\nGüncelleme İşleme Yukarıda Belirtildiği Gibi Yapılsın mı?", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

                        if(cevap==DialogResult.Yes) //Güncelleme Yapılmak İsteniyor
                        {

                            int etk =Convert.ToInt32(perquesorm.Update(perques));

                            if(etk>0) //Güncelleme Başarıyla Tamamlandı
                            {
                                MessageBox.Show(string.Format("{0} ID 'li Soru Başarıyla Güncellendi", id));
                                IslemKayit ik = new IslemKayit();
                                ik.NesneID = id;
                                ik.IslemForm = IslemForm.PersonalityQuestion;
                                ik.IslemTipi = IslemTipi.Updating;
                                ik.IslemTarihi = DateTime.Now;
                                ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                                ikorm.Insert(ik);
                                Loading();
                            }
                            else //Güncelleme Sırasında Bir Hata Oluştu
                            {
                                MessageBox.Show("Güncelleme Sırasında Bir Hata Oluştu Lütfen Daha Sonra Tekrar Deneyiniz.");
                                Loading();
                            }
                        }
                        else //Kullanıcı Güncelleme İşelminde Vazgeçti
                        {
                            MessageBox.Show("Güncelleme İşlemi İptal Edildi");
                            Loading();
                        }

                    }
                    else //Radio Buton Seçilmemiş
                    {
                        MessageBox.Show("Lütfen Güncelleme Yapmak İçin Radio Butonlardan Uygun Gördüğünüz Bir Tanesini Seçiniz");
                    }

                }
                else //TextBox a bir şey yazılmamis
                {
                    MessageBox.Show(string.Format("Lütfen {0} Id'li Soru İçin Üsteki Alana Soruyu Yazınız", id));
                }
            }
            else //DataGridten Seçim Yapılmamış
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Soruya Aşagıdaki Listeden Tıklayınız");
            }
        }  //Update Buton Sonu

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(id!=0) //Data Grid 'ten Seçim Yapılmış
            {
                DialogResult cevap = MessageBox.Show(string.Format("{0} ID li Soru ('{1}' )Silinsin mi", id,rchperques.Text), "\n\nSilme  İşleme Aşağıda Belirtilen Soru İçin Yapılsın mı?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes) //Silme Yapılmak İsteniyor
                {
                    PersonalityQuestions perques = new PersonalityQuestions();
                    perques.PersonalityQID = id;
                    perques.Question = rchperques.Text;
                    if (rdbolumlu.Checked == true)
                    {
                        sorutip = "OLUMLU";
                        perques.Sorutipi = SoruTipi.OLUMLU;
                    }
                    else
                    {
                        sorutip = "OLUMSUZ";
                        perques.Sorutipi = SoruTipi.OLUMSUZ;
                    }

                    int etk =Convert.ToInt32(perquesorm.Delete(perques));
                    if (etk > 0) //Silme Başarıyla Tamamlandı
                    {
                        MessageBox.Show(string.Format("{0} ID 'li Soru Sistemden  Silindi", id));
                        IslemKayit ik = new IslemKayit();
                        ik.NesneID = id;
                        ik.IslemForm = IslemForm.PersonalityQuestion;
                        ik.IslemTipi = IslemTipi.Deleting;
                        ik.IslemTarihi = DateTime.Now;
                        ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                        ikorm.Insert(ik);
                        Loading();
                    }
                    else //Silme Sırasında Bir Hata Oluştu
                    {
                        MessageBox.Show("Silme Sırasında Bir Hata Oluştu Lütfen Daha Sonra Tekrar Deneyiniz.");
                        Loading();
                    }
                }

                else //Kullanıcı Silme İşleminden Vazgeçti
                {
                    MessageBox.Show("Silme İşleminden Vazgeçildi");
                    Loading();
                }

            }
            else //Data Grid 'ten Seçim Yapılmamış
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Soruyu Aşağıdaki Listeden Seçiniz");
            }
        }
    }
}
