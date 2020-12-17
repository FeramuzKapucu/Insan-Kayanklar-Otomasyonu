using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari.ORM.Entity
{
   public class UserSkills
    {
        public int UserSkillID { get; set; }
        public int UserID { get; set; }
        public int KeySKill1 { get; set; }
        public int KeySKill2 { get; set; }
        public int KeySKill3 { get; set; }
        public bool Lisans { get; set; }
        public string University { get; set; }
        public string Ozet { get; set; }
        public double PersonalityTest { get; set; }
    }
}
