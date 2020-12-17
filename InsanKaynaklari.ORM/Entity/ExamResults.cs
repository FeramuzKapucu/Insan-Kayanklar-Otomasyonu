using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari.ORM.Entity
{
    public class ExamResults
    {
        public int EID { get; set; }
        public int UserID { get; set; }
        public int Keyskill { get; set; }
        public double Result { get; set; }
        public DateTime Date { get; set; }

    }
}
