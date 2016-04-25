using System;
using System.Collections.Generic;

namespace Aviaco_V2.Models
{
    public partial class EMPLOYEE
    {
        public EMPLOYEE()
        {
            EARNEDRATING = new HashSet<EARNEDRATING>();
        }

        public int EMP_NUM { get; set; }
        public DateTime? EMP_DOB { get; set; }
        public string EMP_FNAME { get; set; }
        public DateTime? EMP_HIRE_DATE { get; set; }
        public string EMP_INITIAL { get; set; }
        public string EMP_LNAME { get; set; }
        public string EMP_TITLE { get; set; }

        public virtual ICollection<EARNEDRATING> EARNEDRATING { get; set; }
        public virtual PILOT PILOT { get; set; }
    }
}
