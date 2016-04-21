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
    public partial class addCharter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAdd_Click(object sender, EventArgs e)
        {
            classCharter charter = new classCharter();
            charter.char_Trip = Convert.ToInt32(txtTrip.Text);
            charter.char_Date = DateTime.Parse(txtDate.Text);
            charter.ac_Number = txtAccountNum.Text;
            charter.char_Destination = drpDestination.Text;
            charter.char_Hours_Flown = double.Parse(txtHoursFlown.Text);
            charter.char_Hours_Wait = double.Parse(txtHoursWait.Text);
            charter.char_Fuel_Gallons = double.Parse(txtFuelGallons.Text);
            charter.char_Oil_Qts = int.Parse(txtOilQuantity.Text);
            charter.cus_Code = int.Parse(txtCusCode.Text);

            charterHandler cHandler = new charterHandler();

            if (cHandler.AddNewCharter(charter) == true)
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Fail')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Success')", true);
            }
        }
    }
}