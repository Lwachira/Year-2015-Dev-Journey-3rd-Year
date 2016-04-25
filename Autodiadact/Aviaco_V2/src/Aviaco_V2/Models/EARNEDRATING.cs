using System;
using System.Collections.Generic;

namespace Aviaco_V2.Models
{
    public partial class EARNEDRATING
    {
        public int EMP_NUM { get; set; }
        public string RTG_CODE { get; set; }
        public DateTime? EARNRTG_DATE { get; set; }

        public virtual EMPLOYEE EMP_NUMNavigation { get; set; }
        public virtual RATING RTG_CODENavigation { get; set; }
    }
}
