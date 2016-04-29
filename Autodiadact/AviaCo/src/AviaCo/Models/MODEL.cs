using System;
using System.Collections.Generic;

namespace AviaCo.Models
{
    public partial class MODEL
    {
        public MODEL()
        {
            AIRCRAFT = new HashSet<AIRCRAFT>();
        }

        public string MOD_CODE { get; set; }
        public decimal? MOD_CHG_MILE { get; set; }
        public string MOD_MANUFACTURER { get; set; }
        public string MOD_NAME { get; set; }
        public int? MOD_SEATS { get; set; }

        public virtual ICollection<AIRCRAFT> AIRCRAFT { get; set; }
    }
}
