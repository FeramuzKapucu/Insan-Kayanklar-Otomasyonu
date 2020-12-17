using InsanKaynaklari.ORM.Entity;
using InsanKaynaklari.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    public partial class AddApptitudeTypes : Form
    {
        public AddApptitudeTypes()
        {
            InitializeComponent();
        }

        ApptitudeTypesORM atorm = new ApptitudeTypesORM();
        IslemKayitORM ikorm = new IslemKayitORM();
        
        private void Loading()  // Başlangıç ya da ekleme sonrası çağrılır.
        {
            dataGridView1.DataSource = atorm.Select();
            txtname.Clear();
            txtname.Focus();
        }

        private void ApptitudeTypes_Load(object sender, EventArgs e)
        {
            Loading();
        }

       

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                errorProvider1.SetError(txtname, "Lütfen Eklemek İstediğiniz Yeteneği Giriniz...");
            }
            else
            {
                errorProvider1.Clear();
                ApptitudeTypes aptyp = new ApptitudeTypes();
                aptyp.ApptitudeName= txtname.Text.ToUpper().Trim();


                int id = Convert.ToInt32(atorm.InsertScalar(aptyp));

                if(id>0)
                {
                    MessageBox.Show("Yeni Yetenek Eklemesi Başarıyla Tamamlandı");
                    IslemKayit ik = new IslemKayit();

                    ik.NesneID = id;
                    ik.IslemForm = IslemForm.ApptitudeType;
                    ik.IslemTipi = IslemTipi.Adding;
                    ik.IslemTarihi = DateTime.Now;
                    ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;
              
                    ikorm.Insert(ik);
                    Loading();
                }
                else
                {
                    MessageBox.Show("Aynı İsimde Birden Fazla Yetenek Eklemesi Yapılamaz.");
                    return;
                }
               
            }
        }
    }
   
}
