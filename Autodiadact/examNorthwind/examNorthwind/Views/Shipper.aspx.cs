using examNorthwind.BLL_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examNorthwind.Views
{
    public partial class Shipper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {

                BindData();
                
            }

           

        }

        private void BindData()
        {
            ShipperHandler handler = new ShipperHandler();
            drpShipperID.DataSource = handler.GetShipperList();
            drpShipperID.DataTextField = "ShipperID";
            drpShipperID.DataValueField = "ShipperID";
            drpShipperID.DataBind();
        }

        protected void drpShipperID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
                
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
        }
    }
}