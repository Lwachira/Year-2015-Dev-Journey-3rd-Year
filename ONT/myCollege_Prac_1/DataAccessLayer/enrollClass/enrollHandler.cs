using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.enrollClass
{
   public class enrollHandler
    {
        enrollAccess eAccess = null;
        public enrollHandler()
        {
            eAccess = new enrollAccess();
        }


        public bool AddEnrollment(wpEnroll enroll)
        {
            return eAccess.AddEnrollment(enroll);
        }


        public List<wpEnroll> GetEnrollList()
        {
            return eAccess.GetEnrollList();
        }
    }
}
