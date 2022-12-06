using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3s_QLThucTapSinhIntern.Data
{
    public class Report
    {
        public int ReportID { get; set; }
        public string NameReport { get; set; }
        public int MenterID { get; set; }
        public string NameMenter { get; set; }
        public int InternID { get; set; }
        public string NameIntern { get; set; }
        public string FinishWork { get; set; }
        public string UnfinishedWork { get; set; }
        public string CommentOfMenter { get; set; }
        public string FeedbackIntern { get; set; }
    }
}
