using DataAccessLayer.courseVenueClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myCollege_Prac_1
{
    public partial class courseVenue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            courseVenueHandler cVenueHandler = new courseVenueHandler();
            table.DataSource = cVenueHandler.GetCourseList("ACCT-211");
            table.DataBind();
        }
    }
}