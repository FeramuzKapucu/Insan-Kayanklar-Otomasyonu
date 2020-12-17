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
    public class UsersORM:ORMBase<Users>
    {
        // İşlemleri Yapan Aktif User Belirli Olsun Diye Kullanılacak
        public static Users AktifUser;

        public Users Girisyap(Users u)
        //İçerisinde Users tipinden değer alan bir fonskiyon sql de select yapıyor eğer gönderilen veri tabanında kayıtlı değilse null kayıtlı ise aktif admin olarak o değer döndürülüyor. 
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Users_Giris", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@umail", u.Email);
            adp.SelectCommand.Parameters.AddWithValue("@prl", u.Password);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            Users aktif = new Users();
            foreach (DataRow dr in dt.Rows)
            {
                aktif.ID= (int)dr["ID"];
                aktif.Name = dr["Name"].ToString();
                aktif.Surname = dr["Surname"].ToString();
                aktif.Password = dr["Password"].ToString();
            }

            return aktif;
        }
    }
}
