using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class classPilot
    {
        int empNum;
        string pLicense;
        string ratings;
        char medType;
        DateTime medDate;
        DateTime pt135_Date;
        int pilotID;
        double totalHours;
        DateTime currentDate;
        string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public DateTime CurrentDate
        {
            get { return currentDate; }
            set { currentDate = value; }
        }

        public double TotalHours
        {
            get { return totalHours; }
            set { totalHours = value; }
        }

        public int PilotID
        {
            get { return pilotID; }
            set { pilotID = value; }
        }

        public int EmpNum
        {
            get { return empNum; }
            set { empNum = value; }
        }

        public string PLicense
        {
            get { return pLicense; }
            set { pLicense = value; }

        }

        public string Ratings
        {
            get { return ratings; }
            set { ratings = value; }
        }

        public  char MedType
        {
            get { return medType; }
            set { medType = value; }
        }

        public DateTime MedDate
        {
            get { return medDate; }
            set { medDate = value; }
        }

        public DateTime Pt135_Date
        {
            get { return pt135_Date; }
            set { pt135_Date = value; }
        }
    }
}
