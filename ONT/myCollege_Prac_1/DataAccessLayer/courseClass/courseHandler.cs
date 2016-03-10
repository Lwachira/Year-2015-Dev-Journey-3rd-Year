using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.courseClass
{
   public class courseHandler
    {

        courseAccess cAccess = null;

        public courseHandler()
        {
            cAccess = new courseAccess();
        }

        public  List<wpCourseClass> GetStudentTotal(int stu_num)
        {
            return cAccess.GetStudentTotal(stu_num);
        }
    }
}
