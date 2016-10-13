
using System;
using System.Collections.Generic;

namespace AngularStoredProc.Models
{
    public partial class t_Student
    {
        public int Student_Id { get; set; }
        public string Student_FirstName { get; set; }
        public string Student_LastName { get; set; }
        public string Student_Email { get; set; }
        public string Student_Address { get; set; }
        public System.DateTime Student_EnrollmentDate { get; set; }
        public int Student_DepartmentId { get; set; }
    }
}