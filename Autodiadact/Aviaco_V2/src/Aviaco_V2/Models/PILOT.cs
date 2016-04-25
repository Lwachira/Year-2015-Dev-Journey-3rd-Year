using System;
using System.Collections.Generic;

namespace Aviaco_V2.Models
{
    public partial class PILOT
    {
        public int EMP_NUM { get; set; }
        public string PIL_LICENSE { get; set; }
        public DateTime? PIL_MED_DATE { get; set; }
        public string PIL_MED_TYPE { get; set; }
        public DateTime? PIL_PT135_DATE { get; set; }
        public string PIL_RATINGS { get; set; }

        public virtual EMPLOYEE EMP_NUMNavigation { get; set; }
    }
}
