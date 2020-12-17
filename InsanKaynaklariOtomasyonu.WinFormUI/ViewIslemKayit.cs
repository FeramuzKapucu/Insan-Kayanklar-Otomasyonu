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
    public partial class ViewIslemKayit : Form
    {
        public ViewIslemKayit()
        {
            InitializeComponent();
        }
        IslemKayitORM ikorm = new IslemKayitORM();
        
        private void ViewIslemKayit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ikorm.Select();

        }
    }
}
