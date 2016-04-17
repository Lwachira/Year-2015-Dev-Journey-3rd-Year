using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class classCharter
    {
        public int char_Trip;
        public DateTime char_Date;
        public string ac_Number;
        public string char_Destination;
        public int char_Distance;
        public double char_Hours_Flown;
        public double char_Hours_Wait;
        public double char_Fuel_Gallons;
        public int char_Oil_Qts;
        public int cus_Code;


        public int Char_Trip
        {
            get { return char_Trip; }
            set { char_Trip = value; }

        }


        public DateTime Char_Date
        {
            get { return char_Date; }
            set { char_Date = value; }
        }

        public string Ac_Number
        {
            get { return ac_Number; }
            set { ac_Number = value; }
        }

        public string Char_Destination
        {
            get { return char_Destination; }
            set { char_Destination = value; }
        }

        public int Char_Distance
        {
            get { return char_Distance; }
            set { char_Distance = value; }
        }

        public double Char_Hours_Flown
        {
            get { return char_Hours_Flown; }
            set { char_Hours_Flown = value; }
        }

        public double Char_Hours_Wait
        {
            get { return char_Hours_Wait; }
            set { char_Hours_Wait = value; }
        }

        public double Char_Fuel_Gallons
        {
            get { return char_Fuel_Gallons; }
            set { char_Fuel_Gallons = value; }
        }

        public int Char_Oil_Qts
        {
            get { return char_Oil_Qts; }
            set { char_Oil_Qts = value; }
        }

        public int Cus_Code
        {
            get { return cus_Code; }
            set { cus_Code = value; }
        }
    }
}
