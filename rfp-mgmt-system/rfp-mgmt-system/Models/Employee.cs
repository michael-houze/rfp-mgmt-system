//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rfp_mgmt_system.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYEE
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeSecurityQuestion { get; set; }
        public string EmployeeSecurityAnswer { get; set; }
    
        public virtual Emp_Admin Emp_Admin { get; set; }
        public virtual EMP_LOGIN EMP_LOGIN { get; set; }

        public String createUsername()
        {
            String userName = EmployeeFirstName.Substring(0, 1) + EmployeeLastName;
            userName = userName.ToLower();
            return userName;
        }

        public String createPassword()
        {
            return "12345";
        }
    }
}
