using InsanKaynaklari.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    public partial class ViewCandidatesProfile : Form
    {
        public ViewCandidatesProfile()
        {
            InitializeComponent();
        }
        public int userid;
        int ks1, ks2, ks3;

        private void KeyskillToLabel(Label lb, int apid) //Keys Skilleri Label e taşıyan method
        {
            SqlCommand cmd2 = new SqlCommand("Select ApptitudeName from ApptitudeTypes where ID=@a1", Tools.Baglanti);
            cmd2.Parameters.AddWithValue("@a1", apid);

            if (cmd2.Connection.State != ConnectionState.Open)
                cmd2.Connection.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lb.Text = dr2["ApptitudeName"].ToString();
            }
            dr2.Close();
        }
        private void ViewCandidatesProfile_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select ID, Name,Experience, Surname, KeySkill1, KeySkill2, KeySkill3, Email, Picture,University,Ozet from Users U left join UserSkills S on U.ID=S.UserID where ID=@u1", Tools.Baglanti);
            cmd.Parameters.AddWithValue("@u1", userid);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                lblname.Text = dr["Name"].ToString();
                lblsurname.Text = dr["Surname"].ToString();
                ks1 = Convert.ToInt32(dr["KeySkill1"]);
                ks2 = Convert.ToInt32(dr["KeySkill2"]);
                ks3 = Convert.ToInt32(dr["KeySkill3"]);
                lblexp.Text = dr["Experience"].ToString();
                lblmail.Text = dr["EMail"].ToString();
                lbluni.Text = dr["University"].ToString();
                rchozet.Text = dr["Ozet"].ToString();

                byte[] resim = (byte[])dr["Picture"]; //Resim Çekmek için İşelemler
                MemoryStream ms = new MemoryStream(resim, 0, resim.Length);
                ms.Write(resim, 0, resim.Length);
                Image img = Image.FromStream(ms);
                pictureBox1.BackgroundImage = img;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            dr.Close();
            KeyskillToLabel(lblks1,ks1);
            KeyskillToLabel(lblks2,ks2);
            KeyskillToLabel(lblks3,ks3);
        }
    }
}
