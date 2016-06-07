using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examNorthwind.DAL_Code
{
   public class ShipperDBAccess
    {
        public ShipperDBAccess()
        {

        }

        public bool AddNewShipper(Shippers shipper)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CompanyName",shipper.CompanyName),
                new SqlParameter("@Phone",shipper.Phone)
            };
            return DBHelper.ExecuteNonQuery("uspInsertShipper", System.Data.CommandType.StoredProcedure, parameters);
        }

        public bool UpdateShipper(Shippers shipper)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ShipperID",shipper.ShipperID),
                new SqlParameter("@CompanyName",shipper.CompanyName),
                new SqlParameter("@Phone",shipper.Phone)
            };
            return DBHelper.ExecuteNonQuery("uspUpdateShipper", System.Data.CommandType.StoredProcedure, parameters);
        }

        public bool DeleteShipper(int shipperID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("ShipperID",shipperID)
            };
            return DBHelper.ExecuteNonQuery("uspDeleterShipper", System.Data.CommandType.StoredProcedure, parameters);
        }

        public Shippers GetShipperDetails(int shipperID)
        {
            Shippers shipper = null;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ShipperID",shipperID)
            };
            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("uspReturnShipper", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    shipper = new Shippers();
                   // shipper.ShipperID = Convert.ToInt32(row["ShipperID"]);
                    shipper.CompanyName = row["CompanyName"].ToString();
                    shipper.Phone = row["Phone"].ToString();
                }
            }
            return shipper;
        }

        public List<Shippers> GetShipperList()
        {
            List<Shippers> shipperList = null;
            using (DataTable table = DBHelper.ExecuteSelectCommand("uspReturnAllShippers", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    shipperList = new List<Shippers>();
                    foreach (DataRow row in table.Rows)
                    {
                        Shippers shipper = new Shippers();
                        shipper.ShipperID = Convert.ToInt32(row["ShipperID"]);
                        shipper.CompanyName = row["CompanyName"].ToString();
                        shipper.Phone = row["Phone"].ToString();
                        shipperList.Add(shipper);
                    }
                }
            }

            return shipperList;
           

            
        }

    }
}
