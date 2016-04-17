using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class charterDBAccess
    {

        public bool UpdateCharter(classCharter charter)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@TRIP", charter.char_Trip),
            new SqlParameter("@DATE", charter.char_Date),
            new SqlParameter("@NUMBER", charter.ac_Number),
            new SqlParameter("@DESTINATION", charter.char_Destination),
            new SqlParameter("@DISTANCE", charter.char_Distance),
            new SqlParameter("@HOURS_FLOWN", charter.char_Hours_Flown),
            new SqlParameter("@HOURS_WAIT", charter.char_Hours_Wait),
            new SqlParameter("@FUEL_GALLONS", charter.char_Fuel_Gallons),
            new SqlParameter("@OIL_QTS", charter.char_Oil_Qts),
            new SqlParameter("@Customer_CODE", charter.cus_Code)
            };

            return SqlDbHelper.ExecuteNonQuery("uspUpdateCharter", CommandType.StoredProcedure, parameters);
        }


        public List<classCharter> GetAllCharterList()
        {
            List<classCharter> listCharter = null;
            using (DataTable table = SqlDbHelper.ExecuteSelectCommand("GetAllCharter",CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    listCharter = new List<classCharter>();
                    foreach (DataRow row in table.Rows)
                    {
                        classCharter charter = new classCharter();
                        charter.char_Trip = Convert.ToInt32(row["CHAR_TRIP"]);
                        charter.char_Date = DateTime.Parse(row["CHAR_DATE"].ToString());
                        charter.ac_Number = row["AC_NUMBER"].ToString();
                        charter.char_Destination = row["CHAR_DESTINATION"].ToString();
                        charter.char_Distance = int.Parse(row["CHAR_DISTANCE"].ToString());
                        charter.char_Hours_Flown = Convert.ToDouble(row["CHAR_HOURS_FLOWN"]);
                        charter.char_Hours_Wait = Convert.ToDouble(row["CHAR_HOURS_WAIT"]);
                        charter.char_Fuel_Gallons = Convert.ToDouble(row["CHAR_FUEL_GALLONS"]);
                        charter.char_Oil_Qts = Convert.ToInt32(row["CHAR_OIL_QTS"]);
                        charter.cus_Code = Convert.ToInt32(row["CUS_CODE"]);

                        listCharter.Add(charter);
                    }
                }
            }

            return listCharter;
        } 
    }
}
