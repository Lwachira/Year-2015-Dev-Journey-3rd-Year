using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.courseClass
{
   public class wpCourseClass
    {
        int stuNum;
        string lName;
        int crsCredit;

        
        public int StuNum
        {
            get { return stuNum; }
            set { stuNum = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }


        public int CrsCredit
        {
            get { return crsCredit; }
            set { crsCredit = value; }
        }
        
    }
}
