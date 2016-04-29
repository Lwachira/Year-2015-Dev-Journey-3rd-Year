using System;
using System.Collections.Generic;

namespace AviaCo.Models
{
    public partial class CHARTER
    {
        public CHARTER()
        {
            CREW = new HashSet<CREW>();
        }

        public int CHAR_TRIP { get; set; }
        public string AC_NUMBER { get; set; }
        public DateTime? CHAR_DATE { get; set; }
        public string CHAR_DESTINATION { get; set; }
        public int? CHAR_DISTANCE { get; set; }
        public decimal? CHAR_FUEL_GALLONS { get; set; }
        public decimal? CHAR_HOURS_FLOWN { get; set; }
        public decimal? CHAR_HOURS_WAIT { get; set; }
        public int? CHAR_OIL_QTS { get; set; }
        public int CUS_CODE { get; set; }

        public virtual ICollection<CREW> CREW { get; set; }
        public virtual AIRCRAFT AC_NUMBERNavigation { get; set; }
        public virtual CUSTOMER CUS_CODENavigation { get; set; }
    }
}
