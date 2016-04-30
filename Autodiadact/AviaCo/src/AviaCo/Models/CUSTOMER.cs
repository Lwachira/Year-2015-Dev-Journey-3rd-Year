using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AviaCo.Models
{
    public partial class CUSTOMER
    {
        public CUSTOMER()
        {
            CHARTER = new HashSet<CHARTER>();
        }

        [Display(Name ="Customer Code")]
        public int CUS_CODE { get; set; }
        [Display(Name = "Customer Area Code")]

        public string CUS_AREACODE { get; set; }
        [Display(Name = "Customer Balance")]

        public decimal? CUS_BALANCE { get; set; }
        [Display(Name = "Customer First Name")]

        public string CUS_FNAME { get; set; }
        [Display(Name = "Customer Initial")]

        public string CUS_INITIAL { get; set; }
        [Display(Name = "Customer Last Name")]

        public string CUS_LNAME { get; set; }
        [Display(Name = "Customer Phone Number")]

        public string CUS_PHONE { get; set; }
        //public List<SelectListItem>CUS_Code { get; set; }
        public virtual ICollection<CHARTER> CHARTER { get; set; }
    }
}
