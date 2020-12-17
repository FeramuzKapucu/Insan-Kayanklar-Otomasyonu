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
    public partial class ViewJobDetails : Form
    {
        public ViewJobDetails()
        {
            InitializeComponent();
        }
        int id;
        JobsORM jobsorm = new JobsORM();
        IslemKayitORM ikorm = new IslemKayitORM();
        private void Loading()  //Loading ve İşelmler sonrası çağrılan method
        {
            dataGridView1.DataSource = jobsorm.Select();
            txttitle.Clear();
            txtapplic.Clear();
            txtid.Clear();
            txtplace.Clear();
            txtreq.Clear();
            txtsalary.Clear();
            rchdesignation.Clear();
            id = 0;
        }
        private void ViewJobDetails_Load(object sender, EventArgs e)
        {
            Loading();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells["JID"].Value;

                SqlCommand cmd = new SqlCommand("Select * from Jobs where JID=@j1", Tools.Baglanti);
                cmd.Parameters.AddWithValue("@j1", id);

                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtid.Text = dr["JId"].ToString();
                    rchdesignation.Text = dr["Designation"].ToString();
                    txtsalary.Text = dr["Salary"].ToString();
                    txttitle.Text = dr["Title"].ToString();
                    txtplace.Text = dr["Place"].ToString();
                    txtreq.Text = dr["RequirementAdded"].ToString();
                    txtapplic.Text = dr["Applicable"].ToString();
                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen Listeden Uygun Bir Yere Tıklayınız");
                Loading();
            }
        }

        private void btnrmvreq_Click(object sender, EventArgs e)
        {
            if (id != 0) //Data Grid ten Seçim Yapılmamış
            {
                if (txtreq.Text == "True") // Seçilen İş İçin Requirement Kayıdı Var
                {
                    DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li İş İçin Sistemdeki Requirement Bilgileri Silinecektir\n\n Ayrıca İş Artık Başvurya Açık 'Applicable' Bir İş Olarak DEĞERLENDİRİLMEYECEK  ", id), "Bu İşlemi Onaylıyor musunuz", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes) //Requirement Kaldırma İşlemi Onaylandı
                    {
                        SqlCommand cmd = new SqlCommand("Update Jobs set RequirementAdded=0,Applicable=0 where JId=@j1", Tools.Baglanti);
                        cmd.Parameters.AddWithValue("@j1", id);

                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();
                        int result1 = cmd.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand("Delete from Requirements where JobID=@r1", Tools.Baglanti);
                        cmd2.Parameters.AddWithValue("@r1", id);

                        if (cmd2.Connection.State != ConnectionState.Open)
                            cmd2.Connection.Open();

                        int result2= cmd2.ExecuteNonQuery();

                        if(result1>0 && result2>0)
                        {
                            MessageBox.Show(string.Format("{0} ID'li İş İçin Requirment Sistemden Kaldırıldı ve İş Başvuruya Kapalı Bir Hale Geldi", id));
                            IslemKayit ik = new IslemKayit();
                            ik.NesneID = id;
                            ik.IslemForm = IslemForm.Requirement;
                            ik.IslemTipi = IslemTipi.Deleting;
                            ik.IslemTarihi = DateTime.Now;
                            ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                            ikorm.Insert(ik);
                            Loading();
                        }
                        else
                        {
                            MessageBox.Show("Requirement Silme Sırasında Bir Hata Meydana Geldi Lütfen Daha Sonra Tekrar Deneyiniz");
                            Loading();
                        }
                    }
                    else //Requirement Kaldrıma İşlemi İptal Edildi
                    {
                        MessageBox.Show(string.Format("{0} ID'li İş İçin Requirement Kaldırma İşlemi İptal Edildi", id));
                        Loading();

                    }

                }
                else // Seçilen İş İçin Sistemde Bir Requirement Kayıtlı Değil
                {
                    MessageBox.Show(string.Format("{0} ID'li İş İçin Requirement Ataması Yapılmamış\n\nRequirement Bilgilerini Kaldırmak İstediğiniz İşi Listeden Seçiniz", id));
                    Loading();
                }
            }
            else //Data Grid ten Seçim Yapılmamış
            {
                MessageBox.Show("Lütfen Aşağıdaki Listeden Uygun Bir Satır Seçiniz");
                Loading();
            }
        } // Requirement Kaldırma İşlemi Sonu

        private void btnrmvapplicable_Click(object sender, EventArgs e) //İş için requirement kydı olsun ama başvurulabilir olmasın
        {
            if(id!=0) // İş  Seçilmişse
            {
                if(txtreq.Text=="True") // Seçilen İş İçin Req Kayıdı var
                {
                    if(txtapplic.Text=="True") //Seçilen İş Applicable
                    {
                        DialogResult cevap = MessageBox.Show(string.Format("{0} ID li İş İçin Requirement Kaydı Silinmeyecek Ama İş Artık Başvurulabilir Olmayacak\n\nBu Durumu İsterseniz 'Do The Job Applicable' Butonuna Basarak Yeniden Düzenleyebilirsiniz", id), "Aşağıda Belirtilen İşlemi Onaylıyor musunuz?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if(cevap==DialogResult.Yes) //İşelemin Yapılması İsteniyor
                        {
                            SqlCommand cmd = new SqlCommand("Update Jobs set Applicable=0 where JId=@j1", Tools.Baglanti);
                            cmd.Parameters.AddWithValue("@j1", id);

                            if (cmd.Connection.State != ConnectionState.Open)
                                cmd.Connection.Open();
                            int result1 = cmd.ExecuteNonQuery();

                            if(result1>0) // İşlem Başarıyla Halledildi
                            {
                                MessageBox.Show(string.Format("{0} ID'li İş İçin Başvurulabilir Durumlardan Kaldırma İşlemi Başarıyla Oldu.\n\n İşlem Artık BAŞVURULABİLİR  DEĞiL", id));
                                IslemKayit ik = new IslemKayit();
                                ik.NesneID = id;
                                ik.IslemForm = IslemForm.Job;
                                ik.IslemTipi = IslemTipi.Updating;
                                ik.IslemTarihi = DateTime.Now;
                                ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                                ikorm.Insert(ik);
                                Loading();
                            }
                            else // İşlem Sırasında Bir Hata Oluştu
                            {
                                MessageBox.Show("İşlem Sırasında Bir Hata Oluştu Lütfen Daha Sonra Tekrar Deneyiniz");
                                Loading();
                            }
                        }
                        else // İşlemin Yapılması İstenmiyor
                        {
                            MessageBox.Show(string.Format("{0} ID'li İş Başvurulabilir Durumlardan Kaldırılma İşlemi İPTAL EDİLDİ", id));
                            Loading();
                        }

                    }
                  

                    else// İş Başvurulabilir DEğil
                    {
                        MessageBox.Show(string.Format("{0} ID'li İş Zaten Başvurulabilir Durumda Değil", id));
                        Loading();
                    }
                }
                else // Seçilen İş İçin req Kaydı yok
                {
                    MessageBox.Show(string.Format("{0} ID'li  İş İçin Requirement Kaydı Yoktur.Dolayısıyla İş Zaten Başvurulabilir DEĞİL",id));
                    Loading();
                }
            }

            else // İş seçilmemişse
            {
                MessageBox.Show("Lütfen Başvurulabilir Olamasını İstemediğiniz İşi Listeden Seçiniz");
                Loading();
            }
        }

        private void btndoapllicable_Click(object sender, EventArgs e) //Başvurulabilir Olmayan İşi Başvurulabilir Yapma
        {
            if(id!=0) //Listeden Seçim Yapılmış
            {
                if(txtreq.Text=="True")  // Seçilen İş İçin Reg Kaydı Var
                {
                    if (txtapplic.Text == "False") //Seçilen İş Applicable Değil
                    {
                        DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li İş Başvurulabilir Yapılsın mı ", id), "Aşağıda Belirtilen Update İşlemini Onaylıyor musunuz", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if(cevap==DialogResult.Yes) // İşlemin Yapılması İsteniyor
                        {
                            SqlCommand cmd = new SqlCommand("Update Jobs set Applicable=1 where JId=@j1", Tools.Baglanti);
                            cmd.Parameters.AddWithValue("@j1", id);

                            if (cmd.Connection.State != ConnectionState.Open)
                                cmd.Connection.Open();
                            int result1 = cmd.ExecuteNonQuery();

                            if(result1>0) // İşlem Başarıyla Gerçekleşti
                            {
                                MessageBox.Show(string.Format("{0} ID'li İş Başvurulabilir Duruma Getirildi", id));
                                IslemKayit ik = new IslemKayit();
                                ik.NesneID = id;
                                ik.IslemForm = IslemForm.Job;
                                ik.IslemTipi = IslemTipi.Updating;
                                ik.IslemTarihi = DateTime.Now;
                                ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                                ikorm.Insert(ik);
                                Loading();

                            }
                            else //İşlemin Gerçekleşmesi Sırasında Bir Hata Oluştu
                            {
                                MessageBox.Show(string.Format("{0} ID'li İşin Başvurulabilir Yapılması Sırasında Bir Hata Oluştu", id));
                                Loading();
                            }
                        }
                        else // işlemin Yapılmasında Vazgeilmiş
                        {
                            MessageBox.Show(string.Format("{0} ID'li İş İçin İşi 'Başvurulabilir Yapma' İşlemi İptal Edildi", id));
                            Loading();
                        }

                    }
                    else //Seçilen İş  Zaten Applicable 
                    {
                        MessageBox.Show(string.Format("{0} ID'li İş Zaten Başvurulablir Durumda", id));
                        Loading();
                    }
                }
                else // Seçilen İş İçin Reg Kaydı Yok
                {

                    MessageBox.Show(string.Format("{0} ID'li  İş İçin Requirement Kaydı Yoktur.Requirement Kaydı Olmayan İş Başvurulabilir YAPILAMAZ", id));
                    Loading();
                }
            }
            else //Listeden Seçim Yapılmamış
            {
                MessageBox.Show("Lütfen Başvurulabilir Olamasını İstediğiniz İşi Listeden Seçiniz");
                Loading();
            }
        }
    }
}
