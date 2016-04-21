using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aviaco_V1
{
    public partial class pilotHours : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                pilotHandler pHandler = new pilotHandler();
                lblDisplay.Text = "the total number of hours flown on all charters: ";
                //ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Success')", true);
                lblDisplay.Text += pHandler.GetTotalHours(int.Parse(txtPilotID.Text)).ToString();
                lblDisplay.ForeColor = System.Drawing.Color.Red;

            }
            catch (Exception ex)
            {
                //ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Fail')", true);
                lblDisplay.Text = ex.Message;
            }
           

            //List<double> totalHours = new List<double>();
            //totalHours.Add(double.Parse(pHandler.GetPilot(int.Parse(txtPilotID.Text)).ToString()));
            //lblDisplay.Text = totalHours.ToString();

               

          
            //dgvSearchPilot.DataSource = pHandler.GetPilot(int.Parse(txtPilotID.Text));
            //dgvSearchPilot.DataBind();
            //dgvSearchPilot.Visible = true;
            
          
        }
    }
}