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
    public partial class AddApptitudeQuestion : Form
    {
        public AddApptitudeQuestion()
        {
            InitializeComponent();
        }
        ApptitudeTypesORM atypo = new ApptitudeTypesORM();
        ApptitudeQuestionsORM aquesorm = new ApptitudeQuestionsORM();
        IslemKayitORM ikorm = new IslemKayitORM();

        private void Loading()  //Yeni Ekleme sonrası textbox silme veri çekme
        {
            cmbtype.DataSource = atypo.Select();
            cmbtype.DisplayMember = "ApptitudeName";
            cmbtype.ValueMember = "ID";
            richTextBox1.Clear();
            rcho1.Clear();
            rcho2.Clear();
            rcho3.Clear();
            rcho4.Clear();
            cmbanswer.SelectedIndex = -1;
            cmbtype.SelectedIndex = -1;
        }
        private void AddApptitudeQuestion_Load(object sender, EventArgs e)
        {
            Loading();
           

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text != "") && (rcho1.Text != "") && (rcho2.Text != "") && (rcho3.Text != "") && (rcho4.Text != ""))
            {
                errorProvider1.Clear();
                if (cmbtype.SelectedIndex != -1)
                {
                    errorProvider1.Clear();
                    if (cmbanswer.SelectedIndex != -1)
                    {

                        errorProvider1.Clear();
                        ApptitudeQuestions appques = new ApptitudeQuestions();
                        appques.ApptitudeType = Convert.ToInt32(cmbtype.SelectedValue);
                        appques.Question = richTextBox1.Text;
                        appques.Secenek1 = rcho1.Text;
                        appques.Secenek2 = rcho2.Text;
                        appques.Secenek3 = rcho3.Text;
                        appques.Secenek4 = rcho4.Text;
                        appques.Cevap = cmbanswer.Text;

                        int id = Convert.ToInt32(aquesorm.InsertScalar(appques));

                        if (id > 0)
                        {
                            MessageBox.Show("Yeni Soru Eklemesi Başarıyla Tamamlandı");
                            Loading(); // textbox temzilemesi ve yeni ekleme için hazırlık
                            IslemKayit ik = new IslemKayit();

                            ik.NesneID = id;
                            ik.IslemForm = IslemForm.ApptitudeQuestion;
                            ik.IslemTipi = IslemTipi.Adding;
                            ik.IslemTarihi = DateTime.Now;
                            ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                            ikorm.Insert(ik);

                        }
                    }
                    else
                    {
                        errorProvider1.SetError(cmbanswer, "Lütfen Combobox tan Doğru Olan Cevabı Seçiniz.");
                    }
                }

                else
                {
                    errorProvider1.SetError(cmbtype, "Lütfen Girilecek Sorunun Tipini Seçiniz..");
                }

            }
            else
            {
                errorProvider1.SetError(richTextBox1, "Lütfen Uygun Bir Soru Yazınız");
                errorProvider1.SetError(rcho1, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(rcho2, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(rcho3, "Bu Alan Boş Geçilemez");
                errorProvider1.SetError(rcho4, "Bu Alan Boş Geçilemez");
            }
        }
    }
}
