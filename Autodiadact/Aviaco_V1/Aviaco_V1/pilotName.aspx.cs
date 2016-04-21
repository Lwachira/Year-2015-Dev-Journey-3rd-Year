using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aviaco_V1
{
    public partial class pilotName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btnDate_Click(object sender, EventArgs e)
        {
            pilotHandler pHandler = new pilotHandler();

            List<DateTime> myDate = new List<DateTime>();

            drpDate.DataSource = pHandler.GetPilotDates(DateTime.Parse(txtDate.Text));
            drpDate.DataTextField = "FullName";
            drpDate.DataBind();
        }
    }
}