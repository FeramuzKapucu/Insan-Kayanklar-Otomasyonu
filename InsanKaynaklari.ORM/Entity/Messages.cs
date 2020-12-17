using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklari.ORM.Entity
{
    public class Messages
    {
        public int  MID { get; set; }
        public int UserID { get; set; }
        public int JobID { get; set; }
        public string Message { get; set; }
        public int Admin { get; set; }
        public DateTime Time { get; set; }
    }
}
