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
    public partial class AddJobRequirement : Form
    {
        public AddJobRequirement()
        {
            InitializeComponent();
        }
        ApptitudeTypesORM apptyporm = new ApptitudeTypesORM();
        RequirementORM rqorm = new RequirementORM();
        IslemKayitORM ikorm = new IslemKayitORM();

        private void Loading()
        {
            // daha öndecedn requirement eklemesi yapılanlar gösterilmeyecek
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Jobs where RequirementAdded=0 ", Tools.Baglanti);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            cmbid.DataSource = tbl;
            cmbid.DisplayMember = "JId";
            cmbid.ValueMember = "JId";

            //Combobox a skiller taşınır
            cmbkeyskill.DataSource = apptyporm.Select();
            cmbkeyskill.DisplayMember = "ApptitudeName";
            cmbkeyskill.ValueMember = "ID";

            nudexperince.Value = 0;
            rdbgerekli.Checked = false;
            rdbgereklidegil.Checked = false;
        }

        private void AddJobRequirement_Load(object sender, EventArgs e)

        {
            Loading();
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                SqlCommand cmd = new SqlCommand("Select * from Jobs where JId=@j1", Tools.Baglanti);
                int id = 0;  //Try parse metodu dönüşüm yapamazsa hatta olmaması için default değer ataması
                bool sonuc = Int32.TryParse(cmbid.Text, out id); // Try Parse bir bool döndüren metod dödürmeyi yapabilirse true döndürüyor ve "out" la aldığı int parametreye atamayı yapıyor.
                cmbid.Tag = id;// id değerine daha sonra ulaşabilmek için
                cmd.Parameters.AddWithValue("@j1", id);
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();  // selected index değişince data reader ile okuma ve labellere yazma işlemi
                while (dr.Read())
                {
                    lbltitle.Text = dr["Title"].ToString();
                    rchdesignation.Text = dr["Designation"].ToString();
                    lblsalary.Text = dr["Salary"].ToString();
                    lblplace.Text = dr["Place"].ToString();
                }
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if ((rdbgerekli.Checked == true) || (rdbgereklidegil.Checked == true))
            {
                int id = (int)cmbid.Tag;
                string lisans; //Mesag Box ile soru sorarken lazım
                bool lisans1; //Veri tabanına kayıt yaparken lazım
                if (rdbgerekli.Checked)
                {
                    lisans = "Gerekli";
                    lisans1 = true;
                }
                else
                {
                    lisans = "Gerekli Değil";
                    lisans1 = false;
                }

                DialogResult cevap = MessageBox.Show(string.Format("ID :{0}'/'{1} İşi İçin \n\nExperience ---- {2}\nKeySkill  ---- {3}\nLisans Durum --- {4}\n\nRequirement Eklensin mi??", id, lbltitle.Text, nudexperince.Value, cmbkeyskill.Text, lisans), "Kayıt Onaylansın mı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)//Kullanıcı Req Kayıdı Yaptırmak İstiyor
                {
                    Requirements req = new Requirements();
                    req.JobID = id;
                    req.Experience = Convert.ToInt32(nudexperince.Value);
                    req.KeySkill = (int)cmbkeyskill.SelectedValue;
                    req.Lisans = lisans1;

                    int result = Convert.ToInt32(rqorm.InsertScalar(req));
                    if (result > 0) //Kayıt Başarılı Şekilde Eklendi
                    {
                        MessageBox.Show(string.Format("{0} Id'li İş İçin Requirement Eklemesi Başarılı Bir Şekilde Yapıldı", id));

                        // Jobs Tablosundaki Ekleme Yapılan Job Güncellendi Beöylelikle Requirement Ekleme Ekranına Aynı Job Gelmeyecek ve Ayrıca Requirement Eklenen İş Otomatik olarak Başvurulabilir HAle Getirildi
                        SqlCommand cmd = new SqlCommand("Update Jobs set RequirementAdded=1,Applicable=1 where JId=@j1", Tools.Baglanti);
                        cmd.Parameters.AddWithValue("@j1", id);

                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();
                        int result2 = cmd.ExecuteNonQuery();
                        
                        IslemKayit ik = new IslemKayit();

                        ik.NesneID = result;
                        ik.IslemForm = IslemForm.Requirement;
                        ik.IslemTipi = IslemTipi.Adding;
                        ik.IslemTarihi = DateTime.Now;
                        ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                        ikorm.Insert(ik);
                        Loading();
                    }
                    else
                    {
                        MessageBox.Show("Requirement Eklemesi Sırasın Bir Hata Oluştu Lütfen Daha Sonra Tekrar Deneyiniz.");
                        Loading();
                    }



                }
                else //Kullanıcı Req Kayıdından Vazgeçti 
                {

                }
            }
            else
            {
                MessageBox.Show("Lütfen Eklemek İstenilen Kritere Göre Radio Butonlardan Birini Seçiniz.");
            }
        }
    }
}
