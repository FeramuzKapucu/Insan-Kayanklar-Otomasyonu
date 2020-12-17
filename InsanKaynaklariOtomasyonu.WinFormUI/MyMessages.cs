using InsanKaynaklari.ORM;
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
    public partial class MyMessages : Form
    {
        public MyMessages()
        {
            InitializeComponent();
        }

        private void Messages_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Messages where UserID=@m1", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@m1", UsersORM.AktifUser.ID);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }
    }
}
