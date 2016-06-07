using examNorthwind.BLL_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examNorthwind
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShipperHandler handler = new ShipperHandler();
            dgvShipper.DataSource = handler.GetShipperList();
            dgvShipper.DataBind();
        }
    }
}