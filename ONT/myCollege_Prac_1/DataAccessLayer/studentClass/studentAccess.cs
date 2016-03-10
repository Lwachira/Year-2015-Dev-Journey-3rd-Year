using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.studentClass
{
    public class studentAccess
    {
        public List<wpStudent> GetStudentDetails()
        {
            List<wpStudent> listStudentNum = null;
            using (DataTable table = dbHelper.ExecuteSelectCommand("uspGetStudentNum", CommandType.StoredProcedure))
            {

                {
                    listStudentNum = new List<wpStudent>();
                    foreach (DataRow row in table.Rows)
                    {
                        wpStudent student = new wpStudent();
                        student.StudentNum = int.Parse(row["STU_NUM"].ToString());
                        listStudentNum.Add(student);
                    }
                }
            }
            return listStudentNum;
        }
    }
}
