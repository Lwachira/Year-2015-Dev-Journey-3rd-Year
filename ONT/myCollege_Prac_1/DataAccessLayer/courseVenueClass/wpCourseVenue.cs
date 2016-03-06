using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.courseVenueClass
{
    public class wpCourseVenue
    {
        string courseCode;
        
        string crsDescription;
        string roomCode;


        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }

        public string RoomCode
        {
            get { return roomCode; }
            set { roomCode = value; }
        }

        public string CourseDescription
        {
            get { return crsDescription; }
            set { crsDescription = value; }
        }

    }
}
