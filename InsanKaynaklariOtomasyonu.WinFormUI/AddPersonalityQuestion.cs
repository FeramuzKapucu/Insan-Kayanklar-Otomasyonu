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
    public partial class AddPersonalityQuestion : Form
    {
        public AddPersonalityQuestion()
        {
            InitializeComponent();
        }
        PersonalityQuestionsORM perqorm = new PersonalityQuestionsORM();
        IslemKayitORM ikorm = new IslemKayitORM();

        private void Loading() // Form Yüklemesi ve Soru Eklemesi Sonrası İşlemler
        {
            richTextBox1.Text = "'Personality Question' kısmı için adaylara sorulan soruların cevaplarının doğru değerlendirilmesi adına sorduğunuz sorunun (Hayır,Nötr,Kısmen,Evet) gibi bir cevaplamada 'Evet' şeklinde cevaplanması bekleniyorsa Radio Butonlardan 'OLUMLU' yazanı aksi durumda ise 'OLUMSUZ' yazanı işaretlemeyi UNUTMAYIN!!!";

            rchquestion.Clear();
            rchquestion.Focus();
            rdbolumlu.Checked = false;
            rdbolumsuz.Checked = false;
        }

        private void AddPersonalityQuestion_Load(object sender, EventArgs e)
        {
            Loading(); 

        }

      

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (rchquestion.Text != "")
            {
                errorProvider1.Clear();
                if ((rdbolumlu.Checked == true) || (rdbolumsuz.Checked == true))
                {
                    errorProvider1.Clear();

                    PersonalityQuestions perquest = new PersonalityQuestions();
                    perquest.Question = rchquestion.Text;

                    if (rdbolumlu.Checked) //Radio butonlardan hangisi işaretlenmişse
                        perquest.Sorutipi = SoruTipi.OLUMLU;
                    else
                        perquest.Sorutipi = SoruTipi.OLUMSUZ;

                    int id =Convert.ToInt32(perqorm.InsertScalar(perquest));
                    if (id > 0)
                    {
                        MessageBox.Show("Yeni Soru Eklemesi Başarıyla Tamamlandı");
                        Loading(); // textbox temzilemesi ve yeni ekleme için hazırlık
                        IslemKayit ik = new IslemKayit();

                        ik.NesneID = id;
                        ik.IslemForm = IslemForm.PersonalityQuestion;
                        ik.IslemTipi = IslemTipi.Adding;
                        ik.IslemTarihi = DateTime.Now;
                        ik.IslemAdmin = AdminlerORM.AktifAdmin.UserName;

                        ikorm.Insert(ik);

                    }
                }
                else
                {
                    errorProvider1.SetError(rdbolumlu, "Lütfen Radio ButonLardan Birini Seçiniz.");
                    errorProvider1.SetError(rdbolumsuz, "Lütfen Radio Butonlardan Birini Seçiniz.");

                }
            }
            else
            {
                errorProvider1.SetError(rchquestion, "Lütfen Eklemek İstediğiniz Soruyu Giriniz...");
            }
        }
    }
}
