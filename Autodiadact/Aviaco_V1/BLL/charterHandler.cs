using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public class charterHandler
    {
        charterDBAccess charterDB = null;

        public charterHandler()
        {
            charterDB = new charterDBAccess();
        }


        public bool UpdateCharter(classCharter charter)
        {
            return charterDB.UpdateCharter(charter);
        }
        public List<classCharter> GetAllCharterList()
        {
            return charterDB.GetAllCharterList();
        }

    }
}
