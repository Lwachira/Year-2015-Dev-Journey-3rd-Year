using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.courseVenueClass
{
  public  class courseVenueHandler
    {
        courseVenueAccess cVenueAccess = null;

        public courseVenueHandler()
        {
            cVenueAccess = new courseVenueAccess();
        }

        public wpCourseVenue GetCourseDetails(string course)
        {
            return cVenueAccess.GetCourseDetails(course);
        }

        public List<wpCourseVenue> GetCourseList(string course)
        {
            return cVenueAccess.GetCourseList(course);
        }
    }
}
