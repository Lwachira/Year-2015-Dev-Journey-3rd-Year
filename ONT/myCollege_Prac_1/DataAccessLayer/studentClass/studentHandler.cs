using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.studentClass
{
  public class studentHandler
    {
        public List<wpStudent> GetStudentDetails()
        {
            studentAccess sAcess = new studentAccess();
            return sAcess.GetStudentDetails();
        }

    }
}
