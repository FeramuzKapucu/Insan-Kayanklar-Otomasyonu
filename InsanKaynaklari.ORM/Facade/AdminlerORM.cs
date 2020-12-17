using InsanKaynaklari.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InsanKaynaklari.ORM.Facade
{
    public class AdminlerORM : ORMBase<Adminler>
    {
        // İşlemleri Yapan Aktif Admin Belirli Olsun Diye Kullanılacak
        public static Adminler AktifAdmin;

        public Adminler Girisyap(Adminler a)
        //İçerisinde Adminler tipinden değer alan bir fonskiyon sql de select yapıyor eğer gönderilen veri tabanında kayıtlı değilse null kayıtlı ise aktif admin olarak o değer döndürülüyor. 
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Admin_Giris", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@ka", a.UserName);
            adp.SelectCommand.Parameters.AddWithValue("@prl", a.Password);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            Adminler aktif = new Adminler();
            foreach (DataRow dr in dt.Rows)
            {
                aktif.AdminID = (int)dr["AdminID"];
                aktif.UserName = dr["UserName"].ToString();
                aktif.Password = dr["Password"].ToString();
            }

            return aktif;
        }

    }
}
