using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari.ORM.Entity
{
    public class Applications
    {
        public int AID { get; set; }
        public int UserID { get; set; }
        public int JobID { get; set; }
        public double PersonalityPoint { get; set; }
        public double RequirementPoint { get; set; }
        public double SkillPoint { get; set; }
        public DateTime Time { get; set; }

    }
}
