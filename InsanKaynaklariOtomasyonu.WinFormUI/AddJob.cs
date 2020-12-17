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
    public partial class AddJob : Form
    {
        public AddJob()
        {
            InitializeComponent();
        }
        int sonuc = 0;
        IslemKayitORM ikorm = new IslemKayitORM();
        JobsORM jorm = new JobsORM();
        private void Loading() // Kayıt ya da yükleme ekranı için çağrılacak fonksiyon
        {
            txtid.Focus();
            SqlCommand cmd = new SqlCommand("prc_JobsMAXID_Select",Tools.Baglanti);// En yüksek id li job un jobid isni çekiyor.
            cmd.CommandType = CommandType.StoredProcedure;
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader(); // veri tabanından okuma işlemi

            while (dr.Read())
            {
                string sonuc1= dr["JID"].ToString();
                bool deneme = Int32.TryParse(sonuc1, out sonuc);

            }
            if (cmd.Connection.State != ConnectionState.Closed)
                cmd.Connection.Close();
            sonuc += 1; // sonuç a 1 ekleniyor.(Bir sonraki iş ekleme işleminden dolayısıyla en yüksek id nin bir fazlası veri tabanında kaydedilir.
            txtid.Text = sonuc.ToString(); // Eklenenecek id txtid ye yazılır.

            txttitle.Clear();
            txtplace.Clear();
            rchdesignation.Clear();
            nudsalary.Value = 1000;
        }
        private void AddJob_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if(txttitle.Text!="") // Title Girilmiş
            {
                errorProvider1.Clear();
                if(rchdesignation.Text!="") //Designation Girilmiş
                {
                    errorProvider1.Clear();

                    if (txtplace.Text != "")  // Place Girilmiş
                    {
                        errorProvider1.Clear();

                     DialogResult cevap=MessageBox.Show(string.Format("Title --- {0}\nDesignation ---- {1}\n Salary  ---- {2}\nPlace --- {3}\n\nKayıdı Onaylıyor musunuz??", txttitle.Text, rchdesignation.Text, nudsalary.Value, txtplace.Text), "Kayıt Onaylansın mı",  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if(cevap==DialogResult.Yes) //Kullanıcı Kayıdı yapmak istiyor.
                        {
                            Jobs jobs = new Jobs();
                            jobs.JID =Convert.ToInt32(txtid.Text);
                            jobs.title = txttitle.Text.Trim();
                            jobs.Designation = rchdesignation.Text.Trim();
                            jobs.Place = txtplace.Text.Trim().ToUpper() ;
                            jobs.Salary =Convert.ToDouble(nudsalary.Value);

                            int id =Convert.ToInt32(jorm.InsertScalar(jobs));
                            if(id>0)
                            {
                                MessageBox.Show("Yeni İş Kaydı Başarı İle Tamamlandı.");
                                Loading(); // textbox temzilemesi ve yeni ekleme için hazırlık
                                IslemKayit ik = new IslemKayit();

                                ik.NesneID = id;
                                ik.IslemForm = IslemForm.Job;
                                ik.IslemTipi = IslemTipi.Adding;
                                ik.IslemTarihi = DateTime.Now;
                                ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                                ikorm.Insert(ik);
                            }

                            else
                            {
                                MessageBox.Show("İş Kaydı Sırasında Bir Hata Oldu.");
                            }
                        }
                        else //Kullanıcı Kayıdı yapmak istemiyor.
                        {
                            MessageBox.Show("Yeni İş Kaydı Yapılmadı");
                        }

                    }
                    else
                    {
                        errorProvider1.SetError(txtplace, "Lütfen Eklenecek İş İçin Bir Şehir Giriniz.");
                    }
                }
                else
                {
                    errorProvider1.SetError(rchdesignation, "Lütfen Eklenecek İş İçin Bir Açıklama Giriniz.");
                
                }
            }
            else
            {
                errorProvider1.SetError(txttitle, "Lütfen Eklenecek İş İçin Bir Ünvan Giriniz");
            }
        }
    }
}

