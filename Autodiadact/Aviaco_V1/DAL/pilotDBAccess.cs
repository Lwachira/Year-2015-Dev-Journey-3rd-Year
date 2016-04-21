using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class pilotDBAccess
    {


        public double GetTotalHours(int pilotNum)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@pilotNum",pilotNum)
            };

            dt = SqlDbHelper.ExecuteParamerizedSelectCommand("uspGetPilot", CommandType.StoredProcedure, parameters);
            return double.Parse(dt.Rows[0][0].ToString());
        }

        public List<classPilot>GetPilotDates(DateTime myDate)
        {
            List<classPilot> aDate = null;
          
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@currentDate",myDate)
            };
            using (DataTable table = SqlDbHelper.ExecuteParamerizedSelectCommand("uspPilotFlights", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    aDate = new List<classPilot>();
                    foreach (DataRow row in table.Rows)
                    {
                       classPilot cPilot = new classPilot();
                        cPilot.FullName = row["FullName"].ToString();
                        aDate.Add(cPilot);
                    }
                   
                    

                }
            }

           
            return aDate;
        }

        public classPilot GetPilot(int pilotNum)
        {
            classPilot cPilot = null;
            DataTable dt = new DataTable();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@pilotNum",pilotNum)
            };

            using (DataTable table = SqlDbHelper.ExecuteParamerizedSelectCommand("uspGetPilot", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    cPilot = new classPilot();
                    cPilot.TotalHours = Convert.ToDouble(row["TotalHours"]);
                    //cPilot.PLicense = row["PIL_LICENSE"].ToString();
                    //cPilot.Ratings = row["PIL_RATINGS"].ToString();
                    //cPilot.MedType = Convert.ToChar(row["PIL_MED_TYPE"].ToString());
                    //cPilot.MedDate = DateTime.Parse(row["PIL_PT135_DATE"].ToString());
                }
            }

            return cPilot;
        }

    }
}
