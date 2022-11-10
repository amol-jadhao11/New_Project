using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace New_Project.ViewModel
{
    public  class EmployeeViewModel
    {

        public int EmpID { get; set; }

        [Required(ErrorMessage = "Employee Name is Mandaroty")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Employee Designation is Mandaroty")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Employee Department is Mandaroty")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Employee JoiningDate is Mandaroty")]
        public Nullable<System.DateTime> JoiningDate { get; set; }
    }
}