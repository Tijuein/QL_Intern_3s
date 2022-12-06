using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3s_QLThucTapSinhIntern.Data
{
    public class Intern
    {
        public int InternID { get; set; }
        public string NameIntern { get; set; }
        public bool Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public string Specialize { get; set; }
        public string Email { get; set; }
    }
}
