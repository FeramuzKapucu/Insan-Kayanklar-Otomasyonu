using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari.ORM.Entity
{
    public class ApptitudeQuestions
    {
        public int QuestionID { get; set; }
        public int ApptitudeType { get; set; }
        public string Question { get; set; }
        public string Secenek1 { get; set; }
        public string Secenek2 { get; set; }
        public string Secenek3 { get; set; }
        public string Secenek4 { get; set; }
        public string Cevap { get; set; }

    }
}
