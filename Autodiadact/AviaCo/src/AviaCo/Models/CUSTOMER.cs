using System;
using System.Collections.Generic;

namespace AviaCo.Models
{
    public partial class CUSTOMER
    {
        public CUSTOMER()
        {
            CHARTER = new HashSet<CHARTER>();
        }

        public int CUS_CODE { get; set; }
        public string CUS_AREACODE { get; set; }
        public decimal? CUS_BALANCE { get; set; }
        public string CUS_FNAME { get; set; }
        public string CUS_INITIAL { get; set; }
        public string CUS_LNAME { get; set; }
        public string CUS_PHONE { get; set; }

        public virtual ICollection<CHARTER> CHARTER { get; set; }
    }
}
