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
    public partial class ViewApplicationForJobs : Form
    {
        public ViewApplicationForJobs()
        {
            InitializeComponent();
        }
        int id;// İş İd'si tutulacak
        int userid;
        MessagesORM mesorm=new MessagesORM();

        private void Loading()
        {
            SqlDataAdapter adp2 = new SqlDataAdapter("Select Distinct JOBID from Applications", Tools.Baglanti); // Aynı iş için birden fazla başvuru olabilir.
            DataTable tbl2 = new DataTable();
            adp2.Fill(tbl2);
            cmbjobs.DataSource = tbl2;
            cmbjobs.DisplayMember = "JOBID";
            cmbjobs.ValueMember = "JOBID";
            cmbjobs.SelectedIndex = -1;
            id = 0;
            userid = 0;
        }
        private void ViewApplicationForJobs_Load(object sender, EventArgs e)
        {
            Loading();

        }

      

        private void cmbjobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbjobs.SelectedIndex!=-1) // Combobox 'tan Bir iş seçilmiş
            {
                bool lis = false;
               
                Int32.TryParse(cmbjobs.SelectedValue.ToString(), out id);
                SqlDataAdapter adp = new SqlDataAdapter("Select * from Applications where JobID=@a1", Tools.Baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@a1", id);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dataGridView1.DataSource = tbl;

                //Seçilen iş için bazı bilgiler gösterildi..
                SqlCommand cmd = new SqlCommand("Select JID,Title,Experience,ApptitudeName,Lisans from Jobs J left join Requirements R on J.JID=R.jobId left join ApptitudeTypes A on R.keyskill=A.ID  where JID=@j1", Tools.Baglanti);
                cmd.Parameters.AddWithValue("@j1", id);

                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    lbltitle.Text = dr["Title"].ToString();
                    lblexperince.Text = dr["Experience"].ToString();
                    lblkey.Text = dr["Apptitudename"].ToString();
                    lis =(bool)dr["Lisans"];

                    if (lis)
                        lbllis.Text = "Gerekli";
                    else
                        lbllis.Text = "Gerekli Değil";

                }

                dr.Close();
            }
            else //Başlangıçta selected index -1 ve hepsi gösterilecek
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * from Applications", Tools.Baglanti);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
       
        }

        private void btnlistall_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Applications", Tools.Baglanti);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dataGridView1.DataSource = tbl;
            cmbjobs.SelectedIndex = -1;
            id = 0;
            lbllis.Text = "";
            lblkey.Text = "";
            lbltitle.Text = "";
            lblexperince.Text = "";
        }

        private void sortperso_Click(object sender, EventArgs e) //Personlity Point e Göre Sıralama
        {
            if(id!=0)  // Filtre Uygulanmadıysa
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * from Applications where JobId=@a1 order by PersonalityPoint desc ", Tools.Baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@a1", id);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("Lütfen Sıralama Yapmak İstediğiniz Başvuru İçin Filtre Uygylayınız");
            }
        }

        private void sortrequi_Click(object sender, EventArgs e) // Requirement Point e Göre Sıralama
        {
            if (id != 0)   // Filtre Uygulanmadıysa
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * from Applications where JobId=@a1 order by RequirementPoint desc ", Tools.Baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@a1", id);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("Lütfen Sıralama Yapmak İstediğiniz Başvuru İçin Filtre Uygylayınız");
            }
        }

        private void sortskill_Click(object sender, EventArgs e) // Skill Pointe Göre 
        {
            if (id != 0)   // Filtre Uygulanmadıysa
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * from Applications where JobId=@a1 order by SkillPoint desc ", Tools.Baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@a1", id);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("Lütfen Sıralama Yapmak İstediğiniz Başvuru İçin Filtre Uygylayınız");
            }
        }

        private void viewUsersProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(id!=0)
            {
                try
                {
                    userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["userID"].Value);
                    DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li Kullanıcının Profilini Görüntülemek mi İstiyorsunuz?\n\nEvet'e tıklayın veya  İptal/Hayır Seçeneklerinden Birine Tıklayıp Başka Bir Kullanıcı Seçiniz.", userid), "User Profilini Görüntüleme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        ViewCandidatesProfile vicanpr = new ViewCandidatesProfile();
                        vicanpr.userid = userid;
                        vicanpr.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Görüntüleme İşlemi İptal Edildi");
                        userid = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Görüntülemek İstediğiniz Kullanıcının Bulunduğu Satırı Seçiniz");
                }
                
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Lütfen Önce İşleri 'Filter Jobs by JobID ' Bölümünden Filtreleyiniz ");
            } 
        }

        private void sendMessageToUserForThisJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                try
                {
                    userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["userID"].Value);
                    DialogResult cevap = MessageBox.Show(string.Format("{0} ID'li İş İçin {1} ID'li Kullanıcıya 'Tebrikler Başvurnuzu İlk Aşaması Olumlu Bir Şekilde Sonuçlandı İleriki Aşamalar İçin Bilgilendirilecekciniz'  Mesajı Gönderilsin mi\n\nEvet'e tıklayın veya  İptal/Hayır Seçeneklerinden Birine Tıklayıp Mesaj Gönderme İşleminden Vazgeçebilirisiniz.",id, userid), "Mesaj Gönderme Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        InsanKaynaklari.ORM.Entity.Messages msg = new InsanKaynaklari.ORM.Entity.Messages();
                        msg.UserID = userid;
                        msg.JobID = id;
                        msg.Message = string.Format("Tebrikler {0} ID'li İş Başvurunuzun İlk Aşaması Olumlu Bir Şekilde Sonuçlandı İleriki Aşamalar İçin Bilgilendirilecekciniz",id);
                        msg.Admin = AdminlerORM.AktifAdmin.AdminID;
                        msg.Time = DateTime.Now;
                       int etk=Convert.ToInt32(mesorm.Insert(msg));

                        if(etk>0) // Mesaj Başarılı Bir Şekilde Gönderildi.
                        {
                            MessageBox.Show(string.Format("{0} ID'li İş İçin {1} ID'li Kullanıcıya Mesaj Başarılı Bir Şekilde Gönderildirdi", id, userid));
                            Loading();
                            
                        }
                        else //Mesaj Gönderimi sırasında Bir Hata Oluştu
                        {
                            MessageBox.Show("Mesaj Gönderimi Sırasında Bir Hata Oluştu");
                            Loading();
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("Mesaj Gönderme  İşlemi İptal Edildi");
                        userid = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Mesaj Göndermek  İstediğiniz Kullanıcının Bulunduğu Satırı Seçiniz");
                }

            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Lütfen Önce İşleri 'Filter Jobs by JobID ' Bölümünden Filtreleyiniz ");
            }
        }
    }
}
