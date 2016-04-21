using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class pilotHandler
    {
        pilotDBAccess pilotDB = null;

        public pilotHandler()
        {
            pilotDB = new pilotDBAccess();
        }

        public List<classPilot> GetPilotDates(DateTime myDate)
        {
            return pilotDB.GetPilotDates(myDate);
        }

        public double GetTotalHours(int pilotNum)
        {
            return pilotDB.GetTotalHours(pilotNum);
        }


        public classPilot GetPilot(int pilotNum)
        {
            return pilotDB.GetPilot(pilotNum);
        }
    }
}
