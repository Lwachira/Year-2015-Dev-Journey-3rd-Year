using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer.studentClass;
using DataAccessLayer.courseClass;

namespace myCollege_Prac_1
{
    public partial class totalCredit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlStudent.Items.Clear();
            studentHandler sHandler = new studentHandler();
            ddlStudent.DataSource = sHandler.GetStudentDetails();
            ddlStudent.DataTextField = "StudentNum";
            ddlStudent.DataValueField = "StudentNum";
            ddlStudent.DataBind(); 
           
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //wpCourseClass courseClass = new wpCourseClass();
            //courseClass.StuNum = int.Parse(txtStudentNum.Text);
            //courseHandler cHandler = new courseHandler();

            //    Response.Redirect("totalCredit.aspx");
            try
            {
                courseHandler cHandler = new courseHandler();
               
                dgvCredits.DataSource = cHandler.GetStudentTotal(int.Parse(txtStudentNum.Text));
                dgvCredits.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
           

        }

        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            txtStudentNum.Text = ddlStudent.SelectedItem.Text;
        }

        protected void ddlStudent_TextChanged(object sender, EventArgs e)
        {
            
            txtStudentNum.Text = ddlStudent.SelectedItem.Text;

        }
    }
}