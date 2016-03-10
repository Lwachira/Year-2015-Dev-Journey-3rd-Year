using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.studentClass
{
   public class wpStudent
    {
        int STU_NUM;

        public int StudentNum
        {
            get { return STU_NUM; } 
            set { STU_NUM = value; }
        }
    }
}
