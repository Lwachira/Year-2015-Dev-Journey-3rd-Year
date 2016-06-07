using examNorthwind.DAL_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examNorthwind.BLL_Code
{
    class ShipperHandler
    {

        ShipperDBAccess shipperDB = null;

        public ShipperHandler()
        {
            shipperDB = new ShipperDBAccess();
        } 

        public List<Shippers>GetShipperList()
        {
            return shipperDB.GetShipperList();
        }

        public Shippers GetShipperDetails(int shipperID)
        {
            return shipperDB.GetShipperDetails(shipperID);
        }

        public bool AddNewShipper(Shippers shipper)
        {
            return shipperDB.AddNewShipper(shipper);
        }

        public bool UpdateShipper(Shippers shipper)
        {
            return shipperDB.UpdateShipper(shipper);
        }

        public bool DeleteShipper(int shipperID)
        {
            return shipperDB.DeleteShipper(shipperID);
        }
    }
}
