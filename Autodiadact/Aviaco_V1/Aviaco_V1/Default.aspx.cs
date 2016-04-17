using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

namespace Aviaco_V1
{
    public partial class _Default : Page
    {
        charterHandler cHandler = new charterHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsPostBack == false)
            {
                this.BindGrid();


            }
        }


        private void BindGrid()
        {
            List<classCharter> charter = cHandler.GetAllCharterList();
            dgvCharter.DataSource = charter;
            dgvCharter.DataBind();
        }

        protected void dgvCharter_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgvCharter.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }

        protected void dgvCharter_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {

            dgvCharter.EditIndex = -1;
            this.BindGrid();
        }

        protected void dgvCharter_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgvCharter.EditIndex = -1;
           this.BindGrid();

        }

        protected void dgvCharter_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblTrip = dgvCharter.Rows[e.RowIndex].FindControl("lblTrip") as Label;
            TextBox txtDate = dgvCharter.Rows[e.RowIndex].FindControl("txtDate") as TextBox;
            TextBox txtNumber = dgvCharter.Rows[e.RowIndex].FindControl("txtNumber") as TextBox;
            TextBox txtDestination = dgvCharter.Rows[e.RowIndex].FindControl("txtDestination") as TextBox;
            TextBox txtDistance = dgvCharter.Rows[e.RowIndex].FindControl("txtDistance") as TextBox;
            TextBox txtHoursFlown = dgvCharter.Rows[e.RowIndex].FindControl("txtHoursFlown") as TextBox;
            TextBox txtHoursWait = dgvCharter.Rows[e.RowIndex].FindControl("txtHoursWait") as TextBox;
            TextBox txtFuelGallons = dgvCharter.Rows[e.RowIndex].FindControl("txtFuelGallons") as TextBox;
            TextBox txtOil_Qts = dgvCharter.Rows[e.RowIndex].FindControl("txtOil_Qts") as TextBox;
            TextBox txtcust_Code = dgvCharter.Rows[e.RowIndex].FindControl("txtcust_Code") as TextBox;

            if (lblTrip != null && txtDate != null && txtNumber != null && txtDestination != null && txtDistance != null 
                
                && txtHoursFlown != null && txtHoursWait != null && txtFuelGallons != null && txtOil_Qts != null && txtcust_Code != null)
            {

                classCharter charter = new classCharter();
                charter.char_Trip = Convert.ToInt32(lblTrip.Text.Trim());
                charter.char_Date = DateTime.Parse( txtDate.Text);
                charter.ac_Number = txtNumber.Text;
                charter.char_Destination = txtDestination.Text;
                charter.char_Distance = int.Parse(txtDistance.Text);
                charter.char_Hours_Flown = double.Parse(txtHoursFlown.Text);
                charter.char_Hours_Wait = double.Parse( txtHoursWait.Text);
                charter.char_Fuel_Gallons = double.Parse( txtFuelGallons.Text);
                charter.char_Oil_Qts = int.Parse(txtOil_Qts.Text);
                charter.cus_Code = int.Parse( txtOil_Qts.Text);

                if (cHandler.UpdateCharter(charter) == true)
                {
                    lblResult.Text = "Success";
                }
                else
                {
                    lblResult.Text = "Fail";
                }

                dgvCharter.EditIndex = -1;
               this.BindGrid();

            }
            else
            {
                lblResult.Text = "It not working";
            }

        }
    }
}