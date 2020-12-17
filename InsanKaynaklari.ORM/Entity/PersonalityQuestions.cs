using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari.ORM.Entity
{
    public class PersonalityQuestions
    {
        public int PersonalityQID { get; set; }
        public string Question { get; set; }
        public SoruTipi Sorutipi { get; set; }
    }

    public enum SoruTipi
    {
        OLUMLU = 1,
        OLUMSUZ = 2
    };
}
