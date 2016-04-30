using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AviaCo.ViewModels
{
    public class charterViewModel
    {
        public int CUS_CODE { get; set; }
        public SelectList CustomerList { get; set; }
    }
}
