using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AviaCo.Models
{
    public partial class CHARTER
    {
        public CHARTER()
        {
            CREW = new HashSet<CREW>();
        }

        [Display(Name ="Charter Trip")]
        public int CHAR_TRIP { get; set; }
        [Display(Name = "Air Craft Number")]

        public string AC_NUMBER { get; set; }
        [Display(Name = "Charter Date")]

        public DateTime? CHAR_DATE { get; set; }
        [Display(Name = "Charter Destination")]

        public string CHAR_DESTINATION { get; set; }
        [Display(Name = "Charter Distance")]

        public int? CHAR_DISTANCE { get; set; }
        [Display(Name = "Charter Fuel Gallons")]

        public decimal? CHAR_FUEL_GALLONS { get; set; }
        [Display(Name = "Charter Hours Flown")]

        public decimal? CHAR_HOURS_FLOWN { get; set; }
        [Display(Name = "Charter Hours Wait")]

        public decimal? CHAR_HOURS_WAIT { get; set; }
        [Display(Name = "Charter Oil Quantity")]

        public int? CHAR_OIL_QTS { get; set; }
        [Display(Name = "Charter Customer Code")]

        public int CUS_CODE { get; set; }

        public virtual ICollection<CREW> CREW { get; set; }
        public virtual AIRCRAFT AC_NUMBERNavigation { get; set; }
        public virtual CUSTOMER CUS_CODENavigation { get; set; }
    }
}
