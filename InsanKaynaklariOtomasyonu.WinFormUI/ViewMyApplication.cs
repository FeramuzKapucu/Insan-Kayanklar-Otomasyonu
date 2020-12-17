using InsanKaynaklari.ORM;
using InsanKaynaklari.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    public partial class ViewMyApplication : Form
    {
        public ViewMyApplication()
        {
            InitializeComponent();
        }

        private void ViewMyApplication_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Applications where UserId=@u1", Tools.Baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@u1", UsersORM.AktifUser.ID);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dataGridView1.DataSource = tbl;
            
        }
    }
}
