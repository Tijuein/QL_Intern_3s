using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3s_QLThucTapSinhIntern.Data
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string NameProject { get; set; }
        public int MenterID { get; set; }
        public int InternID { get; set; }
        public DateTime? Datetime_Start { get; set; }
        public DateTime? Datetime_End { get; set; }
        public bool Projectprogress { get; set; }
    }
}
