using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.courseClass
{
   public class courseAccess
    {
        public List<wpCourseClass>GetStudentTotal(int stu_num)
        {
            List<wpCourseClass> listStudentTotal = null;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@stu_num",stu_num)
            };
            using (DataTable table = dbHelper.ExecuteParamerizedSelectCommand("uspTotalCredits", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    listStudentTotal = new List<wpCourseClass>();
                    foreach (DataRow row in table.Rows)
                    {
                        wpCourseClass courseClass = new wpCourseClass();
                        courseClass.StuNum = int.Parse(row["STU_NUM"].ToString());
                        courseClass.LName = row["STU_LNAME"].ToString();
                        courseClass.CrsCredit = int.Parse(row["Total Credits"].ToString());
                        listStudentTotal.Add(courseClass);
                    }

                }
            }
            return listStudentTotal;

        }

       
    }
}
