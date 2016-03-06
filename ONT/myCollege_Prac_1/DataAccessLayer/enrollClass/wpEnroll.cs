using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.enrollClass
{
   public class wpEnroll
    {
        string classCode;
        int studentNum;
        string enrollGrade;

        public string ClassCode
        {
            get { return classCode; }
            set { classCode = value; }
        }

        public int StudentNum
        {
            get { return studentNum; }
            set { studentNum = value; }
        }

        public string EnrollGrade
        {
            get { return enrollGrade; }
            set { enrollGrade = value; }
        }
    }
}
