using System;
using System.Collections.Generic;

namespace AviaCo.Models
{
    public partial class RATING
    {
        public RATING()
        {
            EARNEDRATING = new HashSet<EARNEDRATING>();
        }

        public string RTG_CODE { get; set; }
        public string RTG_NAME { get; set; }

        public virtual ICollection<EARNEDRATING> EARNEDRATING { get; set; }
    }
}
