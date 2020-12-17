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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }


        AdminlerORM aorm = new AdminlerORM();
        IslemKayitORM ikorm = new IslemKayitORM();

        private void Loading()  // Yeni Admin ekleme ya da form loadında çalışır. 
        {
            dataGridView1.DataSource = aorm.Select();
            dataGridView1.Columns["Password"].Visible = false;
            txtname.Clear();
            txtpassword.Clear();
            txtname.Focus();
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
            Loading();

        }

       

        private void btnekle_Click(object sender, EventArgs e)
        {
            if((txtname.Text=="")&&(txtpassword.Text==""))
            {
                errorProvider1.SetError(txtname, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(txtpassword, "Bu AlanBoş Geçilemez");
            }
            else
            {
                // Yeni admin ekleme işlemi
                Adminler admin = new Adminler();
                admin.UserName = txtname.Text;
                admin.Password = txtpassword.Text;

                int id = Convert.ToInt32(aorm.InsertScalar(admin));



                // Ekleme işleminin işlem kayıdına eklenmesi
                IslemKayit ik = new IslemKayit();
                ik.NesneID = id;
                ik.IslemTipi = IslemTipi.Adding;
                ik.IslemForm = IslemForm.Admin;
                ik.IslemTarihi = DateTime.Now;
                ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                ikorm.Insert(ik);

                MessageBox.Show("Bir Yeni Admin Eklendi");
                Loading();
            }
           
        }
    }
}
