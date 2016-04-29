using System;
using System.Collections.Generic;

namespace AviaCo.Models
{
    public partial class CREW
    {
        public int crewID { get; set; }
        public int CHAR_TRIP { get; set; }
        public string CREW_JOB { get; set; }
        public int EMP_NUM { get; set; }

        public virtual CHARTER CHAR_TRIPNavigation { get; set; }
        public virtual EMPLOYEE EMP_NUMNavigation { get; set; }
    }
}
