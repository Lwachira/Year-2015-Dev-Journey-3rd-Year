using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace DataAccessLayer.enrollClass
{
  public  class enrollAccess
    {
        public bool AddEnrollment(wpEnroll enroll)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {

                new SqlParameter("@ccode",enroll.ClassCode),
                new SqlParameter("@snum",enroll.StudentNum),
                new SqlParameter("@grade",enroll.EnrollGrade)
            };
            return dbHelper.ExecuteNonQuery("[uspAddEnrollment]", System.Data.CommandType.StoredProcedure, parameters);
        }

        public List<wpEnroll> GetEnrollList()
        {
            List<wpEnroll> enrollList = null;
            using (DataTable table = dbHelper.ExecuteSelectCommand("[uspGetEnroll]", System.Data.CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    enrollList = new List<wpEnroll>();
                    foreach (DataRow row in table.Rows)
                    {
                        wpEnroll myEnroll = new wpEnroll();
                        myEnroll.ClassCode = row["CLASS_CODE"].ToString();
                        myEnroll.StudentNum = Convert.ToInt32(row["STU_NUM"]);
                        myEnroll.EnrollGrade = row["ENROLL_GRADE"].ToString();
                        enrollList.Add(myEnroll);
                    }
                }

                return enrollList;
            }
        }
    }

}
