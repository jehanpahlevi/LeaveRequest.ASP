using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;

namespace LeaveRequest.ASP.DataAccess.Param
{
    public class EmployeeLeaveParam
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string LeaveType { get; set; }
        public int? DeductDays { get; set; }
        public int? LeaveDays { get; set; }
        public string Backup { get; set; }
        public string Note { get; set; }
        public string ApprovalStatus { get; set; }
        public int? ThisYearBefore { get; set; }
        public int? LastYearBefore { get; set; }
        public int? ThisYearAfter { get; set; }
        public int? LastYearAfter { get; set; }
        public int? DaysSpecial { get; set; }
        public DateTimeOffset? StartDateSpecial { get; set; }
        public DateTimeOffset? EndDateSpecial { get; set; }
        public EmployeeLeaveParam() { }
        public EmployeeLeaveParam(Employee employee)
        {
            this.EmployeeId = employee.Id;
            this.Name = employee.Name;
            this.Email = employee.Email;
            this.Company = employee.Departments.Companies.Name;
            this.Department = employee.Departments.Name;
            this.JobTitle = employee.JobTitle;
            this.ThisYearBefore = employee.ThisYear;
            this.LastYearBefore = employee.LastYear;
        }

    }
}
