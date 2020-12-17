using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari.ORM.Entity
{
    public class IslemKayit
    {
        public int IslemID { get; set; }
        public int NesneID { get; set; }
        public string IslemAdmin { get; set; }
        public IslemTipi IslemTipi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public IslemForm IslemForm { get; set; }

    }
    public enum IslemTipi
    {
        Adding = 1,
        Deleting = 2,
        Updating=3
    };
    public enum IslemForm
    {
        Admin = 1,
        ApptitudeQuestion = 2,
        ApptitudeType = 3,
        Job=4,
        KeySkill=5,
        PersonalityQuestion=6,
        Requirement=7
    };
}
