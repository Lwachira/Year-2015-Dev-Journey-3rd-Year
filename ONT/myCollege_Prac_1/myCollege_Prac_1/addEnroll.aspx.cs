using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer.enrollClass;

namespace myCollege_Prac_1
{
    public partial class addEnroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            enrollHandler eHandler = new enrollHandler();
            table.DataSource = eHandler.GetEnrollList();
            table.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            wpEnroll enroll = new wpEnroll();

            enroll.ClassCode = txtClassCode.Text;
            enroll.StudentNum = int.Parse(txtStudentNumber.Text);
            enroll.EnrollGrade = txtGrade.Text;
            enrollHandler eHandler = new enrollHandler();
            if (eHandler.AddEnrollment(enroll) == true)
            {
                Response.Redirect("addEnroll.aspx");
            }
        }

        protected void table_Sorting(object sender, GridViewSortEventArgs e)
        {
            
        }
    }
}