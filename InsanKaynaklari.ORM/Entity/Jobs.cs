using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari.ORM.Entity
{
    public class Jobs
    {
        public Jobs()
        {
            Applicable = false;
            RequirementAdded = false;
        }

        public int JID { get; set; }
        public string title { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public string Place { get; set; }
        public bool RequirementAdded { get; set; }
        public bool Applicable { get; set; }

    }
  
         
}
