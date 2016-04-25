using System;
using System.Collections.Generic;

namespace Aviaco_V2.Models
{
    public partial class AIRCRAFT
    {
        public AIRCRAFT()
        {
            CHARTER = new HashSet<CHARTER>();
        }

        public string AC_NUMBER { get; set; }
        public decimal? AC_TTAF { get; set; }
        public decimal? AC_TTEL { get; set; }
        public decimal? AC_TTER { get; set; }
        public string MOD_CODE { get; set; }

        public virtual ICollection<CHARTER> CHARTER { get; set; }
        public virtual MODEL MOD_CODENavigation { get; set; }
    }
}
